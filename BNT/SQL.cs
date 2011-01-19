using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.Drawing;

namespace BNT
{
    public class SQL
    {
        SqlCeConnection cn = new SqlCeConnection("Data Source=..\\..\\Baza_BNT.sdf;Persist Security Info=False;");

        ~SQL()
        {
            cn.Close();
        }
        
        public SQL()
        {
            cn.Open();
        }

        private SqlCeDataReader Zapytanie(string zapytanie)
        {
            SqlCeDataReader rdr;

            using (SqlCeCommand cmd = new SqlCeCommand(zapytanie, cn))
                rdr = cmd.ExecuteReader();

            return rdr;
        }

        public void DodajMiasto(string nazwa, Point wspolrzedne)
        {
            string zapytanie = "INSERT INTO miasta (nazwa, wsp_x, wsp_y) VALUES ('"+nazwa+"','"+wspolrzedne.X.ToString()+"','"+wspolrzedne.Y.ToString()+"')";
            Zapytanie(zapytanie);
        }

        public string[][] CzytajMiasta()
        {
            List<string[]> tablica = new List<string[]>();

            string zapytanie = "SELECT nazwa, wsp_x, wsp_y FROM miasta";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
            {
                string[] s = new string[3];
                s[0] = rdr[0].ToString();
                s[1] = rdr[1].ToString();
                s[2] = rdr[2].ToString();
                tablica.Add(s);
            }

            return tablica.ToArray();
        }

        public int[] Ilosci(string miasto)
        {
            List<int> tablica = new List<int>();

            //ilosc slupow
            string zapytanie = "SELECT COUNT(*) as howmany FROM miasta LEFT JOIN slupy ON miasta.id=slupy.id_miasta WHERE miasta.nazwa='"+miasto+"'";
            SqlCeDataReader rdr = Zapytanie(zapytanie);

            while (rdr.Read())
                tablica.Add(Int32.Parse(rdr[0].ToString()));
            
            //ilosc nadajnikow
            zapytanie = "SELECT COUNT(*) as howmany FROM miasta, slupy, nadajniki WHERE miasta.id=slupy.id_miasta AND slupy.id=nadajniki.id_slupu "+
                "AND miasta.nazwa='" + miasto + "'";
            rdr = Zapytanie(zapytanie);

            while (rdr.Read())
                tablica.Add(Int32.Parse(rdr[0].ToString()));

            //ilosc firm
            zapytanie = "SELECT COUNT(*) as howmany FROM miasta, slupy, nadajniki, firmy WHERE miasta.id=slupy.id_miasta AND slupy.id=nadajniki.id_slupu " +
                "AND nadajniki.id_firmy=firmy.id AND miasta.nazwa='" + miasto + "'";
            rdr = Zapytanie(zapytanie);

            while (rdr.Read())
                tablica.Add(Int32.Parse(rdr[0].ToString()));

            return tablica.ToArray();
        }

        //TODO jak wychiagnac jeszcze firmy?
        public string[][] CzytajSlupy() 
        {
            List<string[]> tablica = new List<string[]>();
            List<string> tabId = new List<string>(); //zapisanie tutaj idikow po kolei
            
            string zapytanie = "SELECT slupy.id, miasta.nazwa, slupy.wsp_x, slupy.wsp_y, slupy.cena FROM slupy, miasta WHERE slupy.id_miasta=miasta.id";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
            {
                string[] s = new string[5];
                tabId.Add(rdr[0].ToString());
                s[0] = rdr[1].ToString();
                s[1] = rdr[2].ToString()+";"+rdr[3].ToString(); //wspolrzedne x i y w jednej kolumnie beda
                s[2] = rdr[4].ToString() + " zł";
                
                tablica.Add(s);
            }

            for (int i = 0; i < tabId.Count; ++i)
            {
                string zapytanieFirmy = "SELECT firmy.nazwa FROM firmy, nadajniki WHERE firmy.id IN (SELECT nadajniki.id_firmy FROM nadajniki WHERE nadajniki.id_slupu=" + tabId[i] + ") GROUP BY firmy.nazwa";
                rdr = Zapytanie(zapytanieFirmy);
                string firmy = "";
                while (rdr.Read())
                {
                    firmy += rdr[0].ToString() + ", ";
                }

                if (firmy.Length > 0) //zapisanie firm
                    tablica[i][3] = firmy.Remove(firmy.Length - 2); //usuniecie ostatniej spacji i zapisanie firm do tablicy
                else
                    tablica[i][3] = "Nikt nie dzierżawi";

                //zapisanie ceny
                if (firmy.Length > 0)
                    tablica[i][4] = (float.Parse(tablica[i][2].Remove(tablica[i][2].Length - 3)) * (firmy.Split(',').Length - 1)).ToString() + " zł";
                else
                    tablica[i][4] = "0";
            }

            return tablica.ToArray();
        }

        public string[] CzytajFirmy()
        {
            List<string> tablica = new List<string>();
            string zapytanie = "SELECT nazwa FROM firmy";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
            {
                string s = rdr[0].ToString();
                tablica.Add(s);
            }
            return tablica.ToArray();
        }

        public string[][] CzytajFaktury(string nazwaFirmy)
        {
            int licznik = 1;
            List<string[]> tablica = new List<string[]>();
            for (int rok = 2008; rok <= DateTime.Now.Year; rok++)
            {
                for (int miesiac = 1; miesiac <= 12; miesiac++)
                {
                    string[] s = new string[4];
                    s[0] = licznik.ToString();
                    s[1] = CzytajNajpozniejszaDateZaplaty(nazwaFirmy,miesiac,rok);
                    if (s[1] == null)
                        continue;
                    s[2] = float.Parse(CzytajKwoteMiesieczna(nazwaFirmy,miesiac,rok)).ToString("F") + " zł";
                    s[3] = "Pokaż";
                    tablica.Add(s);
                    licznik++;
                }
            }
            return tablica.ToArray();
        }

        private string CzytajKwoteMiesieczna(string nazwaFirmy, int numerMiesiaca, int numerRoku)
        {
            float cena = 0;
            string zapytanie = "SELECT DISTINCT slupy.cena, slupy.id FROM slupy LEFT OUTER JOIN nadajniki ON slupy.id = nadajniki.id_slupu LEFT OUTER JOIN faktury ON nadajniki.id_faktury = faktury.id LEFT OUTER JOIN firmy ON nadajniki.id_firmy = firmy.id WHERE (firmy.nazwa = '" + nazwaFirmy + "')";
            SqlCeDataReader rdr = Zapytanie(zapytanie);

            while (rdr.Read())
                cena += float.Parse(rdr[0].ToString());


            zapytanie = "SELECT SUM(modele.cena * nadajniki.ilosc) FROM faktury LEFT OUTER JOIN nadajniki ON nadajniki.id_faktury = faktury.id LEFT OUTER JOIN firmy ON firmy.id = nadajniki.id_firmy LEFT OUTER JOIN modele ON modele.id = nadajniki.id_modelu WHERE (firmy.nazwa = '" + nazwaFirmy + "') AND (faktury.data_zaplaty BETWEEN '" + numerRoku + "-" + numerMiesiaca + "-01' AND '" + numerRoku + "-" + numerMiesiaca + "-" + DateTime.DaysInMonth(numerRoku,numerMiesiaca) + "')";
            rdr = Zapytanie(zapytanie);

            if (rdr.Read())
            {
                if (rdr[0].ToString() == "")
                    return null;
                else
                    cena += float.Parse(rdr[0].ToString());
            }

            zapytanie = "SELECT faktury.wartosc FROM faktury LEFT OUTER JOIN nadajniki ON nadajniki.id_faktury = faktury.id LEFT OUTER JOIN firmy ON " +
                "firmy.id = nadajniki.id_firmy WHERE (firmy.nazwa = '" + nazwaFirmy + "') AND (faktury.data_zaplaty BETWEEN '" + numerRoku + "-" + 
                numerMiesiaca + "-01' AND '" + numerRoku + "-" + numerMiesiaca + "-" + DateTime.DaysInMonth(numerRoku, numerMiesiaca) + 
                "') ORDER BY faktury.data_zaplaty DESC";
            rdr = Zapytanie(zapytanie);

            if (rdr.Read())
                cena *= float.Parse(rdr[0].ToString());


            return cena.ToString();

        }

        private string CzytajNajpozniejszaDateZaplaty(string nazwaFirmy, int numerMiesiaca, int numerRoku)
        {
            string zapytanie = "SELECT faktury.data_zaplaty FROM faktury LEFT OUTER JOIN nadajniki ON nadajniki.id_faktury = faktury.id " +
                "LEFT OUTER JOIN firmy ON firmy.id = nadajniki.id_firmy WHERE (firmy.nazwa = '" + nazwaFirmy + "') AND (faktury.data_zaplaty BETWEEN '" +
                numerRoku + "-" + numerMiesiaca + "-01' AND '" + numerRoku + "-" + numerMiesiaca + "-" + DateTime.DaysInMonth(numerRoku, numerMiesiaca) + 
                "') ORDER BY faktury.data_zaplaty DESC";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            if (rdr.Read())
                return rdr[0].ToString().Substring(0, 10);
            return null;
        }

    }
}

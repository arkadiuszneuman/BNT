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
        public string[][] CzytajNadajniki() 
        {
            List<string[]> tablica = new List<string[]>();

            string zapytanie = "SELECT miasta.nazwa, slupy.wsp_x, slupy.wsp_y, slupy.cena FROM slupy, miasta WHERE slupy.id_miasta=miasta.id";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
            {
                string[] s = new string[3];
                s[0] = rdr[0].ToString();
                s[1] = rdr[1].ToString()+";"+rdr[2].ToString();
                s[2] = rdr[3].ToString();
                tablica.Add(s);
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

        public string[][] CzytajFakture(string nazwaFirmy)
        {
            List<string[]> tablica = new List<string[]>();
            for (int rok = 2008; rok <= DateTime.Now.Year; rok++)
            {
                for (int miesiac = 1; miesiac <= 12; miesiac++)
                {
                    string[] s = new string[3];
                    s[0] = CzytajNajpozniejszaDateZaplaty(nazwaFirmy,miesiac,rok);
                    s[1] = CzytajKwoteMiesieczna(nazwaFirmy,miesiac,rok);
                    s[2] = "Przycisk";
                    tablica.Add(s);
                }
            }
            return tablica.ToArray();
        }

        public int DzienMiesiaca(int miesiac, int rok)
        {
            switch (miesiac)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (rok % 4 == 0)
                        return 28;
                    else
                        return 29;
                default:
                    return 31;
            }
        }

        public string CzytajKwoteMiesieczna(string nazwaFirmy, int numerMiesiaca, int numerRoku)
        {
            string zapytanie = "SELECT SUM((slupy.cena + modele.cena * nadajniki.ilosc) * faktury.wartosc) AS ILOSC FROM faktury LEFT OUTER JOIN nadajniki ON nadajniki.id_faktury = faktury.id LEFT OUTER JOIN firmy ON firmy.id = nadajniki.id_firmy LEFT OUTER JOIN slupy ON slupy.id = nadajniki.id_slupu LEFT OUTER JOIN modele ON modele.id = nadajniki.id_modelu WHERE (firmy.nazwa = '" + nazwaFirmy + "') AND (faktury.data_zaplaty BETWEEN '" + numerRoku + "-" + numerMiesiaca + "-01' AND '" + numerRoku + "-" + numerMiesiaca + "-" + DzienMiesiaca(numerMiesiaca,numerRoku) + "')";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            if(rdr.Read())
                return rdr[0].ToString();
            else
                return null;
        }

        public string CzytajNajpozniejszaDateZaplaty(string nazwaFirmy, int numerMiesiaca, int numerRoku)
        {
            string zapytanie = "SELECT MAX(faktury.data_zaplaty) AS DATA FROM faktury LEFT OUTER JOIN nadajniki ON nadajniki.id_faktury = faktury.id LEFT OUTER JOIN firmy ON firmy.id = nadajniki.id_firmy WHERE (firmy.nazwa = '" + nazwaFirmy + "') AND (faktury.data_zaplaty BETWEEN '" + numerRoku + "-" + numerMiesiaca + "-01' AND '" + numerRoku + "-" + numerMiesiaca + "-" + DzienMiesiaca(numerMiesiaca, numerRoku) + "')";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            if (rdr.Read())
                return rdr[0].ToString();
            else
                return null;
        }

    }
}

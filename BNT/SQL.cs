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
            SqlCeDataReader rdr = null;

            using (SqlCeCommand cmd = new SqlCeCommand(zapytanie, cn))
            {
                rdr = cmd.ExecuteReader();
            }

            return rdr;
        }

        public void DodajMiasto(string nazwa, Point wspolrzedne)
        {
            string zapytanie = "INSERT INTO miasta (nazwa, wsp_x, wsp_y) VALUES ('"+nazwa+"','"+wspolrzedne.X.ToString()+"','"+wspolrzedne.Y.ToString()+"')";
            Zapytanie(zapytanie);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="czyWsp">czy zwracac wspolrzedne</param>
        /// <returns></returns>
        public string[][] CzytajMiasta(bool czyWsp)
        {
            List<string[]> tablica = new List<string[]>();

            string zapytanie = "SELECT nazwa";
            if (czyWsp)
                zapytanie += ", wsp_x, wsp_y";
            zapytanie += " FROM miasta";
            
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
            {
                string[] s;
                if (czyWsp)
                    s = new string[3];
                else
                    s = new string[1];

                s[0] = rdr[0].ToString();
                if (czyWsp)
                {
                    s[1] = rdr[1].ToString();
                    s[2] = rdr[2].ToString();
                }
                tablica.Add(s);
            }

            return tablica.ToArray();
        }

        public int[] Ilosci(string miasto)
        {
            List<int> tablica = new List<int>();

            //ilosc slupow
            string zapytanie = "SELECT COUNT(*) as howmany FROM miasta RIGHT JOIN slupy ON miasta.id=slupy.id_miasta WHERE miasta.nazwa='"+miasto+"'";
            SqlCeDataReader rdr = Zapytanie(zapytanie);

            while (rdr.Read())
                tablica.Add(Convert.ToInt16(rdr[0]));
            
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

        public string[][] CzytajSlupy() 
        {
            List<string[]> tablica = new List<string[]>();
            //List<string> tabId = new List<string>(); //zapisanie tutaj idikow po kolei
            
            string zapytanie = "SELECT slupy.id, miasta.nazwa, slupy.wsp_x, slupy.wsp_y, slupy.cena FROM slupy, miasta WHERE slupy.id_miasta=miasta.id";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
            {
                string[] s = new string[6];
                s[0] = rdr[0].ToString();
                s[1] = rdr[1].ToString();
                s[2] = rdr[2].ToString()+";"+rdr[3].ToString(); //wspolrzedne x i y w jednej kolumnie beda
                s[3] = rdr[4].ToString() + " zł";
                
                tablica.Add(s);
            }
            
            for (int i = 0; i < tablica.Count; ++i)
            {
                string zapytanieFirmy = "SELECT firmy.nazwa FROM firmy, nadajniki WHERE firmy.id IN (SELECT nadajniki.id_firmy FROM nadajniki WHERE nadajniki.id_slupu=" + tablica[i][0] + ") GROUP BY firmy.nazwa";
                rdr = Zapytanie(zapytanieFirmy);
                string firmy = "";
                try
                {
                    while (rdr.Read())
                    {
                        firmy += rdr[0].ToString() + ", ";
                    }
                }
                catch (SqlCeLockTimeoutException)
                {
                    MessageBox.Show("Przekroczono limit czasu");
                    return tablica.ToArray();
                }

                if (firmy.Length > 0) //zapisanie firm
                    tablica[i][4] = firmy.Remove(firmy.Length - 2); //usuniecie ostatniej spacji i zapisanie firm do tablicy
                else
                    tablica[i][4] = "Nikt nie dzierżawi";

                //zapisanie ceny
                if (firmy.Length > 0)
                    tablica[i][5] = (float.Parse(tablica[i][3].Remove(tablica[i][3].Length - 3)) * (firmy.Split(',').Length - 1)).ToString() + " zł";
                else
                    tablica[i][5] = "0 zł";
            }

            return tablica.ToArray();
        }

        public string[] CzytajSlupy(bool czyTylkoSlupIMiasto)
        {
            List<string> tablica = new List<string>();
            string zapytanie = "SELECT slupy.id, miasta.nazwa FROM slupy, miasta WHERE slupy.id_miasta=miasta.id ORDER BY slupy.id";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
            {
                string s = rdr[0].ToString() + " (" + rdr[1].ToString() + ")";

                tablica.Add(s);
            }

            return tablica.ToArray();
        }

        public void DodajSlup(string miasto, Point wsp, decimal cena)
        {
            string zapytanie = "INSERT INTO slupy (wsp_x, wsp_y, cena, id_miasta) SELECT " 
                + wsp.X + ", " + wsp.Y + ", " + cena.ToString().Replace(',', '.') + ", id FROM miasta WHERE (miasta.nazwa = '" + miasto + "')";
            Zapytanie(zapytanie);
        }

        public void EdytujSlup(int id, string miasto, Point wsp, decimal cena)
        {
            //string zapytanie = "UPDATE slupy SET wsp_x=" + wsp.X + ", wsp_y=" + wsp.Y + ", cena="
            //    + cena.ToString().Replace(',', '.') + ", id_miasta=(SELECT id FROM miasta WHERE nazwa='"+miasto+"') WHERE id="+id+"";

            string zapytanie = "SELECT id FROM miasta WHERE nazwa='" + miasto + "'";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
                zapytanie = "UPDATE slupy SET wsp_x='" + wsp.X + "', wsp_y='" + wsp.Y + "', cena='"
                    + cena.ToString().Replace(',', '.') + "', id_miasta='"+rdr[0].ToString()+"' WHERE id="+id+"";
            Zapytanie(zapytanie);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true jesli usuniety, false jesli istnieje nadajnik na tym slupie</returns>
        public bool UsunSlup(int id)
        {
            string zapytanie = "SELECT COUNT(*) as howmany FROM nadajniki WHERE nadajniki.id_slupu="+id+"";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
            {
                if (Convert.ToInt32(rdr[0]) > 0)
                {
                    return false; //wyswietlic messageboxa
                }
            }

            zapytanie = "DELETE FROM slupy WHERE id="+id+"";
            Zapytanie(zapytanie);
            return true;
        }

        public string[][] CzytajNadajniki()
        {
            List<string[]> tablica = new List<string[]>();
           
            string zapytanie = "SELECT nadajniki.id, firmy.nazwa, nadajniki.id_slupu, modele.nazwa, nadajniki.ilosc FROM nadajniki LEFT JOIN firmy ON nadajniki.id_firmy=firmy.id JOIN modele ON nadajniki.id_modelu=modele.id";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
            {
                string[] s = new string[5];
                s[0] = rdr[0].ToString();
                s[1] = rdr[1].ToString();
                s[2] = rdr[2].ToString();
                s[3] = rdr[3].ToString();
                s[4] = rdr[4].ToString();

                tablica.Add(s);
            }


            return tablica.ToArray();
        }

        public void DodajNadajnik(int slup, string model, int ilosc)
        {
            //string zapytanie = "INSERT INTO nadajniki (id_slupu, id_modelu, ilosc) VALUES ('" + slup + "','" + model + "','" + ilosc + "')";
            string zapytanie = "INSERT INTO nadajniki (id_slupu, ilosc, id_modelu) SELECT "
                + slup + ", "+ ilosc + ", id FROM modele WHERE (modele.nazwa = '" + model + "')";

            Zapytanie(zapytanie);
        }

        public void EdytujNadajnik(int id, int slup, string model, int ilosc)
        {
            string zapytanie = "SELECT id FROM modele WHERE nazwa='" + model + "'";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
                zapytanie = "UPDATE nadajniki SET id_slupu='" + slup + "', id_modelu='" + rdr[0].ToString() + "', ilosc='"
                    + ilosc + "' WHERE id=" + id + "";
            Zapytanie(zapytanie);
        }

        public bool UsunNadajnik(int id)
        {
            string zapytanie = "DELETE FROM nadajniki WHERE id=" + id + "";
            Zapytanie(zapytanie);
            return true;
        }

        public string[][] CzytajModele(bool czyTylkoNazwy)
        {
            List<string[]> tablica = new List<string[]>();
            //List<string> tabId = new List<string>(); //zapisanie tutaj idikow po kolei

            string zapytanie = null;
            if (!czyTylkoNazwy)
                zapytanie = "SELECT * FROM modele";
            else
                zapytanie = "SELECT nazwa FROM modele ORDER BY nazwa";

            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
            {
                string[] s;
                if (!czyTylkoNazwy)
                    s = new string[4];
                else
                    s = new string[1];
                s[0] = rdr[0].ToString();
                if (!czyTylkoNazwy)
                {
                    s[1] = rdr[1].ToString();
                    s[2] = rdr[2].ToString();
                    s[3] = rdr[3].ToString() + " zł";
                }

                tablica.Add(s);
            }


            return tablica.ToArray();
        }

        public void DodajModel(string nazwa, int zasieg, decimal cena)
        {
            string zapytanie = "INSERT INTO modele (nazwa, zasieg, cena) VALUES ('"+nazwa+"','"+zasieg+"','"+cena.ToString().Replace(',', '.')+"')";
            Zapytanie(zapytanie);
        }

        public void EdytujModel(int id, string nazwa, int zasieg, decimal cena)
        {
            string zapytanie = "UPDATE modele SET nazwa='" + nazwa + "', zasieg='" + zasieg + "', cena='" + cena.ToString().Replace(',', '.') + "' WHERE id='"+id+"'";

            Zapytanie(zapytanie);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true jesli usuniety, false jesli istnieje nadajnik na tym slupie</returns>
        public bool UsunModel(int id)
        {
            /*string zapytanie = "SELECT COUNT(*) as howmany FROM nadajniki WHERE nadajniki.id_slupu=" + id + "";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
            {
                if (Convert.ToInt32(rdr[0]) > 0)
                {
                    return false; //wyswietlic messageboxa
                }
            }*/

            string zapytanie = "DELETE FROM modele WHERE id=" + id + "";
            Zapytanie(zapytanie);
            return true;
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

        private int DzienMiesiaca(int miesiac, int rok)
        {
            switch (miesiac)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if ((rok % 4) == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 31;
            }
        }

        private string CzytajKwoteMiesieczna(string nazwaFirmy, int numerMiesiaca, int numerRoku)
        {
            string zapytanie = "SELECT SUM((slupy.cena + modele.cena * nadajniki.ilosc) * faktury.wartosc) AS ILOSC FROM faktury LEFT OUTER JOIN nadajniki ON nadajniki.id_faktury = faktury.id LEFT OUTER JOIN firmy ON firmy.id = nadajniki.id_firmy LEFT OUTER JOIN slupy ON slupy.id = nadajniki.id_slupu LEFT OUTER JOIN modele ON modele.id = nadajniki.id_modelu WHERE (firmy.nazwa = '" + nazwaFirmy + "') AND (faktury.data_zaplaty BETWEEN '" + numerRoku + "-" + numerMiesiaca + "-01' AND '" + numerRoku + "-" + numerMiesiaca + "-" + DzienMiesiaca(numerMiesiaca,numerRoku) + "')";
            SqlCeDataReader rdr = Zapytanie(zapytanie);

            // cenę słupa trzeba brać jednorazowo, a nie za każdy model, trzeba dopisać jeszcze jedno zapytanie

            if (rdr.Read())
            {
                if (rdr[0].ToString() == "")
                    return null;
                else
                    return rdr[0].ToString();
            }
            else
                return "Błąd: Złe zapytanie.";
        }

        private string CzytajNajpozniejszaDateZaplaty(string nazwaFirmy, int numerMiesiaca, int numerRoku)
        {
            string zapytanie = "SELECT MAX(faktury.data_zaplaty) AS DATA FROM faktury LEFT OUTER JOIN nadajniki ON nadajniki.id_faktury = faktury.id LEFT OUTER JOIN firmy ON firmy.id = nadajniki.id_firmy WHERE (firmy.nazwa = '" + nazwaFirmy + "') AND (faktury.data_zaplaty BETWEEN '" + numerRoku + "-" + numerMiesiaca + "-01' AND '" + numerRoku + "-" + numerMiesiaca + "-" + DzienMiesiaca(numerMiesiaca, numerRoku) + "')";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            if (rdr.Read())
            {
                if (rdr[0].ToString() == "")
                    return null;
                else
                    return rdr[0].ToString().Substring(0, 10);
            }
            else
                return "Błąd: Złe zapytanie.";
        }

    }
}

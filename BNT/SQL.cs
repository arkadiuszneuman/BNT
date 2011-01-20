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
                    s[1] = CzytajNajpozniejszaDateZaplaty(nazwaFirmy,miesiac,rok)[0];
                    if (s[1] == null)
                        continue;
                    s[1] = s[1].Substring(0, 10);
                    s[2] = float.Parse(CzytajKwoteMiesieczna(nazwaFirmy,miesiac,rok)).ToString("F") + " zł";
                    s[3] = "Pokaż";
                    tablica.Add(s);
                    licznik++;
                }
            }
            return tablica.ToArray();
        }


        public string[][] CzytajKwotySlupowFirmy(string nazwaFirmy)
        {
            string zapytanie = "SELECT DISTINCT slupy.cena, miasta.nazwa, slupy.id FROM slupy LEFT OUTER JOIN nadajniki " + 
                "ON slupy.id = nadajniki.id_slupu LEFT OUTER JOIN faktury ON nadajniki.id_faktury = faktury.id " +
                "LEFT OUTER JOIN firmy ON nadajniki.id_firmy = firmy.id LEFT OUTER JOIN miasta ON slupy.id_miasta = slupy.id " +
                "WHERE (firmy.nazwa = '" + nazwaFirmy + "')";

            List<string[]> tablica = new List<string[]>();
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
            {
                string[] s = new string[2];
                s[0] = rdr[0].ToString();  // cena
                s[1] = rdr[1].ToString();  // miasto
                tablica.Add(s);
            }

            return tablica.ToArray();

        }

        public string[][] CzytajNadajniki(string nazwaFirmy, int numerMiesiaca, int numerRoku)
        {
            string zapytanie = "SELECT modele.nazwa, nadajniki.ilosc, modele.cena, faktury.wartosc FROM faktury LEFT OUTER JOIN nadajniki " +
                "ON nadajniki.id_faktury = faktury.id LEFT OUTER JOIN firmy ON firmy.id = nadajniki.id_firmy LEFT OUTER JOIN " +
                "modele ON modele.id = nadajniki.id_modelu WHERE (firmy.nazwa = '" + nazwaFirmy + "') AND " + 
                "(faktury.data_zaplaty BETWEEN '" + numerRoku + "-" + numerMiesiaca + "-01' AND '" + numerRoku + "-" 
                + numerMiesiaca + "-" + DateTime.DaysInMonth(numerRoku, numerMiesiaca) + "')";

            List<string[]> tablica = new List<string[]>();
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
            {
                string[] s = new string[4];
                s[0] = rdr[0].ToString();  // nazwa modelu
                s[1] = rdr[1].ToString();  // ilosc
                s[2] = rdr[2].ToString();  // cena modelu
                s[3] = rdr[3].ToString();  // stawka
                tablica.Add(s);
            }

            return tablica.ToArray();
        }


        private string CzytajKwoteMiesieczna(string nazwaFirmy, int numerMiesiaca, int numerRoku)
        {
            float cena = 0;
            //string zapytanie; // = "SELECT DISTINCT slupy.cena, slupy.id FROM slupy LEFT OUTER JOIN nadajniki ON slupy.id = nadajniki.id_slupu LEFT OUTER JOIN faktury ON nadajniki.id_faktury = faktury.id LEFT OUTER JOIN firmy ON nadajniki.id_firmy = firmy.id WHERE (firmy.nazwa = '" + nazwaFirmy + "')";
            //SqlCeDataReader rdr; // = Zapytanie(zapytanie);

            string[][] KwotySlupow = (CzytajKwotySlupowFirmy(nazwaFirmy));

            for(int i=0; i<KwotySlupow.Length; i++)
            {
                cena += float.Parse(KwotySlupow[i][0].ToString());
            }

            //zapytanie = "SELECT SUM(modele.cena * nadajniki.ilosc) FROM faktury LEFT OUTER JOIN nadajniki ON nadajniki.id_faktury = faktury.id LEFT OUTER JOIN firmy ON firmy.id = nadajniki.id_firmy LEFT OUTER JOIN modele ON modele.id = nadajniki.id_modelu WHERE (firmy.nazwa = '" + nazwaFirmy + "') AND (faktury.data_zaplaty BETWEEN '" + numerRoku + "-" + numerMiesiaca + "-01' AND '" + numerRoku + "-" + numerMiesiaca + "-" + DateTime.DaysInMonth(numerRoku,numerMiesiaca) + "')";
            //rdr = Zapytanie(zapytanie);

            string[][] KwotyNadajnikow = CzytajNadajniki(nazwaFirmy, numerMiesiaca, numerRoku);
            for (int i = 0; i < KwotyNadajnikow.Length; i++)
            {
                cena += int.Parse(KwotyNadajnikow[i][1]) * float.Parse(KwotyNadajnikow[i][2]) * float.Parse(KwotyNadajnikow[i][3]);
            }

            /*
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
            */

            return cena.ToString();

        }

        public string[] CzytajNajpozniejszaDateZaplaty(string nazwaFirmy, int numerMiesiaca, int numerRoku)
        {
            string zapytanie = "SELECT faktury.data_zaplaty, faktury.id FROM faktury LEFT OUTER JOIN nadajniki ON nadajniki.id_faktury = faktury.id " +
                "LEFT OUTER JOIN firmy ON firmy.id = nadajniki.id_firmy WHERE (firmy.nazwa = '" + nazwaFirmy + "') AND (faktury.data_zaplaty BETWEEN '" +
                numerRoku + "-" + numerMiesiaca + "-01' AND '" + numerRoku + "-" + numerMiesiaca + "-" + DateTime.DaysInMonth(numerRoku, numerMiesiaca) + 
                "') ORDER BY faktury.data_zaplaty DESC";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            string[] s = new string[2];
            if (rdr.Read())
            {
                s[0] = rdr[0].ToString();
                s[1] = rdr[1].ToString();
            }
            return s;
        }

        public string[][] CzytajFirmyBezFaktury()
        {
            int licznik = 1;
            string zapytanie = "SELECT " + "nadajniki.id," + " firmy.nazwa, miasta.nazwa, modele.nazwa, nadajniki.ilosc, nadajniki.ilosc * modele.cena " + 
                "FROM firmy LEFT OUTER JOIN nadajniki ON firmy.id = nadajniki.id_firmy LEFT OUTER JOIN slupy ON nadajniki.id_slupu = slupy.id " +
                "LEFT OUTER JOIN modele ON nadajniki.id_modelu = modele.id LEFT OUTER JOIN miasta ON slupy.id_miasta = miasta.id " +
                "WHERE (nadajniki.id_faktury IS NULL)";
            SqlCeDataReader rdr = Zapytanie(zapytanie);

            List<string[]> tablica = new List<string[]>();

            while (rdr.Read())
            {
                string[] s = new string[6];
                //s[0] = licznik.ToString();
                s[0] = rdr[0].ToString();
                s[1] = rdr[1].ToString();
                s[2] = rdr[2].ToString();
                s[3] = rdr[3].ToString();
                s[4] = rdr[4].ToString();
                s[5] = rdr[5].ToString();
                tablica.Add(s);
                licznik++;
            }

            return tablica.ToArray();
        }

        public void StworzRekordFaktury(string data_zaplaty, string stawka)
        {
            string zapytanie = "INSERT INTO faktury (data_zaplaty, wartosc) VALUES ('" + data_zaplaty.Substring(0, 10) +"', " + stawka.Replace(',','.') + ")";
            Zapytanie(zapytanie);
        }

        private string CzytajOstatniIndeksFaktury()
        {
            string zapytanie = "SELECT MAX(id) FROM faktury";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            if (rdr.Read())
                return rdr[0].ToString();
            else
            {
                MessageBox.Show("Błąd odczytu indeksu faktury!");
                return null;
            }
        }

        public void DolaczNowaFakture(string id_nadajnika)
        {
            string indeksNowejFaktury = CzytajOstatniIndeksFaktury();
            string zapytanie = "UPDATE nadajniki SET id_faktury=" + indeksNowejFaktury + " WHERE nadajniki.id = " + id_nadajnika;
            Zapytanie(zapytanie);
        }

        public string[] CzytajFirme(string nazwaFirmy)
        {
            string[] s = new string[8];
            string zapytanie = "SELECT firmy.imie, firmy.nazwisko, firmy.ulica, firmy.kod_pocztowy, miasta.nazwa, " +
                " firmy.nip, firmy.regon, firmy.telefon FROM firmy LEFT OUTER JOIN miasta ON firmy.id_miasta=miasta.id WHERE firmy.nazwa='" + nazwaFirmy +
                "'";
            SqlCeDataReader rdr = Zapytanie(zapytanie);

            if (rdr.Read())
            {
                s[0] = rdr[0].ToString();  // imie
                s[1] = rdr[1].ToString();  // nazwisko
                s[2] = rdr[2].ToString();  // ulica
                s[3] = rdr[3].ToString();  // kod_pocztowy
                s[4] = rdr[4].ToString();  // miasto
                s[5] = rdr[5].ToString();  // nip
                s[6] = rdr[6].ToString();  // regon
                s[7] = rdr[7].ToString();  // telefon
            }

            return s.ToArray();
        }
    }
}

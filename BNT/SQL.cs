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
    }
}

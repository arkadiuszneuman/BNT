using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace BNT
{
    public class SQL
    {
        SqlCeConnection cn = new SqlCeConnection("Data Source=..\\..\\Baza_BNT.sdf;Persist Security Info=False;");

        ~SQL()
        {
            
        }

        private SqlCeDataReader Zapytanie(string zapytanie)
        {
            cn.Open();

            SqlCeDataReader rdr = null;

            using (SqlCeCommand cmd = new SqlCeCommand(zapytanie, cn))
                rdr = cmd.ExecuteReader();

            return rdr;
        }

        public void Przyklad()
        {
            string zapytanie = "SELECT firmy.nazwa,modele.nazwa FROM firmy JOIN nadajniki ON firmy.id=nadajniki.id_firmy JOIN modele ON modele.id=nadajniki.id_modelu";
            SqlCeDataReader rdr = Zapytanie(zapytanie);
            while (rdr.Read())
                MessageBox.Show(rdr[0].ToString() + " | " + rdr[1].ToString());
        }
    }
}

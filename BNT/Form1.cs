using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace BNT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCeConnection cn = new SqlCeConnection("Data Source=..\\..\\Baza_BNT.sdf;Persist Security Info=False;");
            SqlCeCommand cmd;
            SqlCeDataReader rdr = null;

            cn.Open();
            //cmd = new SqlCeCommand("INSERT INTO Firmy (imie, nazwisko) VALUES ('Alojzy','Piątek')", cn);

            //cmd.ExecuteNonQuery();
            //cmd.Dispose();

            cmd = new SqlCeCommand("SELECT firmy.nazwa,modele.nazwa FROM firmy JOIN nadajniki ON firmy.id=nadajniki.id_firmy JOIN modele ON modele.id=nadajniki.id_modelu", cn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //MessageBox.Show(rdr[1].ToString() + " | " + rdr[2].ToString() + " | " + rdr[3].ToString() + " | " + rdr[4].ToString() + " | " + rdr[5].ToString() + " | " + rdr[6].ToString());
                MessageBox.Show(rdr[0].ToString() + " | " + rdr[1].ToString());
            }

            cmd.Dispose();
            cn.Close();
        }
    }
}

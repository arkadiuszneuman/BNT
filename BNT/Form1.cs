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
            //cos
            cmd = new SqlCeCommand(@"INSERT INTO Firmy (imie, nazwisko) VALUES ('Arek','Piątek')", cn);
            //cmd.Parameters.AddWithValue("@imie","Mietek");
            //cmd.Parameters.AddWithValue("@nazwisko", "Szczesniak");
            /*
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr[0]);
            }
            */

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            //cn.Close();
        }
    }
}

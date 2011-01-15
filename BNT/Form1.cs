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
            /*SqlCeConnection cn = new SqlCeConnection("Data Source=Baza_BNT.sdf;");
            SqlCeCommand cmd;
            SqlCeDataReader rdr = null;

            cn.Open();
            cmd = new SqlCeCommand("INSERT INTO Firmy (imie,nazwisko) VALUES ('Mietek','Szczesniak')", cn);
            //cmd = new SqlCeCommand("SELECT * FROM Firmy", cn);
            
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                MessageBox.Show(rdr[0].ToString()+" "+rdr[1].ToString()+" "+rdr[2].ToString());
            }
            

            //cmd.ExecuteNonQuery();
            cmd.Dispose();
            cn.Close();*/

            string conString = Properties.Settings.Default.Baza_BNTConnectionString;

            // Open the connection using the connection string.
            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                con.Open();

                // Insert into the SqlCe table. ExecuteNonQuery is best for inserts.

                using (SqlCeCommand com = new SqlCeCommand("INSERT INTO Firmy (imie,nazwisko) VALUES ('Mietekkkk','Szczesniak')", con))
                {
                    //com.Parameters.AddWithValue("@num", num);
                    com.ExecuteNonQuery();
                    
                }
            }
        }
    }
}

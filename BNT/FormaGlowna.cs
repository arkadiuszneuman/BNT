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
    public partial class FormaGlowna : Form
    {
        MapBtn m;

        public FormaGlowna()
        {
            InitializeComponent();
            string v = "0.1";
            Text = "BNT - Baza Nadajników Trakcyjnych v" + v;
            m = new MapBtn(tabMapa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQL sql = new SQL();
            //sql.Przyklad();

            
            //m.Maluj();
        }

        private void pictureBoxMapa_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxMapa.SendToBack();
           // m.Odswiez(e);
            Text = e.X.ToString() + " " + e.Y.ToString();
        }

        private void pictureBoxMapa_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
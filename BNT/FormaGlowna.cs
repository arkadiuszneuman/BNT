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
        //MapBtn m;
        SQL sql = new SQL();
        bool dodawajMiasto = false;

        public FormaGlowna()
        {
            InitializeComponent();
            string v = "0.1";
            Text = "BNT - Baza Nadajników Trakcyjnych v" + v;
            foreach (string[] miasta in sql.CzytajMiasta(true))
            {
                new MapBtn(tabMapa, panelMiasto, miasta[0], short.Parse(miasta[1]), short.Parse(miasta[2]));
            }
            pictureBoxMapa.SendToBack();
        }

        private void buttonDodajMiasto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dodaj miasto klikając w odpowiednie miejsce na mapie. Czy chcesz kontynuować?", "Dodaj miasto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                dodawajMiasto = true;
        }

        private void pictureBoxMapa_Click(object sender, EventArgs e)
        {
            if (dodawajMiasto)
            {
                NazwaMiasta dialog = new NazwaMiasta();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    sql.DodajMiasto(dialog.Nazwa, new Point(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y));
                }
            }

            Text = ((MouseEventArgs)e).X.ToString() + " " + ((MouseEventArgs)e).Y.ToString();
        }

        //tutaj dodawac swoje klasy, reakcja na zmiane karty (zakladki)
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((TabControl)sender).SelectedIndex)
            {
                case 1: //reakcja na klikniecie na slupy
                    new Slupy(dataGridSlupy, tabSlupy);
                    break;
                case 2:
                    new Nadajniki(dataGridNadajniki, tabNadajniki);
                    break;
                case 3:
                    new Modele(dataGridModele, tabModele);
                    break;
                case 5:
                    new Faktury(comboFirmy,comboMiesiace,comboRok,buttonGeneruj,dataGridFaktury);
                    break;
            }
        }
    }
}
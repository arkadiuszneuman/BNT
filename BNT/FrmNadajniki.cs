using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BNT
{
    public partial class FrmNadajniki : Form
    {
        SQL sql = new SQL();
        DataGridView tabelka;
        int id = 0;
        public FrmNadajniki(DataGridView tabelka)
        {
            InitializeComponent();

            this.tabelka = tabelka;

            WypelnijCombo();
        }

        /// <summary>
        /// Edycja
        /// </summary>
        /// /// <param name="wspolrzedne">jesli sa</param>
        /// <param name="miasto">jesli sa</param>
        /// <param name="cena">jesli jest</param>
        public FrmNadajniki(string miasto, string wspolrzedne, string cena, DataGridView tabelka, int id)
        {
            InitializeComponent();

            WypelnijCombo();
            cena = cena.Remove(cena.Length - 3); //usuniecie zł
            numericN.Value = decimal.Parse(wspolrzedne.Split(';')[0]);
            numericS.Value = decimal.Parse(wspolrzedne.Split(';')[1]);
            numericZl.Value = decimal.Parse(cena);

            buttonDodajLubZmien.Text = "Edytuj";
            this.id = id;

            comboBoxMiasto.SelectedItem = miasto;
            this.tabelka = tabelka;
        }

        private void WypelnijCombo()
        {         
            string[][] miasta = sql.CzytajMiasta(false);
            for (int i = 0; i < miasta.Length; ++i)
                comboBoxMiasto.Items.Add(miasta[i][0]);
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OdswiezTabelke()
        {
            string[][] dane = sql.CzytajSlupy();
            if (dane.Length > 0)
                tabelka.Rows.Clear();

            for (int j = 0; j < dane.Length; ++j)
                tabelka.Rows.Add(dane[j]);
        }

        private void buttonDodajLubZmien_Click(object sender, EventArgs e)
        {
            if (comboBoxMiasto.SelectedIndex < 0)
            {
                MessageBox.Show("Nie ma takiego miasta");
                return;
            }

            if (buttonDodajLubZmien.Text == "Edytuj")
            {
                sql.EdytujSlup(id, comboBoxMiasto.SelectedItem.ToString(), new Point((int)numericN.Value, (int)numericS.Value), numericZl.Value);
            }
            else //dodawanie
            {
                sql.DodajSlup(comboBoxMiasto.SelectedItem.ToString(), new Point((int)numericN.Value, (int)numericS.Value), numericZl.Value);
            }

            OdswiezTabelke();
            Close();
        }
    }
}

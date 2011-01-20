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

            WypelnijCombo();

            this.tabelka = tabelka;
        }

        /// <summary>
        /// Edycja
        /// </summary>
        /// /// <param name="wspolrzedne">jesli sa</param>
        /// <param name="miasto">jesli sa</param>
        /// <param name="cena">jesli jest</param>
        public FrmNadajniki(string slup, string model, int ilosc, DataGridView tabelka, int id)
        {
            InitializeComponent();

            WypelnijCombo();

            for (int i = 0; i < comboBoxSlupy.Items.Count; ++i)
            {
                if (comboBoxSlupy.Items[i].ToString().Split(' ')[0] == slup)
                {
                    comboBoxSlupy.SelectedIndex = i;
                    break;
                }
            }

            buttonDodajLubZmien.Text = "Edytuj";

            comboBoxModel.SelectedItem = model;
            numericIlosc.Value = ilosc;

            this.id = id;
            
            this.tabelka = tabelka;
        }

        private void WypelnijCombo()
        {
            string[][] modele = sql.CzytajModele(true);
            for (int i = 0; i < modele.Length; ++i)
                comboBoxModel.Items.Add(modele[i][0]);

            foreach (string s in sql.CzytajSlupy(true))
                comboBoxSlupy.Items.Add(s);
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OdswiezTabelke()
        {
            string[][] dane = sql.CzytajNadajniki();
            if (dane.Length > 0)
                tabelka.Rows.Clear();

            for (int j = 0; j < dane.Length; ++j)
                tabelka.Rows.Add(dane[j]);
        }

        private void buttonDodajLubZmien_Click(object sender, EventArgs e)
        {
            if (comboBoxSlupy.SelectedIndex < 0)
            {
                MessageBox.Show("Nie ma takiego miasta");
                return;
            }

            if (buttonDodajLubZmien.Text == "Edytuj")
            {
                sql.EdytujNadajnik(id, int.Parse(comboBoxSlupy.SelectedItem.ToString().Split(' ')[0]), comboBoxModel.SelectedItem.ToString(), Convert.ToInt32(numericIlosc.Value));
            }
            else //dodawanie
            {
                sql.DodajNadajnik(int.Parse(comboBoxSlupy.SelectedItem.ToString().Split(' ')[0]), comboBoxModel.SelectedItem.ToString(), Convert.ToInt32(numericIlosc.Value));
            }

            OdswiezTabelke();
            Close();
        }
    }
}

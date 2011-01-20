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
    public partial class FrmFirmy : Form
    {
        SQL sql = new SQL();
        DataGridView tabelka;
        int id = 0;
        public FrmFirmy(DataGridView tabelka)
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
        public FrmFirmy(int id, DataGridView tabelka, string nazwa, string imie, string nazwisko, string ulica, string kodPocztowy,
            string miasto, string nip, string regon, string telefon, string nadajniki)
        {
            InitializeComponent();

            WypelnijCombo();

            textBoxNazwa.Text = nazwa;
            textBoxImie.Text = imie;
            textBoxNazwisko.Text = nazwisko;
            textBoxUlica.Text = ulica;
            maskedTextBoxKod.Text = kodPocztowy;
            maskedTextBoxNip.Text = nip;
            maskedTextBoxRegon.Text = regon;
            maskedTextBoxTelefon.Text = telefon;

            for (int i = 0; i < nadajniki.Split(',').Length; ++i)
            {
                listBoxNadajniki.Items.Add(nadajniki.Split(',')[i].Trim());
            }

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

            foreach (string s in sql.CzytajNadajniki(true, 0))
                comboBoxNadajniki.Items.Add(s);

            if (id != 0)
            {
                foreach (string s in sql.CzytajNadajniki(true, id))
                    listBoxNadajniki.Items.Add(s);
            }
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OdswiezTabelke()
        {
            string[][] dane = sql.CzytajFirmy(true);
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

            List<int> nadajniki = new List<int>();
            for (int i = 0; i < listBoxNadajniki.Items.Count; ++i)
            {
                nadajniki.Add(Convert.ToInt32(listBoxNadajniki.Items[i]));
            }

            if (buttonDodajLubZmien.Text == "Edytuj")
            {
                //sql.EdytujSlup(id, comboBoxMiasto.SelectedItem.ToString(), new Point((int)numericN.Value, (int)numericS.Value), numericZl.Value);
            }
            else //dodawanie
            {
                sql.DodajFirme(textBoxNazwa.Text, textBoxImie.Text, textBoxNazwisko.Text, textBoxUlica.Text, maskedTextBoxKod.Text,
                    comboBoxMiasto.SelectedItem.ToString(), maskedTextBoxNip.Text, maskedTextBoxRegon.Text, maskedTextBoxTelefon.Text, nadajniki.ToArray());
            }

            OdswiezTabelke();
            Close();
        }

        private void buttonDodajNadajnik_Click(object sender, EventArgs e)
        {
            if (!listBoxNadajniki.Items.Contains(comboBoxNadajniki.SelectedItem))
                listBoxNadajniki.Items.Add(comboBoxNadajniki.SelectedItem);
        }

        private void buttonUsunNadajnik_Click(object sender, EventArgs e)
        {
            if (listBoxNadajniki.SelectedIndex >= 0)
                listBoxNadajniki.Items.RemoveAt(listBoxNadajniki.SelectedIndex);
        }

    }
}

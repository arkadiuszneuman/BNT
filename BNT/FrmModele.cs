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
    public partial class FrmModele : Form
    {
        SQL sql = new SQL();
        DataGridView tabelka;
        int id = 0;
        public FrmModele(DataGridView tabelka)
        {
            InitializeComponent();

            this.tabelka = tabelka;
        }

        /// <summary>
        /// Edycja
        /// </summary>
        /// /// <param name="wspolrzedne">jesli sa</param>
        /// <param name="miasto">jesli sa</param>
        /// <param name="cena">jesli jest</param>
        public FrmModele(string nazwa, int zasieg, string cena, DataGridView tabelka, int id)
        {
            InitializeComponent();

            cena = cena.Remove(cena.Length - 3); //usuniecie zł
            textBoxNazwa.Text = nazwa;
            numericZasieg.Value = zasieg;
            numericCena.Value = decimal.Parse(cena);

            buttonDodajLubZmien.Text = "Edytuj";
            this.id = id;

            this.tabelka = tabelka;
        }


        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OdswiezTabelke()
        {
            string[][] dane = sql.CzytajModele();
            if (dane.Length > 0)
                tabelka.Rows.Clear();

            for (int j = 0; j < dane.Length; ++j)
                tabelka.Rows.Add(dane[j]);
        }

        private void buttonDodajLubZmien_Click(object sender, EventArgs e)
        {
            if (buttonDodajLubZmien.Text == "Edytuj")
            {
                sql.EdytujModel(id, textBoxNazwa.Text, (int)numericZasieg.Value, numericCena.Value);
            }
            else //dodawanie
            {
                sql.DodajModel(textBoxNazwa.Text, (int)numericZasieg.Value, numericCena.Value);
            }

            OdswiezTabelke();
            Close();
        }
    }
}

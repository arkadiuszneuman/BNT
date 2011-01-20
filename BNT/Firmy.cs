using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BNT
{
    class Firmy
    {
        DataGridView tabelka;
        Button buttonDodaj = new Button();
        Button buttonEdytuj = new Button();
        Button buttonUsun = new Button();

        public Firmy(DataGridView tabelka, TabPage tabFirmy)
        {
            this.tabelka = tabelka;
            SQL sql = new SQL();
            string[][] dane = sql.CzytajFirmy(true);
            if (dane.Length > 0)
                tabelka.Rows.Clear();

            for (int j = 0; j < dane.Length; ++j)
                tabelka.Rows.Add(dane[j]);

            StworzPrzyciski(tabFirmy);
        }

        private void StworzPrzyciski(TabPage firmy)
        {
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(8, 468);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(89, 468);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(75, 23);
            this.buttonEdytuj.TabIndex = 2;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(170, 468);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 23);
            this.buttonUsun.TabIndex = 3;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);

            firmy.Controls.AddRange(new Control[] { buttonDodaj, buttonEdytuj, buttonUsun });
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            new FrmFirmy(tabelka).ShowDialog();
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colIdFirmy"].Value);
            string nazwa = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colNazwaFirmy"].Value.ToString();
            string imie = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colImieFirmy"].Value.ToString();
            string nazwisko = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colNazwiskoFirmy"].Value.ToString();
            string ulica = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colUlicaFirmy"].Value.ToString();
            string kodPocztowy = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colKodFirmy"].Value.ToString();
            string miasto = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colMiastoFirmy"].Value.ToString();
            string nip = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colNipFirmy"].Value.ToString();
            string regon = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colRegonFirmy"].Value.ToString();
            string telefon = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colTelFirmy"].Value.ToString();
            string nadajniki = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colNrNadFirmy"].Value.ToString();

            new FrmFirmy(id, tabelka, nazwa, imie, nazwisko, ulica, kodPocztowy,
            miasto, nip, regon, telefon, nadajniki).ShowDialog();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colIdFirmy"].Value);
            string nazwa = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colNazwaFirmy"].Value.ToString();

            if (MessageBox.Show("Czy chcesz usunać firme " + nazwa + "?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQL sql = new SQL();
                sql.UsunFirme(id);
                //odswiezenie
                string[][] dane = sql.CzytajFirmy(true);
                if (dane.Length > 0)
                    tabelka.Rows.Clear();

                for (int j = 0; j < dane.Length; ++j)
                    tabelka.Rows.Add(dane[j]);
            }
        }
    }
}

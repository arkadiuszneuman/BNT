using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BNT
{
    class Modele
    {
        DataGridView tabelka;
        Button buttonDodaj = new Button();
        Button buttonEdytuj = new Button();
        Button buttonUsun = new Button();

        public Modele(DataGridView tabelka, TabPage tabModele)
        {
            this.tabelka = tabelka;
            SQL sql = new SQL();
            string[][] dane = sql.CzytajModele();
            if (dane.Length > 0)
                tabelka.Rows.Clear();

            for (int j = 0; j < dane.Length; ++j)
                tabelka.Rows.Add(dane[j]);

            StworzPrzyciski(tabModele);
        }

        private void StworzPrzyciski(TabPage modele)
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

            modele.Controls.AddRange(new Control[] { buttonDodaj, buttonEdytuj, buttonUsun });
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            new FrmModele(tabelka).ShowDialog();
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colIdModele"].Value);
            string nazwa = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colNazwaModele"].Value.ToString();
            string zasieg = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colZasiegModele"].Value.ToString();
            string cena = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colCenaModele"].Value.ToString();

            new FrmModele(nazwa, int.Parse(zasieg), cena, tabelka, id).ShowDialog();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colIdModele"].Value);
            string nazwa = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colNazwaModele"].Value.ToString();
            
            if (MessageBox.Show("Czy chcesz usunać model " + nazwa + "?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQL sql = new SQL();
                if (new SQL().UsunModel(id))
                {

                    //odswiezenie
                    string[][] dane = sql.CzytajNadajniki();
                    if (dane.Length > 0)
                        tabelka.Rows.Clear();

                    for (int j = 0; j < dane.Length; ++j)
                        tabelka.Rows.Add(dane[j]);
                }
            }
        }
    }
}

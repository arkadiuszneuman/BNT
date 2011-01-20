using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BNT
{
    class Slupy
    {
        DataGridView tabelka;
        Button buttonDodaj = new Button();
        Button buttonEdytuj = new Button();
        Button buttonUsun = new Button();

        public Slupy(DataGridView tabelka, TabPage tabSlupy)
        {
            this.tabelka = tabelka;
            
            SQL sql = new SQL();
		    string[][] dane = sql.CzytajSlupy();
		    if (dane.Length > 0)
		        tabelka.Rows.Clear();
		
		    for (int j = 0; j < dane.Length; ++j)
		        tabelka.Rows.Add(dane[j]);

            StworzPrzyciski(tabSlupy);
        }

        private void StworzPrzyciski(TabPage slupy)
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

            slupy.Controls.AddRange(new Control[] { buttonDodaj, buttonEdytuj, buttonUsun });
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            new FrmSlupy(tabelka).ShowDialog();
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colNr"].Value);
            string miasto = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colMiasto"].Value.ToString();
            string wspolrzedne = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colWsp"].Value.ToString();
            string cena = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colCena"].Value.ToString();

            new FrmSlupy(miasto, wspolrzedne, cena, tabelka, id).ShowDialog();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colNr"].Value);
            if (MessageBox.Show("Czy chcesz usunać słup nr: " + id + "?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQL sql = new SQL();
                if (sql.UsunSlup(id))
                {

                    //odswiezenie
                    string[][] dane = sql.CzytajSlupy();
                    if (dane.Length > 0)
                        tabelka.Rows.Clear();

                    for (int j = 0; j < dane.Length; ++j)
                        tabelka.Rows.Add(dane[j]);
                }
                else
                {
                    MessageBox.Show("Najpierw usuń nadajniki należące do tego słupu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

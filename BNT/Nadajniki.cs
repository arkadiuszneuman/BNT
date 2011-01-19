using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BNT
{
    class Nadajniki
    {
        DataGridView tabelka;
        Button buttonDodaj = new Button();
        Button buttonEdytuj = new Button();
        Button buttonUsun = new Button();

        public Nadajniki(DataGridView tabelka, TabPage tabNadajniki)
        {
            this.tabelka = tabelka;
            SQL sql = new SQL();
            string[][] dane = sql.CzytajNadajniki();
            if (dane.Length > 0)
                tabelka.Rows.Clear();

            for (int j = 0; j < dane.Length; ++j)
                tabelka.Rows.Add(dane[j]);

            StworzPrzyciski(tabNadajniki);
        }

        private void StworzPrzyciski(TabPage nadajniki)
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

            nadajniki.Controls.AddRange(new Control[] { buttonDodaj, buttonEdytuj, buttonUsun });
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            new FrmNadajniki(tabelka).ShowDialog();
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colNrNadajniki"].Value);
            string nrSlupu = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colNrSlupuNadajniki"].Value.ToString();
            string model = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colModelNadajniki"].Value.ToString();
            string ilosc = tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colIloscNadajniki"].Value.ToString();

            new FrmNadajniki(nrSlupu, model, int.Parse(ilosc), tabelka, id).ShowDialog();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tabelka.Rows[tabelka.SelectedRows[0].Index].Cells["colNrNadajniki"].Value);
            if (MessageBox.Show("Czy chcesz usunać nadajnik nr: " + id + "?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQL sql = new SQL();
                sql.UsunNadajnik(id);
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

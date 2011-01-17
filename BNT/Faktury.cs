using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BNT
{
    class Faktury
    {
        ComboBox comboFirmy;
        ComboBox comboMiesiace;
        ComboBox comboRok;
        Button buttonGeneruj;
        DataGridView dataGridFaktury;
        SQL sql;

        public Faktury(ComboBox comboFirmy, ComboBox comboMiesiace, ComboBox comboRok, Button buttonGeneruj, DataGridView dataGridFaktury)
        {
            SQL sql = new SQL();
            this.comboFirmy = comboFirmy;
            this.comboMiesiace = comboMiesiace;
            this.comboRok = comboRok;
            this.buttonGeneruj = buttonGeneruj;
            this.dataGridFaktury = dataGridFaktury;
            this.comboFirmy.Items.AddRange(sql.CzytajFirmy());
            this.comboFirmy.SelectedIndexChanged += new System.EventHandler(this.KlikZmienFirme);
        }

        private void KlikZmienFirme(object sender, EventArgs e)
        {
            if (comboFirmy.Items.Count > 0)
            {
                comboMiesiace.SelectedIndex = DateTime.Now.Month - 1;
                comboRok.SelectedIndex = (DateTime.Now.Year - 2008) - 1;
                comboMiesiace.Enabled = true;
                comboRok.Enabled = true;
                buttonGeneruj.Enabled = true;
                string[][] dane = sql.CzytajFakture(comboFirmy.SelectedItem.ToString());

                for (int j = 0; j < dane.Length; ++j)
                    dataGridFaktury.Rows.Add(dane[j]);
            }
        }
    }
}

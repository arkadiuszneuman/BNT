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
        SQL sql = new SQL();

        public Faktury(ComboBox comboFirmy, ComboBox comboMiesiace, ComboBox comboRok, Button buttonGeneruj, DataGridView dataGridFaktury)
        {
            this.comboFirmy = comboFirmy;
            this.comboMiesiace = comboMiesiace;
            this.comboRok = comboRok;
            this.buttonGeneruj = buttonGeneruj;
            this.dataGridFaktury = dataGridFaktury;
            this.comboFirmy.Items.AddRange(sql.CzytajFirmy());
            this.comboFirmy.SelectedIndexChanged += new System.EventHandler(this.KlikZmienFirme);
            this.dataGridFaktury.MouseClick += new MouseEventHandler(this.KlikTabelaFaktury);
        }

        private void KlikZmienFirme(object sender, EventArgs e)
        {
            dataGridFaktury.Rows.Clear();
            if (comboFirmy.Items.Count > 0)
            {
                comboMiesiace.SelectedIndex = DateTime.Now.Month - 1;
                comboRok.SelectedIndex = (DateTime.Now.Year - 2008) - 1;
                comboMiesiace.Enabled = true;
                comboRok.Enabled = true;
                buttonGeneruj.Enabled = true;
                dataGridFaktury.Enabled = true;
                string[][] dane = sql.CzytajFaktury(comboFirmy.SelectedItem.ToString());
                for (int j = 0; j < dane.Length; ++j)
                    dataGridFaktury.Rows.Add(dane[j]);
            }
        }

        public void KlikTabelaFaktury(object sender, EventArgs e)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace BNT
{
    class Faktury
    {
        ComboBox comboFirmy;
        ComboBox comboMiesiace;
        ComboBox comboRok;
        Button buttonPokaz;
        Button buttonStworzFakture;
        DataGridView dataGridFaktury;
        RadioButton radioTabela;
        RadioButton radioData;
        bool pierwszyRaz;
        SQL sql = new SQL();

        public Faktury(ComboBox comboFirmy, ComboBox comboMiesiace, ComboBox comboRok, Button buttonPokaz, Button buttonStworzFakture, DataGridView dataGridFaktury, RadioButton radioTabela, RadioButton radioData)
        {
            this.comboFirmy = comboFirmy;
            this.comboMiesiace = comboMiesiace;
            this.comboRok = comboRok;
            this.buttonPokaz = buttonPokaz;
            this.buttonStworzFakture = buttonStworzFakture;
            this.dataGridFaktury = dataGridFaktury;
            this.radioTabela = radioTabela;
            this.radioData = radioData;
            this.comboFirmy.Items.Clear();
            try
            {
                this.comboFirmy.Items.AddRange(sql.CzytajFirmy());
            }
            catch (SqlCeLockTimeoutException)
            {
                MessageBox.Show("Błąd Bazy!");
            }
            this.pierwszyRaz = true;

            this.radioData.Checked = true;
            this.comboMiesiace.Enabled = false;
            this.comboRok.Enabled = false;

            this.comboFirmy.SelectedIndexChanged += new System.EventHandler(this.KlikZmienFirme);
            this.buttonPokaz.Click += new System.EventHandler(this.buttonPokaz_Click);
            this.buttonStworzFakture.Click += new System.EventHandler(this.buttonStworzFakture_Click);
            this.radioTabela.CheckedChanged += new System.EventHandler(this.radioTabela_CheckedChanged);

            this.radioData.CheckedChanged += new System.EventHandler(this.KlikSprawdzCzyIstniejeFaktura);
            this.comboMiesiace.SelectedIndexChanged += new System.EventHandler(this.KlikSprawdzCzyIstniejeFaktura);
            this.comboRok.SelectedIndexChanged += new System.EventHandler(this.KlikSprawdzCzyIstniejeFaktura);
            this.comboFirmy.SelectedIndexChanged += new System.EventHandler(this.KlikSprawdzCzyIstniejeFaktura);
        }

        private void KlikZmienFirme(object sender, EventArgs e)
        {
            if (pierwszyRaz)
            {
                comboMiesiace.SelectedIndex = DateTime.Now.Month - 1;
                comboRok.SelectedIndex = (DateTime.Now.Year - 2008) - 1;
                this.radioData.Enabled = true;
                this.radioTabela.Enabled = true;
                this.comboMiesiace.Enabled = true;
                this.comboRok.Enabled = true;
                this.buttonPokaz.Enabled = true;
                this.pierwszyRaz = false;
            }
            if (radioTabela.Checked)
            {
                radioTabela_CheckedChanged(sender, e);
            }
        }

        private void buttonStworzFakture_Click(object sender, EventArgs e)
        {
            new FrmStworzFakture().ShowDialog();
        }

        private void buttonPokaz_Click(object sender, EventArgs e)
        {
         if(comboFirmy.SelectedIndex != -1)
            if (radioData.Checked)
                new FrmFaktury(comboFirmy.SelectedItem.ToString(), comboMiesiace.SelectedIndex + 1, DateTime.Now.Year - (comboRok.Items.Count - (comboRok.SelectedIndex+1))).ShowDialog();
            else
                if (dataGridFaktury.Rows.Count != 0)
                new FrmFaktury(comboFirmy.SelectedItem.ToString(), DateTime.Parse(dataGridFaktury.Rows[dataGridFaktury.SelectedRows[0].Index].Cells["colDataWystawienia"].Value.ToString()).Month,  DateTime.Parse(dataGridFaktury.Rows[dataGridFaktury.SelectedRows[0].Index].Cells["colDataWystawienia"].Value.ToString()).Year).ShowDialog();
        }

        private void radioTabela_CheckedChanged(object sender, EventArgs e)
        {
            dataGridFaktury.Rows.Clear();
            if (radioTabela.Checked && (comboFirmy.SelectedItem != null))
            {
                comboMiesiace.Enabled = false;
                comboRok.Enabled = false;
                buttonPokaz.Enabled = true;
                dataGridFaktury.Enabled = true;
                try
                {
                    string[][] dane = sql.CzytajFaktury(comboFirmy.SelectedItem.ToString());
                    for (int j = 0; j < dane.Length; ++j)
                        dataGridFaktury.Rows.Add(dane[j]);
                }
                catch (SqlCeLockTimeoutException)
                {
                    MessageBox.Show("Błąd Bazy!");
                }
            }
            else
            {
                comboMiesiace.Enabled = true;
                comboRok.Enabled = true;
                buttonPokaz.Enabled = true;
                dataGridFaktury.Enabled = false;
            }
        }

        private void KlikSprawdzCzyIstniejeFaktura(object sender, EventArgs e)
        {
            if (radioData.Checked)
            {
                if(comboFirmy.SelectedItem != null)
                    try
                    {
                        if (sql.CzytajNajpozniejszaDateZaplaty(comboFirmy.SelectedItem.ToString(), comboMiesiace.SelectedIndex + 1, DateTime.Now.Year - (comboRok.Items.Count - (comboRok.SelectedIndex + 1)))[0] == null)
                            this.buttonPokaz.Enabled = false;
                        else
                            this.buttonPokaz.Enabled = true;
                    }
                    catch (SqlCeLockTimeoutException)
                    {
                        MessageBox.Show("Błąd Bazy!");
                    }
            }
            else
                this.buttonPokaz.Enabled = true;
        }

    }
}

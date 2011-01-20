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
    public partial class FrmStworzFakture : Form
    {
        SQL sql = new SQL();
        public FrmStworzFakture()
        {
            InitializeComponent();
            string[][] dane = sql.CzytajFirmyBezFaktury();
            for (int j = 0; j < dane.Length; ++j)
                dataGridStworzFakture.Rows.Add(dane[j]);
        }

        private void buttonStworz_Click(object sender, EventArgs e)
        {
            sql.StworzRekordFaktury(dateTimeFaktura.Value.Date.ToString(), (((float)numericStawka.Value)/100).ToString());
            sql.DolaczNowaFakture(dataGridStworzFakture.Rows[dataGridStworzFakture.SelectedRows[0].Index].Cells["colLp"].Value.ToString());
            string[][] dane = sql.CzytajFirmyBezFaktury();

            dataGridStworzFakture.Rows.Clear();

            for (int j = 0; j < dane.Length; ++j)
                dataGridStworzFakture.Rows.Add(dane[j]);
        }

        private void buttonWyjdz_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

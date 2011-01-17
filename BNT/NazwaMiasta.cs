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
    public partial class NazwaMiasta : Form
    {
        public string Nazwa {get; private set;}
        public NazwaMiasta()
        {
            InitializeComponent();
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            if (Nazwa == "")
            {
                MessageBox.Show("Nazwa nie może być pusta");
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Nazwa = textBoxNazwa.Text;
            Close();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Abort;
            Close();
        }

        private void textBoxNazwa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonZapisz_Click(null, null);
        }
    }
}

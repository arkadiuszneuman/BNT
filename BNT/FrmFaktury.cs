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
    public partial class FrmFaktury : Form
    {
        SQL sql = new SQL();
        Random r = new Random();
        int licznik = 1;
        float suma = 0;

        public FrmFaktury(string nazwaFirmy, int miesiac, int rok)
        {
            InitializeComponent();
            string[] informacjeFirmy = sql.CzytajFirme(nazwaFirmy);
            string[] dataIdFaktury = sql.CzytajNajpozniejszaDateZaplaty(nazwaFirmy, miesiac, rok);
            string[][] dane = sql.CzytajKwotySlupowFirmy(nazwaFirmy);
           
            labelNabywca.Text += nazwaFirmy + "\n" + informacjeFirmy[2] + "\n" +
                informacjeFirmy[3] + " " + informacjeFirmy[4] + "\nNIP: " + informacjeFirmy[5] + "\nREGON: " + informacjeFirmy[6] +
                "\nTelefon: " + informacjeFirmy[7];
            labelDataWystawienia.Text += dataIdFaktury[0].Substring(0,10);
            labelTermin.Text += DateTime.Parse(dataIdFaktury[0]).AddMonths(1).ToString().Substring(0, 10);
            labelOdebral.Text += informacjeFirmy[0] + " " + informacjeFirmy[1];
            labelFaktura.Text += dataIdFaktury[1] + "/" + r.Next(100, 1000);

            int j;
            for (j = 0; j < dane.Length; ++j)
            {
                dataGridProdukty.Height += 20;
                labelTermin.Location = new System.Drawing.Point(labelTermin.Location.X, labelTermin.Location.Y + 20);
                labelDoZaplaty.Location = new System.Drawing.Point(labelDoZaplaty.Location.X, labelDoZaplaty.Location.Y + 20);
                dataGridProdukty.Rows.Add(j+1, "Dzierżawa słupa w mieście " + dane[j][1], 1, float.Parse(dane[j][0]).ToString("F") + " zł",
                    "---", float.Parse(dane[j][0]).ToString("F") + " zł", "23%", (float.Parse(dane[j][0]) * 0.77).ToString("F") + " zł");
                dataGridProdukty.Rows[licznik - 1].Cells[2].Style.Alignment = DataGridViewContentAlignment.TopCenter;
                dataGridProdukty.Rows[licznik - 1].Cells[3].Style.Alignment = DataGridViewContentAlignment.TopRight;
                dataGridProdukty.Rows[licznik - 1].Cells[4].Style.Alignment = DataGridViewContentAlignment.TopCenter;
                dataGridProdukty.Rows[licznik - 1].Cells[5].Style.Alignment = DataGridViewContentAlignment.TopRight;
                dataGridProdukty.Rows[licznik - 1].Cells[7].Style.Alignment = DataGridViewContentAlignment.TopRight;
                licznik++;
                suma += float.Parse(dane[j][0]);
            }

            dane = sql.CzytajNadajniki(nazwaFirmy,miesiac,rok);
            for (j = 0 ; j < dane.Length; ++j)
            {
                dataGridProdukty.Height += 20;
                labelTermin.Location = new System.Drawing.Point(labelTermin.Location.X, labelTermin.Location.Y + 20);
                labelDoZaplaty.Location = new System.Drawing.Point(labelDoZaplaty.Location.X, labelDoZaplaty.Location.Y + 20);
                dataGridProdukty.Rows.Add(licznik, "Dzierżawa modelu " + dane[j][0], dane[j][1], float.Parse(dane[j][2]).ToString("F") + " zł",
                    int.Parse( (float.Parse(dane[j][3]) * 100).ToString() ) + " %" , (int.Parse(dane[j][1]) * float.Parse(dane[j][2]) * float.Parse(dane[j][3])).ToString("F") + " zł",
                    "23%", ((int.Parse(dane[j][1]) * float.Parse(dane[j][2]) * float.Parse(dane[j][3])) * 0.77).ToString("F") + " zł");
                dataGridProdukty.Rows[licznik - 1].Cells[2].Style.Alignment = DataGridViewContentAlignment.TopCenter;
                dataGridProdukty.Rows[licznik - 1].Cells[3].Style.Alignment = DataGridViewContentAlignment.TopRight;
                dataGridProdukty.Rows[licznik - 1].Cells[4].Style.Alignment = DataGridViewContentAlignment.TopCenter;
                dataGridProdukty.Rows[licznik - 1].Cells[5].Style.Alignment = DataGridViewContentAlignment.TopRight;
                dataGridProdukty.Rows[licznik - 1].Cells[7].Style.Alignment = DataGridViewContentAlignment.TopRight;
                licznik++;
                suma += int.Parse(dane[j][1]) * float.Parse(dane[j][2]) * float.Parse(dane[j][3]);
            }

            dataGridProdukty.Height += 20;
            labelTermin.Location = new System.Drawing.Point(labelTermin.Location.X, labelTermin.Location.Y + 20);
            labelDoZaplaty.Location = new System.Drawing.Point(labelDoZaplaty.Location.X, labelDoZaplaty.Location.Y + 20);
            dataGridProdukty.Rows.Add("","","","", "Razem", suma.ToString("F") + " zł","",(suma*0.77).ToString("F") + " zł");
            dataGridProdukty.Rows[licznik - 1].Cells[5].Style.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridProdukty.Rows[licznik - 1].Cells[7].Style.Alignment = DataGridViewContentAlignment.TopRight;

            labelDoZaplaty.Text += suma.ToString("F") + " zł";

        }

    }
}

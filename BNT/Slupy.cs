﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BNT
{
    class Slupy
    {
        DataGridView tabelka;

        public Slupy(DataGridView tabelka)
        {
            this.tabelka = tabelka;
            SQL sql = new SQL();
            string[][] dane = sql.CzytajNadajniki();

                for (int j = 0; j < dane.Length; ++j)
                    tabelka.Rows.Add(dane[j]);
                
        }
    }
}

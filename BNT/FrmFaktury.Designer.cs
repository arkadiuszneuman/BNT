namespace BNT
{
    partial class FrmFaktury
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelSprze = new System.Windows.Forms.Label();
            this.labelNabywca = new System.Windows.Forms.Label();
            this.labelFaktura = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelDataWystawienia = new System.Windows.Forms.Label();
            this.dataGridProdukty = new System.Windows.Forms.DataGridView();
            this.labelTermin = new System.Windows.Forms.Label();
            this.labelDoZaplaty = new System.Windows.Forms.Label();
            this.labelWystawil = new System.Windows.Forms.Label();
            this.labelOdebral = new System.Windows.Forms.Label();
            this.colLp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsluga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSztuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCenaJedn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStawka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSprze
            // 
            this.labelSprze.AutoSize = true;
            this.labelSprze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelSprze.Location = new System.Drawing.Point(68, 139);
            this.labelSprze.Name = "labelSprze";
            this.labelSprze.Size = new System.Drawing.Size(123, 112);
            this.labelSprze.TabIndex = 0;
            this.labelSprze.Text = "Sprzedawca:\r\n\r\nFirma BNT\r\nul. Słoneczna 1/22\r\n40-001 Katowice\r\nNIP 111-222-33-44\r" +
                "\nREGON 123456789";
            // 
            // labelNabywca
            // 
            this.labelNabywca.AutoSize = true;
            this.labelNabywca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelNabywca.Location = new System.Drawing.Point(359, 139);
            this.labelNabywca.Name = "labelNabywca";
            this.labelNabywca.Size = new System.Drawing.Size(68, 32);
            this.labelNabywca.TabIndex = 1;
            this.labelNabywca.Text = "Nabywca:\r\n\r\n";
            // 
            // labelFaktura
            // 
            this.labelFaktura.AutoSize = true;
            this.labelFaktura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFaktura.Location = new System.Drawing.Point(178, 93);
            this.labelFaktura.Name = "labelFaktura";
            this.labelFaktura.Size = new System.Drawing.Size(186, 31);
            this.labelFaktura.TabIndex = 2;
            this.labelFaktura.Text = "Faktura VAT ";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelAdres.Location = new System.Drawing.Point(29, 26);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(118, 48);
            this.labelAdres.TabIndex = 4;
            this.labelAdres.Text = "Firma BNT\r\nul. Słoneczna 1/22\r\n40-001 Katowice";
            // 
            // labelDataWystawienia
            // 
            this.labelDataWystawienia.AutoSize = true;
            this.labelDataWystawienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelDataWystawienia.Location = new System.Drawing.Point(451, 26);
            this.labelDataWystawienia.Name = "labelDataWystawienia";
            this.labelDataWystawienia.Size = new System.Drawing.Size(68, 16);
            this.labelDataWystawienia.TabIndex = 5;
            this.labelDataWystawienia.Text = "Katowice, ";
            // 
            // dataGridProdukty
            // 
            this.dataGridProdukty.AllowUserToAddRows = false;
            this.dataGridProdukty.AllowUserToDeleteRows = false;
            this.dataGridProdukty.AllowUserToResizeColumns = false;
            this.dataGridProdukty.AllowUserToResizeRows = false;
            this.dataGridProdukty.BackgroundColor = System.Drawing.Color.White;
            this.dataGridProdukty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdukty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLp,
            this.colUsluga,
            this.colSztuk,
            this.colCenaJedn,
            this.colStawka,
            this.colBrutto,
            this.colVAT,
            this.colNetto});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProdukty.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProdukty.Enabled = false;
            this.dataGridProdukty.GridColor = System.Drawing.Color.White;
            this.dataGridProdukty.Location = new System.Drawing.Point(32, 288);
            this.dataGridProdukty.MaximumSize = new System.Drawing.Size(545, 395);
            this.dataGridProdukty.MultiSelect = false;
            this.dataGridProdukty.Name = "dataGridProdukty";
            this.dataGridProdukty.ReadOnly = true;
            this.dataGridProdukty.RowHeadersVisible = false;
            this.dataGridProdukty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridProdukty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProdukty.Size = new System.Drawing.Size(545, 51);
            this.dataGridProdukty.TabIndex = 6;
            // 
            // labelTermin
            // 
            this.labelTermin.AutoSize = true;
            this.labelTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTermin.Location = new System.Drawing.Point(68, 376);
            this.labelTermin.Name = "labelTermin";
            this.labelTermin.Size = new System.Drawing.Size(134, 16);
            this.labelTermin.TabIndex = 7;
            this.labelTermin.Text = "Termin płatności: ";
            // 
            // labelDoZaplaty
            // 
            this.labelDoZaplaty.AutoSize = true;
            this.labelDoZaplaty.BackColor = System.Drawing.Color.White;
            this.labelDoZaplaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDoZaplaty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDoZaplaty.Location = new System.Drawing.Point(359, 376);
            this.labelDoZaplaty.Name = "labelDoZaplaty";
            this.labelDoZaplaty.Size = new System.Drawing.Size(93, 16);
            this.labelDoZaplaty.TabIndex = 8;
            this.labelDoZaplaty.Text = "Do zapłaty: ";
            // 
            // labelWystawil
            // 
            this.labelWystawil.AutoSize = true;
            this.labelWystawil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelWystawil.Location = new System.Drawing.Point(56, 711);
            this.labelWystawil.Name = "labelWystawil";
            this.labelWystawil.Size = new System.Drawing.Size(121, 64);
            this.labelWystawil.TabIndex = 9;
            this.labelWystawil.Text = "Fakturę wystawił:\r\n\r\nŁukasz Andrzejak\r\nArkadiusz Neuman";
            this.labelWystawil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelOdebral
            // 
            this.labelOdebral.AutoSize = true;
            this.labelOdebral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelOdebral.Location = new System.Drawing.Point(390, 711);
            this.labelOdebral.Name = "labelOdebral";
            this.labelOdebral.Size = new System.Drawing.Size(109, 32);
            this.labelOdebral.TabIndex = 10;
            this.labelOdebral.Text = "Fakturę odebrał:\r\n\r\n";
            this.labelOdebral.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colLp
            // 
            this.colLp.HeaderText = "Lp";
            this.colLp.Name = "colLp";
            this.colLp.ReadOnly = true;
            this.colLp.Width = 20;
            // 
            // colUsluga
            // 
            this.colUsluga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUsluga.HeaderText = "Nazwa Usługi";
            this.colUsluga.Name = "colUsluga";
            this.colUsluga.ReadOnly = true;
            // 
            // colSztuk
            // 
            this.colSztuk.HeaderText = "Sztuk";
            this.colSztuk.Name = "colSztuk";
            this.colSztuk.ReadOnly = true;
            this.colSztuk.Width = 40;
            // 
            // colCenaJedn
            // 
            this.colCenaJedn.HeaderText = "Cena Jednost.";
            this.colCenaJedn.Name = "colCenaJedn";
            this.colCenaJedn.ReadOnly = true;
            this.colCenaJedn.Width = 70;
            // 
            // colStawka
            // 
            this.colStawka.HeaderText = "Stawka";
            this.colStawka.Name = "colStawka";
            this.colStawka.ReadOnly = true;
            this.colStawka.Width = 50;
            // 
            // colBrutto
            // 
            this.colBrutto.HeaderText = "Cena Brutto";
            this.colBrutto.Name = "colBrutto";
            this.colBrutto.ReadOnly = true;
            this.colBrutto.Width = 70;
            // 
            // colVAT
            // 
            this.colVAT.HeaderText = "VAT%";
            this.colVAT.Name = "colVAT";
            this.colVAT.ReadOnly = true;
            this.colVAT.Width = 40;
            // 
            // colNetto
            // 
            this.colNetto.HeaderText = "Cena Netto";
            this.colNetto.Name = "colNetto";
            this.colNetto.ReadOnly = true;
            this.colNetto.Width = 70;
            // 
            // FrmFaktury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 862);
            this.Controls.Add(this.labelOdebral);
            this.Controls.Add(this.labelWystawil);
            this.Controls.Add(this.labelDoZaplaty);
            this.Controls.Add(this.labelTermin);
            this.Controls.Add(this.dataGridProdukty);
            this.Controls.Add(this.labelDataWystawienia);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelFaktura);
            this.Controls.Add(this.labelNabywca);
            this.Controls.Add(this.labelSprze);
            this.Name = "FrmFaktury";
            this.Text = "FrmFaktury";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdukty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSprze;
        private System.Windows.Forms.Label labelNabywca;
        private System.Windows.Forms.Label labelFaktura;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelDataWystawienia;
        private System.Windows.Forms.DataGridView dataGridProdukty;
        private System.Windows.Forms.Label labelTermin;
        private System.Windows.Forms.Label labelDoZaplaty;
        private System.Windows.Forms.Label labelWystawil;
        private System.Windows.Forms.Label labelOdebral;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSztuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCenaJedn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStawka;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrutto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetto;
    }
}
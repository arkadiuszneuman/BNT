namespace BNT
{
    partial class FrmStworzFakture
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
            this.buttonStworz = new System.Windows.Forms.Button();
            this.buttonWyjdz = new System.Windows.Forms.Button();
            this.dataGridStworzFakture = new System.Windows.Forms.DataGridView();
            this.dateTimeFaktura = new System.Windows.Forms.DateTimePicker();
            this.labelStawka = new System.Windows.Forms.Label();
            this.numericStawka = new System.Windows.Forms.NumericUpDown();
            this.labelProcent = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.colLp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIlosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStworzFakture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStawka)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStworz
            // 
            this.buttonStworz.Location = new System.Drawing.Point(12, 194);
            this.buttonStworz.Name = "buttonStworz";
            this.buttonStworz.Size = new System.Drawing.Size(90, 23);
            this.buttonStworz.TabIndex = 0;
            this.buttonStworz.Text = "Stwórz";
            this.buttonStworz.UseVisualStyleBackColor = true;
            this.buttonStworz.Click += new System.EventHandler(this.buttonStworz_Click);
            // 
            // buttonWyjdz
            // 
            this.buttonWyjdz.Location = new System.Drawing.Point(460, 194);
            this.buttonWyjdz.Name = "buttonWyjdz";
            this.buttonWyjdz.Size = new System.Drawing.Size(75, 23);
            this.buttonWyjdz.TabIndex = 1;
            this.buttonWyjdz.Text = "Wyjdź";
            this.buttonWyjdz.UseVisualStyleBackColor = true;
            this.buttonWyjdz.Click += new System.EventHandler(this.buttonWyjdz_Click);
            // 
            // dataGridStworzFakture
            // 
            this.dataGridStworzFakture.AllowUserToAddRows = false;
            this.dataGridStworzFakture.AllowUserToDeleteRows = false;
            this.dataGridStworzFakture.AllowUserToResizeColumns = false;
            this.dataGridStworzFakture.AllowUserToResizeRows = false;
            this.dataGridStworzFakture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStworzFakture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLp,
            this.colFirma,
            this.colMiasto,
            this.colModel,
            this.colIlosc,
            this.colCena});
            this.dataGridStworzFakture.Location = new System.Drawing.Point(12, 12);
            this.dataGridStworzFakture.MultiSelect = false;
            this.dataGridStworzFakture.Name = "dataGridStworzFakture";
            this.dataGridStworzFakture.ReadOnly = true;
            this.dataGridStworzFakture.RowHeadersVisible = false;
            this.dataGridStworzFakture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStworzFakture.Size = new System.Drawing.Size(523, 176);
            this.dataGridStworzFakture.TabIndex = 2;
            // 
            // dateTimeFaktura
            // 
            this.dateTimeFaktura.Location = new System.Drawing.Point(226, 197);
            this.dateTimeFaktura.Name = "dateTimeFaktura";
            this.dateTimeFaktura.Size = new System.Drawing.Size(228, 20);
            this.dateTimeFaktura.TabIndex = 3;
            // 
            // labelStawka
            // 
            this.labelStawka.AutoSize = true;
            this.labelStawka.Location = new System.Drawing.Point(108, 199);
            this.labelStawka.Name = "labelStawka";
            this.labelStawka.Size = new System.Drawing.Size(46, 13);
            this.labelStawka.TabIndex = 4;
            this.labelStawka.Text = "Stawka:";
            // 
            // numericStawka
            // 
            this.numericStawka.Location = new System.Drawing.Point(160, 197);
            this.numericStawka.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericStawka.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericStawka.Name = "numericStawka";
            this.numericStawka.Size = new System.Drawing.Size(39, 20);
            this.numericStawka.TabIndex = 5;
            this.numericStawka.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelProcent
            // 
            this.labelProcent.AutoSize = true;
            this.labelProcent.Location = new System.Drawing.Point(205, 199);
            this.labelProcent.Name = "labelProcent";
            this.labelProcent.Size = new System.Drawing.Size(15, 13);
            this.labelProcent.TabIndex = 6;
            this.labelProcent.Text = "%";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(9, 220);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(190, 13);
            this.labelInfo.TabIndex = 7;
            this.labelInfo.Text = "* cena nie uwzględnia dzierżawy słupa";
            // 
            // colLp
            // 
            this.colLp.HeaderText = "Lp";
            this.colLp.Name = "colLp";
            this.colLp.ReadOnly = true;
            this.colLp.Width = 30;
            // 
            // colFirma
            // 
            this.colFirma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFirma.HeaderText = "Firma";
            this.colFirma.Name = "colFirma";
            this.colFirma.ReadOnly = true;
            // 
            // colMiasto
            // 
            this.colMiasto.HeaderText = "Słup z miasta";
            this.colMiasto.Name = "colMiasto";
            this.colMiasto.ReadOnly = true;
            // 
            // colModel
            // 
            this.colModel.HeaderText = "Model nadajnika";
            this.colModel.Name = "colModel";
            this.colModel.ReadOnly = true;
            // 
            // colIlosc
            // 
            this.colIlosc.HeaderText = "Sztuk";
            this.colIlosc.Name = "colIlosc";
            this.colIlosc.ReadOnly = true;
            this.colIlosc.Width = 50;
            // 
            // colCena
            // 
            this.colCena.HeaderText = "Cena*";
            this.colCena.Name = "colCena";
            this.colCena.ReadOnly = true;
            this.colCena.Width = 60;
            // 
            // FrmStworzFakture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 242);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelProcent);
            this.Controls.Add(this.numericStawka);
            this.Controls.Add(this.labelStawka);
            this.Controls.Add(this.dateTimeFaktura);
            this.Controls.Add(this.dataGridStworzFakture);
            this.Controls.Add(this.buttonWyjdz);
            this.Controls.Add(this.buttonStworz);
            this.Name = "FrmStworzFakture";
            this.Text = "Stwórz Fakturę";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStworzFakture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStawka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStworz;
        private System.Windows.Forms.Button buttonWyjdz;
        private System.Windows.Forms.DataGridView dataGridStworzFakture;
        private System.Windows.Forms.DateTimePicker dateTimeFaktura;
        private System.Windows.Forms.Label labelStawka;
        private System.Windows.Forms.NumericUpDown numericStawka;
        private System.Windows.Forms.Label labelProcent;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIlosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCena;
    }
}
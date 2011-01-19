namespace BNT
{
    partial class FrmNadajniki
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
            this.buttonDodajLubZmien = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMiasto = new System.Windows.Forms.ComboBox();
            this.numericN = new System.Windows.Forms.NumericUpDown();
            this.numericS = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericZl = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZl)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDodajLubZmien
            // 
            this.buttonDodajLubZmien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDodajLubZmien.Location = new System.Drawing.Point(12, 114);
            this.buttonDodajLubZmien.Name = "buttonDodajLubZmien";
            this.buttonDodajLubZmien.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajLubZmien.TabIndex = 0;
            this.buttonDodajLubZmien.Text = "Dodaj";
            this.buttonDodajLubZmien.UseVisualStyleBackColor = true;
            this.buttonDodajLubZmien.Click += new System.EventHandler(this.buttonDodajLubZmien_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnuluj.Location = new System.Drawing.Point(276, 114);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuluj.TabIndex = 1;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Miasto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Współrzędne:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cena za dzierżawę:";
            // 
            // comboBoxMiasto
            // 
            this.comboBoxMiasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxMiasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMiasto.FormattingEnabled = true;
            this.comboBoxMiasto.Location = new System.Drawing.Point(131, 22);
            this.comboBoxMiasto.MaxDropDownItems = 100;
            this.comboBoxMiasto.Name = "comboBoxMiasto";
            this.comboBoxMiasto.Size = new System.Drawing.Size(165, 21);
            this.comboBoxMiasto.TabIndex = 5;
            // 
            // numericN
            // 
            this.numericN.Location = new System.Drawing.Point(131, 49);
            this.numericN.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericN.Name = "numericN";
            this.numericN.Size = new System.Drawing.Size(59, 20);
            this.numericN.TabIndex = 6;
            this.numericN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericS
            // 
            this.numericS.Location = new System.Drawing.Point(217, 49);
            this.numericS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericS.Name = "numericS";
            this.numericS.Size = new System.Drawing.Size(59, 20);
            this.numericS.TabIndex = 7;
            this.numericS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "N";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "S";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "zł";
            // 
            // numericZl
            // 
            this.numericZl.DecimalPlaces = 2;
            this.numericZl.Location = new System.Drawing.Point(131, 76);
            this.numericZl.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericZl.Name = "numericZl";
            this.numericZl.Size = new System.Drawing.Size(143, 20);
            this.numericZl.TabIndex = 12;
            this.numericZl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmNadajniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 149);
            this.Controls.Add(this.numericZl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericS);
            this.Controls.Add(this.numericN);
            this.Controls.Add(this.comboBoxMiasto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonDodajLubZmien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmNadajniki";
            this.Text = "Nadajniki";
            ((System.ComponentModel.ISupportInitialize)(this.numericN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodajLubZmien;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMiasto;
        private System.Windows.Forms.NumericUpDown numericN;
        private System.Windows.Forms.NumericUpDown numericS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericZl;
    }
}
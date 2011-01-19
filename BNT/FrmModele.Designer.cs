namespace BNT
{
    partial class FrmModele
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
            this.numericZasieg = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericCena = new System.Windows.Forms.NumericUpDown();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericZasieg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCena)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zasięg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cena:";
            // 
            // numericZasieg
            // 
            this.numericZasieg.Location = new System.Drawing.Point(131, 49);
            this.numericZasieg.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericZasieg.Name = "numericZasieg";
            this.numericZasieg.Size = new System.Drawing.Size(118, 20);
            this.numericZasieg.TabIndex = 7;
            this.numericZasieg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "zł";
            // 
            // numericCena
            // 
            this.numericCena.DecimalPlaces = 2;
            this.numericCena.Location = new System.Drawing.Point(131, 76);
            this.numericCena.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericCena.Name = "numericCena";
            this.numericCena.Size = new System.Drawing.Size(118, 20);
            this.numericCena.TabIndex = 12;
            this.numericCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(131, 22);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(145, 20);
            this.textBoxNazwa.TabIndex = 13;
            // 
            // FrmModele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 149);
            this.Controls.Add(this.textBoxNazwa);
            this.Controls.Add(this.numericCena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericZasieg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonDodajLubZmien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmModele";
            this.Text = "Słupy";
            ((System.ComponentModel.ISupportInitialize)(this.numericZasieg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodajLubZmien;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericZasieg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericCena;
        private System.Windows.Forms.TextBox textBoxNazwa;
    }
}
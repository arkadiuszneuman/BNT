namespace BNT
{
    partial class FrmFirmy
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
            this.comboBoxMiasto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxUlica = new System.Windows.Forms.TextBox();
            this.maskedTextBoxKod = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNip = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRegon = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.listBoxNadajniki = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNadajniki = new System.Windows.Forms.ComboBox();
            this.buttonDodajNadajnik = new System.Windows.Forms.Button();
            this.buttonUsunNadajnik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDodajLubZmien
            // 
            this.buttonDodajLubZmien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDodajLubZmien.Location = new System.Drawing.Point(12, 294);
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
            this.buttonAnuluj.Location = new System.Drawing.Point(306, 294);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Imię:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nazwisko:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nazwa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ulica:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Kod Pocztowy:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Nip:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Regon:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Telefon";
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(131, 49);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(165, 20);
            this.textBoxNazwa.TabIndex = 21;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(131, 75);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(165, 20);
            this.textBoxImie.TabIndex = 22;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(131, 101);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(165, 20);
            this.textBoxNazwisko.TabIndex = 23;
            // 
            // textBoxUlica
            // 
            this.textBoxUlica.Location = new System.Drawing.Point(131, 127);
            this.textBoxUlica.Name = "textBoxUlica";
            this.textBoxUlica.Size = new System.Drawing.Size(165, 20);
            this.textBoxUlica.TabIndex = 24;
            // 
            // maskedTextBoxKod
            // 
            this.maskedTextBoxKod.Location = new System.Drawing.Point(131, 153);
            this.maskedTextBoxKod.Mask = "00-999";
            this.maskedTextBoxKod.Name = "maskedTextBoxKod";
            this.maskedTextBoxKod.Size = new System.Drawing.Size(165, 20);
            this.maskedTextBoxKod.TabIndex = 25;
            this.maskedTextBoxKod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maskedTextBoxNip
            // 
            this.maskedTextBoxNip.Location = new System.Drawing.Point(131, 179);
            this.maskedTextBoxNip.Mask = "000-999-00-00";
            this.maskedTextBoxNip.Name = "maskedTextBoxNip";
            this.maskedTextBoxNip.Size = new System.Drawing.Size(165, 20);
            this.maskedTextBoxNip.TabIndex = 26;
            this.maskedTextBoxNip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maskedTextBoxRegon
            // 
            this.maskedTextBoxRegon.Location = new System.Drawing.Point(131, 205);
            this.maskedTextBoxRegon.Mask = "000000000";
            this.maskedTextBoxRegon.Name = "maskedTextBoxRegon";
            this.maskedTextBoxRegon.Size = new System.Drawing.Size(165, 20);
            this.maskedTextBoxRegon.TabIndex = 27;
            this.maskedTextBoxRegon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maskedTextBoxTelefon
            // 
            this.maskedTextBoxTelefon.Location = new System.Drawing.Point(131, 231);
            this.maskedTextBoxTelefon.Mask = "000-999-000";
            this.maskedTextBoxTelefon.Name = "maskedTextBoxTelefon";
            this.maskedTextBoxTelefon.Size = new System.Drawing.Size(165, 20);
            this.maskedTextBoxTelefon.TabIndex = 28;
            this.maskedTextBoxTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listBoxNadajniki
            // 
            this.listBoxNadajniki.FormattingEnabled = true;
            this.listBoxNadajniki.Location = new System.Drawing.Point(316, 41);
            this.listBoxNadajniki.Name = "listBoxNadajniki";
            this.listBoxNadajniki.Size = new System.Drawing.Size(68, 134);
            this.listBoxNadajniki.Sorted = true;
            this.listBoxNadajniki.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nadajniki:";
            // 
            // comboBoxNadajniki
            // 
            this.comboBoxNadajniki.FormattingEnabled = true;
            this.comboBoxNadajniki.Location = new System.Drawing.Point(316, 178);
            this.comboBoxNadajniki.Name = "comboBoxNadajniki";
            this.comboBoxNadajniki.Size = new System.Drawing.Size(68, 21);
            this.comboBoxNadajniki.TabIndex = 31;
            // 
            // buttonDodajNadajnik
            // 
            this.buttonDodajNadajnik.Location = new System.Drawing.Point(316, 204);
            this.buttonDodajNadajnik.Name = "buttonDodajNadajnik";
            this.buttonDodajNadajnik.Size = new System.Drawing.Size(68, 23);
            this.buttonDodajNadajnik.TabIndex = 32;
            this.buttonDodajNadajnik.Text = "Dodaj";
            this.buttonDodajNadajnik.UseVisualStyleBackColor = true;
            this.buttonDodajNadajnik.Click += new System.EventHandler(this.buttonDodajNadajnik_Click);
            // 
            // buttonUsunNadajnik
            // 
            this.buttonUsunNadajnik.Location = new System.Drawing.Point(316, 233);
            this.buttonUsunNadajnik.Name = "buttonUsunNadajnik";
            this.buttonUsunNadajnik.Size = new System.Drawing.Size(68, 23);
            this.buttonUsunNadajnik.TabIndex = 33;
            this.buttonUsunNadajnik.Text = "Usuń";
            this.buttonUsunNadajnik.UseVisualStyleBackColor = true;
            this.buttonUsunNadajnik.Click += new System.EventHandler(this.buttonUsunNadajnik_Click);
            // 
            // FrmFirmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 329);
            this.Controls.Add(this.buttonUsunNadajnik);
            this.Controls.Add(this.buttonDodajNadajnik);
            this.Controls.Add(this.comboBoxNadajniki);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxNadajniki);
            this.Controls.Add(this.maskedTextBoxTelefon);
            this.Controls.Add(this.maskedTextBoxRegon);
            this.Controls.Add(this.maskedTextBoxNip);
            this.Controls.Add(this.maskedTextBoxKod);
            this.Controls.Add(this.textBoxUlica);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.textBoxNazwa);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxMiasto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonDodajLubZmien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmFirmy";
            this.Text = "Słupy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodajLubZmien;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMiasto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxUlica;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKod;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNip;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRegon;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefon;
        private System.Windows.Forms.ListBox listBoxNadajniki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNadajniki;
        private System.Windows.Forms.Button buttonDodajNadajnik;
        private System.Windows.Forms.Button buttonUsunNadajnik;
    }
}
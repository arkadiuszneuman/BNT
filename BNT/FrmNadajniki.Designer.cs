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
            this.comboBoxSlupy = new System.Windows.Forms.ComboBox();
            this.numericIlosc = new System.Windows.Forms.NumericUpDown();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericIlosc)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Słup nr:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ilość:";
            // 
            // comboBoxSlupy
            // 
            this.comboBoxSlupy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSlupy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSlupy.FormattingEnabled = true;
            this.comboBoxSlupy.Location = new System.Drawing.Point(131, 22);
            this.comboBoxSlupy.MaxDropDownItems = 100;
            this.comboBoxSlupy.Name = "comboBoxSlupy";
            this.comboBoxSlupy.Size = new System.Drawing.Size(165, 21);
            this.comboBoxSlupy.TabIndex = 5;
            // 
            // numericIlosc
            // 
            this.numericIlosc.Location = new System.Drawing.Point(131, 76);
            this.numericIlosc.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericIlosc.Name = "numericIlosc";
            this.numericIlosc.Size = new System.Drawing.Size(165, 20);
            this.numericIlosc.TabIndex = 12;
            this.numericIlosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(131, 48);
            this.comboBoxModel.MaxDropDownItems = 100;
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(165, 21);
            this.comboBoxModel.TabIndex = 13;
            // 
            // FrmNadajniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 149);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.numericIlosc);
            this.Controls.Add(this.comboBoxSlupy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonDodajLubZmien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmNadajniki";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Nadajniki";
            ((System.ComponentModel.ISupportInitialize)(this.numericIlosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodajLubZmien;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSlupy;
        private System.Windows.Forms.NumericUpDown numericIlosc;
        private System.Windows.Forms.ComboBox comboBoxModel;
    }
}
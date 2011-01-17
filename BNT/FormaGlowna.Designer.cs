namespace BNT
{
    partial class FormaGlowna
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMapa = new System.Windows.Forms.TabPage();
            this.panelMiasto = new System.Windows.Forms.Panel();
            this.labelFirmy = new System.Windows.Forms.Label();
            this.labelNadajniki = new System.Windows.Forms.Label();
            this.labelSlupy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMiasto = new System.Windows.Forms.Label();
            this.buttonDodajMiasto = new System.Windows.Forms.Button();
            this.pictureBoxMapa = new System.Windows.Forms.PictureBox();
            this.tabSlupy = new System.Windows.Forms.TabPage();
            this.dataGridSlupy = new System.Windows.Forms.DataGridView();
            this.colMiasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celCena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirmy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrzychod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNadajniki = new System.Windows.Forms.TabPage();
            this.tabModele = new System.Windows.Forms.TabPage();
            this.tabFirmy = new System.Windows.Forms.TabPage();
            this.tabFaktury = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabMapa.SuspendLayout();
            this.panelMiasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapa)).BeginInit();
            this.tabSlupy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSlupy)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMapa);
            this.tabControl.Controls.Add(this.tabSlupy);
            this.tabControl.Controls.Add(this.tabNadajniki);
            this.tabControl.Controls.Add(this.tabModele);
            this.tabControl.Controls.Add(this.tabFirmy);
            this.tabControl.Controls.Add(this.tabFaktury);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(564, 525);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabMapa
            // 
            this.tabMapa.Controls.Add(this.panelMiasto);
            this.tabMapa.Controls.Add(this.buttonDodajMiasto);
            this.tabMapa.Controls.Add(this.pictureBoxMapa);
            this.tabMapa.Location = new System.Drawing.Point(4, 22);
            this.tabMapa.Name = "tabMapa";
            this.tabMapa.Padding = new System.Windows.Forms.Padding(3);
            this.tabMapa.Size = new System.Drawing.Size(556, 499);
            this.tabMapa.TabIndex = 0;
            this.tabMapa.Text = "Mapa";
            this.tabMapa.UseVisualStyleBackColor = true;
            // 
            // panelMiasto
            // 
            this.panelMiasto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMiasto.Controls.Add(this.labelFirmy);
            this.panelMiasto.Controls.Add(this.labelNadajniki);
            this.panelMiasto.Controls.Add(this.labelSlupy);
            this.panelMiasto.Controls.Add(this.label4);
            this.panelMiasto.Controls.Add(this.label2);
            this.panelMiasto.Controls.Add(this.label1);
            this.panelMiasto.Controls.Add(this.labelMiasto);
            this.panelMiasto.Location = new System.Drawing.Point(260, 137);
            this.panelMiasto.Name = "panelMiasto";
            this.panelMiasto.Size = new System.Drawing.Size(177, 108);
            this.panelMiasto.TabIndex = 2;
            // 
            // labelFirmy
            // 
            this.labelFirmy.Location = new System.Drawing.Point(101, 84);
            this.labelFirmy.Name = "labelFirmy";
            this.labelFirmy.Size = new System.Drawing.Size(71, 13);
            this.labelFirmy.TabIndex = 8;
            // 
            // labelNadajniki
            // 
            this.labelNadajniki.Location = new System.Drawing.Point(101, 61);
            this.labelNadajniki.Name = "labelNadajniki";
            this.labelNadajniki.Size = new System.Drawing.Size(71, 13);
            this.labelNadajniki.TabIndex = 6;
            // 
            // labelSlupy
            // 
            this.labelSlupy.Location = new System.Drawing.Point(101, 38);
            this.labelSlupy.Name = "labelSlupy";
            this.labelSlupy.Size = new System.Drawing.Size(71, 13);
            this.labelSlupy.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ilość firm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ilość nadajników:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość słupów:";
            // 
            // labelMiasto
            // 
            this.labelMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMiasto.Location = new System.Drawing.Point(3, 0);
            this.labelMiasto.Name = "labelMiasto";
            this.labelMiasto.Size = new System.Drawing.Size(169, 29);
            this.labelMiasto.TabIndex = 0;
            this.labelMiasto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDodajMiasto
            // 
            this.buttonDodajMiasto.Location = new System.Drawing.Point(3, 468);
            this.buttonDodajMiasto.Name = "buttonDodajMiasto";
            this.buttonDodajMiasto.Size = new System.Drawing.Size(96, 28);
            this.buttonDodajMiasto.TabIndex = 1;
            this.buttonDodajMiasto.Text = "Dodaj Miasto";
            this.buttonDodajMiasto.UseVisualStyleBackColor = true;
            this.buttonDodajMiasto.Click += new System.EventHandler(this.buttonDodajMiasto_Click);
            // 
            // pictureBoxMapa
            // 
            this.pictureBoxMapa.Image = global::BNT.Properties.Resources.polska_kontur_maly;
            this.pictureBoxMapa.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMapa.Name = "pictureBoxMapa";
            this.pictureBoxMapa.Size = new System.Drawing.Size(544, 503);
            this.pictureBoxMapa.TabIndex = 0;
            this.pictureBoxMapa.TabStop = false;
            this.pictureBoxMapa.Click += new System.EventHandler(this.pictureBoxMapa_Click);
            // 
            // tabSlupy
            // 
            this.tabSlupy.Controls.Add(this.dataGridSlupy);
            this.tabSlupy.Location = new System.Drawing.Point(4, 22);
            this.tabSlupy.Name = "tabSlupy";
            this.tabSlupy.Size = new System.Drawing.Size(556, 499);
            this.tabSlupy.TabIndex = 1;
            this.tabSlupy.Text = "Słupy";
            this.tabSlupy.UseVisualStyleBackColor = true;
            // 
            // dataGridSlupy
            // 
            this.dataGridSlupy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSlupy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSlupy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMiasto,
            this.colWsp,
            this.celCena,
            this.colFirmy,
            this.colPrzychod});
            this.dataGridSlupy.Location = new System.Drawing.Point(3, 3);
            this.dataGridSlupy.Name = "dataGridSlupy";
            this.dataGridSlupy.Size = new System.Drawing.Size(545, 438);
            this.dataGridSlupy.TabIndex = 0;
            // 
            // colMiasto
            // 
            this.colMiasto.HeaderText = "Miasto";
            this.colMiasto.Name = "colMiasto";
            // 
            // colWsp
            // 
            this.colWsp.HeaderText = "Współrzędne";
            this.colWsp.Name = "colWsp";
            // 
            // celCena
            // 
            this.celCena.HeaderText = "Cena";
            this.celCena.Name = "celCena";
            // 
            // colFirmy
            // 
            this.colFirmy.HeaderText = "Firmy";
            this.colFirmy.Name = "colFirmy";
            // 
            // colPrzychod
            // 
            this.colPrzychod.HeaderText = "Przychód miesięczny";
            this.colPrzychod.Name = "colPrzychod";
            // 
            // tabNadajniki
            // 
            this.tabNadajniki.Location = new System.Drawing.Point(4, 22);
            this.tabNadajniki.Name = "tabNadajniki";
            this.tabNadajniki.Size = new System.Drawing.Size(541, 499);
            this.tabNadajniki.TabIndex = 2;
            this.tabNadajniki.Text = "Nadajniki";
            this.tabNadajniki.UseVisualStyleBackColor = true;
            // 
            // tabModele
            // 
            this.tabModele.Location = new System.Drawing.Point(4, 22);
            this.tabModele.Name = "tabModele";
            this.tabModele.Size = new System.Drawing.Size(541, 499);
            this.tabModele.TabIndex = 3;
            this.tabModele.Text = "Modele";
            this.tabModele.UseVisualStyleBackColor = true;
            // 
            // tabFirmy
            // 
            this.tabFirmy.Location = new System.Drawing.Point(4, 22);
            this.tabFirmy.Name = "tabFirmy";
            this.tabFirmy.Size = new System.Drawing.Size(541, 499);
            this.tabFirmy.TabIndex = 4;
            this.tabFirmy.Text = "Firmy";
            this.tabFirmy.UseVisualStyleBackColor = true;
            // 
            // tabFaktury
            // 
            this.tabFaktury.Location = new System.Drawing.Point(4, 22);
            this.tabFaktury.Name = "tabFaktury";
            this.tabFaktury.Size = new System.Drawing.Size(541, 499);
            this.tabFaktury.TabIndex = 5;
            this.tabFaktury.Text = "Faktury";
            this.tabFaktury.UseVisualStyleBackColor = true;
            // 
            // FormaGlowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 525);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormaGlowna";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabMapa.ResumeLayout(false);
            this.panelMiasto.ResumeLayout(false);
            this.panelMiasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapa)).EndInit();
            this.tabSlupy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSlupy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMapa;
        private System.Windows.Forms.PictureBox pictureBoxMapa;
        private System.Windows.Forms.Button buttonDodajMiasto;
        private System.Windows.Forms.Panel panelMiasto;
        private System.Windows.Forms.Label labelFirmy;
        private System.Windows.Forms.Label labelNadajniki;
        private System.Windows.Forms.Label labelSlupy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMiasto;
        private System.Windows.Forms.TabPage tabSlupy;
        private System.Windows.Forms.DataGridView dataGridSlupy;
        private System.Windows.Forms.TabPage tabNadajniki;
        private System.Windows.Forms.TabPage tabModele;
        private System.Windows.Forms.TabPage tabFirmy;
        private System.Windows.Forms.TabPage tabFaktury;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn celCena;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirmy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrzychod;
    }
}


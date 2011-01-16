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
            this.buttonDodajMiasto = new System.Windows.Forms.Button();
            this.pictureBoxMapa = new System.Windows.Forms.PictureBox();
            this.panelMiasto = new System.Windows.Forms.Panel();
            this.labelMiasto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSlupy = new System.Windows.Forms.Label();
            this.labelNadajniki = new System.Windows.Forms.Label();
            this.labelFirmy = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabMapa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapa)).BeginInit();
            this.panelMiasto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMapa);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(549, 525);
            this.tabControl.TabIndex = 1;
            // 
            // tabMapa
            // 
            this.tabMapa.Controls.Add(this.panelMiasto);
            this.tabMapa.Controls.Add(this.buttonDodajMiasto);
            this.tabMapa.Controls.Add(this.pictureBoxMapa);
            this.tabMapa.Location = new System.Drawing.Point(4, 22);
            this.tabMapa.Name = "tabMapa";
            this.tabMapa.Padding = new System.Windows.Forms.Padding(3);
            this.tabMapa.Size = new System.Drawing.Size(541, 499);
            this.tabMapa.TabIndex = 0;
            this.tabMapa.Text = "Mapa";
            this.tabMapa.UseVisualStyleBackColor = true;
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
            // labelMiasto
            // 
            this.labelMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMiasto.Location = new System.Drawing.Point(3, 0);
            this.labelMiasto.Name = "labelMiasto";
            this.labelMiasto.Size = new System.Drawing.Size(169, 29);
            this.labelMiasto.TabIndex = 0;
            this.labelMiasto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ilość nadajników:";
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
            // labelSlupy
            // 
            this.labelSlupy.Location = new System.Drawing.Point(101, 38);
            this.labelSlupy.Name = "labelSlupy";
            this.labelSlupy.Size = new System.Drawing.Size(71, 13);
            this.labelSlupy.TabIndex = 5;
            // 
            // labelNadajniki
            // 
            this.labelNadajniki.Location = new System.Drawing.Point(101, 61);
            this.labelNadajniki.Name = "labelNadajniki";
            this.labelNadajniki.Size = new System.Drawing.Size(71, 13);
            this.labelNadajniki.TabIndex = 6;
            // 
            // labelFirmy
            // 
            this.labelFirmy.Location = new System.Drawing.Point(101, 84);
            this.labelFirmy.Name = "labelFirmy";
            this.labelFirmy.Size = new System.Drawing.Size(71, 13);
            this.labelFirmy.TabIndex = 8;
            // 
            // FormaGlowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 525);
            this.Controls.Add(this.tabControl);
            this.Name = "FormaGlowna";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabMapa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapa)).EndInit();
            this.panelMiasto.ResumeLayout(false);
            this.panelMiasto.PerformLayout();
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
    }
}


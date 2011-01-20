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
            this.colNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirmy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrzychod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNadajniki = new System.Windows.Forms.TabPage();
<<<<<<< HEAD
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            this.dataGridNadajniki = new System.Windows.Forms.DataGridView();
            this.colNrNadajniki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirmaNadajniki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNrSlupuNadajniki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelNadajniki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIloscNadajniki = new System.Windows.Forms.DataGridViewTextBoxColumn();
>>>>>>> origin/master
            this.tabModele = new System.Windows.Forms.TabPage();
            this.dataGridModele = new System.Windows.Forms.DataGridView();
            this.tabFirmy = new System.Windows.Forms.TabPage();
            this.tabFaktury = new System.Windows.Forms.TabPage();
            this.radioData = new System.Windows.Forms.RadioButton();
            this.radioTabela = new System.Windows.Forms.RadioButton();
            this.buttonStworzFakture = new System.Windows.Forms.Button();
            this.dataGridFaktury = new System.Windows.Forms.DataGridView();
            this.colLp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataWystawienia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMnoznik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPokaz = new System.Windows.Forms.Button();
            this.comboRok = new System.Windows.Forms.ComboBox();
            this.comboMiesiace = new System.Windows.Forms.ComboBox();
            this.comboFirmy = new System.Windows.Forms.ComboBox();
            this.napis_rok = new System.Windows.Forms.Label();
            this.napis_miesiac = new System.Windows.Forms.Label();
            this.napis_firma = new System.Windows.Forms.Label();
<<<<<<< HEAD
=======
            this.colIdModele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNazwaModele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZasiegModele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCenaModele = new System.Windows.Forms.DataGridViewTextBoxColumn();
>>>>>>> origin/master
            this.tabControl.SuspendLayout();
            this.tabMapa.SuspendLayout();
            this.panelMiasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapa)).BeginInit();
            this.tabSlupy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSlupy)).BeginInit();
            this.tabNadajniki.SuspendLayout();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNadajniki)).BeginInit();
            this.tabModele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModele)).BeginInit();
>>>>>>> origin/master
            this.tabFaktury.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFaktury)).BeginInit();
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
            this.panelMiasto.BackColor = System.Drawing.Color.LightGoldenrodYellow;
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
            this.dataGridSlupy.AllowUserToAddRows = false;
            this.dataGridSlupy.AllowUserToDeleteRows = false;
            this.dataGridSlupy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSlupy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSlupy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNr,
            this.colMiasto,
            this.colWsp,
            this.colCena,
            this.colFirmy,
            this.colPrzychod});
            this.dataGridSlupy.Location = new System.Drawing.Point(3, 3);
            this.dataGridSlupy.MultiSelect = false;
            this.dataGridSlupy.Name = "dataGridSlupy";
            this.dataGridSlupy.ReadOnly = true;
            this.dataGridSlupy.RowHeadersVisible = false;
            this.dataGridSlupy.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSlupy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSlupy.Size = new System.Drawing.Size(545, 459);
            this.dataGridSlupy.TabIndex = 0;
            // 
            // colNr
            // 
            this.colNr.HeaderText = "Nr";
            this.colNr.Name = "colNr";
            this.colNr.ReadOnly = true;
            this.colNr.Width = 30;
            // 
            // colMiasto
            // 
            this.colMiasto.HeaderText = "Miasto";
            this.colMiasto.Name = "colMiasto";
            this.colMiasto.ReadOnly = true;
            // 
            // colWsp
            // 
            this.colWsp.HeaderText = "Współrzędne";
            this.colWsp.Name = "colWsp";
            this.colWsp.ReadOnly = true;
            // 
            // colCena
            // 
            this.colCena.HeaderText = "Cena";
            this.colCena.Name = "colCena";
            this.colCena.ReadOnly = true;
            // 
            // colFirmy
            // 
            this.colFirmy.HeaderText = "Firmy";
            this.colFirmy.Name = "colFirmy";
            this.colFirmy.ReadOnly = true;
            this.colFirmy.Width = 130;
            // 
            // colPrzychod
            // 
            this.colPrzychod.HeaderText = "Przychód miesięczny";
            this.colPrzychod.Name = "colPrzychod";
            this.colPrzychod.ReadOnly = true;
            // 
            // tabNadajniki
            // 
            this.tabNadajniki.Controls.Add(this.dataGridNadajniki);
            this.tabNadajniki.Location = new System.Drawing.Point(4, 22);
            this.tabNadajniki.Name = "tabNadajniki";
            this.tabNadajniki.Size = new System.Drawing.Size(556, 499);
            this.tabNadajniki.TabIndex = 2;
            this.tabNadajniki.Text = "Nadajniki";
            this.tabNadajniki.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(545, 459);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nr";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Miasto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Współrzędne";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cena";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Firmy";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Przychód miesięczny";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
=======
            // dataGridNadajniki
            // 
            this.dataGridNadajniki.AllowUserToAddRows = false;
            this.dataGridNadajniki.AllowUserToDeleteRows = false;
            this.dataGridNadajniki.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridNadajniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNadajniki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNrNadajniki,
            this.colFirmaNadajniki,
            this.colNrSlupuNadajniki,
            this.colModelNadajniki,
            this.colIloscNadajniki});
            this.dataGridNadajniki.Location = new System.Drawing.Point(3, 3);
            this.dataGridNadajniki.MultiSelect = false;
            this.dataGridNadajniki.Name = "dataGridNadajniki";
            this.dataGridNadajniki.ReadOnly = true;
            this.dataGridNadajniki.RowHeadersVisible = false;
            this.dataGridNadajniki.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridNadajniki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridNadajniki.Size = new System.Drawing.Size(545, 459);
            this.dataGridNadajniki.TabIndex = 1;
            // 
            // colNrNadajniki
            // 
            this.colNrNadajniki.HeaderText = "Nr";
            this.colNrNadajniki.Name = "colNrNadajniki";
            this.colNrNadajniki.ReadOnly = true;
            this.colNrNadajniki.Width = 30;
            // 
            // colFirmaNadajniki
            // 
            this.colFirmaNadajniki.HeaderText = "Firma";
            this.colFirmaNadajniki.Name = "colFirmaNadajniki";
            this.colFirmaNadajniki.ReadOnly = true;
            // 
            // colNrSlupuNadajniki
            // 
            this.colNrSlupuNadajniki.HeaderText = "Nr słupu";
            this.colNrSlupuNadajniki.Name = "colNrSlupuNadajniki";
            this.colNrSlupuNadajniki.ReadOnly = true;
            // 
            // colModelNadajniki
            // 
            this.colModelNadajniki.HeaderText = "Model";
            this.colModelNadajniki.Name = "colModelNadajniki";
            this.colModelNadajniki.ReadOnly = true;
            // 
            // colIloscNadajniki
            // 
            this.colIloscNadajniki.HeaderText = "Ilość nadajników";
            this.colIloscNadajniki.Name = "colIloscNadajniki";
            this.colIloscNadajniki.ReadOnly = true;
            this.colIloscNadajniki.Width = 130;
>>>>>>> origin/master
            // 
            // tabModele
            // 
            this.tabModele.Controls.Add(this.dataGridModele);
            this.tabModele.Location = new System.Drawing.Point(4, 22);
            this.tabModele.Name = "tabModele";
            this.tabModele.Size = new System.Drawing.Size(556, 499);
            this.tabModele.TabIndex = 3;
            this.tabModele.Text = "Modele";
            this.tabModele.UseVisualStyleBackColor = true;
            // 
            // dataGridModele
            // 
            this.dataGridModele.AllowUserToAddRows = false;
            this.dataGridModele.AllowUserToDeleteRows = false;
            this.dataGridModele.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridModele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridModele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdModele,
            this.colNazwaModele,
            this.colZasiegModele,
            this.colCenaModele});
            this.dataGridModele.Location = new System.Drawing.Point(3, 3);
            this.dataGridModele.MultiSelect = false;
            this.dataGridModele.Name = "dataGridModele";
            this.dataGridModele.ReadOnly = true;
            this.dataGridModele.RowHeadersVisible = false;
            this.dataGridModele.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridModele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridModele.Size = new System.Drawing.Size(545, 459);
            this.dataGridModele.TabIndex = 2;
            // 
            // tabFirmy
            // 
            this.tabFirmy.Location = new System.Drawing.Point(4, 22);
            this.tabFirmy.Name = "tabFirmy";
            this.tabFirmy.Size = new System.Drawing.Size(556, 499);
            this.tabFirmy.TabIndex = 4;
            this.tabFirmy.Text = "Firmy";
            this.tabFirmy.UseVisualStyleBackColor = true;
            // 
            // tabFaktury
            // 
            this.tabFaktury.Controls.Add(this.radioData);
            this.tabFaktury.Controls.Add(this.radioTabela);
            this.tabFaktury.Controls.Add(this.buttonStworzFakture);
            this.tabFaktury.Controls.Add(this.dataGridFaktury);
            this.tabFaktury.Controls.Add(this.buttonPokaz);
            this.tabFaktury.Controls.Add(this.comboRok);
            this.tabFaktury.Controls.Add(this.comboMiesiace);
            this.tabFaktury.Controls.Add(this.comboFirmy);
            this.tabFaktury.Controls.Add(this.napis_rok);
            this.tabFaktury.Controls.Add(this.napis_miesiac);
            this.tabFaktury.Controls.Add(this.napis_firma);
            this.tabFaktury.Location = new System.Drawing.Point(4, 22);
            this.tabFaktury.Name = "tabFaktury";
            this.tabFaktury.Size = new System.Drawing.Size(556, 499);
            this.tabFaktury.TabIndex = 5;
            this.tabFaktury.Text = "Faktury";
            this.tabFaktury.UseVisualStyleBackColor = true;
            // 
            // radioData
            // 
            this.radioData.AutoSize = true;
            this.radioData.Enabled = false;
            this.radioData.Location = new System.Drawing.Point(18, 50);
            this.radioData.Name = "radioData";
            this.radioData.Size = new System.Drawing.Size(101, 17);
            this.radioData.TabIndex = 10;
            this.radioData.TabStop = true;
            this.radioData.Text = "Wybierz miesiąc";
            this.radioData.UseVisualStyleBackColor = true;
            // 
            // radioTabela
            // 
            this.radioTabela.AutoSize = true;
            this.radioTabela.Enabled = false;
            this.radioTabela.Location = new System.Drawing.Point(18, 110);
            this.radioTabela.Name = "radioTabela";
            this.radioTabela.Size = new System.Drawing.Size(96, 17);
            this.radioTabela.TabIndex = 9;
            this.radioTabela.TabStop = true;
            this.radioTabela.Text = "Szukaj w tabeli";
            this.radioTabela.UseVisualStyleBackColor = true;
            // 
            // buttonStworzFakture
            // 
            this.buttonStworzFakture.Location = new System.Drawing.Point(367, 15);
            this.buttonStworzFakture.Name = "buttonStworzFakture";
            this.buttonStworzFakture.Size = new System.Drawing.Size(170, 23);
            this.buttonStworzFakture.TabIndex = 8;
            this.buttonStworzFakture.Text = "Stwórz fakturę";
            this.buttonStworzFakture.UseVisualStyleBackColor = true;
            // 
            // dataGridFaktury
            // 
            this.dataGridFaktury.AllowUserToAddRows = false;
            this.dataGridFaktury.AllowUserToDeleteRows = false;
            this.dataGridFaktury.AllowUserToResizeColumns = false;
            this.dataGridFaktury.AllowUserToResizeRows = false;
            this.dataGridFaktury.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFaktury.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLp,
            this.colDataWystawienia,
            this.colMnoznik});
            this.dataGridFaktury.Enabled = false;
            this.dataGridFaktury.Location = new System.Drawing.Point(8, 136);
            this.dataGridFaktury.MultiSelect = false;
            this.dataGridFaktury.Name = "dataGridFaktury";
            this.dataGridFaktury.ReadOnly = true;
            this.dataGridFaktury.RowHeadersVisible = false;
            this.dataGridFaktury.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFaktury.Size = new System.Drawing.Size(540, 355);
            this.dataGridFaktury.TabIndex = 7;
            // 
            // colLp
            // 
            this.colLp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colLp.HeaderText = "Lp";
            this.colLp.Name = "colLp";
            this.colLp.ReadOnly = true;
            this.colLp.Width = 44;
            // 
            // colDataWystawienia
            // 
            this.colDataWystawienia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDataWystawienia.HeaderText = "Data Wystawienia Faktury";
            this.colDataWystawienia.Name = "colDataWystawienia";
            this.colDataWystawienia.ReadOnly = true;
            // 
            // colMnoznik
            // 
            this.colMnoznik.HeaderText = "Do zapłaty";
            this.colMnoznik.Name = "colMnoznik";
            this.colMnoznik.ReadOnly = true;
            this.colMnoznik.Width = 200;
            // 
            // buttonPokaz
            // 
            this.buttonPokaz.Enabled = false;
            this.buttonPokaz.Location = new System.Drawing.Point(367, 77);
            this.buttonPokaz.Name = "buttonPokaz";
            this.buttonPokaz.Size = new System.Drawing.Size(170, 23);
            this.buttonPokaz.TabIndex = 6;
            this.buttonPokaz.Text = "Pokaż fakturę";
            this.buttonPokaz.UseVisualStyleBackColor = true;
            // 
            // comboRok
            // 
            this.comboRok.Enabled = false;
            this.comboRok.FormattingEnabled = true;
            this.comboRok.Items.AddRange(new object[] {
            "2009",
            "2010",
            "2011"});
            this.comboRok.Location = new System.Drawing.Point(268, 79);
            this.comboRok.Name = "comboRok";
            this.comboRok.Size = new System.Drawing.Size(68, 21);
            this.comboRok.TabIndex = 5;
            // 
            // comboMiesiace
            // 
            this.comboMiesiace.Enabled = false;
            this.comboMiesiace.Items.AddRange(new object[] {
            "Styczeń",
            "Luty",
            "Marzec",
            "Kwiecień",
            "Maj",
            "Czerwiec",
            "Lipiec",
            "Sierpień",
            "Wrzesień",
            "Październik",
            "Listopad",
            "Grudzień"});
            this.comboMiesiace.Location = new System.Drawing.Point(67, 79);
            this.comboMiesiace.Name = "comboMiesiace";
            this.comboMiesiace.Size = new System.Drawing.Size(126, 21);
            this.comboMiesiace.TabIndex = 4;
            // 
            // comboFirmy
            // 
            this.comboFirmy.FormattingEnabled = true;
            this.comboFirmy.Location = new System.Drawing.Point(67, 17);
            this.comboFirmy.Name = "comboFirmy";
            this.comboFirmy.Size = new System.Drawing.Size(269, 21);
            this.comboFirmy.TabIndex = 3;
            // 
            // napis_rok
            // 
            this.napis_rok.AutoSize = true;
            this.napis_rok.Location = new System.Drawing.Point(232, 82);
            this.napis_rok.Name = "napis_rok";
            this.napis_rok.Size = new System.Drawing.Size(30, 13);
            this.napis_rok.TabIndex = 2;
            this.napis_rok.Text = "Rok:";
            // 
            // napis_miesiac
            // 
            this.napis_miesiac.AutoSize = true;
            this.napis_miesiac.Location = new System.Drawing.Point(15, 82);
            this.napis_miesiac.Name = "napis_miesiac";
            this.napis_miesiac.Size = new System.Drawing.Size(46, 13);
            this.napis_miesiac.TabIndex = 1;
            this.napis_miesiac.Text = "Miesiąc:";
            // 
            // napis_firma
            // 
            this.napis_firma.AutoSize = true;
            this.napis_firma.Location = new System.Drawing.Point(15, 20);
            this.napis_firma.Name = "napis_firma";
            this.napis_firma.Size = new System.Drawing.Size(35, 13);
            this.napis_firma.TabIndex = 0;
            this.napis_firma.Text = "Firma:";
            // 
<<<<<<< HEAD
=======
            // colIdModele
            // 
            this.colIdModele.HeaderText = "Id";
            this.colIdModele.Name = "colIdModele";
            this.colIdModele.ReadOnly = true;
            this.colIdModele.Visible = false;
            // 
            // colNazwaModele
            // 
            this.colNazwaModele.HeaderText = "Nazwa";
            this.colNazwaModele.Name = "colNazwaModele";
            this.colNazwaModele.ReadOnly = true;
            // 
            // colZasiegModele
            // 
            this.colZasiegModele.HeaderText = "Zasięg";
            this.colZasiegModele.Name = "colZasiegModele";
            this.colZasiegModele.ReadOnly = true;
            // 
            // colCenaModele
            // 
            this.colCenaModele.HeaderText = "Cena";
            this.colCenaModele.Name = "colCenaModele";
            this.colCenaModele.ReadOnly = true;
            // 
>>>>>>> origin/master
            // FormaGlowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 525);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormaGlowna";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabMapa.ResumeLayout(false);
            this.panelMiasto.ResumeLayout(false);
            this.panelMiasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapa)).EndInit();
            this.tabSlupy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSlupy)).EndInit();
            this.tabNadajniki.ResumeLayout(false);
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNadajniki)).EndInit();
            this.tabModele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModele)).EndInit();
>>>>>>> origin/master
            this.tabFaktury.ResumeLayout(false);
            this.tabFaktury.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFaktury)).EndInit();
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
        private System.Windows.Forms.ComboBox comboFirmy;
        private System.Windows.Forms.Label napis_rok;
        private System.Windows.Forms.Label napis_miesiac;
        private System.Windows.Forms.Label napis_firma;
        private System.Windows.Forms.ComboBox comboMiesiace;
        private System.Windows.Forms.Button buttonPokaz;
        private System.Windows.Forms.ComboBox comboRok;
        private System.Windows.Forms.DataGridView dataGridFaktury;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCena;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirmy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrzychod;
<<<<<<< HEAD
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataWystawienia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMnoznik;
        private System.Windows.Forms.Button buttonStworzFakture;
        private System.Windows.Forms.RadioButton radioData;
        private System.Windows.Forms.RadioButton radioTabela;
=======
        private System.Windows.Forms.DataGridView dataGridNadajniki;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNrNadajniki;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirmaNadajniki;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNrSlupuNadajniki;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelNadajniki;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIloscNadajniki;
        private System.Windows.Forms.DataGridView dataGridModele;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdModele;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNazwaModele;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZasiegModele;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCenaModele;
>>>>>>> origin/master
    }
}


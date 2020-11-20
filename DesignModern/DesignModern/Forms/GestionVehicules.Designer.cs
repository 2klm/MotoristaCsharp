namespace DesignModern
{
    partial class GestionVehicules
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
            this.components = new System.ComponentModel.Container();
            this.panelGestionUtil = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDebut = new FontAwesome.Sharp.IconButton();
            this.buttonFin = new FontAwesome.Sharp.IconButton();
            this.buttonPrecedent = new FontAwesome.Sharp.IconButton();
            this.buttonSuivant = new FontAwesome.Sharp.IconButton();
            this.panelInfoUtil = new System.Windows.Forms.Panel();
            this.comboBoxModele = new System.Windows.Forms.ComboBox();
            this.comboBoxTypesGarage = new System.Windows.Forms.ComboBox();
            this.comboBoxTypesVehicules = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassagers = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoiteVitesse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnergie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCouleur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPuissance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroVehicule = new System.Windows.Forms.TextBox();
            this.dataGridViewVehicule = new System.Windows.Forms.DataGridView();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new FontAwesome.Sharp.IconButton();
            this.buttonValidAjout = new FontAwesome.Sharp.IconButton();
            this.buttonValidModif = new FontAwesome.Sharp.IconButton();
            this.buttonSupprimer = new FontAwesome.Sharp.IconButton();
            this.buttonModif = new FontAwesome.Sharp.IconButton();
            this.buttonAjouter = new FontAwesome.Sharp.IconButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblGestionUtil = new System.Windows.Forms.Label();
            this.buttonUtil = new FontAwesome.Sharp.IconButton();
            this.panelBar = new System.Windows.Forms.Panel();
            this.errorProviderErreur = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelGestionUtil.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelInfoUtil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicule)).BeginInit();
            this.panelButton.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderErreur)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGestionUtil
            // 
            this.panelGestionUtil.Controls.Add(this.panel1);
            this.panelGestionUtil.Controls.Add(this.panelInfoUtil);
            this.panelGestionUtil.Controls.Add(this.panelButton);
            this.panelGestionUtil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestionUtil.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelGestionUtil.Location = new System.Drawing.Point(0, 0);
            this.panelGestionUtil.Name = "panelGestionUtil";
            this.panelGestionUtil.Size = new System.Drawing.Size(1233, 670);
            this.panelGestionUtil.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.buttonDebut);
            this.panel1.Controls.Add(this.buttonFin);
            this.panel1.Controls.Add(this.buttonPrecedent);
            this.panel1.Controls.Add(this.buttonSuivant);
            this.panel1.Location = new System.Drawing.Point(365, 565);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 65);
            this.panel1.TabIndex = 7;
            // 
            // buttonDebut
            // 
            this.buttonDebut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDebut.FlatAppearance.BorderSize = 0;
            this.buttonDebut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDebut.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonDebut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDebut.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDebut.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.buttonDebut.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonDebut.IconSize = 38;
            this.buttonDebut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDebut.Location = new System.Drawing.Point(3, 2);
            this.buttonDebut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDebut.Name = "buttonDebut";
            this.buttonDebut.Rotation = 0D;
            this.buttonDebut.Size = new System.Drawing.Size(60, 60);
            this.buttonDebut.TabIndex = 5;
            this.buttonDebut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDebut.UseVisualStyleBackColor = true;
            this.buttonDebut.Click += new System.EventHandler(this.buttonDebut_Click);
            // 
            // buttonFin
            // 
            this.buttonFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFin.FlatAppearance.BorderSize = 0;
            this.buttonFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonFin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFin.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonFin.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.buttonFin.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonFin.IconSize = 38;
            this.buttonFin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFin.Location = new System.Drawing.Point(223, 2);
            this.buttonFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Rotation = 0D;
            this.buttonFin.Size = new System.Drawing.Size(60, 60);
            this.buttonFin.TabIndex = 6;
            this.buttonFin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFin.UseVisualStyleBackColor = true;
            this.buttonFin.Click += new System.EventHandler(this.buttonFin_Click);
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrecedent.FlatAppearance.BorderSize = 0;
            this.buttonPrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrecedent.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonPrecedent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrecedent.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPrecedent.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.buttonPrecedent.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonPrecedent.IconSize = 38;
            this.buttonPrecedent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrecedent.Location = new System.Drawing.Point(69, 2);
            this.buttonPrecedent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Rotation = 0D;
            this.buttonPrecedent.Size = new System.Drawing.Size(60, 60);
            this.buttonPrecedent.TabIndex = 4;
            this.buttonPrecedent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSuivant.FlatAppearance.BorderSize = 0;
            this.buttonSuivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuivant.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSuivant.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuivant.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSuivant.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.buttonSuivant.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonSuivant.IconSize = 38;
            this.buttonSuivant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSuivant.Location = new System.Drawing.Point(157, 2);
            this.buttonSuivant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Rotation = 0D;
            this.buttonSuivant.Size = new System.Drawing.Size(60, 60);
            this.buttonSuivant.TabIndex = 3;
            this.buttonSuivant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // panelInfoUtil
            // 
            this.panelInfoUtil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelInfoUtil.Controls.Add(this.comboBoxModele);
            this.panelInfoUtil.Controls.Add(this.comboBoxTypesGarage);
            this.panelInfoUtil.Controls.Add(this.comboBoxTypesVehicules);
            this.panelInfoUtil.Controls.Add(this.label12);
            this.panelInfoUtil.Controls.Add(this.label9);
            this.panelInfoUtil.Controls.Add(this.txtPrix);
            this.panelInfoUtil.Controls.Add(this.label11);
            this.panelInfoUtil.Controls.Add(this.txtPassagers);
            this.panelInfoUtil.Controls.Add(this.label10);
            this.panelInfoUtil.Controls.Add(this.label8);
            this.panelInfoUtil.Controls.Add(this.txtBoiteVitesse);
            this.panelInfoUtil.Controls.Add(this.label7);
            this.panelInfoUtil.Controls.Add(this.label6);
            this.panelInfoUtil.Controls.Add(this.txtEnergie);
            this.panelInfoUtil.Controls.Add(this.label5);
            this.panelInfoUtil.Controls.Add(this.txtCouleur);
            this.panelInfoUtil.Controls.Add(this.label4);
            this.panelInfoUtil.Controls.Add(this.txtPuissance);
            this.panelInfoUtil.Controls.Add(this.label3);
            this.panelInfoUtil.Controls.Add(this.txtNumSerie);
            this.panelInfoUtil.Controls.Add(this.label2);
            this.panelInfoUtil.Controls.Add(this.label1);
            this.panelInfoUtil.Controls.Add(this.txtNumeroVehicule);
            this.panelInfoUtil.Controls.Add(this.dataGridViewVehicule);
            this.panelInfoUtil.Location = new System.Drawing.Point(108, 127);
            this.panelInfoUtil.Name = "panelInfoUtil";
            this.panelInfoUtil.Size = new System.Drawing.Size(829, 409);
            this.panelInfoUtil.TabIndex = 4;
            // 
            // comboBoxModele
            // 
            this.comboBoxModele.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxModele.Enabled = false;
            this.comboBoxModele.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModele.FormattingEnabled = true;
            this.comboBoxModele.ItemHeight = 16;
            this.comboBoxModele.Items.AddRange(new object[] {
            "Enregistrée",
            "Vérification",
            "Validée",
            "Préparation",
            "Livraison",
            "Livrée",
            "Incident"});
            this.comboBoxModele.Location = new System.Drawing.Point(560, 93);
            this.comboBoxModele.Name = "comboBoxModele";
            this.comboBoxModele.Size = new System.Drawing.Size(193, 24);
            this.comboBoxModele.TabIndex = 31;
            // 
            // comboBoxTypesGarage
            // 
            this.comboBoxTypesGarage.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxTypesGarage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypesGarage.FormattingEnabled = true;
            this.comboBoxTypesGarage.ItemHeight = 16;
            this.comboBoxTypesGarage.Items.AddRange(new object[] {
            "Enregistrée",
            "Vérification",
            "Validée",
            "Préparation",
            "Livraison",
            "Livrée",
            "Incident"});
            this.comboBoxTypesGarage.Location = new System.Drawing.Point(560, 35);
            this.comboBoxTypesGarage.Name = "comboBoxTypesGarage";
            this.comboBoxTypesGarage.Size = new System.Drawing.Size(193, 24);
            this.comboBoxTypesGarage.TabIndex = 30;
            // 
            // comboBoxTypesVehicules
            // 
            this.comboBoxTypesVehicules.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxTypesVehicules.DisplayMember = "etatTypeV";
            this.comboBoxTypesVehicules.Enabled = false;
            this.comboBoxTypesVehicules.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypesVehicules.FormattingEnabled = true;
            this.comboBoxTypesVehicules.ItemHeight = 16;
            this.comboBoxTypesVehicules.Items.AddRange(new object[] {
            "Enregistrée",
            "Vérification",
            "Validée",
            "Préparation",
            "Livraison",
            "Livrée",
            "Incident"});
            this.comboBoxTypesVehicules.Location = new System.Drawing.Point(198, 90);
            this.comboBoxTypesVehicules.Name = "comboBoxTypesVehicules";
            this.comboBoxTypesVehicules.Size = new System.Drawing.Size(193, 24);
            this.comboBoxTypesVehicules.TabIndex = 29;
            this.comboBoxTypesVehicules.ValueMember = "idTypeV";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(678, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "€";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(477, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Prix";
            // 
            // txtPrix
            // 
            this.txtPrix.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrix.Enabled = false;
            this.txtPrix.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.Location = new System.Drawing.Point(560, 290);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(116, 26);
            this.txtPrix.TabIndex = 22;
            this.txtPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(477, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Passagers";
            // 
            // txtPassagers
            // 
            this.txtPassagers.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPassagers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassagers.Enabled = false;
            this.txtPassagers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassagers.Location = new System.Drawing.Point(560, 140);
            this.txtPassagers.Name = "txtPassagers";
            this.txtPassagers.Size = new System.Drawing.Size(35, 26);
            this.txtPassagers.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(477, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Modèle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(67, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Boîte de vitesse";
            // 
            // txtBoiteVitesse
            // 
            this.txtBoiteVitesse.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoiteVitesse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoiteVitesse.Enabled = false;
            this.txtBoiteVitesse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoiteVitesse.Location = new System.Drawing.Point(198, 295);
            this.txtBoiteVitesse.Name = "txtBoiteVitesse";
            this.txtBoiteVitesse.Size = new System.Drawing.Size(180, 26);
            this.txtBoiteVitesse.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(477, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Garage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(67, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Energie";
            // 
            // txtEnergie
            // 
            this.txtEnergie.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEnergie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnergie.Enabled = false;
            this.txtEnergie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnergie.Location = new System.Drawing.Point(198, 238);
            this.txtEnergie.Name = "txtEnergie";
            this.txtEnergie.Size = new System.Drawing.Size(138, 26);
            this.txtEnergie.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(477, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Couleur";
            // 
            // txtCouleur
            // 
            this.txtCouleur.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCouleur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCouleur.Enabled = false;
            this.txtCouleur.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCouleur.Location = new System.Drawing.Point(560, 191);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.Size = new System.Drawing.Size(149, 26);
            this.txtCouleur.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(67, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Puissance (cv)";
            // 
            // txtPuissance
            // 
            this.txtPuissance.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPuissance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPuissance.Enabled = false;
            this.txtPuissance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuissance.Location = new System.Drawing.Point(198, 190);
            this.txtPuissance.Name = "txtPuissance";
            this.txtPuissance.Size = new System.Drawing.Size(70, 26);
            this.txtPuissance.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(67, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numéro de série";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNumSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumSerie.Enabled = false;
            this.txtNumSerie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSerie.Location = new System.Drawing.Point(198, 140);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(180, 26);
            this.txtNumSerie.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(67, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type véhicule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(67, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numéro véhicule";
            // 
            // txtNumeroVehicule
            // 
            this.txtNumeroVehicule.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNumeroVehicule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroVehicule.Enabled = false;
            this.txtNumeroVehicule.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroVehicule.Location = new System.Drawing.Point(198, 35);
            this.txtNumeroVehicule.Name = "txtNumeroVehicule";
            this.txtNumeroVehicule.Size = new System.Drawing.Size(54, 26);
            this.txtNumeroVehicule.TabIndex = 0;
            // 
            // dataGridViewVehicule
            // 
            this.dataGridViewVehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicule.Location = new System.Drawing.Point(233, 311);
            this.dataGridViewVehicule.Name = "dataGridViewVehicule";
            this.dataGridViewVehicule.Size = new System.Drawing.Size(10, 10);
            this.dataGridViewVehicule.TabIndex = 28;
            this.dataGridViewVehicule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVehicule_CellContentClick);
            // 
            // panelButton
            // 
            this.panelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButton.Controls.Add(this.buttonAnnuler);
            this.panelButton.Controls.Add(this.buttonValidAjout);
            this.panelButton.Controls.Add(this.buttonValidModif);
            this.panelButton.Controls.Add(this.buttonSupprimer);
            this.panelButton.Controls.Add(this.buttonModif);
            this.panelButton.Controls.Add(this.buttonAjouter);
            this.panelButton.Location = new System.Drawing.Point(1045, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(188, 670);
            this.panelButton.TabIndex = 3;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAnnuler.FlatAppearance.BorderSize = 0;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonAnnuler.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAnnuler.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.buttonAnnuler.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonAnnuler.IconSize = 38;
            this.buttonAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnnuler.Location = new System.Drawing.Point(5, 518);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Rotation = 0D;
            this.buttonAnnuler.Size = new System.Drawing.Size(167, 59);
            this.buttonAnnuler.TabIndex = 5;
            this.buttonAnnuler.Text = " Annuler";
            this.buttonAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Visible = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonValidAjout
            // 
            this.buttonValidAjout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonValidAjout.FlatAppearance.BorderSize = 0;
            this.buttonValidAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValidAjout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonValidAjout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValidAjout.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonValidAjout.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.buttonValidAjout.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonValidAjout.IconSize = 38;
            this.buttonValidAjout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValidAjout.Location = new System.Drawing.Point(3, 451);
            this.buttonValidAjout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonValidAjout.Name = "buttonValidAjout";
            this.buttonValidAjout.Rotation = 0D;
            this.buttonValidAjout.Size = new System.Drawing.Size(167, 59);
            this.buttonValidAjout.TabIndex = 4;
            this.buttonValidAjout.Text = " Valider ajout";
            this.buttonValidAjout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonValidAjout.UseVisualStyleBackColor = true;
            this.buttonValidAjout.Visible = false;
            this.buttonValidAjout.Click += new System.EventHandler(this.buttonValidAjout_Click);
            // 
            // buttonValidModif
            // 
            this.buttonValidModif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonValidModif.FlatAppearance.BorderSize = 0;
            this.buttonValidModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValidModif.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonValidModif.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValidModif.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonValidModif.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.buttonValidModif.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonValidModif.IconSize = 38;
            this.buttonValidModif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValidModif.Location = new System.Drawing.Point(5, 451);
            this.buttonValidModif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonValidModif.Name = "buttonValidModif";
            this.buttonValidModif.Rotation = 0D;
            this.buttonValidModif.Size = new System.Drawing.Size(167, 59);
            this.buttonValidModif.TabIndex = 3;
            this.buttonValidModif.Text = "Valider modification";
            this.buttonValidModif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonValidModif.UseVisualStyleBackColor = true;
            this.buttonValidModif.Visible = false;
            this.buttonValidModif.Click += new System.EventHandler(this.buttonValidModif_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSupprimer.FlatAppearance.BorderSize = 0;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSupprimer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSupprimer.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.buttonSupprimer.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonSupprimer.IconSize = 38;
            this.buttonSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimer.Location = new System.Drawing.Point(5, 261);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Rotation = 0D;
            this.buttonSupprimer.Size = new System.Drawing.Size(167, 59);
            this.buttonSupprimer.TabIndex = 2;
            this.buttonSupprimer.Text = " Supprimer";
            this.buttonSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModif
            // 
            this.buttonModif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonModif.FlatAppearance.BorderSize = 0;
            this.buttonModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModif.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonModif.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModif.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonModif.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.buttonModif.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonModif.IconSize = 38;
            this.buttonModif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModif.Location = new System.Drawing.Point(5, 194);
            this.buttonModif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonModif.Name = "buttonModif";
            this.buttonModif.Rotation = 0D;
            this.buttonModif.Size = new System.Drawing.Size(167, 59);
            this.buttonModif.TabIndex = 1;
            this.buttonModif.Text = " Modifier";
            this.buttonModif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonModif.UseVisualStyleBackColor = true;
            this.buttonModif.Click += new System.EventHandler(this.buttonModif_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAjouter.FlatAppearance.BorderSize = 0;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonAjouter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAjouter.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.buttonAjouter.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonAjouter.IconSize = 38;
            this.buttonAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouter.Location = new System.Drawing.Point(5, 127);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Rotation = 0D;
            this.buttonAjouter.Size = new System.Drawing.Size(167, 59);
            this.buttonAjouter.TabIndex = 0;
            this.buttonAjouter.Text = " Ajouter";
            this.buttonAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblGestionUtil);
            this.panelTitle.Controls.Add(this.buttonUtil);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1233, 100);
            this.panelTitle.TabIndex = 4;
            // 
            // lblGestionUtil
            // 
            this.lblGestionUtil.AutoSize = true;
            this.lblGestionUtil.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionUtil.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGestionUtil.Location = new System.Drawing.Point(101, 31);
            this.lblGestionUtil.Name = "lblGestionUtil";
            this.lblGestionUtil.Size = new System.Drawing.Size(389, 42);
            this.lblGestionUtil.TabIndex = 6;
            this.lblGestionUtil.Text = "Gestion des véhicules";
            // 
            // buttonUtil
            // 
            this.buttonUtil.FlatAppearance.BorderSize = 0;
            this.buttonUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUtil.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonUtil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUtil.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUtil.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.buttonUtil.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonUtil.IconSize = 58;
            this.buttonUtil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUtil.Location = new System.Drawing.Point(12, 28);
            this.buttonUtil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUtil.Name = "buttonUtil";
            this.buttonUtil.Rotation = 0D;
            this.buttonUtil.Size = new System.Drawing.Size(80, 59);
            this.buttonUtil.TabIndex = 5;
            this.buttonUtil.UseVisualStyleBackColor = true;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 100);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(1233, 5);
            this.panelBar.TabIndex = 5;
            // 
            // errorProviderErreur
            // 
            this.errorProviderErreur.ContainerControl = this;
            // 
            // GestionVehicules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1233, 670);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelGestionUtil);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GestionVehicules";
            this.Text = "Dashboardcs";
            this.Load += new System.EventHandler(this.GestionVehicules_Load);
            this.panelGestionUtil.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelInfoUtil.ResumeLayout(false);
            this.panelInfoUtil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicule)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderErreur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton buttonAjouter;
        private FontAwesome.Sharp.IconButton buttonModif;
        private FontAwesome.Sharp.IconButton buttonSupprimer;
        private System.Windows.Forms.Panel panelGestionUtil;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblGestionUtil;
        private FontAwesome.Sharp.IconButton buttonUtil;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelInfoUtil;
        private FontAwesome.Sharp.IconButton buttonFin;
        private FontAwesome.Sharp.IconButton buttonDebut;
        private FontAwesome.Sharp.IconButton buttonPrecedent;
        private FontAwesome.Sharp.IconButton buttonSuivant;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonValidModif;
        private FontAwesome.Sharp.IconButton buttonValidAjout;
        private FontAwesome.Sharp.IconButton buttonAnnuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroVehicule;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPassagers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoiteVitesse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEnergie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCouleur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPuissance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.ErrorProvider errorProviderErreur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.DataGridView dataGridViewVehicule;
        private System.Windows.Forms.ComboBox comboBoxTypesVehicules;
        private System.Windows.Forms.ComboBox comboBoxTypesGarage;
        private System.Windows.Forms.ComboBox comboBoxModele;
    }
}
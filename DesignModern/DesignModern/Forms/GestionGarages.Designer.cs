namespace DesignModern
{
    partial class GestionGarages
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
            this.comboTypeGarage = new System.Windows.Forms.ComboBox();
            this.txtNumGarage = new System.Windows.Forms.TextBox();
            this.txtNomGarage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.dataGridViewGarages = new System.Windows.Forms.DataGridView();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonAjouterUtil = new FontAwesome.Sharp.IconButton();
            this.buttonAnnuler = new FontAwesome.Sharp.IconButton();
            this.buttonValidModif = new FontAwesome.Sharp.IconButton();
            this.buttonSupprimer = new FontAwesome.Sharp.IconButton();
            this.buttonModif = new FontAwesome.Sharp.IconButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblGestionUtil = new System.Windows.Forms.Label();
            this.buttonUtil = new FontAwesome.Sharp.IconButton();
            this.panelBar = new System.Windows.Forms.Panel();
            this.errorProviderErreur = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelGestionUtil.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelInfoUtil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGarages)).BeginInit();
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
            this.panelInfoUtil.Controls.Add(this.comboTypeGarage);
            this.panelInfoUtil.Controls.Add(this.txtNumGarage);
            this.panelInfoUtil.Controls.Add(this.txtNomGarage);
            this.panelInfoUtil.Controls.Add(this.label7);
            this.panelInfoUtil.Controls.Add(this.label6);
            this.panelInfoUtil.Controls.Add(this.label5);
            this.panelInfoUtil.Controls.Add(this.label4);
            this.panelInfoUtil.Controls.Add(this.label3);
            this.panelInfoUtil.Controls.Add(this.label2);
            this.panelInfoUtil.Controls.Add(this.label1);
            this.panelInfoUtil.Controls.Add(this.txtEmail);
            this.panelInfoUtil.Controls.Add(this.txtTelephone);
            this.panelInfoUtil.Controls.Add(this.txtAdresse);
            this.panelInfoUtil.Controls.Add(this.txtCodePostal);
            this.panelInfoUtil.Controls.Add(this.dataGridViewGarages);
            this.panelInfoUtil.Location = new System.Drawing.Point(108, 127);
            this.panelInfoUtil.Name = "panelInfoUtil";
            this.panelInfoUtil.Size = new System.Drawing.Size(829, 409);
            this.panelInfoUtil.TabIndex = 4;
            // 
            // comboTypeGarage
            // 
            this.comboTypeGarage.Enabled = false;
            this.comboTypeGarage.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.comboTypeGarage.FormattingEnabled = true;
            this.comboTypeGarage.Items.AddRange(new object[] {
            "Propriétaire",
            "Partenaire"});
            this.comboTypeGarage.Location = new System.Drawing.Point(602, 47);
            this.comboTypeGarage.Name = "comboTypeGarage";
            this.comboTypeGarage.Size = new System.Drawing.Size(146, 30);
            this.comboTypeGarage.TabIndex = 39;
            // 
            // txtNumGarage
            // 
            this.txtNumGarage.Enabled = false;
            this.txtNumGarage.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtNumGarage.Location = new System.Drawing.Point(222, 96);
            this.txtNumGarage.Name = "txtNumGarage";
            this.txtNumGarage.Size = new System.Drawing.Size(26, 30);
            this.txtNumGarage.TabIndex = 36;
            // 
            // txtNomGarage
            // 
            this.txtNomGarage.Enabled = false;
            this.txtNomGarage.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtNomGarage.Location = new System.Drawing.Point(222, 47);
            this.txtNomGarage.Name = "txtNomGarage";
            this.txtNomGarage.Size = new System.Drawing.Size(180, 30);
            this.txtNomGarage.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(504, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(504, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Téléphone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(70, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Code postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(70, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Adresse garage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(70, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nom garage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(489, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Type garage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(70, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numéro garage";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtEmail.Location = new System.Drawing.Point(602, 233);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 30);
            this.txtEmail.TabIndex = 38;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Enabled = false;
            this.txtTelephone.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtTelephone.Location = new System.Drawing.Point(602, 187);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(132, 30);
            this.txtTelephone.TabIndex = 37;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Enabled = false;
            this.txtAdresse.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtAdresse.Location = new System.Drawing.Point(221, 187);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(253, 30);
            this.txtAdresse.TabIndex = 36;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Enabled = false;
            this.txtCodePostal.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtCodePostal.Location = new System.Drawing.Point(221, 235);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(78, 30);
            this.txtCodePostal.TabIndex = 38;
            // 
            // dataGridViewGarages
            // 
            this.dataGridViewGarages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGarages.Location = new System.Drawing.Point(260, 199);
            this.dataGridViewGarages.Name = "dataGridViewGarages";
            this.dataGridViewGarages.RowHeadersWidth = 51;
            this.dataGridViewGarages.Size = new System.Drawing.Size(10, 10);
            this.dataGridViewGarages.TabIndex = 28;
            // 
            // panelButton
            // 
            this.panelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButton.Controls.Add(this.buttonAjouterUtil);
            this.panelButton.Controls.Add(this.buttonAnnuler);
            this.panelButton.Controls.Add(this.buttonValidModif);
            this.panelButton.Controls.Add(this.buttonSupprimer);
            this.panelButton.Controls.Add(this.buttonModif);
            this.panelButton.Location = new System.Drawing.Point(1045, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(188, 670);
            this.panelButton.TabIndex = 3;
            // 
            // buttonAjouterUtil
            // 
            this.buttonAjouterUtil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAjouterUtil.FlatAppearance.BorderSize = 0;
            this.buttonAjouterUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterUtil.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonAjouterUtil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterUtil.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAjouterUtil.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.buttonAjouterUtil.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonAjouterUtil.IconSize = 38;
            this.buttonAjouterUtil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterUtil.Location = new System.Drawing.Point(0, 127);
            this.buttonAjouterUtil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAjouterUtil.Name = "buttonAjouterUtil";
            this.buttonAjouterUtil.Rotation = 0D;
            this.buttonAjouterUtil.Size = new System.Drawing.Size(167, 59);
            this.buttonAjouterUtil.TabIndex = 6;
            this.buttonAjouterUtil.Text = " Ajouter";
            this.buttonAjouterUtil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAjouterUtil.UseVisualStyleBackColor = true;
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
            this.buttonValidModif.Size = new System.Drawing.Size(176, 59);
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
            this.buttonSupprimer.Location = new System.Drawing.Point(0, 261);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Rotation = 0D;
            this.buttonSupprimer.Size = new System.Drawing.Size(167, 59);
            this.buttonSupprimer.TabIndex = 2;
            this.buttonSupprimer.Text = " Supprimer";
            this.buttonSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSupprimer.UseVisualStyleBackColor = true;
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
            this.buttonModif.Location = new System.Drawing.Point(0, 194);
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
            this.lblGestionUtil.Size = new System.Drawing.Size(466, 55);
            this.lblGestionUtil.TabIndex = 6;
            this.lblGestionUtil.Text = "Gestion des garages";
            // 
            // buttonUtil
            // 
            this.buttonUtil.FlatAppearance.BorderSize = 0;
            this.buttonUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUtil.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonUtil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUtil.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUtil.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
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
            // GestionGarages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1233, 670);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelGestionUtil);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GestionGarages";
            this.Text = "Dashboardcs";
            this.Load += new System.EventHandler(this.GestionGarages_Load);
            this.panelGestionUtil.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelInfoUtil.ResumeLayout(false);
            this.panelInfoUtil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGarages)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderErreur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton buttonModif;
        private FontAwesome.Sharp.IconButton buttonSupprimer;
        private System.Windows.Forms.Panel panelGestionUtil;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblGestionUtil;
        private FontAwesome.Sharp.IconButton buttonUtil;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Panel panelButton;
        private FontAwesome.Sharp.IconButton buttonFin;
        private FontAwesome.Sharp.IconButton buttonDebut;
        private FontAwesome.Sharp.IconButton buttonPrecedent;
        private FontAwesome.Sharp.IconButton buttonSuivant;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonValidModif;
        private FontAwesome.Sharp.IconButton buttonAnnuler;
        private System.Windows.Forms.ErrorProvider errorProviderErreur;
        private System.Windows.Forms.Panel panelInfoUtil;
        private System.Windows.Forms.DataGridView dataGridViewGarages;
        private FontAwesome.Sharp.IconButton buttonAjouterUtil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboTypeGarage;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtNumGarage;
        private System.Windows.Forms.TextBox txtNomGarage;
    }
}
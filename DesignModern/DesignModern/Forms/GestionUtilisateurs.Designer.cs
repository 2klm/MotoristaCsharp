namespace DesignModern
{
    partial class GestionUtil
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
            this.buttonAjouterUtil = new FontAwesome.Sharp.IconButton();
            this.buttonModifUtil = new FontAwesome.Sharp.IconButton();
            this.buttonSupprimerUtil = new FontAwesome.Sharp.IconButton();
            this.panelGestionUtil = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonUtil = new FontAwesome.Sharp.IconButton();
            this.lblGestionUtil = new System.Windows.Forms.Label();
            this.panelBar = new System.Windows.Forms.Panel();
            this.panelGestionUtil.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAjouterUtil
            // 
            this.buttonAjouterUtil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAjouterUtil.FlatAppearance.BorderSize = 0;
            this.buttonAjouterUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterUtil.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonAjouterUtil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterUtil.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAjouterUtil.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.buttonAjouterUtil.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonAjouterUtil.IconSize = 58;
            this.buttonAjouterUtil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterUtil.Location = new System.Drawing.Point(284, 488);
            this.buttonAjouterUtil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAjouterUtil.Name = "buttonAjouterUtil";
            this.buttonAjouterUtil.Rotation = 0D;
            this.buttonAjouterUtil.Size = new System.Drawing.Size(215, 59);
            this.buttonAjouterUtil.TabIndex = 0;
            this.buttonAjouterUtil.Text = "Ajouter";
            this.buttonAjouterUtil.UseVisualStyleBackColor = true;
            // 
            // buttonModifUtil
            // 
            this.buttonModifUtil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonModifUtil.FlatAppearance.BorderSize = 0;
            this.buttonModifUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifUtil.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonModifUtil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifUtil.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonModifUtil.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.buttonModifUtil.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonModifUtil.IconSize = 58;
            this.buttonModifUtil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifUtil.Location = new System.Drawing.Point(519, 488);
            this.buttonModifUtil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonModifUtil.Name = "buttonModifUtil";
            this.buttonModifUtil.Rotation = 0D;
            this.buttonModifUtil.Size = new System.Drawing.Size(215, 59);
            this.buttonModifUtil.TabIndex = 1;
            this.buttonModifUtil.Text = "Modifier";
            this.buttonModifUtil.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimerUtil
            // 
            this.buttonSupprimerUtil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSupprimerUtil.FlatAppearance.BorderSize = 0;
            this.buttonSupprimerUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerUtil.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSupprimerUtil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerUtil.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSupprimerUtil.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.buttonSupprimerUtil.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonSupprimerUtil.IconSize = 58;
            this.buttonSupprimerUtil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimerUtil.Location = new System.Drawing.Point(755, 488);
            this.buttonSupprimerUtil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSupprimerUtil.Name = "buttonSupprimerUtil";
            this.buttonSupprimerUtil.Rotation = 0D;
            this.buttonSupprimerUtil.Size = new System.Drawing.Size(236, 59);
            this.buttonSupprimerUtil.TabIndex = 2;
            this.buttonSupprimerUtil.Text = "Supprimer";
            this.buttonSupprimerUtil.UseVisualStyleBackColor = true;
            // 
            // panelGestionUtil
            // 
            this.panelGestionUtil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGestionUtil.Controls.Add(this.buttonModifUtil);
            this.panelGestionUtil.Controls.Add(this.buttonSupprimerUtil);
            this.panelGestionUtil.Controls.Add(this.buttonAjouterUtil);
            this.panelGestionUtil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestionUtil.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelGestionUtil.Location = new System.Drawing.Point(0, 0);
            this.panelGestionUtil.Name = "panelGestionUtil";
            this.panelGestionUtil.Size = new System.Drawing.Size(1233, 670);
            this.panelGestionUtil.TabIndex = 3;
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
            // buttonUtil
            // 
            this.buttonUtil.FlatAppearance.BorderSize = 0;
            this.buttonUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUtil.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonUtil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUtil.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUtil.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
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
            // lblGestionUtil
            // 
            this.lblGestionUtil.AutoSize = true;
            this.lblGestionUtil.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionUtil.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGestionUtil.Location = new System.Drawing.Point(101, 31);
            this.lblGestionUtil.Name = "lblGestionUtil";
            this.lblGestionUtil.Size = new System.Drawing.Size(400, 41);
            this.lblGestionUtil.TabIndex = 6;
            this.lblGestionUtil.Text = "Gestion Des Utilisateurs";
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 100);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(1233, 9);
            this.panelBar.TabIndex = 5;
            // 
            // GestionUtil
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
            this.Name = "GestionUtil";
            this.Text = "Dashboardcs";
            this.panelGestionUtil.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton buttonAjouterUtil;
        private FontAwesome.Sharp.IconButton buttonModifUtil;
        private FontAwesome.Sharp.IconButton buttonSupprimerUtil;
        private System.Windows.Forms.Panel panelGestionUtil;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblGestionUtil;
        private FontAwesome.Sharp.IconButton buttonUtil;
        private System.Windows.Forms.Panel panelBar;
    }
}
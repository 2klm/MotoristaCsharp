﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DesignModern
{
    public partial class CreerUser : Form
    {
        private motoristaDbContext db;
        public FormMain leFormMain;

        public CreerUser(FormMain leForm)
        {
            InitializeComponent();
            db = new motoristaDbContext();
            leFormMain = leForm;
        }

        private void chargerDataGrind()
        {
            dataGridViewUtil.DataSource = db.client.ToList();

            dataGridViewUtil.DataSource = db.client.Select(c => new
            {
                Numero = c.numC,
                TypeClient = c.type_de_client,
                Nom = c.nomC,
                Prenom = c.paysC,
                Adresse = c.adresseC,
                CP = c.cpC,
                Ville = c.villeC,
                Pays = c.paysC,
                Telephone = c.telC,
                Email = c.emailC,
                Login = c.loginC,
                MDP = c.mdpC

            }).ToList();

            dataGridViewUtil.Rows[0].Selected = true;
            dataGridViewUtil.CurrentCell = dataGridViewUtil.Rows[0].Cells[0];
        }

        private void AffecterValeurs(int ligne)
        {
            txtNumeroClient.Text = dataGridViewUtil.Rows[ligne].Cells[0].Value.ToString();
            comboBoxTypesClient.SelectedValue = dataGridViewUtil.Rows[ligne].Cells[1].Value.ToString();
            txtNom.Text = dataGridViewUtil.Rows[ligne].Cells[2].Value.ToString();
            txtPrenom.Text = dataGridViewUtil.Rows[ligne].Cells[3].Value.ToString();
            txtAdresse.Text = dataGridViewUtil.Rows[ligne].Cells[4].Value.ToString();
            txtCP.Text = dataGridViewUtil.Rows[ligne].Cells[5].Value.ToString();
            txtVille.Text = dataGridViewUtil.Rows[ligne].Cells[6].Value.ToString();
            txtPays.Text = dataGridViewUtil.Rows[ligne].Cells[7].Value.ToString();
            txtTelephone.Text = dataGridViewUtil.Rows[ligne].Cells[8].Value.ToString();
            txtEmail.Text = dataGridViewUtil.Rows[ligne].Cells[9].Value.ToString();
            txtLogin.Text = dataGridViewUtil.Rows[ligne].Cells[10].Value.ToString();
            txtMdp.Text = dataGridViewUtil.Rows[ligne].Cells[11].Value.ToString();

            dataGridViewUtil.Rows[ligne].Selected = true;
            dataGridViewUtil.CurrentCell = dataGridViewUtil.Rows[ligne].Cells[0];
        }
        private void deverouillerVerrouiller()
        {
            if (txtNumeroClient.Enabled == true)
            {
                //Vérouillage
                txtNumeroClient.Enabled = false;
                txtNom.Enabled = false;
                txtPrenom.Enabled = false;
                txtAdresse.Enabled = false;
                txtCP.Enabled = false;
                txtVille.Enabled = false;
                txtPays.Enabled = false;
                txtLogin.Enabled = false;
                txtMdp.Enabled = false;
                txtEmail.Enabled = false;
                txtTelephone.Enabled = false;
                comboBoxTypesClient.Enabled = false;
            }
            else
            {
                //Déverouillage
                txtNumeroClient.Enabled = true;
                txtNom.Enabled = true;
                txtPrenom.Enabled = true;
                txtAdresse.Enabled = true;
                txtCP.Enabled = true;
                txtVille.Enabled = true;
                txtPays.Enabled = true;
                txtLogin.Enabled = true;
                txtMdp.Enabled = true;
                txtEmail.Enabled = true;
                txtTelephone.Enabled = true;
                comboBoxTypesClient.Enabled = true;
            }
        }
        private bool verif()
        {
            bool verification = true;
            if (txtNumeroClient.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtNumeroClient, "Veuillez indiquer le numéro de client");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtNumeroClient, "");
            }

            if (txtNom.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtNom, "Veuillez indiquer votre nom");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtNom, "");
            }

            if (txtPrenom.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtPrenom, "Veuillez indiquer votre prenom");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtPrenom, "");
            }

            if (txtAdresse.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtAdresse, "Veuillez indiquer votre adresse");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtAdresse, "");
            }

            if (txtCP.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtCP, "Veuillez indiquer votre code postal");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtCP, "");
            }

            if (txtVille.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtVille, "Veuillez indiquer votre ville");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtVille, "");
            }

            if (txtPays.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtPays, "Veuillez indiquer votre pays");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtPays, "");
            }
            if (txtLogin.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtLogin, "Veuillez indiquer votre login");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtLogin, "");
            }
            if (txtMdp.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtMdp, "Veuillez indiquer votre mot de passe");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtMdp, "");
            }
            if (txtEmail.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtEmail, "Veuillez indiquer votre email");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtEmail, "");
            }
            if (txtTelephone.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtTelephone, "Veuillez indiquer votre téléphone");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtTelephone, "");
            }
            if (comboBoxTypesClient.Text.Trim() == "")
            {
                errorProviderErreur.SetError(comboBoxTypesClient, "Veuillez indiquer le type de client");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(comboBoxTypesClient, "");
            }

            return (verification);
        }
        private void remiseAZero()
        {
            txtNumeroClient.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
            txtAdresse.Clear();
            txtCP.Clear();
            txtVille.Clear();
            txtPays.Clear();
            txtLogin.Clear();
            txtMdp.Clear();
            txtEmail.Clear();
            txtTelephone.Clear();
            comboBoxTypesClient.Text = "";
        }

        private void GestionUtil_Load(object sender, EventArgs e)
        {
            chargerDataGrind();
            comboBoxTypesClient.DataSource = db.type_de_client.ToList();
            comboBoxTypesClient.DisplayMember = "typeClient";
            comboBoxTypesClient.ValueMember = "numTypeClient";
            comboBoxTypesClient.Text = "";
        }

        private void buttonValidAjout_Click(object sender, EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Veuillez compléter toutes les zones de saisies");
            }
            else
            {
                try
                {
                    client unClient = new client();
                    unClient.numC = Convert.ToInt32(txtNumeroClient.Text);
                    unClient.nomC = txtNom.Text;
                    unClient.prenomC = txtPrenom.Text;
                    unClient.adresseC = txtAdresse.Text;
                    unClient.cpC = txtCP.Text;
                    unClient.villeC = txtVille.Text;
                    unClient.paysC = txtPays.Text;
                    unClient.loginC = txtLogin.Text;
                    unClient.mdpC = txtMdp.Text;
                    unClient.emailC = txtEmail.Text;
                    unClient.telC = txtTelephone.Text;
                    unClient.numTypeClient = Convert.ToInt32(comboBoxTypesClient.SelectedValue.ToString());

                    db.client.Add(unClient);
                    db.SaveChanges();
                    chargerDataGrind();
                    deverouillerVerrouiller();

                    MessageBox.Show("Ajout effectué");
                    leFormMain.OuvrirMDICommandes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Activation / Désactivation des boutons

                buttonValidAjout.Enabled = false;
                buttonValidAjout.Visible = false;
            }
        }

        private void buttonValidModif_Click(object sender, EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Veuillez compléter toutes les zones de saisies");
            }
            else
            {
                try
                {
                    //Modification d'un client Reste à recuperer les informations du client et les affichées dans le champs !

                    client unClient = db.client.First(c => c.numC.ToString() == txtNumeroClient.Text);
                    unClient.numC = Convert.ToInt32(txtNumeroClient.Text);
                    unClient.nomC = txtNom.Text;
                    unClient.prenomC = txtPrenom.Text;
                    unClient.adresseC = txtAdresse.Text;
                    unClient.cpC = txtCP.Text;
                    unClient.villeC = txtVille.Text;
                    unClient.paysC = txtPays.Text;
                    unClient.loginC = txtLogin.Text;
                    unClient.mdpC = txtMdp.Text;
                    unClient.emailC = txtEmail.Text;
                    unClient.telC = txtTelephone.Text;
                    unClient.numTypeClient = Convert.ToInt32(comboBoxTypesClient.SelectedValue.ToString());

                    db.SaveChanges();
                    chargerDataGrind();
                    deverouillerVerrouiller();

                    MessageBox.Show("Modification effectuée");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Activation / Désactivation des boutons
                buttonValidAjout.Enabled = false;
            }
        }
        private void buttonSupprimerUtil_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer " + txtNumeroClient.Text + " " + txtNom.Text, "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Suppression annulée");
            }
            else
            {
                try
                {
                    //Suppresion (Reste maintenant à afficher quel client supprimer !

                    client unClient = db.client.First(c => c.numC.ToString() == txtNumeroClient.Text);
                    db.client.Remove(unClient);
                    db.SaveChanges();
                    chargerDataGrind();
                    deverouillerVerrouiller();

                    MessageBox.Show("Suppression effectuée");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewUtil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AffecterValeurs(dataGridViewUtil.CurrentRow.Index);
        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            panelInfoUtil.Visible = true;
            btnOui.Visible = false;
            btnNon.Visible = false;
            lblQuestion.Visible = false;
            buttonValidAjout.Visible = true;
        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            leFormMain.OuvrirMDICommandes();
        }
    }
}

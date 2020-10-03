using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DesignModern
{
    public partial class GestionUtil : Form
    {
        private motoristaDbContext db;
        public GestionUtil()
        {
            InitializeComponent();
            db = new motoristaDbContext();
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
            comboBoxTypesClient.DataSource = db.type_de_client.ToList();
            comboBoxTypesClient.DisplayMember = "typeClient";
            comboBoxTypesClient.ValueMember = "numTypeClient";
            comboBoxTypesClient.Text = "";
        }

        private void buttonAjouterUtil_Click(object sender, EventArgs e)
        {
            remiseAZero();
            deverouillerVerrouiller();
            buttonModifUtil.Enabled = false;
            buttonSupprimerUtil.Enabled = false;
            buttonValidAjout.Enabled = true;
            buttonValidAjout.Visible = true;
            buttonValidModif.Enabled = false;
            buttonAjouterUtil.Enabled = false;
            buttonAnnuler.Enabled = true;
            buttonAnnuler.Visible = true;
            txtNumeroClient.Focus();
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
                    deverouillerVerrouiller();

                    MessageBox.Show("Ajout effectué");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Activation / Désactivation des boutons
                buttonModifUtil.Enabled = true;
                buttonSupprimerUtil.Enabled = true;
                buttonValidAjout.Enabled = false;
                buttonValidAjout.Visible = false;
                buttonValidModif.Enabled = false;
                buttonAjouterUtil.Enabled = true;
                buttonAnnuler.Enabled = false;
                buttonAnnuler.Visible = false;
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            remiseAZero();
            db.SaveChanges();
            deverouillerVerrouiller();
            buttonValidAjout.Visible = false;
            buttonAnnuler.Visible = false;
            buttonAjouterUtil.Enabled = true;
            buttonModifUtil.Enabled = true;
            buttonSupprimerUtil.Enabled = true;
            buttonValidModif.Visible = false;
        }
        private void buttonModifUtil_Click(object sender, EventArgs e)
        {
            deverouillerVerrouiller();
            buttonModifUtil.Enabled = false;
            buttonSupprimerUtil.Enabled = false;
            buttonValidAjout.Enabled = true;
            buttonValidAjout.Visible = false;
            buttonValidModif.Enabled = true;
            buttonValidModif.Visible = true;
            buttonAjouterUtil.Enabled = false;
            buttonAnnuler.Enabled = true;
            buttonAnnuler.Visible = true;
            txtNumeroClient.Focus();
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
                    deverouillerVerrouiller();

                    MessageBox.Show("Modification effectuée");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Activation / Désactivation des boutons
                buttonModifUtil.Enabled = true;
                buttonSupprimerUtil.Enabled = true;
                buttonValidAjout.Enabled = false;
                buttonValidModif.Enabled = false;
                buttonValidModif.Visible = false;
                buttonAjouterUtil.Enabled = true;
                buttonAnnuler.Enabled = false;
                buttonAnnuler.Visible = false;
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
                    deverouillerVerrouiller();

                    MessageBox.Show("Suppression effectuée");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

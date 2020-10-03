using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignModern
{
    public partial class GestionUtil : Form
    {
        private Entities db;
        public GestionUtil()
        {
            InitializeComponent();
            db = new Entities();
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
                txtEmail.Enabled = false;
                txtTelephone.Enabled = false;
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
                txtEmail.Enabled = true;
                txtTelephone.Enabled = true;
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
            txtEmail.Clear();
            txtTelephone.Clear();
        }
    }
}

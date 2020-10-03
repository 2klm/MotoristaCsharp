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
    public partial class GestionVehicules : Form
    {
        private Entities db;
        public GestionVehicules()
        {
            InitializeComponent();
            db = new Entities();
        }

        private void deverouillerVerrouiller()
        {
            if (txtNumeroVehicule.Enabled == true)
            {
                //Vérouillage
                txtNumeroVehicule.Enabled = false;
                txtTypeVehicule.Enabled = false;
                txtNumSerie.Enabled = false;
                txtPuissance.Enabled = false;
                txtCouleur.Enabled = false;
                txtEnergie.Enabled = false;
                txtBoiteVitesse.Enabled = false;
                txtGarage.Enabled = false;
                txtModele.Enabled = false;
                txtPassagers.Enabled = false;
            }
            else
            {
                //Déverouillage
                txtNumeroVehicule.Enabled = true;
                txtTypeVehicule.Enabled = true;
                txtNumSerie.Enabled = true;
                txtPuissance.Enabled = true;
                txtCouleur.Enabled = true;
                txtEnergie.Enabled = true;
                txtBoiteVitesse.Enabled = true;
                txtGarage.Enabled = true;
                txtModele.Enabled = true;
                txtPassagers.Enabled = true;
            }
        }
        private bool verif()
        {
            bool verification = true;
            if (txtNumeroVehicule.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtNumeroVehicule, "Veuillez indiquer le numéro de client");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtNumeroVehicule, "");
            }

            if (txtTypeVehicule.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtTypeVehicule, "Veuillez indiquer votre nom");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtTypeVehicule, "");
            }

            if (txtNumSerie.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtNumSerie, "Veuillez indiquer votre prenom");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtNumSerie, "");
            }

            if (txtPuissance.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtPuissance, "Veuillez indiquer votre adresse");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtPuissance, "");
            }

            if (txtCouleur.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtCouleur, "Veuillez indiquer votre code postal");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtCouleur, "");
            }

            if (txtEnergie.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtEnergie, "Veuillez indiquer votre ville");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtEnergie, "");
            }

            if (txtBoiteVitesse.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtBoiteVitesse, "Veuillez indiquer votre pays");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtBoiteVitesse, "");
            }
            if (txtGarage.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtGarage, "Veuillez indiquer votre login");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtGarage, "");
            }
            if (txtModele.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtModele, "Veuillez indiquer votre email");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtModele, "");
            }
            if (txtPassagers.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtPassagers, "Veuillez indiquer votre téléphone");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtPassagers, "");
            }

            return (verification);
        }
        private void remiseAZero()
        {
            txtNumeroVehicule.Clear();
            txtTypeVehicule.Clear();
            txtNumSerie.Clear();
            txtPuissance.Clear();
            txtCouleur.Clear();
            txtEnergie.Clear();
            txtBoiteVitesse.Clear();
            txtGarage.Clear();
            txtModele.Clear();
            txtPassagers.Clear();
        }
    }
}

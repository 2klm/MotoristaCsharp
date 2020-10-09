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
    public partial class GestionCommandes : Form
    {
        private motoristaDbContext db;
        public GestionCommandes()
        {
            InitializeComponent();
            db = new motoristaDbContext();
        }

        private void deverouillerVerrouiller()
        {
            if (txtNumCommande.Enabled == true)
            {
                //Vérouillage
                txtNumCommande.Enabled = false;
                txtNumClient.Enabled = false;
                txtDateCommande.Enabled = false;
                txtDateLivraison.Enabled = false;
                txtNumGarage.Enabled = false;
                comboEtatCommande.Enabled = false;
            }
            else
            {
                //Déverouillage
                txtNumCommande.Enabled = true;
                txtNumClient.Enabled = true;
                txtDateCommande.Enabled = true;
                txtDateLivraison.Enabled = true;
                txtNumGarage.Enabled = true;
                comboEtatCommande.Enabled = true;
            }
        }
        private bool verif()
        {
            bool verification = true;

            if (txtNumCommande.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtNumCommande, "Veuillez indiquer le numéro de commande");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtNumCommande, "");
            }

            if (txtNumClient.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtNumClient, "Veuillez indiquer le numéro de commande");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtNumClient, "");
            }

            if (txtNumGarage.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtNumGarage, "Veuillez indiquer le numéro de commande");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtNumGarage, "");
            }

            if (comboEtatCommande.Text.Trim() == "")
            {
                errorProviderErreur.SetError(comboEtatCommande, "Veuillez indiquer le numéro de commande");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(comboEtatCommande, "");
            }

            return (verification);
        }
        private void remiseAZero()
        {
            txtNumGarage.Clear(); 
            txtNumClient.Clear();
            txtNumCommande.Clear();
            txtNumCommande.Enabled = false;
            txtNumClient.Enabled = false;
            txtDateCommande.Enabled = false;
            txtDateLivraison.Enabled = false;
            txtNumGarage.Enabled = false;
            comboEtatCommande.Enabled = false;
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {           
            buttonModif.Enabled = false;
            buttonSupprimer.Enabled = false;            
            buttonAnnuler.Visible = true;
            deverouillerVerrouiller();
            txtNumCommande.Focus();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {            
            buttonModif.Enabled = true;
            buttonSupprimer.Enabled = true;
            remiseAZero();
            buttonAnnuler.Visible = false;
        }

        private void buttonValidAjout_Click(object sender, EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Veuillez compléter toutes les zones de saisies");
            }
            else
            {
                //try
                //{
                    commande uneCommande = new commande();
                    uneCommande.numC = Convert.ToInt16(txtNumClient.Text);
                    uneCommande.numCmd = Convert.ToInt16(txtNumCommande.Text);
                    uneCommande.idGarage = Convert.ToInt16(txtNumGarage.Text);
                    uneCommande.dateLivraisonCmd = txtDateLivraison.Value;
                    uneCommande.dateCmd = txtDateCommande.Value;
                    uneCommande.etatCmd = comboEtatCommande.Text;


                    db.commande.Add(uneCommande);
                    db.SaveChanges();
                    deverouillerVerrouiller();

                    MessageBox.Show("Ajout effectué");
               // }
                //catch (Exception ex)
                //{
                   // MessageBox.Show("Echec de l'ajout"+ex.Message);

                //}
                //Activation / Désactivation des boutons
                buttonAnnuler.Visible = false;
                buttonModif.Enabled = true;
                buttonSupprimer.Enabled = true;
            }
        }
    }
}

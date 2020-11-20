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
    public partial class GestionGarages : Form
    {
        private motoristaDbContext db;
        public GestionGarages()
        {
            InitializeComponent();
            db = new motoristaDbContext();
            chargerDataGrind();
        }
        
        //remplir le data grid avec les données de la BDD
        private void chargerDataGrind()
        {
            dataGridViewGarages.DataSource = db.garage.ToList();

            dataGridViewGarages.DataSource = db.garage.Select(c => new
            {
                idGarage = c.idGarage,
                idType = c.type_de_garage.libelleType,
                nom = c.nomG,
                adresse = c.adresseG,
                codePostal = c.cpG,
                telephone = c.telG,
                email = c.emailG
            }).ToList();

            dataGridViewGarages.Rows[0].Selected = true;
            dataGridViewGarages.CurrentCell = dataGridViewGarages.Rows[0].Cells[0];

            txtNumGarage.Text = dataGridViewGarages.Rows[0].Cells[0].Value.ToString();
            comboTypeGarage.Text = dataGridViewGarages.Rows[0].Cells[1].Value.ToString();
            txtNomGarage.Text = dataGridViewGarages.Rows[0].Cells[2].Value.ToString();
            txtAdresse.Text = dataGridViewGarages.Rows[0].Cells[3].Value.ToString();
            txtCodePostal.Text = dataGridViewGarages.Rows[0].Cells[4].Value.ToString();
            txtTelephone.Text = dataGridViewGarages.Rows[0].Cells[5].Value.ToString();
            txtEmail.Text = dataGridViewGarages.Rows[0].Cells[6].Value.ToString();
        }

        //verrouille ou deverouille les champs de texte
        private void deverouillerVerrouiller()
        {
            if (txtAdresse.Enabled == true)
            {
                //Vérouillage
                txtCodePostal.Enabled = false;
                txtAdresse.Enabled = false;
                txtEmail.Enabled = false;
                txtNomGarage.Enabled = false;
                txtTelephone.Enabled = false;
                comboTypeGarage.Enabled = false;
            }
            else
            {
                //Déverouillage
                txtCodePostal.Enabled = true;
                txtAdresse.Enabled = true;
                txtEmail.Enabled = true;
                txtNomGarage.Enabled = true;
                txtTelephone.Enabled = true;
                comboTypeGarage.Enabled = true;
            }     
        }

        //vérifie que les champs sont correctement remplis avant l'envoi à la base de données
        private bool Verif()
        {
            bool verification = true;
            
            if (txtCodePostal.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtCodePostal, "Veuillez indiquer le code postal");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtCodePostal, "");
            }

            if (txtAdresse.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtAdresse, "Veuillez indiquer l'adresse du garage");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtAdresse, "");
            }

            if (txtTelephone.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtTelephone, "Veuillez indiquer le numéro de télphone");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtTelephone, "");
            }

            if (txtEmail.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtEmail, "Veuillez indiquer le numéro de téléphone");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtEmail, "");
            }

            if (txtNomGarage.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtNomGarage, "Veuillez indiquer le nom du garage");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtNomGarage, "");
            }
            return (verification);
        }

        //vide tous les champs de texte, avant une saisie par exemple
        private void remiseAZero()
        {
            txtCodePostal.Text = "";
            txtAdresse.Text = "";
            txtEmail.Text = "";
            txtNomGarage.Text = "";
            txtTelephone.Text = "";
            comboTypeGarage.Text = "";
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            buttonModif.Visible = true;
            buttonSupprimer.Visible = true;
            buttonAjouterUtil.Visible = true;
            buttonValidModif.Visible = false;
            buttonAnnuler.Visible = false;
            deverouillerVerrouiller();
            buttonSuivant.Enabled = true;
            buttonDebut.Enabled = true;
            buttonFin.Enabled = true;
            buttonPrecedent.Enabled = true;
        }

        //rempli les champs de texte avec les valeurs en fonction de la position du selecteur dans le data grid
        private void AffecterValeurs(int ligne)
        {
            txtNumGarage.Text = dataGridViewGarages.Rows[ligne].Cells[0].Value.ToString();
            comboTypeGarage.Text = dataGridViewGarages.Rows[ligne].Cells[1].Value.ToString();
            txtNomGarage.Text = dataGridViewGarages.Rows[ligne].Cells[2].Value.ToString();
            txtAdresse.Text = dataGridViewGarages.Rows[ligne].Cells[3].Value.ToString();
            txtCodePostal.Text = dataGridViewGarages.Rows[ligne].Cells[4].Value.ToString();
            txtTelephone.Text = dataGridViewGarages.Rows[ligne].Cells[5].Value.ToString();
            txtEmail.Text = dataGridViewGarages.Rows[ligne].Cells[6].Value.ToString();

            dataGridViewGarages.Rows[ligne].Selected = true;
            dataGridViewGarages.CurrentCell = dataGridViewGarages.Rows[ligne].Cells[0];
        }

        //verrouiller les boutons Suivant/précédent en fonction de la position du selecteur
        private void Verrou()
        {

            if (dataGridViewGarages.RowCount == 0)
            {
                buttonSuivant.Enabled = false;
                buttonPrecedent.Enabled = false;
                buttonDebut.Enabled = false;
                buttonFin.Enabled = false;
            }
            else
            {
                if ((dataGridViewGarages.CurrentRow.Index == 0) && (dataGridViewGarages.CurrentRow.Index == dataGridViewGarages.RowCount - 1))
                {
                    buttonSuivant.Enabled = false;
                    buttonPrecedent.Enabled = false;
                    buttonDebut.Enabled = false;
                    buttonFin.Enabled = false;
                }
                else
                {
                    if (dataGridViewGarages.CurrentRow.Index == 0)
                    {
                        buttonSuivant.Enabled = true;
                        buttonPrecedent.Enabled = false;
                        buttonDebut.Enabled = false;
                        buttonFin.Enabled = true;
                    }
                    else
                    {
                        if (dataGridViewGarages.CurrentRow.Index == dataGridViewGarages.RowCount - 1)
                        {
                            buttonSuivant.Enabled = false;
                            buttonPrecedent.Enabled = true;
                            buttonDebut.Enabled = true;
                            buttonFin.Enabled = false;
                        }
                        else
                        {
                            buttonSuivant.Enabled = true;
                            buttonPrecedent.Enabled = true;
                            buttonDebut.Enabled = true;
                            buttonFin.Enabled = true;
                        }
                    }
                }
            }
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            AffecterValeurs(dataGridViewGarages.CurrentRow.Index + 1);
            Verrou();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if (dataGridViewGarages.CurrentRow.Index != 0)
            {
                AffecterValeurs(dataGridViewGarages.CurrentRow.Index - 1);
            }
            Verrou();
        }

        private void buttonDebut_Click(object sender, EventArgs e)
        {
            AffecterValeurs(0);
            Verrou();
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            AffecterValeurs(dataGridViewGarages.RowCount - 1);
            Verrou();
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            buttonSuivant.Enabled = false;
            buttonDebut.Enabled = false;
            buttonFin.Enabled = false;
            buttonPrecedent.Enabled = false;
            buttonSupprimer.Visible = false;
            buttonModif.Visible = false;
            buttonValidModif.Visible = true;
            buttonAnnuler.Visible = true;
            deverouillerVerrouiller();
        }

        private void buttonValidModif_Click(object sender, EventArgs e)
        {
            if (Verif() == false)
                MessageBox.Show("Veuillez compléter toutes les zones de saisies");
            
            else
            {
                //int numCmd = int.Parse(txtNumCommande.Text);
                //int numC = int.Parse(txtNumClient.Text);
                //int idGarage = int.Parse(txtNumGarage.Text);
                try
                {
                    /*commande uneCommande = db.commande.First(r => r.numCmd == numCmd);
                    uneCommande.numC = numC;
                    uneCommande.idGarage = idGarage;
                    uneCommande.dateCmd = txtDateCommande.Value;
                    uneCommande.dateLivraisonCmd = txtDateLivraison.Value;
                    uneCommande.etatCmd = comboEtatCommande.Text;*/
                    db.SaveChanges();
                    chargerDataGrind();

                    MessageBox.Show("Modification effectuée");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                buttonModif.Visible = true;
                buttonSupprimer.Visible = true;
                buttonValidModif.Visible = false;
                buttonAnnuler.Visible = false;
                Verrou();
                deverouillerVerrouiller();
            }
        }

        private void GestionGarages_Load(object sender, EventArgs e)
        {
            comboTypeGarage.DataSource = db.type_de_garage.ToList();
            comboTypeGarage.DisplayMember = "libelleType";
            comboTypeGarage.ValueMember = "idType";
        }
    }
}

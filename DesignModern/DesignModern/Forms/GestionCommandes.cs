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
            chargerDataGrind();
        }
        
        //remplir le data grid avec les données de la BDD
        private void chargerDataGrind()
        {
            dataGridViewCommandes.DataSource = db.commande.ToList();

            dataGridViewCommandes.DataSource = db.commande.Select(c => new
            {
                NumeroCmd = c.numCmd,
                NomClient = c.client.nomC + " " + c.client.prenomC,
                NumeroGarage = c.garage.nomG,
                DateCommande = c.dateCmd,
                DateLivraison = c.dateLivraisonCmd,
                Etat = c.etatCmd
            }).ToList();

            dataGridViewCommandes.Rows[0].Selected = true;
            dataGridViewCommandes.CurrentCell = dataGridViewCommandes.Rows[0].Cells[0];

            txtNumCommande.Text = dataGridViewCommandes.Rows[0].Cells[0].Value.ToString();
            txtNomClient.Text = dataGridViewCommandes.Rows[0].Cells[1].Value.ToString();
            txtNomGarage.Text = dataGridViewCommandes.Rows[0].Cells[2].Value.ToString();
            txtDateCommande.Value = DateTime.Parse(dataGridViewCommandes.Rows[0].Cells[3].Value.ToString());
            txtDateLivraison.Value = DateTime.Parse(dataGridViewCommandes.Rows[0].Cells[4].Value.ToString());
            comboEtatCommande.Text = dataGridViewCommandes.Rows[0].Cells[5].Value.ToString();
        }

        //verrouille ou deverouille les champs de texte
        private void deverouillerVerrouiller()
        {
            if (txtNumCommande.Enabled == true)
            {
                //Vérouillage
                txtNumCommande.Enabled = false;
                txtNomClient.Enabled = false;
                txtDateCommande.Enabled = false;
                txtDateLivraison.Enabled = false;
                txtNomGarage.Enabled = false;
                comboEtatCommande.Enabled = false;
            }
            else
            {
                //Déverouillage
                txtNumCommande.Enabled = true;
                txtNomClient.Enabled = true;
                txtDateCommande.Enabled = true;
                txtDateLivraison.Enabled = true;
                txtNomGarage.Enabled = true;
                comboEtatCommande.Enabled = true;
            }
        }

        //vérifie que les champs sont correctement remplis avant l'envoi à la base de données
        private bool Verif()
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

            if (txtNomClient.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtNomClient, "Veuillez indiquer le numéro de commande");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtNomClient, "");
            }

            if (txtNomGarage.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtNomGarage, "Veuillez indiquer le numéro de commande");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtNomGarage, "");
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

        //méthode de débug. vide les champs de texte
        private void remiseAZero()
        {
            txtNomGarage.Clear();
            txtNomClient.Clear();
            txtNumCommande.Clear();
            txtNumCommande.Enabled = false;
            txtNomClient.Enabled = false;
            txtDateCommande.Enabled = false;
            txtDateLivraison.Enabled = false;
            txtNomGarage.Enabled = false;
            comboEtatCommande.Enabled = false;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            buttonModif.Visible = true;
            buttonSupprimer.Visible = true;
            buttonValidModif.Visible = false;
            buttonAnnuler.Visible = false;
            deverouillerVerrouiller();
            Verrou();
        }

        //rempli les champs de texte avec les valeurs en fonction de la position du selecteur dans le data grid
        private void AffecterValeurs(int ligne)
        {
            txtNumCommande.Text = dataGridViewCommandes.Rows[ligne].Cells[0].Value.ToString();
            txtNomClient.Text = dataGridViewCommandes.Rows[ligne].Cells[1].Value.ToString();
            txtNomGarage.Text = dataGridViewCommandes.Rows[ligne].Cells[2].Value.ToString();
            txtDateCommande.Value = DateTime.Parse(dataGridViewCommandes.Rows[ligne].Cells[3].Value.ToString());
            txtDateLivraison.Value = DateTime.Parse(dataGridViewCommandes.Rows[ligne].Cells[4].Value.ToString());
            comboEtatCommande.Text = dataGridViewCommandes.Rows[ligne].Cells[5].Value.ToString();

            dataGridViewCommandes.Rows[ligne].Selected = true;
            dataGridViewCommandes.CurrentCell = dataGridViewCommandes.Rows[ligne].Cells[0];
        }

        //verrouiller les boutons Suivant/précédent en fonction de la position du selecteur
        private void Verrou()
        {
            //MessageBox.Show("Nb"+dataGridViewRevue.RowCount.ToString());
            //MessageBox.Show("Index" + dataGridViewRevue.CurrentRow.Index);

            if (dataGridViewCommandes.RowCount == 0)
            {
                buttonSuivant.Enabled = false;
                buttonPrecedent.Enabled = false;
                buttonDebut.Enabled = false;
                buttonFin.Enabled = false;
            }
            else
            {
                if ((dataGridViewCommandes.CurrentRow.Index == 0) && (dataGridViewCommandes.CurrentRow.Index == dataGridViewCommandes.RowCount - 1))
                {
                    buttonSuivant.Enabled = false;
                    buttonPrecedent.Enabled = false;
                    buttonDebut.Enabled = false;
                    buttonFin.Enabled = false;
                }
                else
                {
                    if (dataGridViewCommandes.CurrentRow.Index == 0)
                    {
                        buttonSuivant.Enabled = true;
                        buttonPrecedent.Enabled = false;
                        buttonDebut.Enabled = false;
                        buttonFin.Enabled = true;
                    }
                    else
                    {
                        if (dataGridViewCommandes.CurrentRow.Index == dataGridViewCommandes.RowCount - 1)
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
            AffecterValeurs(dataGridViewCommandes.CurrentRow.Index + 1);
            Verrou();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if (dataGridViewCommandes.CurrentRow.Index != 0)
            {
                AffecterValeurs(dataGridViewCommandes.CurrentRow.Index - 1);
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
            AffecterValeurs(dataGridViewCommandes.RowCount - 1);
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
                int numCmd = int.Parse(txtNumCommande.Text);
                int numC = int.Parse(txtNomClient.Text);
                int idGarage = int.Parse(txtNomGarage.Text);
                try
                {
                    commande uneCommande = db.commande.First(r => r.numCmd == numCmd);
                    uneCommande.numC = numC;
                    uneCommande.idGarage = idGarage;
                    uneCommande.dateCmd = txtDateCommande.Value;
                    uneCommande.dateLivraisonCmd = txtDateLivraison.Value;
                    uneCommande.etatCmd = comboEtatCommande.Text;
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

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer la commande de " + txtNomClient.Text + " ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            { }

            else
            {
                try
                {
                    commande uneCommande = db.commande.First(c => c.numCmd.ToString() == txtNumCommande.Text);
                    db.commande.Remove(uneCommande);
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
    }
}

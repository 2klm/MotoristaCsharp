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

        private void chargerDataGrind()
        {
            dataGridViewCommandes.DataSource = db.commande.ToList();

            dataGridViewCommandes.DataSource = db.commande.Select(c => new
            {
                NumeroCmd = c.numCmd,
                NumeroClient = c.numC,
                NumeroGarage = c.idGarage,
                DateCommande = c.dateCmd,
                DateLivraison = c.dateLivraisonCmd,
                Etait = c.etatCmd
            }).ToList();

            dataGridViewCommandes.Rows[0].Selected = true;
            dataGridViewCommandes.CurrentCell = dataGridViewCommandes.Rows[0].Cells[0];

            txtNumCommande.Text = dataGridViewCommandes.Rows[0].Cells[0].Value.ToString();
            txtNumClient.Text = dataGridViewCommandes.Rows[0].Cells[1].Value.ToString();
            txtNumGarage.Text = dataGridViewCommandes.Rows[0].Cells[2].Value.ToString();
            txtDateCommande.Value = DateTime.Parse(dataGridViewCommandes.Rows[0].Cells[3].Value.ToString());
            txtDateLivraison.Value = DateTime.Parse(dataGridViewCommandes.Rows[0].Cells[4].Value.ToString());
            comboEtatCommande.Text = dataGridViewCommandes.Rows[0].Cells[5].Value.ToString();
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

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            buttonModif.Visible = true;
            buttonSupprimer.Visible = true;
            buttonValidModif.Visible = false;
            buttonAnnuler.Visible = false;
            deverouillerVerrouiller();
            buttonSuivant.Enabled = true;
            buttonDebut.Enabled = true;
            buttonFin.Enabled = true;
            buttonPrecedent.Enabled = true;

        }

        private void AffecterValeurs(int ligne)
        {
            txtNumCommande.Text = dataGridViewCommandes.Rows[ligne].Cells[0].Value.ToString();
            txtNumClient.Text = dataGridViewCommandes.Rows[ligne].Cells[1].Value.ToString();
            txtNumGarage.Text = dataGridViewCommandes.Rows[ligne].Cells[2].Value.ToString();
            txtDateCommande.Value = DateTime.Parse(dataGridViewCommandes.Rows[ligne].Cells[3].Value.ToString());
            txtDateLivraison.Value = DateTime.Parse(dataGridViewCommandes.Rows[ligne].Cells[4].Value.ToString());
            comboEtatCommande.Text = dataGridViewCommandes.Rows[ligne].Cells[5].Value.ToString();

            dataGridViewCommandes.Rows[ligne].Selected = true;
            dataGridViewCommandes.CurrentCell = dataGridViewCommandes.Rows[ligne].Cells[0];
        }

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
            {
                MessageBox.Show("Veuillez compléter toutes les zones de saisies");
            }
            else
            {
                int numCmd = int.Parse(txtNumCommande.Text);
                int numC = int.Parse(txtNumClient.Text);
                int idGarage = int.Parse(txtNumGarage.Text);
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
    }
}

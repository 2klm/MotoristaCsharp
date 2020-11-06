using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DesignModern
{
    public partial class GestionVehicules : Form
    {
        private motoristaDbContext db;
        public GestionVehicules()
        {
            InitializeComponent();
            db = new motoristaDbContext();
            //chargerDataGrid();
        }

        private void chargerDataGrid()
        {
            dataGridViewVehicule.DataSource = db.voiture.ToList();

            dataGridViewVehicule.DataSource = db.voiture.Select(v => new
            {
                idVoiture = v.idVoiture,
                TypeVehicule = v.idTypeV,
                numSerieVehicule = v.numSerieV,
                Puissance = v.puissanceV,
                Energie = v.energieV,
                BoiteDeVitesse = v.boiteDeVitesseV,
                Garage = v.idGarage,
                Modele = v.idModele,
                Passagers = v.nbPassagerV,
                Couleur = v.couleurV,
                Prix = v.prixVenteV

            }).ToList();

            dataGridViewVehicule.Rows[0].Selected = true;
            AffecterValeurs(0);
            dataGridViewVehicule.CurrentCell = dataGridViewVehicule.Rows[0].Cells[0];
        }

        private void AffecterValeurs(int ligne)
        {
            txtNumeroVehicule.Text = dataGridViewVehicule.Rows[ligne].Cells[0].Value.ToString();
            txtTypeVehicule.Text = dataGridViewVehicule.Rows[ligne].Cells[1].Value.ToString();
            txtNumSerie.Text = dataGridViewVehicule.Rows[ligne].Cells[2].Value.ToString();
            txtPuissance.Text = dataGridViewVehicule.Rows[ligne].Cells[3].Value.ToString(); 
            txtEnergie.Text = dataGridViewVehicule.Rows[ligne].Cells[4].Value.ToString();
            txtBoiteVitesse.Text = dataGridViewVehicule.Rows[ligne].Cells[5].Value.ToString();
            txtGarage.Text = dataGridViewVehicule.Rows[ligne].Cells[6].Value.ToString();
            txtModele.Text = dataGridViewVehicule.Rows[ligne].Cells[7].Value.ToString();
            txtPassagers.Text = dataGridViewVehicule.Rows[ligne].Cells[8].Value.ToString();
            txtCouleur.Text = dataGridViewVehicule.Rows[ligne].Cells[9].Value.ToString();
            txtPrix.Text = dataGridViewVehicule.Rows[ligne].Cells[10].Value.ToString();

            dataGridViewVehicule.Rows[ligne].Selected = true;
            dataGridViewVehicule.CurrentCell = dataGridViewVehicule.Rows[ligne].Cells[0];
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
                txtPrix.Enabled = false;
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
                txtPrix.Enabled = true;
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
            txtPrix.Clear();
        }
        private void Verrou()
        {
            //MessageBox.Show("Nb"+dataGridViewRevue.RowCount.ToString());
            //MessageBox.Show("Index" + dataGridViewRevue.CurrentRow.Index);

            if (dataGridViewVehicule.RowCount == 0)
            {
                buttonSuivant.Enabled = false;
                buttonPrecedent.Enabled = false;
                buttonDebut.Enabled = false;
                buttonFin.Enabled = false;
            }
            else
            {
                if ((dataGridViewVehicule.CurrentRow.Index == 0) && (dataGridViewVehicule.CurrentRow.Index == dataGridViewVehicule.RowCount - 1))
                {
                    buttonSuivant.Enabled = false;
                    buttonPrecedent.Enabled = false;
                    buttonDebut.Enabled = false;
                    buttonFin.Enabled = false;
                }
                else
                {
                    if (dataGridViewVehicule.CurrentRow.Index == 0)
                    {
                        buttonSuivant.Enabled = true;
                        buttonPrecedent.Enabled = false;
                        buttonDebut.Enabled = false;
                        buttonFin.Enabled = true;
                    }
                    else
                    {
                        if (dataGridViewVehicule.CurrentRow.Index == dataGridViewVehicule.RowCount - 1)
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

        private void GestionVehicules_Load(object sender, System.EventArgs e)
        {
            chargerDataGrid();
        }

        private void buttonAjouter_Click(object sender, System.EventArgs e)
        {
            remiseAZero();
            deverouillerVerrouiller();
            buttonAjouter.Enabled = false;
            buttonSupprimer.Enabled = false;
            buttonModif.Enabled = false;
            buttonValidAjout.Enabled = true;
            buttonValidAjout.Visible = true;
            buttonValidModif.Enabled = false;
            buttonAjouter.Enabled = false;
            buttonAnnuler.Enabled = true;
            buttonAnnuler.Visible = true;
        }

        private void buttonValidAjout_Click(object sender, System.EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Veuillez compléter toutes les zones de saisies");
            }
            else
            {
                try
                {
                    voiture uneVoiture = new voiture();
                    uneVoiture.idVoiture = Convert.ToInt32(txtNumeroVehicule.Text);
                    uneVoiture.idTypeV = Convert.ToInt32(txtTypeVehicule.Text);
                    uneVoiture.numSerieV = Convert.ToInt32(txtNumSerie.Text);
                    uneVoiture.puissanceV = Convert.ToInt32(txtPuissance.Text);
                    uneVoiture.energieV = txtEnergie.Text;
                    uneVoiture.boiteDeVitesseV = txtBoiteVitesse.Text;
                    uneVoiture.idGarage = Convert.ToInt32(txtGarage.Text);
                    uneVoiture.idModele = Convert.ToInt32(txtModele.Text);
                    uneVoiture.nbPassagerV = Convert.ToInt32(txtPassagers.Text);
                    uneVoiture.couleurV = txtCouleur.Text;
                    uneVoiture.prixVenteV = Convert.ToInt32(txtPrix.Text);

                    db.voiture.Add(uneVoiture);
                    db.SaveChanges();
                    chargerDataGrid();
                    deverouillerVerrouiller();

                    MessageBox.Show("Ajout effectué");
                    chargerDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Activation / Désactivation des boutons
                buttonModif.Enabled = true;
                buttonSupprimer.Enabled = true;
                buttonValidAjout.Enabled = false;
                buttonValidAjout.Visible = false;
                buttonValidModif.Enabled = false;
                buttonAjouter.Enabled = true;
                buttonAjouter.Enabled = false;
                buttonAnnuler.Visible = false;
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            deverouillerVerrouiller();
            buttonValidAjout.Visible = false;
            buttonAnnuler.Visible = false;
            buttonAjouter.Enabled = true;
            buttonModif.Enabled = true;
            buttonSupprimer.Enabled = true;
            buttonValidModif.Visible = false;
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            deverouillerVerrouiller();
            buttonModif.Enabled = false;
            buttonSupprimer.Enabled = false;
            buttonValidAjout.Enabled = true;
            buttonValidAjout.Visible = false;
            buttonValidModif.Enabled = true;
            buttonValidModif.Visible = true;
            buttonAjouter.Enabled = false;
            buttonAnnuler.Enabled = true;
            buttonAnnuler.Visible = true;
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
                    voiture uneVoiture = db.voiture.First(v => v.idVoiture.ToString() == txtNumeroVehicule.Text);
                    uneVoiture.idVoiture = Convert.ToInt32(txtNumeroVehicule.Text);
                    uneVoiture.idTypeV = Convert.ToInt32(txtTypeVehicule.Text);
                    uneVoiture.numSerieV = Convert.ToInt32(txtNumSerie.Text);
                    uneVoiture.puissanceV = Convert.ToInt32(txtPuissance.Text);
                    uneVoiture.energieV = txtEnergie.Text;
                    uneVoiture.boiteDeVitesseV = txtBoiteVitesse.Text;
                    uneVoiture.idGarage = Convert.ToInt32(txtGarage.Text);
                    uneVoiture.idModele = Convert.ToInt32(txtModele.Text);
                    uneVoiture.nbPassagerV = Convert.ToInt32(txtPassagers.Text);
                    uneVoiture.couleurV = txtCouleur.Text;
                    uneVoiture.prixVenteV = Convert.ToInt32(txtPrix.Text);

                    db.SaveChanges();
                    chargerDataGrid();
                    deverouillerVerrouiller();

                    MessageBox.Show("Modification effectué");
                    chargerDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Activation / Désactivation des boutons
                buttonModif.Enabled = true;
                buttonSupprimer.Enabled = true;
                buttonValidAjout.Enabled = false;
                buttonValidAjout.Visible = false;
                buttonValidModif.Enabled = false;
                buttonValidModif.Visible = false;
                buttonAjouter.Enabled = true;
                buttonAnnuler.Enabled = false;
                buttonAnnuler.Visible = false;
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer " +txtNumeroVehicule + " " + txtNumSerie, "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Suppression annulée");
            }
            else
            {
                try
                {
                    //Suppresion (Reste maintenant à afficher quel client supprimer !

                    voiture uneVoiture = db.voiture.First(v => v.idVoiture.ToString() == txtNumeroVehicule.Text);
                    db.voiture.Remove(uneVoiture);
                    db.SaveChanges();
                    chargerDataGrid();
                    deverouillerVerrouiller();

                    MessageBox.Show("Suppression effectuée");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewVehicule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AffecterValeurs(dataGridViewVehicule.CurrentRow.Index);
        }

        private void buttonDebut_Click(object sender, EventArgs e)
        {
            AffecterValeurs(0);
            Verrou();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehicule.CurrentRow.Index != 0)
            {
                AffecterValeurs(dataGridViewVehicule.CurrentRow.Index - 1);
            }
            Verrou();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            AffecterValeurs(dataGridViewVehicule.CurrentRow.Index + 1);
            Verrou();
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            AffecterValeurs(dataGridViewVehicule.RowCount - 1);
            Verrou();
        }
    }
}

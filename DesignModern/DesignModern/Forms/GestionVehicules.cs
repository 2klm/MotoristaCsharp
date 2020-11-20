using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DesignModern
{
    public partial class GestionVehicules : Form
    {
        int z = 0;
        private motoristaDbContext db;
        public GestionVehicules()
        {
            InitializeComponent();
            db = new motoristaDbContext();
            chargerDataGrid();
        }

        private void chargerDataGrid()
        {
            dataGridViewVehicule.DataSource = db.voiture.ToList();

            dataGridViewVehicule.DataSource = db.voiture.Select(v => new
            {
                v.idVoiture,
                TypeVehicule = v.type_de_voiture.etatTypeV,
                numSerieVehicule = v.numSerieV,
                Puissance = v.puissanceV,
                Energie = v.energieV,
                BoiteDeVitesse = v.boiteDeVitesseV,
                Garage = v.garage.nomG,
                Modele = v.modele.nomModele,
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
            comboBoxTypesVehicules.Text = dataGridViewVehicule.Rows[ligne].Cells[1].Value.ToString();
            txtNumSerie.Text = dataGridViewVehicule.Rows[ligne].Cells[2].Value.ToString();
            txtPuissance.Text = dataGridViewVehicule.Rows[ligne].Cells[3].Value.ToString(); 
            txtEnergie.Text = dataGridViewVehicule.Rows[ligne].Cells[4].Value.ToString();
            txtBoiteVitesse.Text = dataGridViewVehicule.Rows[ligne].Cells[5].Value.ToString();
            comboBoxTypesGarage.Text = dataGridViewVehicule.Rows[ligne].Cells[6].Value.ToString();
            comboBoxModele.Text = dataGridViewVehicule.Rows[ligne].Cells[7].Value.ToString().Trim();
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
                txtNumSerie.Enabled = false;
                txtPuissance.Enabled = false;
                txtCouleur.Enabled = false;
                txtEnergie.Enabled = false;
                txtBoiteVitesse.Enabled = false;
                comboBoxTypesGarage.Enabled = false;
                comboBoxModele.Enabled = false;
                txtPassagers.Enabled = false;
                txtPrix.Enabled = false;
                comboBoxTypesVehicules.Enabled = false;
            }
            else
            {
                //Déverouillage
                txtNumeroVehicule.Enabled = true;
                txtNumSerie.Enabled = true;
                txtPuissance.Enabled = true;
                txtCouleur.Enabled = true;
                txtEnergie.Enabled = true;
                txtBoiteVitesse.Enabled = true;
                comboBoxTypesGarage.Enabled = true;
                comboBoxModele.Enabled = true;
                txtPassagers.Enabled = true;
                txtPrix.Enabled = true;
                comboBoxTypesVehicules.Enabled = true;
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

            if (comboBoxTypesVehicules.Text.Trim() == "")
            {
                errorProviderErreur.SetError(comboBoxTypesVehicules, "Veuillez indiquer votre nom");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(comboBoxTypesVehicules, "");
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
            if (comboBoxTypesGarage.Text.Trim() == "")
            {
                errorProviderErreur.SetError(comboBoxTypesGarage, "Veuillez indiquer votre login");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(comboBoxTypesGarage, "");
            }
            if (comboBoxModele.Text.Trim() == "")
            {
                errorProviderErreur.SetError(comboBoxModele, "Veuillez indiquer votre email");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(comboBoxModele, "");
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
            txtNumSerie.Clear();
            txtPuissance.Clear();
            txtCouleur.Clear();
            txtEnergie.Clear();
            txtBoiteVitesse.Clear();
            comboBoxTypesGarage.Text ="";
            comboBoxModele.Text ="";
            txtPassagers.Clear();
            txtPrix.Clear();
            comboBoxTypesVehicules.Text = "";
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
            chargerComboBox();
        }

        private void buttonAjouter_Click(object sender, System.EventArgs e)
        {
            z = 1;
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
            txtNumeroVehicule.Focus();
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
                    uneVoiture.numSerieV = Convert.ToInt32(txtNumSerie.Text);
                    uneVoiture.puissanceV = Convert.ToInt32(txtPuissance.Text);
                    uneVoiture.energieV = txtEnergie.Text;
                    uneVoiture.boiteDeVitesseV = txtBoiteVitesse.Text;
                    uneVoiture.idGarage = Convert.ToInt32(comboBoxTypesGarage.SelectedValue.ToString());
                    uneVoiture.idModele = Convert.ToInt32(comboBoxModele.SelectedValue.ToString());
                    uneVoiture.nbPassagerV = Convert.ToInt32(txtPassagers.Text);
                    uneVoiture.couleurV = txtCouleur.Text;
                    uneVoiture.prixVenteV = Convert.ToInt32(txtPrix.Text);
                    uneVoiture.idTypeV = Convert.ToInt32(comboBoxTypesVehicules.SelectedValue.ToString());

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
            
            if (z == 1)
            {
               AffecterValeurs(0);
                z = 0;
                chargerComboBox();
            }

        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            z = 1;
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
                    uneVoiture.numSerieV = Convert.ToInt32(txtNumSerie.Text);
                    uneVoiture.puissanceV = Convert.ToInt32(txtPuissance.Text);
                    uneVoiture.energieV = txtEnergie.Text;
                    uneVoiture.boiteDeVitesseV = txtBoiteVitesse.Text;
                    uneVoiture.idGarage = Convert.ToInt32(comboBoxTypesGarage.SelectedValue.ToString());
                    uneVoiture.idModele = Convert.ToInt32(comboBoxModele.SelectedValue.ToString());
                    uneVoiture.nbPassagerV = Convert.ToInt32(txtPassagers.Text);
                    uneVoiture.couleurV = txtCouleur.Text;
                    uneVoiture.prixVenteV = Convert.ToInt32(txtPrix.Text);
                    uneVoiture.idTypeV = Convert.ToInt32(comboBoxTypesVehicules.SelectedValue.ToString());

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
            chargerComboBox();
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
        public void chargerComboBox()
        {
            comboBoxTypesVehicules.DataSource = db.type_de_voiture.ToList();
            comboBoxTypesVehicules.DisplayMember = "etatTypeV";
            comboBoxTypesVehicules.ValueMember = "idTypeV";

            comboBoxTypesGarage.DataSource = db.garage.ToList();
            comboBoxTypesGarage.DisplayMember = "nomG";
            comboBoxTypesGarage.ValueMember = "idGarage";

            comboBoxModele.DataSource = db.modele.ToList();
            comboBoxModele.DisplayMember = "nomModele";
            comboBoxModele.ValueMember = "idModele";
        }
    }
}

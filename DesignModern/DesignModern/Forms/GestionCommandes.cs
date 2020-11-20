using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DesignModern
{
    public partial class GestionCommandes : Form
    {
        private motoristaDbContext db;
        public GestionCommandes()
        {
            //au démarrage
            InitializeComponent();
            db = new motoristaDbContext(); //on instancie un objet de "type" base de données
            chargerDataGrind();
        }
        
        //remplir le data grid avec les données de la BDD
        private void chargerDataGrind()
        {
            dataGridViewCommandes.DataSource = db.commande.ToList(); 

            dataGridViewCommandes.DataSource = db.commande.Select(c => new
            {
                NumeroCmd = c.numCmd,
                NomClient = c.client.nomC,
                idGarage = c.garage.nomG,
                DateCommande = c.dateCmd,
                DateLivraison = c.dateLivraisonCmd,
                Etat = c.etatCmd
            }).ToList();

            //on place le curseur sur la première ligne du data grid invisible
            dataGridViewCommandes.Rows[0].Selected = true;
            dataGridViewCommandes.CurrentCell = dataGridViewCommandes.Rows[0].Cells[0];

            //affecter les valeurs aux champs de texte
            txtNumCommande.Text = dataGridViewCommandes.Rows[0].Cells[0].Value.ToString();
            comboBoxNomClient.Text = dataGridViewCommandes.Rows[0].Cells[1].Value.ToString();
            comboBoxGarage.Text = dataGridViewCommandes.Rows[0].Cells[2].Value.ToString();
            txtDateCommande.Value = DateTime.Parse(dataGridViewCommandes.Rows[0].Cells[3].Value.ToString());
            txtDateLivraison.Value = DateTime.Parse(dataGridViewCommandes.Rows[0].Cells[4].Value.ToString());
            comboEtatCommande.Text = dataGridViewCommandes.Rows[0].Cells[5].Value.ToString();
        }

        //verrouille ou deverouille les champs de texte
        private void deverouillerVerrouiller()
        {
            if (comboEtatCommande.Enabled == true)
            {
                //Vérouillage
                txtNumCommande.Enabled = false;
                comboBoxNomClient.Enabled = false;
                txtDateCommande.Enabled = false;
                txtDateLivraison.Enabled = false;
                comboBoxGarage.Enabled = false;
                comboEtatCommande.Enabled = false;
            }
            else
            {
                //Déverouillage
                txtDateCommande.Enabled = true;
                txtDateLivraison.Enabled = true;
                comboBoxGarage.Enabled = true;
                comboEtatCommande.Enabled = true;
            }
        }

        //vérifie que les champs sont correctement remplis avant l'envoi à la base de données
        private bool Verif()
        {
            bool verification = true;
            //au début la vérification est considérée comme "ok", mais changera d'état si on rentre dans un if

            if (txtNumCommande.Text.Trim() == "")
            {
                errorProviderErreur.SetError(txtNumCommande, "Veuillez indiquer le numéro de commande");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(txtNumCommande, "");
            }

            if (comboBoxNomClient.Text.Trim() == "")
            {
                errorProviderErreur.SetError(comboBoxNomClient, "Veuillez indiquer le nom du client");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(comboBoxNomClient, "");
            }

            if (comboBoxGarage.Text.Trim() == "")
            {
                errorProviderErreur.SetError(comboBoxGarage, "Veuillez indiquer le numéro de commande");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(comboBoxGarage, "");
            }

            if (comboEtatCommande.Text.Trim() == "")
            {
                errorProviderErreur.SetError(comboEtatCommande, "Veuillez indiquer l'état de commande");
                verification = false;
            }
            else
            {
                errorProviderErreur.SetError(comboEtatCommande, "");
            }

            return (verification); //retourne false si un des champs n'est pas correctement rempli
        }

        //méthode de débug. vide les champs de texte
        private void remiseAZero()
        {
            txtNumCommande.Clear();
            txtNumCommande.Enabled = false;
            comboBoxNomClient.Enabled = false;
            txtDateCommande.Enabled = false;
            txtDateLivraison.Enabled = false;
            comboBoxGarage.Enabled = false;
            comboEtatCommande.Enabled = false;
        }

        //clic bouton annuler
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
            comboBoxNomClient.Text = dataGridViewCommandes.Rows[ligne].Cells[1].Value.ToString();
            comboBoxGarage.Text = dataGridViewCommandes.Rows[ligne].Cells[2].Value.ToString();
            txtDateCommande.Value = DateTime.Parse(dataGridViewCommandes.Rows[ligne].Cells[3].Value.ToString());
            txtDateLivraison.Value = DateTime.Parse(dataGridViewCommandes.Rows[ligne].Cells[4].Value.ToString());
            comboEtatCommande.Text = dataGridViewCommandes.Rows[ligne].Cells[5].Value.ToString();

            dataGridViewCommandes.Rows[ligne].Selected = true;
            dataGridViewCommandes.CurrentCell = dataGridViewCommandes.Rows[ligne].Cells[0];
        }

        //verrouiller les boutons Suivant/précédent en fonction de la position du selecteur
        private void Verrou()
        {
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

        //clic bouton suivant
        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            AffecterValeurs(dataGridViewCommandes.CurrentRow.Index + 1);
            Verrou();
        }
        
        //clic bouton précédent
        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if (dataGridViewCommandes.CurrentRow.Index != 0)
            {
                AffecterValeurs(dataGridViewCommandes.CurrentRow.Index - 1);
            }
            Verrou();
        }

        //clic bouton debut
        private void buttonDebut_Click(object sender, EventArgs e)
        {
            AffecterValeurs(0);
            Verrou();
        }

        //clic bouton fin
        private void buttonFin_Click(object sender, EventArgs e)
        {
            AffecterValeurs(dataGridViewCommandes.RowCount - 1);
            Verrou();
        }

        //clic sur le bouton "modifier"
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

        //validation des modifications
        private void buttonValidModif_Click(object sender, EventArgs e)
        {
            //si tous les champs ne sont pas correctement remplis, on affiche un message, sinon on envoie les modifications à la base de données
            if (Verif() == false)
                MessageBox.Show("Veuillez compléter toutes les zones de saisies");
            
            else
            {
                int numCmd = int.Parse(txtNumCommande.Text);
                try
                {
                    commande uneCommande = db.commande.First(r => r.numCmd == numCmd);
                    uneCommande.numC = int.Parse(comboBoxNomClient.SelectedValue.ToString());
                    uneCommande.idGarage = int.Parse(comboBoxGarage.SelectedValue.ToString()) ;
                    uneCommande.dateCmd = txtDateCommande.Value;
                    uneCommande.dateLivraisonCmd = txtDateLivraison.Value;
                    uneCommande.etatCmd = comboEtatCommande.Text;
                    db.SaveChanges();
                    chargerDataGrind();

                    MessageBox.Show("Modification effectuée");
                }
                catch (Exception ex) // si la modification echoue on affiche le message d'erreur à l'utilisateur
                {
                    MessageBox.Show(ex.Message);
                }

                //on rétablit l'était initial des boutons supprimer, modifier etc..., on réaffiche les valeurs des champs et déverouille le selecteur
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
            //demande de confirmation à l'utilisateur
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer la commande de " + comboBoxNomClient.Text + " ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            { }

            else
            {
                try //on vérifie que la modification est possible au niveau de la BDD
                {
                    commande uneCommande = db.commande.First(c => c.numCmd.ToString() == txtNumCommande.Text);
                    db.commande.Remove(uneCommande);
                    db.SaveChanges();
                    chargerDataGrind();
                    deverouillerVerrouiller();

                    MessageBox.Show("Suppression effectuée");
                }
                catch (Exception ex) // si la modification echoue on affiche le message d'erreur à l'utilisateur
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //on charge les comboBox au moment ou le formulaire s'ouvre
        private void GestionCommandes_Load(object sender, EventArgs e)
        {
            comboBoxGarage.DataSource = db.garage.ToList();
            comboBoxGarage.DisplayMember = "nomG";
            comboBoxGarage.ValueMember = "idGarage";

            comboBoxNomClient.DataSource = db.client.ToList();
            comboBoxNomClient.DisplayMember = "nomC";
            comboBoxNomClient.ValueMember = "numC";
        }
    }
}

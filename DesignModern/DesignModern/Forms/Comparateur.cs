using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignModern.Forms
{
    public partial class Comparateur : Form
    {
        private motoristaDbContext db;

        //variables qui correspondent aux attributs à comparer des véhicules 1 et 2
        /*double prixP, prixS;
        int puissanceP, puissanceS;
        string boiteVitesseP, boiteVitesseS;
        string energieP, energieS;
        int nbPassagersP, nbPassagersS;*/

        public Comparateur()
        {
            InitializeComponent();
            db = new motoristaDbContext();
            chargerDataGridPremier();
            chargerDataGridSecond();
        }

        //clic sur le bouton comparer
        private void btnComparer_Click(object sender, EventArgs e)
        {
            AffecterValeursPremier(dataGridPremier.CurrentRow.Index);
            AffecterValeursSecond(dataGridSecond.CurrentRow.Index);

            comparerVehicules();
        }

        public void comparerVehicules()
        {
            int ptsPremier = 0;
            int ptsSecond = 0;

            if (int.Parse(prixPremier.Text) > int.Parse(prixSecond.Text))
            {
                prixPremier.ForeColor = Color.Red;
                prixSecond.ForeColor = Color.Green;
                ptsSecond++;
            }

            else if (int.Parse(prixPremier.Text) < int.Parse(prixSecond.Text))
            {
                prixSecond.ForeColor = Color.Red;
                prixPremier.ForeColor = Color.Green;
                ptsPremier++;
            }

            else
            {
                prixSecond.ForeColor = Color.Yellow;
                prixPremier.ForeColor = Color.Yellow;
            }

            //

            if (int.Parse(puissancePremier.Text) < int.Parse(puissanceSecond.Text))
            {
                puissancePremier.ForeColor = Color.Red;
                puissanceSecond.ForeColor = Color.Green;
                ptsSecond++;
            }

            else if (int.Parse(puissancePremier.Text) > int.Parse(puissanceSecond.Text))
            {
                puissanceSecond.ForeColor = Color.Red;
                puissancePremier.ForeColor = Color.Green;
                ptsPremier++;
            }

            else
            {
                puissanceSecond.ForeColor = Color.Yellow;
                puissancePremier.ForeColor = Color.Yellow;
            }

            //

            if (int.Parse(boitePremier.Text) < int.Parse(boiteSecond.Text))
            {
                boitePremier.ForeColor = Color.Red;
                boiteSecond.ForeColor = Color.Green;
                ptsSecond++;
            }

            else if (int.Parse(boitePremier.Text) > int.Parse(boiteSecond.Text))
            {
                boiteSecond.ForeColor = Color.Red;
                boitePremier.ForeColor = Color.Green;
                ptsPremier++;
            }

            else
            {
                boiteSecond.ForeColor = Color.Yellow;
                boitePremier.ForeColor = Color.Yellow;
            }

            //
            if (int.Parse(passagersPremier.Text) > int.Parse(passagersSecond.Text))
            {
                passagersPremier.ForeColor = Color.Green;
                passagersSecond.ForeColor = Color.Red;
                ptsPremier++;
            }
            else if (int.Parse(passagersPremier.Text) < int.Parse(passagersSecond.Text))
            {
                passagersPremier.ForeColor = Color.Red;
                passagersSecond.ForeColor = Color.Green;
                ptsSecond++;
            }
            else
            {
                passagersPremier.ForeColor = Color.Yellow;
                passagersSecond.ForeColor = Color.Yellow;
            }

            //

            switch (energiePremier.Text)
            {
                case "hybride" when energieSecond.Text == "essence":
                    energiePremier.ForeColor = Color.Green;
                    energieSecond.ForeColor = Color.Red;
                    ptsPremier++;
                    break;
                case "electrique" when energieSecond.Text == "essence":
                    energiePremier.ForeColor = Color.Green;
                    energieSecond.ForeColor = Color.Red;
                    ptsPremier++;
                    break;
                case "electrique" when energieSecond.Text == "hybride":
                    energiePremier.ForeColor = Color.Green;
                    energieSecond.ForeColor = Color.Red;
                    ptsPremier++;
                    break;
                case "essence" when energieSecond.Text == "hybride":
                    energiePremier.ForeColor = Color.Red;
                    energieSecond.ForeColor = Color.Green;
                    ptsSecond++;
                    break;
                case "essence" when energieSecond.Text == "electrique":
                    energiePremier.ForeColor = Color.Red;
                    energieSecond.ForeColor = Color.Green;
                    ptsSecond++;
                    break;
                case "hybride" when energieSecond.Text == "electrique":
                    energiePremier.ForeColor = Color.Red;
                    energieSecond.ForeColor = Color.Green;
                    ptsSecond++;
                    break;
                case "hybride" when energieSecond.Text == "hybride":
                    energiePremier.ForeColor = Color.Yellow;
                    energieSecond.ForeColor = Color.Yellow;
                    break;
                case "essence" when energieSecond.Text == "essence":
                    energiePremier.ForeColor = Color.Yellow;
                    energieSecond.ForeColor = Color.Yellow;
                    break;
                case "electrique" when energieSecond.Text == "electrique":
                    energiePremier.ForeColor = Color.Yellow;
                    energieSecond.ForeColor = Color.Yellow;
                    break;
                default:
                    break;
            }

            if((ptsPremier != 0) && (ptsSecond != 0))
            {
               if(ptsPremier > ptsSecond)
                {
                    resultat.Text = "Le meilleur véhicule d'après notre comparateur est le véhicule numéro 1 avec un score de : " + ptsPremier;
                    resultat.ForeColor = Color.Green;
                }
                else
                {
                    resultat.Text = "Le meilleur véhicule d'après notre comparateur est le véhicule numéro 2 avec un score de : " + ptsSecond;
                    resultat.ForeColor = Color.Green;
                }
            }
            else
            {
                resultat.Text = "Il semblerait que vous ayez tester le même vehicule !" + "\n" + "Veuillez choisir deux véhicule différents afin d'obtenir un résulat concluent !";
                resultat.ForeColor = Color.Red;
            }

        }

        public void AffecterValeursPremier(int index)
        {
            prixPremier.Text = dataGridPremier.Rows[index].Cells[4].Value.ToString();
            puissancePremier.Text = dataGridPremier.Rows[index].Cells[2].Value.ToString();
            boitePremier.Text = dataGridPremier.Rows[index].Cells[5].Value.ToString();
            energiePremier.Text = dataGridPremier.Rows[index].Cells[3].Value.ToString();
            passagersPremier.Text = dataGridPremier.Rows[index].Cells[1].Value.ToString();
        }

        public void AffecterValeursSecond(int index)
        {
            prixSecond.Text = dataGridSecond.Rows[index].Cells[4].Value.ToString();
            puissanceSecond.Text = dataGridSecond.Rows[index].Cells[2].Value.ToString();
            boiteSecond.Text = dataGridSecond.Rows[index].Cells[5].Value.ToString();
            energieSecond.Text = dataGridSecond.Rows[index].Cells[3].Value.ToString();
            passagersSecond.Text = dataGridSecond.Rows[index].Cells[1].Value.ToString();
        }

        //charger le premier data grid et applique de thème des couleurs
        private void chargerDataGridPremier()
        {
            dataGridPremier.DataSource = db.voiture.ToList();
            //chargement des données dans le data grid
            dataGridPremier.DataSource = db.voiture.Select(c => new
            {
                Modele = c.modele.nomModele,
                Passagers = c.nbPassagerV,
                Puissance = c.puissanceV,
                Energie = c.energieV,
                Prix = c.prixVenteV,
                Vitesses = c.boiteDeVitesseV,
            }).ToList();

            dataGridPremier.Rows[0].Selected = true;
            dataGridPremier.CurrentCell = dataGridPremier.Rows[0].Cells[0];

            //applique les couleurs
            dataGridPremier.BorderStyle = BorderStyle.None;
            dataGridPremier.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            dataGridPremier.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridPremier.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridPremier.EnableHeadersVisualStyles = false;
            dataGridPremier.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridPremier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        //charger le deuxième data grid et applique de thème des couleurs
        private void chargerDataGridSecond()
        {
            dataGridSecond.DataSource = db.voiture.ToList();
            //chargement des données dans le data grid
            dataGridSecond.DataSource = db.voiture.Select(c => new
            {
                Modele = c.modele.nomModele,
                Passagers = c.nbPassagerV,
                Puissance = c.puissanceV,
                Energie = c.energieV,
                Prix = c.prixVenteV,
                Vitesses = c.boiteDeVitesseV,

            }).ToList();

            dataGridSecond.Rows[0].Selected = true;
            dataGridSecond.CurrentCell = dataGridSecond.Rows[0].Cells[0];

            //applique les couleurs
            dataGridSecond.BorderStyle = BorderStyle.None;
            dataGridSecond.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            dataGridSecond.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridSecond.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridSecond.EnableHeadersVisualStyles = false;
            dataGridSecond.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridSecond.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        //executé au chargement du formulaire
        private void Comparateur_Load(object sender, EventArgs e)
        {
            dataGridPremier.Rows[0].Selected = true;
            dataGridSecond.Rows[0].Selected = true;
        }

        private void dataGridPremier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridPremier.Rows[e.RowIndex].Selected = true;
            }
            catch 
            { 
                //
            } 
              
        }

        private void dataGridSecond_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridSecond.Rows[e.RowIndex].Selected = true;
            }
            catch
            {
                //
            }
        }
    }
}

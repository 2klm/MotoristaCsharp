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
               //txtCouleur.Enabled = false;
                //txtEnergie.Enabled = false;
                //txtBoiteVitesse.Enabled = false;
                txtGarage.Enabled = false;
                txtGarage.Enabled = false;
               // txtPassagers.Enabled = false;
            }
            else
            {
                //Déverouillage
                txtNumCommande.Enabled = true;
                txtNumClient.Enabled = true;
                txtDateCommande.Enabled = true;
                txtDateLivraison.Enabled = true;
               // txtCouleur.Enabled = true;
                //txtEnergie.Enabled = true;
                //txtBoiteVitesse.Enabled = true;
                txtGarage.Enabled = true;
                txtGarage.Enabled = true;
                //txtPassagers.Enabled = true;
            }
        }
        private bool verif()
        {
            
            return true;
        }
        private void remiseAZero()
        {
            /*txtNumCommande.Clear();
            txtNumClient.Clear();
            txtDateCommande.Clear();
            txtDateLivraison.Clear();
            txtCouleur.Clear();
            txtEnergie.Clear();
            txtBoiteVitesse.Clear();
            txtGarage.Clear();
            txtGarage.Clear();
            txtPassagers.Clear();*/
        }
    }
}

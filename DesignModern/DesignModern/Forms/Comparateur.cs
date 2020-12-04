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
        
        public Comparateur()
        {
            InitializeComponent();
            db = new motoristaDbContext();
            chargerDataGridPremier();
            chargerDataGridSecond();
        }

        private void btnComparer_Click(object sender, EventArgs e)
        {
  
            
        }

        private void chargerDataGridPremier()
        {
            dataGridPremier.DataSource = db.voiture.ToList();

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

            dataGridPremier.BorderStyle = BorderStyle.None;
            dataGridPremier.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            dataGridPremier.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridPremier.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridPremier.EnableHeadersVisualStyles = false;
            dataGridPremier.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridPremier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

        }

        private void chargerDataGridSecond()
        {
            dataGridSecond.DataSource = db.voiture.ToList();

            dataGridSecond.DataSource = db.voiture.Select(c => new
            {
                idVoitureD = c.idVoiture,
                idGarageD = c.idGarage,
                idTypeD = c.idTypeV,
                ModeleD = c.modele.idModele,
                numSerieD = c.numSerieV,
                nbPassagersD = c.nbPassagerV,
                nbKmD = c.nbKmV,
                puissanceD = c.puissanceV,
                couleurD = c.couleurV,
                energieD = c.energieV,
                prixD = c.prixVenteV,
                boitevitesseD = c.boiteDeVitesseV

            }).ToList();

            dataGridSecond.Rows[0].Selected = true;
            dataGridSecond.CurrentCell = dataGridSecond.Rows[0].Cells[0];            
        }

        private void Comparateur_Load(object sender, EventArgs e)
        {
        }

    }
}

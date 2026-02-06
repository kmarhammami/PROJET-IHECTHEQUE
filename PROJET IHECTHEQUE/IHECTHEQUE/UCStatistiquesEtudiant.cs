using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace IHECTHEQUE
{
    public partial class UCStatistiquesEtudiant : UserControl
    {
        private int idUtilisateur;
        public UCStatistiquesEtudiant(int idUtilisateur)
        {
            InitializeComponent();
            this.idUtilisateur = idUtilisateur;
        }

        private void UCStatistiquesEtudiant_Load(object sender, EventArgs e)
        {

        }

        private void panelLIVFAVPAGE4ET_Paint(object sender, PaintEventArgs e)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Favoris WHERE id_utilisateur = @userId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", idUtilisateur);
                    int totalFavoris = (int)cmd.ExecuteScalar();
                    lblNombreFavoris.Text = $"Nombre de livres favoris : {totalFavoris}";
                }
            }
        }

        private void lblNombreFavoris_Click(object sender, EventArgs e)
        {

        }

        private void panelTOTempPAGE4ET_Paint(object sender, PaintEventArgs e)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT COUNT(*) 
            FROM Emprunt 
            WHERE id_utilisateur = @userId AND statut = 'Confirmé' AND date_retour IS NULL";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", idUtilisateur);
                    int totalEnCours = (int)cmd.ExecuteScalar();
                    lblTotalEmprunts.Text = $"Livres empruntés en cours : {totalEnCours}";
                }
            }
        }

        private void lblTotalEmprunts_Click(object sender, EventArgs e)
        {

        }

    }
}

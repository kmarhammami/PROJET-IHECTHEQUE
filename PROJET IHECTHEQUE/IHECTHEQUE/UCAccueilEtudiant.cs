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
    public partial class UCAccueilEtudiant : UserControl
    {
        private int idUtilisateur;

        public UCAccueilEtudiant(int idUtilisateur)
        {
            InitializeComponent();
            this.idUtilisateur = idUtilisateur;
        }




        private void UCAccueilEtudiant_Load(object sender, EventArgs e)
        {
            string nomEtudiant = GetNomEtudiant(idUtilisateur);
            lblNomEtudiantAccueilET.Text = nomEtudiant;
            AfficherEmpruntsEnCours(); // 🔥 Ajoute ça ici



        }



        private void labelSousTitre_Click(object sender, EventArgs e)
        {

        }

        private void labelBonjourNom_Click(object sender, EventArgs e)
        {

        }

        private void lblNomEtudiantAccueilET_Click(object sender, EventArgs e)
        {

        }
        private string GetNomEtudiant(int id)
        {
            string nomComplet = "";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT Nom, Prenom FROM Utilisateurs WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nom = reader["Nom"].ToString();
                            string prenom = reader["Prenom"].ToString();
                            nomComplet = prenom + " " + nom;
                        }
                    }
                }
            }

            return nomComplet;
        }

        private void panelEmpruntsEnCours_Paint(object sender, PaintEventArgs e)
        {
            AfficherEmpruntsEnCours();
        }

        private void AfficherEmpruntsEnCours()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"
SELECT TOP 1 L.titre, E.date_retour
            FROM Emprunt E
            JOIN Livre L ON E.id_livre = L.id_livre
            WHERE E.id_utilisateur = @idUser AND E.statut = 'Confirmé' AND E.date_retour IS NULL";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUser", idUtilisateur);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string titre = reader["titre"].ToString();
                            DateTime? dateRetour = reader["date_retour"] != DBNull.Value ? (DateTime?)reader["date_retour"] : null;

                            // Affectation dynamique
                            lblTitreEmprunts.Text = titre;
                            lblDateRetour.Text = dateRetour.HasValue
                                ? "Retour le " + dateRetour.Value.ToShortDateString()
                                : "Retour : Non défini";

                     
                        }
                        else
                        {
                            lblTitreEmprunts.Text = "Aucun emprunt en cours";
                            lblDateRetour.Text = "";
                            pictureBoxEmpET.Image = null;
                        }
                    }
                }
            }
        }


    }
}

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
    public partial class UCFavorisEtudiant : UserControl
    {
        private int idUtilisateur;
        public UCFavorisEtudiant(int idUtilisateur)
        {
            InitializeComponent();
            this.idUtilisateur = idUtilisateur;

        }
        private void UCFavorisEtudiant_Load_1(object sender, EventArgs e)
        {
            ChargerFavoris();
        }

        private void ChargerFavoris()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT L.id_livre, L.titre, L.auteur, L.editeur
            FROM Favoris F
            JOIN Livre L ON F.id_livre = L.id_livre
            WHERE F.id_utilisateur = @userId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", idUtilisateur);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanelfavorie.Controls.Clear();

                        while (reader.Read())
                        {
                            int idLivre = (int)reader["id_livre"];
                            string titre = reader["titre"].ToString();
                            string auteur = reader["auteur"].ToString();
                            string editeur = reader["editeur"].ToString();

                            AjouterCarteLivre(idLivre, titre, auteur, editeur);
                        }
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AjouterCarteLivre(int idLivre, string titre, string auteur, string editeur)
        {
            Panel panel = new Panel
            {
                Width = 200,
                Height = 200,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                BackColor = Color.White,
            };

            Label lblTitre = new Label
            {
                Text = titre,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = false,
                Width = 180
            };

            Label lblAuteur = new Label
            {
                Text = $"Par {auteur}",
                Location = new Point(10, 40),
                AutoSize = false,
                Width = 180
            };

            Label lblEditeur = new Label
            {
                Text = $"Éditeur : {editeur}",
                Location = new Point(10, 60),
                AutoSize = false,
                Width = 180
            };

            // Bouton pour retirer des favoris (optionnel)
            Button btnSupprimer = new Button
            {
                Text = "Supprimer",
                BackColor = Color.DarkRed,
                ForeColor = Color.White,
                Location = new Point(10, 120),
                Width = 80
            };
            btnSupprimer.Click += (s, e) =>
            {
                SupprimerFavori(idLivre);
                ChargerFavoris(); // Recharger la liste
            };

            panel.Controls.Add(lblTitre);
            panel.Controls.Add(lblAuteur);
            panel.Controls.Add(lblEditeur);
            panel.Controls.Add(btnSupprimer);

            flowLayoutPanelfavorie.Controls.Add(panel);
        }
        private void SupprimerFavori(int idLivre)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Favoris WHERE id_utilisateur = @userId AND id_livre = @livreId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", idUtilisateur);
                    cmd.Parameters.AddWithValue("@livreId", idLivre);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Livre retiré des favoris.");
        }

        private void flowLayoutPanelfavorie_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}

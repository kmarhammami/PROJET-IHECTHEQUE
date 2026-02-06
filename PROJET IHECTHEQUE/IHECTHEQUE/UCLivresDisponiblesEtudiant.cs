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
    public partial class UCLivresDisponiblesEtudiant : UserControl
    {

        private int idUtilisateur;
        public UCLivresDisponiblesEtudiant(int idUtilisateur)
        {
            InitializeComponent();
            this.Load += UCLivresDisponiblesEtudiant_Load;

            this.idUtilisateur = idUtilisateur;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void UCLivresDisponiblesEtudiant_Load(object sender, EventArgs e)
        {
            ChargerLivresDisponibles();
        }

        private void panel1PAGE6ET_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ChargerLivresDisponibles()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"
SELECT L.id_livre, L.titre, L.auteur, L.editeur
FROM Livre L
WHERE NOT EXISTS (
    SELECT 1 FROM Emprunt E
    WHERE E.id_livre = L.id_livre AND E.statut = 'Confirmé' AND E.date_retour IS NULL
)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
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
        private void AjouterAuxFavoris(int idLivre, int idUtilisateur)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                // Vérifie si le livre est déjà dans les favoris
                string checkQuery = "SELECT COUNT(*) FROM Favoris WHERE id_utilisateur = @userId AND id_livre = @livreId";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@userId", idUtilisateur);
                    checkCmd.Parameters.AddWithValue("@livreId", idLivre);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Ce livre est déjà dans vos favoris.");
                        return;
                    }
                }

                // Ajout du favori
                string query = "INSERT INTO Favoris (id_utilisateur, id_livre) VALUES (@userId, @livreId)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", idUtilisateur);
                    cmd.Parameters.AddWithValue("@livreId", idLivre);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Livre ajouté aux favoris !");
            }
        }

        private void AjouterCarteLivre(int idLivre, string titre, string auteur, string editeur)
        {
            Panel panelLivre = new Panel
            {
                Width = 200,
                Height = 220,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                BackColor = Color.White,
            };

            Label lblTitre = new Label
            {
                Text = titre,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = false,
                Width = 180,
                Location = new Point(10, 10)
            };

            Label lblAuteur = new Label
            {
                Text = $"Par {auteur}",
                AutoSize = false,
                Width = 180,
                Location = new Point(10, 40)
            };

            Label lblEditeur = new Label
            {
                Text = $"Éditeur : {editeur}",
                AutoSize = false,
                Width = 180,
                Location = new Point(10, 60)
            };

            // Boutons
            Button btnEmprunter = new Button
            {
                Text = "Emprunter",
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                Location = new Point(10, 150),
                Width = 80
            };

            Button btnFavoris = new Button
            {
                Text = "Ajouter au favoris",
                BackColor = Color.DarkRed,
                ForeColor = Color.White,
                Location = new Point(100, 150),
                Width = 100
            };

            // Ajout au panel
            panelLivre.Controls.Add(lblTitre);
            panelLivre.Controls.Add(lblAuteur);
            panelLivre.Controls.Add(lblEditeur);
            panelLivre.Controls.Add(btnEmprunter);
            panelLivre.Controls.Add(btnFavoris);
            btnEmprunter.Click += (s, e) =>
            {
                DemanderEmprunt(idLivre, idUtilisateur);
            };
            btnFavoris.Click += (s, e) =>
{
    AjouterAuxFavoris(idLivre, idUtilisateur);
};


            // Ajouter au panel parent (ex: FlowLayoutPanel)
            flowLayoutPanelLivres.Controls.Add(panelLivre);
        }
        private void DemanderEmprunt(int idLivre, int idUtilisateur)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Emprunt (id_utilisateur, id_livre, statut) VALUES (@userId, @livreId, 'En attente')";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", idUtilisateur);
                    cmd.Parameters.AddWithValue("@livreId", idLivre);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Demande d'emprunt envoyée !");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelLivres_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

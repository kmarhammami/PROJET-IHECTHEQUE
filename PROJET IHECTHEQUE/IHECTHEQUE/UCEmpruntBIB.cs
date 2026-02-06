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
    public partial class UCEmpruntBIB : UserControl
    {
        public UCEmpruntBIB()
        {
            InitializeComponent();
            this.Load += UCEmpruntBIB_Load;

        }

        private void UCEmpruntBIB_Load(object sender, EventArgs e)
        {
            ChargerDemandesEmprunt(); // charge les demandes

        }

        private void ChargerDemandesEmprunt()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"SELECT E.id, U.Nom + ' ' + U.Prenom AS NomUtilisateur, L.titre, L.auteur
                         FROM Emprunt E
                         JOIN Utilisateurs U ON E.id_utilisateur = U.id
                         JOIN Livre L ON E.id_livre = L.id_livre
                         WHERE E.statut = 'En attente'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())

                {
                    flowDemandes.Controls.Clear(); // vide les anciennes demandes

                    while (reader.Read())
                    {
                        int idEmprunt = (int)reader["id"];
                        string utilisateur = reader["NomUtilisateur"].ToString();
                        string titre = reader["titre"].ToString();
                        string auteur = reader["auteur"].ToString();

                        AfficherDemande(idEmprunt, utilisateur, titre, auteur);
                    }
                }
            }
        }
        private void AfficherDemande(int id, string utilisateur, string titre, string auteur)
        {
            Panel panelDemande = new Panel
            {
                Width = flowDemandes.Width - 30,
                Height = 80,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                Padding = new Padding(10)
            };

            // Nom de l'utilisateur
            Label lblNom = new Label
            {
                Text = utilisateur,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 37, 41),
                Location = new Point(10, 10),
                AutoSize = true
            };

            // Titre du livre
            Label lblTitre = new Label
            {
                Text = $"📘 {titre}",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Location = new Point(10, 35),
                AutoSize = true
            };

            // Auteur
            Label lblAuteur = new Label
            {
                Text = $"✍ {auteur}",
                Font = new Font("Segoe UI", 8, FontStyle.Italic),
                ForeColor = Color.Gray,
                Location = new Point(10, 55),
                AutoSize = true
            };

            // Bouton confirmer
            Button btnConfirmer = new Button
            {
                Text = "✔ Confirmer",
                BackColor = Color.FromArgb(25, 135, 84),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9),
                Location = new Point(panelDemande.Width - 190, 20),
                Width = 80,
                Height = 30,
                FlatStyle = FlatStyle.Flat
            };
            btnConfirmer.Click += (s, e) => ConfirmerDemande(id);

            // Bouton refuser
            Button btnRefuser = new Button
            {
                Text = "✖ Annuler",
                BackColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9),
                Location = new Point(panelDemande.Width - 100, 20),
                Width = 80,
                Height = 30,
                FlatStyle = FlatStyle.Flat
            };
            btnRefuser.Click += (s, e) => RefuserDemande(id);

            // Empêche les boutons d’avoir des bordures moches
            btnConfirmer.FlatAppearance.BorderSize = 0;
            btnRefuser.FlatAppearance.BorderSize = 0;

            // Ajout au panel
            panelDemande.Controls.Add(lblNom);
            panelDemande.Controls.Add(lblTitre);
            panelDemande.Controls.Add(lblAuteur);
            panelDemande.Controls.Add(btnConfirmer);
            panelDemande.Controls.Add(btnRefuser);

            // Ajout au FlowLayoutPanel
            flowDemandes.Controls.Add(panelDemande);
        }

        private void ConfirmerDemande(int idEmprunt)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Emprunt SET statut = @statut, date_emprunt = @dateEmp WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@statut", "Confirmé");
                    cmd.Parameters.AddWithValue("@dateEmp", DateTime.Now); // Date de confirmation
                    cmd.Parameters.AddWithValue("@id", idEmprunt);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Demande confirmée !");
            ChargerDemandesEmprunt(); // recharge la liste
        }


        private void RefuserDemande(int idEmprunt)
        {
            MettreAJourStatut(idEmprunt, "Refusé");
        }

        private void MettreAJourStatut(int id, string statut)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query;

                if (statut == "Confirmé")
                {
                    query = "UPDATE Emprunt SET statut = @statut, date_emprunt = @date WHERE id = @id";
                }
                else
                {
                    query = "UPDATE Emprunt SET statut = @statut WHERE id = @id";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@statut", statut);
                    cmd.Parameters.AddWithValue("@id", id);

                    if (statut == "Confirmé")
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Statut mis à jour !");
            ChargerDemandesEmprunt();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            Text = "Interface des demandes d'emprunt";


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowDemandes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class UCutilisateursADMIN : UserControl
    {
        public UCutilisateursADMIN()
        {
            InitializeComponent();
        }

        private void btnAjouterUtiliAD_Click(object sender, EventArgs e)
        {
            // 1. Créer une instance du UserControl d'ajout utilisateur
            UCAjoutUtilisateurADMIN ajoutUtilisateurUC = new UCAjoutUtilisateurADMIN();

            // 2. Trouver le Form parent
            Form parentForm = this.FindForm();

            // 3. Vérifier et caster
            if (parentForm != null && parentForm is FormEspaceAdmin)
            {
                FormEspaceAdmin formAdmin = (FormEspaceAdmin)parentForm;

                // 4. Charger le UserControl d'ajout dans le panelContainerAD
                formAdmin.ChargerUserControl(ajoutUtilisateurUC);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UCutilisateursADMIN_Load(object sender, EventArgs e)
        {
            panelUtilisateurs.Controls.Clear(); // Nettoyer l'affichage précédent

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, Nom, Prenom, Email FROM Utilisateurs WHERE Role = 'Etudiant'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["id"];
                        string nom = reader["Nom"].ToString();
                        string prenom = reader["Prenom"].ToString();
                        string email = reader["Email"].ToString();

                        // Créer une "carte"
                        Panel card = new Panel
                        {
                            Width = 300,
                            Height = 180,
                            BorderStyle = BorderStyle.FixedSingle,
                            Margin = new Padding(10)
                        };

                        Label lblNom = new Label
                        {
                            Text = "Nom : " + nom + " " + prenom,
                            Location = new Point(10, 10),
                            AutoSize = true
                        };

                        Label lblEmail = new Label
                        {
                            Text = "Email : " + email,
                            Location = new Point(10, 30),
                            AutoSize = true
                        };

                        Label lblStatut = new Label
                        {
                            Text = "● Actif",
                            Location = new Point(10, 50),
                            ForeColor = Color.Green,
                            Font = new Font("Segoe UI", 9, FontStyle.Bold),
                            AutoSize = true
                        };

                        Button btnSupprimer = new Button
                        {
                            Text = "Supprimer",
                            Location = new Point(10, 80),
                            Width = 100
                        };
                        // Bouton sans action pour l’instant

                        Button btnEmprunts = new Button
                        {
                            Text = "Emprunts",
                            Location = new Point(120, 80),
                            Width = 100,
                            Tag = id // on stocke l’ID pour l’utiliser dans l’événement
                        };
                        btnEmprunts.Click += BtnEmprunts_Click;

                        // Ajouter les contrôles à la carte
                        card.Controls.Add(lblNom);
                        card.Controls.Add(lblEmail);
                        card.Controls.Add(lblStatut);
                        card.Controls.Add(btnSupprimer);
                        card.Controls.Add(btnEmprunts);

                        panelUtilisateurs.Controls.Add(card); // ajouter la carte au panel
                    }
                }
            }
            AfficherUtilisateurs(); // Affiche tous les étudiants par défaut

        }
        private void BtnEmprunts_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idUtilisateur = (int)btn.Tag;

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT id_livre, date_emprunt FROM Emprunts WHERE id_utilisateur = @id AND statut = 'en cours'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idUtilisateur);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        StringBuilder sb = new StringBuilder("📚 Emprunts en cours :\n\n");
                        while (reader.Read())
                        {
                            string idLivre = reader["id_livre"].ToString();
                            string date = Convert.ToDateTime(reader["date_emprunt"]).ToShortDateString();
                            sb.AppendLine($"- Livre ID : {idLivre} | Date : {date}");
                        }

                        if (sb.ToString().Trim() == "📚 Emprunts en cours :")
                            sb.AppendLine("Aucun emprunt en cours.");

                        MessageBox.Show(sb.ToString(), "Emprunts de l'étudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panelUtilisateurs_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AfficherUtilisateurs(string filtre = "")
        {
            panelUtilisateurs.Controls.Clear(); // Vider le panel

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, Nom, Prenom, Email FROM Utilisateurs WHERE Role = 'Etudiant'";

                if (!string.IsNullOrWhiteSpace(filtre))
                {
                    query += " AND (Nom LIKE @filtre OR Prenom LIKE @filtre)";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrWhiteSpace(filtre))
                    {
                        cmd.Parameters.AddWithValue("@filtre", "%" + filtre + "%");
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["id"];
                            string nom = reader["Nom"].ToString();
                            string prenom = reader["Prenom"].ToString();
                            string email = reader["Email"].ToString();

                            // Créer la carte utilisateur
                            Panel card = new Panel
                            {
                                Width = 300,
                                Height = 180,
                                BorderStyle = BorderStyle.FixedSingle,
                                Margin = new Padding(10),
                                BackColor = Color.White,
                            };

                            Label lblNom = new Label
                            {
                                Text = "Nom : " + nom + " " + prenom,
                                Location = new Point(10, 10),
                                AutoSize = true
                            };

                            Label lblEmail = new Label
                            {
                                Text = "Email : " + email,
                                Location = new Point(10, 30),
                                AutoSize = true
                            };

                            Label lblStatut = new Label
                            {
                                Text = "● Actif",
                                Location = new Point(10, 50),
                                ForeColor = Color.Green,
                                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                                AutoSize = true
                            };

                            Button btnSupprimer = new Button
                            {
                                Text = "Supprimer",
                                Location = new Point(10, 80),
                                Width = 100
                            };

                            Button btnEmprunts = new Button
                            {
                                Text = "Emprunts",
                                Location = new Point(120, 80),
                                Width = 100,
                                Tag = id
                            };
                            btnEmprunts.Click += BtnEmprunts_Click;

                            card.Controls.Add(lblNom);
                            card.Controls.Add(lblEmail);
                            card.Controls.Add(lblStatut);
                            card.Controls.Add(btnSupprimer);
                            card.Controls.Add(btnEmprunts);

                            panelUtilisateurs.Controls.Add(card);
                        }
                    }
                }
            }
        }

        private void textBoxRechercheUtiliPAGE4AD_TextChanged(object sender, EventArgs e)
        {
            string texteRecherche = textBoxRechercheUtiliPAGE4AD.Text.Trim();
            AfficherUtilisateurs(texteRecherche);
        }
    }
}

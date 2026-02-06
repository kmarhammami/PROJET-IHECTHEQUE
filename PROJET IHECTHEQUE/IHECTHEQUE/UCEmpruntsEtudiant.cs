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
    public partial class UCEmpruntsEtudiant : UserControl
    {
        private int idUtilisateur;
        public UCEmpruntsEtudiant(int idUtilisateur)
        {
            InitializeComponent();
            this.idUtilisateur = idUtilisateur;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCEmpruntsEtudiant_Load(object sender, EventArgs e)
        {
            ChargerMesEmprunts();
        }
        private void ChargerMesEmprunts()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"SELECT E.id_livre, L.titre, L.auteur, E.date_emprunt, E.date_retour
                 FROM Emprunt E
                 JOIN Livre L ON E.id_livre = L.id_livre
                 WHERE E.id_utilisateur = @idUtilisateur AND E.statut = 'Confirmé'";
                ;

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUtilisateur", this.idUtilisateur);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanelEmprunts.Controls.Clear(); // vide l'ancien affichage

                        while (reader.Read())
                        {
                            int idLivre = (int)reader["id_livre"];

                            string titre = reader["titre"].ToString();
                            string auteur = reader["auteur"].ToString();

                            DateTime? dateEmp = reader["date_emprunt"] != DBNull.Value ? (DateTime?)reader["date_emprunt"] : null;
                            DateTime? dateRetour = reader["date_retour"] != DBNull.Value ? (DateTime?)reader["date_retour"] : null;

                            AfficherEmprunt(idLivre,titre, auteur, dateEmp, dateRetour);

                        }
                    }
                }
            }
        }
        private void AfficherEmprunt(int idLivre, string titre, string auteur, DateTime? dateEmp, DateTime? dateRetour)
        {
            Panel panel = new Panel
            {
                Width = 750,
                Height = 100,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5),
                BackColor = Color.White
            };

            Label lblTitre = new Label
            {
                Text = titre,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(100, 10),
                AutoSize = true
            };

            Label lblAuteur = new Label
            {
                Text = "Auteur : " + auteur,
                Location = new Point(100, 35),
                AutoSize = true
            };

            Label lblDateEmp = new Label
            {
                Text = "Emprunté le : " + (dateEmp.HasValue ? dateEmp.Value.ToShortDateString() : "Non défini"),
                Location = new Point(100, 55),
                AutoSize = true
            };

            Label lblRetour = new Label
            {
                Text = "À retourner le : " + (dateRetour.HasValue ? dateRetour.Value.ToShortDateString() : "Non défini"),
                ForeColor = Color.Red,
                Location = new Point(250, 55),
                AutoSize = true
            };

            Button btnRetourner = new Button
            {
                Text = "Retourner",
                BackColor = Color.Red,
                ForeColor = Color.White,
                Width = 90,
                Location = new Point(650, 35)
            };
            btnRetourner.Click += (s, e) =>
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Emprunt SET date_retour = @dateRetour WHERE id_utilisateur = @userId AND id_livre = @livreId AND statut = 'Confirmé' AND date_retour IS NULL";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", idUtilisateur);
                        cmd.Parameters.AddWithValue("@livreId", idLivre);
                        cmd.Parameters.AddWithValue("@dateRetour", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Livre retourné !");
                ChargerMesEmprunts(); // recharge la liste des emprunts
            };

            panel.Controls.Add(lblTitre);
            panel.Controls.Add(lblAuteur);
            panel.Controls.Add(lblDateEmp);
            panel.Controls.Add(lblRetour);
            panel.Controls.Add(btnRetourner);

            flowLayoutPanelEmprunts.Controls.Add(panel);
        }


        private void flowLayoutPanelEmprunts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

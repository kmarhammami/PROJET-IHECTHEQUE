using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace IHECTHEQUE
{
    public partial class UCAjoutUtilisateurADMIN : UserControl
    {
        public UCAjoutUtilisateurADMIN()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregitrerUtiAD_Click(object sender, EventArgs e)
        {
            // 🔵 Récupérer les valeurs des TextBox avec tes vrais noms
            string nom = textBoxNOMUtilisateurAD.Text.Trim();
            string prenom = textBoxPRENOMUtilisateurAD.Text.Trim();
            string email = textBoxEMAILUtilisateurAD.Text.Trim();
            string role = textBoxROLEUtilisateurAD.Text.Trim();

            // 🔵 Vérification 1 : Champs vides
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("❌ Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 🔵 Vérification 2 : Format de l'email
            if (!email.EndsWith("@ihec.ucar.tn"))
            {
                MessageBox.Show("❌ L'email doit se terminer par '@ihec.ucar.tn'.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 🔵 Connexion à la base
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    // 🔵 Requête SQL pour insérer les données
                    string query = "INSERT INTO Utilisateurs (Nom, Prenom, Email, Role, MotDePasse) " +
                                   "VALUES (@Nom, @Prenom, @Email, @Role, @MotDePasse)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nom);
                        cmd.Parameters.AddWithValue("@Prenom", prenom);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Role", role);

                        // Générer automatiquement un mot de passe (ex: prenom123)
                        string motDePasse = prenom.ToLower() + "123";
                        cmd.Parameters.AddWithValue("@MotDePasse", motDePasse);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("✅ Utilisateur ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 🔵 Réinitialiser les champs après insertion
                textBoxNOMUtilisateurAD.Clear();
                textBoxPRENOMUtilisateurAD.Clear();
                textBoxEMAILUtilisateurAD.Clear();
                textBoxROLEUtilisateurAD.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Erreur lors de l'ajout : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

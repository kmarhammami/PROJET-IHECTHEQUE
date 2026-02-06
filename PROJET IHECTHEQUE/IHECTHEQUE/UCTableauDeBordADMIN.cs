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
    public partial class UCTableauDeBordADMIN : UserControl
    {
        private int idAdmin;

        public UCTableauDeBordADMIN(int idAdmin)
        {
            InitializeComponent();
            this.idAdmin = idAdmin;
            AfficherNomAdmin(); // Appelle la méthode juste après l'initialisation
            AfficherTotalLivres(); // <-- ici
            AfficherTotalEmprunts(); // <-- Ajoute cette ligne ici
            AfficherTotalUtilisateurs(); // Ajoute cette ligne ici




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAjoutLIVAD_Click(object sender, EventArgs e)
        {
            UCLivresADMIN ajoutLivreUC = new UCLivresADMIN();
            Form parentForm = this.FindForm();

            if (parentForm is FormEspaceAdmin formAdmin)
            {
                formAdmin.ChargerUserControl(ajoutLivreUC);
            }
        }

        private void btnNouvelUTAD_Click(object sender, EventArgs e)
        {
            UCAjoutUtilisateurADMIN ajoutUtilisateurUC = new UCAjoutUtilisateurADMIN();
            Form parentForm = this.FindForm();

            if (parentForm is FormEspaceAdmin formAdmin)
            {
                formAdmin.ChargerUserControl(ajoutUtilisateurUC);
            }
        }

        private void btnNouvEVENTAD_Click(object sender, EventArgs e)
        {
            UCEVENTADMIN evenementUC = new UCEVENTADMIN();
            Form parentForm = this.FindForm();

            if (parentForm is FormEspaceAdmin formAdmin)
            {
                formAdmin.ChargerUserControl(evenementUC);
            }
        }

        private void btnParamAD_Click(object sender, EventArgs e)
        {
            UCParamétresADMIN parametresUC = new UCParamétresADMIN();
            Form parentForm = this.FindForm();

            if (parentForm is FormEspaceAdmin formAdmin)
            {
                formAdmin.ChargerUserControl(parametresUC);
            }
        }

        private void panelEventAD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label9.Text, "Nom Admin");

        }
        private void AfficherNomAdmin()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT Nom, Prenom FROM Utilisateurs WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idAdmin);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nom = reader["Nom"].ToString();
                            string prenom = reader["Prenom"].ToString();
                            label9.Text = $"Bonjour {prenom} {nom} !";
                        }
                        else
                        {
                            label9.Text = "Bonjour Administrateur !";
                        }
                    }
                }
            }
        }
        private void AfficherTotalLivres()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Livre";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int totalLivres = (int)cmd.ExecuteScalar(); // récupère le nombre total
                    lblTotlivresAD.Text = totalLivres.ToString(); // affiche dans le label
                }
            }
        }
        private void AfficherTotalEmprunts()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Emprunts"; // table correcte
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int totalEmprunts = (int)cmd.ExecuteScalar();
                    lblEMPAD.Text = totalEmprunts.ToString(); // affiche le nombre dans le label
                }
            }
        }

        private void lblTotlivresAD_Click(object sender, EventArgs e)
        {
            AfficherTotalLivres(); // Appelle la méthode quand on clique sur le label

        }

        private void lblEMPAD_Click(object sender, EventArgs e)
        {
            AfficherTotalEmprunts(); // recharge sur clic

        }
        private void AfficherTotalUtilisateurs()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Utilisateurs WHERE Role = 'Etudiant'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int totalUtilisateurs = (int)cmd.ExecuteScalar();
                    lblUTIAD.Text = totalUtilisateurs.ToString(); // met à jour le label
                }
            }
        }

        private void lblUTIAD_Click(object sender, EventArgs e)
        {
            AfficherTotalUtilisateurs(); // Recharge manuellement

        }
    }
}

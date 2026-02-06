using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IHECTHEQUE;
namespace IHECTHEQUE
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            this.Visible = false;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = true;

            // Affiche après tout
            this.Shown += (s, e) => { this.Visible = true; };
        }
        //On va faire disparaître le texte dès que l'utilisateur clique

        protected override void OnHandleCreated(EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            base.OnHandleCreated(e);
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Adresse email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }
        //On va faire disparaître le texte dès que l'utilisateur clique
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Adresse email";
                txtEmail.ForeColor = Color.Gray;
            }
        }
        //Pour txtPassword diparait
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mot de passe")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = Color.Black;
            }
        }
        //Pour txtPassword disparait
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Mot de passe";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void btnLoginConnexion_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string email = txtEmail.Text.Trim();
                    string mdp = txtPassword.Text.Trim();

                    string query = "SELECT * FROM Utilisateurs WHERE Email = @email AND MotDePasse = @mdp";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@mdp", mdp);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read()) // utilisateur trouvé
                    {
                        string role = dr["Role"].ToString().Trim().ToLower();
                        int idUtilisateur = Convert.ToInt32(dr["Id"]);

                        this.Hide();

                        if (role == "etudiant")
                        {
                            FormEspaceEtudiant espace = new FormEspaceEtudiant(idUtilisateur);
                            espace.Show();
                        }

                        else if (role == "bibliomanager")
                        {
                            FormEspaceBiblio espace = new FormEspaceBiblio(idUtilisateur);
                            espace.ShowDialog();
                        }
                        else if (role == "admin")
                        {
                            FormEspaceAdmin espace = new FormEspaceAdmin(idUtilisateur); // <-- tu as déjà cette variable
                            espace.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("❌ Rôle inconnu.");
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("❌ Identifiants incorrects. Veuillez réessayer.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("⚠️ Erreur de connexion : " + ex.Message);
                }
            }
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCréerCompte_Click(object sender, EventArgs e)
        {
            FormSignup signup = new FormSignup();
            signup.Show();
            this.Hide(); // cache la page login si tu veux
        }

        private void lblOublie_Click(object sender, EventArgs e)
        {
            FormSignup signup = new FormSignup();
            signup.Show();
            this.Hide(); // si tu veux cacher le formulaire actuel
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbEye_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // Chargement des infos si elles existent
            txtEmail.Text = Properties.Settings.Default.Email;
            txtPassword.Text = Properties.Settings.Default.Password;
            chkSouvenir.Checked = Properties.Settings.Default.SeSouvenir;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
 }



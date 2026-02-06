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
    public partial class UCParamétresADMIN : UserControl
    {
        private int idAdmin;


        public UCParamétresADMIN()
        {
            InitializeComponent();
        }
        public void SetAdminId(int id)
        {
            idAdmin = id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfUtilBIB_Click(object sender, EventArgs e)
        {

        }

        private void btnModifCompAD_Click(object sender, EventArgs e)
        {
            panelChangeMdp.Visible = !panelChangeMdp.Visible;
            panelChangeMdp.BringToFront(); // 🧲 Met le panel devant tous les autres



        }
        private TextBox txtAncien;
        private TextBox txtNouveau;
        private Button btnValider;
        private Panel panelChangeMdp;
        private void UCParamétresADMIN_Load(object sender, EventArgs e)
        {
            panelChangeMdp = new Panel
            {
                Width = 300,
                Height = 150,
                BackColor = Color.WhiteSmoke,
                Location = new Point(30, 150),
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };

            Label lbl1 = new Label { Text = "Ancien mot de passe", Location = new Point(10, 10), AutoSize = true };
            txtAncien = new TextBox { Width = 200, Location = new Point(10, 30), PasswordChar = '*' };

            Label lbl2 = new Label { Text = "Nouveau mot de passe", Location = new Point(10, 60), AutoSize = true };
            txtNouveau = new TextBox { Width = 200, Location = new Point(10, 80), PasswordChar = '*' };

            btnValider = new Button { Text = "Valider", Location = new Point(10, 110), Width = 100 };
            btnValider.Click += BtnValider_Click;

            panelChangeMdp.Controls.Add(lbl1);
            panelChangeMdp.Controls.Add(txtAncien);
            panelChangeMdp.Controls.Add(lbl2);
            panelChangeMdp.Controls.Add(txtNouveau);
            panelChangeMdp.Controls.Add(btnValider);

            this.Controls.Add(panelChangeMdp);
        }
        private void BtnValider_Click(object sender, EventArgs e)
        {
            string ancien = txtAncien.Text.Trim();
            string nouveau = txtNouveau.Text.Trim();

            if (ancien == "" || nouveau == "")
            {
                MessageBox.Show("Remplissez les deux champs.");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string check = "SELECT COUNT(*) FROM Utilisateurs WHERE id = @id AND MotDePasse = @mdp";
                using (SqlCommand cmd = new SqlCommand(check, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idAdmin);
                    cmd.Parameters.AddWithValue("@mdp", ancien);

                    int count = (int)cmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Ancien mot de passe incorrect.");
                        return;
                    }
                }

                string update = "UPDATE Utilisateurs SET MotDePasse = @newMdp WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(update, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idAdmin);
                    cmd.Parameters.AddWithValue("@newMdp", nouveau);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Mot de passe mis à jour.");
                    panelChangeMdp.Visible = false;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnModifUtiliAD_Click(object sender, EventArgs e)
        {
            // Trouver la Form parent (celle qui contient les UserControls)
            Form parentForm = this.FindForm();

            // Vérifier si c’est bien FormEspaceAdmin
            if (parentForm is FormEspaceAdmin formAdmin)
            {
                // Créer une instance du UserControl cible
                UCutilisateursADMIN ucUtilisateurs = new UCutilisateursADMIN();

                // Appeler la méthode de chargement de UserControl
                formAdmin.ChargerUserControl(ucUtilisateurs);
            }
        }
    }
}

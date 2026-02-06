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
    public partial class UCTableauDeBoardBIB : UserControl
    {
        private int idBibliothecaire;
        public UCTableauDeBoardBIB(int id)
        {
            InitializeComponent();
            idBibliothecaire = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelSousTitre_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UCTableauDeBoardBIB_Load(object sender, EventArgs e)
        {
            AfficherTotalEmprunts();
            AfficherTotalFavoris();
            AfficherListeEmprunts();

        }

        private void panelAjoutLivreBIB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnReserBIB_Click(object sender, EventArgs e)
        {
            UCEmpruntBIB uc = new UCEmpruntBIB();
            panelContainerBIB.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainerBIB.Controls.Add(uc);
            Form parentForm = this.FindForm(); // récupère le Form parent
            if (parentForm is FormEspaceBiblio form)
            {
                form.AfficherUC(new UCEmpruntBIB());
            }
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblNomEtudiant_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelBonjourNom_Click(object sender, EventArgs e)
        {

        }

        private void btnAjoutLivreBIB_Click(object sender, EventArgs e)
        {
            // 1. Créer une instance du UC_AjoutLivreBIB
            UCAjoutLivreBIB ajoutLivreUC = new UCAjoutLivreBIB(); // sans rien passer

            // 2. Trouver la Form parent (FormEspaceBiblio)
            Form parentForm = this.FindForm();

            if (parentForm != null && parentForm is FormEspaceBiblio)
            {
                FormEspaceBiblio formBiblio = (FormEspaceBiblio)parentForm;

                // 3. Utiliser la fonction ChargerUserControl pour afficher ton UC d'ajout
                formBiblio.ChargerUserControl(ajoutLivreUC);
            }
        }

        private void panelContainerBIB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nbr_emprunt_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTotalEmprunts_Click(object sender, EventArgs e)
        {

        }
        private void AfficherTotalEmprunts()
        {
            int total = 0;

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Emprunts";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    total = (int)cmd.ExecuteScalar();
                }
            }

            labelTotalEmprunts.Text = " " + total.ToString();
            labelTotalEmprunts.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            labelTotalEmprunts.ForeColor = Color.Navy;
            labelTotalEmprunts.Location = new Point(20, 20);
        }

        private void nbr_favori_Click(object sender, EventArgs e)
        {
            AfficherTotalFavoris();
        }
        private void AfficherTotalFavoris()
        {
            int total = 0;

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Favoris";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    total = (int)cmd.ExecuteScalar();
                }
            }

            nbr_favori.Text = " " + total.ToString();
            nbr_favori.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            nbr_favori.ForeColor = Color.MediumVioletRed;

        }
        private void AfficherListeEmprunts()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"
        SELECT 
            U.Nom,
            U.Prenom,
            U.Email,
            L.titre AS Livre,
            E.date_emprunt,
            ISNULL(CONVERT(varchar, E.date_retour, 23), 'Pas encore') AS date_retour
        FROM Emprunts E
        INNER JOIN Utilisateurs U ON E.id_utilisateur = U.id
        INNER JOIN Livre L ON E.id_livre = L.id_livre
        ORDER BY E.date_emprunt DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvEmpruntsRecents.DataSource = table;
                // Mise en forme améliorée
                dgvEmpruntsRecents.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvEmpruntsRecents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvEmpruntsRecents.AutoResizeColumns();
                dgvEmpruntsRecents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void liste_emprunt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEmpruntsRecents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

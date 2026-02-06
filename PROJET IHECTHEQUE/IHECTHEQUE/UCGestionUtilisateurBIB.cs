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
    public partial class UCGestionUtilisateurBIB : UserControl
    {
        private int idBibliothecaire;
        public UCGestionUtilisateurBIB(int id)
        {
            InitializeComponent();
            idBibliothecaire = id;
        }

        private void UCGestionAdhérents_Load(object sender, EventArgs e)
        {
            ChargerUtilisateurs();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void ChargerUtilisateurs()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"SELECT Nom, Prenom, Email FROM Utilisateurs";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                data_utilisateurs.DataSource = dt;
                data_utilisateurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }


        private void data_utilisateurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

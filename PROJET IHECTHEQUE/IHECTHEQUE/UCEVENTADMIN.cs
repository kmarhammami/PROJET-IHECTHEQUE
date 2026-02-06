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
    public partial class UCEVENTADMIN : UserControl
    {
        private int idAdmin;

        public UCEVENTADMIN()
        {
            InitializeComponent();
            this.idAdmin = idAdmin;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void labelBonjourNom_Click(object sender, EventArgs e)
        {

        }
        private void UCEVENTADMIN_Load(object sender, EventArgs e)
        {
            string nomAdmin = GetNomAdmin(idAdmin);
            label_name_admin.Text = nomAdmin;
        }

        private void label_name_admin_Click(object sender, EventArgs e)
        {

        }
        private string GetNomAdmin(int id)
        {
            string nomComplet = "";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT Nom, Prenom FROM Utilisateurs WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nom = reader["Nom"].ToString();
                            string prenom = reader["Prenom"].ToString();
                            nomComplet = prenom + " " + nom;
                        }
                    }
                }
            }

            return nomComplet;
        }

    }
}

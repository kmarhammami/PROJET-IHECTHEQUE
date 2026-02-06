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
using System.IO;
namespace IHECTHEQUE
{
    public partial class UCLivresADMIN : UserControl
    {
        public UCLivresADMIN()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UCLivresADMIN_Load(object sender, EventArgs e)
        {
            panelLivresAdmin.Controls.Clear(); // vide les anciens livres

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT titre, auteur, cote FROM Livre"; // ❌ on enlève 'image'

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string titre = reader["titre"].ToString();
                        string auteur = reader["auteur"].ToString();
                        string genre = reader["cote"].ToString();

                        // ✅ Image fixe par défaut (ajoutée dans Resources)
                        Image imageLivre = Properties.Resources.defaultBook;

                        // Créer la carte livre
                        Panel card = new Panel
                        {
                            Width = 180,
                            Height = 300,
                            BorderStyle = BorderStyle.FixedSingle,
                            Margin = new Padding(10)
                        };

                        PictureBox pb = new PictureBox
                        {
                            Image = imageLivre,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Width = 160,
                            Height = 180,
                            Location = new Point(10, 10)
                        };

                        Label lblGenre = new Label
                        {
                            Text = genre,
                            Font = new Font("Segoe UI", 9, FontStyle.Italic),
                            ForeColor = Color.Gray,
                            Location = new Point(10, 195),
                            AutoSize = true
                        };

                        Label lblTitre = new Label
                        {
                            Text = titre,
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            Location = new Point(10, 215),
                            AutoSize = true
                        };

                        Label lblAuteur = new Label
                        {
                            Text = "Par " + auteur,
                            Font = new Font("Segoe UI", 9),
                            Location = new Point(10, 235),
                            AutoSize = true
                        };

                        // Ajouter les éléments à la carte
                        card.Controls.Add(pb);
                        card.Controls.Add(lblGenre);
                        card.Controls.Add(lblTitre);
                        card.Controls.Add(lblAuteur);

                        // Ajouter la carte au FlowLayoutPanel
                        panelLivresAdmin.Controls.Add(card);
                    }
                }
            }
        }


        private void panelLivresAdmin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

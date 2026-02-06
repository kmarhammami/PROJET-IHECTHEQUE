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
    public partial class UCGestionLivreBIB : UserControl
    {
        private int idBibliothecaire;
        public UCGestionLivreBIB(int id)
        {
            InitializeComponent();
            idBibliothecaire = id;
        }
        private void UCGestionLivreBIB_Load(object sender, EventArgs e)
        {
            ChargerLivresDisponibles();
        }
        private void btnAjouterLivreBIB_Click(object sender, EventArgs e)
        {

            // Créer une nouvelle instance du UserControl pour l'ajout
            UCAjoutLivreBIB ajoutLivreUC = new UCAjoutLivreBIB();

            // Trouver la Form parente (FormEspaceBiblio)
            Form parentForm = this.FindForm();
            if (parentForm != null && parentForm is FormEspaceBiblio formBiblio)
            {
                // Charger le nouveau UserControl dans le panel
                formBiblio.ChargerUserControl(ajoutLivreUC);
            }
        }
        private void ChargerLivresDisponibles()
        {
            liste_livres.Controls.Clear(); // Nettoyer avant d’ajouter

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT L.id_livre, L.titre, L.auteur, L.editeur, L.nb_pages
            FROM Livre L
            LEFT JOIN Emprunts E ON L.id_livre = E.id_livre AND E.date_retour_effective IS NULL
            WHERE E.id_livre IS NULL";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string titre = reader.IsDBNull(1) ? "Non spécifié" : reader.GetString(1);
                    string auteur = reader.IsDBNull(2) ? "Non spécifié" : reader.GetString(2);
                    string editeur = reader.IsDBNull(3) ? "Non spécifié" : reader.GetString(3);
                    string nb_pages = reader.IsDBNull(4) ? "?" : reader.GetString(4);

                    // Création du panneau représentant un livre
                    Panel panelLivre = new Panel
                    {
                        Width = 350,
                        Height = 160,
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10)
                    };

                    // Éléments de la carte
                    Label lblTitre = new Label { Text = "📖 " + titre, Font = new Font("Segoe UI", 10, FontStyle.Bold), AutoSize = true, Location = new Point(10, 10) };
                    Label lblAuteur = new Label { Text = "Auteur : " + auteur, AutoSize = true, Location = new Point(10, 35) };
                    Label lblEditeur = new Label { Text = "Éditeur : " + editeur, AutoSize = true, Location = new Point(10, 55) };
                    Label lblPages = new Label { Text = "Pages : " + nb_pages, AutoSize = true, Location = new Point(10, 75) };
                    Label lblDispo = new Label { Text = "📗 Disponible", ForeColor = Color.Green, AutoSize = true, Location = new Point(10, 95) };

                    // Bouton de suppression
                    Button btnDelete = new Button
                    {
                        Text = "Supprimer",
                        BackColor = Color.IndianRed,
                        ForeColor = Color.White,
                        Width = 100,
                        Height = 30,
                        Location = new Point(220, 110),
                        Tag = id
                    };

                    // Événement suppression
                    btnDelete.Click += (s, e) =>
                    {
                        DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce livre ?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            SupprimerLivre((int)((Button)s).Tag);
                            ChargerLivresDisponibles(); // Rafraîchissement
                        }
                    };

                    // Ajout des contrôles au panel
                    panelLivre.Controls.Add(lblTitre);
                    panelLivre.Controls.Add(lblAuteur);
                    panelLivre.Controls.Add(lblEditeur);
                    panelLivre.Controls.Add(lblPages);
                    panelLivre.Controls.Add(lblDispo);
                    panelLivre.Controls.Add(btnDelete);

                    // Ajout au flow panel
                    liste_livres.Controls.Add(panelLivre);
                }
            }
        }





        private void SupprimerLivre(int idLivre)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Livre WHERE id_livre = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idLivre);
                cmd.ExecuteNonQuery();
            }
        }

        private void liste_livres_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

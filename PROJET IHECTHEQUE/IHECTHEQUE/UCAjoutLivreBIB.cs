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
    public partial class UCAjoutLivreBIB : UserControl
    {
        private int idBibliothecaire;
        public UCAjoutLivreBIB()
        {
            InitializeComponent();
           
        }

        private void panelAjoutLivBIB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxNBRExpBIB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtboxTItreLivBIB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UCAjoutLivreBIB_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void EnregistrerAjoutLIVBIB_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO Livre (titre, auteur, editeur, date_edition, isbn, prix, cote, nb_pages) " +
                                   "VALUES (@titre, @auteur, @editeur, @date_edition, @isbn, @prix, @cote, @nb_pages)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Vérification que Prix est un nombre
                        if (!decimal.TryParse(txtBoxPrix.Text.Trim(), out decimal prix))
                        {
                            MessageBox.Show("❌ Le prix n'est pas un nombre valide.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // On arrête si prix est invalide
                        }

                        // Maintenant on ajoute tous les paramètres
                        cmd.Parameters.AddWithValue("@titre", txtboxTItreLivBIB.Text.Trim());
                        cmd.Parameters.AddWithValue("@auteur", txtboxAuteurBIB.Text.Trim());
                        cmd.Parameters.AddWithValue("@editeur", txtboxEditeur.Text.Trim());
                        cmd.Parameters.AddWithValue("@date_edition", dateTimePicker2.Value.Date);
                        cmd.Parameters.AddWithValue("@isbn", txtboxISINBIB.Text.Trim());
                        cmd.Parameters.AddWithValue("@prix", prix);
                        cmd.Parameters.AddWithValue("@cote", DBNull.Value); // ou "-" si tu veux une chaîne vide
                        cmd.Parameters.AddWithValue("@nb_pages", DBNull.Value); // ou 0 si tu veux

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("✅ Livre ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Nettoyer les champs après succès
                        txtboxTItreLivBIB.Clear();
                        txtboxAuteurBIB.Clear();
                        txtboxEditeur.Clear();
                        txtboxISINBIB.Clear();
                        txtBoxPrix.Clear();
                        dateTimePicker2.Value = DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace IHECTHEQUE
{
    public partial class FormEspaceBiblio : Form
    {
        private int idUtilisateur;

        public FormEspaceBiblio(int id)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.idUtilisateur = id;
            // Charger automatiquement le tableau de bord au démarrage
            ChargerUserControl(new UCTableauDeBoardBIB(idUtilisateur));
        }
        public void ChargerUserControl(UserControl uc)

        {
            panelContainerBIB.Controls.Clear();  // (panelContainerBIB est ton Panel principal à droite)
            uc.Dock = DockStyle.Fill;
            panelContainerBIB.Controls.Add(uc);
        }

        private void lblET_Click(object sender, EventArgs e)
        {

        }

        private void btnTabBorAD_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCTableauDeBoardBIB(idUtilisateur));
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        public void AfficherUC(UserControl uc)
        {
            panelContainerBIB.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainerBIB.Controls.Add(uc);
        }

        private void FormEspaceBiblio_Load(object sender, EventArgs e)
        {

        }

        private void btnGestionLivBIB_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCGestionLivreBIB(idUtilisateur));
        }

        private void btnGestUtilisateurBIB_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCGestionUtilisateurBIB(idUtilisateur));
        }

        private void btnStatBIB_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCStatBIB(idUtilisateur));
        }

        private void btnNotifMessBIB_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCNotifMessBIB(idUtilisateur));
        }

        private void panelContainerBIB_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
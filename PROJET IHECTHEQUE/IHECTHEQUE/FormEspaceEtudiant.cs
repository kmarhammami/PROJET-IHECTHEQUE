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
using IHECTHEQUE;


namespace IHECTHEQUE
{
    public partial class FormEspaceEtudiant : Form
    {
        private int idUtilisateur;

        public FormEspaceEtudiant(int id)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.idUtilisateur = id;

            // Charger automatiquement l'accueil à l'ouverture
            ChargerUserControl(new UCAccueilEtudiant(idUtilisateur));
        }


        private void ChargerUserControl(UserControl uc)
        {
            panelContainerET.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainerET.Controls.Add(uc);
        }

        private void btnAcceuilET_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCAccueilEtudiant(idUtilisateur));
        }

        private void btnMesEmpruntsET_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCEmpruntsEtudiant(idUtilisateur));
        }

        private void btnFavorisET_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCFavorisEtudiant(idUtilisateur));
        }

        private void btnStatET_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCStatistiquesEtudiant(idUtilisateur));
        }

        private void btnNotifET_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCNotificationsEtudiant(idUtilisateur));
        }

        private void btnLivresDispoET_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCLivresDisponiblesEtudiant(idUtilisateur));
        }

        private void btnLivreDispoET_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCLivresDisponiblesEtudiant(idUtilisateur));

        }

        private void panelContainerET_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

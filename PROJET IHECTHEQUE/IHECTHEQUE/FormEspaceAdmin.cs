using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHECTHEQUE
{
    public partial class FormEspaceAdmin : Form
    {
        private int idAdmin;

        public FormEspaceAdmin(int idAdmin)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.idAdmin = idAdmin;
            ChargerUserControl(new UCTableauDeBordADMIN(idAdmin));
        }

        public void ChargerUserControl(UserControl uc)
        {
            panelContainerAD.Controls.Clear();   // vide l'ancien UserControl
            uc.Dock = DockStyle.Fill;             // prend tout l'espace
            panelContainerAD.Controls.Add(uc);    // ajoute le nouveau UserControl
        }

        private void btnTabBorAD_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCTableauDeBordADMIN(idAdmin));
        }

        private void btnEvénementsAD_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCEVENTADMIN());
        }

        private void btnLivresAD_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCLivresADMIN());

        }

        private void btnUtilisateursAD_Click(object sender, EventArgs e)
        {
            ChargerUserControl(new UCutilisateursADMIN());
        }

        private void btnParamétresAD_Click(object sender, EventArgs e)
        {
            var ucParam = new UCParamétresADMIN();
            ucParam.SetAdminId(idAdmin);  // ✅ transmettre l'id
            ChargerUserControl(ucParam);
        }
        private void lblTitreBibliothequeAD_Click(object sender, EventArgs e)
        {

        }

        private void btnUtilisateursAD_Click_1(object sender, EventArgs e)
        {
            ChargerUserControl(new UCutilisateursADMIN());
        }

        private void btnParamétresAD_Click_1(object sender, EventArgs e)
        {
            var ucParam = new UCParamétresADMIN();
            ucParam.SetAdminId(idAdmin);  // ✅ transmettre l'id
            ChargerUserControl(ucParam);
        }

        private void btnLivresAD_Click_1(object sender, EventArgs e)
        {
            ChargerUserControl(new UCLivresADMIN());
        }
    }
}

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
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent(); // ⚠️ d'abord, c'est essentiel
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {
            // ✅ Ce code ne posera plus de souci avec le Designer
            this.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = true;

            // 💡 Retarde l’affichage pour éviter le clignotement
            this.Shown += (s, ev) => { this.Visible = true; };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            FormSignup signupForm = new FormSignup();
            signupForm.Show();
            this.Hide();
        }
    }
}

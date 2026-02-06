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
    public partial class FormSignup : Form
    {
        public FormSignup()
        {
            this.Visible = false;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = true;

            // Affiche après tout
            this.Shown += (s, e) => { this.Visible = true; };
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            base.OnHandleCreated(e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormSignup_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

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
    public partial class UCStatBIB : UserControl
    {
        private int idBibliothecaire;
        public UCStatBIB(int id)
        {
            InitializeComponent();
            idBibliothecaire = id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using model;

namespace BD_Infracciones {
    public partial class MenuPrincipal : Form {
        private Data data;

        public MenuPrincipal() {
            InitializeComponent();

            data = new Data();
        }

        private void policiaToolStripMenuItem_Click(object sender, EventArgs e) {
            CrearPolicia cp = new CrearPolicia();
            cp.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e) {
            CrearMarcaModelo cmm = new CrearMarcaModelo();
            cmm.Show();
        }

        private void automovilToolStripMenuItem_Click(object sender, EventArgs e) {
            CrearAutomovil ca = new CrearAutomovil();
            ca.Show();
        }

        private void infracciónToolStripMenuItem_Click(object sender, EventArgs e) {
            CrearInfraccion ci = new CrearInfraccion();
            ci.Show();
        }
    }
}

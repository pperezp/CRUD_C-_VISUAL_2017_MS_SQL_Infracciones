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
    public partial class CrearPolicia : Form {
        private Data data;

        public CrearPolicia() {
            InitializeComponent();

            data = new Data();
            limpiar();
            cargar();
        }

        private void btnRegistrarPolicia_Click(object sender, EventArgs e) {
            Policia p = new Policia();

            p.Nombre = txtNombre.Text;
            p.Rut = txtRut.Text;
            p.Sexo = (opHombre.Checked ? 1 : 2);

            data.crearPolicia(p);

            limpiar();
            cargar();
        }

        private void limpiar() {
            txtNombre.Clear();
            txtRut.Clear();
            opHombre.Checked = true;

            txtRut.Focus();
        }

        private void cargar() {
            gridPolicia.DataSource = data.getPolicias();
        }

        private void txtBuscarPolicia_keyup(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                gridPolicia.DataSource = data.getPolicias(txtBuscarPolicia.Text);
            }
        }
    }
}

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

    public partial class CrearMarcaModelo : Form {

        private Data data;

        public CrearMarcaModelo() {
            InitializeComponent();

            data = new Data();

            cargarComboMarcas();
            cargarTabla();
        }

        private void cargarTabla() {
            gridMarca.DataSource = data.getMarcas();
        }

        private void cargarComboMarcas() {
            cboMarca.DataSource = data.getMarcas();
            cboMarca.DisplayMember = "nombre";
            cboMarca.ValueMember = "id";
        }

        private void btnRegistrarMarca_Click(object sender, EventArgs e) {
            data.crearMarca(txtMarca.Text);
            
            txtMarca.Clear();
            txtMarca.Focus();

            cargarComboMarcas();
            cargarTabla();
        }
    }
}

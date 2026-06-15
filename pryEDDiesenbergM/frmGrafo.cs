using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDDiesenbergM
{
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();
        }

        clsGrafoMatricial grafo = new clsGrafoMatricial();
        private void frmGrafo_Load(object sender, EventArgs e)
        {
            grafo.MostrarCiudades(cmbOrigenA);
            grafo.MostrarCiudades(cmbDestinoA);
            grafo.MostrarCiudades(cmbOrigenE);
            grafo.MostrarCiudades(cmbDestinoE);
            grafo.MostrarCiudades(cmbOrigenC);
            grafo.MostrarCiudades(cmbDestinoC);
            grafo.MostrarTodo(dgvGrafo);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (cmbOrigenA.SelectedIndex < 0 || cmbDestinoA.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione origen y destino.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Ingrese un precio válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Decimal.TryParse(txtPrecio.Text, out Decimal p))
            {
                MessageBox.Show("Precio inválido. Use formato numérico (coma decimal en es-ES).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Int32 f = cmbOrigenA.SelectedIndex;
            Int32 c = cmbDestinoA.SelectedIndex;

            grafo.Agregar(f, c, p);
            grafo.MostrarTodo(dgvGrafo);
            txtPrecio.Text = "";
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            grafo.BorrarTodo();
            grafo.MostrarTodo(dgvGrafo);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbOrigenE.SelectedIndex < 0 || cmbDestinoE.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione origen y destino para consultar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int32 f = cmbOrigenE.SelectedIndex;
            Int32 c = cmbDestinoE.SelectedIndex;
            Decimal precio = grafo.Consultar(f, c);
            lblPrecio2.Text = precio.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbOrigenE.SelectedIndex;
            Int32 c = cmbDestinoE.SelectedIndex;
            grafo.Eliminar(f, c);
            grafo.MostrarTodo(dgvGrafo);
        }

        private void btnListarDestinos_Click(object sender, EventArgs e)
        {
            Int32 c = cmbOrigenC.SelectedIndex;
            grafo.MostrarDestinos(c, dgvGrafo);
        }

        private void btnListarOrigenes_Click(object sender, EventArgs e)
        {
            Int32 c = cmbDestinoC.SelectedIndex;
            grafo.MostrarOrigenes(c, dgvGrafo);
        }

        private void btnVerViajes_Click(object sender, EventArgs e)
        {
            grafo.MostrarTodo(dgvGrafo);
        }

        private void cmbOrigenA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

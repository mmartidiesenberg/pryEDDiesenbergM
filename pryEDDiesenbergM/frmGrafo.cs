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
            grafo.MostrarCiudades(cmbOrigenE);
            grafo.MostrarCiudades(cmbOrigenC);
            grafo.MostrarCiudades(cmbDestinoA);
            grafo.MostrarCiudades(cmbDestinoE);
            grafo.MostrarCiudades(cmbDestinoC);
            grafo.MostrarTodo(dgvGrafo);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbOrigenA.SelectedIndex;
            Int32 c = cmbDestinoA.SelectedIndex;
            Decimal p = Convert.ToDecimal(txtPrecio.Text);
            grafo.Agregar(f, c, p);
            grafo.MostrarTodo(dgvGrafo);
            //lblTitulo.Text = "Listado Completo de viajes";
            txtPrecio.Text = "";    
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            grafo.BorrarTodo();
            grafo.MostrarTodo(dgvGrafo);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbOrigenC.SelectedIndex;
            Int32 c = cmbDestinoC.SelectedIndex;
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
            Int32 f = cmbOrigenA.SelectedIndex;
            grafo.MostrarDestinos(f, dgvGrafo);
        }

        private void btnListarOrigenes_Click(object sender, EventArgs e)
        {
            Int32 c = cmbDestinoA.SelectedIndex;
            grafo.MostrarOrigenes(c, dgvGrafo);
        }

        private void btnVerViajes_Click(object sender, EventArgs e)
        {
            grafo.MostrarTodo(dgvGrafo);
        }
    }
}

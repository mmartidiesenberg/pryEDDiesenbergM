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
    }
}

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
    public partial class frmPila : Form
    {
        clsPila Pila = new clsPila();
        public frmPila()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;

            Pila.Agregar(nuevo);
            Pila.Recorrer(dgvPila);
            Pila.Recorrer(lstPila);
            Pila.Recorrer("ArchivoPila.csv");

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Pila.Primero != null)
            {
                lblCodigo2.Text = Pila.Primero.Codigo.ToString();
                lblNombre2.Text = Pila.Primero.Nombre;
                lblTramite2.Text = Pila.Primero.Tramite;
                Pila.Eliminar();
                Pila.Recorrer(dgvPila);
                Pila.Recorrer(lstPila);
                Pila.Recorrer();
            }
        }
    }
}

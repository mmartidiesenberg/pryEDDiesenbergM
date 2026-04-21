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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        clsCola fila = new clsCola();
        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (fila.Primero != null)
            {
                lblCodigo.Text = fila.Primero.Codigo.ToString();   
                lblNombre.Text = fila.Primero.Nombre;
                lblTramite.Text = fila.Primero.Tramite; 
                fila.Eliminar();
                fila.Recorrer(dgvCola);
                fila.Recorrer(lstCola);
                fila.Recorrer();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;

            fila.Agregar(n);    
            fila.Recorrer(dgvCola);
            fila.Recorrer(lstCola);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";   
        }
    }
}

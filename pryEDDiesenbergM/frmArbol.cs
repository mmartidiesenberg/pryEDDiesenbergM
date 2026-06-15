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
    public partial class frmArbol : Form
    {
        public frmArbol()
        {
            InitializeComponent();
        }

        clsArbolBinario ObjArbol = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            ObjArbol.Agregar(Persona);
            ObjArbol.Recorrer(dgvArbol);
            ObjArbol.Recorrer(tvArbol);
            ObjArbol.Recorrer(cmbCodigo);

        }

        private void frmArbol_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex == -1) return;

            int codigo = Convert.ToInt32(cmbCodigo.SelectedItem);

            ObjArbol.Eliminar(codigo);

            ObjArbol.Recorrer(dgvArbol);
            ObjArbol.Recorrer(tvArbol);
            ObjArbol.Recorrer(cmbCodigo);
        }
    }
}

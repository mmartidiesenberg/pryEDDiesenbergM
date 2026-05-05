using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//lista simple: es una estructura de datos lineal, dinamica, no homogenea, no ordenada y no indexada. 
//los datos se alojan en la lista ordenados por el programador
namespace pryEDDiesenbergM
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple lista = new clsListaSimple();
            
        private void gbListado_Enter(object sender, EventArgs e)
        {

        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;

            lista.Agregar(n);
            lista.Recorrer(cmbCodigo);
            lista.Recorrer(dgvLista);
            lista.Recorrer(lstLista);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex == -1) return;
            string codigoSeleccionado = cmbCodigo.SelectedItem.ToString();
            foreach (DataGridViewRow fila in dgvLista.Rows)
            {
                if (fila.Cells[0].Value.ToString() == codigoSeleccionado)
                {
                    dgvLista.Rows.RemoveAt(fila.Index);
                    break;
                }
            }
            foreach (var item in lstLista.Items)
            {
                if (item.ToString().Contains(codigoSeleccionado))
                {
                    lstLista.Items.Remove(item);
                    break;
                }
            }
            cmbCodigo.Items.Remove(cmbCodigo.SelectedItem);
        }
    }
}

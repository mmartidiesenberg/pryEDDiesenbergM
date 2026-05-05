using System;
using System.Collections;
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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble Lista = new clsListaDoble();

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex == -1) return;
            string codigoSeleccionado = cmbCodigo.SelectedItem.ToString();
            foreach (DataGridViewRow fila in dgvListaDoble.Rows)
            {
                if (fila.Cells[0].Value.ToString() == codigoSeleccionado)
                {
                    dgvListaDoble.Rows.RemoveAt(fila.Index);
                    break;
                }
            }
            foreach (var item in lstListaDoble.Items)
            {
                if (item.ToString().Contains(codigoSeleccionado))
                {
                    lstListaDoble.Items.Remove(item);
                    break;
                }
            }
            cmbCodigo.Items.Remove(cmbCodigo.SelectedItem);
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            Lista.Agregar(ObjNodo);
            Lista.RecorrerDesc(dgvListaDoble);
            Lista.Recorrer(lstListaDoble);
            Lista.Recorrer(cmbCodigo);
            Lista.Recorrer("clsListaDoble.csv");

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (btnAsc.Checked)
                OrdenarListas(ascendente: true);
        }

        private void btnDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDesc.Checked)
                OrdenarListas(ascendente: false);
        }

        private void OrdenarListas(bool ascendente)
        {
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            foreach (DataGridViewRow fila in dgvListaDoble.Rows)
            {
                if (!fila.IsNewRow)
                {
                    filas.Add(fila);
                }
            }

            if (ascendente)
            {
                filas = filas.OrderBy(f => Convert.ToInt32(f.Cells[0].Value)).ToList();
            }
            else
            {
                filas = filas.OrderByDescending(f => Convert.ToInt32(f.Cells[0].Value)).ToList();
            }

            dgvListaDoble.Rows.Clear();
            foreach (DataGridViewRow fila in filas)
            {
                dgvListaDoble.Rows.Add(fila.Cells.Cast<DataGridViewCell>()
                .Select(c => c.Value).ToArray());
            }

            lstListaDoble.Items.Clear();
            foreach (DataGridViewRow fila in dgvListaDoble.Rows)
            {
                if (!fila.IsNewRow)
                {
                    lstListaDoble.Items.Add(fila.Cells[0].Value.ToString());
                }
            }
        }
    }
}

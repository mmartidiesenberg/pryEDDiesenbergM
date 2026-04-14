using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace pryEDDiesenbergM
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto objCliente = new clsArchivoTexto();
            objCliente.NomArchi = "Clientes.csv";
            objCliente.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            objCliente.Recorrer(dgvClientes);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
           clsArchivoTexto X = new clsArchivoTexto();
            X.NomArchi = "Clientes.csv";
            if (File.Exists(X.NomArchi)) X.Recorrer(dgvClientes);
        }
    }
}

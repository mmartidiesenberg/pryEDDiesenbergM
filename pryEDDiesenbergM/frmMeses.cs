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
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NomArchi = "Meses.txt";
            x.Grabar(txtMeses.Text);
            x.Recorrer(lstMeses);
            MessageBox.Show("Dato grabado");
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {

        }
    }
}

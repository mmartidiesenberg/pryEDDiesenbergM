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
    public partial class frmOperacionesBD : Form
    {
        public frmOperacionesBD()
        {
            InitializeComponent();
        }
        clsBaseDatos bd = new clsBaseDatos();
        private void btnMultiatributo_Click(object sender, EventArgs e)
        {
            String varSQL = "select titulo, año, cantidad, " +
                "precio, (cantidad * precio) as Total from libro";
            bd.Listar(dgvBD, varSQL);
        }
    }
}

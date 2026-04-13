using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDDiesenbergM
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto objAlumnos = new clsArchivoTexto();
            objAlumnos.NomArchi = "Alumnos.csv";
            objAlumnos.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            clsArchivoTexto X = new clsArchivoTexto();
            X.NomArchi = "Alumnos.csv";
            if (File.Exists(X.NomArchi))
                X.Recorrer(dgvAlumnos);
        }
    }
}

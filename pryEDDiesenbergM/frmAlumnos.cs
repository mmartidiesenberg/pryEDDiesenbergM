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
            objAlumnos.Recorrer(dgvAlumnos);

        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            clsArchivoTexto objCarrera = new clsArchivoTexto();
            objCarrera.NomArchi = "Carreras.csv";
            if (File.Exists(objCarrera.NomArchi)) objCarrera.Recorrer(cmbCarrera);

            clsArchivoTexto objAlumno = new clsArchivoTexto();
            objAlumno.NomArchi = "Alumnos.csv";
            if (File.Exists(objAlumno.NomArchi)) objAlumno.Recorrer(dgvAlumnos);

        }
    }
}

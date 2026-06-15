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

        private void btnProySimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT titulo, año, cantidad, precio FROM libro";
            bd.Listar(dgvBD, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT l.titulo, a.nombre AS autor, p.nombre AS pais, " +
                    "i.nombre AS idioma, l.año, l.cantidad, l.precio " +
                    "FROM ((libro l " +
                    "INNER JOIN autor a ON l.idautor = a.idautor) " +
                    "INNER JOIN pais p ON l.idpais = p.idpais) " +
                    "INNER JOIN idioma i ON l.ididioma = i.ididioma";
            bd.Listar(dgvBD, varSQL);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM libro WHERE cantidad > 5";
            bd.Listar(dgvBD, varSQL);
        }

        private void btnMultiat_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM libro WHERE cantidad > 5 AND precio < 1000";
            bd.Listar(dgvBD, varSQL);
        }

        private void btnConvolucion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT l.titulo, a.nombre AS autor, l.precio " +
                    "FROM libro l INNER JOIN autor a ON l.idautor = a.idautor " +
                    "WHERE l.precio > 500";
            bd.Listar(dgvBD, varSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT nombre FROM autor " +
                   "UNION " +
                   "SELECT nombre FROM pais";
            bd.Listar(dgvBD, varSQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT nombre FROM autor WHERE nombre IN " +
                   "(SELECT nombre FROM pais)";
            bd.Listar(dgvBD, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT nombre FROM autor WHERE nombre NOT IN " +
                    "(SELECT nombre FROM pais)";
            bd.Listar(dgvBD, varSQL);
        }
    }
}

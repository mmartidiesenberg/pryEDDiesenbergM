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
    public partial class frmConsultasVarias : Form
    {
        clsBaseDatos bd = new clsBaseDatos();

        public frmConsultasVarias()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            String varSQL = "";

            switch (cmbOperacion.SelectedItem.ToString())
            {
                case "Proyección Simple":
                    varSQL = "SELECT titulo, año, cantidad, precio FROM libro";
                    break;
                case "Proyección Multiatributo":
                    varSQL = "SELECT titulo, año, cantidad, precio, (cantidad * precio) AS Total FROM libro";
                    break;
                case "Juntar":
                    varSQL = "SELECT l.titulo, a.nombre AS autor, p.nombre AS pais, " +
                             "i.nombre AS idioma, l.año, l.cantidad, l.precio " +
                             "FROM ((libro l " +
                             "INNER JOIN autor a ON l.idautor = a.idautor) " +
                             "INNER JOIN pais p ON l.idpais = p.idpais) " +
                             "INNER JOIN idioma i ON l.ididioma = i.ididioma";
                    break;
                case "Selección Simple":
                    varSQL = "SELECT * FROM libro WHERE cantidad > 5";
                    break;
                case "Selección Multiatributo":
                    varSQL = "SELECT * FROM libro WHERE cantidad > 5 AND precio < 1000";
                    break;
                case "Selección por Convolución":
                    varSQL = "SELECT l.titulo, a.nombre AS autor, l.precio " +
                             "FROM libro l INNER JOIN autor a ON l.idautor = a.idautor " +
                             "WHERE l.precio > 500";
                    break;
                case "Unión":
                    varSQL = "SELECT nombre FROM autor UNION SELECT nombre FROM pais";
                    break;
                case "Intersección":
                    varSQL = "SELECT nombre FROM autor WHERE nombre IN (SELECT nombre FROM pais)";
                    break;
                case "Diferencia":
                    varSQL = "SELECT nombre FROM autor WHERE nombre NOT IN (SELECT nombre FROM pais)";
                    break;
            }

            bd.Listar(dgvOperaciones, varSQL);
        }

        private void frmConsultasVarias_Load(object sender, EventArgs e)
        {
            cmbOperacion.Items.Add("Proyección Simple");
            cmbOperacion.Items.Add("Proyección Multiatributo");
            cmbOperacion.Items.Add("Juntar");
            cmbOperacion.Items.Add("Selección Simple");
            cmbOperacion.Items.Add("Selección Multiatributo");
            cmbOperacion.Items.Add("Selección por Convolución");
            cmbOperacion.Items.Add("Unión");
            cmbOperacion.Items.Add("Intersección");
            cmbOperacion.Items.Add("Diferencia");
            cmbOperacion.SelectedIndex = 0;
        }
    }
}

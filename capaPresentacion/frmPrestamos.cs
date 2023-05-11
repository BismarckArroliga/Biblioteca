using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocios;
using capaComun;

namespace capaPresentacion
{
    public partial class frmPrestamos : Form
    {
        public frmPrestamos()
        {
            InitializeComponent();
        }

        private void listarPrestamos()
        {
            CN_Prestamos objPrestamos = new CN_Prestamos();
            dgvPrestamos.DataSource = objPrestamos.listarPrestamos();
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            txtEmpleado.Text = CM_UsuarioCache.Nombre + " " + CM_UsuarioCache.Apellido;
            listarPrestamos();
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {       
            using (var Modal = new md_Estudiantes())
            {              
                // CENTRAR MODAL ESTUDIANTES
                Point pnlLocation = pnlFondo2.PointToScreen(pnlFondo2.Location);
                int x = pnlLocation.X + (pnlFondo2.Width / 2) - (Modal.Width / 2);
                int y = pnlLocation.Y + (pnlFondo2.Height / 2) - (Modal.Height / 2);
                Modal.Location = new Point(x, y);
                var res = Modal.ShowDialog();

                if (res == DialogResult.OK)
                {
                    txtIdEstudiante.Text = Modal._estudiantes.Id.ToString();
                    txtEstudiante.Text = Modal._estudiantes.Nombre;
                }
            }
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            using (var Modal = new md_Libros())
            {
                // CENTRAR MODAL LIBROS
                Point pnlLocation = pnlFondo2.PointToScreen(pnlFondo2.Location);
                int x = pnlLocation.X + (pnlFondo2.Width / 2) - (Modal.Width / 2);
                int y = pnlLocation.Y + (pnlFondo2.Height / 2) - (Modal.Height / 2);
                Modal.Location = new Point(x, y);
                var res = Modal.ShowDialog();

                if (res == DialogResult.OK)
                {
                    txtIdLibro.Text = Modal._libros.Id.ToString();
                    txtLibro.Text = Modal._libros.Nombre;
                }
            }
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            CN_Prestamos objPrestamos = new CN_Prestamos();
            string empleado_id = CM_UsuarioCache.idEmpleado.ToString();
            objPrestamos.insertarPrestamo(empleado_id, txtIdEstudiante.Text,txtIdLibro.Text,txtFechaFin.Text);
            MessageBox.Show("Prestamo realizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            listarPrestamos();
        }
    }
}





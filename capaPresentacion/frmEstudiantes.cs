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

namespace capaPresentacion
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }

        private void listarEstudiantes()
        {
            CN_Estudiantes objEstudiantes = new CN_Estudiantes();
            dgvEstudiantes.DataSource = objEstudiantes.listarEstudiantes();
        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            listarEstudiantes();
            txtTelefono.MaxLength = 8;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            CN_Estudiantes objEstudiantes = new CN_Estudiantes();
            objEstudiantes.insertarEstudiantes(txtNombre.Text, txtCorreo.Text, txtTelefono.Text, txtDireccion.Text);
            MessageBox.Show("Estudiante registrado correctamente");
            listarEstudiantes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("El campo id es obligatorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CN_Estudiantes objEstudiantes = new CN_Estudiantes();
            objEstudiantes.actaulizarEstudiantes(txtId.Text,txtNombre.Text, txtCorreo.Text, txtTelefono.Text, txtDireccion.Text);
            MessageBox.Show("Estudiante actaulizado correctamente");
            listarEstudiantes();
        }
    }
}

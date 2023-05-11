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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void listarUsurios()
        {
            dgvUsuarios.DataSource = new CN_Usuarios().listarUsuarios();
        }

        private void resultadoBusqueda()
        {
            txtUsuario.Text = CM_Empleados.Nombre;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            listarUsurios();
        }

        private void txtIdEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (txtIdEmpleado.Text !="")
            {
                CN_Empleados objEmpleados = new CN_Empleados();
                objEmpleados.buscarEmpleado(txtIdEmpleado.Text);
                resultadoBusqueda();
            } else
            {
                txtUsuario.Clear();
                CM_Empleados.Nombre = "";
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            CN_Usuarios objUsuarios = new CN_Usuarios();
            objUsuarios.insertarUsuarios(txtUsuario.Text.Trim(), txtContrasena.Text.Trim(), txtIdEmpleado.Text);
            MessageBox.Show("Usuario creado correctamente");
            listarUsurios();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIdEmpleado.Text == "")
            {
                MessageBox.Show("El campo id es obligatorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CN_Usuarios objUsuarios = new CN_Usuarios();
            objUsuarios.actualizarUsuarios(txtIdEmpleado.Text, txtUsuario.Text, txtContrasena.Text, txtIdEmpleado.Text);
            MessageBox.Show("Usuario actualizado correctamente");
            listarUsurios();
        }
    }
}







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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void listarEmpleados()
        {
            CN_Empleados objempleados = new CN_Empleados();
            dgvEmpleados.DataSource = objempleados.listarEmpleados();
        }

        private void listarCargos()
        {
            CN_Empleados objempleados = new CN_Empleados();
            cmbCargos.DataSource = objempleados.listarCargos();
            cmbCargos.DisplayMember = "Nombre";
            cmbCargos.ValueMember = "Id";
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            listarEmpleados();
            listarCargos();
            txtCedula.MaxLength = 14;
            txtTelefono.MaxLength = 8;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            CN_Empleados objempleados = new CN_Empleados();
            objempleados.insertarEmpleados(txtNombre.Text.Trim(), txtApellido.Text, txtCorreo.Text, txtTelefono.Text, txtCedula.Text, cmbCargos.SelectedValue.ToString());
            MessageBox.Show("Nuevo empleado insertado correctamente");
            listarEmpleados();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("El campo id es obligatorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CN_Empleados objempleados = new CN_Empleados();
            objempleados.actaulizarEmpleados(txtId.Text, txtNombre.Text,txtApellido.Text, txtCorreo.Text, txtTelefono.Text, txtCedula.Text, cmbCargos.SelectedValue.ToString());
            MessageBox.Show("Empleado actualizado correctamente");
            listarEmpleados();
        }
    }
}

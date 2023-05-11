using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocios;

namespace capaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtContrasena.Text != "")
                {
                    CN_Usuarios objUsuarios = new CN_Usuarios();
                    var usuario = objUsuarios.login(txtUsuario.Text.Trim(), txtContrasena.Text.Trim());
                    if (usuario)
                    {
                        this.Hide();
                        frmSistema sistema = new frmSistema();
                        sistema.Show();
                        MessageBox.Show("Open");
                        sistema.FormClosed += login;
                    }
                    else
                        MessageBox.Show("Usuario o contraseña incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Debes ingresar una contrasena", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Debes ingresar un usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void login(object senderr, FormClosedEventArgs e)
        {
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
            this.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Select();
        }

    }
}










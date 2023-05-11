using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaComun;
using capaNegocios;

namespace capaPresentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void listarCacheUsuario()
        {
            lblUsuario.Text = CM_UsuarioCache.Nombre + " " + CM_UsuarioCache.Apellido;
        }

        private void cargarSumario()
        {
            CN_Sumario objSumario = new CN_Sumario();
            objSumario.listarCantLibros();
            objSumario.listarCantEstudiantes();
            objSumario.listarCantPrestamos();
            objSumario.listarCantUsuarios();

            // ASIGNAR VALORES 
            lblCantLibros.Text = CM_Sumario.cantLibros.ToString();
            lblCantEstudiantes.Text = CM_Sumario.cantEstudiantes.ToString();
            lblCantPresta.Text = CM_Sumario.cantPrestamos.ToString();
            lblCantUsuarios.Text = CM_Sumario.cantUsuarios.ToString();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            listarCacheUsuario();
            cargarSumario();
        }

        private void timerFecha_Tick(object sender, EventArgs e)
        {
            //lblFecha.Text = DateTime.Now.ToLongDateString();
            //lblHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

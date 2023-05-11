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
    public partial class frmDevolucion : Form
    {
        public frmDevolucion()
        {
            InitializeComponent();
        }

        private void listarDevoluciones()
        {
            CN_Prestamos objPrestamos = new CN_Prestamos();
            dgvDevoluciones.DataSource = objPrestamos.listarDevoluciones();
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            listarDevoluciones();
        }

        private void btnDevolverPrestamo_Click(object sender, EventArgs e)
        {
            CN_Prestamos objPrestamos = new CN_Prestamos();
            objPrestamos.retornarPrestamo(txtIdPrestamo.Text, txtFechaRetorno.Text);
            MessageBox.Show("Devolucion exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtIdPrestamo.Clear();
            listarDevoluciones();
        }

    }
}





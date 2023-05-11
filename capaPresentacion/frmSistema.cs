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

namespace capaPresentacion
{
    public partial class frmSistema : Form
    {
        public frmSistema()
        {
            InitializeComponent();
        }

        #region Efecto Mover
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Mover();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int
       wparam, int lparam);

        public void Mover()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void pnlPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            Mover();
        }

        private void AbrirFormEnPanel (object FormHijo)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
                this.pnlPrincipal.Controls.RemoveAt(0);

            Form form = FormHijo as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            this.pnlPrincipal.Controls.Add(form);
            this.pnlPrincipal.Tag = form;
            form.Show();
            form.BringToFront();
        }


        private void AbrirFormInicio()
        {
            AbrirFormEnPanel(new frmInicio());
        }

        private void frmSistema_Load(object sender, EventArgs e)
        {
            AbrirFormInicio();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInicio();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmEmpleados());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmUsuarios());
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmEstudiantes());
        }

        private void btnLlbros_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmLibros());
        }

        private void frmPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmPrestamos());
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmDevolucion());
        }
    }
}

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
    public partial class frmLibros : Form
    {
        public frmLibros()
        {
            InitializeComponent();
        }

        private void listarLibros()
        {
            CN_Libros objLibros = new CN_Libros();
            dgvLibros.DataSource = objLibros.listarLibros();
        }

        private void listarCategorias()
        {
            CN_Libros objLibros = new CN_Libros();
            cmbCategorias.DataSource = objLibros.listarCategorias();
            cmbCategorias.DisplayMember = "Nombre";
            cmbCategorias.ValueMember = "Id";

        }

        public void listarAutores()
        {
            CN_Libros objLibros = new CN_Libros();
            cmbAutores.DataSource = objLibros.listarAutores();
            cmbAutores.DisplayMember = "Nombre";
            cmbAutores.ValueMember = "Id";

        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            listarLibros();
            listarCategorias();
            listarAutores();
        }

        private void btnInsertarLibro_Click(object sender, EventArgs e)
        {
            CN_Libros objLibros = new CN_Libros();
            string categoria_id = cmbCategorias.SelectedValue.ToString();
            string autor_id = cmbAutores.SelectedValue.ToString();
            objLibros.insertarLibros(txtNombre.Text, txtPaginas.Text, txtStock.Text, categoria_id, autor_id);
            MessageBox.Show("Libro registrado correctamente");
            listarLibros();
        }

        private void btnActualizarLibro_Click(object sender, EventArgs e)
        {
            if (txtIdLibro.Text == "")
            {
                MessageBox.Show("El campo id es obligatorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CN_Libros objLibros = new CN_Libros();
            string categoria_id = cmbCategorias.SelectedValue.ToString();
            string autor_id = cmbAutores.SelectedValue.ToString();
            objLibros.actualizarLibros(txtIdLibro.Text, txtNombre.Text, txtPaginas.Text, txtStock.Text, categoria_id, autor_id);
            MessageBox.Show("Libro actualizado correctamente");
            listarLibros();
        }


        private void btnModalAutores_Click(object sender, EventArgs e)
        {
            md_Autores md_Autores = new md_Autores();

            // CENTRAR MODAL AUTORES
            Point pnlLocation = pnlFondo.PointToScreen(pnlFondo.Location);
            int x = pnlLocation.X + (pnlFondo.Width / 2) - (md_Autores.Width / 2);
            int y = pnlLocation.Y + (pnlFondo.Height / 2) - (md_Autores.Height / 2);
            md_Autores.Location = new Point(x, y);

            md_Autores.FormClosed += cerrarModal;
            md_Autores.ShowDialog();
           
        }

        private void cerrarModal(object server, FormClosedEventArgs e)
        {
            listarAutores();
        }
    }
}

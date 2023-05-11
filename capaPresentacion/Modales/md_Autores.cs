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
    public partial class md_Autores : Form
    {
        public md_Autores()
        {
            InitializeComponent();
        }

        private void listarAutores()
        {
            CN_Libros objLibros = new CN_Libros();
            dgvAutores.DataSource = objLibros.listarAutores();
        }

        private void md_Autores_Load(object sender, EventArgs e)
        {
            listarAutores();
        }
     
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            CN_Libros objLibros = new CN_Libros();
            objLibros.insertarAutores(txtNombre.Text);
            MessageBox.Show("Nuevo autor registrado correctamente");
            listarAutores();
        }

        private void btnActaulizar_Click(object sender, EventArgs e)
        {
            CN_Libros objLibros = new CN_Libros();
            objLibros.actaulizarAutores(txtIdAutor.Text, txtNombre.Text);
            MessageBox.Show("Autor actualizado correctamente");
            listarAutores();
        }
    }
}








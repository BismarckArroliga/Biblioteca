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
    public partial class md_Libros : Form
    {
        public Libros _libros { get; set; }

        public md_Libros()
        {
            InitializeComponent();
        }

        private void listarLibros()
        {
            CN_Libros objLibros = new CN_Libros();
            dgvLibros.DataSource = objLibros.listarLibros();
        }

        private void md_Libros_Load(object sender, EventArgs e)
        {
            listarLibros();
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                _libros = new Libros();
                _libros.Id = Convert.ToInt32(dgvLibros.Rows[row].Cells["Id"].Value);
                _libros.Nombre = dgvLibros.Rows[row].Cells["Nombre"].Value.ToString();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}








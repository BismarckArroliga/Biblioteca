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
    public partial class md_Estudiantes : Form
    {
        public Estudiantes _estudiantes { get; set; }

        public md_Estudiantes()
        {
            InitializeComponent();
        }

        private void listarEstudiantes()
        {
            CN_Estudiantes objEstudiantes = new CN_Estudiantes();
            dgvEstudiantes.DataSource = objEstudiantes.listarEstudiantes();
        }

        private void md_Estudiantes_Load(object sender, EventArgs e)
        {
            listarEstudiantes();
        }

        private void dgvEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                _estudiantes = new Estudiantes();
                _estudiantes.Id = Convert.ToInt32(dgvEstudiantes.Rows[row].Cells["Id"].Value);
                _estudiantes.Nombre = dgvEstudiantes.Rows[row].Cells["Nombre"].Value.ToString();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}








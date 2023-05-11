using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaNegocios
{
    public class CN_Estudiantes
    {
        CD_Estudiantes objEstudiantes = new CD_Estudiantes();
        public System.Data.DataTable listarEstudiantes()
        {
            return objEstudiantes.listarEstudiantes();
        }

        public void insertarEstudiantes(string nombre, string correo, string telefono, string direccion)
        {
            objEstudiantes.insertarEstudiantes(nombre, correo, telefono, direccion);
        }

        public void actaulizarEstudiantes(string estudiante_id, string nombre, string correo, string telefono, string direccion)
        {
            objEstudiantes.actualizarEstudiantes(int.Parse(estudiante_id), nombre, correo, telefono, direccion);
        }
    }
}

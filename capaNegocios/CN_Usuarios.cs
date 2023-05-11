using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaNegocios
{
    public class CN_Usuarios
    {
        CD_Usuarios objUsuarios = new CD_Usuarios();
        public bool login(string usuario, string contrasena)
        {
            return objUsuarios.Login(usuario, contrasena);
        }

        public System.Data.DataTable listarUsuarios()
        {
            return objUsuarios.listarUsuarios();
        }

        public void insertarUsuarios(string usuario, string contrasena, string empleado_id)
        {
            objUsuarios.insertarUsuarios(usuario, contrasena, int.Parse(empleado_id));
        }

        public void actualizarUsuarios(string usuario_id, string usuario, string contrasena, string empleado_id)
        {
            objUsuarios.actaulizarUsuarios(int.Parse(usuario_id), usuario, contrasena, int.Parse(empleado_id));
        }
    }
}

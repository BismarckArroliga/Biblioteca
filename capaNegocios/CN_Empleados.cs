using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaNegocios
{
    public class CN_Empleados
    {
        CD_Empleados objEmpleados = new CD_Empleados();

        public System.Data.DataTable listarEmpleados()
        {
            return objEmpleados.listarEmpleados();
        }

        public System.Data.DataTable listarCargos()
        {
            return objEmpleados.listarCargos();
        }

        public void insertarEmpleados(string nombre, string apellido, string correo, string telefono, string cedula, string cargo)
        {
            objEmpleados.insertarEmpleados(nombre, apellido, correo, telefono, cedula, int.Parse(cargo));
        }

        public void actaulizarEmpleados(string id,string nombre, string apellido, string correo, string telefono, string cedula, string cargo)
        {
            objEmpleados.actualizarEmpleados(int.Parse(id), nombre, apellido, correo, telefono, cedula, int.Parse(cargo));
        }

        public void buscarEmpleado(string id)
        {
            objEmpleados.buscarEmpleado(int.Parse(id));
        }
    }
}

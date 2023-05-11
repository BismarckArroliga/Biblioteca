using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaNegocios
{
    public class CN_Prestamos
    {
        CD_Prestamos objPrestamos = new CD_Prestamos();

        public System.Data.DataTable listarPrestamos()
        {
            return objPrestamos.listarPrestamos();
        }

        public System.Data.DataTable listarDevoluciones()
        {
            return objPrestamos.listarDevoluciones();
        }

        public void insertarPrestamo(string empleado_id, string estudiante_id, string libro_id,string fecha_fin)
        {
            objPrestamos.insertarPrestamo(int.Parse(empleado_id), int.Parse(estudiante_id), int.Parse(libro_id), Convert.ToDateTime(fecha_fin));
        }

        public void retornarPrestamo(string prestamo_id, string fecha_retorno)
        {
            objPrestamos.retornarPrestamo( int.Parse(prestamo_id), Convert.ToDateTime(fecha_retorno));
        }
    }
}

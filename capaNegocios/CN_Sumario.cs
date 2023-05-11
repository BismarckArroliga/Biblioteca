using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaNegocios
{
   public class CN_Sumario
    {
        CD_Sumario objSumario = new CD_Sumario();
        public void listarCantLibros()
        {
            objSumario.listarCantLibros();
        }

        public void listarCantEstudiantes()
        {
            objSumario.listarCantEstudiantes();
        }

        public void listarCantPrestamos()
        {
            objSumario.listarCantPrestamos();
        }

        public void listarCantUsuarios()
        {
            objSumario.listarCantUsuarios();
        }
    }
}

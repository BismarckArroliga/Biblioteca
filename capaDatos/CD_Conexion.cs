using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public abstract class CD_Conexion
    {
        private readonly string sql;
        public CD_Conexion()
        {
            sql = "Server=(local); DataBase = BD_Biblioteca; Integrated Security= true";
        }
        public System.Data.SqlClient.SqlConnection GetConnection()
        {
            return new System.Data.SqlClient.SqlConnection(sql);
        }
    }
}

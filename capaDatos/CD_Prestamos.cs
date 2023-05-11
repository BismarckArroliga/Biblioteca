using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class CD_Prestamos: CD_Conexion
    {
        public DataTable listarPrestamos()
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_prestamos", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "L";
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable tabla = new DataTable();
                    tabla.Load(reader);
                    return tabla;
                }
            }
        }

        public DataTable listarDevoluciones()
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_prestamos", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "D";
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable tabla = new DataTable();
                    tabla.Load(reader);
                    return tabla;
                }
            }
        }

        public void insertarPrestamo(int empleado_id, int estudiante_id, int libro_id, DateTime fecha_fin)
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_prestamos", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "I";
                    cmd.Parameters.Add("@empleado_id", SqlDbType.Int).Value = empleado_id;
                    cmd.Parameters.Add("@estudiante_id", SqlDbType.Int).Value = estudiante_id;
                    cmd.Parameters.Add("@libro_id", SqlDbType.Int).Value = libro_id;
                    cmd.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fecha_fin;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void retornarPrestamo(int prestamo_id, DateTime fecha_fin)
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_prestamos", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char,1).Value = "U";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = prestamo_id;
                    cmd.Parameters.Add("@fecha_retorno", SqlDbType.Date).Value = fecha_fin;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

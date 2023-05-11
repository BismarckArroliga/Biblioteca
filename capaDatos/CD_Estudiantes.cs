using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class CD_Estudiantes: CD_Conexion
    {
        public DataTable listarEstudiantes()
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_estudiantes", sql))
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

        public void insertarEstudiantes(string nombre, string correo, string telefono, string direccion)
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_estudiantes", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "I";
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = correo;
                    cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 14).Value = telefono;
                    cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = direccion;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void actualizarEstudiantes(int estudiante_id, string nombre, string correo, string telefono, string direccion)
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_estudiantes", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "U";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = estudiante_id;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = correo;
                    cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 14).Value = telefono;
                    cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = direccion;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}



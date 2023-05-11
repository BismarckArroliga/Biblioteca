using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using capaComun;

namespace capaDatos
{
    public class CD_Usuarios:CD_Conexion
    {
        public bool Login(string usuario, string contrasena)
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using(var cmd = new SqlCommand("sp_usuarios", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.VarChar, 5).Value = "LOGIN";
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = usuario;
                    cmd.Parameters.Add("@contrasena", SqlDbType.VarChar, 50).Value = contrasena;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if(reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            CM_UsuarioCache.idEmpleado = reader.GetInt32(0);
                            CM_UsuarioCache.Nombre = reader.GetString(1);
                            CM_UsuarioCache.Apellido = reader.GetString(2);
                        }

                        return true;
                    } else
                    {
                        return false;
                    }
                }
            }
        }

        public DataTable listarUsuarios()
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_usuarios", sql))
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

        public void insertarUsuarios(string usuario, string contrasena, int empleado_id)
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_usuarios", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "I";
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = usuario;
                    cmd.Parameters.Add("@contrasena", SqlDbType.VarChar, 50).Value = contrasena;
                    cmd.Parameters.Add("@empleado_id", SqlDbType.Int).Value = empleado_id;
                    cmd.ExecuteNonQuery();
                   
                }
            }
        }

        public void actaulizarUsuarios(int usuario_id, string usuario, string contrasena, int empleado_id)
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_usuarios", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "U";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = usuario_id;
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = usuario;
                    cmd.Parameters.Add("@contrasena", SqlDbType.VarChar, 50).Value = contrasena;
                    cmd.Parameters.Add("@empleado_id", SqlDbType.Int).Value = empleado_id;
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}









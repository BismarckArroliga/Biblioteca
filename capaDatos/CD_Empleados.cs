using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capaComun;

namespace capaDatos
{
    public class CD_Empleados : CD_Conexion
    {
        DataTable tabla = new DataTable();
        SqlDataReader reader;

        public DataTable listarEmpleados()
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_empleados", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "L";
                    reader = cmd.ExecuteReader();
                    tabla.Load(reader);
                    return tabla;
                }
            }
        }


        public DataTable listarCargos()
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_empleados", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "C";
                    reader = cmd.ExecuteReader();
                    tabla.Load(reader);
                    return tabla;
                }
            }
        }

        public void insertarEmpleados(string nombre, string apellido, string correo, string telefono, string cedula, int cargo)
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_empleados", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "I";
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
                    cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = apellido;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = correo;
                    cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 14).Value = telefono;
                    cmd.Parameters.Add("@cedula", SqlDbType.VarChar, 50).Value = cedula;
                    cmd.Parameters.Add("@cargo_id", SqlDbType.Int).Value = cargo;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void actualizarEmpleados(int id, string nombre, string apellido, string correo, string telefono, string cedula, int cargo)
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_empleados", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "U";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
                    cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = apellido;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = correo;
                    cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 14).Value = telefono;
                    cmd.Parameters.Add("@cedula", SqlDbType.VarChar, 50).Value = cedula;
                    cmd.Parameters.Add("@cargo_id", SqlDbType.Int).Value = cargo;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void buscarEmpleado(int id)
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_empleados", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "B";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            CM_Empleados.Nombre = reader.GetString(1);
                        }
                    }
                }
            }
        }
    }


}

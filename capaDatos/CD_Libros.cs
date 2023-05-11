using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
   public class CD_Libros: CD_Conexion
    {
        public DataTable listarLibros()
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_libros", sql))
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

        public DataTable listarCategorias()
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_libros", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "C";
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable tabla = new DataTable();
                    tabla.Load(reader);
                    return tabla;
                }
            }
        }

        public void insertarLibros(string nombre, int paginas, int stock, int categoria_id, int autor_id)
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_libros", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "I";
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
                    cmd.Parameters.Add("@paginas", SqlDbType.Int).Value = paginas;
                    cmd.Parameters.Add("@stock", SqlDbType.Int).Value = stock;
                    cmd.Parameters.Add("@categoria_id", SqlDbType.Int).Value = categoria_id;
                    cmd.Parameters.Add("@autor_id", SqlDbType.Int).Value = autor_id;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void actualizarLibros(int libro_id, string nombre, int paginas, int stock, int categoria_id, int autor_id)
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_libros", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "U";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = libro_id;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
                    cmd.Parameters.Add("@paginas", SqlDbType.Int).Value = paginas;
                    cmd.Parameters.Add("@stock", SqlDbType.Int).Value = stock;
                    cmd.Parameters.Add("@categoria_id", SqlDbType.Int).Value = categoria_id;
                    cmd.Parameters.Add("@autor_id", SqlDbType.Int).Value = autor_id;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable listarAutores()
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_autores", sql))
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

        public void insertarAutores(string nombre)
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_autores", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "I";
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void actualizarAutores(int autor_id, string nombre)
        {
            using (var sql = GetConnection())
            {
                sql.Open();
                using (var cmd = new SqlCommand("sp_autores", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@op", SqlDbType.Char, 1).Value = "U";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = autor_id;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}

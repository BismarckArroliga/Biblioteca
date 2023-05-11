using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaNegocios
{
    public class CN_Libros
    {
        CD_Libros objLibros = new CD_Libros();

        public System.Data.DataTable listarLibros()
        {
            return objLibros.listarLibros();
        }

        public System.Data.DataTable listarCategorias()
        {
            return objLibros.listarCategorias();
        }

        public System.Data.DataTable listarAutores()
        {
            return objLibros.listarAutores();
        }

        public void insertarLibros(string nombre, string paginas, string stock, string categoria_id, string autor_id)
        {
            objLibros.insertarLibros(nombre, int.Parse(paginas), int.Parse(stock), int.Parse(categoria_id), int.Parse(autor_id));
        }

        public void actualizarLibros(string libro_id, string nombre, string paginas, string stock, string categoria_id, string autor_id)
        {
            objLibros.actualizarLibros(int.Parse(libro_id), nombre, int.Parse(paginas), int.Parse(stock), int.Parse(categoria_id), int.Parse(autor_id));
        }

        public void insertarAutores(string nombre)
        {
            objLibros.insertarAutores(nombre);
        }

        public void actaulizarAutores(string libro_id, string nombre)
        {
            objLibros.actualizarAutores(int.Parse(libro_id), nombre);
        }
    }
}











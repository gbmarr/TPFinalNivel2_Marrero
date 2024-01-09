using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace Presentación
{
    class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader datos;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Codigo Código, Nombre, A.Descripcion Descripción, M.Descripcion Marca, C.Descripcion Categoría, ImagenUrl Imagen, Precio From ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdMarca = M.Id AND A.IdCategoria = C.Id";
                comando.Connection = conexion;

                conexion.Open();
                datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    Articulo aux = new Articulo();
                    aux.codArticulo = (string)datos["Código"];
                    aux.Nombre = (string)datos["Nombre"];
                    aux.Descripcion = (string)datos["Descripción"];
                    aux.Marca = (string)datos["Marca"];
                    aux.Categoria = (string)datos["Categoría"];
                    aux.Imagen = (string)datos["Imagen"];
                    aux.Precio = (Decimal)datos["Precio"];

                    lista.Add(aux);

                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

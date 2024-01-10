using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
                
            try
            {
                datos.setearConsulta("Select Codigo Código, Nombre, A.Descripcion Descripción, M.Descripcion Marca, C.Descripcion Categoría, ImagenUrl, Precio From ARTICULOS A, CATEGORIAS C, MARCAS M Where A.IdMarca = M.Id AND A.IdCategoria = c.Id");
                datos.ejecutarLectura();

                while(datos.LectorDeDatos.Read())
                {
                    Articulo aux = new Articulo();
                    aux.codArticulo = (string)datos.LectorDeDatos["Código"];
                    aux.Nombre = (string)datos.LectorDeDatos["Nombre"];
                    aux.Descripcion = (string)datos.LectorDeDatos["Descripción"];
                    aux.Marca = new Elemento();
                    aux.Marca.Descripcion = (string)datos.LectorDeDatos["Marca"];
                    aux.Categoria = new Elemento();
                    aux.Categoria.Descripcion = (string)datos.LectorDeDatos["Categoría"];
                    aux.Imagen = (string)datos.LectorDeDatos["ImagenUrl"];
                    aux.Precio = (Decimal)datos.LectorDeDatos["Precio"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

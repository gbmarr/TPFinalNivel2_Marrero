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
                datos.setearConsulta("Select A.Id ID, Codigo Código, Nombre, A.Descripcion Descripción, M.Descripcion Marca, C.Descripcion Categoría, ImagenUrl, Precio, M.Id IdMarca, C.Id IdCategoria From ARTICULOS A, CATEGORIAS C, MARCAS M Where A.IdMarca = M.Id AND A.IdCategoria = c.Id");
                datos.ejecutarLectura();

                while(datos.LectorDeDatos.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.LectorDeDatos["ID"];
                    aux.codArticulo = (string)datos.LectorDeDatos["Código"];
                    aux.Nombre = (string)datos.LectorDeDatos["Nombre"];
                    aux.Descripcion = (string)datos.LectorDeDatos["Descripción"];
                    aux.Marca = new Elemento();
                    aux.Marca.Id = (int)datos.LectorDeDatos["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.LectorDeDatos["Marca"];
                    aux.Categoria = new Elemento();
                    aux.Categoria.Id = (int)datos.LectorDeDatos["IdCategoria"];
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
                //Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values ('G22', 'Motorola G22', 'Un buen telefono', 5, 1, '', 23550)
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                datos.setearParametro("@Codigo", nuevo.codArticulo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@ImagenUrl", nuevo.Imagen);
                datos.setearParametro("@Precio", nuevo.Precio);

                datos.ejecutarInsert();
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

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //update ARTICULOS set Codigo = 0, Nombre = '', Descripcion = '', IdMarca = 1, IdCategoria = 1, ImagenUrl = '', Precio = 0 Where Id = 0
                datos.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio Where Id = @Id");
                datos.setearParametro("@Codigo", articulo.codArticulo);
                datos.setearParametro("@Nombre", articulo.Nombre);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@IdMarca", articulo.Marca.Id);
                datos.setearParametro("@IdCategoria", articulo.Categoria.Id);
                datos.setearParametro("@ImagenUrl", articulo.Imagen);
                datos.setearParametro("@Precio", articulo.Precio);
                datos.setearParametro("@Id", articulo.Id);

                datos.ejecutarInsert();
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
    }
}

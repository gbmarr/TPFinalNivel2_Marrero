using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listar(string tabla)
        {
            List<Elemento> lista = new List<Elemento>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion From " + tabla + "");
                datos.ejecutarLectura();

                while (datos.LectorDeDatos.Read())
                {
                    Elemento aux = new Elemento();
                    aux.Id = (int)datos.LectorDeDatos["Id"];
                    aux.Descripcion = (string)datos.LectorDeDatos["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

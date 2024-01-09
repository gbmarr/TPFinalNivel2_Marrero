using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        //Código de artículo.
        //Nombre.
        //Descripción.
        //Marca(seleccionable de una lista desplegable).
        //Categoría(seleccionable de una lista desplegable.
        //Imagen.
        //Precio.
        public string codArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }
        public Decimal Precio { get; set; }
    }
}

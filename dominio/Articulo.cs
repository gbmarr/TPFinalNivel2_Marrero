using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int Id { get; set; }
        [DisplayName("Código")]
        public string codArticulo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public Elemento Marca { get; set; }
        [DisplayName("Categoría")]
        public Elemento Categoria { get; set; }
        public string Imagen { get; set; }
        public Decimal Precio { get; set; }
    }
}

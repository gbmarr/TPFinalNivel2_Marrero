using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Presentación
{
    public partial class frmDetalleDeArticulo : Form
    {
        private Articulo articulo = null;
        public frmDetalleDeArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalleDeArticulo_Load(object sender, EventArgs e)
        {
            lblDetalleCodigo.Text += " " + articulo.codArticulo;
            lblDetalleNombre.Text += " " + articulo.Nombre;
            lblDetalleDescripcion.Text += " " + articulo.Descripcion;
            lblDetalleMarca.Text += " " + articulo.Marca.Descripcion;
            lblDetalleCat.Text += " " + articulo.Categoria.Descripcion;
            cargarImagen(articulo.Imagen);
            lblDetallePrecio.Text += " $" + articulo.Precio;
        }
        private void cargarImagen(string img)
        {
            try
            {
                pbxDetalleImagen.Load(img);
            }
            catch (Exception ex)
            {
                pbxDetalleImagen.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }
    
    }
}

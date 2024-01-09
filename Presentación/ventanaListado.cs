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

namespace Presentación
{
    public partial class ventanaListado : Form
    {
        private List<Articulo> listaArticulos;
        public ventanaListado()
        {
            InitializeComponent();
        }

        private void ventanaListado_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articulos = new ArticuloNegocio();
            listaArticulos = articulos.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["Imagen"].Visible = false;
            cargarImagen(listaArticulos[0].Imagen);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo filaSeleccionada = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(filaSeleccionada.Imagen);
        }

        private void cargarImagen(string img)
        {
            try
            {
                pbxArticulo.Load(img);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }
    }
}

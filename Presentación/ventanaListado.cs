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
    public partial class ventanaListado : Form
    {
        private List<Articulo> listaArticulos;
        public ventanaListado()
        {
            InitializeComponent();
        }

        private void ventanaListado_Load(object sender, EventArgs e)
        {
            cargarDatos();
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
        private void cargarDatos()
        {
            ArticuloNegocio articulos = new ArticuloNegocio();
            try
            {
                listaArticulos = articulos.listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["Imagen"].Visible = false;
                dgvArticulos.Columns["ID"].Visible = false;
                cargarImagen(listaArticulos[0].Imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargarDatos();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro que quieres eliminar el registro?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

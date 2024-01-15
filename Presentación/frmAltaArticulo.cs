using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace Presentación
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar datos de articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                bool codigoValido = txtCodProducto.Text != "" && txtCodProducto.Text != null ? true : false;
                bool nombreValido = txtNombre.Text != "" && txtNombre.Text != null ? true : false;
                bool descValido = txtDescripcion.Text != "" && txtDescripcion.Text != null ? true : false;
                bool marcaValido = cbxMarca.SelectedItem.ToString() != "" && cbxMarca.SelectedItem != null ? true : false;
                bool categoriaValido = cbxCategoria.SelectedItem.ToString() != "" && cbxCategoria.SelectedItem != null ? true : false;
                bool imgValido = txtImagen.Text != "" && txtImagen.Text != null ? true : false;
                bool precioValido = txtPrecio.Text != "" && txtPrecio.Text != null ? true : false;


                if (codigoValido && nombreValido && descValido && marcaValido && categoriaValido && imgValido && precioValido)
                {
                    if (articulo == null)
                        articulo = new Articulo();

                    articulo.codArticulo = txtCodProducto.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.Marca = (Elemento)cbxMarca.SelectedItem;
                    articulo.Categoria = (Elemento)cbxCategoria.SelectedItem;
                    articulo.Imagen = txtImagen.Text;
                    articulo.Precio = Decimal.Parse(txtPrecio.Text);

                    if(articulo.Id != 0)
                    {
                        negocio.modificar(articulo);
                        MessageBox.Show("Modificado exitosamente");
                    }
                    else
                    {
                        negocio.agregar(articulo);
                        MessageBox.Show("Agregado exitosamente");
                    }

                    if (archivo != null && !(txtImagen.Text.ToUpper().Contains("HTTP")))
                        guardarImagen();

                    Close();
                }
                else
                {
                    lblAdvertencia.Text = "(complete todos los campos antes de 'Aceptar'";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            ElementoNegocio desplegable = new ElementoNegocio();
            try
            {
                cbxMarca.DataSource = desplegable.listar("MARCAS");
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCategoria.DataSource = desplegable.listar("CATEGORIAS");
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodProducto.Text = articulo.codArticulo.ToString();
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    txtImagen.Text = articulo.Imagen;
                    cargarImagen(articulo.Imagen);
                    txtPrecio.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void cargarImagen(string img)
        {
            try
            {
                pbxAltaProducto.Load(img);
            }
            catch (Exception ex)
            {
                pbxAltaProducto.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void btnAgregarIMG_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);


            }
        }

        private void guardarImagen()
        {
                File.Copy(archivo.FileName, ConfigurationManager.AppSettings["directorio-IMG"] + archivo.SafeFileName);
        }
    }
}

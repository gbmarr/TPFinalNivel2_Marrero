﻿using System;
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
            cargarCampos();
            btnFiltrarBusqueda.Enabled = false;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo filaSeleccionada = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(filaSeleccionada.Imagen);
            }
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
                ocultarColumnas();
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
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                modificar.ShowDialog();
                cargarDatos();
            }
            else
            {
                MessageBox.Show("No existen registros con el criterio " + txtFiltroRapido.Text + " para modificar.");
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string busqueda = txtFiltroRapido.Text;

            if(busqueda != "")
            {
                gbxFiltrarBusqueda.Enabled = false;
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(busqueda.ToUpper()) || x.Descripcion.ToUpper().Contains(busqueda.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(busqueda.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(busqueda.ToUpper()));
            }
            else
            {
                gbxFiltrarBusqueda.Enabled = true;
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;

            btnEliminar.Enabled = dgvArticulos.CurrentRow == null ? false : true;

            ocultarColumnas();
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["ID"].Visible = false;
        }

        private void cargarCampos()
        {
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Descripción");
            cbxCampo.Items.Add("Marca");
            cbxCampo.Items.Add("Categoría");
            cbxCampo.Items.Add("Precio");
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxCampo.SelectedItem != null)
            {
                string seleccionado = cbxCampo.SelectedItem.ToString();

            txtFiltroRapido.Enabled = cbxCampo.SelectedItem != null ? false : true;

                if(seleccionado == "Precio")
                {
                    cbxCriterio.Items.Clear();
                    cbxCriterio.Items.Add("Mayor a");
                    cbxCriterio.Items.Add("Menor a");
                    cbxCriterio.Items.Add("Igual a");
                }
                else
                {
                    cbxCriterio.Items.Clear();
                    cbxCriterio.Items.Add("Comienza con");
                    cbxCriterio.Items.Add("Termina con");
                    cbxCriterio.Items.Add("Contiene");
                }
            }
        }

        private void btnFiltrarBusqueda_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltrarBusqueda.Text;
                bool datosValidos = true;

                if(campo == "Precio")
                {
                    foreach (char letra in filtro)
                    {
                        if (!(char.IsNumber(letra)))
                        {
                            MessageBox.Show("El campo " + campo + " solo acepta números.");
                            datosValidos = false;
                            return;
                        }
                    }
                }
                if (datosValidos)
                {
                    dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
                    btnEliminar.Enabled = dgvArticulos.CurrentRow == null ? false : true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnResetBusqueda_Click(object sender, EventArgs e)
        {
            cbxCampo.SelectedItem = null;
            cbxCriterio.Items.Clear();
            txtFiltrarBusqueda.Text = "";
            txtFiltroRapido.Enabled = true;

            cargarDatos();

            if (dgvArticulos.CurrentRow != null)
                btnEliminar.Enabled = true;
        }

        private void txtFiltrarBusqueda_TextChanged(object sender, EventArgs e)
        {
            btnFiltrarBusqueda.Enabled = cbxCampo.SelectedItem != null && cbxCriterio.SelectedItem != null && (txtFiltrarBusqueda.Text != "" || txtFiltrarBusqueda.Text != null) ? true : false;
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmDetalleDeArticulo ventana = new frmDetalleDeArticulo(seleccionado);
                ventana.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un artículo para mostrar los detalles");
            }
        }
    }
}

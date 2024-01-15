
namespace Presentación
{
    partial class ventanaListado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.gbxFiltrarBusqueda = new System.Windows.Forms.GroupBox();
            this.btnResetBusqueda = new System.Windows.Forms.Button();
            this.btnFiltrarBusqueda = new System.Windows.Forms.Button();
            this.txtFiltrarBusqueda = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.gbxFiltrarBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 47);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(875, 312);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 365);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 35);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(103, 365);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 35);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(802, 365);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(1110, 365);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(141, 35);
            this.btnDetalle.TabIndex = 4;
            this.btnDetalle.Text = "Ver detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(925, 47);
            this.pbxArticulo.MaximumSize = new System.Drawing.Size(326, 312);
            this.pbxArticulo.MinimumSize = new System.Drawing.Size(326, 312);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Padding = new System.Windows.Forms.Padding(100);
            this.pbxArticulo.Size = new System.Drawing.Size(326, 312);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 5;
            this.pbxArticulo.TabStop = false;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Location = new System.Drawing.Point(12, 9);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(135, 17);
            this.lblListado.TabIndex = 6;
            this.lblListado.Text = "Listado de artículos:";
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Location = new System.Drawing.Point(674, 15);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(56, 17);
            this.lblFiltroRapido.TabIndex = 7;
            this.lblFiltroRapido.Text = "Buscar:";
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.Location = new System.Drawing.Point(736, 12);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(151, 22);
            this.txtFiltroRapido.TabIndex = 8;
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbxFiltrarBusqueda
            // 
            this.gbxFiltrarBusqueda.Controls.Add(this.btnResetBusqueda);
            this.gbxFiltrarBusqueda.Controls.Add(this.btnFiltrarBusqueda);
            this.gbxFiltrarBusqueda.Controls.Add(this.txtFiltrarBusqueda);
            this.gbxFiltrarBusqueda.Controls.Add(this.lblFiltro);
            this.gbxFiltrarBusqueda.Controls.Add(this.cbxCriterio);
            this.gbxFiltrarBusqueda.Controls.Add(this.lblCriterio);
            this.gbxFiltrarBusqueda.Controls.Add(this.lblCampo);
            this.gbxFiltrarBusqueda.Controls.Add(this.cbxCampo);
            this.gbxFiltrarBusqueda.Location = new System.Drawing.Point(12, 406);
            this.gbxFiltrarBusqueda.Name = "gbxFiltrarBusqueda";
            this.gbxFiltrarBusqueda.Size = new System.Drawing.Size(718, 121);
            this.gbxFiltrarBusqueda.TabIndex = 9;
            this.gbxFiltrarBusqueda.TabStop = false;
            this.gbxFiltrarBusqueda.Text = "Filtrar búsqueda:";
            // 
            // btnResetBusqueda
            // 
            this.btnResetBusqueda.Location = new System.Drawing.Point(577, 67);
            this.btnResetBusqueda.Name = "btnResetBusqueda";
            this.btnResetBusqueda.Size = new System.Drawing.Size(66, 24);
            this.btnResetBusqueda.TabIndex = 7;
            this.btnResetBusqueda.Text = "Reset";
            this.btnResetBusqueda.UseVisualStyleBackColor = true;
            this.btnResetBusqueda.Click += new System.EventHandler(this.btnResetBusqueda_Click);
            // 
            // btnFiltrarBusqueda
            // 
            this.btnFiltrarBusqueda.Location = new System.Drawing.Point(417, 67);
            this.btnFiltrarBusqueda.Name = "btnFiltrarBusqueda";
            this.btnFiltrarBusqueda.Size = new System.Drawing.Size(154, 24);
            this.btnFiltrarBusqueda.TabIndex = 6;
            this.btnFiltrarBusqueda.Text = "Buscar";
            this.btnFiltrarBusqueda.UseVisualStyleBackColor = true;
            this.btnFiltrarBusqueda.Click += new System.EventHandler(this.btnFiltrarBusqueda_Click);
            // 
            // txtFiltrarBusqueda
            // 
            this.txtFiltrarBusqueda.Location = new System.Drawing.Point(271, 67);
            this.txtFiltrarBusqueda.Name = "txtFiltrarBusqueda";
            this.txtFiltrarBusqueda.Size = new System.Drawing.Size(140, 22);
            this.txtFiltrarBusqueda.TabIndex = 5;
            this.txtFiltrarBusqueda.TextChanged += new System.EventHandler(this.txtFiltrarBusqueda_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(268, 44);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(43, 17);
            this.lblFiltro.TabIndex = 4;
            this.lblFiltro.Text = "Filtro:";
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(144, 67);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 24);
            this.cbxCriterio.TabIndex = 3;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(141, 44);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(57, 17);
            this.lblCriterio.TabIndex = 2;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(14, 44);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(56, 17);
            this.lblCampo.TabIndex = 1;
            this.lblCampo.Text = "Campo:";
            // 
            // cbxCampo
            // 
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(17, 67);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(121, 24);
            this.cbxCampo.TabIndex = 0;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // ventanaListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 539);
            this.Controls.Add(this.gbxFiltrarBusqueda);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.ventanaListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.gbxFiltrarBusqueda.ResumeLayout(false);
            this.gbxFiltrarBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.GroupBox gbxFiltrarBusqueda;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.TextBox txtFiltrarBusqueda;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Button btnFiltrarBusqueda;
        private System.Windows.Forms.Button btnResetBusqueda;
    }
}


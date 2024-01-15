
namespace Presentación
{
    partial class frmDetalleDeArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDetalleNombre = new System.Windows.Forms.Label();
            this.lblDetalleCodigo = new System.Windows.Forms.Label();
            this.lblDetalleDescripcion = new System.Windows.Forms.Label();
            this.lblDetalleMarca = new System.Windows.Forms.Label();
            this.lblDetalleCat = new System.Windows.Forms.Label();
            this.lblDetalleImagen = new System.Windows.Forms.Label();
            this.pbxDetalleImagen = new System.Windows.Forms.PictureBox();
            this.lblDetallePrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalleImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetalleNombre
            // 
            this.lblDetalleNombre.AutoSize = true;
            this.lblDetalleNombre.Location = new System.Drawing.Point(54, 85);
            this.lblDetalleNombre.Name = "lblDetalleNombre";
            this.lblDetalleNombre.Size = new System.Drawing.Size(62, 17);
            this.lblDetalleNombre.TabIndex = 0;
            this.lblDetalleNombre.Text = "Nombre:";
            // 
            // lblDetalleCodigo
            // 
            this.lblDetalleCodigo.AutoSize = true;
            this.lblDetalleCodigo.Location = new System.Drawing.Point(60, 54);
            this.lblDetalleCodigo.Name = "lblDetalleCodigo";
            this.lblDetalleCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblDetalleCodigo.TabIndex = 1;
            this.lblDetalleCodigo.Text = "Código:";
            // 
            // lblDetalleDescripcion
            // 
            this.lblDetalleDescripcion.AutoSize = true;
            this.lblDetalleDescripcion.Location = new System.Drawing.Point(30, 113);
            this.lblDetalleDescripcion.Name = "lblDetalleDescripcion";
            this.lblDetalleDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblDetalleDescripcion.TabIndex = 2;
            this.lblDetalleDescripcion.Text = "Descripción:";
            // 
            // lblDetalleMarca
            // 
            this.lblDetalleMarca.AutoSize = true;
            this.lblDetalleMarca.Location = new System.Drawing.Point(65, 142);
            this.lblDetalleMarca.Name = "lblDetalleMarca";
            this.lblDetalleMarca.Size = new System.Drawing.Size(51, 17);
            this.lblDetalleMarca.TabIndex = 3;
            this.lblDetalleMarca.Text = "Marca:";
            // 
            // lblDetalleCat
            // 
            this.lblDetalleCat.AutoSize = true;
            this.lblDetalleCat.Location = new System.Drawing.Point(43, 170);
            this.lblDetalleCat.Name = "lblDetalleCat";
            this.lblDetalleCat.Size = new System.Drawing.Size(73, 17);
            this.lblDetalleCat.TabIndex = 4;
            this.lblDetalleCat.Text = "Categoría:";
            // 
            // lblDetalleImagen
            // 
            this.lblDetalleImagen.AutoSize = true;
            this.lblDetalleImagen.Location = new System.Drawing.Point(58, 201);
            this.lblDetalleImagen.Name = "lblDetalleImagen";
            this.lblDetalleImagen.Size = new System.Drawing.Size(58, 17);
            this.lblDetalleImagen.TabIndex = 5;
            this.lblDetalleImagen.Text = "Imagen:";
            // 
            // pbxDetalleImagen
            // 
            this.pbxDetalleImagen.Location = new System.Drawing.Point(122, 201);
            this.pbxDetalleImagen.MaximumSize = new System.Drawing.Size(318, 276);
            this.pbxDetalleImagen.MinimumSize = new System.Drawing.Size(318, 276);
            this.pbxDetalleImagen.Name = "pbxDetalleImagen";
            this.pbxDetalleImagen.Padding = new System.Windows.Forms.Padding(100);
            this.pbxDetalleImagen.Size = new System.Drawing.Size(318, 276);
            this.pbxDetalleImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDetalleImagen.TabIndex = 6;
            this.pbxDetalleImagen.TabStop = false;
            // 
            // lblDetallePrecio
            // 
            this.lblDetallePrecio.AutoSize = true;
            this.lblDetallePrecio.Location = new System.Drawing.Point(58, 504);
            this.lblDetallePrecio.Name = "lblDetallePrecio";
            this.lblDetallePrecio.Size = new System.Drawing.Size(52, 17);
            this.lblDetallePrecio.TabIndex = 7;
            this.lblDetallePrecio.Text = "Precio:";
            // 
            // frmDetalleDeArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 535);
            this.Controls.Add(this.lblDetallePrecio);
            this.Controls.Add(this.pbxDetalleImagen);
            this.Controls.Add(this.lblDetalleImagen);
            this.Controls.Add(this.lblDetalleCat);
            this.Controls.Add(this.lblDetalleMarca);
            this.Controls.Add(this.lblDetalleDescripcion);
            this.Controls.Add(this.lblDetalleCodigo);
            this.Controls.Add(this.lblDetalleNombre);
            this.Name = "frmDetalleDeArticulo";
            this.Text = "frmDetalleDeArticulo";
            this.Load += new System.EventHandler(this.frmDetalleDeArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalleImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetalleNombre;
        private System.Windows.Forms.Label lblDetalleCodigo;
        private System.Windows.Forms.Label lblDetalleDescripcion;
        private System.Windows.Forms.Label lblDetalleMarca;
        private System.Windows.Forms.Label lblDetalleCat;
        private System.Windows.Forms.Label lblDetalleImagen;
        private System.Windows.Forms.PictureBox pbxDetalleImagen;
        private System.Windows.Forms.Label lblDetallePrecio;
    }
}
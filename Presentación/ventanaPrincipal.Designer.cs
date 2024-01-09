
namespace Presentación
{
    partial class ventanaPrincipal
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
            this.pbxImgPresentacion = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgPresentacion)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImgPresentacion
            // 
            this.pbxImgPresentacion.Location = new System.Drawing.Point(50, 12);
            this.pbxImgPresentacion.MaximumSize = new System.Drawing.Size(442, 426);
            this.pbxImgPresentacion.MinimumSize = new System.Drawing.Size(442, 426);
            this.pbxImgPresentacion.Name = "pbxImgPresentacion";
            this.pbxImgPresentacion.Size = new System.Drawing.Size(442, 426);
            this.pbxImgPresentacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImgPresentacion.TabIndex = 0;
            this.pbxImgPresentacion.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(547, 357);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(172, 52);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // ventanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.pbxImgPresentacion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "ventanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidx";
            this.Load += new System.EventHandler(this.ventanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgPresentacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImgPresentacion;
        private System.Windows.Forms.Button btnIngresar;
    }
}
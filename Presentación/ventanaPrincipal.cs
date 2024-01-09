using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class ventanaPrincipal : Form
    {
        public ventanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ventanaListado ventanaListado = new ventanaListado();
            ventanaListado.ShowDialog();
        }

        private void ventanaPrincipal_Load(object sender, EventArgs e)
        {
            pbxImgPresentacion.Load("https://img.freepik.com/vector-gratis/ilustracion-concepto-casillas-verificacion_114360-2465.jpg");
        }
    }
}

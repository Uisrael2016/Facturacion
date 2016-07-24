using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion_Vista.Vistas.Agregar
{
    public partial class FrmProducto : DevComponents.DotNetBar.Office2007Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {

        }
    }
}

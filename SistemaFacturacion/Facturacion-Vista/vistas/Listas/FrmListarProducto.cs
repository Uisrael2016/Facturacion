using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_Vista.Vistas.Agregar;

namespace Facturacion_Vista.Vistas.Listas
{
    public partial class FrmListarProducto : DevComponents.DotNetBar.Office2007Form
    {
        public FrmListarProducto()
        {
            InitializeComponent();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            frm.ShowDialog();
        }
    }
}

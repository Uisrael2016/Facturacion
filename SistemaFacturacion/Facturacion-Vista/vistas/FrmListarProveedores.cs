using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion_Vista.Vistas
{
    public partial class FrmListarProveedores : DevComponents.DotNetBar.Office2007Form
    {
        public FrmListarProveedores()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            FrmProveedores frmproveedores = new FrmProveedores();
            frmproveedores.ShowDialog();
        }
    }
}

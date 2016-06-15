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
    public partial class FrmListarMaterial : DevComponents.DotNetBar.Office2007Form
    {
        public FrmListarMaterial()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            FrmMaterial frm = new FrmMaterial();
            frm.ShowDialog();
        }
    }
}

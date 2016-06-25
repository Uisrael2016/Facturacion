using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion_Vista.Vistas
{
    public partial class MDIMenu : DevComponents.DotNetBar.Office2007RibbonForm
    {


        public MDIMenu()
        {
            InitializeComponent();
        }

        private void buttonItem26_Click(object sender, EventArgs e)
        {
            FrmListarCliente listcliente = new FrmListarCliente();
            listcliente.ShowDialog();
        }
        private void itemEmpresa_Click(object sender, EventArgs e)
        {
            FrmEmpresa empresa = new FrmEmpresa(Utilidades.Acciones.update);
            empresa.ShowDialog();
        }

        private void itemMaterial_Click(object sender, EventArgs e)
        {
            FrmListarMaterial frm = new FrmListarMaterial();
            frm.ShowDialog();
        }

        private void itemProveedor_Click(object sender, EventArgs e)
        {
            FrmListarProveedores frm = new FrmListarProveedores();
            frm.ShowDialog();
        }
    }
}

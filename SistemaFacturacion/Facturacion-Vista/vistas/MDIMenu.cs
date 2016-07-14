using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;using System.Text;
using Facturacion_Vista.Vistas.transaccion;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_Vista.Vistas.Listas;

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
            FrmListarCliente listcliente = new FrmListarCliente(0);
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

        private void itemUsuarios_Click(object sender, EventArgs e)
        {
            FrmListarUsuario frm = new FrmListarUsuario();
            frm.ShowDialog();
        }

        private void itemProforma_Click(object sender, EventArgs e)
        {
            FrmProforma frm = new FrmProforma();
            frm.ShowDialog();
        }

        private void itemSecuencial_Click(object sender, EventArgs e)
        {
            FrmListarSecuencial frm = new FrmListarSecuencial(0);
            frm.ShowDialog();
        }
    }
}

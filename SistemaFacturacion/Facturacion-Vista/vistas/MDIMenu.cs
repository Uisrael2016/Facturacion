using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;using System.Text;
using Facturacion_Vista.Vistas.transacciones;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_Vista.Vistas.Listas;
using Facturacion_Vista.Vistas.Agregar;

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
            FrmListarUsuario frm = new FrmListarUsuario(0);
            frm.ShowDialog();
        }

        private void itemUsuarioPerfil_Click(object sender, EventArgs e)
        {
            FrmUsuarioPerfil frm = new FrmUsuarioPerfil();
            frm.ShowDialog();
        }

        private void itemDocContables_Click(object sender, EventArgs e)
        {
            FrmListarCodigo_Documento frm = new FrmListarCodigo_Documento(0);
            frm.ShowDialog();

        }

        private void itemTarifa_Click(object sender, EventArgs e)
        {
            FrmListaTarifa frm = new FrmListaTarifa();
            frm.ShowDialog();
        }

        private void itemProducto_Click(object sender, EventArgs e)
        {
            FrmListarProducto frm = new FrmListarProducto(0);
            frm.ShowDialog();
        }

        private void itemNotaPedido_Click(object sender, EventArgs e)
        {
            FrmNotaPedido frm = new FrmNotaPedido(0);
            frm.ShowDialog();
        }

        private void itemPerfiles_Click(object sender, EventArgs e)
        {
            FrmListarPerfl frm = new FrmListarPerfl(0);
            frm.ShowDialog();
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            FrmListarTipoMaterial frm = new FrmListarTipoMaterial(0);
            frm.ShowDialog();
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            FrmListarEstablecimiento frm = new FrmListarEstablecimiento(0);
            frm.ShowDialog();
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            FrmListarPuntoEmision frm = new FrmListarPuntoEmision(0);
            frm.ShowDialog();
        }
    }
}

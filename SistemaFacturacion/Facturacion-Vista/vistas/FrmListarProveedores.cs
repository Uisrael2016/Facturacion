using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_Entidades;
using Facturacion_AccesoDatos.conexion;
using Facturacion_AccesoDatos.dao;
using Facturacion_Vista.Vistas;
namespace Facturacion_Vista.Vistas
{
    public partial class FrmListarProveedores : DevComponents.DotNetBar.Office2007Form
    {
        private ProveedorDao proveedorDao = new ProveedorDao();
        private List<Proveedor> listaProveedor;
        public FrmListarProveedores()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            FrmProveedores frmproveedores = new FrmProveedores(0);
            frmproveedores.ShowDialog();
        }

        private void listarProveedor ()
        {
            proveedorDao = new ProveedorDao();
            listaProveedor = (List<Proveedor>)proveedorDao.consultar();
            if(listaProveedor!=null)
            {
                dtlista.Rows.Clear();
                foreach(Proveedor pro in listaProveedor)
                {
                    dtlista.Rows.Add(pro.IdProveedor, pro.Documento, pro.RazonSocial, pro.Direccion, pro.Telefono);

                }
            }
        }
        private void dtlista_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

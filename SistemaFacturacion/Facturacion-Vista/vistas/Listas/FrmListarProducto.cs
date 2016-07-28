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
using Facturacion_Vista.Utilidades;
using Facturacion_AccesoDatos;
using Facturacion_Entidades;
using Facturacion_AccesoDatos.dao;
namespace Facturacion_Vista.Vistas.Listas
{
    public partial class FrmListarProducto : DevComponents.DotNetBar.Office2007Form
    {
        private ProductoDao productoDao = new ProductoDao();
        private List<Producto> listaProducto;
        Acciones _accion;
        public Producto productoSeleccionado { get; set; }
        public FrmListarProducto(Acciones a)
        {
            InitializeComponent();
            this._accion =a;
            this.listarProducto();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto(0);
            frm.ShowDialog();
            listarProducto();
        }
        private void listarProducto()
        {
            productoDao = new ProductoDao();
            listaProducto = (List<Producto>)productoDao.consultar();
            if(listaProducto!=null)
            {
                dtlista.Rows.Clear();
                foreach(Producto prod in listaProducto)
                {
                    dtlista.Rows.Add(prod.IdProducto, prod.Tipo, prod.Precio,prod.Descuento, prod.DescProducto);
                }
            }
        }

        private void dtlista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_accion != Acciones.inject)
            {
                int id = Convert.ToInt32(dtlista.CurrentRow.Cells[0].Value);
                FrmProducto frm = new FrmProducto(id);
                frm.ShowDialog();
                listarProducto();
            }
            else
            {
                int id = Convert.ToInt32(dtlista.CurrentRow.Cells[0].Value);
                ProductoDao dao = new ProductoDao();
                productoSeleccionado = dao.consultarPorId(id);
                this.Hide();
            }
        }
    }
}

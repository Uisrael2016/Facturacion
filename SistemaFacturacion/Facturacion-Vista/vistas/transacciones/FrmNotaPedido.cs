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
using Facturacion_Vista.Vistas.Agregar;
using Facturacion_Vista.Vistas.Listas;
namespace Facturacion_Vista.Vistas.transacciones
   
{
    public partial class FrmNotaPedido : DevComponents.DotNetBar.Office2007Form
    {
        public FrmNotaPedido()
        {
            InitializeComponent();
        }

        private void btagregar_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            
        }
        private void setGroup(Cliente c)
        {
            textCliente.Text = c.Nombres + " " + c.Apellidos;
            textRuc.Text = c.DocumentoCliente;
            textDireccion.Text = c.Direccion;
            textTlf.Text = c.Telefono;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmListarCliente frml = new FrmListarCliente(Utilidades.Acciones.inject);
            frml.ShowDialog();
            if (frml.clienteSeleccionado != null)
            {
                Cliente cliente = frml.clienteSeleccionado;
                setGroup(cliente);
            }
        }
        private void setGrouppro(Producto p)
        {
            txtDetalle.Text = p.DescProducto;

        }
        private void btBuscar_Click(object sender, EventArgs e)
        {
            //FrmListarProducto frml = new FrmListarProducto(Utilidades.Acciones.inject);
            //frml.ShowDialog();
            //if (frml.productoSeleccionado != null)
            //{
            //    Producto producto = frml.productoSeleccionado;
            //    setGrouppro(producto);
            //}
        }
    }
}

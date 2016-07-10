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
namespace Facturacion_Vista.Vistas.transaccion
{
    public partial class FrmProforma : DevComponents.DotNetBar.Office2007Form
    {
        private Cliente clienteSeleccionado;
        private Producto productoSeleccionado;
        public FrmProforma()
        {
            InitializeComponent();
            textFechaEmision.Text = new DateTime().ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente(0);
            frm.ShowDialog();
            if (frm.clienteSeleccionado != null)
            {
                Cliente cliente = frm.clienteSeleccionado;
                setGroup(cliente);
            }
            
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
    }
}

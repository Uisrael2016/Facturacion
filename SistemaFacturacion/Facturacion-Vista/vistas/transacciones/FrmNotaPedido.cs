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
using Facturacion_Vista.Utilidades;
using DevComponents.DotNetBar;
namespace Facturacion_Vista.Vistas.transacciones
 
{
    public partial class FrmNotaPedido : DevComponents.DotNetBar.Office2007Form
    {
        double preciopro ;
        double cantidadpro ;
        double total;
      
        public FrmNotaPedido()
        {
            InitializeComponent();
        }
        
        private void btagregar_Click(object sender, EventArgs e)
        {
             preciopro = Convert.ToDouble(txtPrecio.Text);
            cantidadpro = Convert.ToDouble(txtcantidad.Text);

            int bandera = 0;

                for (int fila = 0; fila < dtdocumento.Rows.Count; fila++)
                {
                    if (dtdocumento.Rows[fila].Cells["desc_producto"].Value.ToString() == this.txtDetalle.Text)
                    {
                        bandera = 1;
                    }
                }

                if (bandera == 1)
                {
                    Mensaje.mensajeError("Error", "Error este producto ya fue ingresado");
                }

                else
                {
                    if (String.IsNullOrWhiteSpace(this.txtDetalle.Text) ||
                        (String.IsNullOrWhiteSpace(this.txtPrecio.Text)) ||
                        (String.IsNullOrWhiteSpace(this.txtcantidad.Text)))
                    {
                        Mensaje.mensajeError("Error", "No se puede dejar campos vacios");
                    }

                    else if (cantidadpro == 0)
                    {
                        Mensaje.mensajeError("Error", "La Cantidad no puede ser igual a 0");
                    }
                                       
                    else
                    {
                        this.dtdocumento.Rows.Add("", this.txtDetalle.Text,
                        cantidadpro, preciopro.ToString("0.00## $"),
                        total.ToString("0.00## $"));
                    this.txtDetalle.Text = String.Empty;
                    this.txtcantidad.Text = Convert.ToString( 0);
                    this.txtPrecio.Text = Convert.ToString(0);
                    this.txttotal.Text = Convert.ToString(0);




                }
                }
            
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
            txtPrecio.Text = Convert.ToString(p.Precio);
           
        }
        private void btBuscar_Click(object sender, EventArgs e)
        {
            FrmListarProducto frml = new FrmListarProducto(Utilidades.Acciones.inject);
            frml.ShowDialog();
            if (frml.productoSeleccionado != null)
            {
               Producto producto = frml.productoSeleccionado;
                setGrouppro(producto);
            }
        }

        private void btguardar_Click(object sender, EventArgs e)
        {

        }

       

        private void dtdocumento_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            this.dtdocumento.Rows[e.RowIndex].Cells[0].Value=(e.RowIndex+1).ToString();
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
            {
            preciopro = Convert.ToDouble(txtPrecio.Text);
           cantidadpro = Convert.ToDouble(txtcantidad.Text);
            total = preciopro * cantidadpro;
            txttotal.Text = Convert.ToString(total);

        }

        private void dtdocumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btresta_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtdocumento.Rows.Count) > 0)
            {
                this.dtdocumento.Rows.Remove(this.dtdocumento.Rows[this.dtdocumento.CurrentRow.Index]);
            }

            else
            {
                Mensaje.mensajeError("Error","Debes seleccionar una fila para eliminar");
            }
        }
        private void subtotalpro()
        {
            double subtotal = 0 ;
            foreach (DataGridViewRow row in dtdocumento.Rows)
            {
                subtotal += Convert.ToDouble(row.Cells["total_sin_impuesto"].Value);
            }
            txtsubtotal.Text = Convert.ToString(subtotal);
        }
        private void dtdocumento_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.subtotalpro();
        }
    }
}

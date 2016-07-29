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
        private Producto nuevoproducto;
        //private List<DetalleProducto> listaDetpro;
        private List<Producto> listaProducto;
        private int _idproducto;
        double cantidadpro  ;
        double totalprecio ;
        double subtotalproducto ;
        public FrmNotaPedido(int id)
        {            
            InitializeComponent();
            _idproducto = id;
            listaProducto = new List<Producto>();
            
            
        }        
        
        private void btagregar_Click(object sender, EventArgs e)
        {

           // if (nuevoproducto != null)
            //{
                listaProducto.Add(nuevoproducto);
               // listaProducto.Add(nuevaSalida);
                reset();
                listarProducto();
            //}
            //else
            //{
            //    Mensaje.mensajeAlerta("Información", "Escojer un detalle de producto");
            //}
        }
        private void listarProducto()
        {

            
            if (listaProducto != null)
            {
                dtdocumento.Rows.Clear();
                int cont = 1;
                foreach (Producto det in listaProducto)
                {                           
                    dtdocumento.Rows.Add(cont,det.DescProducto,this.txtcantidad,det.Precio);
                    cont++;               
                }
            }
            reset();
            
        }
        private void reset()
        {
            txtDetalle.Text = string.Empty;
            this.txtcantidad.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            nuevoproducto = null;
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
        private void setGrouppro(Producto pro)
        {
            txtDetalle.Text = pro.DescProducto;
            txtdescuento.Text = Convert.ToString( pro.Descuento);
            txtPrecio.Text = Convert.ToString( pro.Precio);           
        }
             
       
                      
      
        private void btresta_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtdocumento.Rows.Count) > 0)
            {
                int id = Convert.ToInt32(dtdocumento.CurrentRow.Cells[0].Value);
                this.dtdocumento.Rows.Remove(this.dtdocumento.Rows[this.dtdocumento.CurrentRow.Index]);
                listaProducto.RemoveAt(id - 1);

            }

            else
            {
                Mensaje.mensajeError("Error", "Debes seleccionar una fila para eliminar");
            }
        }
        
        private void btBuscar_Click_1(object sender, EventArgs e)
        {
            FrmListarProducto frml = new FrmListarProducto(Acciones.inject);
            frml.ShowDialog();
            if (frml.productoSeleccionado != null)
            {
                Producto producto = frml.productoSeleccionado;
                setGrouppro (producto);
            }

        }

        private void dtdocumento_RowDefaultCellStyleChanged(object sender, DataGridViewRowEventArgs e)
        {
        }
    }
}

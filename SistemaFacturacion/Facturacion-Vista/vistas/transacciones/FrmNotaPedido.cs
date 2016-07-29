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
        private DetalleProducto nuevo;
        private List<DetalleProducto> listaDetpro;
        double cantidadpro  ;
        double totalprecio ;
        double subtotalproducto ;
        public FrmNotaPedido(int id)
        {            
            InitializeComponent();
            listaDetpro = new List<DetalleProducto>();
            
        }        
        
        private void btagregar_Click(object sender, EventArgs e)
        {
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
                if (nuevo != null)
                {
                    listaDetpro.Add(nuevo);
                    listarProducto();
                    //reset();

                }
                else
                {
                    Mensaje.mensajeAlerta("Información", "Escojer un detalle de producto");
                }
            }
           
        }
        private void listarProducto()
        {

            
            if (listaDetpro != null)
            {
                dtdocumento.Rows.Clear();
                int cont = 1;
                foreach (DetalleProducto det in listaDetpro)
                {
                    
                    cantidadpro = Convert.ToDouble(txtcantidad.Text);
                    totalprecio = cantidadpro * det.IdProducto.Precio;
                    txtsubtotal.Text = Convert.ToString(subtotalproducto);
                    subtotalproducto += totalprecio;
                    dtdocumento.Rows.Add(cont,det.IdProducto.DescProducto,cantidadpro,det.IdProducto.Precio.ToString("0.00## $"),this.totalprecio.ToString("0.00## $"));
                    cont++;                  
                    txtsubtotal.Text = Convert.ToString(subtotalproducto.ToString("0.00## $"));
                    
                }
            }
            reset();
            
        }
        private void reset()
        {
            txtDetalle.Text = string.Empty;
            this.txtcantidad.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            nuevo = null;
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
        private void setGrouppro(DetalleProducto det)
        {
            txtDetalle.Text = det.IdProducto.DescProducto;
            txtPrecio.Text = Convert.ToString(det.IdProducto.Precio);
           
        }
             
       
                      
      
        private void btresta_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtdocumento.Rows.Count) > 0)
            {
                int id = Convert.ToInt32(dtdocumento.CurrentRow.Cells[0].Value);
                this.dtdocumento.Rows.Remove(this.dtdocumento.Rows[this.dtdocumento.CurrentRow.Index]);
                listaDetpro.RemoveAt(id - 1);

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
            if (frml.detaleproducoSeleccionado != null)
            {
                nuevo = new DetalleProducto();
                nuevo = frml.detaleproducoSeleccionado;
               setGrouppro(nuevo);
            }

        }

        private void dtdocumento_RowDefaultCellStyleChanged(object sender, DataGridViewRowEventArgs e)
        {
        }
    }
}

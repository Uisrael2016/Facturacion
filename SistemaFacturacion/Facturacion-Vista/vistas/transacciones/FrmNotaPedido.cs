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
using Facturacion_AccesoDatos.dao;
namespace Facturacion_Vista.Vistas.transacciones

{
    public partial class FrmNotaPedido : DevComponents.DotNetBar.Office2007Form
    {
        private Detalle detalle;
        //private List<DetalleProducto> listaDetpro;
        private List<Detalle> listaDetalleFactura;
        private Producto producto;
        private Cabecera cabecera;
        private TarifaDao tarifaDao;
        private int _idproducto;
        private Tarifa _tarifa;
        private Cliente cliente;
        private CodigoDocumento codigoDocumento;
        private CodigoDocumentoDao codigoDao;
        private CabeceraDao cabeceraDao;
        private string codigo;
        private int idEntidad;
        double subtotal = 0;
        double descuento = 0;
        double subdescuento = 0;
        double iva = 0;
        double total;
        double subtotalSinIva = 0;
        public FrmNotaPedido(String tipo, int id)
        {

            InitializeComponent();
            listaDetalleFactura = new List<Detalle>();
            cabecera = new Cabecera();
            _tarifa = new Tarifa();
            tarifaDao = new TarifaDao();
            codigoDocumento = new CodigoDocumento();
            codigoDao = new CodigoDocumentoDao();
            cabeceraDao = new CabeceraDao();
            tarifaActual();
            this.codigo = tipo;
            cargaCodigo();
            if (id > 0)
            {
                this.idEntidad = id;
                cabecera = cabeceraDao.consultarPorId(idEntidad);
                cliente = new Cliente();
                cliente = cabecera.IdCliente;
                if (cabecera != null)
                {
                    setGroup(cabecera.IdCliente);
                    DetalleDao dao = new DetalleDao();
                    listaDetalleFactura = dao.listaDetalle(cabecera.IdCabecera);
                    //foreach (Detalle det in cabecera.DetalleList)
                    //{
                    //    listaDetalleFactura.Add(det);
                    //}
                    listarGrid();
                }
            }


        }
        private void cargaCodigo()
        {
            try
            {
                codigoDocumento = codigoDao.buscaCodigoDocumento(this.codigo);
                lbCodigo.Text = codigoDocumento.Codigo + "-" + "000" + "-" + codigoDocumento.Secuencial;
            }
            catch (Exception ex)
            {
            }
        }
        private void tarifaActual()
        {
            try
            {
                _tarifa = tarifaDao.buscaTarifa();
            }
            catch (Exception ex)
            {

            }
        }
        private void btagregar_Click(object sender, EventArgs e)
        {
            if (producto != null)
            {
                if (txtcantidad.Text.Trim() != "" && txtcantidad.Text.Trim() != "0")
                {
                    detalle = new Detalle();
                    detalle.IdProducto = producto;
                    detalle.Cantidad = Convert.ToInt32(txtcantidad.Text);
                    detalle.PrecioTotal = detalle.Cantidad * producto.Precio;
                    listaDetalleFactura.Add(detalle);
                    listarGrid();
                    reset();

                }
                else
                {
                    Mensaje.mensajeAlerta("Información", "Debe ingresar al menos una cantidad");
                }

            }
            else
            {
                Mensaje.mensajeAlerta("Información", "Debe ingresar un producto");
            }

        }

        private void listarGrid()
        {
            int cont = 1;
            dtdocumento.Rows.Clear();
            foreach (Detalle det in listaDetalleFactura)
            {
                subtotal += det.PrecioTotal;
                dtdocumento.Rows.Add(cont, det.IdProducto.DescProducto, det.Cantidad, det.IdProducto.Precio, det.PrecioTotal);
                cont++;
            }

            if (txtdescuento.Text.Trim() != string.Empty)
            {
                descuento = Convert.ToDouble(txtdescuento.Text);
            }
            else
            {
                descuento = 0;
            }

            subdescuento = Math.Round((subtotal * descuento) / 100, 2);

            subtotalSinIva = subtotal - subdescuento;

            iva = Math.Round((subtotalSinIva * _tarifa.ValTarifa) / 100, 2);

            total = subtotalSinIva + iva;


            textSubtotal.Text = Convert.ToString(subtotal);
            textDescuentoFat.Text = Convert.ToString(subdescuento);
            textIva.Text = Convert.ToString(iva);
            textTotal.Text = Convert.ToString(total);
            lblDescuento.Text = "Descuento" + " " + "%" + descuento;
            lblIva.Text = "IVA" + " " + "%" + _tarifa.ValTarifa;
        }
        private void reset()
        {
            txtDetalle.Text = string.Empty;
            this.txtcantidad.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtdescuento.Text = string.Empty;
            detalle = null;
            producto = null;
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
                cliente = new Cliente();
                cliente = frml.clienteSeleccionado;
                setGroup(cliente);
            }
        }

        private void btresta_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtdocumento.Rows.Count) > 0)
            {
                int id = Convert.ToInt32(dtdocumento.CurrentRow.Cells[0].Value);
                this.dtdocumento.Rows.Remove(this.dtdocumento.Rows[this.dtdocumento.CurrentRow.Index]);
                listaDetalleFactura.RemoveAt(id - 1);
                listarGrid();
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
                producto = new Producto();
                producto = frml.productoSeleccionado;
                txtDetalle.Text = producto.DescProducto;
                txtPrecio.Text = Convert.ToString(producto.Precio);
                pictureProducto.Load(producto.Imagen);
            }

        }

        private void dtdocumento_RowDefaultCellStyleChanged(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void dtdocumento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void setCabecera(string estado)
        {
            EmpresaDao empresaDao = new EmpresaDao();
            Empresa empresa = new Empresa();
            empresa = empresaDao.buscaEmpresa();
            FormaPago formaPago = new FormaPago();
            FormaPagoDao daoPago = new FormaPagoDao();
            formaPago = daoPago.consultarPorId(1);
            cabecera.Estado = "PA";
            cabeceraDao.modificar(cabecera);
            if (codigo == "FC") {
                cabecera = new Cabecera();
            }
            cabecera.Secuencial = codigoDocumento.Secuencial;
            cabecera.IdEmpresa = empresa;
            cabecera.IdFormaPago = formaPago;
            cabecera.IdCodigoDocumento = codigoDocumento;
            cabecera.IdUsuarioPerfil = Login.usuarioPerfilManager;
            cabecera.IdCliente = cliente;
            cabecera.FechaEmision = DateTime.Now;
            cabecera.TotalSinImpuesto = this.subtotal;
            cabecera.TotalDescuento = this.subdescuento;
            cabecera.Propina = 0;
            cabecera.Total = this.total;
            cabecera.Moneda = "DOLAR";
            cabecera.Estado = estado;
        }
        private void setImpuesto()
        {
            Impuesto im = new Impuesto();
            im.BaseImponible = iva;
            im.IdTarifa = _tarifa;
            im.IdCabecera = cabecera;
            im.Valor = _tarifa.ValTarifa;
            im.Codigo = "2";
            im.CodigoPorcentaje = "2";
            ImpuestoDao imDao = new ImpuestoDao();
            imDao.insertar(im);
        }
        private void btguardar_Click(object sender, EventArgs e)
        {
            if (cliente != null)
            {
                if (listaDetalleFactura.Count != 0)
                {
                    try
                    {
                        SriDao sriDao = new SriDao();
                        DetalleDao detalleDao = new DetalleDao();
                        if (this.codigo == "NP")
                        {
                            setCabecera("IN");
                            cabeceraDao.insertar(cabecera);
                            codigoDocumento.Secuencial = codigoDocumento.Secuencial + 1;
                            codigoDao.modificar(codigoDocumento);
                            foreach (Detalle det in listaDetalleFactura)
                            {
                                det.IdCabecera = cabecera;
                                detalleDao.insertar(det);
                            }
                            setImpuesto();
                        }
                        else
                        {
                            setCabecera("PA");
                            cabeceraDao.insertar(cabecera);
                            foreach (Detalle det in listaDetalleFactura)
                            {
                                det.IdCabecera = cabecera;
                                detalleDao.insertar(det);
                            }
                            Sri sri = new Sri();
                            sri.IdCabecera = cabecera;
                            sri.MensajeError = string.Empty;
                            sri.Autorizacion= string.Empty;
                            sri.ClaveAcceso = string.Empty;
                            sri.CodigoError = string.Empty;

                            sriDao.insertar(sri);
                            setImpuesto();
                            codigoDocumento.Secuencial = codigoDocumento.Secuencial + 1;
                            codigoDao.modificar(codigoDocumento);
                        }

                        Mensaje.mensajeInformacion("Información",codigoDocumento.Documento+" "+"ingresada exitisomente");
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        Mensaje.mensajeError("Información", codigoDocumento.Documento +" "+"fallo al ingresar");
                    }



                }
                else
                {
                    Mensaje.mensajeAlerta("Información", "No existe ningun detalle");
                }
            }
            else
            {
                Mensaje.mensajeAlerta("Información", "Debe seleccionar un cliente");
            }
        }
    }
}

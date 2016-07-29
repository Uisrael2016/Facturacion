using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_Vista.Utilidades;
using Facturacion_AccesoDatos.dao;
using Facturacion_Entidades;

namespace Facturacion_Vista.Vistas.Agregar
{
    public partial class FrmProducto : DevComponents.DotNetBar.Office2007Form
    {
        private string pathFile;
        private int idProducto = 0;
        private Acciones _accion;
        private ProductoDao productoDao;
        private DetalleProductoDao detalleDao;
        private SalidaDao salidaDao;
        public Producto productoSeleccionado { get; set; }
        private string valor;
        private DetalleProducto nuevoDetalle;
        private Salida nuevaSalida;
        private List<DetalleProducto> listaDetalle;
        private List<Salida> listaSalida;
        private Material materialSeleccionado { get; set; }
        private double valorSalida;
        private double valorStock;
        private MaterialDao materialDao;
        public FrmProducto(int id)
        {
            InitializeComponent();
            this.idProducto = id;
            listaDetalle = new List<DetalleProducto>();
            listaSalida = new List<Salida>();
            productoDao = new ProductoDao();
            salidaDao = new SalidaDao();
            detalleDao = new DetalleProductoDao();
            materialDao = new MaterialDao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog buscaImagen = new OpenFileDialog();
                buscaImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                buscaImagen.Filter = "Image files (*.jpg, *.jpeg,*.png) | *.jpg; *.jpeg; *.png";
                buscaImagen.FileName = "";
                buscaImagen.Title = "Imagen de Producto";
                if (buscaImagen.ShowDialog(this) == DialogResult.OK)
                {
                    pathFile = buscaImagen.FileName;
                    if (pathFile.Equals("") == false)
                    {
                        pictureProducto.Load(pathFile);

                    }


                }

            }
            catch (Exception ex)
            {
                Mensaje.mensajeError("Error", "No se pudo cargar" + ex.ToString());
            }



        }
        public void setproducto()
        {
            if (_accion == Acciones.insert)
            {
                productoSeleccionado = new Producto();
            }
            productoSeleccionado.DescProducto = textDescPro.Text.ToUpper();
            if (comboTipoPro.SelectedItem == comboItem1)
            {
                valor = Convert.ToString('N');
            }
            else
            {
                valor = Convert.ToString('M');
            }

            productoSeleccionado.Tipo = Convert.ToChar(valor);
            productoSeleccionado.Imagen = pathFile;
            productoSeleccionado.Precio = Convert.ToDouble(textPrecio.Text);
            productoSeleccionado.Descuento = Convert.ToDouble(textDescuento.Text);

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (General.validaFormGroup(this.Controls, erroricono))
            {
                if (comboTipoPro.SelectedIndex != 0)
                {
                    setproducto();
                    if (_accion == Acciones.insert)
                    {
                       productoDao.insertar(productoSeleccionado);
                    }
                    foreach (DetalleProducto det in listaDetalle) {
                        det.IdProducto = productoSeleccionado;
                        detalleDao.insertar(det);

                    }
                    
                    foreach (Salida sali in listaSalida) {
                        valorSalida += sali.CantidadEgreso;
                        Material material = sali.IdMaterial;
                        material.Stock = material.Stock - valorSalida;
                        materialDao.modificar(material);
                        salidaDao.insertar(sali);
                    }
                }
                else
                {
                    Mensaje.mensajeAlerta("Informacion", "Seleccione un Tipo");
                }
                Mensaje.mensajeConfirm("Informacion", "Agregado con Exito");
                this.Hide();
            }


        }



        private void btnDetalle_Click_1(object sender, EventArgs e)
        {
            FrmDetalleProducto frm = new FrmDetalleProducto(Acciones.inject);
            frm.ShowDialog();
            if (frm.detproductoSeleccionado != null)
            {
                nuevoDetalle = new DetalleProducto();
                nuevoDetalle = frm.detproductoSeleccionado;
                
                nuevaSalida = new Salida();
                nuevaSalida = frm.salida;
                materialSeleccionado = frm._material;
                valorStock += nuevoDetalle.Cantidad;
                if (valorStock > materialSeleccionado.Stock)
                {                    
                    Mensaje.mensajeAlerta("Informacion", "No existe suficiente stock para realizar el pedido");
                    reset();
                    return;

                }
                else {
                    nuevoDetalle.IdMaterial = materialSeleccionado;
                    textDescripcion.Text = nuevoDetalle.DescDetalle;
                    textCantidadDetalle.Text = Convert.ToString(nuevoDetalle.Cantidad);
                }
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (nuevoDetalle != null)
            {
                listaDetalle.Add(nuevoDetalle);
                listaSalida.Add(nuevaSalida);
                reset();
                listarDetalle();
            }
            else
            {
                Mensaje.mensajeAlerta("Información", "Escojer un detalle de producto");
            }
        }
        private void listarDetalle()
        {
            if (listaDetalle != null)
            {
                dtListaDetalle.Rows.Clear();

                double suma = 0;
                int cont = 1;
                foreach (DetalleProducto det in listaDetalle)
                {
                    suma += det.Cantidad;
                    dtListaDetalle.Rows.Add(cont, det.IdMaterial.Descripcion, det.DescDetalle, det.Cantidad, det.Color);
                    Console.WriteLine(suma.ToString());
                    cont++;
                }
            }
        }

        private void reset()
        {
            textDescripcion.Text = string.Empty;
            textCantidadDetalle.Text = string.Empty;
            nuevoDetalle = null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtListaDetalle.Rows.Count) > 0)
            {
                int id = Convert.ToInt32(dtListaDetalle.CurrentRow.Cells[0].Value);
                this.dtListaDetalle.Rows.Remove(this.dtListaDetalle.Rows[this.dtListaDetalle.CurrentRow.Index]);
                listaDetalle.RemoveAt(id - 1);
                listaSalida.RemoveAt(id - 1);
                listarDetalle();
            }

            else
            {
                Mensaje.mensajeError("Error", "Debes seleccionar una fila para eliminar");
            }
        }
    }
}

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
        private Producto productoSeleccionado { get; set; }
        private string valor;
        public FrmProducto(int id)
        {
            InitializeComponent();
            this.idProducto = id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            FrmDetalleProducto frm = new FrmDetalleProducto();
            frm.ShowDialog();
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
                    if (pathFile.Equals("")==false)
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
            
            productoSeleccionado.DescProducto = textDescPro.Text.ToUpper();
            if (comboTipoPro.SelectedItem == comboItem1)
            {
                valor =Convert.ToString('N');
            }
            else
            {
                if (comboTipoPro.SelectedItem == comboItem2)
                    valor = Convert.ToString('M');
            }
            productoSeleccionado.Tipo = Convert.ToChar( valor);
            productoSeleccionado.Imagen = pathFile;
            productoSeleccionado.Precio = Convert.ToDouble(textPrecio.Text);
            productoSeleccionado.Descuento = Convert.ToDouble(textDescuento.Text);
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //if(General.validaFormGroup(this.Controls,errorProvider1))
            //{
                try
                {
                    setproducto();
                    if(_accion==Acciones.insert)
                    {
                        productoDao.insertar(productoSeleccionado);
                        Mensaje.mensajeInformacion("Informmacion", "Cliente grabado con exito");
                        this.Hide();
                    }
                    else
                    {
                        productoSeleccionado.IdProducto = idProducto;
                        productoDao.modificar(productoSeleccionado);
                        Mensaje.mensajeInformacion("Informmacion", "Cliente actualizado con exito");
                        this.Hide();
                    }
                }
                catch(Exception ex)
                {
                    if (_accion == Acciones.insert)
                    {
                        Mensaje.mensajeError("Error", "Error al insertar" + ex.Message);
                    }
                    else
                    {
                        Mensaje.mensajeError("Error", "Error al actualizar" + ex.Message);
                    }
                }
            
        }
    }
}

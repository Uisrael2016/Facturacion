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
using Facturacion_Entidades;
using Facturacion_AccesoDatos.dao;
using Facturacion_Vista.Vistas.Agregar;
namespace Facturacion_Vista.Vistas.Agregar
{
    public partial class FrmDetalleProducto : DevComponents.DotNetBar.Office2007Form
    {
        private MaterialDao _materialDao;
        private Acciones _accion;
        private double valor;
        private double resul;
        public DetalleProducto detproductoSeleccionado { get; set; }
        public Salida salida { get; set; }
        public Material _material { get; set; }
        private string color;
        public FrmDetalleProducto(Acciones accion)
        {
            InitializeComponent();
            _material = new Material();
            cargaCombo();
            this._accion = accion;
        }

        private void cargaCombo()
        {
            _materialDao = new MaterialDao();
            comboMaterial.DataSource = _materialDao.consultar();
            comboMaterial.DisplayMember = "Descripcion";
            comboMaterial.ValueMember = "IdMaterial";
        }
        private void textCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.validaDecimal(e, textCantidad);
        }

        private void comboMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material mat = (Material)comboMaterial.SelectedItem;
            _material.IdMaterial = mat.IdMaterial;
            _material.Descripcion = mat.Descripcion;
            _material.Stock = mat.Stock;
            _material.IdTipoMaterial = mat.IdTipoMaterial;
            _material.IdProveedor = mat.IdProveedor;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            textColor.BackColor = colorDialog.Color;
            color = colorDialog.Color.ToString();
            Console.WriteLine(colorDialog.Color.ToString());
        }

        private void setDetalleProduc()
        {
            detproductoSeleccionado = new DetalleProducto();
            detproductoSeleccionado.Cantidad = valor;
            detproductoSeleccionado.Color = textColor.BackColor.ToString();
            detproductoSeleccionado.DescDetalle = textDescripcion.Text;
            detproductoSeleccionado.IdMaterial = (Material)comboMaterial.SelectedItem;

        }
        private void setSalida()
        {
            salida = new Salida();
            salida.CantidadEgreso = valor;
            salida.IdMaterial = _material;
            salida.FechaEgreso = DateTime.Now;
            salida.UsuarioEgreso = Login.usuarioPerfilManager.IdUsuario.IdUsuario;

        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (General.validaFormGroup(this.Controls, errorProvider))
            {
                valor = Convert.ToDouble(textCantidad.Text);
                if (valor > _material.Stock)
                {
                    Mensaje.mensajeAlerta("Información", "Cantidad exede stock de material");
                    return;
                }
                else
                {
                    resul = _material.Stock - valor;
                    setDetalleProduc();
                    setSalida();
                    this.Hide();
                }


            }
        }
    }
}

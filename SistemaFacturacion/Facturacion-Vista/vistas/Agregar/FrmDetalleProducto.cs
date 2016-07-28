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
        private Material _material;
        private Acciones _accion;
        private Producto producto;
        private DetalleProducto detproductoSeleccionado { get; set; }
        public FrmDetalleProducto()
        {
            InitializeComponent();
            _material = new Material();
            cargaCombo();
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
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            richTextBox1.BackColor = colorDialog.Color;
            Console.WriteLine(colorDialog.Color.ToString());


        }
        
        private  void setDetalleProduc()
        {
            if (_accion == Acciones.insert)
            {
                detproductoSeleccionado = new DetalleProducto();
            }
            detproductoSeleccionado.IdMaterial = (Material)comboMaterial.SelectedItem;
           
                
        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

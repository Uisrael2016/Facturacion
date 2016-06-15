using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_Vista.Utilidades;
using Facturacion_AccesoDatos.dao;
using Facturacion_Entidades;
namespace Facturacion_Vista.Vistas
{
    public partial class FrmMaterial : DevComponents.DotNetBar.Office2007Form
    {
        private int idMaterial = 0;
        private Material materialSeleccionado;
        private Ingreso ingreso;
        private Salida salida;
        private Proveedor _proveedor;
        private TipoMaterial _tipoMaterial;
        private Acciones _accion;
        private MaterialDao materialDao;
        public FrmMaterial(int id)
        {
            InitializeComponent();
            this.idMaterial = id;
            _proveedor = new Proveedor();
            _tipoMaterial = new TipoMaterial();
            cargarProveedor();
            cargaTipoMaterial();
            materialDao = new MaterialDao();
            if (id > 0)
            {
                _accion = Acciones.update;
                materialSeleccionado = materialDao.consultarPorId(id);

            }
            else
            {
                _accion = Acciones.insert;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.validaDecimal(e, textCantidad);
        }

        private void cargarProveedor()
        {
            ProveedorDao dao = new ProveedorDao();
            comboProveedor.DataSource = dao.consultar();
            comboProveedor.DisplayMember = "RazonSocial";
            comboProveedor.ValueMember = "IdProveedor";
        }
        private void cargaTipoMaterial()
        {
            TipoMaterialDao dao = new TipoMaterialDao();
            comboTipoMaterial.DataSource = dao.consultar();
            comboTipoMaterial.DisplayMember = "Tipo";
            comboTipoMaterial.ValueMember = "IdTipoMaterial";
        }

        private void comboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Proveedor prov = (Proveedor)comboProveedor.SelectedItem;
            _proveedor.IdProveedor = prov.IdProveedor;
            _proveedor.IdTipoDocumento = prov.IdTipoDocumento;
            _proveedor.Documento = prov.Documento;
            _proveedor.RazonSocial = prov.RazonSocial;
            _proveedor.Email = prov.Email;
            _proveedor.Estado = prov.Estado;
            _proveedor.FechaIngreso = prov.FechaIngreso;
            _proveedor.FechaEgreso = prov.FechaEgreso;
            _proveedor.UsuarioIngresa = prov.UsuarioIngresa;
            _proveedor.UsuarioEgresa = prov.UsuarioEgresa;
        }

        private void comboTipoMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoMaterial tipMat = (TipoMaterial)comboTipoMaterial.SelectedItem;
            _tipoMaterial.IdTipoMaterial = tipMat.IdTipoMaterial;
            _tipoMaterial.Tipo = tipMat.Tipo;
        }

        private void setMaterial()
        {
            materialSeleccionado.Descripcion = textDescripcion.Text;
            materialSeleccionado.Stock = Convert.ToDouble(textCantidad.Text);
            materialSeleccionado.IdProveedor = _proveedor;
            materialSeleccionado.IdTipoMaterial = _tipoMaterial;

        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (General.validaFormGroup(this.Controls, errorProvider))
            {
                try
                {
                    setMaterial();
                    if (materialDao == null)
                        materialDao = new MaterialDao();
                    if (_accion == Acciones.insert)
                    {
                        materialSeleccionado = new Material();
                        IngresoDao inDao = new IngresoDao();
                        ingreso = new Ingreso();
                        materialDao.insertar(materialSeleccionado);
                        Mensaje.mensajeInformacion("Información","Material Registrado Correctamente");
                        this.Hide();
                    }
                    else
                    {
                        salida = new Salida();

                    }
                }
                catch (Exception ex)
                {

                }

            }
        }
    }

}

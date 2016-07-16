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
using Facturacion_AccesoDatos.dao;
using Facturacion_Vista.Utilidades;

namespace Facturacion_Vista.Vistas
{
    public partial class FrmProveedores : DevComponents.DotNetBar.Office2007Form
    {
        private char estado;
        private int idProveedor = 0;
        private TipoDocumento _tipodocumento;
        private Acciones _accion;
        private ProveedorDao proveedorDao;
        private Proveedor proveedorSeleccionado;
        

        public FrmProveedores(int id)
        {
            InitializeComponent();
            this.idProveedor = id;
            _tipodocumento = new TipoDocumento();
            proveedorDao = new ProveedorDao();
            if(id>0)
            {
                _accion = Acciones.update;
                proveedorSeleccionado = proveedorDao.consultarPorId(id);
                cbxTipoDocumento.SelectedItem = proveedorSeleccionado.IdTipoDocumento;
                txtDocumento.Text = proveedorSeleccionado.Documento;
                txtRazonSocial.Text = proveedorSeleccionado.RazonSocial;
                txtreprlegal.Text = proveedorSeleccionado.RepresentanteLegal;
                txtEmail.Text = proveedorSeleccionado.Email;
                txtDireccion.Text = proveedorSeleccionado.Direccion;
                txtTelefono.Text = proveedorSeleccionado.Telefono;      

            }
            else
            {
                _accion = Acciones.insert;
            }
            this.cargar_combo();
        }
        private void setProveedor()
        {


            if (_accion == Acciones.insert)
            {
                proveedorSeleccionado = new Proveedor();

            }
            proveedorSeleccionado.IdTipoDocumento = (TipoDocumento)cbxTipoDocumento.SelectedItem;
            proveedorSeleccionado.Documento = txtDocumento.Text;
            proveedorSeleccionado.RazonSocial = txtRazonSocial.Text.ToUpper();
            proveedorSeleccionado.RepresentanteLegal = txtreprlegal.Text.ToUpper();
            proveedorSeleccionado.Email = txtEmail.Text;
            proveedorSeleccionado.Direccion = txtDireccion.Text;
            proveedorSeleccionado.Estado = estado;
            proveedorSeleccionado.FechaIngreso = DateTime.Now;
            proveedorSeleccionado.UsuarioIngresa = Login.usuarioPerfilManager.IdUsuario.IdUsuario;
            proveedorSeleccionado.Direccion = txtDireccion.Text;
            proveedorSeleccionado.Telefono = txtTelefono.Text;
        }
        private void btguardar_Click(object sender, EventArgs e)
        {
            if (General.validaFormGroup(this.Controls, erroricono))
            {
                try
                {
                    setProveedor();
                    if (_accion == Acciones.insert)
                    {
                        proveedorDao.insertar(proveedorSeleccionado);
                        Mensaje.mensajeInformacion("Informacion", "Prveedor Grabado con Exito");
                        this.Hide();
                    }
                    else
                    {
                        proveedorSeleccionado.Estado = estado;
                        proveedorSeleccionado.IdProveedor = idProveedor;
                        proveedorSeleccionado.UsuarioEgresa = Login.usuarioPerfilManager.IdUsuario.IdUsuario;
                        proveedorSeleccionado.FechaEgreso = DateTime.Now;
                        proveedorDao.modificar(proveedorSeleccionado);
                        Mensaje.mensajeInformacion("Informacion ", "Proveedor Actualizado con exito");
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
            else
            {

            }
        }
        private void cargar_combo()
        {
            TipoDocumentoDao _tipoDocumento = new TipoDocumentoDao();
            cbxTipoDocumento.DataSource = _tipoDocumento.consultar();
            cbxTipoDocumento.DisplayMember = "Documento";
            cbxTipoDocumento.ValueMember = "IdTipoDocumento";
        }

        private void radioH_CheckedChanged(object sender, EventArgs e)
        {
            estado = 'A';
        }

        private void radioD_CheckedChanged(object sender, EventArgs e)
        {
            estado = 'D';
        }

        private void cbxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoDocumento tpdocumento = (TipoDocumento)cbxTipoDocumento.SelectedItem;
            _tipodocumento.IdTipoDocumento = tpdocumento.IdTipoDocumento;
            _tipodocumento.Documento = tpdocumento.Documento;
        }

        private void cbxTipoDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_tipodocumento.IdTipoDocumento == 1)
            {
                General.lengthNumber(e, txtDocumento,10);

            } else if (_tipodocumento.IdTipoDocumento==2)
            {
                General.lengthNumber(e, txtDocumento,13);
            }

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

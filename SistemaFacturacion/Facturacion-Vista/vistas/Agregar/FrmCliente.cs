﻿using System;
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
    public partial class FrmCliente : DevComponents.DotNetBar.Office2007Form
    {
        private int idcliente = 0;
        private TipoDocumento _tipodocumento;
        private Acciones _accion;
        private ClienteDao clientedao;
        public Cliente clienteSeleccionado { get; set; }
        public FrmCliente(int id)
        {
            InitializeComponent();
            this.idcliente = id;
            _tipodocumento = new TipoDocumento();
            cargar_combo();
            clientedao = new ClienteDao();
            if (id > 0)
            {
                _accion = Acciones.update;
                clienteSeleccionado = clientedao.consultarPorId(id);
                txtDocumento.Text = clienteSeleccionado.DocumentoCliente;
                txtNombre.Text = clienteSeleccionado.Nombres;
                txtApellido.Text = clienteSeleccionado.Apellidos;
                txtEmail.Text = clienteSeleccionado.Correo;
                txtDireccion.Text = clienteSeleccionado.Direccion;
                txtTelefono.Text = clienteSeleccionado.Telefono;
                cbxTipoDocumento.SelectedItem = clienteSeleccionado.IdTipoDocumento;
            }
            else
            {
                _accion = Acciones.insert;
            }

        }
        private void cargar_combo()
        {
            TipoDocumentoDao _tipodocumento = new TipoDocumentoDao();
            cbxTipoDocumento.DataSource = _tipodocumento.consultar();
            cbxTipoDocumento.DisplayMember = "Documento";
            cbxTipoDocumento.ValueMember = "IdTipoDocumento";

        }
        private void setCliente()
        {
            //DateTime fechahoy = DateTime.Now;
            //string fecha = fechahoy.ToString("d");
            if (_accion == Acciones.insert)
            {
                clienteSeleccionado = new Cliente();
            }
            clienteSeleccionado.IdTipoDocumento = (TipoDocumento)cbxTipoDocumento.SelectedItem;
            clienteSeleccionado.DocumentoCliente = txtDocumento.Text;
            clienteSeleccionado.Nombres = txtNombre.Text.ToUpper();
            clienteSeleccionado.Apellidos = txtApellido.Text.ToUpper();
            clienteSeleccionado.Correo = txtEmail.Text;
            clienteSeleccionado.Direccion = txtDireccion.Text.ToUpper();
            clienteSeleccionado.Telefono = txtTelefono.Text;
            clienteSeleccionado.FechaIngreso = DateTime.Now;
            clienteSeleccionado.UsuarioIngreso = Login.usuarioPerfilManager.IdUsuario.IdUsuario;
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (General.validaFormGroup(this.Controls, erroricono))
            {

                try
                {
                    setCliente();
                    if (_accion == Acciones.insert)
                    {
                        clientedao.insertar(clienteSeleccionado);
                        Mensaje.mensajeInformacion("Informmacion", "Cliente grabado con exito");
                        this.Hide();

                    }
                    else
                    {
                        clienteSeleccionado.IdCliente = idcliente;
                        clienteSeleccionado.UsuarioEgreso = Login.usuarioPerfilManager.IdUsuario.IdUsuario;
                        clienteSeleccionado.FechaEgreso = DateTime.Now;
                        clientedao.modificar(clienteSeleccionado);
                        Mensaje.mensajeInformacion("Informmacion", "Cliente actualizado con exito");
                        this.Hide();
                    }
                }
                catch (Exception ex)
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

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoDocumento tpdocumento = (TipoDocumento)cbxTipoDocumento.SelectedItem;
            _tipodocumento.IdTipoDocumento = tpdocumento.IdTipoDocumento;
            _tipodocumento.Documento = tpdocumento.Documento;
            _tipodocumento.Codigo = tpdocumento.Codigo;
            if (_accion == Acciones.insert)
            {
                txtDocumento.Text = string.Empty;
            }


        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_tipodocumento.IdTipoDocumento == 1)
            {
                General.lengthNumber(e, txtDocumento, 10);
            }
            else if (_tipodocumento.IdTipoDocumento == 2)
            {
                General.lengthNumber(e, txtDocumento, 13);
            }

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.validaNumero(e, txtTelefono);
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {

            if (_tipodocumento.IdTipoDocumento == 1)
            {
                cbxTipoDocumento.Enabled = false;
                if (txtDocumento.Text.Length == 10)
                {
                    if (!General.validaCedula(txtDocumento.Text))
                    {
                        Mensaje.mensajeError("Cedula Invalida", "Cedula Incorrecta, verifique el numero de cedula por favor");
                        txtDocumento.Focus();
                        txtDocumento.Text = string.Empty;
                        return;
                    }
                }
                else
                {
                    Mensaje.mensajeError("Cedula Invalida", "Numero de digitos de cedula invalido");
                    txtDocumento.Focus();
                    return;
                }

            }

        }
    }
}

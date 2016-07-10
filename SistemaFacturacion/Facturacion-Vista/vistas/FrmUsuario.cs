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
    public partial class FrmUsuario : DevComponents.DotNetBar.Office2007Form
    {
        private int idusuario = 0;
        private TipoDocumento _tipodocumento;
        private Acciones _accion;
        private UsuarioDao usuariodao;
        private Usuario usuarioSeleccionado;
        public FrmUsuario(int id)
        {
            InitializeComponent();
            this.idusuario = id;
            _tipodocumento = new TipoDocumento();
            cargar_combo();
            usuariodao = new UsuarioDao();
            if(id>0)
                {
                _accion = Acciones.update;
                usuarioSeleccionado = usuariodao.consultarPorId(id);
                cbTipoDocumento.SelectedItem = usuarioSeleccionado.IdTipoDocumento;
                txtDocumento.Text = usuarioSeleccionado.Documento;
                txtNombres.Text = usuarioSeleccionado.Nombre;
                txtTelefono.Text = usuarioSeleccionado.Telefono;
                txtEmail.Text = usuarioSeleccionado.Mail;
                txtuser.Text = usuarioSeleccionado.UserName;
                txtClave.Text = usuarioSeleccionado.Clave;
                estado_base = Convert.ToChar(usuarioSeleccionado.Estado);
                fechaIngreso.Text = Convert.ToString(usuarioSeleccionado.FechaIngreso);
                }
            else
            {
                _accion = Acciones.insert;
            }
        }
        private char estado;
        private char estado_base;
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            fechaIngreso.Text = DateTime.Now.ToString("dd-MM-yyyy");
            if (estado_base == 'A')
            {
                rdActivo.Checked = true;
            }
            else
            {
                rdDesactivo.Checked = true;
            }
            cbTipoDocumento.Focus();
            cargar_combo();            
        }

        private void cargar_combo()
        {
            TipoDocumentoDao usuario = new TipoDocumentoDao();
            cbTipoDocumento.DataSource = usuario.consultar();
            cbTipoDocumento.DisplayMember = "Documento";
            cbTipoDocumento.ValueMember = "IdTipoDocumento";
        }

        private void setUsuario()
        {
            if(_accion==Acciones.insert)
            {
                usuarioSeleccionado = new Usuario();
            }
            usuarioSeleccionado.IdTipoDocumento = (TipoDocumento)cbTipoDocumento.SelectedItem;
            usuarioSeleccionado.Documento = txtDocumento.Text;
            usuarioSeleccionado.Nombre = txtNombres.Text.ToUpper();
            usuarioSeleccionado.Mail = txtEmail.Text;
            usuarioSeleccionado.FechaIngreso = Convert.ToDateTime(fechaIngreso.Text);
            usuarioSeleccionado.UserName = txtuser.Text.ToUpper();
            usuarioSeleccionado.Clave = txtClave.Text;
            usuarioSeleccionado.Estado = estado;
            usuarioSeleccionado.Telefono = txtTelefono.Text;
            usuarioSeleccionado.CambiarClave = Convert.ToBoolean(ckCambiarClave.CheckState);
            usuarioSeleccionado.UsuarioIngreso = Login.usuarioPerfilManager.IdUsuario.IdUsuario;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            estado = 'A';
        }

        private void rdDesactivo_CheckedChanged(object sender, EventArgs e)
        {
            estado = 'D';
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
          if(General.validaFormGroup(this.Controls,erroricono))
           {
                try
                {
                    if (txtDocumento.Text.Length==0 || txtNombres.Text.Length==0 || txtTelefono.Text.Length==0 || txtEmail.Text.Length==0 || txtuser.Text.Length==0 || txtClave.Text.Length==0 )
                    {
                        MessageBox.Show("Por favor no deje campos vacios.");
                        return;
                    }
                    else
                    {
                        setUsuario();
                        if (_accion == Acciones.insert)
                        {
                            usuariodao.insertar(usuarioSeleccionado);
                            Mensaje.mensajeInformacion("Información", "Usuario ingresado correctamente");
                            this.Hide();
                        }
                        else
                        {
                            usuarioSeleccionado.IdUsuario = idusuario;
                            usuariodao.modificar(usuarioSeleccionado);
                            Mensaje.mensajeInformacion("Información", "Usuario actualizado correctamente");
                            this.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (_accion == Acciones.insert)
                    {
                        Mensaje.mensajeError("Error", "Error al ingresar el usuario" + ex.Message);
                    }
                    else
                    {
                        Mensaje.mensajeError("Error", "Error al actualizar el usuario" + ex.Message);
                    }
                }
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoDocumento tipodoc = (TipoDocumento)cbTipoDocumento.SelectedItem;
            _tipodocumento.IdTipoDocumento = tipodoc.IdTipoDocumento;
            _tipodocumento.Documento = tipodoc.Documento;
        }

        private void txtDocumento_Validating(object sender, CancelEventArgs e)
        {
            if(txtDocumento.Text.Length==10)
            {
                if(!General.validaCedula(txtDocumento.Text))
                {
                    Mensaje.mensajeError("Cedula Invalida", "Cedula ingresada no valida, por favor verifiquela");
                    txtDocumento.Text = string.Empty;
                    txtDocumento.Focus();
                    return;
                }
            }
            else
            {
                Mensaje.mensajeError("Cedula Invalida", "Por favor verique la cedula ingresada.");
                txtDocumento.Focus();
                return;
            }
        }


        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_tipodocumento.IdTipoDocumento == 1)
            {
                General.lengthNumber(e, txtDocumento,10);
            }
            else if (_tipodocumento.IdTipoDocumento == 2)
            {
                General.lengthNumber(e, txtDocumento,13);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.validaNumero(e, txtTelefono);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if(!General.validaEmail(txtEmail.Text))
            {
                Mensaje.mensajeError("Email invalido", "Por favor revise el email ingresado, Ex: ejemplo@gmail.com");
                txtEmail.Text = string.Empty;
                txtEmail.Focus();
                return;
            }
        }
    }
}

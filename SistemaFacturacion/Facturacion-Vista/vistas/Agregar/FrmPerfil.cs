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
using Facturacion_AccesoDatos.conexion;
using Facturacion_AccesoDatos.dao;
using Facturacion_Vista.Vistas;
using Facturacion_Vista.Utilidades;
using System.Collections;

namespace Facturacion_Vista.Vistas.Agregar
{
    public partial class FrmPerfil : DevComponents.DotNetBar.Office2007Form
    {
        private int idperfil = 0;
        private Perfil _perfil;
        private Acciones _accion;
        private PerfilDao perfildao;
        private Perfil perfilSeleccionado { get; set; }
        public FrmPerfil(int id)
        {
            InitializeComponent();
            this.idperfil = id;
            _perfil = new Perfil();
            perfildao = new PerfilDao();
            if(id>0)
            {
                _accion = Acciones.update;
                perfilSeleccionado = perfildao.consultarPorId(id);
                txtDescripcion.Text = perfilSeleccionado.Descripcion;
                txtCodigo.Text = perfilSeleccionado.Codigo;
                estado_base = Convert.ToChar(perfilSeleccionado.Estado);
            }
            else
            {
                _accion = Acciones.insert;
            }
        }
        private char estado;
        private char estado_base;

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            if (estado_base == 'A')
            {
                rdActivo.Checked = true;
            }
            else
            {
                rdDesactivo.Checked = true;
            }
        }
        private void setPerfil()
        {
            if(_accion==Acciones.insert)
            {
                perfilSeleccionado = new Perfil();
            }
            perfilSeleccionado.Descripcion = txtDescripcion.Text.ToUpper();
            perfilSeleccionado.Codigo = txtCodigo.Text.ToUpper();
            perfilSeleccionado.Estado = estado;
        }

        private void rdActivado_CheckedChanged(object sender, EventArgs e)
        {
            estado = 'A';
        }

        private void rdDesactivado_CheckedChanged(object sender, EventArgs e)
        {
            estado = 'D';
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if(General.validaFormGroup(this.Controls,errorProvider1))
            {
                try
                {
                    setPerfil();
                    if (_accion == Acciones.insert)
                    {
                        perfildao.insertar(perfilSeleccionado);
                        Mensaje.mensajeInformacion("Información", "Perfil ingresado correctamente");
                        this.Hide();
                    }
                    else
                    { 
                        perfilSeleccionado.IdPerfil = idperfil;
                        perfildao.modificar(perfilSeleccionado);
                        Mensaje.mensajeInformacion("Información", "Perfil actualizado correctamente");
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    if (_accion == Acciones.insert)
                    {
                        Mensaje.mensajeError("Error", "Error al ingresar el perfil " + ex.Message);
                    }
                    else
                    {
                        Mensaje.mensajeError("Error", "Error al actualizar el perfil " + ex.Message);
                    }
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            string descripcion = this.txtDescripcion.Text;
            string codigo = descripcion.Substring(0, 3);
            txtCodigo.Text = codigo;
        }
    }
}

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

namespace Facturacion_Vista.Vistas.Agregar
{
    public partial class FrmEstablecimiento : DevComponents.DotNetBar.Office2007Form
    {
        private int idestablecimiento = 0;
        private Establecimiento _establecimiento;
        private Acciones _accion;
        private EstablecimientoDAO establecimientoDAO;
        private Establecimiento establecimientoSeleccionado { get; set; }
        public FrmEstablecimiento(int id)
        {
            InitializeComponent();
            this.idestablecimiento = id;
            _establecimiento = new Establecimiento();
            establecimientoDAO = new EstablecimientoDAO();
            if(id>0)
            {
                _accion = Acciones.update;
                establecimientoSeleccionado = establecimientoDAO.consultarPorId(id);
                txtNombre.Text = establecimientoSeleccionado.Nombre;
                txtDireccion.Text = establecimientoSeleccionado.Direccion;
                estado_base = Convert.ToChar(establecimientoSeleccionado.Estado);
            }
            else
            {
                _accion = Acciones.insert;
            }
        }
        private char estado;
        private char estado_base;
        private void FrmEstablecimiento_Load(object sender, EventArgs e)
        {
            if(estado_base=='A')
            {
                rdActivo.Checked = true;
            }
            else
            {
                rdDesactivo.Checked = true;
            }
        }

        private void setEstablecimiento()
        {
            if(_accion==Acciones.insert)
            {
                establecimientoSeleccionado = new Establecimiento();
            }
            establecimientoSeleccionado.Nombre = txtNombre.Text.ToUpper();
            establecimientoSeleccionado.Direccion = txtDireccion.Text.ToUpper();
            establecimientoSeleccionado.Estado = Convert.ToString(estado);
        }

        private void rdActivo_CheckedChanged(object sender, EventArgs e)
        {
            estado = 'A';
        }

        private void rdDesactivo_CheckedChanged(object sender, EventArgs e)
        {
            estado = 'D';
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if(General.validaFormGroup(this.Controls,errorProvider1))
            {
                try
                {
                    setEstablecimiento();
                    if(_accion==Acciones.insert)
                    {
                        establecimientoDAO.insertar(establecimientoSeleccionado);
                        Mensaje.mensajeInformacion("Información", "Establecimiento correctamente ingresado");
                        this.Hide();
                    }
                    else
                    {
                        establecimientoSeleccionado.IdEstablecimiento = idestablecimiento;
                        establecimientoDAO.modificar(establecimientoSeleccionado);
                        Mensaje.mensajeInformacion("Información", "Establecimiento correctamente actualizado");
                        this.Hide();
                    }
                }
                catch(Exception ex)
                {
                    if(_accion==Acciones.insert)
                    {
                        Mensaje.mensajeError("Error", "Error al ingresar el establecimiento " + ex.Message);
                    }
                    else
                    {
                        Mensaje.mensajeError("Error", "Error al modificar el establecimiento " + ex.Message);
                    }
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

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
    public partial class FrmPuntoEmision : DevComponents.DotNetBar.Office2007Form
    {
        private int idpuntoEmision = 0;
        private Establecimiento _establecimiento;
        private Acciones _accion;
        private PuntoEmisionDAO puntoEmisionDAO;
        private PuntoEmision puntoemisionSeleccionado { get; set; }
        public FrmPuntoEmision(int id)
        {
            InitializeComponent();
            this.idpuntoEmision = id;
             _establecimiento = new Establecimiento();
            cargar_combo();
            puntoEmisionDAO = new PuntoEmisionDAO();
            if(id>0)
            {
                _accion = Acciones.update;
                puntoemisionSeleccionado = puntoEmisionDAO.consultarPorId(id);
                txtCodigo.Text = puntoemisionSeleccionado.Codigo;
                estado_base = Convert.ToChar(puntoemisionSeleccionado.Estado);
                cbEstablecimiento.SelectedItem = puntoemisionSeleccionado.IdEstablecimiento;
            }
            else
            {
                _accion = Acciones.insert;
            }
        }
        private char estado;
        private char estado_base;
        private void FrmPuntoEmision_Load(object sender, EventArgs e)
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

        private void cargar_combo()
        {
            EstablecimientoDAO _establecimiento = new EstablecimientoDAO();
            cbEstablecimiento.DataSource = _establecimiento.consultar();
            cbEstablecimiento.DisplayMember = "Nombre";
            cbEstablecimiento.ValueMember = "IdEstablecimiento";
        }

        private void setPuntoEmision()
        {
            if(_accion==Acciones.insert)
            {
                puntoemisionSeleccionado = new PuntoEmision();
            }
            puntoemisionSeleccionado.IdEstablecimiento = (Establecimiento)cbEstablecimiento.SelectedItem;
            puntoemisionSeleccionado.Codigo = txtCodigo.Text.ToUpper();
            puntoemisionSeleccionado.Estado = estado;
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
                    setPuntoEmision();
                    if(_accion==Acciones.insert)
                    {
                        puntoEmisionDAO.insertar(puntoemisionSeleccionado);
                        Mensaje.mensajeInformacion("Información", "Punto de Emisión ingresado correctamente");
                        this.Hide();
                    }
                    else
                    {
                        puntoemisionSeleccionado.IdPuntoEmision = idpuntoEmision;
                        puntoEmisionDAO.modificar(puntoemisionSeleccionado);
                        Mensaje.mensajeInformacion("Información", "Punto de Emisión actualizado correctamente");
                        this.Hide();
                    }
                }
                catch(Exception ex)
                    {
                        if(_accion==Acciones.insert)
                        {
                            Mensaje.mensajeError("Error", "Error al ingresar el punto de emisión " + ex.Message);
                        }
                        else
                        {
                            Mensaje.mensajeError("Error", "Error al actualizar el punto de emisión " + ex.Message);
                        }
                    }
                }
            }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbEstablecimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Establecimiento esta = (Establecimiento)cbEstablecimiento.SelectedItem;
            _establecimiento.IdEstablecimiento = esta.IdEstablecimiento;
            _establecimiento.Nombre = esta.Nombre;
            _establecimiento.Estado = esta.Estado;
            if(_accion==Acciones.insert)
            {
                txtCodigo.Text = string.Empty;
            }
        }
    }
}


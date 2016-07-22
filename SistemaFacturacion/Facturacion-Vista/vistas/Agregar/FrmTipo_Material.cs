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
    public partial class FrmTipo_Material : DevComponents.DotNetBar.Office2007Form
    {
        private int idTipomaterial = 0;
        private TipoMaterial _tipomaterial;
        private Acciones _accion;
        private TipoMaterialDao tipomaterialDAO;
        private TipoMaterial tipomaterialSeleccionado { get; set; }
        public FrmTipo_Material(int id)
        {
            InitializeComponent();
            this.idTipomaterial = id;
            _tipomaterial = new TipoMaterial();
            tipomaterialDAO = new TipoMaterialDao();
            if(id>0)
            {
                _accion = Acciones.update;
                tipomaterialSeleccionado = tipomaterialDAO.consultarPorId(id);
                textBoxX1.Text = tipomaterialSeleccionado.Tipo;
            }
            else
            {
                _accion = Acciones.insert;
            }
        }

        private void FrmTipo_Material_Load(object sender, EventArgs e)
        {

        }

        private void setTipomaterial()
        {
            if(_accion==Acciones.insert)
            {
                tipomaterialSeleccionado = new TipoMaterial();
            }
            tipomaterialSeleccionado.Tipo = textBoxX1.Text;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if(General.validaFormGroup(this.Controls,errorProvider1))
            {
                try
                {
                    setTipomaterial();
                    if(_accion==Acciones.insert)
                    {
                        tipomaterialDAO.insertar(tipomaterialSeleccionado);
                        Mensaje.mensajeInformacion("Información", "Tipo de material ingresado correctamente");
                        this.Hide();
                    }
                    else
                    {
                        tipomaterialSeleccionado.IdTipoMaterial = idTipomaterial;
                        tipomaterialDAO.modificar(tipomaterialSeleccionado);
                        Mensaje.mensajeInformacion("Información", "Tipo de material actualizado correctamente");
                        this.Hide();
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

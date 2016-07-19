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
    public partial class FrmTarifa : DevComponents.DotNetBar.Office2007Form
    {
        private char estado;
        private int idTarifa = 0;
        private Tarifa tarifaseleccionado;
        private Acciones _accion;
        private TarifaDao tarifaDao;
        public FrmTarifa(int id)
        {
            InitializeComponent();
            this.idTarifa = id;
            tarifaDao = new TarifaDao();
            if (id > 0)
            {
                _accion = Acciones.update;
                tarifaseleccionado = tarifaDao.consultarPorId(id);
                txtvalor.Text = Convert.ToString(tarifaseleccionado.ValTarifa);

            }
            else
            {
                _accion = Acciones.insert;
            }
        }
        private void setTarifa()
        {
            if (_accion == Acciones.insert)
            {
                tarifaseleccionado = new Tarifa();
            }
            tarifaseleccionado.ValTarifa = Convert.ToInt32(txtvalor.Text);
            tarifaseleccionado.Estado = estado;
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (General.validaFormGroup(this.Controls, erroricono)) ;
            {
                try
                {
                    setTarifa();
                    if (_accion == Acciones.insert)
                    {
                        tarifaDao.insertar(tarifaseleccionado);
                        Mensaje.mensajeInformacion("Informacion", "Tarifa Grabada con Exito");
                        this.Hide();
                    }
                    else
                    {
                        tarifaseleccionado.Estado = estado;
                        Mensaje.mensajeInformacion("Informacion ", "Tarifa Actualizada con exito");
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

        private void radioH_CheckedChanged(object sender, EventArgs e)
        {
            estado = 'A';
        }

        private void radioD_CheckedChanged(object sender, EventArgs e)
        {
            estado = 'D';
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

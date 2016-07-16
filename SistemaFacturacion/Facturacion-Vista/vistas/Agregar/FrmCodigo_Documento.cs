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
    public partial class FrmCodigo_Documento : DevComponents.DotNetBar.Office2007Form
    {
        private int idcodigoDocumento = 0;
        private Acciones _accion;
        private CodigoDocumentoDao codigoDocumentoDao;
        public CodigoDocumento codigoDocumentoSeleccionado { get; set; }
        public FrmCodigo_Documento(int id)
        {            
            InitializeComponent();
            this.idcodigoDocumento = id;
            codigoDocumentoDao = new CodigoDocumentoDao();
            if(id>0)
            {
                _accion = Acciones.update;
                codigoDocumentoSeleccionado = codigoDocumentoDao.consultarPorId(id);
                txtcodigo.Text = codigoDocumentoSeleccionado.Codigo;
                txtdocumento.Text = codigoDocumentoSeleccionado.Documento;
            }
            else
            {
                _accion = Acciones.insert;
            }

        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if(General.validaFormGroup(this.Controls,erroricono))
            {
                try
                {
                    setCodigoDocumento();
                    if(_accion==Acciones.insert)
                    {
                        codigoDocumentoDao.insertar(codigoDocumentoSeleccionado);
                        Mensaje.mensajeInformacion("Informmacion", "Documento grabado con exito");
                        this.Hide();
                    }
                    else
                    {
                        codigoDocumentoSeleccionado.IdCodigoDocumento = idcodigoDocumento;
                        codigoDocumentoDao.modificar(codigoDocumentoSeleccionado);
                        Mensaje.mensajeInformacion("Informmacion", "Documento actualizado con exito");
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
        }
        private void setCodigoDocumento()
        {
            if(_accion==Acciones.insert)
            {
                codigoDocumentoSeleccionado = new CodigoDocumento();
            }
            codigoDocumentoSeleccionado.Codigo = txtcodigo.Text.ToUpper();
            codigoDocumentoSeleccionado.Documento = txtdocumento.Text.ToUpper();

        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

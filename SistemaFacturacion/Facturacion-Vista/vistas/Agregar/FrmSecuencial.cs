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
namespace Facturacion_Vista.Vistas.Listas
{
    public partial class FrmSecuencial : DevComponents.DotNetBar.Office2007Form
    {
        private string codigo;
        private Acciones _accion;
        private SecuencialDao secuencialDao;
        public Secuencial secuencialSeleccionado { get; set; }
        public FrmSecuencial(string id)
        {
            InitializeComponent();
            this.codigo = id;
            secuencialDao = new SecuencialDao();
            if(id.Trim() != "")
            {
                _accion = Acciones.update;
                secuencialSeleccionado = secuencialDao.buscaSecuencial(id);
                txtcodigo.Text = secuencialSeleccionado.Codigo;
                txtdescripcion.Text = secuencialSeleccionado.Descripcion;
                txtvalor.Text = Convert.ToString( secuencialSeleccionado.Valor);
            }
            else
            {
                _accion = Acciones.insert;
            }
        }
        private void setsecuencial()
        {
            if(_accion==Acciones.insert)
            {
                secuencialSeleccionado = new Secuencial();
            }
            secuencialSeleccionado.Codigo = txtcodigo.Text.ToUpper();
            secuencialSeleccionado.Descripcion = txtdescripcion.Text.ToUpper();
            secuencialSeleccionado.Valor = Convert.ToInt32(txtvalor.Text);
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (General.validaFormGroup(this.Controls,erroricono))
            {
                try
                {
                    setsecuencial();
                    if (_accion == Acciones.insert)
                    {
                        secuencialDao.insertar(secuencialSeleccionado);
                        Mensaje.mensajeInformacion("Informmacion", "Cliente grabado con exito");
                        this.Hide();
                    }
                    else
                    {
                        secuencialSeleccionado.Codigo = codigo;
                        secuencialDao.modificar(secuencialSeleccionado);
                        Mensaje.mensajeInformacion("Informmacion", "Cliente actualizado con exito");
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
    }
}

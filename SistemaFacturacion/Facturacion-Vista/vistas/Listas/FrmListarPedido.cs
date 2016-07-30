using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_AccesoDatos.dao;
using Facturacion_Entidades;
using Facturacion_Vista.Vistas.transacciones;
using Facturacion_Vista.Utilidades;

namespace Facturacion_Vista.Vistas.Listas
{
    public partial class FrmListarPedido : DevComponents.DotNetBar.Office2007Form
    {
        private List<Cabecera> listacabecera;
        private CabeceraDao cabecerDao;
        Acciones _accion;
        public FrmListarPedido(Acciones a)
        {
            InitializeComponent();
            this._accion = a;
            cabecerDao = new CabeceraDao();
            this.listarCabecera();
        }

          private void btGuardar_Click(object sender, EventArgs e)
        {
            FrmNotaPedido frm = new FrmNotaPedido(0);
            frm.ShowDialog();
            this.listarCabecera();
        }
        private void listarCabecera ()
        {
            listacabecera = (List<Cabecera>)cabecerDao.consultar();
            if(listacabecera !=null)
            {
                dtlista.Rows.Clear();
                foreach(Cabecera ca in listacabecera)
                {
                    //if ((textBuscar.Text == "")
                    //    ||()) 
                    dtlista.Rows.Add(ca.IdCabecera, ca.IdCodigoDocumento.Codigo +"-" + ca.Secuencial,ca.IdCliente.Nombres+" "+ca.IdCliente.Apellidos,ca.FechaEmision,ca.Total);
                }
               
            }
        }
        
    }
}

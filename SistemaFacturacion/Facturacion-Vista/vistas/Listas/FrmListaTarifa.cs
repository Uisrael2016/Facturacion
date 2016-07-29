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
using Facturacion_Vista.Vistas.Agregar;
using Facturacion_Vista.Utilidades;
namespace Facturacion_Vista.Vistas.Listas
{
    public partial class FrmListaTarifa : DevComponents.DotNetBar.Office2007Form
    {
        private TarifaDao tarifaDao = new TarifaDao();
        private List<Tarifa> listaTarifa;
        private Tarifa tarifaseleccionada;
        private Acciones _accion;
        public FrmListaTarifa()
        {
            InitializeComponent();
            this.ListarTarifa();
           
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            FrmTarifa frm = new FrmTarifa(0);
            frm.ShowDialog();
            ListarTarifa();
        }
        private void ListarTarifa()
        {
            tarifaDao = new TarifaDao();
            listaTarifa = (List<Tarifa>)tarifaDao.consultar();
            if(listaTarifa!=null)
            {
                dtlista.Rows.Clear();
                foreach (Tarifa tar in listaTarifa)
                {
                    dtlista.Rows.Add(tar.IdTarifa, tar.ValTarifa, tar.Estado);
                    
                }
            }
        }

        private void dtlista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_accion != Acciones.update)
            {
                int id = Convert.ToInt32(dtlista.CurrentRow.Cells[0].Value);
                FrmTarifa frm = new FrmTarifa(id);
                frm.ShowDialog();
                ListarTarifa();
                
            }
            else
            {
                int id = Convert.ToInt32(dtlista.CurrentRow.Cells[0].Value);
                TarifaDao dao = new TarifaDao();
               tarifaseleccionada = dao.consultarPorId(id);
                
                this.Hide();
            }
        }
    }
}

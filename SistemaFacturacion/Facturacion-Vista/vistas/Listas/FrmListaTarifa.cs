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
namespace Facturacion_Vista.Vistas.Listas
{
    public partial class FrmListaTarifa : DevComponents.DotNetBar.Office2007Form
    {
        private TarifaDao tarifaDao = new TarifaDao();
        private List<Tarifa> listaTarifa;
        public FrmListaTarifa()
        {
            InitializeComponent();
           
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            FrmTarifa frm = new FrmTarifa(0);
            frm.ShowDialog();
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
    }
}

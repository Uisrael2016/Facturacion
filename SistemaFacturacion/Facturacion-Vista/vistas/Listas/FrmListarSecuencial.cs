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
//namespace Facturacion_Vista.Vistas;

namespace Facturacion_Vista.Vistas.Listas
{
    public partial class FrmListarSecuencial : DevComponents.DotNetBar.Office2007Form
    {
        private SecuencialDao secuencialDao = new SecuencialDao();
        private List<Secuencial> listaSecuencial;
        public Secuencial secuencialSeleccionado { get; set; }
        Acciones _accion;
        public FrmListarSecuencial(Acciones a)
        {
            InitializeComponent();
            this._accion = a;
            this.listarSecuencial();
            
        }
        private void listarSecuencial()
        {
            secuencialDao = new SecuencialDao();
            listaSecuencial = (List<Secuencial>)secuencialDao.consultar();
            if (listaSecuencial != null)
            {
                dtlista.Rows.Clear();
                foreach (Secuencial sec in listaSecuencial)
                {
                    if ((txtbuscar.Text == "")
                        || (sec.Codigo.Contains(txtbuscar.Text.ToUpper()))
                        || (sec.Descripcion.Contains(txtbuscar.Text.ToUpper())))
                    {
                        dtlista.Rows.Add(sec.Codigo, sec.Descripcion, sec.Valor);
                    }
                }
            }

        }
        private void FrmListarSecuencial_Load(object sender, EventArgs e)
        {

        }

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.listarSecuencial();
        }

        private void dtlista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = Convert.ToString( dtlista.CurrentRow.Cells[0].Value);
            FrmSecuencial frm = new FrmSecuencial(id);
            frm.ShowDialog();
            listarSecuencial();

        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            FrmSecuencial frm = new FrmSecuencial(string.Empty);
            frm.ShowDialog();
            this.listarSecuencial();
        }
    }
}

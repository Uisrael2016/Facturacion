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
using Facturacion_Vista.Vistas.Agregar;
using Facturacion_Vista.Utilidades;
using System.Collections;

namespace Facturacion_Vista.Vistas.Listas
{
    public partial class FrmListarPuntoEmision : DevComponents.DotNetBar.Office2007Form
    {
        private PuntoEmisionDAO puntoemisionDAO = new PuntoEmisionDAO();
        private List<PuntoEmision> listaPuntoEmision;
        public PuntoEmision puntoEmisionSeleccionado { get; set; }
        Acciones _accion;
        public FrmListarPuntoEmision(Acciones a)
        {
            InitializeComponent();
            this._accion = a;
            ListarPuntoEmision();
        }

        public void ListarPuntoEmision()
        {
            puntoemisionDAO = new PuntoEmisionDAO();
            listaPuntoEmision = (List < PuntoEmision >) puntoemisionDAO.consultar();
            if (listaPuntoEmision != null)
            {
                dtLista.Rows.Clear();
                foreach (PuntoEmision ptE in listaPuntoEmision)
                {
                    {
                        if ((txtbuscar.Text == "")
                            || (ptE.Codigo.Contains(txtbuscar.Text.ToUpper())))
                        {
                            dtLista.Rows.Add(ptE.IdPuntoEmision, ptE.Codigo, ptE.Estado);
                        }
                    }
                }
            }
        }

        private void dtlista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_accion != Acciones.inject)
            {
                int id = Convert.ToInt32(dtLista.CurrentRow.Cells[0].Value);
                FrmPuntoEmision frm = new FrmPuntoEmision(id);
                frm.ShowDialog();
                ListarPuntoEmision();
            }
            else
            {
                int id = Convert.ToInt32(dtLista.CurrentRow.Cells[0].Value);
                PuntoEmisionDAO dao = new PuntoEmisionDAO();
                puntoEmisionSeleccionado = dao.consultarPorId(id);
                this.Hide();
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            FrmPuntoEmision frmpuntoEmision = new FrmPuntoEmision(0);
            frmpuntoEmision.ShowDialog();
            ListarPuntoEmision();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            ListarPuntoEmision();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Facturacion_Entidades;
using Facturacion_AccesoDatos.dao;
using Facturacion_Vista.Utilidades;
using Facturacion_Vista.Vistas.Agregar;

namespace Facturacion_Vista.Vistas.Listas
{
    public partial class FrmListarEstablecimiento : DevComponents.DotNetBar.Office2007Form
    {
        private EstablecimientoDAO establecimientoDAO = new EstablecimientoDAO();
        private List<Establecimiento> listaEstablecimiento;
        public Establecimiento establecimientoSeleccionado { get; set; }
        Acciones _accion;
        public FrmListarEstablecimiento(Acciones a)
        {
            InitializeComponent();
            this._accion = a;
            listarEstablecimiento();
        }
        public void listarEstablecimiento()
        {
            establecimientoDAO = new EstablecimientoDAO();
            listaEstablecimiento = (List<Establecimiento>)establecimientoDAO.consultar();
            if (listaEstablecimiento != null)
            {
                dtLista.Rows.Clear();
                foreach (Establecimiento est in listaEstablecimiento)
                {
                    if ((txtbuscar.Text == "")
                        || (est.Nombre.Contains(txtbuscar.Text.ToUpper()))
                        || (est.Direccion.Contains(txtbuscar.Text)))
                    {
                        dtLista.Rows.Add(est.IdEstablecimiento, est.Nombre, est.Direccion, est.Estado);
                    }
                }
            }
        }
        private void FrmListarEstablecimiento_Load(object sender, EventArgs e)
        {
            this.listarEstablecimiento();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            FrmEstablecimiento frmestablecimiento = new FrmEstablecimiento(0);
            frmestablecimiento.ShowDialog();
            listarEstablecimiento();
        }

        private void dtLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtLista.CurrentRow.Cells[0].Value);
            FrmEstablecimiento frm = new FrmEstablecimiento(id);
            frm.ShowDialog();
            listarEstablecimiento();
            
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            listarEstablecimiento();
        }

        private void dtLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && _accion == Acciones.inject)
            {
                int id = Convert.ToInt32(dtLista.CurrentRow.Cells[0].Value);
                EstablecimientoDAO dao = new EstablecimientoDAO();
                establecimientoSeleccionado = dao.consultarPorId(id);
                this.Hide();
            }
        }
    }
}

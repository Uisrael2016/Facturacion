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
    public partial class FrmListarPerfl : DevComponents.DotNetBar.Office2007Form
    {
        private PerfilDao perfilDAO = new PerfilDao();
        private List<Perfil> listaPerfil;
        public Perfil perfilSeleccionado { get; set; }
        Acciones _accion;
        public FrmListarPerfl(Acciones a)
        {
            InitializeComponent();
            this._accion = a;
            ListarPerfil();
        }

        private void FrmListarPerfl_Load(object sender, EventArgs e)
        {
           this.ListarPerfil();
        }
        public void ListarPerfil()
        {
            perfilDAO = new PerfilDao();
            listaPerfil = (List<Perfil>)perfilDAO.consultar();
            if (listaPerfil != null)
                dtLista.Rows.Clear();
            foreach (Perfil per in listaPerfil)
            {
                if((txtbuscar.Text=="")
                    || (per.Descripcion.Contains(txtbuscar.Text.ToUpper()))
                    || (per.Codigo.Contains(txtbuscar.Text.ToUpper())))
                {
                    dtLista.Rows.Add(per.IdPerfil, per.Descripcion, per.Codigo, per.Estado);
                }
            }
        }

        private void dtLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtLista.CurrentRow.Cells[0].Value);
            FrmPerfil frm=new FrmPerfil(id);
            frm.ShowDialog();
            ListarPerfil();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            FrmPerfil frmperfil = new FrmPerfil(0);
            frmperfil.ShowDialog();
            ListarPerfil();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            this.ListarPerfil();
        }
    }
}

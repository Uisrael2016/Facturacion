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
    public partial class FrmListarTipoMaterial : DevComponents.DotNetBar.Office2007Form
    {
        private TipoMaterialDao tipoMaterialDAO = new TipoMaterialDao();
        private List<TipoMaterial> listaTipoMaterial;
        public TipoMaterial tipoMaterialseleccionado { get; set; }
        Acciones _accion;
        public FrmListarTipoMaterial(Acciones a)
        {
            InitializeComponent();
            this._accion = a;
            ListarTipoMaterial(); 
        }

        private void FrmListarTipoMaterial_Load(object sender, EventArgs e)
        {
            this.ListarTipoMaterial();
        }

        public void ListarTipoMaterial()
        {
            tipoMaterialDAO = new TipoMaterialDao();
            listaTipoMaterial = (List < TipoMaterial >) tipoMaterialDAO.consultar();
            if(listaTipoMaterial!=null)
            {
                dtLista.Rows.Clear();
                foreach(TipoMaterial tmaterial in listaTipoMaterial)
                {
                    if((txtBuscar.Text=="")
                        || (tmaterial.Tipo.Contains(txtBuscar.Text.ToUpper())))
                    {
                        dtLista.Rows.Add(tmaterial.IdTipoMaterial, tmaterial.Tipo);
                    }
                }
            }
        }

        private void dtLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtLista.CurrentRow.Cells[0].Value);
            FrmTipo_Material frm= new FrmTipo_Material(id);
            frm.ShowDialog();
            ListarTipoMaterial();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            FrmTipo_Material frmtipoMaterial = new FrmTipo_Material(0);
            frmtipoMaterial.ShowDialog();
            ListarTipoMaterial();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ListarTipoMaterial();
        }

        private void dtLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && _accion == Acciones.inject)
            {
                int id = Convert.ToInt32(dtLista.CurrentRow.Cells[0].Value);
                TipoMaterialDao dao = new TipoMaterialDao();
                tipoMaterialseleccionado = dao.consultarPorId(id);
                this.Hide();
            }
        }
    }
}

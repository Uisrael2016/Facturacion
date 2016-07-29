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
namespace Facturacion_Vista.Vistas
{

    public partial class FrmListarMaterial : DevComponents.DotNetBar.Office2007Form
    {
        private MaterialDao materialDao;
        private List<Material> listaMaterial;
        public FrmListarMaterial()
        {
            InitializeComponent();
            listarMaterial();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            FrmMaterial frm = new FrmMaterial(0);
            frm.ShowDialog();
            this.listarMaterial();
        }
        private void listarMaterial()
        {
            materialDao = new MaterialDao();
            listaMaterial = (List<Material>)materialDao.consultar();
            if (listaMaterial != null)
            {
                dataMaterial.Rows.Clear();
                foreach (Material mat in listaMaterial)
                {
                    dataMaterial.Rows.Add(mat.IdMaterial,mat.Descripcion,mat.Stock,mat.IdProveedor.RazonSocial,mat.IdTipoMaterial.Tipo);
                }
            }

        }

        private void dataMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataMaterial.CurrentRow.Cells[0].Value);
            FrmMaterial frm = new FrmMaterial(id);
            frm.ShowDialog();
            listarMaterial();
        }
    }
}

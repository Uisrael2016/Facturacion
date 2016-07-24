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
using Facturacion_Vista.Vistas.Agregar;


namespace Facturacion_Vista.Vistas.Listas
{
    public partial class FrmListarCodigo_Documento : DevComponents.DotNetBar.Office2007Form
    {
        private CodigoDocumentoDao codigoDocumentoDao = new CodigoDocumentoDao();
        private List<CodigoDocumento> listaCodigoDocumento;
        public CodigoDocumento codigoDocumentoSeleccionado { get; set; }
        Acciones _accion;
        public FrmListarCodigo_Documento(Acciones a)
        {
            InitializeComponent();
            this._accion = a;
            this.listarCodigoDocumentacion();
        }
        private void listarCodigoDocumentacion()
        {
            codigoDocumentoDao = new CodigoDocumentoDao();
            listaCodigoDocumento = (List<CodigoDocumento>)codigoDocumentoDao.consultar();
            if(listaCodigoDocumento!=null)
            {
                dtlista.Rows.Clear();
                foreach(CodigoDocumento cdoc in listaCodigoDocumento)
                {
                    if ((txtbuscar.Text == "")
                        || (cdoc.Codigo.Contains(txtbuscar.Text.ToUpper()))
                        || (cdoc.Documento.Contains(txtbuscar.Text.ToUpper())))
                    {
                        dtlista.Rows.Add(cdoc.IdCodigoDocumento, cdoc.Codigo, cdoc.Documento,cdoc.Secuencial);
                    }
                }
            }
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            FrmCodigo_Documento frm = new FrmCodigo_Documento(0);
            frm.ShowDialog();
            listarCodigoDocumentacion();
        }

        private void dtlista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtlista.CurrentRow.Cells[0].Value);
            FrmCodigo_Documento frm = new FrmCodigo_Documento(id);
            frm.ShowDialog();
            listarCodigoDocumentacion();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listarCodigoDocumentacion();
        }
    }
}

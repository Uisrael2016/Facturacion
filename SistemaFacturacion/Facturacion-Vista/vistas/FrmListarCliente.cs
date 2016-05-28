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

namespace Facturacion_Vista.Vistas
{
    public partial class FrmListarCliente : DevComponents.DotNetBar.Office2007Form
    {
        public FrmListarCliente()
        {
            InitializeComponent();
        }

        private void FrmListarCliente_Load(object sender, EventArgs e)
        {


        }
        ClienteDao dao = new ClienteDao();
        private void Lista()
        {
            
            //try
            //{
            //    this.dtlista.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
            //    //is.dtlista.DataSource = this.dao.consultar(this.txtbuscar.Text);
            //    this.dtlista.Columns[0].HeaderText = "Codigo";
            //    this.dtlista.Columns[0].Width = 100;
            //    this.dtlista.Columns[0].HeaderText = "Cliente";
            //    this.dtlista.Columns[0].Width = 300;
            //}

            //catch (Exception)
            //{
            //}
        }
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            FrmCliente frmcliente = new FrmCliente();
            frmcliente.nuevo = true;
            frmcliente.ShowDialog();
            this.Lista();
        }
    }
}

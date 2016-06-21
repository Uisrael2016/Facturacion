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
        private ClienteDao clienteDao = new ClienteDao();
        private List<Cliente> listaCliente;
        public FrmListarCliente()
        {
            InitializeComponent();
            listarCliente();
        }
       
        private void FrmListarCliente_Load(object sender, EventArgs e)
        {
            this.listarCliente();

        }
        
        public void listarCliente()
        {
            clienteDao = new ClienteDao();
            listaCliente = (List<Cliente>)clienteDao.consultar();
            if(listaCliente!=null)
            {
                dtlista.Rows.Clear();
                foreach(Cliente cli in listaCliente)
                {
                    dtlista.Rows.Add(cli.IdCliente, cli.Nombres
                        , cli.Apellidos, cli.Correo, cli.Direccion);
                }
            }
           
        }
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            FrmCliente frmcliente = new FrmCliente(0);
            frmcliente.ShowDialog();
            
        }
        //private ClienteDao clientedao;
        private void dtlista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtlista.CurrentRow.Cells[0].Value);
            FrmCliente frm = new FrmCliente(id);
            frm.ShowDialog();
            listarCliente();
        }
    }
}

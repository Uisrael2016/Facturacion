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
namespace Facturacion_Vista.Vistas
{
    public partial class FrmListarCliente : DevComponents.DotNetBar.Office2007Form
    {
        private ClienteDao clienteDao = new ClienteDao();
        private List<Cliente> listaCliente;
        public Cliente clienteSeleccionado { get; set; }
        Acciones _accion;
        public FrmListarCliente(Acciones a)
        {
            InitializeComponent();
            this._accion = a;
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
                        if ((txtbuscar.Text == "") 
                        || (cli.Nombres.Contains(txtbuscar.Text.ToUpper())) 
                        || (cli.Apellidos.Contains(txtbuscar.Text.ToUpper()))
                        || (cli.DocumentoCliente.Contains(txtbuscar.Text)))
                        {
                            dtlista.Rows.Add(cli.IdCliente, cli.DocumentoCliente, cli.Nombres + " " + cli.Apellidos, cli.Correo, cli.Direccion);
                        }
                }
            }
           
        }
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            FrmCliente frmcliente = new FrmCliente(0);
            frmcliente.ShowDialog();
            listarCliente();
            
        }
        private void dtlista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtlista.CurrentRow.Cells[0].Value);
            FrmCliente frm = new FrmCliente(id);
            frm.ShowDialog();
            listarCliente();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listarCliente();
        }

        private void dtlista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && _accion==Acciones.inject)
            {
                int id = Convert.ToInt32(dtlista.CurrentRow.Cells[0].Value);
                ClienteDao dao = new ClienteDao();
                clienteSeleccionado = dao.consultarPorId(id);
                this.Hide();
            }
        }
    }
}

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
        ClienteDao listaruser = new ClienteDao();
        private void FrmListarCliente_Load(object sender, EventArgs e)
        {
            this.Lista();

        }
        
        public void Lista()
        {
            try
            {
                dtlista.DataSource = listaruser.consultar();
            }
            catch
            {
                MessageBox.Show("error al obtener conexion ");
            }
           
        }
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            FrmCliente frmcliente = new FrmCliente();
            frmcliente.nuevo = true;
            frmcliente.ShowDialog();
            this.Lista();
        }
        //private ClienteDao clientedao;
        private void dtlista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                int idregistro = 0;
                FrmCliente frmcliente = new FrmCliente();
               // var model = this.listaruser.consultarPorId(int.Parse(this.dtlista.CurrentRow.Cells[0].Value.ToString()));
                idregistro = Convert.ToInt32(dtlista.CurrentRow.Cells[0].Value);
                ClienteDao clientedao = new ClienteDao();
                Cliente model = clientedao.consultarPorId(idregistro);
                frmcliente.cbxTipoDocumento.SelectedItem = model.IdTipoDocumento.ToString();
                frmcliente.txtDocumento.Text = model.DocumentoCliente;
                frmcliente.txtNombre.Text = model.Nombres;
                frmcliente.txtApellido.Text = model.Apellidos;
                frmcliente.txtEmail.Text = model.Correo;
                frmcliente.txtDireccion.Text = model.Direccion;
                frmcliente.txtTelefono.Text = model.Telefono;
                frmcliente.ShowDialog();
                this.Lista();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

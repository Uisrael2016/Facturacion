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
        
        private void Lista()
        {
            
            dtlista.DataSource = listaruser.consultar();
        }
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            FrmCliente frmcliente = new FrmCliente();
            frmcliente.nuevo = true;
            frmcliente.ShowDialog();
            this.Lista();
        }
        
        private void dtlista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FrmCliente frmcliente = new FrmCliente();
                var t = this.listaruser.consultarPorId(int.Parse(this.dtlista.CurrentRow.Cells[0].Value.ToString()));
                frmcliente.cbxTipoDocumento.Text = t.IdTipoDocumento.ToString();
                frmcliente.txtDocumento.Text = t.DocumentoCliente;
                frmcliente.txtNombre.Text = t.Nombres;
                frmcliente.txtApellido.Text = t.Apellidos;
                frmcliente.txtEmail.Text = t.Correo;
                frmcliente.txtDireccion.Text = t.Direccion;
                frmcliente.txtTelefono.Text = t.Telefono;
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

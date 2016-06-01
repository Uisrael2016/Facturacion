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
using Facturacion_AccesoDatos.dao;


namespace Facturacion_Vista.Vistas
{
    public partial class FrmCliente : DevComponents.DotNetBar.Office2007Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        public bool nuevo;
        private enum Tipo
        {
            insert,
            update,
            reload
        }

        private Tipo _tipo;
        private void FrmCliente_Load(object sender, EventArgs e)
        {
          cargar_combo();
            
        }
        private void cargar_combo()
        {
            TipoDocumentoDao tpdocumento = new TipoDocumentoDao();
            var lista = tpdocumento.consultar();

            cbxTipoDocumento.DataSource = lista;
            //xTipoDocumento.ad
            cbxTipoDocumento.DisplayMember = "Documento";
            cbxTipoDocumento.ValueMember = "IdTipoDocumento";
           
        }
        private void dato ()
        {
            ClienteDao incliente = new ClienteDao();
            Cliente clinete = new Cliente();
            incliente.insertar(clinete);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            erroricono.Clear();
            if (txtDocumento.Text == "")
            {
                erroricono.SetError(txtDocumento, "Campo Requerido");
                return;
            }

            if ( txtNombre.Text == "")
            {
                erroricono.SetError(txtNombre, "Campo Requerido");
                return;
            }

            if (txtApellido.Text == "")
            {
                erroricono.SetError(txtApellido, "Cmapo Requerido");
                return;
            }

            if (txtEmail.Text == "")
            {
                erroricono.SetError(txtEmail, "Campo Requerido");
                return;
            }

            try
            {

               

                ClienteDao insertarcliente = new ClienteDao();
                Cliente cliente = new Cliente();
                cliente.IdTipoDocumento = (TipoDocumento)cbxTipoDocumento.SelectedItem;
                cliente.DocumentoCliente = txtDocumento.Text;
                cliente.Nombres = txtNombre.Text;
                cliente.Apellidos = txtApellido.Text;
                cliente.Correo = txtEmail.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Telefono = txtTelefono.Text;
                if (_tipo == Tipo.insert)
                {
                    insertarcliente.insertar(cliente);
                    MessageBox.Show("Registro Agregado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                
                }
                       
            }
            catch
            {

            }
            this.Hide();

                 
        }

       
    }
}

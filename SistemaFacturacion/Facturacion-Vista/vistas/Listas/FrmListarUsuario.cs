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
using System.Collections;

namespace Facturacion_Vista.Vistas
{
    public partial class FrmListarUsuario : DevComponents.DotNetBar.Office2007Form
    {
        private UsuarioDao usuarioDAO = new UsuarioDao();
        private List<Usuario> listaUsuario;
        public Usuario usuarioSeleccionado { get; set; }
        Acciones _accion;
        public FrmListarUsuario(Acciones a)
        {
            InitializeComponent();
            this._accion = a;
            ListarUsuario();
        }

        private void FrmListarUsuario_Load(object sender, EventArgs e)
        {
            this.ListarUsuario();
        }
        public void ListarUsuario()
        {
            usuarioDAO = new UsuarioDao();
            listaUsuario = (List<Usuario>)usuarioDAO.consultar();
            if (listaUsuario != null)
            {
                dtLista.Rows.Clear();
                foreach (Usuario usu in listaUsuario)
                {
                    if((txtbuscar.Text=="")
                        || (usu.Nombre.Contains(txtbuscar.Text.ToUpper()))
                        || (usu.Mail.Contains(txtbuscar.Text))
                        || (usu.Documento.Contains(txtbuscar.Text)))
                    {
                        dtLista.Rows.Add(usu.IdUsuario, usu.Documento,
                       usu.Nombre, usu.Mail, usu.Telefono, usu.UserName, usu.Estado);
                    }
                }
            }
        }

        private void dtlista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_accion != Acciones.inject)
            {
                int id = Convert.ToInt32(dtLista.CurrentRow.Cells[0].Value);
                FrmUsuario frm = new FrmUsuario(id);
                frm.ShowDialog();
                ListarUsuario();
            }
            else
            {
                int id = Convert.ToInt32(dtLista.CurrentRow.Cells[0].Value);
                UsuarioDao dao = new UsuarioDao();
                usuarioSeleccionado = dao.consultarPorId(id);
                this.Hide();
            }
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            FrmUsuario frmusuario = new FrmUsuario(0);
            frmusuario.ShowDialog();
            ListarUsuario();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            ListarUsuario();
        }
    }
  }


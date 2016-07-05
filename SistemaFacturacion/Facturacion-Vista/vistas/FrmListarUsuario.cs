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
        public FrmListarUsuario()
        {
            InitializeComponent();
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
                    dtLista.Rows.Add(usu.IdUsuario, usu.Documento,
                        usu.Nombre, usu.Mail, usu.Telefono, usu.UserName);
                }
            }
        }

        private void dtlista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtLista.CurrentRow.Cells[0].Value);
            FrmUsuario frm = new FrmUsuario(id);
            frm.ShowDialog();
            ListarUsuario();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            FrmUsuario frmusuario = new FrmUsuario(0);
            frmusuario.ShowDialog();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            usuarioDAO = new UsuarioDao();
            int id = Convert.ToInt32(txtbuscar.Text);
            usuario = usuarioDAO.consultarPorId(id);
            dtLista.DataSource = usuario;
            }
        }
    }


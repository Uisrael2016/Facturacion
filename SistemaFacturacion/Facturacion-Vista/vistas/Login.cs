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
namespace Facturacion_Vista
{
    public partial class Login : DevComponents.DotNetBar.Office2007Form
    {
        public static UsuarioPerfil usuarioPerfilManager { get; set; }
        public Login()
        {
            
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            
            UsuarioDao dao = new UsuarioDao();
            UsuarioPerfilDao daoPerfil = new UsuarioPerfilDao();
            string user = textUser.Text.ToUpper();
            string pass = textPassword.Text;
            Usuario usuario = dao.buscaUsuario(user, pass);
            if (usuario !=null)
            {
                usuarioPerfilManager = daoPerfil.consultarPorId(usuario.IdUsuario);
                Utilidades.Mensaje.mensajeInformacion("Informacion", "Bienvenido al sistema usuario "+" " + usuario.UserName);
                Console.WriteLine(usuarioPerfilManager.IdUsuario.Nombre);
                Principal pa = new Principal();
                pa.Show();
                this.Hide(); 
            }else
            {
                Utilidades.Mensaje.mensajeAlerta("Informacion", "Usuario o Clave invalidos");
            }
        }

        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {

        }

    }
}


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
    public partial class Login : Form
    {
        public static UsuarioPerfil usuarioPerfilManager { get; set; }
        public Login()
        {

            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            string user = textUser.Text.ToUpper();
            string pass = textPassword.Text;
            foreach (var riboon in this.Controls.OfType<DevComponents.DotNetBar.RibbonBar>())
            {
                foreach (var textBox in riboon.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex))
                {
                    if (textBox.Text.Trim() == "")
                    {
                        errorProvider1.SetError(textBox, "El campo es obligatorio");
                        return;
                    }else
                    {
                        errorProvider1.Clear();
                    }
                }
            }
            UsuarioDao dao = new UsuarioDao();
            UsuarioPerfilDao daoPerfil = new UsuarioPerfilDao();
            Usuario usuario = dao.buscaUsuario(user, pass);
            if (usuario != null)
            {
                usuarioPerfilManager = daoPerfil.consultarPorId(usuario.IdUsuario);
                Utilidades.Mensaje.mensajeInformacion("Informacion", "Bienvenido al sistema usuario " + " " + usuario.UserName);
                Console.WriteLine(usuarioPerfilManager.IdUsuario.Nombre);
                Principal pa = new Principal();
                pa.Show();
                this.Hide();
            }
            else
            {
                Utilidades.Mensaje.mensajeAlerta("Informacion", "Usuario o Clave invalidos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = Utilidades.Mensaje.mensajeConfirm("Información", "Esta seguro de cerrar la aplicación");
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}


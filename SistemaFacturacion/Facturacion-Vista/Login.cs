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

namespace Facturacion_Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {

                UsuarioDao UsuarioDao = new UsuarioDao();
               bool de = UsuarioDao.validaUsuario("eea");
                MessageBox.Show("Cambio realizado", "CAmbio hecho por mi");
                // esto es un mensaje
                // esto es mensaje
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

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
        //Mensaje adicional 2da prueba
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //cambios el dia de hoy 13 
                //UsuarioDao UsuarioDao = new UsuarioDao();
                //Usuario user;
                //user = UsuarioDao.buscaUsuario(1);
                //UsuarioPerfilDao dao = new UsuarioPerfilDao();
                //UsuarioPerfil pr;

                //pr = dao.buscaPerfil(1);
                PerfilDao dao = new PerfilDao();
                Perfil pe;
                pe = dao.buscaPerfil(1);
                Console.WriteLine(pe.UsuarioPerfilList[0].IdUsuario.Nombre);
                //FacturaDao fac = new FacturaDao();
                //Factura factu;
                //factu = fac.buscaFactura(1);
                //Console.WriteLine(factu.IdNotaPedido);
               //bool de = UsuarioDao.validaUsuario("eea");
                MessageBox.Show("Cambio realizado", "CAmbio hecho por mi");
                // esto es un mensaje andres 13 
                // esto es mensaje
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

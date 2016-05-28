using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_AccesoDatos.dao;
using Facturacion_Vista.Vistas;
using Facturacion_Entidades;
using Facturacion_Vista.Utilidades;
namespace Facturacion_Vista
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            //MDIMenu menu = new MDIMenu();
            //Application.Run(new MDIMenu());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Acciones accion;
            EmpresaDao dao = new EmpresaDao();
            Empresa em = dao.buscaEmpresa();
            if (em != null)
            {
                Application.Run(new Login());
            }
            else
            {
                accion = Acciones.insert;
                Application.Run(new FrmEmpresa(accion));
            }

        }
    }
}

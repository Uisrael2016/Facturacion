using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_AccesoDatos.dao;
using Facturacion_Vista.Vistas;
using Facturacion_Entidades;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EmpresaDao dao = new EmpresaDao();
            Empresa em= dao.validaEmpresa();
            if (em != null)
            {
                Application.Run(new Login());
            }
            else {
                Application.Run(new FrmEmpresa());
            }
            
        }
    }
}

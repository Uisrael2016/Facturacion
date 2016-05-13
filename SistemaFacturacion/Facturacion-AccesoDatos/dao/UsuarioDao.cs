using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using Facturacion_Entidades;
using Facturacion_AccesoDatos.conexion;

namespace Facturacion_AccesoDatos.dao
{
    public class UsuarioDao 
    {
        public bool validaUsuario(string usuario)
        {
            using (ISession session = SessionFactory.abrirSession())
            {
                return (from e in session.Query<Usuario>() where e.user.Equals(usuario) select e).Count() > 0;
            }
        }
    }
}

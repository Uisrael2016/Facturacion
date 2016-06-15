using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using Facturacion_Entidades;
using Facturacion_AccesoDatos.conexion;
using NHibernate.Criterion;
namespace Facturacion_AccesoDatos.dao
{
    public class UsuarioPerfilDao : GenericaDao<UsuarioPerfil>
    {
        public UsuarioPerfil buscaUsuario(int idUsuario)
        {
            try
            {
                using (ISession session = SessionFactory.abrirSession())
                {
                    ICriteria c = session.CreateCriteria("UsuarioPerfil");
                    c.Add(Expression.Eq("IdUsuario.IdUsuario",idUsuario));
                    return c.UniqueResult<UsuarioPerfil>();
                }
            }
            catch (Exception ex) 
            {
                return null;
            }
            
        }
    }

}

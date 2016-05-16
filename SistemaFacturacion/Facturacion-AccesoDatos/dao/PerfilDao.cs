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
    public class PerfilDao
    {
        public Perfil buscaPerfil(int id)
        {
            using (ISession session = SessionFactory.abrirSession())
            {
                ICriteria c = session.CreateCriteria("Perfil");
                c.Add(Expression.Eq("IdPerfil", id));
                return c.UniqueResult<Perfil>();
            }


        }
    }
}

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
   public class ClienteDao
    {
        public Cliente buscaCliente(int id)
        {
            using (ISession session = SessionFactory.abrirSession())
            {
                ICriteria c = session.CreateCriteria("Cliente");
                c.Add(Expression.Eq("IdCliente", id));
                return c.UniqueResult<Cliente>();
            }


        }
    }
}

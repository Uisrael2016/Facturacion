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
    public class TarifaDao:GenericaDao<Tarifa>
    {
        public Tarifa buscaTarifa() {
            try
            {
                using (ISession session = SessionFactory.abrirSession())
                {
                    ICriteria c = session.CreateCriteria("Tarifa");
                    c.Add(Expression.Eq("Estado",'A'));
                    return c.UniqueResult<Tarifa>();
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

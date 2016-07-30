using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using NHibernate;
using NHibernate.Linq;
using Facturacion_Entidades;
using Facturacion_AccesoDatos.conexion;
using NHibernate.Criterion;
namespace Facturacion_AccesoDatos.dao
{
   public class CabeceraDao: GenericaDao<Cabecera>
    {
        public List<Cabecera> listaCabecera()
        {
            try
            {
                using (ISession session = SessionFactory.abrirSession())
                {
                    string valor = "NP";
                    ICriteria criterio = session.CreateCriteria("Cabecera");
                    criterio.Add(Expression.Eq("IdCodigoDocumento.IdCodigoDocumento", 2));
                    criterio.Add(Expression.Eq("Estado","IN"));
                    criterio.AddOrder(Order.Asc("IdCabecera"));
                    return (List<Cabecera>)criterio.List<Cabecera>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}

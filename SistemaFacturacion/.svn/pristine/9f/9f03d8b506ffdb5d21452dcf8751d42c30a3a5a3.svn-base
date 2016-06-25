using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using NHibernate.Criterion;
using NHibernate;
using NHibernate.Linq;
using Facturacion_AccesoDatos.conexion;
namespace Facturacion_AccesoDatos.dao
{
    public class AmbienteDao : GenericaDao<Ambiente>
    {
     public List<Ambiente> listaAmbiente()
        {
            try
            {
                using (ISession session=SessionFactory.abrirSession())
                {
                    ICriteria criterio = session.CreateCriteria("Ambiente");
                    criterio.Add(Expression.Eq("Estado", 'A'));
                    criterio.AddOrder(Order.Asc("IdAmbiente"));
                    return (List<Ambiente>)criterio.List<Ambiente>();
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

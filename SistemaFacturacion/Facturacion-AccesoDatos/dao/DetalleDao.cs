using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_AccesoDatos;
using Facturacion_Entidades;
using NHibernate.Criterion;
using NHibernate;
using NHibernate.Linq;
using Facturacion_AccesoDatos.conexion;
namespace Facturacion_AccesoDatos.dao
{
    public class DetalleDao : GenericaDao<Detalle>
    {
        public List<Detalle> listaDetalle(int idCabecera)
        {
            try
            {
                using (ISession session = SessionFactory.abrirSession())
                {
                    ICriteria criterio = session.CreateCriteria("Detalle");
                    criterio.Add(Expression.Eq("IdCabecera.IdCabecera", idCabecera));
                    return (List<Detalle>)criterio.List<Detalle>();
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

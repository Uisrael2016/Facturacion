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
    public class CodigoDocumentoDao:GenericaDao<CodigoDocumento>
    {
        public CodigoDocumento buscaCodigoDocumento(string codigo)
        {

            try
            {
                using (ISession session = SessionFactory.abrirSession())
                {
                    ICriteria c = session.CreateCriteria("CodigoDocumento");
                    c.Add(Expression.Eq("Codigo", codigo));

                    return c.UniqueResult<CodigoDocumento>();
                }

            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}

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
   public class EmpresaDao : GenericaDao<Empresa>
    {
        public Empresa validaEmpresa()
        {
            try
            {
                using (ISession session = SessionFactory.abrirSession())
                {
                    ICriteria criterio = session.CreateCriteria("Empresa");
                    return criterio.UniqueResult<Empresa>();
                }   
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}

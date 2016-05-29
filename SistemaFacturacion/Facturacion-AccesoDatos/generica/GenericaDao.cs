using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using Facturacion_AccesoDatos.conexion;
namespace Facturacion_AccesoDatos
{
    public class GenericaDao<T> : InterfaceDao<T> where T : class
    {
        public void insertar(T entidad)
        {
            using (ISession session = SessionFactory.abrirSession())
            {
                using (ITransaction transaccion = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entidad);
                        transaccion.Commit();

                    }
                    catch (Exception ex)
                    {
                        if (!transaccion.WasCommitted)
                        {
                            transaccion.Rollback();
                        }
                        throw new Exception("Error al grabar entidad " + ex.Message);
                    }
                }

            }

        }
        public void eliminar(T entidad)
        {
            using (ISession session = SessionFactory.abrirSession())
            {
                using (ITransaction transaccion = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entidad);
                        transaccion.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transaccion.WasCommitted)
                        {
                            transaccion.Rollback();
                        }
                        throw new Exception("Error al eliminar entidad " + ex.Message);
                    }
                }

            }
        }
        
        
        public void modificar(T entidad)
        {
            using (ISession session = SessionFactory.abrirSession())
            {
                using (ITransaction transaccion = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidad);
                        transaccion.Commit();

                    }
                    catch (Exception ex)
                    {
                        if (!transaccion.WasCommitted)
                        {
                            transaccion.Rollback();
                        }
                        throw new Exception("Error al actualizar entidad " + ex.Message);
                    }
                }

            }
        }
        public IList<T> consultar()
        {
            using (ISession session = SessionFactory.abrirSession())
            {
                return (from e in session.Query<T>() select e).ToList();
            }
        }

        public T consultarPorId(int id)
        {
            using (ISession session = SessionFactory.abrirSession ())
            {
                return session.Get<T>(id);
            }

        }
        
    }
}

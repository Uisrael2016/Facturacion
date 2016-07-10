using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using Facturacion_AccesoDatos.mapping;
 
namespace Facturacion_AccesoDatos.conexion
{
   public class SessionFactory
    {
        private static ISessionFactory session;
        //cambios de versionado aja ojala valga
        public static ISessionFactory crearSession()
        {
            if (session != null)
                return session;
            try
            {

                session = Fluently.Configure()
                           .Database(PostgreSQLConfiguration.PostgreSQL82.Raw("hbm2ddl.keywords", "none")
                           .ConnectionString(c => c
                           .Host("localhost")
                           .Port(5433)
                           .Database("facturacion")
                           .Username("postgres")
                           .Password("postgres")))
                           .Mappings(x => x.FluentMappings.AddFromAssemblyOf<UsuarioMap>())
                           .BuildSessionFactory();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return session;
        }

        public static ISession abrirSession()
        {
            return crearSession().OpenSession();
        }
    }
}

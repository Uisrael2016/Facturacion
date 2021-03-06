﻿using System;
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
    public class UsuarioDao : GenericaDao<Usuario>
    {
        public Usuario buscaUsuario(string usuario, string password)
        {
            try
            {
                using (ISession session = SessionFactory.abrirSession())
                {
                    ICriteria c = session.CreateCriteria("Usuario");
                    c.Add(Expression.Eq("UserName", usuario))
                    .Add(Expression.Eq("Clave", password));
                    return c.UniqueResult<Usuario>();
                }

            }
            catch (Exception ex)
            {
                return null;
            }


        }
    }
}

﻿using System;
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
    public class SecuencialDao : GenericaDao<Secuencial>
    {
        public Secuencial buscaSecuencial(string codigo)
        {
            
            try
            {
                using (ISession session = SessionFactory.abrirSession())
                {
                    ICriteria c = session.CreateCriteria("Secuencial");
                    c.Add(Expression.Eq("Codigo",codigo ));

                    return c.UniqueResult<Secuencial>();
                }

            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
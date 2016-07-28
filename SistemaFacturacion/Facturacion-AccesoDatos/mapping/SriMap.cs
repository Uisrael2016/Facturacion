using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;

namespace Facturacion_AccesoDatos.mapping
{
    public class SriMap :ClassMap<Sri>
    {
        public SriMap() {
            Schema("public");
            Table("sri");
            Id(c => c.IdSri).Column("id_sri").GeneratedBy.Identity();
            Map(c => c.Autorizacion).Column("autorizacion");
            Map(c => c.ClaveAcceso).Column("clave_acceso");
            Map(c => c.Estado).Column("estado");
            Map(c => c.FechaAutorizacion).Column("fecha_autorizacion");
            Map(c => c.CodigoError).Column("codigo_error");
            Map(c => c.MensajeError).Column("msm_error");
            References(c => c.IdCabecera).Class<Cabecera>().Column("id_cabecera").Not.LazyLoad();
        }
    }
}

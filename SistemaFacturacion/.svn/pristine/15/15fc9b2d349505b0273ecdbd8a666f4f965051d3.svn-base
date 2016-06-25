using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    public class FacturaImpuestoMap :ClassMap<FacturaImpuesto>
    {
        public FacturaImpuestoMap()
        {
            Id(c => c.IdImpuesto).Column("id_impuesto").GeneratedBy.Identity();
            Map(c => c.BaseImponible).Column("base_imponible");
            Map(c => c.Valor).Column("valor");
            References(c => c.IdTarifa).Class<Tarifa>().Column("id_tarifa").Not.LazyLoad();
            HasMany<Factura>(c => c.FacturaList).KeyColumn("id_factura").Inverse().Not.LazyLoad();
        }
    }
}


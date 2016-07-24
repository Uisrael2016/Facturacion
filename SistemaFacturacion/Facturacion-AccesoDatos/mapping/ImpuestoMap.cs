using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;

namespace Facturacion_AccesoDatos.mapping
{
    public class ImpuestoMap : ClassMap<Impuesto>
    {
        public ImpuestoMap()
        {
            Schema("public");
            Table("impuesto");
            Id(c => c.IdImpuesto).Column("id_impuesto").GeneratedBy.Identity();
            Map(c => c.BaseImponible).Column("base_imponible");
            Map(c => c.Valor).Column("valor");
            Map(c =>c.Codigo).Column("codigo");
            Map(c =>c.CodigoPorcentaje).Column("codigo_porcentaje");
            References(c => c.IdTarifa).Class<Tarifa>().Column("id_tarifa").Not.LazyLoad();
            References(c => c.IdCabecera).Class<Cabecera>().Column("id_cabecera").Not.LazyLoad();

        }

    }
}

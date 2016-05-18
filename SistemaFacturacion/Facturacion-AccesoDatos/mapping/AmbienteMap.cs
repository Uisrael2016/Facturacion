using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    public class AmbienteMap : ClassMap<Ambiente>
    {
       public AmbienteMap()
        {
            Schema("public");
            Table("ambiente");
            Id(c => c.IdAmbiente).Column("id_ambiente").GeneratedBy.Identity();
            Map(c => c.Codigo).Column("codigo");
            Map(c => c.Descripcion).Column("descripcion");
            Map(c => c.Estado).Column("estado");
            HasMany<Factura>(c => c.FacturaList).KeyColumn("id_factura").Inverse().Not.LazyLoad();
        }

    }
}


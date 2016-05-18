using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    public class FormaPagoMap :ClassMap<FormaPago>
    {
        public FormaPagoMap()
        {
            Schema("public");
            Table("forma_pago");
            Id(c => c.IdFormaPago).Column("id_forma_pago").GeneratedBy.Identity();
            Map(c => c.Descripcion).Column("descripcion");
            HasMany<Factura>(c => c.FacturaList).KeyColumn("id_factura").Inverse().Not.LazyLoad();
        }

    }
}

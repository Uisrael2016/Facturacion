using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    public class EstablecimientoMap : ClassMap<Establecimiento>
    {
        public EstablecimientoMap()
        {
            Schema("public");
            Table("establecimiento");
            Id(c => c.IdEstablecimiento).Column("id_establecimiento").GeneratedBy.Identity();
            Map(c => c.Nombre).Column("nombre");
            Map(c => c.Direccion).Column("direccion");
            Map(c => c.Estado).Column("estado");
            HasMany<PuntoEmision>(c => c.PuntoEmisionList).Inverse().KeyColumn("id_punto_emision").Not.LazyLoad();

        }
    }
}

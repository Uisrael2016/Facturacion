using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    public class MaterialMap : ClassMap<Material>
    {
        public MaterialMap()
        {
            Id(c => c.IdMaterial).GeneratedBy.Identity().Column("id_material");
            Map(c => c.Descripcion).Column("descripcion");
            Map(c => c.FechaIngreso).Column("fecha_ingreso");
            Map(c => c.FechaEgreso).Column("fecha_egreso");
            References(c => c.IdTipoMaterial).Class<TipoMaterial>().Column("id_tipo_material").Not.LazyLoad();
            References(c => c.IdProveedor).Class<Proveedor>().Column("id_proveedor").Not.LazyLoad();
            HasMany(c => c.DetalleProductoList).Inverse().KeyColumn("id_detalle_producto").Not.LazyLoad();
        }
    }
}

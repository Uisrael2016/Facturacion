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
            Schema("public");
            Table("material");
            Id(c => c.IdMaterial).GeneratedBy.Identity().Column("id_material");
            Map(c => c.Descripcion).Column("descripcion");
            Map(c => c.Stock).Column("stock");
            References(c => c.IdTipoMaterial).Class<TipoMaterial>().Column("id_tipo_material").Not.LazyLoad();
            References(c => c.IdProveedor).Class<Proveedor>().Column("id_proveedor").Not.LazyLoad();
            HasMany(c => c.DetalleProductoList).Inverse().KeyColumn("id_detalle_producto").Cascade.All();
            HasMany(c => c.IngresoList).Inverse().KeyColumn("id_ingreso").Cascade.All();
            HasMany(c => c.SalidaList).Inverse().KeyColumn("id_salida").Cascade.All();
        }
    }
}

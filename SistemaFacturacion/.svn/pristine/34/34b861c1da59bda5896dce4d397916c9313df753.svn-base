using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
   public class DetalleProductoMap : ClassMap<DetalleProducto>
    {
        public DetalleProductoMap()
        {
            Table("detalle_producto");
            Id(c => c.IdDetalleProducto).GeneratedBy.Identity().Column("id_detalle_producto");
            Map(c => c.DescDetalle).Column("desc_detalle");
            Map(c => c.Cantidad).Column("cantidad");
            References(c => c.IdMaterial).Class<Material>().Column("id_material").Not.LazyLoad();
            HasMany<Producto>(c => c.ProductoList).Inverse().KeyColumn("id_producto").Cascade.All();
        }
    }
}

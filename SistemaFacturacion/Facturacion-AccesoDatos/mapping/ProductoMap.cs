using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    public class ProductoMap : ClassMap<Producto>
    {
        public ProductoMap()
        {
            Table("producto");
            Id(c =>c.IdProducto).GeneratedBy.Identity().Column("id_producto");
            Map(c => c.DescProducto).Column("desc_prodcuto");
            Map(c => c.Tipo).Column("tipo");
            Map(c => c.Imagen).Column("imagen");
            Map(c => c.Precio).Column("precio");
            Map(c => c.Descuento).Column("descuento");
            HasMany<DetalleProducto>(c => c.DetalleProductoList).KeyColumn("id_detalle_producto").Inverse().Not.LazyLoad();
            HasMany<Detalle>(c => c.DetalleList).KeyColumn("id_detalle").Inverse().Not.LazyLoad();
        }
    }
}

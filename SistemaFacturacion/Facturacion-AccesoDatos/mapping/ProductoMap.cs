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
            References(c => c.IdDetalleProducto).Class<DetalleProducto>().Column("id_detalle_producto").Not.LazyLoad();

        }
    }
}

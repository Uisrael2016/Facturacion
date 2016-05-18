using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;

namespace Facturacion_AccesoDatos.mapping
{
    public class NotaPedidoMap : ClassMap<NotaPedido>
    {
        public NotaPedidoMap()
        {
            Table("nota_pedido");
            Id(c => c.IdNotaPedido).Column("id_nota_pedido");
            Map(c => c.CodigoPedido).Column("codigo_pedido").Unique();
            Map(c => c.Cantidad).Column("cantidad");
            Map(c => c.PrecioUnitario).Column("precio");
            Map(c => c.FechaIngreso).Column("fecha_ingreso");
            Map(c => c.Estado).Column("estado");
            Map(c => c.Descripcion).Column("descripcion");
            Map(c => c.Descuento).Column("descuento");
            Map(c => c.TotalSinImpuesto).Column("total_sinimpuesto");
            References(c => c.IdProducto).Class<Producto>().Column("id_producto").Not.LazyLoad();
            References(c => c.IdUsuario).Class<Usuario>().Column("id_usuario").Not.LazyLoad();
            HasMany<Factura>(c => c.FacturaList).KeyColumn("id_factura").Inverse().Not.LazyLoad();
        }
    }
}

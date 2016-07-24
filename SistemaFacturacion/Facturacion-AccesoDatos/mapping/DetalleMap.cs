using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos
{
    public class DetalleMap : ClassMap<Detalle>
    {
        public DetalleMap()
        {
            Schema("public");
            Table("detalle");
            Id(c => c.IdDetalle).Column("id_detalle").GeneratedBy.Identity();
            Map(c => c.Cantidad).Column("cantidad");
            Map(c => c.PrecioTotal).Column("precio_total");
            References(c => c.IdCabecera).Class<Cabecera>().Column("id_cabecera").Not.LazyLoad();
            References(c => c.IdProducto).Class<Producto>().Column("id_producto").Not.LazyLoad();



        }
    }
}

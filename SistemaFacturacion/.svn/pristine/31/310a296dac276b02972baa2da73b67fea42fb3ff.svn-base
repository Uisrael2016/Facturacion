using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    public class ProformaMap : ClassMap<Proforma>
    {
        public ProformaMap()
        {
            Table("proforma");
            Id(x => x.IdProforma).Column("id_proforma").GeneratedBy.Identity();
            Map(x => x.CodigoProforma).Column("codigo_proforma");
            Map(c => c.Cantidad).Column("cantidad");
            Map(c => c.Precio).Column("precio");
            Map(c => c.FechaIngreso).Column("fecha_ingreso");
            References(c => c.IdUsuario).Class<Usuario>().Column("id_usuario").Not.LazyLoad();
            References(c => c.IdProducto).Class<Producto>().Column("id_producto").Not.LazyLoad();
            References(c => c.IdCliente).Class<Cliente>().Column("id_cliente").Not.LazyLoad();

        }
    }
}

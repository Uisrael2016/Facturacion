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
            Id(c => c.IdProforma).GeneratedBy.Identity();
            Map(c => c.Cantidad).Column("cantidad");
            Map(c => c.Precio).Column("precio");
            Map(c => c.FechaIngreso).Column("fecha_ingreso");
            References(c => c.IdUsuario).Class<Usuario>().Column("id_usuario").Not.LazyLoad();
            References(c => c.IdProducto).Class<Producto>().Column("id_producto").Not.LazyLoad();
           
        }
    }
}

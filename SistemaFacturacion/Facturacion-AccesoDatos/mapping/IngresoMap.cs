using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Facturacion_Entidades;
namespace Facturacion_AccesoDatos.mapping
{
    public class IngresoMap: ClassMap<Ingreso>
    {
        public IngresoMap()
        {
            Schema("public");
            Table("ingreso");
            Id(c =>c.IdIngreso).Column("id_ingreso").GeneratedBy.Identity();
            Map(c =>c.CantidadIngreso).Column("cantidad_ingreso");
            Map(c => c.FechaIngreso).Column("fecha_ingreso");
            Map(c => c.UsuarioIngreso).Column("usuario_ingreso"); ;
            References(c => c.IdMaterial).Class<Material>().Column("id_material").Cascade.All();
        }
    }
}

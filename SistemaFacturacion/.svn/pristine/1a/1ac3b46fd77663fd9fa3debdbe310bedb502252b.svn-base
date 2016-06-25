using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Facturacion_Entidades;
namespace Facturacion_AccesoDatos.mapping
{
    public class SalidaMap : ClassMap<Salida>
    {
        public SalidaMap()
        {
            Schema("public");
            Table("salida");
            Id(c => c.IdSalida).Column("id_salida").GeneratedBy.Identity();
            Map(c => c.CantidadEgreso).Column("cantidad_egreso");
            Map(c => c.FechaEgreso).Column("fecha_egreso");
            Map(c => c.UsuarioEgreso).Column("usuario_egreso"); ;
            References(c => c.IdMaterial).Class<Material>().Column("id_material").Cascade.All();
        }
    }
}

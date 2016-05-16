using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    class ProveedorMap : ClassMap<Proveedor>
    {
        public ProveedorMap()
        {
            Id(c => c.IdProveedor).GeneratedBy.Identity().Column("id_proveedor");
            Map(c => c.Documento).Column("documento");
            Map(c => c.Nombres).Column("nombres");
            Map(c => c.Apellidos).Column("apellidos");
            Map(c => c.Email).Column("email");
            Map(c => c.Estado).Column("estado");
            Map(c => c.FechaIngreso).Column("fecha_ingreso");
            Map(c => c.FechaEgreso).Column("fecha_egreso");
            Map(c => c.UsuarioIngresa).Column("usuario_ingresa");
            Map(c => c.UsuarioEgresa).Column("usuario_egresa");
            HasMany<Material>(c => c.MateriaList).Inverse().KeyColumn("id_material");       
        }
    }
}

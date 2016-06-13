using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    class ClienteMap : ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Table("cliente");
            Id(c => c.IdCliente).Column("id_cliente").GeneratedBy.Identity();
            Map(c => c.DocumentoCliente).Column("documento_cliente").Unique();
            Map(c => c.Nombres).Column("nombres");
            Map(c => c.Apellidos).Column("apellidos");
            Map(c => c.Correo).Column("correo");
            Map(c => c.Telefono).Column("telefono");
            Map(c => c.FechaIngreso).Column("fecha_ingreso");
            Map(c => c.FechaEgreso).Column("fecha_egreso");
            Map(c => c.UsuarioIngreso).Column("usuario_ingreso");
            Map(c => c.UsuarioEgreso).Column("usuario_egreso");
            HasMany<Proforma>(c => c.ProformaList).Inverse().KeyColumn("id_proforma").Not.LazyLoad();
            References(c => c.IdTipoDocumento).Class<TipoDocumento>().Column("id_tipo_documento").Cascade.All();
        }
    }
}

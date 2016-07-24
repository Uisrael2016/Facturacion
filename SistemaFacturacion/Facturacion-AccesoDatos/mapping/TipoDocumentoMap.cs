using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Facturacion_Entidades;


namespace Facturacion_AccesoDatos.mapping
{
    public class TipoDocumentoMap : ClassMap<TipoDocumento>
    {
        public TipoDocumentoMap()
        {
            Schema("public");
            Table("tipo_documento");
            Id(c => c.IdTipoDocumento).Column("id_tipo_documento").GeneratedBy.Identity();
            Map(c => c.Documento).Column("documento");
            Map(c => c.Codigo).Column("codigo");
            HasMany<Usuario>(c => c.UsuarioList).KeyColumn("id_usuario").Inverse().Not.LazyLoad();
            HasMany<Cliente>(c => c.CLienteList).KeyColumn("id_cliente").Inverse().Not.LazyLoad();
            HasMany<Proveedor>(c => c.ProveedorList).KeyColumn("id_proveedor").Inverse().Not.LazyLoad();
        }
    }
}

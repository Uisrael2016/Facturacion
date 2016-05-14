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
            Table("tipo_documento");
            Id(c => c.IdTipoDocumento).GeneratedBy.Identity().Column("id_tipo_documento");
            Map(c => c.Documento).Column("documento");
            HasMany<Usuario>(c => c.UsuarioList).Inverse().KeyColumn("id_usuario");
            
        }
    }
}

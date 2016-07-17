using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    public class PuntoEmisionMap : ClassMap<PuntoEmision>
    {
        public PuntoEmisionMap()
        {
            Schema("public");
            Table("punto_emision");
            Id(c => c.IdPuntoEmision).Column("id_punto_emision").GeneratedBy.Identity();
            Map(c => c.Codigo).Column("codigo");
            Map(c => c.Estado).Column("estado");
            References(c => c.IdEstablecimiento).Class<Establecimiento>().Column("id_establecimiento").Not.LazyLoad();
            HasMany<UsuarioPerfil>(c => c.UsuarioPerfilList).Inverse().KeyColumn("id_usuario_perfil").Not.LazyLoad();
        }
    }
}

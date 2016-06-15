using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Facturacion_Entidades;
namespace Facturacion_AccesoDatos.mapping
{
    public class PerfilMap : ClassMap<Perfil>
    {
        public PerfilMap()
        {
            Table("perfil");
            Id(c => c.IdPerfil).GeneratedBy.Identity().Column("id_perfil");
            Map(c => c.Descripcion).Column("descripcion");
            Map(c => c.Codigo).Column("codigo");
            Map(c => c.Estado).Column("estado");
            HasMany<UsuarioPerfil>(c => c.UsuarioPerfilList).Inverse().KeyColumn("id_usuario_perfil").Not.LazyLoad();
        }
    }
}

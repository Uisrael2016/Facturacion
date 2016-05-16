using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    public class UsuarioPerfilMap : ClassMap<UsuarioPerfil>
    {
        public UsuarioPerfilMap()
        {
            Table("usuario_perfil");
            Id(c => c.IdUsuarioPerfil).GeneratedBy.Identity().Column("id_usuario_perfil");
            References(c => c.IdUsuario).Class<Usuario>().Column("id_usuario").Not.LazyLoad();
            References(c => c.IdPerfil).Class<Perfil>().Column("id_perfil").Not.LazyLoad();
        }
    }
}

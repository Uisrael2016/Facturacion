using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Facturacion_Entidades;

namespace Facturacion_AccesoDatos.mapping
{
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            Table("usuario");
            Id(c => c.IdUsuario).GeneratedBy.Identity().Column("id_usuario");
            Map(c => c.Nombre).Column("nombre").Unique();
            Map(c => c.Documento).Column("documento").Unique();
            Map(c => c.Mail).Column("mail").Unique();
            Map(c => c.CambiarClave).Column("cambiarclave");
            Map(c => c.FechaIngreso).Column("fecha_ingreso");   
            Map(c => c.UserName).Column("user_name");
            Map(c => c.Clave).Column("clave");
            Map(c => c.Estado).Column("estado");
            Map(c => c.Telefono).Column("telefono");
            Map(c => c.UsuarioIngreso).Column("usuario_ingreso");
            References(c => c.IdTipoDucumento).Class<TipoDocumento>().Column("id_tipo_documento").Cascade.All();
            HasMany<NotaPedido>(c => c.NotaPedidoList).Inverse().KeyColumn("id_nota_pedido").Cascade.All();
            HasMany<UsuarioPerfil>(c => c.UsuarioPerfilList).Inverse().KeyColumn("id_usuario_perfil").Not.LazyLoad();
            HasMany<Proforma>(c => c.ProformaList).Inverse().KeyColumn("id_proforma").Not.LazyLoad();
        }

    }
}



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
            Id(c => c.IdUsuario).GeneratedBy.Identity().Column("id_usuario");
            Map(c => c.Nombre).Column("nombre");
            Map(c => c.Documento).Column("documento");
            Map(c => c.Mail).Column("mail");
            Map(c => c.CambiarClave).Column("cambiarclave");
            Map(c => c.FechaIngreso).Column("fecha_ingreso");
            Map(c => c.User).Column("user");
            Map(c => c.Clave).Column("clave");
            Map(c => c.Estado).Column("estado");
            Map(c => c.Telefono).Column("telefono");
            Table("usuario");
        }

    }
}



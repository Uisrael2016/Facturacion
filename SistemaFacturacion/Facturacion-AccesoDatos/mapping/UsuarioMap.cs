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
            Id(c => c.idUsuario);
            Map(c => c.idTipoDocumento);
            Map(c => c.documento);
            Map(c => c.nombre);
            Map(c => c.mail);
            Map(c => c.cambiarClave);
            Map(c => c.fechaRegistro);
            Map(c => c.usuarioCreacion);
            Map(c => c.user);
            Map(c => c.clave);
            Map(c => c.estado);
            Map(c => c.telefono);
            Table("usuario");
        }

    }
}



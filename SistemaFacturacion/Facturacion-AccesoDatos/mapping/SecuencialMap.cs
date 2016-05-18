using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    class SecuencialMap : ClassMap<Secuecial>
    {
        public SecuencialMap()
        {
            Id(c => c.Codigo).Column("codigo").GeneratedBy.Assigned();
            Map(c => c.Descripcion).Column("descripcion");
            Map(c => c.Valor).Column("valor").Generated.Insert();
        }
    }
}

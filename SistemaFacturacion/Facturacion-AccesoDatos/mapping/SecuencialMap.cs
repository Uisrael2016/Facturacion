using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    class SecuencialMap : ClassMap<Secuencial>
    {
        public SecuencialMap()
        {
            Table("secuencial");
            Schema("public");
            Id(c => c.Codigo).Column("codigo");
            Map(c => c.Descripcion).Column("descripcion");
            Map(c => c.Valor).Column("valor");
        }
    }
}

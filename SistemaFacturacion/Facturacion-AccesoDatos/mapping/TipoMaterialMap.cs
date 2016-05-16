using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Facturacion_Entidades;
namespace Facturacion_AccesoDatos.mapping
{
    public class TipoMaterialMap : ClassMap<TipoMaterial>
    {
        public TipoMaterialMap()
        {
            Id(c => c.IdTipoMaterial).GeneratedBy.Identity().Column("id_tipo_material");
            Map(c => c.Tipo).Column("tipo");
            HasMany<Material>(c => c.MaterialList).Inverse().KeyColumn("id_material").Not.LazyLoad();
        }
    }
}

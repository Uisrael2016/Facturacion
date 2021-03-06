﻿using System;
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
            Schema("public");
            Table("tipo_material");
            Id(c => c.IdTipoMaterial).GeneratedBy.Identity().Column("id_tipo_material");
            Map(c => c.Tipo).Column("tipo");
            Map(c => c.Codigo).Column("codigo");
            HasMany<Material>(c => c.MaterialList).Inverse().KeyColumn("id_material").Not.LazyLoad();
        }
    }
}

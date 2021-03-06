﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    public class TarifaMap : ClassMap<Tarifa>
    {
       public TarifaMap()
        {
            Schema("public");
            Table("tarifa");
            Id(c => c.IdTarifa).Column("id_tarifa").GeneratedBy.Identity();
            Map(c => c.ValTarifa).Column("val_tarifa");
            Map(c => c.Estado).Column("estado");
            HasMany<Impuesto>(c => c.ImpuestoList).KeyColumn("id_impuesto").Inverse().Not.LazyLoad();
        }
    }
}


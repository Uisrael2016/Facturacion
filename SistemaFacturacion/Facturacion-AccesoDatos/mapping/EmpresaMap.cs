using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    public class EmpresaMap : ClassMap<Empresa>
    {
        public EmpresaMap()
        {
            Schema("public");
            Table("empresa");
            Id(c => c.IdEmpresa).Column("id_empresa").GeneratedBy.Identity();
            Map(c => c.Ruc).Column("ruc");
            Map(c => c.RazonSocial).Column("razon_social");
            Map(c => c.DirecMatriz).Column("direc_matriz");
            Map(c => c.PathLogo).Column("path_logo");
            Map(c => c.Estado).Column("estado");
            Map(c => c.Contabilidad).Column("contabilidad");
            References(c => c.IdAmbiente).Class<Ambiente>().Column("id_ambiente").Not.LazyLoad();
            HasMany<Cabecera>(c => c.CabeceraList).KeyColumn("id_cabecera").Inverse().Not.LazyLoad();
        }
    }
}



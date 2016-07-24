using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;

namespace Facturacion_AccesoDatos.mapping
{
    public class CabeceraMap : ClassMap<Cabecera>
    {
        public CabeceraMap()
        {
            Schema("public");
            Table("cabecera");
            Id(c => c.IdCabecera).Column("id_cabecera").GeneratedBy.Identity();
            Map(c => c.Secuencial).Column("secuencial");
            Map(c => c.FechaEmision).Column("fecha_emision");
            Map(c => c.TotalSinImpuesto).Column("total_sin_impuesto");
            Map(c => c.TotalDescuento).Column("total_descuento");
            Map(c => c.Propina).Column("propina");
            Map(c => c.Total).Column("total");
            Map(c => c.Moneda).Column("moneda");
            Map(c=>c.Estado).Column("estado");
            References(c => c.IdEmpresa).Class<Empresa>().Column("id_empresa").Not.LazyLoad();
            References(c => c.IdCodigoDocumento).Class<CodigoDocumento>().Column("id_codigo_documento").Not.LazyLoad();
            References(c => c.IdFormaPago).Class<FormaPago>().Column("id_forma_pago").Not.LazyLoad();
            References(c => c.IdCliente).Class<Cliente>().Column("id_cliente").Not.LazyLoad();
            References(c => c.IdUsuarioPerfil).Class<UsuarioPerfil>().Column("id_usuario_perfil").Not.LazyLoad();
            HasMany<Impuesto>(c => c.ImpuestoList).KeyColumn("id_impuesto").Inverse().Not.LazyLoad();
            HasMany<Sri>(c => c.SriList).KeyColumn("id_sri").Inverse().Not.LazyLoad();




        }
    }
}

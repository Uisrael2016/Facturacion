using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    public class FacturaMap :ClassMap<Factura>
    {
        public FacturaMap()
        {
            Schema("public");
            Table("factura");
            Id(c => c.IdFactura).Column("id_factura").GeneratedBy.Identity();
            Map(c => c.Secuencial).Column("secuencial");
            Map(c => c.Autorizacion).Column("autorizacion");
            Map(c => c.ClaveAcceso).Column("clave_acceso");
            Map(c => c.FechaEmision).Column("fecha_emision");
            Map(c => c.TotalSinImpuesto).Column("total_sin_impuesto");
            Map(c => c.TotalDescuento).Column("total_descuento");
            Map(c => c.Propina).Column("propina");
            Map(c => c.TotalFactura).Column("total_factura");
            Map(c => c.Moneda).Column("moneda");
            Map(c => c.EstadoProceso).Column("estado_proceso");
            Map(c => c.CodigoError).Column("cod_error");
            Map(c => c.MensajeError).Column("msm_error");
            References(c => c.IdEmpresa).Class<Empresa>().Column("id_empresa").Not.LazyLoad();
            References(c => c.IdCodfigoDocumento).Class<CodigoDocumento>().Column("id_codigo_documento").Not.LazyLoad();
            References(c => c.IdNotaPedido).Class<NotaPedido>().Column("id_nota_pedido").Not.LazyLoad();
            References(c => c.IdFormaPago).Class<FormaPago>().Column("id_forma_pago").Not.LazyLoad();
            HasMany<FacturaImpuesto>(c => c.FacturaImpuestoList).KeyColumn("id_impuesto").Inverse().Not.LazyLoad();
            // References(c => c.IdFacturaImpuesto).Class<FacturaImpuesto>().Column("id_impuesto").Not.LazyLoad();
            References(c => c.IdUsuarioPerfil).Class<UsuarioPerfil>().Column("id_usuario_perfil").Not.LazyLoad();

        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion_Entidades;
using FluentNHibernate.Mapping;
namespace Facturacion_AccesoDatos.mapping
{
    public class CodigoDocumentoMap : ClassMap<CodigoDocumento>
    {
        public CodigoDocumentoMap()
        {
            Schema("public");
            Table("codigo_documento");
            
            Id(c => c.IdCodigoDocumento).Column("id_codigo_documento");
            Map(c => c.Codigo).Column("codigo");
            Map(c => c.Documento).Column("documento");
            HasMany<Factura>(c => c.FacturaList).KeyColumn("id_factura").Inverse().Not.LazyLoad();
        }
    }
}

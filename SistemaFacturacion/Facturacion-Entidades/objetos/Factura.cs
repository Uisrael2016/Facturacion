using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Factura
    {
        public virtual int IdFactura { get; set; }

        public virtual int Secuencial { get; set; }

        public virtual string Autorizacion { get; set; }

        public virtual string ClaveAcceso { get; set; }
       
        public virtual DateTime FechaEmision { get; set; }

        public virtual double TotalSinImpuesto { get; set; }

        public virtual double TotalDescuento { get; set; }
        public virtual double Propina { get; set; }
        public virtual double TotalFactura { get; set; }

        public virtual string Moneda { get; set; }

        public virtual char EstadoProceso { get; set; }

        public virtual  char CodigoError { get; set; }

        public virtual string MensajeError { get; set; }
        
        public virtual Empresa IdEmpresa { get; set; }

        public virtual CodigoDocumento IdCodfigoDocumento { get; set; }
        public virtual NotaPedido IdNotaPedido { get; set; }

        public virtual FormaPago IdFormaPago { get; set; }

        public virtual Ambiente IdAmbiente { get; set; }

        public virtual FacturaImpuesto IdFacturaImpuesto { get; set; }

        public virtual UsuarioPerfil IdUsuarioPerfil { get; set; }

    }
}

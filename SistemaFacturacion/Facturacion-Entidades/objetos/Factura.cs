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

        public virtual string  CodigoFactura { get; set; }

        public virtual string Autorizacion { get; set; }
        
        public virtual DateTime  FechaFactura { get; set; }

        public virtual double TotalFactura { get; set; }

        public virtual double Saldo { get; set; }

        public virtual char Estado { get; set; }

        public virtual Usuario IdUsuario { get; set; }

        public virtual FormaPago IdFormaPago { get; set; }

    }
}

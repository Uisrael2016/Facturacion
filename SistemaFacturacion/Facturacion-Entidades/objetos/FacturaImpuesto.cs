using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
   public  class FacturaImpuesto
    {
        public virtual int IdImpuesto { get; set; }
        public virtual double BaseImponible { get; set; }//sin impuestos
        public virtual double Valor { get; set; }// valor del iva

        public virtual Tarifa IdTarifa { get; set; }

        public virtual IList<Factura> FacturaList { get; set; }
        public FacturaImpuesto()
        {
            FacturaList = new List<Factura>();
        }
    }
}

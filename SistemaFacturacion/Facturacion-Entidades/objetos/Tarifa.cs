using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Tarifa
    {
        public virtual int IdTarifa { get; set; }
        public virtual double ValTarifa { get; set; }
           
        public virtual char Estado { get; set; }

        public virtual IList<FacturaImpuesto> FacturaImpuestoList { get; set; }

        public Tarifa()
        {
            FacturaImpuestoList = new List<FacturaImpuesto>();
        }
    }
}

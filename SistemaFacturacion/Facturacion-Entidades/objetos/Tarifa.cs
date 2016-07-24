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

        public virtual IList<Impuesto> ImpuestoList { get; set; }

        public Tarifa()
        {
            ImpuestoList = new List<Impuesto>();
        }
    }
}

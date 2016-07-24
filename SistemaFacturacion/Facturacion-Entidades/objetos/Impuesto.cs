using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Impuesto
    {

        public virtual int IdImpuesto { get; set; }
        public virtual double BaseImponible { get; set; }//sin impuestos
        public virtual double Valor { get; set; }// valor del iva

        public virtual string Codigo { get; set; }

        public virtual string CodigoPorcentaje { get; set; }
        public virtual Tarifa IdTarifa { get; set; }

        public virtual Cabecera IdCabecera { get; set; }
    }
}

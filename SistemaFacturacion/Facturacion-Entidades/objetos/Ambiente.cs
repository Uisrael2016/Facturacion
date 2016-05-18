using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Ambiente
    {
        public virtual int IdAmbiente { get; set; }
        public virtual char Codigo { get; set; }
        public virtual string Descripcion { get; set; }

        public virtual char Estado { get; set; }

        public virtual IList<Factura> FacturaList { get; set; }
        public Ambiente()
        {
            FacturaList = new List<Factura>();
        }
    }
}

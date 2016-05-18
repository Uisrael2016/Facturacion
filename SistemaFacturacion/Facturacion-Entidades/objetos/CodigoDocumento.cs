using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class CodigoDocumento
    {
        public virtual int IdCodigoDocumento { get; set; }
        public virtual string Codigo { get; set; }

        public virtual string Documento { get; set; }

        public virtual IList<Factura> FacturaList { get; set; }

        public CodigoDocumento()
        {
            FacturaList = new List<Factura>();
        }
    }
}

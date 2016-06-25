using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class FormaPago
    {
        public virtual int IdFormaPago { get; set; }

        public virtual string Descripcion { get; set; }

        public virtual IList<Factura>FacturaList { get; set; }

        public FormaPago()
        {
            FacturaList = new List<Factura>();
        }
    }

}

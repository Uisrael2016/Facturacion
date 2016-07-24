using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Detalle
    {
        public virtual int IdDetalle { get; set; }

        public virtual int Cantidad { get; set; }

        public virtual double PrecioTotal { get; set; }

        public virtual Cabecera IdCabecera { get; set; }

        public virtual Producto IdProducto { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Proforma
    {
        public virtual int IdProforma { get; set; }

        public virtual int Cantidad { get; set; }

        public virtual double Precio { get; set; }

        public virtual DateTime FechaIngreso { get; set; }

        public virtual Producto IdProducto { get; set; }

        public virtual Usuario IdUsuario { get; set; }

        

    }
}

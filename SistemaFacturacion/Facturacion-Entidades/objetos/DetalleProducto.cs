using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
   public class DetalleProducto
    {
        public virtual int IdDetalleProducto { get; set; }

        public virtual string DescDetalle { get; set; }

        public virtual double Cantidad { get; set; }

        public virtual string Color { get; set; }

        public virtual Material IdMaterial { get; set; }

        public virtual Producto IdProducto { get; set; }

    }
}

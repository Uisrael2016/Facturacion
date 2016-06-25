using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
   public class NotaPedido
    {
        public virtual int IdNotaPedido { get; set; }

        public virtual string CodigoPedido { get; set; }

        public virtual int Cantidad { get; set; }

        public virtual double PrecioUnitario { get; set; }

        public virtual DateTime FechaIngreso { get; set; }

        public virtual char  Estado { get; set; }

        public virtual string Descripcion { get; set; }

        public virtual double Descuento { get; set; }

        public virtual double TotalSinImpuesto { get; set; }
        
        public virtual Producto IdProducto { get; set; }

        public virtual Usuario IdUsuario { get; set; }

        public virtual IList<Factura> FacturaList { get; set; }

        public NotaPedido()
        {
            FacturaList = new List<Factura>();
        }

    }
}

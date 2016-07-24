using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Producto
    {
        public virtual int IdProducto { get; set; }

        public virtual string DescProducto { get; set; }

        public virtual char Tipo { get; set; }

        public virtual string Imagen { get; set; }

        public virtual double Precio { get; set; }

        public virtual double Descuento { get; set; }
        public virtual  IList<DetalleProducto> DetalleProductoList { get; set; }

        public virtual IList<Detalle>DetalleList { get; set; }

        public Producto()
        {
            DetalleList = new List<Detalle>();
            DetalleProductoList = new List<DetalleProducto>();
           
        }

    }
}

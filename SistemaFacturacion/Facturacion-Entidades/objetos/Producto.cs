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

        public virtual DetalleProducto IdDetalleProducto { get; set; }

        public virtual IList<Proforma>ProformaList { get; set; }


        public Producto()
        {
            ProformaList = new List<Proforma>();
           
        }

    }
}

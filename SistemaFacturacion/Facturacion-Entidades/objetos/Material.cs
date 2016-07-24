using Facturacion_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Material
    {
        public virtual int IdMaterial { get; set; }

        public virtual string Descripcion { get; set; }


        public virtual double Stock { get; set; }

        public virtual TipoMaterial IdTipoMaterial { get; set; }

        public virtual Proveedor IdProveedor { get; set; }

        public virtual IList<DetalleProducto> DetalleProductoList { get; set; }

        public virtual IList<Ingreso>IngresoList { get; set; }

        public virtual IList<Salida> SalidaList { get; set; }


        public Material()
        {
            DetalleProductoList = new List<DetalleProducto>();
            IngresoList = new List<Ingreso>();
            SalidaList = new List<Salida>();
        }
    }
}

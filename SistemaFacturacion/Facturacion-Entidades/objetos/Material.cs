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

        public virtual DateTime FechaIngreso { get; set; }

        public virtual DateTime FechaEgreso { get; set; }

        public virtual TipoMaterial IdTipoMaterial { get; set; }

        public virtual Proveedor IdProveedor { get; set; }

        public virtual IList<DetalleProducto> DetalleProductoList { get; set; }

        public Material()
        {
            DetalleProductoList = new List<DetalleProducto>();
        }
    }
}

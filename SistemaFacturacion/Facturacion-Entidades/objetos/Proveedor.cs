using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Proveedor
    {
        public virtual int IdProveedor { get; set; }

        public virtual string Documento { get; set; }

        public virtual string RazonSocial { get; set; }

        public virtual string RepresentanteLegal { get; set; }

        public virtual string Telefono { get; set; }

        public virtual string Email { get; set; }

        public virtual string Direccion { get; set; }

        public virtual char Estado { get; set; }

        public virtual DateTime FechaIngreso { get; set; }

        public virtual DateTime FechaEgreso { get; set; }

        public virtual int UsuarioIngresa { get; set; }

        public virtual int UsuarioEgresa { get; set; }

        public virtual IList<Material> MateriaList { get; set; }

        public virtual TipoDocumento IdTipoDocumento { get; set; }
        public Proveedor()
        {
            MateriaList = new List<Material>();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }else
            {
                Proveedor p = (Proveedor)obj;
                return (IdProveedor == p.IdProveedor);
            }
        }
        public override int GetHashCode()
        {
            return IdProveedor;
        }
    }
}

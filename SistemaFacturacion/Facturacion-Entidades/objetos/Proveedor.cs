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

        public virtual string Nombres { get; set; }

        public virtual string Apellidos { get; set; }
        public virtual string Email { get; set; }

        public virtual char Estado { get; set; }

        public virtual DateTime FechaIngreso { get; set; }

        public virtual DateTime FechaEgreso { get; set; }

        public virtual int UsuarioIngresa { get; set; }

        public virtual int UsuarioEgresa { get; set; }

        public virtual IList<Material> MateriaList { get; set; }

        public Proveedor()
        {
            MateriaList = new List<Material>();
        }
    }
}

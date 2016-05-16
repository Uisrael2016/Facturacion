using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class TipoMaterial
    {
        public virtual int IdTipoMaterial { get; set; }
        public virtual string Tipo { get; set; }
        public virtual IList<Material>MaterialList { get; set; }

        public TipoMaterial()
        {
            MaterialList = new List<Material>();
        }
    }
}

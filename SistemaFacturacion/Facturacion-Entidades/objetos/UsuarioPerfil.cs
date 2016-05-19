using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class UsuarioPerfil
    {
        public virtual int IdUsuarioPerfil { get; set; }

        public virtual Perfil IdPerfil { get; set; }

        public virtual Usuario IdUsuario { get; set; }

        public virtual PuntoEmision IdPuntoEmision { get; set; }

        public virtual IList<Factura> FacturaList { get; set; }
        public UsuarioPerfil ()
        {
            FacturaList = new List<Factura>();
        }
    }
}

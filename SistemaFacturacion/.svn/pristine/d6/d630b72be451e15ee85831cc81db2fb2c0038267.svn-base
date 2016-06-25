    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class PuntoEmision
    {
        public virtual int IdPuntoEmision { get; set; }

        public virtual string Codigo { get; set; }

        public virtual char Estado { get; set; }

        public virtual Establecimiento  IdEstablecimiento { get; set; }

        public virtual IList<UsuarioPerfil> UsuarioPerfilList { get; set; }
        
        public PuntoEmision()
        {
            UsuarioPerfilList = new List<UsuarioPerfil>();
        }
    }
}

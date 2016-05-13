using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class TipoDocumento
    {
        public TipoDocumento() { }
        public virtual int IdTipoDocumento { get; set; }

        public virtual string  Documento { get; set; }

        public virtual List<Usuario> UsuarioList { get; set; }

        public virtual List<Cliente> ClienteList { get; set; }
    }
}

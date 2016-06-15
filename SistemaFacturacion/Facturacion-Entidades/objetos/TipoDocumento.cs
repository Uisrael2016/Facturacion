using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class TipoDocumento
    {
        
        public virtual int IdTipoDocumento { get; set; }

        public virtual string  Documento { get; set; }

        public virtual IList<Usuario> UsuarioList { get; set; }
        public virtual IList<Cliente> CLienteList { get; set; }

        public virtual IList<Proveedor>ProveedorList { get; set; }
        public TipoDocumento() {
            UsuarioList = new List<Usuario>();
            CLienteList = new List<Cliente>();
            ProveedorList = new List<Proveedor>();
        }
    }
}

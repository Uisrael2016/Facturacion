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

        public virtual string Documento { get; set; }

        public virtual string Codigo { get; set; }
             
        public virtual IList<Usuario> UsuarioList { get; set; }
        public virtual IList<Cliente> CLienteList { get; set; }

        public virtual IList<Proveedor> ProveedorList { get; set; }
        public TipoDocumento()
        {
            UsuarioList = new List<Usuario>();
            CLienteList = new List<Cliente>();
            ProveedorList = new List<Proveedor>();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                TipoDocumento a = (TipoDocumento)obj;
                return (IdTipoDocumento == a.IdTipoDocumento);
            }


        }
        public override int GetHashCode()
        {
            return IdTipoDocumento;
        }
        public override string ToString()
        {
            return this.Documento;
        }

    }

}

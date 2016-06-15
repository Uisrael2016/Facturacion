using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Perfil
    {
        public virtual int IdPerfil { get; set; }

        public virtual string Descripcion { get; set; }

        public virtual string Codigo { get; set; }

        public virtual char Estado { get; set; }

        public virtual IList<UsuarioPerfil> UsuarioPerfilList { get; set; }

        public Perfil()
        {
            UsuarioPerfilList = new List<UsuarioPerfil>();
        }
    }
}

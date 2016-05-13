using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Usuario
    {
        public virtual int idUsuario { get; set; }

        public virtual int idTipoDocumento { get; set; }
        public virtual string documento { get; set; }
        public virtual string nombre { get; set; }

        public virtual string mail { get; set; }

        public virtual bool cambiarClave { get; set; }

        public virtual DateTime  fechaRegistro { get; set; }

        public virtual string  usuarioCreacion { get; set; }

        public virtual string user { get; set; }
        public virtual string clave { get; set; }
        public virtual char estado { get; set; }
        public virtual string telefono { get; set; }
            
    }
}


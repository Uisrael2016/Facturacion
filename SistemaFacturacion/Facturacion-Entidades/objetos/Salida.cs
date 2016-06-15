using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Salida
    {
        public virtual int IdSalida { get; set; }

        public virtual double CantidadEgreso { get; set; }

        public virtual DateTime FechaEgreso { get; set; }

        public virtual int UsuarioEgreso { get; set; }

        public virtual Material IdMaterial { get; set; }
    }
}

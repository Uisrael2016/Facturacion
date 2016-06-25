using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Establecimiento
    {
        public virtual int IdEstablecimiento { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Direccion { get; set; }
        public virtual string Estado { get; set; }

        public virtual IList<PuntoEmision> PuntoEmisionList { get; set; }

        public Establecimiento()
        {
            PuntoEmisionList = new List<PuntoEmision>();
        }

    }
}

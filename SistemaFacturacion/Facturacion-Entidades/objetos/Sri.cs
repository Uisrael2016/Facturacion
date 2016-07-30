using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Sri
    {
        public virtual int IdSri { get; set; }

        public virtual string Autorizacion { get; set; }

        public virtual string ClaveAcceso { get; set; }

        public virtual string Estado { get; set; }
        //public virtual DateTime FechaAutorizacion { get}
        public virtual string CodigoError { get; set; }

        public virtual string MensajeError { get; set; }

        public virtual DateTime FechaAutorizacion{get;set;}

        public virtual Cabecera IdCabecera { get; set; }

    }
}

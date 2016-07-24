using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Sri
    {
        public virtual int IdAutorizacion { get; set; }

        public virtual string Autorizacion { get; set; }

        public virtual string ClaveAcceso { get; set; }

        public virtual char Estado { get; set; }

        public virtual char CodigoError { get; set; }

        public virtual string MensajeError { get; set; }

        public virtual DateTime FechaAutorizacion{get;set;}

        public virtual Cabecera IdCabecera { get; set; }

    }
}

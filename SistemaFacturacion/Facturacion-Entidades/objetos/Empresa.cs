using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Empresa
    {
        public virtual int IdEmpresa { get; set; }

        public virtual string Ruc { get; set; }

        public virtual string RazonSocial { get; set; }

        public virtual string DirecMatriz { get; set; }

        public virtual string PathLogo { get; set; }
        public virtual char Estado { get; set; }

        public virtual bool Contabilidad { get; set;}
        public virtual Ambiente IdAmbiente { get; set; }
        public virtual IList<Cabecera> CabeceraList { get; set; }
        public Empresa()
        {
            CabeceraList = new List<Cabecera>();
        }
    }
}

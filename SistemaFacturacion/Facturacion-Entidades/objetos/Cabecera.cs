using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Cabecera
    {
        public virtual int IdCabecera { get; set; }
        public virtual int Secuencial { get; set; }

        public virtual DateTime FechaEmision { get; set; }

        public virtual double TotalSinImpuesto { get; set; }

        public virtual double TotalDescuento { get; set; }
        public virtual double Propina { get; set; }
        public virtual double Total { get; set; }

        public virtual string Moneda { get; set; }

        public virtual string Estado { get; set; }
        public virtual Empresa IdEmpresa { get; set; }

        public virtual CodigoDocumento IdCodigoDocumento { get; set; }

        public virtual FormaPago IdFormaPago { get; set; }

        public virtual UsuarioPerfil IdUsuarioPerfil { get; set; }

        public virtual Cliente IdCliente { get; set; }

        public virtual IList<Sri> SriList { get; set; }

        public virtual IList<Impuesto> ImpuestoList { get; set; }

        public virtual IList<Detalle> DetalleList { get; set; }
        public Cabecera()
        {
            SriList = new List<Sri>();
            ImpuestoList = new List<Impuesto>();
            DetalleList = new List<Detalle>();
        }

    }
}

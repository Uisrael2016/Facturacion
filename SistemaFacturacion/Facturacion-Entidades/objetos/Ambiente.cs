using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Ambiente
    {
        public virtual int IdAmbiente { get; set; }
        public virtual char Codigo { get; set; }
        public virtual string Descripcion { get; set; }

        public virtual char Estado { get; set; }

        public virtual IList<Empresa> EmpresaList{ get; set; }
        public Ambiente()
        {
            EmpresaList = new List<Empresa>();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                Ambiente a = (Ambiente)obj;
                return (IdAmbiente == a.IdAmbiente);
            }

            
        }
        public override int GetHashCode()
        {
            return IdAmbiente;
        }
        public override string ToString()
        {
            return Descripcion;
        }

    }

}

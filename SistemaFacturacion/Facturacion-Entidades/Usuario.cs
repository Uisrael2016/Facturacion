using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Usuario
    {

        public virtual int? IdUsuario { get; set; }

        public virtual string Documento { get; set; }

        public virtual string Nombre { set; get; }

        public virtual string Mail { get; set; }

        public virtual bool CambiarClave { get; set; }

        public virtual DateTime FechaIngreso { get; set; }
        
        public virtual int UsuarioIngreso { get; set; }

        public virtual string UserName { get; set; }

        public virtual string Clave { get; set; }

        public virtual char Estado { get; set; }

        public virtual string Telefono { get; set; }

        public virtual IList<UsuarioPerfil> UsuarioPerfilList { get; set; }

        public virtual IList<Factura> FacturaList { get; set; }

        public virtual TipoDocumento IdTipoDucumento { get; set; }

        public virtual IList<Proforma> ProformaList { get; set; }

        public virtual IList<NotaPedido> NotaPedidoList { get; set; }



        public Usuario()
        {
            UsuarioPerfilList = new List<UsuarioPerfil>();
            FacturaList = new List<Factura>();
            ProformaList = new List<Proforma>();
            NotaPedidoList = new List<NotaPedido>();
        }

    }
}


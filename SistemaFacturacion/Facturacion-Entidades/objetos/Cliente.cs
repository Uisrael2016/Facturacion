﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Cliente
    {
        public virtual int IdCliente { get; set; }

        public virtual string DocumentoCliente { get; set; }

        public virtual string Nombres { get; set; }

        public virtual string Apellidos { get; set; }

        public virtual string Correo { get; set; }

        public virtual string Direccion { get; set; }

        public virtual string Telefono { get; set; }

        public virtual DateTime FechaIngreso { get; set; }

        public virtual DateTime FechaEgreso { get; set; }

        public virtual int UsuarioIngreso { get; set; }

        public virtual int UsuarioEgreso { get; set; }

        public virtual TipoDocumento IdTipoDocumento { get; set; }

        public virtual IList<Cabecera> CabeceraList { get; set; }
        
        public Cliente()
        {
            CabeceraList = new List<Cabecera>();
            
        }
        
    }
}

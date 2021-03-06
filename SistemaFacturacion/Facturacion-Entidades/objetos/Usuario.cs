﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Entidades
{
    public class Usuario
    {

        public virtual int IdUsuario { get; set; }

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

        public virtual IList<Cabecera> CabeceraList { get; set; }

        public virtual TipoDocumento IdTipoDocumento { get; set; }


        public Usuario() {
            UsuarioPerfilList = new List<UsuarioPerfil>();
            CabeceraList = new List<Cabecera>();
        }

    }
}


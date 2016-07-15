using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_Entidades;
using Facturacion_AccesoDatos.dao;
using Facturacion_Vista.Utilidades;

namespace Facturacion_Vista.Vistas.Agregar
{
    public partial class FrmUsuarioPerfil : DevComponents.DotNetBar.Office2007Form
    {
        private PuntoEmision _puntoEmision;
        private Perfil _perfil;
        private Usuario _usuario;
        public FrmUsuarioPerfil()
        {
            InitializeComponent();
            _puntoEmision = new PuntoEmision();
            _perfil = new Perfil();
            _usuario = new Usuario();
        }

        private void FrmUsuarioPerfil_Load(object sender, EventArgs e)
        {
            cargar_combo_Perfil();
            cargar_combo_Usuario();
            cargar_combo_puntoEmision();
        }
        private void cargar_combo_puntoEmision()
        {
            PuntoEmisionDAO _puntoEmision = new PuntoEmisionDAO();
            cbPuntoemision.DataSource = _puntoEmision.consultar();
            cbPuntoemision.DisplayMember = "Codigo";
            cbPuntoemision.ValueMember = "IdPuntoEmision";
        }
        private void cargar_combo_Perfil()
        {
            PerfilDao _perfil = new PerfilDao();
            cbPerfil.DataSource = _perfil.consultar();
            cbPerfil.DisplayMember = "Descripcion";
            cbPerfil.ValueMember = "IdPerfil";
        }
        private void cargar_combo_Usuario()
        {
            UsuarioDao _usuario = new UsuarioDao();
            cbPerfil.DataSource = _usuario.consultar();
            cbPerfil.DisplayMember = "Nombre";
            cbPerfil.ValueMember = "idUsuario";
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbTipoPuntoEmision_SelectedIndexChanged(object sender, EventArgs e)
        {
            PuntoEmision puntoEmi = (PuntoEmision)cbPuntoemision.SelectedItem;
            _puntoEmision.IdPuntoEmision = puntoEmi.IdPuntoEmision;
            _puntoEmision.Codigo = puntoEmi.Codigo;
        }

        private void cbTipoPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Perfil perfil = (Perfil)cbPerfil.SelectedItem;
            _perfil.IdPerfil = perfil.IdPerfil;
            _perfil.Descripcion = perfil.Descripcion;
        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)cbUsuario.SelectedItem;
            _usuario.IdUsuario = usuario.IdUsuario;
            _usuario.Nombre = usuario.Nombre;
        }
    }
}

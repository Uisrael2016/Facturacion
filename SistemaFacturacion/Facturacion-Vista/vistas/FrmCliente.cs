﻿using System;
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


namespace Facturacion_Vista.Vistas
{
    public partial class FrmCliente : DevComponents.DotNetBar.Office2007Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        public bool nuevo;

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            TipoDocumentoDao tpdocumento = new TipoDocumentoDao();
            var lista = tpdocumento.consultar();

            cbxTipoDocumento.DataSource = lista;
            //xTipoDocumento.ad
            cbxTipoDocumento.DisplayMember = "Documento";
            cbxTipoDocumento.ValueMember = "IdTipoDocumento";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
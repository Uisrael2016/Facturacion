﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion_Vista.Vistas
{
    public partial class FrmListarDocumentoFact : DevComponents.DotNetBar.Office2007Form
    {
        public FrmListarDocumentoFact()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            FrmTipoDocumentoFact frm = new FrmTipoDocumentoFact();
            frm.ShowDialog();

        }
    }
}
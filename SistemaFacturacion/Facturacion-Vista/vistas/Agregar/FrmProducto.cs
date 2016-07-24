using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_Vista.Utilidades;

namespace Facturacion_Vista.Vistas.Agregar
{
    public partial class FrmProducto : DevComponents.DotNetBar.Office2007Form
    {
        private string pathFile;
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            FrmDetalleProducto frm = new FrmDetalleProducto();
            frm.ShowDialog();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog buscaImagen = new OpenFileDialog();
                buscaImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                buscaImagen.Filter = "Image files (*.jpg, *.jpeg,*.png) | *.jpg; *.jpeg; *.png";
                buscaImagen.FileName = "";
                buscaImagen.Title = "Imagen de Producto";
                if (buscaImagen.ShowDialog(this) == DialogResult.OK)
                {
                    pathFile = buscaImagen.FileName;
                    if (pathFile.Equals("")==false)
                    {
                        pictureProducto.Load(pathFile);

                    }
                    

                }

            }
            catch (Exception ex)
            {
                Mensaje.mensajeError("Error", "No se pudo cargar" + ex.ToString());
            }



        }

    }
}

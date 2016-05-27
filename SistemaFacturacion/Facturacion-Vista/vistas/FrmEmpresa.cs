using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_Vista.Utilidades;
using Facturacion_AccesoDatos.dao;
using Facturacion_Entidades;
namespace Facturacion_Vista.Vistas
{
    public partial class FrmEmpresa : DevComponents.DotNetBar.Office2007RibbonForm
    {
        string pathFile;
        private Acciones accion;
        private char estado;
        EmpresaDao empresaDao;
        Empresa empresaSeleccionada;
        int idEmpresa = 0;
        public FrmEmpresa(Acciones valor)
        {
            InitializeComponent();
            this.accion = valor;
            if (valor == Acciones.update)
            {
                estdoLbl.Visible = true;
                radioH.Visible = true;
                radioD.Visible = true;
                empresaDao = new EmpresaDao();
                empresaSeleccionada = empresaDao.buscaEmpresa();
                if (empresaSeleccionada.Estado == 'A')
                {
                    radioH.Select();
                }
                else
                {
                    radioD.Select();
                }
                idEmpresa = empresaSeleccionada.IdEmpresa;
                textRuc.Text = empresaSeleccionada.Ruc;
                textRazonSocial.Text = empresaSeleccionada.RazonSocial;
                textDirecMatriz.Text = empresaSeleccionada.DirecMatriz;
                pathLbl.Text = empresaSeleccionada.PathLogo;
            }else
            {
                empresaSeleccionada = new Empresa();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (accion == Acciones.insert)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                dialog.Filter = "Image files (*.jpg, *.jpeg,*.png) | *.jpg; *.jpeg; *.png";

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    pathFile = dialog.FileName;
                    pathLbl.Text = pathFile;
                }

            }
        }

        private void radioH_CheckedChanged(object sender, EventArgs e)
        {
            estado = 'A';
        }

        private void radioD_CheckedChanged(object sender, EventArgs e)
        {
            estado = 'D';
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (var groupBox in this.Controls.OfType<GroupBox>())
            {
                foreach (var textbox in groupBox.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex))
                {
                    if (textbox.Text == "")
                    {
                        errorProvider1.SetError(textbox, "El campo con error es obligatorio");
                        return;
                    }

                }
            }
            if (pathLbl.Text == "")
            {
                errorProvider1.SetError(pathLbl, "Debe seleccionar un logo");
                return;
            }
            empresaDao = new EmpresaDao();
            try
            {
                empresaSeleccionada.Ruc = textRuc.Text.ToUpper();
                empresaSeleccionada.RazonSocial = textRazonSocial.Text.ToUpper();
                empresaSeleccionada.DirecMatriz = textDirecMatriz.Text.ToUpper();
                empresaSeleccionada.PathLogo = pathLbl.Text;
                if (accion == Acciones.insert)
                {
                    empresaSeleccionada.Estado = 'A';
                    empresaDao.insertar(empresaSeleccionada);
                    Utilidades.Mensaje.mensajeInformacion("Informacion", "Informacion ingresada exitosamente");
                    this.Hide();
                    Login log = new Login();
                    log.Show();
                }
                else
                {
                    empresaSeleccionada.IdEmpresa = idEmpresa;
                    empresaSeleccionada.Estado = estado;
                    empresaDao.modificar(empresaSeleccionada);
                    Utilidades.Mensaje.mensajeInformacion("Informacion", "Informacion actualizada exitosamene");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                if (accion == Acciones.insert)
                    Mensaje.mensajeError("Error", "Error al registrar al usuario" + ex.Message);
                else
                    Mensaje.mensajeError("Error", "Error al acrtualizar al usuario" + ex.Message);
            }

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class  FrmEmpresa : DevComponents.DotNetBar.Office2007RibbonForm
    {
        string pathFile;
        private Acciones accion;
        private char estado;
        EmpresaDao empresaDao;
        Empresa empresaSeleccionada;
        int idEmpresa = 0;
        private Ambiente _ambiente;
        private bool contabilidad;
        public FrmEmpresa(Acciones valor)
        {
            InitializeComponent();
            this.accion = valor;
            _ambiente = new Ambiente();
            cargaCombo();
            if (valor == Acciones.update)
            {

                checkEstado.Visible = true;
                empresaDao = new EmpresaDao();
                empresaSeleccionada = empresaDao.buscaEmpresa();
                    if (empresaSeleccionada.Estado == 'A')
                    {
                        checkEstado.Checked = true;
                    }
                    else
                    {
                        checkEstado.Checked = false;
                    }
                    idEmpresa = empresaSeleccionada.IdEmpresa;
                    textRuc.Text = empresaSeleccionada.Ruc;
                    textRazonSocial.Text = empresaSeleccionada.RazonSocial;
                    textDirecMatriz.Text = empresaSeleccionada.DirecMatriz;
                    textPath.Text = empresaSeleccionada.PathLogo;
                    checkContabilidad.Checked = empresaSeleccionada.Contabilidad;
                    comboAmbiente.SelectedItem = empresaSeleccionada.IdAmbiente;
                
                
            }else
            {
                empresaSeleccionada = new Empresa();
            }
        }

        private void cargaCombo()
        {
            AmbienteDao dao = new AmbienteDao();
            comboAmbiente.DataSource = dao.listaAmbiente();
            comboAmbiente.DisplayMember = "Descripcion";
            comboAmbiente.ValueMember = "IdAmbiente";
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
                    textPath.Text = pathFile;
                }

            }
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (var groupBox in this.Controls.OfType<DevComponents.DotNetBar.Controls.GroupPanel>())
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
            if (textPath.Text == "")
            {
                errorProvider1.SetError(textPath, "Debe seleccionar un logo");
                return;
            }
            empresaDao = new EmpresaDao();
            try
            {
                
                empresaSeleccionada.Ruc = textRuc.Text.ToUpper();
                empresaSeleccionada.RazonSocial = textRazonSocial.Text.ToUpper();
                empresaSeleccionada.DirecMatriz = textDirecMatriz.Text.ToUpper();
                empresaSeleccionada.PathLogo = textPath.Text;
                empresaSeleccionada.IdAmbiente = _ambiente;
                if (checkContabilidad.Checked == true)
                    contabilidad = true;
                else
                    contabilidad = false;
                empresaSeleccionada.Contabilidad = contabilidad;
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
                    if (checkEstado.Checked==true)
                    
                        estado = 'A';
                    else
                        estado = 'I';

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

        private void comboAmbiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ambiente ambt = (Ambiente)comboAmbiente.SelectedItem;
            _ambiente.IdAmbiente = ambt.IdAmbiente;
            _ambiente.Codigo = ambt.Codigo;
            _ambiente.Descripcion = ambt.Descripcion;
            _ambiente.Estado = ambt.Estado;

        }

        private void textRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.General.validaNumero(e, textRuc);
            Utilidades.General.lengthNumber(e, textRuc, 13);
        }
    }
}

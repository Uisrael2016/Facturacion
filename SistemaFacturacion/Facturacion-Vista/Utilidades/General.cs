using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion_Vista.Utilidades;
namespace Facturacion_Vista.Utilidades
{
    public class General
    {

        public static void validaDecimal(KeyPressEventArgs e, TextBox texto)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;
            for (int i = 0; i < texto.Text.Length; i++)
            {
                if (texto.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }

            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }

        public static void lengthCedula(KeyPressEventArgs e, TextBox texto)
        {
            bool IsDec = false;
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

            if (texto.Text.Length >= 10)
                e.Handled = true;

        }
        public static void lengthRuc(KeyPressEventArgs e, TextBox texto)
        {
            bool IsDec = false;
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

            if (texto.Text.Length >= 13)
                e.Handled = true;

        }
        public static void validaNumero(KeyPressEventArgs e, TextBox texto)
        {
            bool IsDec = false;
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }
        public static bool validaForm(Control.ControlCollection control, ErrorProvider error)
        {
            bool flag = false;
            foreach (var textBox in control.OfType<DevComponents.DotNetBar.Controls.TextBoxX>().OrderBy(t => t.TabIndex))
            {
                if (textBox.Text.Trim() == "")
                {
                    error.SetError(textBox, "El campo es requerido");
                    flag = false;
                }
                else
                {
                    error.Clear();
                    flag = true;

                }

            }
            return flag;

        }

        public static bool validaFormGroup(Control.ControlCollection control, ErrorProvider error)
        {
            bool flag = false;
            foreach (var groupBox in control.OfType<DevComponents.DotNetBar.Controls.GroupPanel>())
            {
                if (groupBox.Name == "group")
                {
                    foreach (var textBox in groupBox.Controls.OfType<DevComponents.DotNetBar.Controls.TextBoxX>().OrderBy(t => t.TabIndex))
                    {
                        if (textBox.Text.Trim() == "")
                        {
                            error.SetError(textBox, "El campo es requerido");
                            flag = false;
                        }
                        else
                        {
                            error.Clear();
                            flag = true;
                        }

                    }

                }

            }

            return flag;

        }

        public static void limpiaTexto(Control.ControlCollection control)
        {
            foreach (var groupBox in control.OfType<DevComponents.DotNetBar.Controls.GroupPanel>())
            {
                if (groupBox.Name == "group")
                {
                    foreach (var textBox in groupBox.Controls.OfType<DevComponents.DotNetBar.Controls.TextBoxX>().OrderBy(t => t.TabIndex))
                    {
                        textBox.Text = string.Empty;
                    }
                }

            }

        }

        public static bool validaCedula(string ced)
        {
            bool flag = false;
            int isNumeric;
            var total = 0;
            const int longitudCedula = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int num_provincias = 24;
            const int tercerDigito = 6;
            if (int.TryParse(ced, out isNumeric) && ced.Length == longitudCedula)
            {
                var provincia = Convert.ToInt32(string.Concat(ced[0], ced[1], string.Empty));
                var digitoTres = Convert.ToInt32(ced[2] + string.Empty);
                if ((provincia > 0 && provincia <= num_provincias) && digitoTres < tercerDigito)
                {
                    var digitoVerificadoRecibido = Convert.ToInt32(ced[9] + string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty) *
                            Convert.ToInt32(ced[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;
                    }
                    var digitoVerificadoObtenido = total >= 10 ? (total % 10) !=0 ?
                        10 - (total % 10) : (total % 10) : total;

                    if (digitoVerificadoObtenido == digitoVerificadoRecibido)
                        flag = true;
                    else
                        flag = false;
                    
                }
            }

            return flag;
        }

    }
}

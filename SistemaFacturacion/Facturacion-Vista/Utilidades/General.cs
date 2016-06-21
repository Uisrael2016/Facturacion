using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public static bool validaForm(Control.ControlCollection control, ErrorProvider error)
        {
            bool flag = false;
            foreach (var textBox in control.OfType<TextBox>().OrderBy(t => t.TabIndex))
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
                    foreach (var textBox in groupBox.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex))
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
            foreach (var groupBox in control.OfType<GroupBox>())
            {
                if (groupBox.Name == "groupMantenimiento")
                {
                    foreach (var textBox in groupBox.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex))
                    {
                        textBox.Text = string.Empty;
                    }
                }

            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Facturacion_Vista.Utilidades
{
    public class Mensaje
    {
        public static void mensajeError(string cabecera, string detalle)
        {
            MessageBox.Show(detalle, cabecera, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void mensajeInformacion(string cabecera, string detalle)
        {
            MessageBox.Show(detalle, cabecera, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void mensajeAlerta(string cabecera, string detalle)
        {
            MessageBox.Show( detalle, cabecera, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        public static DialogResult mensajeConfirm(string cabecera, string detalle)
        {

            return MessageBox.Show( detalle, cabecera, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

    }
}

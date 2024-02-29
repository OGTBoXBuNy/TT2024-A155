using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT2024_A155
{
    internal class Validaciones
    {

        public bool soloNumerosDecimales(object sender, KeyPressEventArgs e)
        {
            bool respuesta = false;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                return true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                return true;
            }

            return respuesta;
        }


        public bool soloLetras(object sender, KeyPressEventArgs e)
        {
            bool respuesta = false;

            if (!(char.IsLetter(e.KeyChar))  && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                respuesta = true;
                return respuesta;
            }

            return respuesta;
        }

    }
}

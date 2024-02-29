using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public bool validarCorreo(string email)
        {
            if (email == null)
            {
                return false;
            }
            if (new EmailAddressAttribute().IsValid(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean contrasenaSegura(String contraseñaSinVerificar)
        {
            //letras de la A a la Z, mayusculas y minusculas
            Regex letras = new Regex(@"[a-zA-z]");
            //digitos del 0 al 9
            Regex numeros = new Regex(@"[0-9]");
            //cualquier caracter del conjunto
            Regex caracEsp = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]");

            Boolean cumpleCriterios = false;

            //si no contiene las letras, regresa false
            if (!letras.IsMatch(contraseñaSinVerificar))
            {
                return false;
            }
            //si no contiene los numeros, regresa false
            if (!numeros.IsMatch(contraseñaSinVerificar))
            {
                return false;
            }

            //si no contiene los caracteres especiales, regresa false
            if (!caracEsp.IsMatch(contraseñaSinVerificar))
            {
                return false;
            }

            //Si no es de longitud minima de 8
            if(contraseñaSinVerificar.Length < 8) 
            {
                return false;
            }

            //si cumple con todo, regresa true
            return true;
}


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT2024_A155
{
    public partial class registrarCliente : Form
    {
        public registrarCliente()
        {
            InitializeComponent();
        }
        BD Consulta = new BD();
        Validaciones Validaciones = new();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string rol = "Cliente";
            string usuario = txtUsuario.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string contra = txtContrasenia.Text.Trim();
            string calle = txtCalle.Text.Trim();
            string colonia = txtCol.Text.Trim();
            string noExt = txtNoExt.Text.Trim();
            string noInt = txtNoInt.Text.Trim();
            string cp = txtCP.Text.Trim();
            string ciudad = txtCiudad.Text.Trim();
            string telefono = txtTel.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            Consulta.registroUsuario(rol, usuario, nombre, contra, calle, colonia, noExt, noInt, cp, ciudad, telefono, correo);

            string descripcionLog = "Se registró un nuevo cliente con nombre de usuario:  " + usuario + " el día: " + DateTime.Now.ToString();
            Consulta.Log(usuario, "", descripcionLog, "4");
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.soloLetras(sender, e);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.soloNumerosDecimales(sender, e);
        }

        private void txtNoExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.soloNumerosDecimales(sender, e);
        }

        private void txtNoInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.soloNumerosDecimales(sender, e);
        }
    }
}

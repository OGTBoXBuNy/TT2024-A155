using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Diseño
using MaterialSkin.Controls;

namespace TT2024_A155
{
    public partial class restablecerContraseña : MaterialForm
    {
        BD Consulta = new BD();
        public restablecerContraseña()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void lblCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrarCliente registrarCliente = new registrarCliente();
            registrarCliente.Show();

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Consulta.recuperarContra(txtRecuperacion.Text.Trim());
            string descripcionLog = "Se solicitó restablecer la contraseña del usuario/correo:  " + txtRecuperacion.Text.Trim() + " el día: " + DateTime.Now.ToString();
            Consulta.Log(txtRecuperacion.Text.Trim(), "", descripcionLog, "3");
        }
    }
}

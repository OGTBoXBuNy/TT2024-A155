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
    public partial class restablecerContraseña : Form
    {
        BD Consulta = new BD();
        public restablecerContraseña()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Consulta.recuperarContra(txtRecuperacion.Text.Trim());
            string descripcionLog = "Se solicitó restablecer la contraseña del usuario/correo:  " + txtRecuperacion.Text.Trim() + " el día: " + DateTime.Now.ToString();
            Consulta.Log(txtRecuperacion.Text.Trim(), "", descripcionLog, "3");
        }

        private void lblCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrarCliente registrarCliente = new registrarCliente();
            registrarCliente.Show();

        }
    }
}

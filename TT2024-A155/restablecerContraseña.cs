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
        BD consulta = new BD();
        public restablecerContraseña()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            consulta.recuperarContra(txtRecuperacion.Text.Trim());
        }

        private void lblCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrarCliente registrarCliente = new registrarCliente();
            registrarCliente.Show();

        }
    }
}

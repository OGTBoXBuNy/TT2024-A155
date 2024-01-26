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
    public partial class cambioContraseña : Form
    {
        BD Consulta = new BD();
        public cambioContraseña()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtContra.Text.Trim() == txtContraRep.Text.Trim() && txtContra.Text.Length >= 8)
            {
                Inicio inicio = new Inicio();
                Consulta.actualizarUsuario(lblUsuario.Text, txtContra.Text.Trim());
                AddOwnedForm(inicio);
                inicio.lblUsuario.Text = lblUsuario.Text;
                inicio.lblRol.Text = lblRol.Text;
                this.Hide();
                inicio.Show();

            }
        }
    }
}

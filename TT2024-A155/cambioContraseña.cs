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
using TT2024_A155.Properties;

namespace TT2024_A155
{
    public partial class cambioContraseña : MaterialForm
    {
        BD Consulta = new BD();
        Validaciones Validaciones = new();
        public cambioContraseña()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //-----------VALIDACION-----------------//
            bool validacion = true;
            errorContrasenia.Clear();
            errorContraseniaRepe.Clear();

            if (!Validaciones.contrasenaSegura(txtContraRep.Text.Trim())) { errorContrasenia.SetError(txtContra, "Campo obligatorio y cumplir con: Números, Letras, Carácter especial y longitud mayor o igual a 8"); validacion = false; }
            if (!Validaciones.contrasenaSegura(txtContraRep.Text.Trim())) { errorContraseniaRepe.SetError(txtContraRep, "Campo obligatorio y cumplir con: Números, Letras, Carácter especial y longitud mayor o igual a 8"); validacion = false; }

            //-----------------------------


            if (validacion && txtContra.Text.Trim() == txtContraRep.Text.Trim())
            {
                Inicio inicio = new Inicio();
                Consulta.actualizarUsuario(lblUsuario.Text, txtContra.Text.Trim());
                //AddOwnedForm(inicio);
                inicio.lblUsuario.Text = lblUsuario.Text;
                inicio.lblRol.Text = lblRol.Text;
                inicio.Show();
                this.Close();
            }
        }

        private void PicOJO_MouseClick(object sender, MouseEventArgs e)
        {
            if (PicOJO.Image.Height.ToString() == "128")
            {
                txtContra.UseSystemPasswordChar = false;
                PicOJO.Image = Resources.OjoCerrado;
            }
            else
            {
                txtContra.UseSystemPasswordChar = true;
                PicOJO.Image = Resources.ojo;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            PicOJO.Visible = false;
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            PicOJO.Visible = true;
        }

        private void txtContraRep_Leave(object sender, EventArgs e)
        {
            PicOjoRes.Visible = false;
        }

        private void txtContraRep_Enter(object sender, EventArgs e)
        {
            PicOjoRes.Visible = true;
        }

        private void PicOjoRes_MouseClick(object sender, MouseEventArgs e)
        {
            if (PicOjoRes.Image.Height.ToString() == "128")
            {
                txtContraRep.UseSystemPasswordChar = false;
                PicOjoRes.Image = Resources.OjoCerrado;
            }
            else
            {
                txtContraRep.UseSystemPasswordChar = true;
                PicOjoRes.Image = Resources.ojo;
            }
        }
    }
}

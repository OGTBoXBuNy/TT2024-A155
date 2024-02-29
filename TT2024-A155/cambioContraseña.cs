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
                AddOwnedForm(inicio);
                inicio.lblUsuario.Text = lblUsuario.Text;
                inicio.lblRol.Text = lblRol.Text;
                this.Hide();
                inicio.Show();

            }
        }
    }
}

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
    public partial class CrearUsuario : MaterialForm
    {
        public CrearUsuario()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
        }
        BD Consulta = new();
        Validaciones Validaciones = new();
        DataSet ds = new DataSet();
        DataView dv = new DataView();
        int existeUsuarioFinanzas;
        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            ds = Consulta.Roles();
            dv = ds.Tables[0].DefaultView;
            cmbRol.DataSource = dv;
            cmbRol.ValueMember = "idrol";
            cmbRol.DisplayMember = "nombre";


            existeUsuarioFinanzas = Consulta.validarExistenciaUsuarioFinanzas();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //-----------VALIDACION-----------------//
            bool validacion = true;
            errorNombre.Clear();
            errorUsuario.Clear();
            errorContrasenia.Clear();
            errorCalle.Clear();
            errorColonia.Clear();
            errorCP.Clear();
            errorTelefono.Clear();
            errorNoExt.Clear();
            errorNoInt.Clear();
            errorCiudad.Clear();
            errorCorreo.Clear();

            if (string.IsNullOrEmpty(txtNombre.Text.Trim())) { errorNombre.SetError(txtNombre, "Campo obligatorio"); validacion = false; }
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim())) { errorUsuario.SetError(txtUsuario, "Campo obligatorio"); validacion = false; }
            if (!Validaciones.contrasenaSegura(txtContrasenia.Text.Trim())) { errorContrasenia.SetError(txtContrasenia, "Campo obligatorio y cumplir con: Números, Letras, Carácter especial y longitud mayor o igual a 8"); validacion = false; }
            if (string.IsNullOrEmpty(txtCalle.Text.Trim())) { errorCalle.SetError(txtCalle, "Campo Obligatorio"); validacion = false; }

            if (string.IsNullOrEmpty(txtCol.Text.Trim())) { errorColonia.SetError(txtCol, "Campo obligatorio"); validacion = false; }
            if (string.IsNullOrEmpty(txtCP.Text.Trim())) { errorCP.SetError(txtCP, "Campo obligatorio"); validacion = false; }
            if (string.IsNullOrEmpty(txtTel.Text.Trim())) { errorTelefono.SetError(txtTel, "Campo Obligatorio"); validacion = false; }

            if (string.IsNullOrEmpty(txtNoExt.Text.Trim())) { errorNoExt.SetError(txtNoExt, "Campo obligatorio"); validacion = false; }
            if (string.IsNullOrEmpty(txtNoInt.Text.Trim())) { errorNoInt.SetError(txtNoInt, "Campo obligatorio / ó coloca 0"); validacion = false; }
            if (string.IsNullOrEmpty(txtCiudad.Text.Trim())) { errorCiudad.SetError(txtCiudad, "Campo Obligatorio"); validacion = false; }
            if (!Validaciones.validarCorreo(txtCorreo.Text.Trim())) { errorCorreo.SetError(txtCorreo, "Correo inválido"); validacion = false; }

            //-----------------------------


            if (validacion)
            {
                string rol = cmbRol.Text.Trim();
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

                string usuarioLog = lblUsuarioLog.Text.Trim();
                string descripcionLog = "El usuario : " + usuarioLog + " creó al nuevo usuario: " + usuario + " el día: " + DateTime.Now.ToString();
                Consulta.Log(usuario, "", descripcionLog, "17");
                this.Close();
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.soloLetras(sender, e);
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.soloNumerosDecimales(sender, e);
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



        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            PicOJO.Visible = true;
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            PicOJO.Visible = false;
        }

        private void PicOJO_MouseClick(object sender, MouseEventArgs e)
        {
            if (PicOJO.Image.Height.ToString() == "128")
            {
                txtContrasenia.UseSystemPasswordChar = false;
                PicOJO.Image = Resources.OjoCerrado;
            }
            else
            {
                txtContrasenia.UseSystemPasswordChar = true;
                PicOJO.Image = Resources.ojo;
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRol.Text.Trim() == "Finanzas" && existeUsuarioFinanzas == 1) 
            {
                cmbRol.SelectedIndex = 0;
                MessageBOX.SHowDialog(2,"Solo puede existir un usuario de Finanzas");
            }
        }
    }
}

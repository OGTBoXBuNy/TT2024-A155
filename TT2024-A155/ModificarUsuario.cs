﻿using System;
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
    public partial class ModificarUsuario : MaterialForm
    {
        public ModificarUsuario()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
        }
        //CONSTRUCTOR DEL FORM
        BD Consulta = new BD();
        Validaciones Validaciones = new();
        DataSet ds = new DataSet();
        DataView dv = new DataView();
        string[] datosCuenta;
        private string[] permisos;

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {


            ds = Consulta.Usuarios();
            dv = ds.Tables[0].DefaultView;
            cmbNombreUsuario.DataSource = dv;
            cmbNombreUsuario.ValueMember = "idrol";
            cmbNombreUsuario.DisplayMember = "nombre_usuario";
            cmbNombreUsuario.SelectedIndex = 0;
            txtUsuario.Text = cmbNombreUsuario.Text;


            ds = Consulta.Roles();
            dv = ds.Tables[0].DefaultView;
            cmbRol.DataSource = dv;
            cmbRol.ValueMember = "idrol";
            cmbRol.DisplayMember = "nombre";

            cmbRol.SelectedIndex = Convert.ToInt32(cmbNombreUsuario.SelectedValue.ToString()) - 1;

            txtCif.Enabled = false;
            btnSolicitarFirma.Enabled = false;
            datosCuenta = Consulta.datosPersonalesUsuario(cmbNombreUsuario.Text);

            txtNombre.Text = datosCuenta[0];
            txtCol.Text = datosCuenta[1];
            txtCalle.Text = datosCuenta[2];
            txtNoExt.Text = datosCuenta[3];
            txtNoInt.Text = datosCuenta[4];
            txtCP.Text = datosCuenta[5];
            txtCiudad.Text = datosCuenta[6];
            txtTel.Text = datosCuenta[7];
            txtCorreo.Text = datosCuenta[8];

        }

        private void datosPersonales()
        {
            txtNombre.Text = string.Empty;
            txtCol.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtNoExt.Text = string.Empty;
            txtNoInt.Text = string.Empty;
            txtCP.Text = string.Empty;
            txtCiudad.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtCif.Text = string.Empty;

            if (rbtnDatosPersonales.Checked == true)
            {
                txtContrasenia.Enabled = true;
                txtCif.Enabled = false;
                datosCuenta = Consulta.datosPersonalesUsuario(cmbNombreUsuario.Text);

                txtNombre.Text = datosCuenta[0];
                txtCol.Text = datosCuenta[1];
                txtCalle.Text = datosCuenta[2];
                txtNoExt.Text = datosCuenta[3];
                txtNoInt.Text = datosCuenta[4];
                txtCP.Text = datosCuenta[5];
                txtCiudad.Text = datosCuenta[6];
                txtTel.Text = datosCuenta[7];
                txtCorreo.Text = datosCuenta[8];
            }
        }

        private void rbtnDatosPersonales_CheckedChanged(object sender, EventArgs e)
        {
            datosPersonales();
            panelDatos.Enabled = true;
            panelDatos.Visible = true;
        }


        private void datosFiscales()
        {
            txtNombre.Text = string.Empty;
            txtCol.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtNoExt.Text = string.Empty;
            txtNoInt.Text = string.Empty;
            txtCP.Text = string.Empty;
            txtCiudad.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtCif.Text = string.Empty;
            if (rbtnDatosFiscales.Checked == true)
            {
                txtContrasenia.Enabled = false;
                txtCif.Enabled = true;
                datosCuenta = Consulta.datosFiscalesUsuario(cmbNombreUsuario.Text);

                txtNombre.Text = datosCuenta[0];
                txtCol.Text = datosCuenta[1];
                txtCalle.Text = datosCuenta[2];
                txtNoExt.Text = datosCuenta[3];
                txtNoInt.Text = datosCuenta[4];
                txtCP.Text = datosCuenta[5];
                txtCiudad.Text = datosCuenta[6];
                txtTel.Text = datosCuenta[7];
                txtCorreo.Text = datosCuenta[8];
                txtCif.Text = datosCuenta[9];
            }
        }



        private void cmbNombreUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbNombreUsuario.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                cmbRol.SelectedIndex = Convert.ToInt32(cmbNombreUsuario.SelectedValue.ToString()) - 1;
                //OBTENER PERMISOS SEGUN TIPO USUARIO

                permisos = Consulta.obtenerPermisos(cmbNombreUsuario.SelectedValue.ToString()); //1 ENABLE AND VISIBLE.... 0 DISABLE AND NO VISIBLE
                txtUsuario.Text = cmbNombreUsuario.Text;
            }


            if (cmbRol.Text == "Cliente")
            {
                rbtnDatosFiscales.Enabled = true;
            }
            else
            {
                rbtnDatosFiscales.Enabled = false;
                rbtnDatosPersonales.Checked = true;
            }

            if (rbtnDatosPersonales.Checked)
                datosPersonales();
            else if (rbtnDatosFiscales.Checked)
                datosFiscales();
            else { }

            if(cmbRol.Text == "Finanzas")
            {
                btnSolicitarFirma.Enabled = true;
                btnSolicitarFirma.Visible = true;
            }
            else
            {
                btnSolicitarFirma.Enabled = false;
                btnSolicitarFirma.Visible = false;
            }
                

        }

        private void rbtnDatosPersonales_CheckedChanged_1(object sender, EventArgs e)
        {
            datosPersonales();
            panelDatos.Enabled = true;
            panelDatos.Visible = true;
        }

        private void rbtnDatosFiscales_CheckedChanged(object sender, EventArgs e)
        {
            datosFiscales();
            panelDatos.Enabled = true;
            panelDatos.Visible = true;
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
            errorCif.Clear();

            if (string.IsNullOrEmpty(txtNombre.Text.Trim())) { errorNombre.SetError(txtNombre, "Campo obligatorio"); validacion = false; }
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim())) { errorUsuario.SetError(txtUsuario, "Campo obligatorio"); validacion = false; }
            if (!string.IsNullOrEmpty(txtContrasenia.Text.Trim()))
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
            string cif = txtCif.Text.Trim();
            string idrol = cmbRol.SelectedValue.ToString();

            if (rbtnDatosPersonales.Checked)
            {
                if (validacion)
                {

                    if (txtContrasenia.Text.Trim() != "")
                    {
                        Consulta.actualizarDatosPersonalesAdmin(1, contra, usuario, nombre, colonia, calle, noExt, noInt, cp, ciudad, telefono, correo, idrol);
                    }
                    else
                    {
                        Consulta.actualizarDatosPersonalesAdmin(0, contra, usuario, nombre, colonia, calle, noExt, noInt, cp, ciudad, telefono, correo, idrol);
                    }
                    string usuarioLog = lblUsuarioLog.Text.Trim();
                    string descripcionLog = "El usuario : " + usuarioLog + " modificó los datos personales del usuario: " + usuario + " el día: " + DateTime.Now.ToString();
                    Consulta.Log(usuario, "", descripcionLog, "19");
                    this.Close();
                }
            }
            else if (rbtnDatosFiscales.Checked)
            {
                if (string.IsNullOrEmpty(txtCif.Text.Trim())) { errorCif.SetError(txtCif, "Campo Obligatorio"); validacion = false; }

                if (validacion)
                {

                    Consulta.actualizarDatosFiscalesCliente(usuario, nombre, cif, calle, colonia, noExt, noInt, cp, ciudad, telefono, correo);
                    string usuarioLog = lblUsuarioLog.Text.Trim();
                    string descripcionLog = "El usuario : " + usuarioLog + " modificó los datos fiscales del usuario: " + usuario + " el día: " + DateTime.Now.ToString();
                    Consulta.Log(usuario, "", descripcionLog, "19");
                    this.Close();
                }
            }
            else if (rbtnPermisos.Checked)
            {

            }
            else { }

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

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSolicitarFirma_Click(object sender, EventArgs e)
        {
            MessageBOX mes = new MessageBOX(4, "¿Está seguro de querer solicitar la firma nuevamente para este usuario?");

            if (mes.ShowDialog() == DialogResult.OK)
            {
                string usuario = lblUsuario.Text;
                string usuarioSistema = cmbNombreUsuario.Text;
                Consulta.solicitarFirma(usuarioSistema);
                string descripcionLog = "El administrador : " + usuario + " solicito la firma nuevamente para el usuario : " + usuarioSistema + " el día: " + DateTime.Now.ToString();
                Consulta.Log(usuario, "", descripcionLog, "21");

            }
        }
    }
}

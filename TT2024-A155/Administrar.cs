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
    public partial class Administrar : MaterialForm
    {
        //CONSTRUCTOR DEL FORM
        BD Consulta = new BD();
        DataSet ds = new DataSet();
        DataView dv = new DataView();
        string[] datosCuenta;

        public Administrar()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
        }



        private void Administrar_Load(object sender, EventArgs e)
        {


            ds = Consulta.Roles();
            dv = ds.Tables[0].DefaultView;
            cmbRol.DataSource = dv;
            cmbRol.ValueMember = "idrol";
            cmbRol.DisplayMember = "nombre";

            cmbRol.SelectedIndex = Convert.ToInt32(lblRolF.Text) - 1;
            cmbRol.Enabled = false;

            txtUsuario.Text = lblUsuarioF.Text;
            txtUsuario.Enabled = false;
            txtCif.Enabled = false;

            datosCuenta = Consulta.datosPersonalesUsuario(lblUsuarioF.Text);

            txtNombre.Text = datosCuenta[0];
            txtCol.Text = datosCuenta[1];
            txtCalle.Text = datosCuenta[2];
            txtNoExt.Text = datosCuenta[3];
            txtNoInt.Text = datosCuenta[4];
            txtCP.Text = datosCuenta[5];
            txtCiudad.Text = datosCuenta[6];
            txtTel.Text = datosCuenta[7];
            txtCorreo.Text = datosCuenta[8];

            if (lblRolF.Text == "4")
            {
                rbtnDatosFiscales.Enabled = true;
                rbtnDatosFiscales.Visible = true;
            }
            else
            {
                rbtnDatosFiscales.Enabled = false;
                rbtnDatosFiscales.Visible = false;
            }



        }



        private void btnAceptar_Click(object sender, EventArgs e)
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
            string cif = txtCif.Text.Trim();

            if (rbtnDatosPersonales.Checked)
            {
                if (txtContrasenia.Text.Trim() != "")
                {
                    Consulta.actualizarDatosPersonales(1, contra, usuario, nombre, colonia, calle, noExt, noInt, cp, ciudad, telefono, correo);
                }
                else
                {
                    Consulta.actualizarDatosPersonales(0, contra, usuario, nombre, colonia, calle, noExt, noInt, cp, ciudad, telefono, correo);
                }

                string descripcionLog = "El usuario : " + usuario + " actualizó datos personales de la cuenta: " + " el día: " + DateTime.Now.ToString();
                Consulta.Log(usuario, "", descripcionLog, "18");
            }
            else if (rbtnDatosFiscales.Checked)
            {
                Consulta.actualizarDatosFiscalesCliente(usuario, nombre, cif, calle, colonia, noExt, noInt, cp, ciudad, telefono, correo);
                string descripcionLog = "El usuario : " + usuario + " actualizó datos fiscales de la cuenta: " + " el día: " + DateTime.Now.ToString();
                Consulta.Log(usuario, "", descripcionLog, "18");
            }
            else { }
        }

        private void rbtnDatosPersonales_CheckedChanged(object sender, EventArgs e)
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
                datosCuenta = Consulta.datosPersonalesUsuario(lblUsuarioF.Text);

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



        private void rbtnDatosFiscales_CheckedChanged(object sender, EventArgs e)
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
                datosCuenta = Consulta.datosFiscalesUsuario(lblUsuarioF.Text);

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
    }
}

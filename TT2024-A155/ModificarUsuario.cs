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
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }
        //CONSTRUCTOR DEL FORM
        BD Consulta = new BD();
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

        private void rbtnDatosFiscales_CheckedChanged(object sender, EventArgs e)
        {
            datosFiscales();
            panelDatos.Enabled = true;
            panelDatos.Visible = true;
        }

        private void rbtnPermisos_CheckedChanged(object sender, EventArgs e)
        {
            panelDatos.Enabled = false;
            panelDatos.Visible = false;
        }

        private void cmbNombreUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbNombreUsuario.SelectedValue.ToString() != "System.Data.DataRowView")
                cmbRol.SelectedIndex = Convert.ToInt32(cmbNombreUsuario.SelectedValue.ToString()) - 1;

            if(cmbRol.Text == "Cliente")
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

            //OBTENER PERMISOS SEGUN USUARIO
            permisos = Consulta.obtenerPermisos(lblRol.Text.Trim()); //1 ENABLE AND VISIBLE.... 0 DISABLE AND NO VISIBLE

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
            string idrol = cmbRol.SelectedValue.ToString();

            if (rbtnDatosPersonales.Checked)
            {
                if (txtContrasenia.Text.Trim() != "")
                {
                    Consulta.actualizarDatosPersonalesAdmin(1, contra, usuario, nombre, colonia, calle, noExt, noInt, cp, ciudad, telefono, correo, idrol);
                }
                else
                {
                    Consulta.actualizarDatosPersonalesAdmin(0, contra, usuario, nombre, colonia, calle, noExt, noInt, cp, ciudad, telefono, correo, idrol);
                }
            }
            else if (rbtnDatosFiscales.Checked)
            {
                Consulta.actualizarDatosFiscalesCliente(usuario, nombre, cif, calle, colonia, noExt, noInt, cp, ciudad, telefono, correo);
            }
            else if (rbtnPermisos.Checked) 
            {
                
            }
            else { }
        }
    }
}

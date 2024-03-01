using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;
//Diseño
using MaterialSkin.Controls;
using TT2024_A155.Properties;

namespace TT2024_A155
{
    public partial class inicioSesion : MaterialForm
    {
        //CONSTRUCTOR DEL FORM
        BD Consulta = new BD();

        public inicioSesion()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
        }

        private void inicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            int[] inicioSesion = Consulta.inicioSesion(txtUsuario.Text.Trim(), txtContrasenia.Text.Trim());
            if (inicioSesion[0] == 1)
            {

                if (Consulta.validarContraTemp(txtUsuario.Text.Trim()) == 1)
                {
                    cambioContraseña cambioContra = new();
                    AddOwnedForm(cambioContra);
                    cambioContra.lblUsuario.Text = txtUsuario.Text.Trim();
                    cambioContra.lblRol.Text = inicioSesion[1].ToString();
                    cambioContra.Show();

                    this.Hide();
                }
                else
                {
                    Inicio inicio = new Inicio();
                    AddOwnedForm(inicio);
                    inicio.lblUsuario.Text += txtUsuario.Text.Trim();
                    inicio.lblRol.Text = inicioSesion[1].ToString();
                    inicio.Show();
                    MessageBox.Show("Inicio sesión exitoso");
                    string descripcionLog = "El usuario " + txtUsuario.Text + " Inicio sesión al sistema el día: " + DateTime.Now.ToString();
                    Consulta.Log(txtUsuario.Text, "", descripcionLog, "1");
                    this.Hide();

                }

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
                txtUsuario.Text = "";
                txtContrasenia.Text = "";

            }
        }

        private void lblRestablecerContrasenia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            restablecerContraseña res = new();

            res.ShowDialog();

        }

        private void inicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            Form1 form1 = new();
            form1.ShowDialog();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //-----------VALIDACION-----------------//
            bool validacion = true;
            errorUsuario.Clear();
            errorContrasenia.Clear();

            if (string.IsNullOrEmpty(txtUsuario.Text.Trim())) { errorUsuario.SetError(txtUsuario, "Campo obligatorio"); validacion = false; }
            if (string.IsNullOrEmpty(txtContrasenia.Text.Trim())) { errorContrasenia.SetError(txtContrasenia, "Campo obligatorio"); validacion = false; }

            //-----------------------------

            if (validacion)
            {
                int[] inicioSesion = Consulta.inicioSesion(txtUsuario.Text.Trim(), txtContrasenia.Text.Trim());
                if (inicioSesion[0] == 1)
                {

                    if (Consulta.validarContraTemp(txtUsuario.Text.Trim()) == 1)
                    {
                        cambioContraseña cambioContra = new();
                        AddOwnedForm(cambioContra);
                        cambioContra.lblUsuario.Text = txtUsuario.Text.Trim();
                        cambioContra.lblRol.Text = inicioSesion[1].ToString();
                        cambioContra.Show();

                        this.Hide();
                    }
                    else
                    {
                        Inicio inicio = new Inicio();
                        AddOwnedForm(inicio);
                        inicio.lblUsuario.Text += txtUsuario.Text.Trim();
                        inicio.lblRol.Text = inicioSesion[1].ToString();
                        inicio.Show();
                        MessageBOX.SHowDialog(3, "Bienvenido de vuelta: " + txtUsuario.Text.Trim());
                        string descripcionLog = "El usuario " + txtUsuario.Text + " Inicio sesión al sistema el día: " + DateTime.Now.ToString();
                        Consulta.Log(txtUsuario.Text, "", descripcionLog, "1");
                        this.Hide();

                    }

                }
                else
                {
                    MessageBOX.SHowDialog(2, "Datos incorrectos");
                    txtUsuario.Text = "";
                    txtContrasenia.Text = "";

                }
            }
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            PicOJO.Visible = false;
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            PicOJO.Visible = true;
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

        private void PicOJO_MouseHover(object sender, EventArgs e)
        {
            //if (PicOJO.Image.Height.ToString() == "128")
            //    this.ToolTrip.SetToolTip(PicOJO, "Mostrar contraseña");
            //else
            //    this.ToolTrip.SetToolTip(PicOJO, "Ocultar contraseña");
        }
    }
}

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

namespace TT2024_A155
{
    public partial class inicioSesion : Form
    {
        //CONSTRUCTOR DEL FORM
        BD Consulta = new BD();

        public inicioSesion()
        {
            InitializeComponent();
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

            res.Show();

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
    }
}

﻿using System;
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





            if (Consulta.inicioSesion(txtUsuario.Text.Trim(), txtContrasenia.Text.Trim()) == 1)
            {
                
                if (Consulta.validarContraTemp(txtUsuario.Text.Trim()) == 1)
                {
                    cambioContraseña cambioContra = new();
                    AddOwnedForm(cambioContra);
                    cambioContra.lblUsuario.Text = txtUsuario.Text.Trim();
                    cambioContra.Show();
                    this.Hide();
                }
                else
                {
                    Inicio inicio = new Inicio();
                    AddOwnedForm(inicio);
                    inicio.lblUsuario.Text += txtUsuario.Text.Trim();
                    inicio.Show();
                    MessageBox.Show("Inicio sesión exitoso");
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
    }
}
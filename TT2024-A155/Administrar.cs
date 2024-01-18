﻿using System;
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
    public partial class Administrar : Form
    {
        //CONSTRUCTOR DEL FORM
        BD Consulta = new BD();
        DataSet ds = new DataSet();
        DataView dv = new DataView();
        public Administrar()
        {
            InitializeComponent();
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

            Consulta.registroUsuario(rol, usuario, nombre, contra, calle, colonia, noExt, noInt, cp, ciudad, telefono, correo);
        }

        private void Administrar_Load(object sender, EventArgs e)
        {
            ds = Consulta.Roles();
            dv = ds.Tables[0].DefaultView;
            cmbRol.DataSource = dv;
            cmbRol.ValueMember = "nombre";
            cmbRol.SelectedIndex = 0;
        }
    }
}

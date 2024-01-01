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
    public partial class Administrar : Form
    {
        //CONSTRUCTOR DEL FORM
        BD Consulta = new BD();

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
            string direccion = txtDireccion.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            Consulta.registroUsuario(rol, usuario, nombre, contra, direccion, telefono, correo);
        }

        private void Administrar_Load(object sender, EventArgs e)
        {
            cmbRol.SelectedIndex = 0;
        }
    }
}

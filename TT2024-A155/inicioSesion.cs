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
            


            

            if (Consulta.inicioSesion(txtUsuario.Text, txtContrasenia.Text) == 1)
            {
                MessageBox.Show("Inicio sesión exitoso");

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
                
            }
        }
    }
}

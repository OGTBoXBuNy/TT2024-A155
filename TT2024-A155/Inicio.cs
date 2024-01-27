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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        BD Consulta = new BD();
        private string[] permisos; 

        private void Inicio_Load(object sender, EventArgs e)
        {
            //OBTENER PERMISOS SEGUN USUARIO
            permisos = Consulta.obtenerPermisos(lblRol.Text.Trim());

            if (permisos[0] == "1")//CREAR USUARIOS
            {

            }
            if (permisos[1] == "1")//MODIFICAR USUARIOS
            {

            }
            if (permisos[2] == "1")//CREAR PEDIDOS
            {

            }
            if (permisos[3] == "1")//MODIFICAR PEDIDOS
            {

            }
            if (permisos[4] == "1")//CONFIRMAR PEDIDOS
            {

            }
            if (permisos[5] == "1")//REGISTRAR ENTREGA
            {

            }
            if (permisos[6] == "1")//REGISTRAR DEVOLUCION
            {

            }
            if (permisos[7] == "1")//GENERAR FIRMA
            {

            }
            if (permisos[8] == "1")//GENERAR FACTURA 
            {

            }
            if (permisos[9] == "1")//GENERAR REPORTE VENTAS
            {

            }


        }


        private void btnCrearPedido_Click(object sender, EventArgs e)
        {

            Pedido pedido = new Pedido(0);//0 = CREAR PEDIDO,,,, 1 = ACTUALIZAR
            pedido.lblUsuario.Text = lblUsuario.Text;
            pedido.lblRol.Text = lblRol.Text;
            pedido.ShowDialog();
            //this.Hide();

        }

        
    }
}

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
    public partial class SubMenu : Form
    {
        public SubMenu()
        {
            InitializeComponent();
        }
        BD Consulta = new();
        private string[] permisos;
        private void SubMenu_Load(object sender, EventArgs e)
        {
            //OBTENER PERMISOS SEGUN USUARIO
            permisos = Consulta.obtenerPermisos(lblRol.Text.Trim()); //1 ENABLE AND VISIBLE.... 0 DISABLE AND NO VISIBLE 
        }

        private void btnModificarDatosPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(1);//0 = CREAR PEDIDO,,,, 1 = ACTUALIZAR
            pedido.lblUsuario.Text = lblUsuario.Text;
            pedido.lblRol.Text = lblRol.Text;
            pedido.lblIdPedido.Text = lblIdPedido.Text;
            if (pedido.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            Factura factura = new();
            factura.lblIDPedido.Text = lblIdPedido.Text;
            factura.lblUsuario.Text = lblUsuario.Text;
            factura.ShowDialog();

        }
    }
}

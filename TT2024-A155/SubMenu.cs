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
    public partial class SubMenu : MaterialForm
    {
        public SubMenu()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
        }
        BD Consulta = new();
        private string[] permisos;
        private string[] detalles;
        private void SubMenu_Load(object sender, EventArgs e)
        {
            //OBTENER PERMISOS SEGUN USUARIO
            permisos = Consulta.obtenerPermisos(lblRol.Text.Trim()); //1 ENABLE AND VISIBLE.... 0 DISABLE AND NO VISIBLE 
            //OBTENER DETALLES SOBRE FACTURACION, ENTREGA Y DEVOLUCION
            detalles = Consulta.subMenu(lblIdPedido.Text.Trim());// 0 Facturacion, 1 Facturacion, 2 ENTREGA, 3 DEVOLUCION

            string idPedido = lblIdPedido.Text.Trim();
            string rol = lblRol.Text.Trim();

            if (permisos[3] == "1")//MODIFICAR PEDIDOS
            {
                btnModificarDatosPedido.Enabled = true;
            }

            if (permisos[5] == "1")//REGISTRAR ENTREGA
            {
                btnRegistrarEntrega.Enabled = true;
            }
            if (permisos[6] == "1")//REGISTRAR DEVOLUCION
            {
                btnRegistrarDevolucion.Enabled = true;
            }

            if (permisos[8] == "1")//GENERAR FACTURA 
            {
                btnGenerarFactura.Enabled = true;
            }


            if (Consulta.existeFactura(idPedido) == 1)
                btnGenerarFactura.Enabled = false;
            if (Consulta.existeEntrega(idPedido) == 1)
                btnRegistrarEntrega.Enabled = false;
            if (Consulta.existeDevolucion(idPedido) == 1)
                btnRegistrarDevolucion.Enabled = false;


        }

        private void btnModificarDatosPedido_Click(object sender, EventArgs e)
        {
            if (bool.Parse(detalles[0]) == true)
            {
                MessageBOX.SHowDialog(2, "Este pedido ya ha sido aprobado, no se permiten cambios");
            }
            else if (detalles[1] != string.Empty)
            {
                MessageBOX.SHowDialog(2, "Ya esta facturado el pedido");
            }
            else
            {
                Pedido pedido = new Pedido(1);//0 = CREAR PEDIDO,,,, 1 = ACTUALIZAR
                pedido.lblUsuario.Text = lblUsuario.Text;
                pedido.lblRol.Text = lblRol.Text;
                pedido.lblIdPedido.Text = lblIdPedido.Text;
                if (pedido.ShowDialog() == DialogResult.OK)
                {

                }
            }

            
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (bool.Parse(detalles[0]) == true && detalles[1] == string.Empty)
            {
                Factura factura = new();
                factura.lblIDPedido.Text = lblIdPedido.Text;
                factura.lblUsuario.Text = lblUsuario.Text;
                factura.ShowDialog();
                this.Close();
            }
            else if (bool.Parse(detalles[0]) == false)
            {
                MessageBOX.SHowDialog(2, "En espera de aprobación por cliente");
            }
            else
            {
                MessageBOX.SHowDialog(2, "Ya se ha registrado factura previamente");
            }
            
        }

        private void btnRegistrarEntrega_Click(object sender, EventArgs e)
        {

            if (detalles[2] != string.Empty && detalles[1] != string.Empty) 
            {
                MessageBOX mes = new MessageBOX(4, "¿Está seguro de marcar este pedido como entregado?");

                if (mes.ShowDialog() == DialogResult.OK)
                {
                    string usuario = lblUsuario.Text;
                    string pedido = lblIdPedido.Text;
                    DateTime hoy = DateTime.Now;
                    string fecha = hoy.Year.ToString() + "-" + hoy.Month.ToString() + "-" + hoy.Day.ToString();
                    Consulta.entregarPedido(pedido, usuario, fecha);

                    string descripcionLog = "El usuario : " + usuario + " entregó el pedido : " + pedido + " el día: " + DateTime.Now.ToString();
                    Consulta.Log(usuario, pedido, descripcionLog, "13");
                    this.Close();
                }
            }
            else if (detalles[1] == string.Empty)
            {
                MessageBOX.SHowDialog(2, "En espera de que se facture el pedido");
            }
            else
            {
                MessageBOX.SHowDialog(2, "Ya se ah registrado entrega previamente");
            }

            
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            if (detalles[1] != string.Empty && detalles[2] != string.Empty) 
            {
                MessageBOX mes = new MessageBOX(4, "¿Está seguro de marcar este pedido como devuelto?");

                if (mes.ShowDialog() == DialogResult.OK)
                {
                    string usuario = lblUsuario.Text;
                    string pedido = lblIdPedido.Text;
                    DateTime hoy = DateTime.Now;
                    string fecha = hoy.Year.ToString() + "-" + hoy.Month.ToString() + "-" + hoy.Day.ToString();
                    Consulta.devolverPedido(pedido, usuario, fecha);

                    string descripcionLog = "El usuario : " + usuario + " devolvió el pedido : " + pedido + " el día: " + DateTime.Now.ToString();
                    Consulta.Log(usuario, pedido, descripcionLog, "14");
                    this.Close();
                }
            }
            else if (detalles[2] == string.Empty)
            {
                MessageBOX.SHowDialog(2,"En espera de que se realice una entrega primero");
            }
            else
            {
                MessageBOX.SHowDialog(2,"Ya se ha registrado una devolución");
            }


            
        }
    }
}

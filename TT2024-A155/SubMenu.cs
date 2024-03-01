﻿using System;
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

        private void btnRegistrarEntrega_Click(object sender, EventArgs e)
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

            }
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
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

            }
        }
    }
}

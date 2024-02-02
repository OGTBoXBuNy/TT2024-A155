using iText.Kernel.Colors;
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
        BD Consulta = new();
        private string[] permisos;

        private void Inicio_Load(object sender, EventArgs e)
        {
            //OBTENER PERMISOS SEGUN USUARIO
            permisos = Consulta.obtenerPermisos(lblRol.Text.Trim()); //1 ENABLE AND VISIBLE.... 0 DISABLE AND NO VISIBLE 

            if (permisos[0] == "1")//CREAR USUARIOS
            {
                crearUsuariosToolStripMenuItem.Enabled = true;
                crearUsuariosToolStripMenuItem.Visible = true;
            }
            if (permisos[1] == "1")//MODIFICAR USUARIOS
            {
                modificarUsuariosToolStripMenuItem.Enabled = true;
                modificarUsuariosToolStripMenuItem.Visible = true;
            }
            if (permisos[2] == "1")//CREAR PEDIDOS
            {
                btnCrearPedido.Enabled = true;
                btnCrearPedido.Visible = true;
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

            if(lblRol.Text == "4")//LLENAR EL DATAGRIDVIEW SEGUN SI ES CLIENTE O EMPLEADO
            {
                Consulta.inicioClientePedidos(dgvPedido);
                dgvPedido.Columns["idpedido"].Visible = false;
                //dgvPedido.Columns["Autorizado"]. = true;
                dgvPedido.Columns["impuesto"].Visible = false;
                dgvPedido.Columns["total"].Visible = false;
                dgvPedido.Columns["comentarios"].Visible = false;

                foreach (DataGridViewRow row in dgvPedido.Rows)
                {
                    if (Boolean.Parse(row.Cells["Autorizado"].Value.ToString()) == true)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                        //row.Cells["Autorizado"].Value = "Autorizado";
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                        //row.Cells["Autorizado"].Value = "En revisión";
                    }
                }



            }
            else
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

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            inicioSesion inicioSesion = new();
            inicioSesion.Show();
        }
    }
}

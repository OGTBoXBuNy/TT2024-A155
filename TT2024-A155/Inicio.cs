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
        private string[] detallesPedido;

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

            if (lblRol.Text == "4")//LLENAR EL DATAGRIDVIEW SEGUN SI ES CLIENTE O EMPLEADO
            {
                var btnAceptarPedido = new DataGridViewButtonColumn();
                btnAceptarPedido.Name = "dataGridViewAceptarPedido";
                btnAceptarPedido.HeaderText = "Estado pedido";
                btnAceptarPedido.Text = "";
                btnAceptarPedido.FlatStyle = FlatStyle.Popup;
                btnAceptarPedido.CellTemplate.Style.BackColor = System.Drawing.Color.DarkGoldenrod;
                //btnAceptarPedido.UseColumnTextForButtonValue = true;
                dgvPedido.Columns.Add(btnAceptarPedido);

                inicializarDgvCliente(lblUsuario.Text);
            }
            else
            {
                inicializarDgvEmpleado(lblUsuario.Text);
            }


        }


        private void btnCrearPedido_Click(object sender, EventArgs e)
        {

            Pedido pedido = new Pedido(0);//0 = CREAR PEDIDO,,,, 1 = ACTUALIZAR
            pedido.lblUsuario.Text = lblUsuario.Text;
            pedido.lblRol.Text = lblRol.Text;
            if (pedido.ShowDialog() == DialogResult.OK)
            {
                if (lblRol.Text == "4")
                {
                    inicializarDgvCliente(lblUsuario.Text);
                }
                else
                {
                    inicializarDgvEmpleado(lblUsuario.Text);
                }
                    
            }
            //this.Hide();

        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            inicioSesion inicioSesion = new();
            inicioSesion.Show();
        }


        public void llenarDetallesPedido(string[] detallesPedido)
        {

            lblNoPedido.Text = "# Pedido: " + detallesPedido[0];
            lblFechaCreacion.Text = "Fecha Creación: " + detallesPedido[1];
            lblCliente.Text = "Cliente: " + detallesPedido[2] + "-" + detallesPedido[3];
            lblVendedor.Text = "Vendedor: " + detallesPedido[16];
            lblProducto.Text = "Producto: " + detallesPedido[4];
            lblCantidad.Text = "Cantidad: " + detallesPedido[5];
            lblPrecio.Text = "Precio Venta: $" + detallesPedido[6];
            lblDescuento.Text = "Descuento: " + detallesPedido[7];
            lblMarca.Text = "Marca: " + detallesPedido[8];
            lblModelo.Text = "Modelo: " + detallesPedido[9];
            txtComentarios.Text = detallesPedido[10];
            lblAprobacion.Text = "Estado: " + detallesPedido[11];
            lblFactura.Text = "# Factura: " + detallesPedido[12];
            lblFactSinIva.Text = "Factura sin IVA: " + detallesPedido[13];
            lblImpuesto.Text = "Impuesto: " + detallesPedido[15];
            lblFactIVA.Text = "Factura con IVA: " + detallesPedido[14];


        }

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = Int32.Parse(e.RowIndex.ToString());

            //if click is on new row or header row
            if (e.RowIndex == dgvPedido.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column
            if (dgvPedido.Columns["dataGridViewAceptarPedido"] != null && e.ColumnIndex == dgvPedido.Columns["dataGridViewAceptarPedido"].Index)
            {
                foreach (DataGridViewRow row in dgvPedido.SelectedRows)
                {


                    if (Boolean.Parse(row.Cells["Autorizado"].Value.ToString()))//Si le da clic al boton para aceptar el pedido
                    {
                        MessageBox.Show("Ya se autorizo previamente, ya no es posible modificarlo");
                    }
                    else
                    {
                        MessageBOX mes = new MessageBOX(4, "¿Esta seguro de querer autorizar este pedido?");

                        if (mes.ShowDialog() == DialogResult.OK)
                        {
                            Consulta.aprobarPedidoCliente(dgvPedido.Rows[fila].Cells[2].Value.ToString());
                            inicializarDgvCliente(lblUsuario.Text);

                        }

                    }


                }


                return;
            }



            if (fila == -1) { }
            else if (e.ColumnIndex == -1)
            {

                detallesPedido = Consulta.detallesPedido(dgvPedido.Rows[fila].Cells[1].Value.ToString());
                llenarDetallesPedido(detallesPedido);
                return;

            }
            else
            {



                foreach (DataGridViewRow row in dgvPedido.SelectedRows)
                {
                    MessageBox.Show(row.Cells["iddetalle_pedido"].Value.ToString());
                }
            }


        }

        private void pbFactura_Click(object sender, EventArgs e)
        {
            //detallesPedido[0] = idPedido
            if (detallesPedido != null)
                Consulta.generarComprobante(detallesPedido[0], dgvDatosPDF, false);
        }

        private void inicializarDgvCliente(string usuario)
        {
            Consulta.inicioClientePedidos(dgvPedido, usuario);
            dgvPedido.Columns["idpedido"].Visible = false;
            dgvPedido.Columns["Autorizado"].Visible = false;
            dgvPedido.Columns["impuesto"].Visible = false;
            dgvPedido.Columns["total"].Visible = false;
            dgvPedido.Columns["comentarios"].Visible = false;
            dgvPedido.Columns["iddetalle_pedido"].Visible = false;

            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                if (Boolean.Parse(row.Cells["Autorizado"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Green;

                    row.Cells["dataGridViewAceptarPedido"].Value = "Revisado";

                }
                else
                {

                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                    row.Cells["dataGridViewAceptarPedido"].Value = "En Revisión";
                }
            }
        }


        private void inicializarDgvEmpleado(string usuario)
        {
            Consulta.inicioPedidosEmpleados(dgvPedido, usuario);
            //dgvPedido.Columns["idpedido"].Visible = false;
            dgvPedido.Columns["Usuario"].Visible = false;
            dgvPedido.Columns["Nombre"].Visible = false;
            dgvPedido.Columns["Autorizado"].Visible = false;
            dgvPedido.Columns["impuesto"].Visible = false;
            dgvPedido.Columns["total"].Visible = false;
            dgvPedido.Columns["comentarios"].Visible = false;
            dgvPedido.Columns["iddetalle_pedido"].Visible = false;

            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                if (Boolean.Parse(row.Cells["Autorizado"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Green;

                }
                else
                {

                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                    
                }
            }
        }

    }
}



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
//Diseño
using MaterialSkin.Controls;
using System.Text.RegularExpressions;

namespace TT2024_A155
{
    public partial class Inicio : MaterialForm
    {
        public Inicio()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
        }
        BD Consulta = new();
        Validaciones Validaciones = new();
        private string[] permisos;
        private string[] detallesPedido;
        System.Drawing.Color _colorPendiente = System.Drawing.ColorTranslator.FromHtml("#FFD034");
        System.Drawing.Color _colorAceptados = System.Drawing.ColorTranslator.FromHtml("#209D5C");
        System.Drawing.Color _colorbtnRevision = System.Drawing.ColorTranslator.FromHtml("#AF8016");

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
                generarReporteDeVentasToolStripMenuItem.Enabled = true;
                generarReporteDeVentasToolStripMenuItem.Visible = true;
            }
            if (permisos[10] == "1")//REVISAR LOG
            {
                logCambiosSistemaToolStripMenuItem.Enabled = true;
                logCambiosSistemaToolStripMenuItem.Visible = true;
            }

            if (lblRol.Text == "4")//LLENAR EL DATAGRIDVIEW SEGUN SI ES CLIENTE O EMPLEADO
            {
                var btnAceptarPedido = new DataGridViewButtonColumn();
                btnAceptarPedido.Name = "dataGridViewAceptarPedido";
                btnAceptarPedido.HeaderText = "Estado pedido";
                btnAceptarPedido.Text = "";
                btnAceptarPedido.FlatStyle = FlatStyle.Popup;
                btnAceptarPedido.CellTemplate.Style.BackColor = _colorbtnRevision;
                //btnAceptarPedido.UseColumnTextForButtonValue = true;
                dgvPedido.Columns.Add(btnAceptarPedido);

                inicializarDgvCliente(lblUsuario.Text);

                lblNomCliente.Visible = false;
                txtFiltroCliente.Visible = false;
                lblNombreUsuario.Visible = false;
                txtFiltroUsuario.Visible = false;
            }
            else
            {
                inicializarDgvEmpleado(lblUsuario.Text);
            }


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
            lblVendedor.Text = "Vendedor: " + Consulta.nombreVendedor(detallesPedido[16]);
            lblProducto.Text = "Producto: " + detallesPedido[4];
            lblCantidad.Text = "Cantidad: " + detallesPedido[5];
            lblPrecio.Text = "Precio Venta: $" + detallesPedido[6];
            lblDescuento.Text = "Descuento: %" + detallesPedido[7];
            lblMarca.Text = "Marca: " + detallesPedido[8];
            lblModelo.Text = "Modelo: " + detallesPedido[9];
            lblAnio.Text = "Año: " + detallesPedido[17];
            txtComentarios.Text = detallesPedido[10];
            lblAprobacion.Text = "Estado: " + detallesPedido[11];
            lblFactura.Text = "# Factura: " + detallesPedido[12];
            lblFactSinIva.Text = "Factura sin IVA: $" + detallesPedido[13];
            lblImpuesto.Text = "Impuesto: $" + detallesPedido[15];
            lblFactIVA.Text = "Factura con IVA: $" + detallesPedido[14];
            txtComenatriosFact.Text = detallesPedido[18];
            lblEntregadoPor.Text = "Entregado Por: " + Consulta.nombreVendedor(detallesPedido[19]);
            lblfechaEntrega.Text = "Fecha Entrega: " + detallesPedido[20];
            lblDevueltoPor.Text = "Devuelto Por: " + Consulta.nombreVendedor(detallesPedido[21]);
            lblfechaDevolucion.Text = "Fecha Devolución: " + detallesPedido[22];

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
                        MessageBOX mes = new MessageBOX(4, "¿Está seguro de querer autorizar este pedido?");

                        if (mes.ShowDialog() == DialogResult.OK)
                        {
                            Consulta.aprobarPedidoCliente(dgvPedido.Rows[fila].Cells[2].Value.ToString());
                            inicializarDgvCliente(lblUsuario.Text);
                            string usuario = lblUsuario.Text;
                            string pedido = dgvPedido.Rows[fila].Cells[2].Value.ToString();
                            string descripcionLog = "El usuario : " + usuario + " autorizó el pedido : " + pedido + " el día: " + DateTime.Now.ToString();
                            Consulta.Log(usuario, "", descripcionLog, "7");

                        }

                    }


                }


                return;
            }



            if (fila == -1) { }
            else if (e.ColumnIndex == -1)
            {
                if (lblRol.Text == "4")
                {
                    detallesPedido = Consulta.detallesPedido(dgvPedido.Rows[fila].Cells[1].Value.ToString());
                    llenarDetallesPedido(detallesPedido);
                    return;
                }
                else if (lblRol.Text == "2")
                {
                    detallesPedido = Consulta.detallesPedido(dgvPedido.Rows[fila].Cells[0].Value.ToString());
                    llenarDetallesPedido(detallesPedido);
                    return;
                }
                else { }


            }
            else
            {
                string idPedido;

                if (lblRol.Text == "4")
                {

                    idPedido = dgvPedido.Rows[fila].Cells[2].Value.ToString();
                    SubMenu subMenu = new();
                    subMenu.lblUsuario.Text = lblUsuario.Text;
                    subMenu.lblRol.Text = lblRol.Text;
                    subMenu.lblIdPedido.Text = idPedido;
                    subMenu.ShowDialog();

                }
                else if (lblRol.Text == "2")
                {

                    idPedido = dgvPedido.Rows[fila].Cells[1].Value.ToString();
                    SubMenu subMenu = new();
                    subMenu.lblUsuario.Text = lblUsuario.Text;
                    subMenu.lblRol.Text = lblRol.Text;
                    subMenu.lblIdPedido.Text = idPedido;
                    subMenu.ShowDialog();
                }
                else { }


                foreach (DataGridViewRow row in dgvPedido.SelectedRows)
                {
                    //MessageBox.Show(row.Cells["iddetalle_pedido"].Value.ToString());
                }
            }


        }

        private void pbComprobante_Click(object sender, EventArgs e)
        {
            //detallesPedido[0] = idPedido
            if (detallesPedido != null)
            {
                Consulta.generarComprobante(detallesPedido[0], dgvDatosPDF, false);
                string usuario = lblUsuario.Text.ToString().Trim();
                string pedido = detallesPedido[0];
                string descripcionLog = "El usuario : " + usuario + " generó el comprobante de venta (PDF) del pedido: " + pedido + " el día: " + DateTime.Now.ToString();
                Consulta.Log(usuario, pedido, descripcionLog, "15");
            }

        }

        private void pbFactura_Click(object sender, EventArgs e)
        {
            if (detallesPedido != null)
            {
                Consulta.generarFactura(detallesPedido[0], dgvDatosPDF);
                string usuario = lblUsuario.Text.ToString().Trim();
                string pedido = detallesPedido[0];
                string descripcionLog = "El usuario : " + usuario + " generó la factura (PDF) del pedido: " + pedido + " el día: " + DateTime.Now.ToString();
                Consulta.Log(usuario, pedido, descripcionLog, "16");
            }
        }


        private void estadoPedidoColorCliente()
        {
            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                if (Boolean.Parse(row.Cells["Autorizado"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = _colorAceptados;

                    row.Cells["dataGridViewAceptarPedido"].Value = "Revisado";

                }
                else
                {

                    row.DefaultCellStyle.BackColor = _colorPendiente;
                    row.Cells["dataGridViewAceptarPedido"].Value = "En Revisión";
                }
            }
        }

        private void estadoPedidoColorEmpleado()
        {
            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                if (Boolean.Parse(row.Cells["Autorizado"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = _colorAceptados;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = _colorPendiente;
                }
            }
        }

        private void inicializarDgvCliente(string usuario)
        {
            Consulta.inicioClientePedidos(dgvPedido, usuario);
            dgvPedido.Columns["# Pedido"].Visible = true;
            dgvPedido.Columns["Usuario"].Visible = false;
            dgvPedido.Columns["Nombre"].Visible = false;
            dgvPedido.Columns["Autorizado"].Visible = false;
            dgvPedido.Columns["impuesto"].Visible = false;
            dgvPedido.Columns["total"].Visible = false;
            dgvPedido.Columns["comentarios"].Visible = false;
            dgvPedido.Columns["iddetalle_pedido"].Visible = false;

            estadoPedidoColorCliente();
        }


        private void inicializarDgvEmpleado(string usuario)
        {
            Consulta.inicioPedidosEmpleados(dgvPedido, usuario);
            dgvPedido.Columns["# Pedido"].Visible = true;
            dgvPedido.Columns["Usuario"].Visible = false;
            dgvPedido.Columns["Nombre"].Visible = false;
            dgvPedido.Columns["Autorizado"].Visible = false;
            dgvPedido.Columns["impuesto"].Visible = false;
            dgvPedido.Columns["total"].Visible = false;
            dgvPedido.Columns["comentarios"].Visible = false;
            dgvPedido.Columns["iddetalle_pedido"].Visible = false;

            estadoPedidoColorEmpleado();

        }


        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            string Fecha_inicio = dtpFin.Value.Year.ToString() + "-" + dtpFin.Value.Month.ToString() + "-" + dtpFin.Value.Day.ToString();
            string Fecha_Final = dtpFin.Value.Year.ToString() + "-" + dtpFin.Value.Month.ToString() + "-" + dtpFin.Value.Day.ToString();

            if (lblRol.Text == "4")
            {
                Consulta.filtroFechaCliente(dgvPedido, Fecha_inicio, Fecha_Final, lblUsuario.Text);
                estadoPedidoColorCliente();
            }
            else if (lblRol.Text == "2")
            {


                Consulta.filtroFechaEmpleado(dgvPedido, Fecha_inicio, Fecha_Final, lblUsuario.Text);
                estadoPedidoColorEmpleado();

            }
            else { }

        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            string Fecha_inicio = dtpFin.Value.Year.ToString() + "-" + dtpFin.Value.Month.ToString() + "-" + dtpFin.Value.Day.ToString();
            string Fecha_Final = dtpFin.Value.Year.ToString() + "-" + dtpFin.Value.Month.ToString() + "-" + dtpFin.Value.Day.ToString();

            if (lblRol.Text == "4")
            {
                Consulta.filtroFechaCliente(dgvPedido, Fecha_inicio, Fecha_Final, lblUsuario.Text);
                estadoPedidoColorCliente();
            }
            else if (lblRol.Text == "2")
            {


                Consulta.filtroFechaEmpleado(dgvPedido, Fecha_inicio, Fecha_Final, lblUsuario.Text);
                estadoPedidoColorEmpleado();

            }
            else { }
        }


        private void txtFiltroPedido_KeyUp(object sender, KeyEventArgs e)
        {

            if (lblRol.Text == "4")
            {
                if (txtFiltroPedido.Text.Trim() == string.Empty)
                {
                    inicializarDgvCliente(lblUsuario.Text);
                }
                else
                {
                    Consulta.filtroPedidoCliente(dgvPedido, txtFiltroPedido.Text.Trim(), lblUsuario.Text.Trim());
                    estadoPedidoColorCliente();
                }



            }
            else if (lblRol.Text == "2")
            {
                if (txtFiltroPedido.Text.Trim() == string.Empty)
                {
                    inicializarDgvEmpleado(lblUsuario.Text);
                }
                else
                {
                    Consulta.filtroPedidoEmpleado(dgvPedido, txtFiltroPedido.Text.Trim(), lblUsuario.Text);
                    estadoPedidoColorEmpleado();
                }
            }
            else { }
        }

        private void txtFiltroCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (lblRol.Text == "4")
            {

            }
            else if (lblRol.Text == "2")
            {
                if (txtFiltroCliente.Text.Trim() == string.Empty)
                {
                    inicializarDgvEmpleado(lblUsuario.Text);
                }
                else
                {
                    Consulta.filtroNombreClienteEmpleado(dgvPedido, txtFiltroCliente.Text.Trim(), lblUsuario.Text);
                    estadoPedidoColorEmpleado();
                }
            }
            else { }
        }

        private void txtFiltroUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (lblRol.Text == "4")
            {

            }
            else if (lblRol.Text == "2")
            {
                if (txtFiltroUsuario.Text.Trim() == string.Empty)
                {
                    inicializarDgvEmpleado(lblUsuario.Text);
                }
                else
                {
                    Consulta.filtroNombreUsuarioEmpleado(dgvPedido, txtFiltroUsuario.Text.Trim(), lblUsuario.Text);
                    estadoPedidoColorEmpleado();
                }
            }
            else { }
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

        private void tab1_Click(object sender, EventArgs e)
        {
            tabControlDetallesPedido.SelectedTab = tabPage1;
        }

        private void tab2_Click(object sender, EventArgs e)
        {
            tabControlDetallesPedido.SelectedTab = tabPage2;
        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrar administrar = new();
            administrar.lblRolF.Text = lblRol.Text;
            administrar.lblUsuarioF.Text = lblUsuario.Text;
            administrar.ShowDialog();
        }

        private void crearUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearUsuario crearUsuario = new();
            crearUsuario.lblUsuarioLog.Text = lblUsuario.Text;
            crearUsuario.ShowDialog();
        }

        private void modificarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarUsuario modificarUsuario = new();
            modificarUsuario.lblUsuarioLog.Text = lblUsuario.Text;
            modificarUsuario.ShowDialog();
        }

        private void generarReporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteVentas reporteVentas = new();
            reporteVentas.lblUsuario.Text = lblUsuario.Text;
            reporteVentas.ShowDialog();
        }

        private void logCambiosSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log log = new();
            log.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltroPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.soloNumerosDecimales(sender, e);
        }

        private void txtFiltroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.soloLetras(sender, e);
        }
    }
}



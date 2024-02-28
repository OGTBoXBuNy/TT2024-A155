//using DocumentFormat.OpenXml.Drawing.Charts;
using iText.Kernel.Geom;
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
    public partial class Pedido : MaterialForm
    {


        BD Consulta = new BD();
        private DataTable dt;
        double descuento = 0;
        double precioVenta = 0;
        double precioVentaDescuento = 0;
        int cantidad = 0;
        double subTotal = 0;
        double total = 0;
        int indexCMBCliente = -1;
        int actualizar = 0;

        public Pedido(int x)
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
            // X-->  0 = CREAR PEIDO,,,, 1 = ACTUALIZAR
            actualizar = x;

        }



        private void registrarDatosFiscales(string usuario, string nombre, string cif, string calle, string colonia, string noExt, string noInt, string CP, string ciudad, string telefono, string correo)
        {
            int tieneDatosFiscales = Consulta.validarDatosFiscalesCliente(cmbCliente.Text.Trim());// 0 = no tiene,,,,, 1 = YA TIENE DATOS FISCALES REGISTRADOS

            if (tieneDatosFiscales == 0)
            {
                Consulta.registrarDatosFiscalesCliente(usuario, nombre, cif, calle, colonia, noExt, noInt, CP, ciudad, telefono, correo);
            }
            else if (tieneDatosFiscales == 1)
            {
                Consulta.actualizarDatosFiscalesCliente(usuario, nombre, cif, calle, colonia, noExt, noInt, CP, ciudad, telefono, correo);
            }
        }

        private void registrarPedido()
        {
            string fechaCreacion = DateTime.Today.ToString("d");// FECHA_HORA
            string idVendedor = string.Empty;
            string idCliente = cmbCliente.SelectedValue.ToString();//ID USUARIO CLIENTE
            string comentarios = txtComentarios.Text.Trim();//COMENTARIOS
            string cantidad;
            string idProducto;
            string idVehiculo;
            string precioVenta;
            string descuento;
            int idPedido = -1;



            if (lblRol.Text.Trim() != "4")// 4 = CLIENTE,,, 1,2,3 = VENDEDOR U OTRO
                idVendedor = Consulta.idUsuario(lblUsuario.Text.ToString().Trim()).ToString();

            Consulta.registrarPedido(idVendedor, idCliente, fechaCreacion, subTotal.ToString("0.##"), total.ToString("0.##"), comentarios);//REGISTRAR PEDIDO

            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                cantidad = row.Cells["Cantidad"].Value.ToString();
                idProducto = row.Cells["idProducto"].Value.ToString();
                precioVenta = row.Cells["Precio de venta\n($)"].Value.ToString();
                descuento = row.Cells["Descuento\n(%)"].Value.ToString();
                idVehiculo = row.Cells["idvehiculo"].Value.ToString();

                idPedido = Consulta.registrarDetallePedido(idProducto, cantidad, precioVenta, descuento, idVehiculo);

            }


            string usuario = cmbCliente.Text.Trim();
            string nombre = txtNombreCliFact.Text.Trim();
            string cif = txtCif.Text.Trim();
            string calle = txtCalle.Text.Trim();
            string colonia = txtCol.Text.Trim();
            string noExt = txtNoExt.Text.Trim();
            string noInt = txtNoInt.Text.Trim();
            string CP = txtCP.Text.Trim();
            string ciudad = txtCiudad.Text.Trim();
            string telefono = txtTel.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            registrarDatosFiscales(usuario, nombre, cif, calle, colonia, noExt, noInt, CP, ciudad, telefono, correo);

            if (idPedido != -1)
                Consulta.generarComprobante(idPedido.ToString(), dgvDatosPDF, true);

            if (lblRol.Text.Trim() != "4")
            {
                string vendedor = lblUsuario.Text.ToString().Trim();
                string pedido = Consulta.recuperarUltimoPedido();
                string descripcionLog = "El vendedor :  " + vendedor + " generó el pedido:" + pedido + " para el cliente: " + cmbCliente.Text.Trim() + " el día: " + DateTime.Now.ToString();
                Consulta.Log(vendedor, pedido, descripcionLog, "5");
            }
            else
            {
                string cliente = cmbCliente.Text.Trim();
                string pedido = Consulta.recuperarUltimoPedido();
                string descripcionLog = "El cliente :  " + cliente + " generó el pedido: " + pedido + " el día: " + DateTime.Now.ToString();
                Consulta.Log(cliente, pedido, descripcionLog, "5");
            }


        }

        private void actualizarPedido()
        {

            string comentarios = txtComentarios.Text.Trim();//COMENTARIOS
            string cantidad;
            string idProducto;
            string idVehiculo;
            string precioVenta;
            string descuento;
            string iddetalle_pedido;
            string idPedido = lblIdPedido.Text;

            int idPedidoPDF = -1;





            //Consulta.actualizarPedido();//ACTUALIZAR PEDIDO

            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                if (row.Cells["iddetalle_pedido"].Value.ToString() == "")
                {
                    cantidad = row.Cells["Cantidad"].Value.ToString();
                    idProducto = row.Cells["idProducto"].Value.ToString();
                    precioVenta = row.Cells["Precio de venta\n($)"].Value.ToString();
                    descuento = row.Cells["Descuento\n(%)"].Value.ToString();
                    idVehiculo = row.Cells["idvehiculo"].Value.ToString();
                    iddetalle_pedido = row.Cells["iddetalle_pedido"].Value.ToString();

                    Consulta.registrarDetallePedidoActualizar(idProducto, cantidad, precioVenta, descuento, idVehiculo, idPedido, comentarios, subTotal.ToString("0.##"), total.ToString("0.##"));
                }
                else
                {
                    cantidad = row.Cells["Cantidad"].Value.ToString();
                    idProducto = row.Cells["idProducto"].Value.ToString();
                    precioVenta = row.Cells["Precio de venta\n($)"].Value.ToString();
                    descuento = row.Cells["Descuento\n(%)"].Value.ToString();
                    idVehiculo = row.Cells["idvehiculo"].Value.ToString();
                    iddetalle_pedido = row.Cells["iddetalle_pedido"].Value.ToString();

                    Consulta.actualizarDatosPedido(idVehiculo, cantidad, descuento, iddetalle_pedido, comentarios, idPedido, subTotal.ToString("0.##"), total.ToString("0.##"));
                }




                //idPedido = Consulta.registrarDetallePedido(idProducto, cantidad, precioVenta, descuento, idVehiculo);

            }


            string usuario = cmbCliente.Text.Trim();
            string nombre = txtNombreCliFact.Text.Trim();
            string cif = txtCif.Text.Trim();
            string calle = txtCalle.Text.Trim();
            string colonia = txtCol.Text.Trim();
            string noExt = txtNoExt.Text.Trim();
            string noInt = txtNoInt.Text.Trim();
            string CP = txtCP.Text.Trim();
            string ciudad = txtCiudad.Text.Trim();
            string telefono = txtTel.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            //registrarDatosFiscales(usuario, nombre, cif, calle, colonia, noExt, noInt, CP, ciudad, telefono, correo);

            if (idPedidoPDF != -1)
                Consulta.generarComprobante(idPedido.ToString(), dgvDatosPDF, true);

            string vendedor = lblUsuario.Text.ToString().Trim();
            string descripcionLog = "El vendedor :  " + vendedor + " actualizó el pedido:" + idPedido + " para el cliente: " + cmbCliente.Text.Trim() + " el día: " + DateTime.Now.ToString();
            Consulta.Log(vendedor, idPedido, descripcionLog, "8");

        }




        private void Pedido_Load(object sender, EventArgs e)
        {


            lblSubtotal.Text = "SubTotal: $ " + subTotal.ToString();
            lblTotal.Text = "Total + IVA(16%): $ " + total.ToString();

            var editButton = new DataGridViewButtonColumn();
            editButton.Name = "dataGridViewEditButton";
            editButton.HeaderText = "Editar";
            editButton.Text = "Editar";
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.CellTemplate.Style.BackColor = Color.DarkCyan;
            editButton.UseColumnTextForButtonValue = true;
            this.dgvPedido.Columns.Add(editButton);


            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Eliminar";
            deleteButton.Text = "Eliminar";
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.CellTemplate.Style.BackColor = Color.Red;
            deleteButton.UseColumnTextForButtonValue = true;
            this.dgvPedido.Columns.Add(deleteButton);

            dt = new DataTable();
            dt.Columns.Add("Producto");
            dt.Columns.Add("Vehiculo");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Clave de producto");
            dt.Columns.Add("Descripción");
            dt.Columns.Add("Precio de venta\n($)");
            dt.Columns.Add("Descuento\n(%)");

            dt.Columns.Add("idProducto");
            dt.Columns.Add("idvehiculo");


            //dt.Columns.Add("costo_proveedor\n($)");
            dgvPedido.DataSource = dt;
            dgvPedido.Columns["idProducto"].Visible = false;
            dgvPedido.Columns["idvehiculo"].Visible = false;
            dgvPedido.Columns["dataGridViewEditButton"].Visible = false;


            //Carga los datos registros de clientes en el combobox
            cmbCliente.DataSource = Consulta.ClientesRegistrados().Tables[0].DefaultView;
            cmbCliente.ValueMember = "idusuario";
            cmbCliente.DisplayMember = "nombre_usuario";


            //SI ES CLIENTE EL CMB DE CLIENTE SE BLOQUEA Y SELECCIONA EL DEL CLIENTE

            indexCMBCliente = cmbCliente.FindString(lblUsuario.Text);
            if (indexCMBCliente != -1)
            {
                cmbCliente.SelectedIndex = indexCMBCliente;
                cmbCliente.Enabled = false;
            }


            //----------ACTUALIZAR--------///
            if (actualizar == 1)
            {

                Consulta.datosPedidoActualizar(dgvPedido, dt, lblIdPedido.Text);
                dgvPedido.Columns["Comentarios"].Visible = false;
                dgvPedido.Columns["fecha_hora"].Visible = false;
                dgvPedido.Columns["idusuarioVendedor"].Visible = false;
                dgvPedido.Columns["iddetalle_pedido"].Visible = false;
                dgvPedido.Columns["dataGridViewEditButton"].Visible = true;

                txtComentarios.Text = dgvPedido.Rows[0].Cells[11].Value.ToString();
                lblFechaCreacion.Visible = true;
                lblFechaCreacion.Text = "Fecha Creación: " + dgvPedido.Rows[0].Cells[12].Value.ToString().Substring(0, 10);


                indexCMBCliente = cmbCliente.FindString(Consulta.nombreCliente(lblIdPedido.Text));
                if (indexCMBCliente != -1)
                {
                    cmbCliente.SelectedIndex = indexCMBCliente;
                    cmbCliente.Enabled = false;
                }

            }

        }



        public void actualizarTotales()
        {
            subTotal = 0;
            total = 0;


            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
                descuento = Convert.ToDouble(row.Cells["Descuento\n(%)"].Value.ToString()) / 100;
                precioVenta = Convert.ToDouble(row.Cells["Precio de venta\n($)"].Value.ToString());
                precioVentaDescuento = precioVenta - (precioVenta * descuento);

                subTotal += (precioVentaDescuento * 0.84) * cantidad;
                total += precioVentaDescuento * cantidad;


            }
            lblSubtotal.Text = "SubTotal: $ " + subTotal.ToString("0.##");
            lblTotal.Text = "Total + IVA(16%): $ " + total.ToString("0.##");
        }


        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreCliFact.Text = string.Empty;
            txtCif.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtCol.Text = string.Empty;
            txtNoExt.Text = string.Empty;
            txtNoInt.Text = string.Empty;
            txtCP.Text = string.Empty;
            txtCiudad.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            lblNombreCliente.Text = "Nombre: " + Consulta.recuperarNombreReal(cmbCliente.Text.Trim());

            int tieneDatosFiscales = Consulta.validarDatosFiscalesCliente(cmbCliente.Text.Trim());// 0 = no tiene,,,,, 1 = YA TIENE DATOS FISCALES REGISTRADOS

            if (tieneDatosFiscales == 1)
            {
                string[] datosFiscalesCliente = Consulta.datosFiscalesCliente(cmbCliente.Text);
                txtNombreCliFact.Text = datosFiscalesCliente[0];
                txtCif.Text = datosFiscalesCliente[1];
                txtCalle.Text = datosFiscalesCliente[2];
                txtCol.Text = datosFiscalesCliente[3];
                txtNoExt.Text = datosFiscalesCliente[4];
                txtNoInt.Text = datosFiscalesCliente[5];
                txtCP.Text = datosFiscalesCliente[6];
                txtCiudad.Text = datosFiscalesCliente[7];
                txtTel.Text = datosFiscalesCliente[8];
                txtCorreo.Text = datosFiscalesCliente[9];
            }



        }

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                //if click is on new row or header row
                if (e.RowIndex == dgvPedido.NewRowIndex || e.RowIndex < 0)
                    return;


                //Check if click is on specific column
                if (e.ColumnIndex == dgvPedido.Columns["dataGridViewDeleteButton"].Index)
                {

                    MessageBOX mes = new MessageBOX(4, "¿Esta seguro de eliminar esta pieza?");

                    if (actualizar == 0)
                    {
                        if (mes.ShowDialog() == DialogResult.OK)
                        {
                            dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
                            actualizarTotales();//Actualizar SubTotal y Totales
                        }
                    }
                    else if (actualizar == 1)
                    {
                        if (mes.ShowDialog() == DialogResult.OK)
                        {
                            Consulta.eliminarProductoPedido(dgvPedido.Rows[e.RowIndex].Cells[14].Value.ToString());
                            dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
                            actualizarTotales();//Actualizar SubTotal y Totales

                            string usuario = lblUsuario.Text.ToString().Trim();
                            string pedido = lblIdPedido.Text;
                            string descripcionLog = "El usuario :  " + usuario + " eliminó un producto al pedido:" + pedido + " para el cliente: " + cmbCliente.Text.Trim() + " el día: " + DateTime.Now.ToString();
                            Consulta.Log(usuario, pedido, descripcionLog, "10");
                        }
                    }
                    else { }
                }
                else if (e.ColumnIndex == dgvPedido.Columns["dataGridViewEditButton"].Index)
                {

                    string iddetallepedido = dgvPedido.Rows[e.RowIndex].Cells[14].Value.ToString();
                    int index = dgvPedido.CurrentCell.RowIndex;

                    Producto producto = new Producto(1, iddetallepedido);
                    DialogResult respuesta = producto.ShowDialog();
                    if (respuesta == DialogResult.OK)
                    {

                        double descuento = Convert.ToDouble(producto.datosMandar[4]) / 100;
                        double precioVenta = Convert.ToDouble(producto.datosMandar[3]);

                        int cantidad = Convert.ToInt32(producto.datosMandar[1]);


                        dgvPedido["Producto", index].Value = producto.datosMandar[0];//PRODUCTO
                        dgvPedido["Vehiculo", index].Value = producto.datosMandar[8] + "-" + producto.datosMandar[9] + "-" + producto.datosMandar[10]; //CARRO
                        dgvPedido["Cantidad", index].Value = cantidad;//CANTIDAD
                        dgvPedido["Clave de producto", index].Value = producto.datosMandar[2];//CLAVE PRODUCTO
                        dgvPedido["Descripción", index].Value = producto.datosMandar[5];//DESCRIPCION
                        dgvPedido["Precio de venta\n($)", index].Value = precioVenta;//PRECIO VENTA
                        dgvPedido["Descuento\n(%)", index].Value = producto.datosMandar[4];//DESCUENTO
                        dgvPedido["idProducto", index].Value = producto.datosMandar[11];//IDPRODUCTO
                        dgvPedido["idvehiculo", index].Value = producto.datosMandar[12];//IDVEHICULO
                        actualizarTotales();//Actualizar SubTotal y Totales

                        string usuario = lblUsuario.Text.ToString().Trim();
                        string pedido = lblIdPedido.Text;
                        string descripcionLog = "El usuario :  " + usuario + " editó un producto al pedido:" + pedido + " para el cliente: " + cmbCliente.Text.Trim() + " el día: " + DateTime.Now.ToString();
                        Consulta.Log(usuario, pedido, descripcionLog, "9");

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(0, string.Empty);
            DialogResult respuesta = producto.ShowDialog();
            if (respuesta == DialogResult.OK)
            {

                double descuento = Convert.ToDouble(producto.datosMandar[4]) / 100;
                double precioVenta = Convert.ToDouble(producto.datosMandar[3]);

                int cantidad = Convert.ToInt32(producto.datosMandar[1]);

                DataRow row = dt.NewRow();
                row[0] = producto.datosMandar[0];//PRODUCTO
                row[1] = producto.datosMandar[8] + "-" + producto.datosMandar[9] + "-" + producto.datosMandar[10]; //CARRO
                row[2] = cantidad;//CANTIDAD
                row[3] = producto.datosMandar[2];//CLAVE PRODUCTO
                row[4] = producto.datosMandar[5];//DESCRIPCION
                row[5] = precioVenta;//PRECIO VENTA
                row[6] = producto.datosMandar[4];//DESCUENTO

                row[7] = producto.datosMandar[11];//IDPRODUCTO
                row[8] = producto.datosMandar[12];//IDVEHICULO
                dt.Rows.Add(row);

                actualizarTotales();//Actualizar SubTotal y Totales

                if (lblIdPedido.Text != "IDPedido")
                {
                    string usuario = lblUsuario.Text.ToString().Trim();
                    string pedido = lblIdPedido.Text;
                    string descripcionLog = "El usuario :  " + usuario + " añadió un producto al pedido:" + pedido + " para el cliente: " + cmbCliente.Text.Trim() + " el día: " + DateTime.Now.ToString();
                    Consulta.Log(usuario, pedido, descripcionLog, "6");
                }

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (actualizar == 0)
            {

                registrarPedido();
                this.DialogResult = DialogResult.OK;
                this.Close();
                //Consulta.generarVale();
            }
            else if (actualizar == 1)
            {
                actualizarPedido();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else { }
        }
    }
}

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
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }
        Producto producto = new Producto();
        BD Consulta = new BD();
        private DataTable dt;
        double descuento = 0;
        double precioVenta = 0;
        double precioVentaDescuento = 0;
        int cantidad = 0;
        double subTotal = 0;
        double total = 0;

        private void registrarPedido()
        {
            string fechaCreacion = DateTime.Today.ToString("d");// FECHA_HORA
            string idVendedor = string.Empty;
            string idCliente = cmbCliente.SelectedValue.ToString();//ID USUARIO CLIENTE
            string comentarios = txtComentarios.Text.Trim();//COMENTARIOS
            string cantidad = string.Empty;
            string idProducto = string.Empty;
            string idVehiculo = string.Empty;
            string precioVenta = string.Empty;
            string descuento = string.Empty;
            int idPedido = -1;

            Consulta.registrarPedido(string.Empty, idCliente, fechaCreacion, subTotal.ToString("0.##"), total.ToString("0.##"), comentarios);//REGISTRAR PEDIDO

            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                cantidad = row.Cells["Cantidad"].Value.ToString();
                idProducto = row.Cells["idProducto"].Value.ToString();
                precioVenta = row.Cells["Precio de venta\n($)"].Value.ToString();
                descuento = row.Cells["Descuento\n(%)"].Value.ToString();
                idVehiculo = row.Cells["idvehiculo"].Value.ToString();

                 idPedido =  Consulta.registrarDetallePedido(idProducto,cantidad,precioVenta,descuento,idVehiculo);

            }

            if (idPedido != -1)
                Consulta.generarComprobante(idPedido.ToString(), dgvDatosPDF);

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            registrarPedido();
            //Consulta.generarVale();

        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            lblSubtotal.Text = "SubTotal: " + subTotal.ToString();
            lblTotal.Text = "Total + IVA(16%): " + total.ToString();



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


            //Carga los datos registros de clientes en el combobox
            cmbCliente.DataSource = Consulta.ClientesRegistrados().Tables[0].DefaultView;
            cmbCliente.ValueMember = "idusuario";
            cmbCliente.DisplayMember = "nombre_usuario";


        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            
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
            lblSubtotal.Text = "SubTotal: " + subTotal.ToString("0.##");
            lblTotal.Text = "Total + IVA(16%): " + total.ToString("0.##");
        }


        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNombreCliente.Text = "Nombre: " + Consulta.recuperarNombreReal(cmbCliente.Text.Trim());

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

                    if (mes.ShowDialog() == DialogResult.OK)
                    {
                        dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
                        actualizarTotales();//Actualizar SubTotal y Totales
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

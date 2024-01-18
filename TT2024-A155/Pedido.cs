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
        double subTotal = 0;
        double total = 0;

        private void registrarPedido()
        {
            string fechaCreacion = DateTime.Today.ToString("d");// FECHA_HORA
            string idVendedor = string.Empty;
            string idCliente = cmbCliente.SelectedValue.ToString();//ID USUARIO CLIENTE
            string comentarios = txtComentarios.Text.Trim();





        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            
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
            
            //dt.Columns.Add("costo_proveedor\n($)");
            dgvPedido.DataSource = dt;


            //Carga los datos registros de clientes en el combobox
            cmbCliente.DataSource = Consulta.ClientesRegistrados().Tables[0].DefaultView;
            cmbCliente.ValueMember = "idusuario";
            cmbCliente.DisplayMember = "nombre_usuario";


        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            //int cantidad = 0;
            //double totalPrecio = 0;
            DialogResult respuesta = producto.ShowDialog();
            if (respuesta == DialogResult.OK)
            {

                double descuento = Convert.ToDouble(producto.datosMandar[4]) / 100;
                double precioVenta = Convert.ToDouble(producto.datosMandar[3]);
                double precioVentaDescuento = precioVenta - (precioVenta * descuento);
                int cantidad = Convert.ToInt32(producto.datosMandar[1]);

                DataRow row = dt.NewRow();
                row[0] = producto.datosMandar[0];//PRODUCTO
                row[1] = producto.datosMandar[8] + "-" + producto.datosMandar[9] + "-" + producto.datosMandar[10]; //CARRO
                row[2] = cantidad;//CANTIDAD
                row[3] = producto.datosMandar[2];//CLAVE PRODUCTO
                row[4] = producto.datosMandar[5];//DESCRIPCION
                row[5] = precioVenta;//PRECIO VENTA
                row[6] = producto.datosMandar[4];//DESCUENTO
                dt.Rows.Add(row);

                

                subTotal +=  (precioVentaDescuento * 0.84) * cantidad;
                lblSubtotal.Text = "SubTotal: " + subTotal.ToString("0.##");

                total += precioVentaDescuento * cantidad;
                lblTotal.Text = "Total + IVA(16%): " + total.ToString("0.##");

                //Es utilizado para que por defecto el combobox del dgv tenga seleccionada una opción
                //dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells["dataGridViewStatusCombobox"].Value = 1;
                ///>>>>>>>>>>>>>>>>>>>>>----IMPORTANTE------:
                ///El tipo de dato al que se iguala tiene mucho que coincidir con el "ValueMember"
                ///de la columna combobox del datagridview, en este caso funciona porque se ha
                ///seleccionado toda la tabla desde la consulta y coincide el tipo con el id


                //foreach (DataGridViewRow dgvRow in dgvPedido.Rows)
                //{
                //    cantidad += Convert.ToInt32(dgvRow.Cells["Cantidad"].Value);
                //    //subtotalPrecio += (Convert.ToInt32(dgvRow.Cells["Cantidad"].Value) * Convert.ToDouble(dgvRow.Cells["Precio de venta"].Value) /*+ Convert.ToDouble(dgvRow.Cells["Precio de reparación"].Value)*/);
                //    totalPrecio += Convert.ToDouble(dgvRow.Cells["Precio de venta\n($)"].Value);
                //}
                //totalPrecio = (subtotalPrecio * .16) + subtotalPrecio;

                //lblCantidadTotal.Text = cantidad.ToString();
                //lblPrecioTotal.Text = "$" + totalPrecio.ToString();
            }
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNombreCliente.Text = "Nombre: " + Consulta.recuperarNombreReal(cmbCliente.Text.Trim());
            
        }
    }
}

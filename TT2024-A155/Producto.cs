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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }
        BD Consulta = new BD();
        DataSet ds = new DataSet();
        DataView dv = new DataView();
        internal string[] datosProducto = new string[13];
        private void Producto_Load(object sender, EventArgs e)
        {
            //Carga los datos de las marcas de vehículos en el combobox
            cmbMarca.DataSource = Consulta.MarcasRegistradas(1).Tables[0].DefaultView;
            cmbMarca.ValueMember = "marca";
            //cmbMarca.ValueMember = "cve_marca";
            //cmbMarca.DisplayMember = "marca";


            ds = Consulta.Productos();
            dv = ds.Tables[0].DefaultView;
            cmbProducto.DataSource = dv;
            cmbProducto.ValueMember = "nombre";
            
        }




        /// <summary>
        /// Gets the datosMandar.
        /// </summary>
        public string[] datosMandar
        {
            get
            {
                return datosProducto;
            }
            /*
                        producto[0] = Lector["nombre"].ToString(); 
                        //producto[1] = Lector[""].ToString();CANTIDAD
                        producto[2] = Lector["codigo"].ToString(); 
                        producto[3] = Lector["precio_venta"].ToString(); 
                        //producto[4] = Lector[""].ToString(); DESCUENTO
                        producto[5] = Lector["descripcion"].ToString();
                        producto[6] = Lector["stock"].ToString();
                        producto[7] = Lector["costo_proveedor"].ToString();
                        datosProducto[8] = cmbMarca.Text.Trim(); //MARCA
                        datosProducto[9] = cmbModelo.Text.Trim(); //MODELO
                        datosProducto[10] = txtAnio.Text.Trim(); //ANIO
                        producto[11] = Lector["idproducto"].ToString();//IDPRODUCTO
                        datosProducto[12] = cmbModelo.SelectedValue.ToString();//IDVEHICULO
             */
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            datosProducto[1] = cmbCantidad.Text.Trim();//CANTIDAD
            datosProducto[4] = txtDescuento.Text.Trim();//DESCUENTO
            datosProducto[8] = cmbMarca.Text.Trim(); //MARCA
            datosProducto[9] = cmbModelo.Text.Trim(); //MODELO
            datosProducto[10] = cmbAnio.Text.Trim(); //ANIO
            datosProducto[12] = Consulta.idVehiculoProducto(cmbMarca.Text.Trim(), cmbModelo.Text.Trim(), cmbAnio.Text.Trim());//IDVEHICULO

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

            datosProducto = Consulta.datosProducto(cmbProducto.Text);
            //precio venta
            if (datosProducto[3] != null)
                txtPrecioVenta.Text = datosProducto[3].ToString();
            if (datosProducto[6] != null)
                lblDisponible.Text = "Disponible: " + datosProducto[6].ToString();
                

            cmbCantidad.Items.Clear();
            for (int i = 0; i < Convert.ToInt32(datosProducto[6]); i++)
            {
                cmbCantidad.Items.Add(i + 1);
            }
           
        }

        private void cmbProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmbProducto.DroppedDown = false;
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carga los datos de los modelos de vehículos en el combobox
            //cmbModelo.DataSource = Consulta.VehiculosRegistrados(cmbMarca.Text.Trim()).Tables[0].DefaultView;
            //cmbModelo.ValueMember = "idvehiculo";
            //cmbModelo.DisplayMember = "modelo";
            
            cmbModelo.DataSource = Consulta.modelosRegistrados(cmbMarca.Text.Trim()).Tables[0].DefaultView;
            cmbModelo.ValueMember = "modelo";
            cmbModelo.DisplayMember = "modelo";
            
            if (cmbModelo.Items.Count == 0)
            {
                cmbModelo.Text = "";
            }

        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAnio.DataSource = Consulta.modelosRegistrados(cmbMarca.Text.Trim(),cmbModelo.Text.Trim()).Tables[0].DefaultView;
            cmbAnio.ValueMember = "anio";
            cmbAnio.DisplayMember = "anio";

            if(cmbAnio.Items.Count == 0)
            {
                cmbAnio.Text = "";
            }
        }
    }
}

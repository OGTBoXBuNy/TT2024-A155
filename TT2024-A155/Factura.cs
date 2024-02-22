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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }
        BD Consulta = new();
        private void Factura_Load(object sender, EventArgs e)
        {
            Consulta.datosFacturaPDF(dgvDatosFactura, lblIDPedido.Text);

            txtFacturaSinIVA.Text = dgvDatosFactura.Rows[1].Cells[5].Value.ToString();
            txtFactIVA.Text = dgvDatosFactura.Rows[1].Cells[6].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string idPedido = lblIDPedido.Text;
            string num_factura = txtNumeroFactura.Text.Trim();
            string fact_sinIVA = txtFacturaSinIVA.Text.Trim();
            string descuento = txtDescuento.Text.Trim();
            string fact_neto = txtFactIVA.Text.Trim();
            string fecha_emision = dtpFechEmision.Value.Year.ToString() + "-" + dtpFechEmision.Value.Month.ToString() + "-" + dtpFechEmision.Value.Day.ToString();
            string comentarios = txtComentarios.Text.Trim();
            string iddatos_fiscales_emp = dgvDatosFactura.Rows[1].Cells[0].Value.ToString();
            string iddatos_fiscales_cliente = dgvDatosFactura.Rows[1].Cells[4].Value.ToString();

            //Consulta.generarFactura("1", dgvDatosFactura);
            Consulta.registrarFactura(idPedido, iddatos_fiscales_emp, iddatos_fiscales_cliente, num_factura, fecha_emision, fact_sinIVA, descuento, fact_neto, comentarios, dgvDatosFactura);

            string usuario = lblUsuario.Text.ToString().Trim();
            string descripcionLog = "El usuario : " + usuario + " generó la factura de venta (PDF) del pedido: " + idPedido + " el día: " + DateTime.Now.ToString();
            Consulta.Log(usuario, idPedido, descripcionLog, "11");
        }

        private void btnpubKey_Click(object sender, EventArgs e)
        {

        }

        private void btnprivKey_Click(object sender, EventArgs e)
        {

        }
    }
}

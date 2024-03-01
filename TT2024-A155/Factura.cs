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
    public partial class Factura : MaterialForm
    {
        public Factura()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
        }
        BD Consulta = new();
        Validaciones Validaciones = new();
        private void Factura_Load(object sender, EventArgs e)
        {
            Consulta.datosFacturaPDF(dgvDatosFactura, lblIDPedido.Text);

            txtFacturaSinIVA.Text = dgvDatosFactura.Rows[0].Cells[5].Value.ToString();
            txtFactIVA.Text = dgvDatosFactura.Rows[0].Cells[6].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //-----------VALIDACION-----------------//
            bool validacion = true;
            errorNumeroFact.Clear();
            errorFactSinIva.Clear();
            errorDescuento.Clear();
            errorFactConIva.Clear();
            errorLlavePublica.Clear();
            errorLlavePrivada.Clear();

            if (string.IsNullOrEmpty(txtNumeroFactura.Text.Trim())) { errorNumeroFact.SetError(txtNumeroFactura, "Campo obligatorio"); validacion = false; }
            if (string.IsNullOrEmpty(txtFacturaSinIVA.Text.Trim())) { errorFactSinIva.SetError(txtFacturaSinIVA, "Campo obligatorio"); validacion = false; }

            if (string.IsNullOrEmpty(txtDescuento.Text.Trim())) { errorDescuento.SetError(txtDescuento, "Campo obligatorio"); validacion = false; }
            if (string.IsNullOrEmpty(txtFactIVA.Text.Trim())) { errorFactConIva.SetError(txtFactIVA, "Campo obligatorio"); validacion = false; }

            //if (string.IsNullOrEmpty(txtpubKey.Text.Trim())) { errorLlavePublica.SetError(txtpubKey, "Campo obligatorio"); validacion = false; }
            //if (string.IsNullOrEmpty(txtprivKey.Text.Trim())) { errorLlavePrivada.SetError(txtprivKey, "Campo obligatorio"); validacion = false; }

            //-----------------------------

            if (validacion)
            {
                string idPedido = lblIDPedido.Text;
                string num_factura = txtNumeroFactura.Text.Trim();
                string fact_sinIVA = txtFacturaSinIVA.Text.Trim();
                string descuento = txtDescuento.Text.Trim();
                string fact_neto = txtFactIVA.Text.Trim();
                string fecha_emision = dtpFechEmision.Value.Year.ToString() + "-" + dtpFechEmision.Value.Month.ToString() + "-" + dtpFechEmision.Value.Day.ToString();
                string comentarios = txtComentarios.Text.Trim();
                string iddatos_fiscales_emp = dgvDatosFactura.Rows[0].Cells[0].Value.ToString();
                string iddatos_fiscales_cliente = dgvDatosFactura.Rows[0].Cells[4].Value.ToString();

                //Consulta.generarFactura("1", dgvDatosFactura);
                Consulta.registrarFactura(idPedido, iddatos_fiscales_emp, iddatos_fiscales_cliente, num_factura, fecha_emision, fact_sinIVA, descuento, fact_neto, comentarios, dgvDatosFactura);

                string usuario = lblUsuario.Text.ToString().Trim();
                string descripcionLog = "El usuario : " + usuario + " generó la factura de venta (PDF) del pedido: " + idPedido + " el día: " + DateTime.Now.ToString();
                Consulta.Log(usuario, idPedido, descripcionLog, "11");
            }
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumerosDecimales(sender, e);
        }
    }
}

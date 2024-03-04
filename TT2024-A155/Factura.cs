extern alias NewBouncy;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Commons.Bouncycastle.Crypto;

//Diseño
using MaterialSkin.Controls;
using NewBouncy::Org.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;

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
        byte[] byteArray;
        DilithiumPrivateKeyParameters privateKey;

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
                Consulta.registrarFactura(idPedido, iddatos_fiscales_emp, iddatos_fiscales_cliente, num_factura, fecha_emision, fact_sinIVA, descuento, fact_neto, comentarios, dgvDatosFactura, privateKey);

                string usuario = lblUsuario.Text.ToString().Trim();
                string descripcionLog = "El usuario : " + usuario + " generó la factura de venta (PDF) del pedido: " + idPedido + " el día: " + DateTime.Now.ToString();
                Consulta.Log(usuario, idPedido, descripcionLog, "11");
            }
            this.Close();
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumerosDecimales(sender, e);
        }

        private void btnprivKey_Click(object sender, EventArgs e)
        {
            //configuraciones del openfiledialog 1
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = "C:\\";
            //openFile.Filter = " (*.*)|*.pdf*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtprivKey.Text = openFile.FileName;
                string fpath = @txtprivKey.Text;
                byteArray = File.ReadAllBytes(fpath);
                if (byteArray != null)
                    MessageBox.Show("Found private key");
            }

            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(openFile.FileName);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                string[] tempPrivateKeyParameters = new string[7];//Para guardar Ro, K, Tr, S1, S2, T0, T1
                int i = 0;
                while (line != null)
                {
                    tempPrivateKeyParameters[i] = line;
                    //write the line to console window
                    MessageBox.Show("Llave privada base 64 desde txt: " + line);
                    //Read the next line
                    line = sr.ReadLine();
                    //
                    i++;
                }
                //close the file
                sr.Close();


                //Recuperando la cadena se bytes de la llave publica base64
                byte[] Rho = System.Convert.FromBase64String(tempPrivateKeyParameters[0]);
                byte[] K = System.Convert.FromBase64String(tempPrivateKeyParameters[1]);
                byte[] TR = System.Convert.FromBase64String(tempPrivateKeyParameters[2]);
                byte[] S1 = System.Convert.FromBase64String(tempPrivateKeyParameters[3]);
                byte[] S2 = System.Convert.FromBase64String(tempPrivateKeyParameters[4]);
                byte[] T0 = System.Convert.FromBase64String(tempPrivateKeyParameters[5]);
                byte[] T1 = System.Convert.FromBase64String(tempPrivateKeyParameters[6]);
                //byte[] bytes = System.Convert.FromBase64String(tempPrivateKeyParameters[7]);
                privateKey = new DilithiumPrivateKeyParameters(DilithiumParameters.Dilithium3, Rho, K, TR, S1, S2, T0, T1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
                
            }
        }
    }
}

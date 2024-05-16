extern alias NewBouncy;

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
using NewBouncy::Org.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
//LECTOR QR
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using ZXing.QrCode;
using ZXing.QrCode.Internal;
using DocumentFormat.OpenXml.Drawing;

namespace TT2024_A155
{
    public partial class verificarFactura : MaterialForm
    {
        byte[] byteArray;
        byte[] signature;
        DilithiumPublicKeyParameters publicKey;
        BD Consulta = new();
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        string[] datos;

        public verificarFactura()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
        }

        private void verificarFactura_Load(object sender, EventArgs e)
        {
            //Carga los datos de las facturas en el combobox
            cmbFactura.DataSource = Consulta.facturas().Tables[0].DefaultView;
            cmbFactura.ValueMember = "idfactura";
            cmbFactura.DisplayMember = "num_factura";


            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in CaptureDevice)
            {
                cmbDispositivos.Items.Add(device.Name);
            }

            cmbDispositivos.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();


            //CARGANDO LA LLAVE PUBLICA DEL USUARIO DE FINANZAS

            //byte[] bytes = System.Convert.FromBase64String(Consulta.obtenerPKFinanzas());
            //publicKey = new DilithiumPublicKeyParameters(DilithiumParameters.Dilithium3, bytes);
            //MessageBox.Show("Llave publica en bytes longitud: " + bytes.Length + "Cadena original:" + Consulta.PrettyPrint(bytes));

        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            //configuraciones del openfiledialog 1
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //openFile.Filter = " (*.*)|*.pdf*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtRutaArchivo.Text = openFile.FileName;
                string fpath = @txtRutaArchivo.Text;
                byteArray = File.ReadAllBytes(fpath);
                if (byteArray != null)
                    MessageBox.Show("Archivo Encontrado");

                limpiar();
            }
        }

        private void btnBuscarLlavePub_Click(object sender, EventArgs e)
        {
            //configuraciones del openfiledialog 1
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //openFile.Filter = " (*.*)|*.pdf*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtRutaLlavePublica.Text = openFile.FileName;
                string fpath = txtRutaLlavePublica.Text;
                byteArray = File.ReadAllBytes(fpath);
                if (byteArray != null)
                    MessageBox.Show("Llave pública encontrada");
                limpiar();
            }

            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(openFile.FileName);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                String temp = "";
                while (line != null)
                {
                    temp += line;
                    //write the line to console window
                    Console.WriteLine(line);
                    //MessageBox.Show("Llave publica base 64 desde txt: " + line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();


                //Recuperando la cadena se bytes de la llave publica base64

                byte[] bytes = System.Convert.FromBase64String(temp);
                publicKey = new DilithiumPublicKeyParameters(DilithiumParameters.Dilithium3, bytes);
                MessageBox.Show("Llave publica en bytes longitud: " + bytes.Length + "Cadena original:" + Consulta.PrettyPrint(bytes));
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

        private void verificar(string idFactura)
        {
            datos = Consulta.datosVerificarFactura(idFactura);//[0] IDPEDIDO, [1] FIRMA

            //Recuperando la cadena se bytes de la signature  base64

            signature = System.Convert.FromBase64String(datos[1]);
            //part 6
            // verify signature
            var bob = new DilithiumSigner();
            bob.Init(false, publicKey);

            string fpath = txtRutaArchivo.Text;
            byteArray = File.ReadAllBytes(fpath);
            //var data = Hex.Encode(byteArray);


            var verified = bob.VerifySignature(byteArray, signature);

            if (verified == true)
            {

                txtDatosProveedor.Visible = true;
                txtFirma.Visible = true;
                Consulta.datosFacturaPDF(dgvFactura, datos[0]);
                double impuestos = double.Parse(dgvFactura.Rows[0].Cells[6].Value.ToString()) - double.Parse(dgvFactura.Rows[0].Cells[5].Value.ToString());
                lblNumeroFact.Text = "Número de Factura: " + dgvFactura.Rows[0].Cells[1].Value.ToString();
                txtDatosCliente.Text = dgvFactura.Rows[0].Cells[7].Value.ToString() + " \r\n" + dgvFactura.Rows[0].Cells[8].Value.ToString() + " " + dgvFactura.Rows[0].Cells[9].Value.ToString() + " " +
                           dgvFactura.Rows[0].Cells[10].Value.ToString() + " \r\n" + dgvFactura.Rows[0].Cells[11].Value.ToString() + " " +
                    dgvFactura.Rows[0].Cells[12].Value.ToString() + " " + dgvFactura.Rows[0].Cells[13].Value.ToString() + " \r\n" + "Cel: " + dgvFactura.Rows[0].Cells[14].Value.ToString() + " " + dgvFactura.Rows[0].Cells[15].Value.ToString()
                    + " \r\n" + "R.F.C.: " + dgvFactura.Rows[0].Cells[16].Value.ToString();

                txtComentario.Text = dgvFactura.Rows[0].Cells[3].Value.ToString();
                lblfechaEmision.Text = "Fecha Emisión: " + dgvFactura.Rows[0].Cells[2].Value.ToString().Substring(0, 10);
                lblSubTotal.Text = "SubTotal: $ " + dgvFactura.Rows[0].Cells[5].Value.ToString();
                lblImpuestos.Text = "Impuestos: $ " + impuestos.ToString("0.##");
                lblTotal.Text = "Total: $ " + dgvFactura.Rows[0].Cells[6].Value.ToString();
                txtFirma.Text = dgvFactura.Rows[0].Cells[25].Value.ToString();

                dgvFactura.Columns[0].Visible = false;//Datos fiscales empresa
                dgvFactura.Columns[1].Visible = false;//numero de factura
                dgvFactura.Columns[2].Visible = false;//fecha emision
                dgvFactura.Columns[3].Visible = false;//comentario
                dgvFactura.Columns[4].Visible = false;//iddatos fiscales cliente
                dgvFactura.Columns[5].Visible = false;//subtotal - impuestos
                dgvFactura.Columns[6].Visible = false;//total
                dgvFactura.Columns[7].Visible = false;//nombre cliente
                dgvFactura.Columns[8].Visible = false;//calle
                dgvFactura.Columns[9].Visible = false;//no Ext
                dgvFactura.Columns[10].Visible = false;//no Int
                dgvFactura.Columns[11].Visible = false;//colonia
                dgvFactura.Columns[12].Visible = false;//cp
                dgvFactura.Columns[13].Visible = false;//ciudad
                dgvFactura.Columns[14].Visible = false;//telefono
                dgvFactura.Columns[15].Visible = false;//correo
                dgvFactura.Columns[16].Visible = false;//cif
                dgvFactura.Columns[25].Visible = false;//Firma

                dgvFactura.Columns[17].HeaderText = "Producto";//
                dgvFactura.Columns[18].HeaderText = "Marca";//
                dgvFactura.Columns[19].HeaderText = "Modelo";//
                dgvFactura.Columns[20].HeaderText = "Año";//
                dgvFactura.Columns[21].HeaderText = "Cantidad";//
                dgvFactura.Columns[22].HeaderText = "Precio Venta\r\n($)";//
                dgvFactura.Columns[23].HeaderText = "Descuento\r\n(%)";//
                dgvFactura.Columns[24].HeaderText = "Total x Cantidad\r\n($)";//

                MessageBOX.SHowDialog(3, "Excelente pudimos validar correctamente el archivo");
            }
            else
            {
                MessageBOX.SHowDialog(2, "Parece que el archivo a sufrido algun tipo de cambio");
            }


        }

        private void verificarQr(string idFactura)
        {
            datos = Consulta.datosVerificarFactura(idFactura);//[0] IDPEDIDO, [1] FIRMA

            txtDatosProveedor.Visible = true;
            txtFirma.Visible = true;
            Consulta.datosFacturaPDF(dgvFactura, datos[0]);
            double impuestos = double.Parse(dgvFactura.Rows[0].Cells[6].Value.ToString()) - double.Parse(dgvFactura.Rows[0].Cells[5].Value.ToString());
            lblNumeroFact.Text = "Número de Factura: " + dgvFactura.Rows[0].Cells[1].Value.ToString();
            txtDatosCliente.Text = dgvFactura.Rows[0].Cells[7].Value.ToString() + " \r\n" + dgvFactura.Rows[0].Cells[8].Value.ToString() + " " + dgvFactura.Rows[0].Cells[9].Value.ToString() + " " +
                           dgvFactura.Rows[0].Cells[10].Value.ToString() + " \r\n" + dgvFactura.Rows[0].Cells[11].Value.ToString() + " " +
                    dgvFactura.Rows[0].Cells[12].Value.ToString() + " " + dgvFactura.Rows[0].Cells[13].Value.ToString() + " \r\n" + "Cel: " + dgvFactura.Rows[0].Cells[14].Value.ToString() + " " + dgvFactura.Rows[0].Cells[15].Value.ToString()
                    + " \r\n" + "R.F.C.: " + dgvFactura.Rows[0].Cells[16].Value.ToString();

            txtComentario.Text = dgvFactura.Rows[0].Cells[3].Value.ToString();
            lblfechaEmision.Text = "Fecha Emisión: " + dgvFactura.Rows[0].Cells[2].Value.ToString().Substring(0, 10);
            lblSubTotal.Text = "SubTotal: $ " + dgvFactura.Rows[0].Cells[5].Value.ToString();
            lblImpuestos.Text = "Impuestos: $ " + impuestos.ToString("0.##");
            lblTotal.Text = "Total: $ " + dgvFactura.Rows[0].Cells[6].Value.ToString();
            txtFirma.Text = dgvFactura.Rows[0].Cells[25].Value.ToString();

            dgvFactura.Columns[0].Visible = false;//Datos fiscales empresa
            dgvFactura.Columns[1].Visible = false;//numero de factura
            dgvFactura.Columns[2].Visible = false;//fecha emision
            dgvFactura.Columns[3].Visible = false;//comentario
            dgvFactura.Columns[4].Visible = false;//iddatos fiscales cliente
            dgvFactura.Columns[5].Visible = false;//subtotal - impuestos
            dgvFactura.Columns[6].Visible = false;//total
            dgvFactura.Columns[7].Visible = false;//nombre cliente
            dgvFactura.Columns[8].Visible = false;//calle
            dgvFactura.Columns[9].Visible = false;//no Ext
            dgvFactura.Columns[10].Visible = false;//no Int
            dgvFactura.Columns[11].Visible = false;//colonia
            dgvFactura.Columns[12].Visible = false;//cp
            dgvFactura.Columns[13].Visible = false;//ciudad
            dgvFactura.Columns[14].Visible = false;//telefono
            dgvFactura.Columns[15].Visible = false;//correo
            dgvFactura.Columns[16].Visible = false;//cif
            dgvFactura.Columns[25].Visible = false;//Firma

            dgvFactura.Columns[17].HeaderText = "Producto";//
            dgvFactura.Columns[18].HeaderText = "Marca";//
            dgvFactura.Columns[19].HeaderText = "Modelo";//
            dgvFactura.Columns[20].HeaderText = "Año";//
            dgvFactura.Columns[21].HeaderText = "Cantidad";//
            dgvFactura.Columns[22].HeaderText = "Precio Venta\r\n($)";//
            dgvFactura.Columns[23].HeaderText = "Descuento\r\n(%)";//
            dgvFactura.Columns[24].HeaderText = "Total x Cantidad\r\n($)";//

            MessageBOX.SHowDialog(3, "Estos son los datos que deberías visualizar en la factura");

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //-----------VALIDACION-----------------//
            bool validacion = true;
            errorLlavePublica.Clear();
            errorRutaArchivo.Clear();
            errorFactura.Clear();

            //if (string.IsNullOrEmpty(txtRutaLlavePublica.Text.Trim())) { errorLlavePublica.SetError(txtRutaLlavePublica, "Campo obligatorio"); validacion = false; }
            if (string.IsNullOrEmpty(txtRutaArchivo.Text.Trim())) { errorRutaArchivo.SetError(txtRutaArchivo, "Campo obligatorio"); validacion = false; }
            if (string.IsNullOrEmpty(cmbFactura.Text.Trim())) { errorFactura.SetError(cmbFactura, "Campo obligatorio"); validacion = false; }
            //-----------------------------
            if (validacion)
            {
                verificar(cmbFactura.SelectedValue.ToString());
            }

        }

        private void rbtnArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnArchivo.Checked)
            {
                btnBuscarArchivo.Enabled = true;
                btnBuscarLlavePub.Enabled = true;
                btnVerificar.Enabled = true;
                cmbFactura.Enabled = true;
                limpiar(); txtRutaArchivo.Text = ""; txtRutaLlavePublica.Text = "";
            }
            else
            {
                btnBuscarArchivo.Enabled = false;
                btnBuscarLlavePub.Enabled = false;
                btnVerificar.Enabled = false;
                cmbFactura.Enabled = false;
            }
        }

        private void rbtnQr_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnQr.Checked)
            {
                lblCamara.Visible = true;
                cmbDispositivos.Visible = true;
                pbLectorQr.Visible = true;
                txtLecturaQr.Visible = true;
                btnComenzar.Visible = true;
                btnLeer.Visible = true;
                limpiar(); txtRutaArchivo.Text = ""; txtRutaLlavePublica.Text = "";
            }
            else
            {
                lblCamara.Visible = false;
                cmbDispositivos.Visible = false;
                pbLectorQr.Visible = false;
                txtLecturaQr.Visible = false;
                btnComenzar.Visible = false;
                btnLeer.Visible = false;
            }
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmbDispositivos.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();

        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbLectorQr.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void verificarFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (FinalFrame.IsRunning)
            //    FinalFrame.Stop();
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            var reader = new ZXing.Windows.Compatibility.BarcodeReader();
            Result result = reader.Decode((Bitmap)pbLectorQr.Image);
            string decoded;

            if (result != null)
            {
                try
                {
                    decoded = result.ToString().Trim();
                    if (decoded != "")
                    {
                        txtLecturaQr.Text = decoded;
                        verificarQr(Consulta.idFactura(decoded));
                        temporizador.Stop();
                        //FinalFrame.Stop();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            temporizador.Start();
        }

        private void limpiar()
        {
            lblNumeroFact.Text = "Número de Factura:";
            txtDatosCliente.Text = "";
            txtComentario.Text = "";
            lblfechaEmision.Text = "Fecha Emisión:";
            lblSubTotal.Text = "SubTotal:";
            lblImpuestos.Text = "Impuestos:";
            lblTotal.Text = "Total:";
            txtDatosProveedor.Visible = false;
            dgvFactura.DataSource = null;
            dgvFactura.Rows.Clear();

        }

        private void cmbFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //CARGANDO LA LLAVE PUBLICA DEL USUARIO DE FINANZAS SEGUN LA FACTURA SELECIONADA
                string pk = Consulta.obtenerPkNumFactura(cmbFactura.Text.Trim());


                if (pk != "")
                {
                    byte[] bytes = System.Convert.FromBase64String(pk);
                    publicKey = new DilithiumPublicKeyParameters(DilithiumParameters.Dilithium3, bytes);
                    MessageBox.Show("Llave publica en bytes longitud: " + bytes.Length + "Cadena original:" + Consulta.PrettyPrint(bytes));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }



        }

        private void btnVerificar_ClientSizeChanged(object sender, EventArgs e)
        {

        }
    }
}

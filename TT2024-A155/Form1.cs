extern alias NewBouncy;

using NewBouncy::Org.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;
using NewBouncy::Org.BouncyCastle.Security;
using iText.Commons.Bouncycastle.Crypto;
using System.Security.Cryptography.X509Certificates;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf.Canvas;
using System.Windows.Forms;
using NewBouncy::Org.BouncyCastle.Pqc.Crypto.Utilities;
using Org.BouncyCastle.Crypto;
using iText.Kernel.Pdf;
using DocumentFormat.OpenXml.Spreadsheet;


namespace TT2024_A155
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[] byteArray;
        static DilithiumPublicKeyParameters publicKey;
        static DilithiumPrivateKeyParameters privateKey;
        static byte[] signature;
        byte[] privateKeyParameters = new byte[7];//Para guardar Ro, K, Tr, S1, S2, T0, T1
        static string PrettyPrint(byte[] bytes)
        {
            var base64 = Convert.ToBase64String(bytes);
            //if (base64.Length > 50)
            //return $"{base64[..25]}...{base64[^25..]}";

            return base64;
        }

        private void btnSign_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            //part 5
            // sign
            string path = @txtRuta.Text;
            byte[] bytes = File.ReadAllBytes(path);
            var alice = new DilithiumSigner();
            //DilithiumPrivateKeyParameters tempPrivKey = new DilithiumPrivateKeyParameters(DilithiumParameters.Dilithium3, privateKey.Rho, privateKey.K, privateKey.Tr, privateKey.S1, privateKey.S2, privateKey.T0, privateKey.T1);
            //alice.Init(true, tempPrivKey);
            alice.Init(true, privateKey);
            signature = alice.GenerateSignature(bytes);

            path = @"C:\Users\boxbu\Downloads\Dilithium\signature.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(PrettyPrint(signature));
                }
            }

            MessageBox.Show($"Signature: {PrettyPrint(signature)}");
        }

        private void btnGenLlaves_Click(object sender, EventArgs e)
        {
            //part 2

            var random = new SecureRandom();//GENERADOR DE NUMERO ALEATORIOS
            var keyGenParameters = new DilithiumKeyGenerationParameters(random, DilithiumParameters.Dilithium3); //AES  128 bits
            //part 3
            var dilithiumKeyPairGenerator = new DilithiumKeyPairGenerator();
            dilithiumKeyPairGenerator.Init(keyGenParameters);
            var keyPair = dilithiumKeyPairGenerator.GenerateKeyPair();//Se obtiene la calve publica y privada


           

            //part 4
            // get and view the keys
            //var publicKey = (DilithiumPublicKeyParameters)keyPair.Public;//CER 
            //var privateKey = (DilithiumPrivateKeyParameters)keyPair.Private;//KEY 
            publicKey = (DilithiumPublicKeyParameters)keyPair.Public;//CER 
            privateKey = (DilithiumPrivateKeyParameters)keyPair.Private;//KEY 
            //privateKey.Rho, privateKey.K, privateKey.Tr, privateKey.S1, privateKey.S2, privateKey.T0, privateKey.T1
            byte[] Rho = privateKey.Rho;
            byte[] K = privateKey.K;
            byte[] TR = privateKey.Tr;
            byte[] S1 = privateKey.S1;
            byte[] S2 = privateKey.S2;
            byte[] T0 = privateKey.T0;
            byte[] T1 = privateKey.T1;
            
            var pubEncoded = publicKey.GetEncoded();
            var privateEncoded = privateKey.GetEncoded();
            string path = @"C:\Users\boxbu\Downloads\Dilithium\pubKey.txt";

            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(PrettyPrint(pubEncoded));
            }

            MessageBox.Show($"Public key: {PrettyPrint(pubEncoded)}");
            path = @"C:\Users\boxbu\Downloads\Dilithium\privKey.txt";

            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(PrettyPrint(Rho));
                sw.WriteLine(PrettyPrint(K));
                sw.WriteLine(PrettyPrint(TR));
                sw.WriteLine(PrettyPrint(S1));
                sw.WriteLine(PrettyPrint(S2));
                sw.WriteLine(PrettyPrint(T0));
                sw.WriteLine(PrettyPrint(T1));
            }

            MessageBox.Show($"Private key: {PrettyPrint(privateEncoded)}");
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            string ruta = Application.StartupPath + "\\VALE JEIC.pdf";
            File.WriteAllBytes(ruta, Properties.Resources.Comprobante);

            fileRoute.InitialDirectory = @"C:\";
            fileRoute.Title = "PEDIDO";
            fileRoute.CheckPathExists = true;
            fileRoute.DefaultExt = "pdf";
            fileRoute.Filter = "PDF files (*.pdf)|*.pdf";
            fileRoute.FilterIndex = 2;
            fileRoute.RestoreDirectory = true;
            fileRoute.FileName = "TEST PDF";
            if (fileRoute.ShowDialog() == DialogResult.OK)
            {

                if (File.Exists(fileRoute.FileName))
                {
                    iText.Kernel.Pdf.PdfWriter pdfWriter = new iText.Kernel.Pdf.PdfWriter(fileRoute.FileName);


                    iText.Kernel.Pdf.PdfReader pdfReader = new iText.Kernel.Pdf.PdfReader(Application.StartupPath + "\\VALE JEIC.pdf");


                    iText.Kernel.Pdf.PdfDocument pdfdoc = new iText.Kernel.Pdf.PdfDocument(pdfReader, pdfWriter);





                    for (int i = 0; i < 3; i++)
                    {
                        PdfCanvas canvas = new PdfCanvas(pdfdoc.GetPage(i + 1));
                        iText.Kernel.Font.PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                        int y = 633;
                        int x = 109;
                        int Items = 0;




                        //HORA DE CREACIÓN DEL VALE
                        canvas.BeginText().SetFontAndSize(font, 10)
                                .MoveText(x - 77, y - 63)
                                .SetFillColor(ColorConstants.RED)
                                .ShowText("Creado: " + DateTime.Now.ToString())
                                .EndText();



                        //NUMERO DE ITEMS
                        canvas.BeginText().SetFontAndSize(font, 9)
                                    .MoveText(x - 16, 96)
                                    .ShowText((Items + 1).ToString())
                                    .EndText();
                    }
                    pdfdoc.Close();
                    MessageBox.Show("Exitoso");


                }
                else
                {
                    iText.Kernel.Pdf.PdfWriter pdfWriter = new iText.Kernel.Pdf.PdfWriter(fileRoute.FileName);

                    iText.Kernel.Pdf.PdfReader pdfReader = new iText.Kernel.Pdf.PdfReader(Application.StartupPath + "\\VALE JEIC.pdf");

                    iText.Kernel.Pdf.PdfDocument pdfdoc = new iText.Kernel.Pdf.PdfDocument(pdfReader, pdfWriter);



                    int NumeroFila = 4;

                    for (int i = 0; i < 3; i++)
                    {
                        PdfCanvas canvas = new PdfCanvas(pdfdoc.GetPage(i + 1));
                        iText.Kernel.Font.PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                        int y = 633;
                        int x = 109;
                        int Items = 0;

                        //HORA DE CREACIÓN DEL VALE
                        canvas.BeginText().SetFontAndSize(font, 10)
                                .MoveText(x - 77, y - 63)
                                .SetFillColor(ColorConstants.RED)
                                .ShowText("Creado: " + DateTime.Now.ToString())
                                .EndText();



                        //NUMERO DE ITEMS
                        canvas.BeginText().SetFontAndSize(font, 9)
                                    .MoveText(x - 16, 96)
                                    .ShowText((Items + 1).ToString())
                                    .EndText();
                    }
                    pdfdoc.Close();
                    MessageBox.Show("Exitoso");


                }



            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                String path = @"C:\Users\boxbu\Downloads\Dilithium\signature.txt";
                StreamReader sr = new StreamReader(path);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                String temp = "";
                while (line != null)
                {
                    temp += line;
                    //write the line to console window
                    Console.WriteLine(line);
                    MessageBox.Show("La signature base 64 desde txt: " + line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();


                //Recuperando la cadena se bytes de la signature  base64

                signature = System.Convert.FromBase64String(temp);


                //MessageBox.Show("La signature en bytes longitud: " + signature.Length + "Cadena original:" + PrettyPrint(signature));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }


            //part 6
            // verify signature
            var bob = new DilithiumSigner();
            bob.Init(false, publicKey);

            string fpath = @txtRuta.Text;
            byteArray = File.ReadAllBytes(fpath);
            //var data = Hex.Encode(byteArray);


            var verified = bob.VerifySignature(byteArray, signature);
            MessageBox.Show($"Successfully verified? {verified}");

        }

        private void btnpubKey_Click(object sender, EventArgs e)
        {
            //configuraciones del openfiledialog 1
            openFile.InitialDirectory = "C:\\Users\\boxbu\\Downloads\\Dilithium";
            //openFile.Filter = " (*.*)|*.pdf*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtpubKey.Text = openFile.FileName;
                string fpath = @txtpubKey.Text;
                byteArray = File.ReadAllBytes(fpath);
                if (byteArray != null)
                    MessageBox.Show("found public key");
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
                MessageBox.Show("Llave publica en bytes longitud: " + bytes.Length + "Cadena original:" + PrettyPrint(bytes));
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

        private void btnprivKey_Click(object sender, EventArgs e)
        {
            //configuraciones del openfiledialog 1
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

                MessageBox.Show("Llave privada en bytes longitud: " + Rho.Length + "Cadena original:" + PrettyPrint(Rho));
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //configuraciones del openfiledialog 1
            openFile.InitialDirectory = "C:\\Users\\boxbu\\Downloads\\Dilithium";
            //openFile.Filter = " (*.*)|*.pdf*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                iText.Kernel.Pdf.PdfReader pdfReader = new iText.Kernel.Pdf.PdfReader(openFile.FileName);
                iText.Kernel.Pdf.PdfDocument pdfdoc = new iText.Kernel.Pdf.PdfDocument(pdfReader);
                
                iText.Kernel.Pdf.PdfDocumentInfo info = pdfdoc.GetDocumentInfo();
                string hash = info.GetMoreInfo("TEST");
                MessageBox.Show(hash);
                ////txtRuta.Text = openFile.FileName;
                ////string fpath = @txtRuta.Text;
                ////byteArray = File.ReadAllBytes(fpath);
                ////if (byteArray != null)
                ////    MessageBox.Show("found file");
            }
        }
    }
}





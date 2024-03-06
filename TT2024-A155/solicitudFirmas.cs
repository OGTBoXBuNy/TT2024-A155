extern alias NewBouncy;

using NewBouncy::Org.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;
using NewBouncy::Org.BouncyCastle.Security;
//Diseño
using MaterialSkin.Controls;


namespace TT2024_A155
{
    public partial class solicitudFirmas : MaterialForm
    {
        public solicitudFirmas()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
        }

        
        private DilithiumPublicKeyParameters publicKey;
        private DilithiumPrivateKeyParameters privateKey;
        private byte[] signature;
        byte[] privateKeyParameters = new byte[7];//Para guardar Ro, K, Tr, S1, S2, T0, T1
        BD Consulta = new();
        AES aesBD = new AES();
        Validaciones Validaciones = new Validaciones();

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            //-----------VALIDACION-----------------//
            bool validacion = true;
            errorContrasenia.Clear();

            if (!Validaciones.contrasenaSegura(txtContrasenia.Text.Trim())) { errorContrasenia.SetError(txtContrasenia, "Campo obligatorio y cumplir con: Números, Letras, Carácter especial y longitud mayor o igual a 8"); validacion = false; }

            //----------------------------------------//

            if (validacion)
            {
                //part 2
                var random = new SecureRandom();//GENERADOR DE NUMERO ALEATORIOS
                var keyGenParameters = new DilithiumKeyGenerationParameters(random, DilithiumParameters.Dilithium3); //AES  128 bits


                //part 3
                var dilithiumKeyPairGenerator = new DilithiumKeyPairGenerator();
                dilithiumKeyPairGenerator.Init(keyGenParameters);
                var keyPair = dilithiumKeyPairGenerator.GenerateKeyPair();//Se obtiene la calve publica y privada

                //part 4
                // get and view the 
                publicKey = (DilithiumPublicKeyParameters)keyPair.Public;//CER 
                privateKey = (DilithiumPrivateKeyParameters)keyPair.Private;//KEY 
                                                                            //privateKey.Rho, privateKey.K, privateKey.Tr, privateKey.S1, privateKey.S2, privateKey.T0, privateKey.T1

                SaveFileDialog fileRoutePrivada = new SaveFileDialog();
                fileRoutePrivada.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                fileRoutePrivada.Title = "LLAVE PRIVADA";
                fileRoutePrivada.CheckPathExists = true;
                fileRoutePrivada.DefaultExt = "txt";
                //fileRoute.Filter = "PDF files (*.pdf)|*.pdf";
                //fileRoute.FilterIndex = 2;
                fileRoutePrivada.RestoreDirectory = true;
                fileRoutePrivada.FileName = "Llave privada";



                if (fileRoutePrivada.ShowDialog() == DialogResult.OK)
                {
                    if (!File.Exists(fileRoutePrivada.FileName))
                    {

                        byte[] Rho = privateKey.Rho;
                        byte[] K = privateKey.K;
                        byte[] TR = privateKey.Tr;
                        byte[] S1 = privateKey.S1;
                        byte[] S2 = privateKey.S2;
                        byte[] T0 = privateKey.T0;
                        byte[] T1 = privateKey.T1;


                        var privateEncoded = privateKey.GetEncoded();
                        string path = fileRoutePrivada.FileName;
                        //path = @"C:\Users\boxbu\Downloads\Dilithium\privKey.txt";

                        // Create a file to write to.
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine(Consulta.PrettyPrint(Rho));
                            sw.WriteLine(Consulta.PrettyPrint(K));
                            sw.WriteLine(Consulta.PrettyPrint(TR));
                            sw.WriteLine(Consulta.PrettyPrint(S1));
                            sw.WriteLine(Consulta.PrettyPrint(S2));
                            sw.WriteLine(Consulta.PrettyPrint(T0));
                            sw.WriteLine(Consulta.PrettyPrint(T1));
                        }
                        //TESTING
                        string[] lines = File.ReadAllLines(path);
                        string plainText = string.Join("\n", lines);
                        File.Delete(path);

                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.Write(aesBD.Encrypt(plainText, txtContrasenia.Text.Trim()));
                        }

                        //END TESTING//

                        MessageBox.Show($"Llave privada cifrada: {Consulta.PrettyPrint(privateEncoded)}");
                    }
                }

                SaveFileDialog fileRoutePublica = new SaveFileDialog();
                fileRoutePublica.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                fileRoutePublica.Title = "LLAVE PUBLICA";
                fileRoutePublica.CheckPathExists = true;
                fileRoutePublica.DefaultExt = "txt";
                //fileRoutePublica.Filter = "PDF files (*.pdf)|*.pdf";
                //fileRoutePublica.FilterIndex = 2;
                fileRoutePublica.RestoreDirectory = true;
                fileRoutePublica.FileName = "Llave pública";

                if (fileRoutePublica.ShowDialog() == DialogResult.OK)
                {
                    if (!File.Exists(fileRoutePublica.FileName))
                    {
                        var pubEncoded = publicKey.GetEncoded();
                        string path = fileRoutePublica.FileName;
                        // Create a file to write to.
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine(Consulta.PrettyPrint(pubEncoded));
                        }

                        MessageBox.Show($"Public key: {Consulta.PrettyPrint(pubEncoded)}");

                        Consulta.firmaSolicitada(lblUsuario.Text.Trim());

                        Inicio inicio = new Inicio();
                        inicio.lblUsuario.Text = lblUsuario.Text;
                        inicio.lblRol.Text = lblRol.Text;
                        inicio.Show();
                        this.Close();

                    }
                }
            }
            

            
        }
    }
}

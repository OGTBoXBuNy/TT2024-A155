using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//librerias para envio correo
using MimeKit;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
//CONTRASENIA SEGURO
using BC = BCrypt.Net.BCrypt;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf.Canvas;
//PDF
using iText.IO.Font.Constants;
using BarcodeLib;



namespace TT2024_A155
{
    internal class BD
    {
        //VARIABLES
        private SqlCommand Comando;

        private SqlDataReader Lector;
        private DataTable dt;
        private SqlDataAdapter da;


        //----------------------------------INICIO DE SESION----------------------------------------------
        public int inicioSesion(string us, string contra)
        {
            int contador = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {

                    if (validarUsuario(us) == 1)
                    {
                        string contraHash = "";
                        this.Comando = new SqlCommand(string.Format("SELECT contrasenia FROM usuario WHERE nombre_usuario = '{0}'", us), nuevacon);
                        nuevacon.Open();
                        Lector = this.Comando.ExecuteReader();
                        if (Lector.Read())
                            contraHash = Lector["contrasenia"].ToString();
                        if (BC.Verify(contra, contraHash))
                            contador++;
                    }


                    nuevacon.Close();
                }
                return contador;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return contador;
            }

        }
        //----------------------------------VALIDAR USUARIO EXISTENTE----------------------------------------------
        public int validarUsuario(string us)
        {
            int contador = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    this.Comando = new SqlCommand(string.Format("SELECT * FROM usuario WHERE nombre_usuario = '{0}';", us), nuevacon);
                    nuevacon.Open();
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read()) { contador++; }
                    Lector.Close();
                    nuevacon.Close();
                }
                return contador;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return contador;
            }
        }

        //----------------------------------VALIDAR USUARIO EXISTENTE----------------------------------------------
        public int validarCorreoUsuario(string correo)
        {
            int contador = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    this.Comando = new SqlCommand(string.Format("SELECT * FROM usuario WHERE correo = '{0}';", correo), nuevacon);
                    nuevacon.Open();
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read()) { contador++; }
                    Lector.Close();
                    nuevacon.Close();
                }
                return contador;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return contador;
            }
        }


        //----------------------------------REGISTRAR USUARIO----------------------------------------------
        public int registroUsuario(string rol, string us, string nombre, string contra, string calle,
            string colonia, string noExt, string noInt, string cp, string ciudad, string telefono, string correo)
        {
            int contador = 0;
            int x = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    nuevacon.Open();

                    if (validarUsuario(us) == 0)
                    {
                        this.Comando = new SqlCommand(string.Format("SELECT idrol FROM ROL WHERE nombre = '{0}'", rol), nuevacon);
                        Lector = this.Comando.ExecuteReader();
                        while (Lector.Read()) { x = Int32.Parse(Lector["idrol"].ToString()); }
                        Lector.Close();
                        string contraHash = BC.HashPassword(contra);
                        this.Comando = new SqlCommand(string.Format("INSERT INTO usuario (idrol,nombre_usuario,nombre_real,contrasenia,calle,colonia,noExt,noInt,cp,ciudad,telefono,correo) VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}');", x, us, nombre, contraHash, calle, colonia, noExt, noInt, cp, ciudad, telefono, correo), nuevacon);
                        this.Comando.ExecuteNonQuery();
                        MessageBox.Show("Se registro correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe ese nombre de usuario");
                    }
                    nuevacon.Close();
                }
                return contador;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return contador;
            }
        }

        //----------------------------------GENERAR CONTRASENIA ALEATORIA----------------------------------------------
        public string contraAleatoia()
        {
            string contra = "";
            try
            {
                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var Charsarr = new char[8];
                var random = new Random();

                for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                contra = new String(Charsarr);
                return contra;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return contra;
        }

        //ENVIAR CORREO
        public void enviaCorreo(string destinatario, string contra)
        {


            {

                string senderNombre = "TT2024-A155";
                string senderCorreo = "correos-jeic@jeic.com.mx";
                string senderAppPass = "rdvwqnbybxxomypq";//xldsjobozxjsrmpk
                string responsableCorreoCopia = "";


                try
                {

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress(senderNombre, senderCorreo));

                    message.To.Add(new MailboxAddress("", destinatario));






                    ;
                    message.Subject = "Recuperar Acceso";


                    message.Body = new TextPart("plain")
                    {
                        Text = "Estimado(a) \r\nAcabamos de recibir la solicitud para recuperar la contraseña." +
                            "\r\n\r\n Tu contraseña temporal es: " +
                            "\r\n\r\n" + contra +
                            "\r\n\r\nIMPORTANTE:" +
                            "\r\nEste correo es informativo, favor no responder a esta dirección de correo, ya que no se encuentra habilitada para recibir mensajes.\r\n"
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, false);

                        // Note: only needed if the SMTP server requires authentication
                        client.Authenticate(senderCorreo, senderAppPass);

                        client.Send(message);
                        client.Disconnect(true);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }

        }

        //ENVIAR CORREO END


        //----------------------------------RECUPERAR CONTRASENIA----------------------------------------------
        public void recuperarContra(string dato)
        {

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    nuevacon.Open();
                    if (validarUsuario(dato) == 1)
                    {
                        string contra = contraAleatoia();
                        string contraHash = BC.HashPassword(contra);
                        string destinatario = "";
                        this.Comando = new SqlCommand(string.Format("UPDATE USUARIO SET contrasenia = '{0}', contrasenia_temp = 1 WHERE nombre_usuario = '{1}' OR correo = '{2}';", contraHash, dato, dato), nuevacon);
                        this.Comando.ExecuteNonQuery();

                        this.Comando = new SqlCommand(string.Format("SELECT correo FROM usuario WHERE nombre_usuario = '{0}' OR correo = '{1}';", dato, dato), nuevacon);
                        Lector = this.Comando.ExecuteReader();
                        while (Lector.Read()) { destinatario = Lector["correo"].ToString(); }
                        Lector.Close();

                        this.enviaCorreo(destinatario, contra);

                        MessageBox.Show("Favor de revisar su bandeja de entrada para recuperar su acceso");

                    }
                    else if (validarCorreoUsuario(dato) == 1)
                    {
                        string contra = contraAleatoia();
                        string contraHash = BC.HashPassword(contra);
                        string destinatario = "";
                        this.Comando = new SqlCommand(string.Format("UPDATE USUARIO SET contrasenia = '{0}', contrasenia_temp = 1 WHERE nombre_usuario = '{1}' OR correo = '{2}';", contraHash, dato, dato), nuevacon);
                        this.Comando.ExecuteNonQuery();

                        this.Comando = new SqlCommand(string.Format("SELECT correo FROM usuario WHERE nombre_usuario = '{0}' OR correo = '{1}';", dato, dato), nuevacon);
                        Lector = this.Comando.ExecuteReader();
                        while (Lector.Read()) { destinatario = Lector["correo"].ToString(); }
                        Lector.Close();

                        this.enviaCorreo(destinatario, contra);

                        MessageBox.Show("Favor de revisar su bandeja de entrada para recuperar su acceso");
                    }


                    nuevacon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        //----------------------------------ACTUALIZAR CONTRASENIA USUARIO----------------------------------------------
        public void actualizarUsuario(string us, string contra)
        {

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    nuevacon.Open();


                    string contraHash = BC.HashPassword(contra);
                    this.Comando = new SqlCommand(string.Format("UPDATE USUARIO SET contrasenia = '{0}', contrasenia_temp = 0 WHERE nombre_usuario = '{1}';", contraHash, us), nuevacon);
                    this.Comando.ExecuteNonQuery();



                    MessageBox.Show("Contraseña actualizada correctamente");




                    nuevacon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        //----------------------------------VALIDAR SI TIENE CONTRASENIA TEMPORAL----------------------------------------------
        public int validarContraTemp(string us)
        {
            int contador = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    bool x = false;
                    this.Comando = new SqlCommand(string.Format("SELECT contrasenia_temp FROM usuario WHERE nombre_usuario = '{0}';", us), nuevacon);
                    nuevacon.Open();
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read()) { x = Convert.ToBoolean(Lector["contrasenia_temp"].ToString()); }
                    Lector.Close();

                    if (x)
                    {
                        contador++;
                    }

                    nuevacon.Close();
                }
                return contador;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return contador;
            }
        }

        //OBTENER LA INFORMACI[ON DE LOS PRODUCTOS REGISTRADOS EN LA BASE DE DATOS PARA LLENAR EL CMB DE PRODUCTO
        //---------------- DATOS DE PIEZAS REGISTRADOS
        public DataSet Productos()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TOP 100 nombre, codigo FROM producto WHERE estado = 1 ORDER BY NEWID();", nuevaConexion);
                    dataAdapter.Fill(dataSet, "PRODUCTO");

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //OBETER EL PRECIO DEL PRODUCTO DE ACUERDO SU CODIGO
        public string[] datosProducto(string Nombre)
        {
            string[] producto = new string[11];

            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();

                    this.Comando = new SqlCommand(string.Format("SELECT codigo,nombre,precio_venta,costo_proveedor,stock,descripcion FROM producto WHERE nombre = '{0}' AND estado = 1;", Nombre), nuevaConexion);
                    Lector = this.Comando.ExecuteReader();
                    while (Lector.Read()) {
                        producto[0] = Lector["nombre"].ToString();
                        //producto[1] = Lector[""].ToString();CANTIDAD
                        producto[2] = Lector["codigo"].ToString();
                        producto[3] = Lector["precio_venta"].ToString();
                        //producto[4] = Lector[""].ToString(); DESCUENTO
                        producto[5] = Lector["descripcion"].ToString();
                        producto[6] = Lector["stock"].ToString();
                        producto[7] = Lector["costo_proveedor"].ToString();



                    }
                    Lector.Close();

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return producto;
        }

        //OBTENER LA INFORMACI[ON DE LOS ROLES REGISTRADOS EN LA BASE DE DATOS PARA LLENAR EL CMB DE ROL
        //---------------- DATOS DE ROLES REGISTRADOS
        public DataSet Roles()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre FROM rol WHERE estado = 1", nuevaConexion);
                    dataAdapter.Fill(dataSet, "ROL");

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }


        //---------------------------GENERAR CODIGO DE BARRAS PARA PDF--------------------
        public void generarEtiqueta(string idpedido, string iddetallePedido)
        {

            int valor = 31;
            try
            {
                using (Barcode etiqueta = new Barcode())
                {
                    etiqueta.IncludeLabel = false;
                    etiqueta.AlternateLabel = idpedido + "," + iddetallePedido;
                    etiqueta.LabelPosition = LabelPositions.BOTTOMCENTER;
                    etiqueta.LabelFont = new System.Drawing.Font(System.Drawing.FontFamily.GenericMonospace, 15, FontStyle.Regular);
                    var etiquetaImagen = etiqueta.Encode(((BarcodeLib.TYPE)valor), idpedido + "," + iddetallePedido, System.Drawing.Color.Black, System.Drawing.Color.White, 150, 17);


                    Bitmap titulo = ProyectoBarras.Utilidades.ConvertirBitmap.convertirTextoImagen("");
                    int width = Math.Max((false ? titulo.Width : 0), etiquetaImagen.Width);
                    int height = (false ? titulo.Height : 0) + etiquetaImagen.Height;

                    Bitmap img3 = new Bitmap(width, height);
                    Graphics g = Graphics.FromImage(img3);
                    if (false)
                        g.DrawImage(titulo, new Point(0, 0));

                    g.DrawImage(etiquetaImagen, new Point(0, (false ? titulo.Height : 0)));

                    img3.Save(Application.StartupPath + "\\temp.png", System.Drawing.Imaging.ImageFormat.Png);
                    img3.Dispose();

                    g.Dispose();
                    titulo.Dispose();
                    etiquetaImagen.Dispose();
                    //etiqueta.Dispose();

                    //MessageBox.Show("Etiqueta Generada!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrió un problema\nMayor Detalle:\n" + err.Message + "\n\n*Si muestra en ingles, proceda a traducirlo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        //------------------------OBETNER EL NUMERO DE FILAS DENTRO DE UN PEDIDO-------------------------------------------------------
        public int NumeroFilas(string idPedido)
        {
            int fila = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    Comando = new SqlCommand(string.Format("SELECT COUNT(p.cve_pieza) FROM PEDIDO p LEFT OUTER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta  LEFT OUTER JOIN PIEZA pi ON p.cve_pieza = pi.cve_pieza  LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_nombre = v.cve_cliente LEFT OUTER JOIN TALLER t ON t.cve_taller = ven.cve_taller LEFT OUTER JOIN ENTREGA e ON p.cve_entrega = e.cve_entrega LEFT OUTER JOIN SINIESTRO si ON si.cve_siniestro=ven.cve_siniestro LEFT OUTER JOIN VEHICULO veh ON veh.cve_vehiculo=si.cve_vehiculo where ven.cve_pedido='{0}'", idPedido), nuevacon);
                    nuevacon.Open();
                    Lector = Comando.ExecuteReader();

                    while (Lector.Read())
                    {
                        fila = Lector.GetInt32(0);
                    }
                    Lector.Close();
                    nuevacon.Close();
                    return fila;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return fila;
            }
        }

        //---------------------------LLENAR TABLA PARA DATOS DE MUESTRA PDF CODIGO DE BARRAS--------------------
        public void datosPedidoPDF(DataGridView dgv/*, string idPedido*/)
        {
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter("select TOP 1 p.idpedido, p.fecha_hora, p.idusuarioCliente, p.idusuarioVendedor, prod.nombre, detp.cantidad, prod.precio_venta, ma.marca, v.modelo, v.anio\r\nfrom pedido p \r\nLEFT OUTER JOIN usuario us ON us.idusuario = p.idusuarioCliente\r\nLEFT OUTER JOIN detalle_pedido detp ON detp.idpedido = p.idpedido\r\nLEFT OUTER JOIN vehiculo v ON v.idvehiculo = detp.idvehiculo\r\nLEFT OUTER JOIN marca ma ON ma.idmarca = v.idmarca\r\nLEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto\r\norder by p.idpedido\r\ndesc", nuevacon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                    nuevacon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //----------------------GENERAR PDF (VALE JEIC)
        public void generarVale()
        {
            try
            {
                SaveFileDialog fileRoute = new SaveFileDialog();
                fileRoute.InitialDirectory = @"C:\";
                fileRoute.Title = "PEDIDO";
                fileRoute.CheckPathExists = true;
                fileRoute.DefaultExt = "pdf";
                fileRoute.Filter = "PDF files (*.pdf)|*.pdf";
                fileRoute.FilterIndex = 2;
                fileRoute.RestoreDirectory = true;
                fileRoute.FileName = "Comprobante" + DateTime.Now.ToString();
                DataGridView dgvDatosPDF = new DataGridView(); ;
                if (fileRoute.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(fileRoute.FileName))
                    {
                        iText.Kernel.Pdf.PdfWriter pdfWriter = new iText.Kernel.Pdf.PdfWriter(fileRoute.FileName);

                        string ruta = Application.StartupPath + "\\Comprobante.pdf";
                        File.WriteAllBytes(ruta, Properties.Resources.Comprobante);


                        iText.Kernel.Pdf.PdfReader pdfReader = new iText.Kernel.Pdf.PdfReader(Application.StartupPath + "\\Comprobante.pdf");




                        iText.Kernel.Pdf.PdfDocument pdfdoc = new iText.Kernel.Pdf.PdfDocument(pdfReader, pdfWriter);


                        datosPedidoPDF(dgvDatosPDF);

                        int NumeroFila = 0;//NumeroFilas(idPedido);


                        PdfCanvas canvas = new PdfCanvas(pdfdoc.GetPage(1));
                        PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                        int y = 633;
                        int x = 109;
                        int Items = 0;



                        //PEDIDO
                        canvas.BeginText().SetFontAndSize(font, 18)
                                 .MoveText(x, y)
                                 .ShowText(dgvDatosPDF.Rows[0].Cells[0].Value.ToString())
                                 .EndText();

                        //FECHA_CREACIÓN
                        canvas.BeginText().SetFontAndSize(font, 14)
                                .MoveText(x - 74, y - 45)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[1].Value.ToString())
                                .EndText();

                        //CLIENTE
                        canvas.BeginText().SetFontAndSize(font, 9)
                                .MoveText(x + 268, y - 1)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[2].Value.ToString())
                                .EndText();
                        //VENDEDOR
                        canvas.BeginText().SetFontAndSize(font, 9)
                                .MoveText(x + 268, y - 1)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[3].Value.ToString())
                                .EndText();

                        //VEHICULO
                        //canvas.BeginText().SetFontAndSize(font, 9)
                        //            .MoveText(x + 274, y - 34.5)
                        //            .ShowText(dgvDatosPDF.Rows[0].Cells[3].Value.ToString() + "  -  " + dgvDatosPDF.Rows[0].Cells[4].Value.ToString() + " - " + dgvDatosPDF.Rows[0].Cells[12].Value.ToString())
                        //            .EndText();



                        //HORA DE CREACIÓN DEL VALE
                        //canvas.BeginText().SetFontAndSize(font, 10)
                        //        .MoveText(x - 77, y - 63)
                        //        .SetFillColor(ColorConstants.RED)
                        //        .ShowText("Creado: " + DateTime.Now.ToString())
                        //        .EndText();



                        double Total = 0;
                        for (int count = 0; count < NumeroFila; count++)
                        {

                            ///////////////generarEtiqueta(idPedido, dgvDatosPDF.Rows[count].Cells[!].Value.ToString());
                            iText.IO.Image.ImageData img = iText.IO.Image.ImageDataFactory.Create(Application.StartupPath + "\\temp.png");
                            img.SetWidth(150);
                            img.SetHeight(17);


                            canvas.AddImageAt(img, Convert.ToSingle(x - 76), Convert.ToSingle(y - 102.5), false);
                            File.Delete(Application.StartupPath + "\\temp.png");

                            //PRODUCTOS
                            canvas.BeginText().SetFontAndSize(font, 7)
                                    .MoveText(x + 88.6, y - 100)
                                    .SetFillColor(ColorConstants.BLACK)
                                    .ShowText(dgvDatosPDF.Rows[count].Cells[4].Value.ToString() + "-" + dgvDatosPDF.Rows[count].Cells[7].Value.ToString() + "-" + dgvDatosPDF.Rows[count].Cells[8].Value.ToString() + "-" + dgvDatosPDF.Rows[count].Cells[9].Value.ToString())
                                    .EndText();
                            //CANTIDAD
                            canvas.BeginText().SetFontAndSize(font, 10)
                                    .MoveText(x + 260, y - 100)
                                    .SetFillColor(ColorConstants.BLACK)
                                    .ShowText(dgvDatosPDF.Rows[count].Cells[5].Value.ToString())
                                    .EndText();


                            //PRECIO UNITARIO
                            canvas.BeginText().SetFontAndSize(font, 10)
                              .MoveText(x + 300, y - 100)
                              .SetFillColor(ColorConstants.BLACK)
                              .ShowText(dgvDatosPDF.Rows[count].Cells[6].Value.ToString())
                              .EndText();


                            double totalXProd = Convert.ToInt32(dgvDatosPDF.Rows[count].Cells[5].Value.ToString()) * Convert.ToInt32(dgvDatosPDF.Rows[count].Cells[6].Value.ToString()) ;
                            Total += totalXProd; 

                            //PRECIO TOTAL POR PRODUCTO
                            canvas.BeginText().SetFontAndSize(font, 10)
                              .MoveText(x + 300, y - 100)
                              .SetFillColor(ColorConstants.BLACK)
                              .ShowText(totalXProd.ToString())
                              .EndText();


                            Items = count;
                            y -= 25;
                        }

                        //TOTAL
                        canvas.BeginText().SetFontAndSize(font, 10)
                          .MoveText(x + 300, y - 100)
                          .SetFillColor(ColorConstants.BLACK)
                          .ShowText(Total.ToString())///////////////////////////////////
                          .EndText();

                        //NUMERO DE ITEMS
                        canvas.BeginText().SetFontAndSize(font, 9)
                                        .MoveText(x - 16, 96)
                                        .ShowText((Items + 1).ToString())
                                        .EndText();

                        pdfdoc.Close();

                        //MessageBOX.SHowDialog(3, "PDF creado exitosamente 1");

                    }

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrió un problema\nMayor Detalle:\n" + err.Message + "\n\n*Si muestra en ingles, proceda a traducirlo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        //---------------- OBTENER CLIENTES REGISTRADOS
        public DataSet ClientesRegistrados()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT idusuario ,nombre_usuario, nombre_real FROM usuario WHERE idrol = 4 AND estado = 1;", nuevaConexion);
                        dataAdapter.Fill(dataSet, "CLIENTE");
                    

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }


        //---------------- VEHICULOS-REGISTRADOS-MODELOS
        public DataSet VehiculosRegistrados(string marca)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT DISTINCT veh.idvehiculo,veh.modelo FROM vehiculo veh INNER JOIN MARCA mar ON veh.idmarca = mar.idmarca WHERE mar.marca = @marca AND mar.estado = 1 AND veh.estado = 1;", nuevaConexion);// WHERE modelo NOT LIKE 'PARTICULAR%'
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@marca", marca);
                    dataAdapter.Fill(dataSet, "VEHICULO");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- MARCAS VEHICULOS REGISTRADAS
        public DataSet MarcasRegistradas(int x)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                   
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT marca FROM MARCA WHERE estado = 1;", nuevaConexion);//  WHERE marca NOT LIKE 'PARTICULAR%'
                        dataAdapter.Fill(dataSet, "MARCA");
                    

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //----------------------------------REGISTRAR USUARIO----------------------------------------------
        public string recuperarNombreReal(string nombreUsuario)
        {
            string nombre = "---";
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    nuevacon.Open();

                        this.Comando = new SqlCommand(string.Format("SELECT nombre_real FROM usuario WHERE nombre_usuario = '{0}'", nombreUsuario), nuevacon);
                        Lector = this.Comando.ExecuteReader();
                        while (Lector.Read()) { nombre = Lector["nombre_real"].ToString(); }
                        Lector.Close();

                    nuevacon.Close();
                }
                return nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return nombre;
            }
        }


    }
}

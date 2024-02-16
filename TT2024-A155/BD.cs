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
using System.Net.Mime;
using iText.Kernel.Pdf.Canvas.Wmf;
using System.Reflection;
using System.Globalization;
//EXCEL
//using System.IO;
//using Excel = Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop.Excel;
//using ExcelDataReader;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QRCoder;



namespace TT2024_A155
{
    internal class BD
    {
        //VARIABLES
        private SqlCommand Comando;

        private SqlDataReader Lector;
        private DataTable dt;
        private SqlDataAdapter da;



        //ENVIAR CORREO USUARIO CREADO CORRECTAMENTE
        public void enviaCorreoPedido(string destinatario, string usuario)
        {


            {

                string senderNombre = "TT2024-A155";
                string senderCorreo = "correos-jeic@jeic.com.mx";
                string senderAppPass = "dgyvipbypyupufpm";//xldsjobozxjsrmpk



                try
                {

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress(senderNombre, senderCorreo));

                    message.To.Add(new MailboxAddress("", destinatario));

                    message.Subject = "Bienvenido a TT2024-A155";


                    var bodyBuilder = new BodyBuilder();

                    

                    string contenido = "Hola!!!! " + usuario + " Bienvenido al sistema de TT-2024-A155";

                    bodyBuilder.HtmlBody = contenido;

                    message.Body = bodyBuilder.ToMessageBody();



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

        //OBETER PERMISOS SEGUN EL TIPO DE USUARIO
        public string[] obtenerPermisos(string idrol)
        {
            string[] permisos = new string[10];

            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();

                    Comando = new SqlCommand(string.Format("SELECT * FROM permiso WHERE idrol = '{0}';", idrol), nuevaConexion);
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read())
                    {
                        permisos[0] = Lector["crear_usuarios"].ToString();//CREAR USUARIOS
                        permisos[1] = Lector["mod_usuarios"].ToString();//MODIFICAR USUARIOS
                        permisos[2] = Lector["crear_pedidos"].ToString();//CREAR PEDIDOS
                        permisos[3] = Lector["mod_pedidos"].ToString();//MODIFICAR PEDIDOS
                        permisos[4] = Lector["conf_pedidos"].ToString();//CONFIRMAR PEDIDOS
                        permisos[5] = Lector["registrar_entrega"].ToString();//REGISTRAR ENTREGA
                        permisos[6] = Lector["registrar_devolucion"].ToString();//REGISTRAR DEVOLUCION
                        permisos[7] = Lector["generar_firma"].ToString();//GENERAR FIRMA
                        permisos[8] = Lector["generar_factura"].ToString();//GENERAR FACTURA 
                        permisos[9] = Lector["generar_reporteVentas"].ToString();//GENERAR REPORTE VENTAS

                    }
                    Lector.Close();

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return permisos;
        }

        //----------------------------------INICIO DE SESION----------------------------------------------
        public int[] inicioSesion(string us, string contra)
        {
            int[] contador = new int[2];// int[0] = Se VALIDO,,,, int[1] = ROL
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {

                    if (validarUsuario(us) == 1)
                    {
                        string contraHash = "";
                        Comando = new SqlCommand(string.Format("SELECT contrasenia, idrol FROM usuario WHERE nombre_usuario = '{0}'", us), nuevacon);
                        nuevacon.Open();
                        Lector = Comando.ExecuteReader();
                        if (Lector.Read())
                        {
                            contraHash = Lector["contrasenia"].ToString();
                            contador[1] = Convert.ToInt32(Lector["idrol"].ToString());
                        }
                            
                        if (BC.Verify(contra, contraHash)) 
                            contador[0]++;
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
                    Comando = new SqlCommand(string.Format("SELECT * FROM usuario WHERE nombre_usuario = '{0}';", us), nuevacon);
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
                    Comando = new SqlCommand(string.Format("SELECT * FROM usuario WHERE correo = '{0}';", correo), nuevacon);
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
                        Comando = new SqlCommand(string.Format("SELECT idrol FROM ROL WHERE nombre = '{0}'", rol), nuevacon);
                        Lector = Comando.ExecuteReader();
                        while (Lector.Read()) { x = Int32.Parse(Lector["idrol"].ToString()); }
                        Lector.Close();
                        string contraHash = BC.HashPassword(contra);
                        Comando = new SqlCommand(string.Format("INSERT INTO usuario (idrol,nombre_usuario,nombre_real,contrasenia,calle,colonia,noExt,noInt,cp,ciudad,telefono,correo) VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}');", x, us, nombre, contraHash, calle, colonia, noExt, noInt, cp, ciudad, telefono, correo), nuevacon);
                        Comando.ExecuteNonQuery();
                        MessageBox.Show("Se registro correctamente!");
                        enviaCorreoPedido(correo, nombre);
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
        public void enviaCorreoContrasenia(string destinatario, string contra)
        {


            {

                string senderNombre = "TT2024-A155";
                string senderCorreo = "correos-jeic@jeic.com.mx";
                string senderAppPass = "dgyvipbypyupufpm";//xldsjobozxjsrmpk
                


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
                            "\r\n Tu contraseña temporal es: " +
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
                        Comando = new SqlCommand(string.Format("UPDATE USUARIO SET contrasenia = '{0}', contrasenia_temp = 1 WHERE nombre_usuario = '{1}' OR correo = '{2}';", contraHash, dato, dato), nuevacon);
                        Comando.ExecuteNonQuery();

                        Comando = new SqlCommand(string.Format("SELECT correo FROM usuario WHERE nombre_usuario = '{0}' OR correo = '{1}';", dato, dato), nuevacon);
                        Lector = Comando.ExecuteReader();
                        while (Lector.Read()) { destinatario = Lector["correo"].ToString(); }
                        Lector.Close();

                        this.enviaCorreoContrasenia(destinatario, contra);

                        MessageBox.Show("Favor de revisar su bandeja de entrada para recuperar su acceso");

                    }
                    else if (validarCorreoUsuario(dato) == 1)
                    {
                        string contra = contraAleatoia();
                        string contraHash = BC.HashPassword(contra);
                        string destinatario = "";
                        Comando = new SqlCommand(string.Format("UPDATE USUARIO SET contrasenia = '{0}', contrasenia_temp = 1 WHERE nombre_usuario = '{1}' OR correo = '{2}';", contraHash, dato, dato), nuevacon);
                        Comando.ExecuteNonQuery();

                        Comando = new SqlCommand(string.Format("SELECT correo FROM usuario WHERE nombre_usuario = '{0}' OR correo = '{1}';", dato, dato), nuevacon);
                        Lector = Comando.ExecuteReader();
                        while (Lector.Read()) { destinatario = Lector["correo"].ToString(); }
                        Lector.Close();

                        this.enviaCorreoContrasenia(destinatario, contra);

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
                    Comando = new SqlCommand(string.Format("UPDATE USUARIO SET contrasenia = '{0}', contrasenia_temp = 0 WHERE nombre_usuario = '{1}';", contraHash, us), nuevacon);
                    Comando.ExecuteNonQuery();



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
                    Comando = new SqlCommand(string.Format("SELECT contrasenia_temp FROM usuario WHERE nombre_usuario = '{0}';", us), nuevacon);
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

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TOP 100 nombre, codigo, idproducto FROM producto WHERE estado = 1 ORDER BY NEWID();", nuevaConexion);
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

        //OBTENER INFO DEL PRODUCTO A ACTUALIZAR
        public DataSet ProductoActualizar(string idProducto)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(string.Format("SELECT nombre, codigo, idproducto FROM producto WHERE estado = 1 AND idproducto = '{0}' ORDER BY NEWID();",idProducto), nuevaConexion);
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
            string[] producto = new string[13];

            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();

                    Comando = new SqlCommand(string.Format("SELECT codigo,nombre,precio_venta,costo_proveedor,stock,descripcion,idproducto FROM producto WHERE nombre = '{0}' AND estado = 1;", Nombre), nuevaConexion);
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read()) {
                        producto[0] = Lector["nombre"].ToString();
                        //producto[1] = Lector[""].ToString();CANTIDAD
                        producto[2] = Lector["codigo"].ToString();
                        producto[3] = Lector["precio_venta"].ToString();
                        //producto[4] = Lector[""].ToString(); DESCUENTO
                        producto[5] = Lector["descripcion"].ToString();
                        producto[6] = Lector["stock"].ToString();
                        producto[7] = Lector["costo_proveedor"].ToString();

                        producto[11] = Lector["idproducto"].ToString();//IDPRODUCTO
                        

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

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre, idrol FROM rol WHERE estado = 1", nuevaConexion);
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
                    Comando = new SqlCommand(string.Format("SELECT COUNT (detp.idproducto) FROM detalle_pedido detp LEFT OUTER JOIN pedido p ON p.idpedido = detp.idpedido WHERE p.idpedido = {0};", idPedido), nuevacon);
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



        //---------------------------OBTENER DATOS PARA GENERAR EL COMPROBANTE PDF--------------------
        public void datosPedidoPDF(DataGridView dgv, string idPedido)
        {
           
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("select p.idpedido, p.fecha_hora, us.nombre_real, p.idusuarioVendedor, prod.nombre, detp.cantidad, prod.precio_venta, ma.marca, v.modelo, v.anio, detp.iddetalle_pedido, us.correo from pedido p LEFT OUTER JOIN usuario us ON us.idusuario = p.idusuarioCliente LEFT OUTER JOIN detalle_pedido detp ON detp.idpedido = p.idpedido LEFT OUTER JOIN vehiculo v ON v.idvehiculo = detp.idvehiculo LEFT OUTER JOIN marca ma ON ma.idmarca = v.idmarca LEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto WHERE p.idpedido = {0} order by p.idpedido;", idPedido), nuevacon);
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

        //---------------------------OBTENER DATOS PARA GENERAR LA FACTURA--------------------
        public void datosFacturaPDF(DataGridView dgv, string idPedido)
        {

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("SELECT (1) AS 'Datos Fiscales Empresa', fact.num_factura, fact.fecha_emision, fact.comentario, dfc.iddatos_fiscales_cli, ped.impuesto, ped.total, dfc.nombre, dfc.calle, dfc.noExt, dfc.noInt, dfc.colonia, dfc.cp, dfc.ciudad, dfc.telefono, dfc.correo, dfc.cif, prod.nombre, mar.marca, veh.modelo, veh.anio, detp.cantidad, prod.precio_venta, detp.descuento, ((prod.precio_venta * ((100 - detp.descuento)/100)) * detp.cantidad) AS 'Total'   FROM detalle_pedido detp LEFT OUTER JOIN pedido ped ON ped.idpedido = detp.idpedido LEFT OUTER JOIN usuario us ON us.idusuario = ped.idusuarioCliente LEFT OUTER JOIN datos_fiscales_cliente dfc ON dfc.iddatos_fiscales_cli = us.iddatos_fiscales_cli LEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto LEFT OUTER JOIN vehiculo veh ON veh.idvehiculo = detp.idvehiculo LEFT OUTER JOIN marca mar ON mar.idmarca = veh.idmarca LEFT OUTER JOIN factura fact ON fact.idfactura = ped.idfactura WHERE ped.idpedido = '{0}';", idPedido), nuevacon);
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

        //----------------------GENERAR PDF COMPROBANTE
        public void generarComprobante(string idPedido, DataGridView dgvDatosPDF, bool enviaCorreo)
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
                fileRoute.FileName = "Comprobante_" + idPedido;
                

                if (fileRoute.ShowDialog() == DialogResult.OK)
                {
                    if (!File.Exists(fileRoute.FileName))
                    {
                        iText.Kernel.Pdf.PdfWriter pdfWriter = new iText.Kernel.Pdf.PdfWriter(fileRoute.FileName);

                        string ruta = Application.StartupPath + "\\Comprobante.pdf";
                        File.WriteAllBytes(ruta, Properties.Resources.Comprobante);


                        iText.Kernel.Pdf.PdfReader pdfReader = new iText.Kernel.Pdf.PdfReader(Application.StartupPath + "\\Comprobante.pdf");




                        iText.Kernel.Pdf.PdfDocument pdfdoc = new iText.Kernel.Pdf.PdfDocument(pdfReader, pdfWriter);


                        datosPedidoPDF(dgvDatosPDF ,idPedido);

                        int NumeroFila = NumeroFilas(idPedido);


                        PdfCanvas canvas = new PdfCanvas(pdfdoc.GetFirstPage());
                        PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                        int y = 0;//633
                        int x = 0;//109
                        int cantidad = 0;
                        double Total = 0;
                        int Items = 0;
                        byte[] pdf;
                        string correoCliente = dgvDatosPDF.Rows[0].Cells[11].Value.ToString();


                        //ORIGEN
                        //canvas.BeginText().SetFontAndSize(font, 9)
                        //         .MoveText(x+26,y+540)
                        //         .ShowText("0,0")
                        //         .EndText();

                        //PEDIDO
                        canvas.BeginText().SetFontAndSize(font, 18)
                                 .MoveText(x + 105, y + 642)
                                 .ShowText(dgvDatosPDF.Rows[0].Cells[0].Value.ToString())
                                 .EndText();

                        //FECHA_CREACIÓN
                        canvas.BeginText().SetFontAndSize(font, 14)
                                .MoveText(x + 40, y + 590)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[1].Value.ToString().Substring(0,10))
                                .EndText();

                        //CLIENTE
                        canvas.BeginText().SetFontAndSize(font, 9)
                                .MoveText(x + 395, y + 638)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[2].Value.ToString())
                                .EndText();

                        //VENDEDOR
                        canvas.BeginText().SetFontAndSize(font, 9)
                                .MoveText(x + 403, y + 605)
                                .ShowText(nombreVendedor(dgvDatosPDF.Rows[0].Cells[3].Value.ToString()))
                                .EndText();



                        
                        for (int count = 0; count < NumeroFila; count++)
                        {

                            generarEtiqueta(idPedido, dgvDatosPDF.Rows[count].Cells[10].Value.ToString());
                            iText.IO.Image.ImageData img = iText.IO.Image.ImageDataFactory.Create(Application.StartupPath + "\\temp.png");
                            img.SetWidth(150);
                            img.SetHeight(17);


                            canvas.AddImageAt(img, Convert.ToSingle(x + 27), Convert.ToSingle(y + 537), false);
                            File.Delete(Application.StartupPath + "\\temp.png");

                            //PRODUCTOS
                            canvas.BeginText().SetFontAndSize(font, 7)
                                    .MoveText(x + 197, y +548)
                                    .SetFillColor(ColorConstants.BLACK)
                                    .ShowText(dgvDatosPDF.Rows[count].Cells[4].Value.ToString())
                                    .EndText();

                            //PRODUCTOS NOMBRE VEHICULO Y ANIO
                            canvas.BeginText().SetFontAndSize(font, 7)
                                    .MoveText(x + 197, y + 540)
                                    .SetFillColor(ColorConstants.BLACK)
                                    .ShowText(dgvDatosPDF.Rows[count].Cells[7].Value.ToString() + "-" + dgvDatosPDF.Rows[count].Cells[8].Value.ToString() + "-" + dgvDatosPDF.Rows[count].Cells[9].Value.ToString())
                                    .EndText();

                            cantidad = Convert.ToInt32(dgvDatosPDF.Rows[count].Cells[5].Value.ToString());
                            //CANTIDAD
                            canvas.BeginText().SetFontAndSize(font, 10)
                                    .MoveText(x + 370, y + 548)
                                    .SetFillColor(ColorConstants.BLACK)
                                    .ShowText(dgvDatosPDF.Rows[count].Cells[5].Value.ToString())
                                    .EndText();


                            //PRECIO UNITARIO
                            canvas.BeginText().SetFontAndSize(font, 10)
                              .MoveText(x + 420, y + 548)
                              .SetFillColor(ColorConstants.BLACK)
                              .ShowText(dgvDatosPDF.Rows[count].Cells[6].Value.ToString())
                              .EndText();


                            double totalXProd = Convert.ToDouble(Convert.ToInt32(dgvDatosPDF.Rows[count].Cells[5].Value.ToString()) * Convert.ToDouble(dgvDatosPDF.Rows[count].Cells[6].Value.ToString())) ;
                            Total += totalXProd; 

                            //PRECIO TOTAL POR PRODUCTO
                            canvas.BeginText().SetFontAndSize(font, 10)
                              .MoveText(x + 520, y + 548)
                              .SetFillColor(ColorConstants.BLACK)
                              .ShowText(totalXProd.ToString("0.##"))
                              .EndText();


                            Items += cantidad;
                            y -= 25;
                        }

                        //TOTAL
                        canvas.BeginText().SetFontAndSize(font, 10)
                          .MoveText(x + 510, 105)
                          .SetFillColor(ColorConstants.BLACK)
                          .ShowText("Total: " + Total.ToString("0.##"))
                          .EndText();

                        //NUMERO DE ITEMS
                        canvas.BeginText().SetFontAndSize(font, 9)
                                        .MoveText(x +130, 105)
                                        .ShowText((Items).ToString())
                                        .EndText();

                        pdfdoc.Close();

                        pdf = File.ReadAllBytes(fileRoute.FileName);

                        if(enviaCorreo)
                            enviaCorreoPedido(correoCliente, pdf);

                        //MessageBOX.SHowDialog(3, "PDF creado exitosamente 1");

                    }

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrió un problema\nMayor Detalle:\n" + err.Message + "\n\n*Si muestra en ingles, proceda a traducirlo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        //OBTENER ID DEL USUARIO VENDEDOR U OTRO CON BASE EN SU NOMBRE DE USUARIO
        public int idUsuario(string usuario)
        {
            int idVendedor = -1;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {

                    Comando = new SqlCommand(string.Format("SELECT idusuario FROM usuario WHERE nombre_usuario = '{0}';", usuario), nuevacon);
                    nuevacon.Open();
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                        idVendedor = Convert.ToInt32(Lector["idusuario"].ToString());
                    nuevacon.Close();
                }
                return idVendedor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return idVendedor;
            }

        }

        //OBTENER NOMBRE DEL VENDEDOR CON BASE EN SU ID
        public string nombreVendedor(string idVendedor)
        {
            string nombreVendedor = "";
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {

                    Comando = new SqlCommand(string.Format("SELECT nombre_real from usuario where idusuario = '{0}';", idVendedor), nuevacon);
                    nuevacon.Open();
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                        nombreVendedor = Lector["nombre_real"].ToString();
                    nuevacon.Close();
                }
                return nombreVendedor;
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return nombreVendedor;
            }

        }

        //ENVIAR CORREO PEDIDO CREADO CORRECTAMENTE
        public void enviaCorreoPedido(string destinatario, byte[] pdf)
        {


            {

                string senderNombre = "TT2024-A155";
                string senderCorreo = "correos-jeic@jeic.com.mx";
                string senderAppPass = "dgyvipbypyupufpm";//xldsjobozxjsrmpk
                


                try
                {

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress(senderNombre, senderCorreo));

                    message.To.Add(new MailboxAddress("", destinatario));

                    message.Subject = "Muchas Gracias Por Su Compra!!!!";


                    var bodyBuilder = new BodyBuilder();

                    bodyBuilder.Attachments.Add(fileName: "Comprobante",pdf, contentType: MimeKit.ContentType.Parse(MediaTypeNames.Application.Pdf));

                    string contenido = "En los adjuntos de este correo encontraras el docuemnto PDF con toda la información de tu compra.";
                    
                    bodyBuilder.HtmlBody = contenido;

                    message.Body = bodyBuilder.ToMessageBody();

                    

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



        //---------------- ANIOS DE MODELOS DE CARROS-REGISTRADOS-MODELOS
        public DataSet modelosRegistrados(string marca, string modelo)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT DISTINCT veh.anio FROM vehiculo veh INNER JOIN MARCA mar ON veh.idmarca = mar.idmarca WHERE mar.marca = @marca AND veh.modelo = @modelo AND mar.estado = 1 AND veh.estado = 1;", nuevaConexion);// WHERE modelo NOT LIKE 'PARTICULAR%'
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@marca", marca);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@modelo", modelo);
                    dataAdapter.Fill(dataSet, "ANIO");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }


        //---------------- MODELOS DE CARROS-REGISTRADOS-MODELOS
        public DataSet modelosRegistrados(string marca)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT DISTINCT veh.modelo FROM vehiculo veh INNER JOIN MARCA mar ON veh.idmarca = mar.idmarca WHERE mar.marca = @marca AND mar.estado = 1 AND veh.estado = 1;", nuevaConexion);// WHERE modelo NOT LIKE 'PARTICULAR%'
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@marca", marca);
                    dataAdapter.Fill(dataSet, "MODELO");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }


        
        //---------------- OBTENER ID VEHICULOS- CON MARCA-MODELO-ANIO
        public string idVehiculoProducto(string marca, string modelo, string anio)
        {
            string idVehiculoProducto = null;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand(string.Format("SELECT veh.idvehiculo FROM vehiculo veh INNER JOIN MARCA mar ON veh.idmarca = mar.idmarca WHERE mar.marca = '{0}' AND veh.modelo = '{1}' AND veh.anio = '{2}' AND mar.estado = 1 AND veh.estado = 1;", marca, modelo, anio), nuevaConexion);
                    
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read()) { idVehiculoProducto = Lector["idvehiculo"].ToString(); }
                    Lector.Close();

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return idVehiculoProducto;
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

                        Comando = new SqlCommand(string.Format("SELECT nombre_real FROM usuario WHERE nombre_usuario = '{0}'", nombreUsuario), nuevacon);
                        Lector = Comando.ExecuteReader();
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




        public int registrarPedido(string idUsuarioVendedor, string idUsuarioCliente, string fecha_hora, string impuesto, string total, string comentarios)
        {

                int i = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {


                    nuevacon.Open();
                   
                    Comando = new SqlCommand("INSERT INTO pedido (idusuarioVendedor, idusuarioCliente, fecha_hora, impuesto, total, comentarios)\r\nVALUES (@idUsuarioVendedor, @idUsuarioCliente, @fecha_hora, @impuesto, @total, @comentarios);", nuevacon);
                    
                    if(idUsuarioVendedor != string.Empty)
                        Comando.Parameters.AddWithValue("@idusuarioVendedor", Convert.ToInt32(idUsuarioVendedor));
                    else
                        Comando.Parameters.AddWithValue("@idusuarioVendedor", Convert.ToInt32(idUsuarioCliente));

                    Comando.Parameters.AddWithValue("@idusuarioCliente", Convert.ToInt32(idUsuarioCliente));
                    Comando.Parameters.AddWithValue("@fecha_hora", Convert.ToDateTime(fecha_hora));
                    Comando.Parameters.AddWithValue("@impuesto", Convert.ToDouble(impuesto));
                    Comando.Parameters.AddWithValue("@total", Convert.ToDouble(total));
                    Comando.Parameters.AddWithValue("@comentarios", comentarios);


                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevacon.Close();
                    //if (i == 1)
                    //{  
                    //    MessageBOX.SHowDialog(1, "Se registró pedido correctamente");
                    //}
                    //else
                    //    MessageBOX.SHowDialog(2, "Problemas al registar pedido");
                }
                return i;
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error registrar pedido: " + EX.Message);
            }
            return i;
            
        }


        //----------------------------------ACTUALIZAR STOCK PRODUCTO----------------------------------------------
        public void actualizarStock(string idProducto, string cantidad)
        {
            int i = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    nuevacon.Open();


                        Comando = new SqlCommand(string.Format("UPDATE producto SET stock = (stock + {0}) WHERE idproducto = {1};", cantidad, idProducto), nuevacon);
                        i = Comando.ExecuteNonQuery();

                        if (i > 0)
                        {
                            //MessageBox.Show("Stock Actualizado");
                        }
                        else
                            MessageBox.Show("Stock No Actualizado");

                   

                    nuevacon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


        public int registrarDetallePedido(string idProducto, string cantidad, string precio, string descuento, string idVehiculo)
        {

            int i = 0;
            int idPedido = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {

                    nuevacon.Open();

                    

                    Comando = new SqlCommand("SELECT TOP 1 idpedido FROM pedido WHERE estado = 1 ORDER BY idpedido desc;", nuevacon);
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read()) { idPedido = Convert.ToInt32(Lector["idpedido"].ToString()); }
                    Lector.Close();




                    Comando = new SqlCommand("INSERT INTO detalle_pedido (idpedido, idproducto, cantidad, precio, descuento, idvehiculo)\r\nVALUES (@idPedido,@idProducto, @cantidad, @precio, @descuento, @idVehiculo);", nuevacon);

                    Comando.Parameters.AddWithValue("@idPedido", Convert.ToInt32(idPedido));
                    Comando.Parameters.AddWithValue("@idProducto", Convert.ToInt32(idProducto));
                    Comando.Parameters.AddWithValue("@cantidad", Convert.ToInt32(cantidad));
                    Comando.Parameters.AddWithValue("@precio", Convert.ToDouble(precio));
                    Comando.Parameters.AddWithValue("@descuento", Convert.ToDouble(descuento));
                    Comando.Parameters.AddWithValue("@idVehiculo", Convert.ToInt32(idVehiculo));
                    


                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevacon.Close();
                    if (i == 1)
                    {
                        actualizarStock(idProducto,cantidad);
                        return idPedido;
                        //generarComprobante(idPedido.ToString());
                    }
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar pedido");
                }
                return -1;
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error registrar pedido: " + EX.Message);
            }
            return -1;

        }


        //----------------------------------VALIDAR QUE EL CLIENTE TENGA DATOS FISCALES REGISTRADOS----------------------------------------------
        public int validarDatosFiscalesCliente(string us)
        {
            int contador = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    Comando = new SqlCommand(string.Format("SELECT iddatos_fiscales_cli FROM usuario WHERE nombre_usuario = '{0}';", us), nuevacon);
                    nuevacon.Open();
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read()) { 
                        if (Lector["iddatos_fiscales_cli"].ToString() != string.Empty)
                            contador++;
                    }
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


        //----------------------------------REGISTRAR DATOS FISCALES CLIENTE ----------------------------------------------
        public void registrarDatosFiscalesCliente(string usuario, string nombre, string cif, string calle, string colonia, string noExt, string noInt, string CP, string ciudad, string telefono, string correo)
        {
            int i = 0;
            int idDatosFiscales = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    nuevacon.Open();

                    Comando = new SqlCommand("INSERT INTO datos_fiscales_cliente (nombre,cif,calle,colonia,noExt,noInt,cp,ciudad,telefono,correo) VALUES (@nombre,@cif,@calle,@colonia,@noExt,@noInt,@cp,@ciudad,@telefono,@correo);", nuevacon);

                    Comando.Parameters.AddWithValue("@nombre", nombre);
                    Comando.Parameters.AddWithValue("@cif", cif);
                    Comando.Parameters.AddWithValue("@calle", calle);
                    Comando.Parameters.AddWithValue("@colonia", colonia);
                    Comando.Parameters.AddWithValue("@noExt", noExt);
                    Comando.Parameters.AddWithValue("@noInt", noInt);
                    Comando.Parameters.AddWithValue("@cp", CP);
                    Comando.Parameters.AddWithValue("@ciudad", ciudad);
                    Comando.Parameters.AddWithValue("@telefono", telefono);
                    Comando.Parameters.AddWithValue("@correo", correo);



                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();

                    if (i > 0) {
                        i = 0;
                        Comando = new SqlCommand("SELECT TOP 1 iddatos_fiscales_cli FROM datos_fiscales_cliente WHERE estado = 1 ORDER BY iddatos_fiscales_cli desc;", nuevacon);
                        Lector = Comando.ExecuteReader();
                        while (Lector.Read()) { idDatosFiscales = Convert.ToInt32(Lector["iddatos_fiscales_cli"].ToString()); }
                        Lector.Close();

                        Comando = new SqlCommand(string.Format("UPDATE USUARIO SET iddatos_fiscales_cli = {0} WHERE nombre_usuario = '{1}';", idDatosFiscales,usuario), nuevacon) ;
                        i =  Comando.ExecuteNonQuery();

                        if (i > 0)
                        {
                            MessageBox.Show("Datos Fiscales Registrados Exitosamente");
                        }
                        else
                            MessageBox.Show("Datos Fiscales No Registrados");

                    }

                    nuevacon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        //----------------------------------ACTUALIZAR DATOS FISCALES CLIENTE ----------------------------------------------
        public void actualizarDatosFiscalesCliente(string usuario, string nombre, string cif, string calle, string colonia, string noExt, string noInt, string CP, string ciudad, string telefono, string correo)
        {
            int i = 0;
            int idDatosFiscales = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    nuevacon.Open();

                    Comando = new SqlCommand("UPDATE  dfc SET nombre = @nombre, cif = @cif, calle = @calle, colonia = @colonia, noExt = @noExt, noInt = @noInt, cp = @cp, ciudad = @ciudad, telefono = @telefono, correo = @correo FROM datos_fiscales_cliente dfc INNER JOIN usuario us ON us.iddatos_fiscales_cli = dfc.iddatos_fiscales_cli WHERE us.nombre_usuario = @usuario;", nuevacon);

                    Comando.Parameters.AddWithValue("@nombre", nombre);
                    Comando.Parameters.AddWithValue("@cif", cif);
                    Comando.Parameters.AddWithValue("@calle", calle);
                    Comando.Parameters.AddWithValue("@colonia", colonia);
                    Comando.Parameters.AddWithValue("@noExt", noExt);
                    Comando.Parameters.AddWithValue("@noInt", noInt);
                    Comando.Parameters.AddWithValue("@cp", CP);
                    Comando.Parameters.AddWithValue("@ciudad", ciudad);
                    Comando.Parameters.AddWithValue("@telefono", telefono);
                    Comando.Parameters.AddWithValue("@correo", correo);
                    Comando.Parameters.AddWithValue("@usuario", usuario);



                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();

                    if (i > 0)
                        {
                            MessageBox.Show("Datos Fiscales Actualziados Exitosamente");
                        }
                    else
                            MessageBox.Show("Datos Fiscales No Actualizados");

                    

                    nuevacon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


        //OBETER DATOS FISCALES CLIENTE 
        public string[] datosFiscalesCliente(string usuario)
        {
            string[] datosFiscales = new string[10];

            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();

                    Comando = new SqlCommand(string.Format("SELECT dfc.nombre, dfc.cif, dfc.calle, dfc.colonia, dfc.noExt, dfc.noInt, dfc.cp, dfc.ciudad, dfc.telefono, dfc.correo FROM datos_fiscales_cliente dfc INNER JOIN usuario us ON us.iddatos_fiscales_cli = dfc.iddatos_fiscales_cli  WHERE  us.nombre_usuario = '{0}' AND us.estado = 1;", usuario), nuevaConexion);
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read())
                    {
                        datosFiscales[0] = Lector["nombre"].ToString();//NOMBRE
                        datosFiscales[1] = Lector["cif"].ToString();//CIF
                        datosFiscales[2] = Lector["calle"].ToString();//CALLE
                        datosFiscales[3] = Lector["colonia"].ToString();//COLONIA
                        datosFiscales[4] = Lector["noExt"].ToString();//NOEXT
                        datosFiscales[5] = Lector["noInt"].ToString();//NOINT
                        datosFiscales[6] = Lector["cp"].ToString();//CP
                        datosFiscales[7] = Lector["ciudad"].ToString();//CIUDAD
                        datosFiscales[8] = Lector["telefono"].ToString();//TELEFONO
                        datosFiscales[9] = Lector["correo"].ToString();//CORREO
                        
                    }
                    Lector.Close();

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return datosFiscales;
        }



        //---------------------------Inicializar DGV de Cliente al iniciar sesion--------------------
        public void inicioClientePedidos(DataGridView dgv, string usuario)
        {
            
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    //MessageBox.Show(cvePedido);
                    da = new SqlDataAdapter(string.Format("SELECT detp.iddetalle_pedido, ped.idpedido AS '# Pedido', ped.aprobacionCliente AS 'Autorizado', us.nombre_usuario AS 'Usuario', us.nombre_real AS 'Nombre', ped.fecha_hora AS 'Fecha Creación', prod.nombre AS 'Producto', prod.precio_venta AS 'Precio venta', detp.cantidad AS 'Cantidad', detp.descuento AS 'Descuento', ped.comentarios, ped.impuesto, ped.total, mar.marca AS 'Marca', veh.modelo AS 'Modelo'  FROM detalle_pedido detp LEFT OUTER JOIN pedido ped ON ped.idpedido = detp.idpedido LEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto LEFT OUTER JOIN usuario us ON us.idusuario = ped.idusuarioCliente LEFT OUTER JOIN vehiculo veh ON veh.idvehiculo = detp.idvehiculo LEFT OUTER JOIN marca mar ON mar.idmarca = veh.idmarca WHERE us.idusuario = '{0}' AND detp.estado = 1 ORDER BY ped.fecha_hora desc;", idUsuario(usuario)), nuevacon);
                    nuevacon.Open();
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

        //---------------------------Inicializar DGV de Empleado al iniciar sesion--------------------
        public void inicioPedidosEmpleados(DataGridView dgv, string usuario)
        {
            
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    //MessageBox.Show(cvePedido);
                    da = new SqlDataAdapter(string.Format("SELECT detp.iddetalle_pedido, ped.idpedido AS '# Pedido', ped.aprobacionCliente AS 'Autorizado', us.nombre_usuario AS 'Usuario', us.nombre_real AS 'Nombre', ped.fecha_hora AS 'Fecha Creación', prod.nombre AS 'Producto', prod.precio_venta AS 'Precio venta', detp.cantidad AS 'Cantidad', detp.descuento AS 'Descuento', ped.comentarios, ped.impuesto, ped.total, mar.marca AS 'Marca', veh.modelo AS 'Modelo'  FROM detalle_pedido detp LEFT OUTER JOIN pedido ped ON ped.idpedido = detp.idpedido LEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto LEFT OUTER JOIN usuario us ON us.idusuario = ped.idusuarioVendedor LEFT OUTER JOIN vehiculo veh ON veh.idvehiculo = detp.idvehiculo LEFT OUTER JOIN marca mar ON mar.idmarca = veh.idmarca WHERE us.idusuario = '{0}' AND detp.estado = 1 ORDER BY ped.fecha_hora desc;", idUsuario(usuario)), nuevacon);
                    nuevacon.Open();
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

        //---------------------------Llenar Datos pedido--------------------
        public string[] detallesPedido(string idDetallePedido)
        {
            string[] detallesPedido = new string[19];
            double impuesto;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    
                    nuevacon.Open();
                    Comando = new SqlCommand(string.Format("SELECT ped.idpedido, ped.fecha_hora, us.nombre_real, us.nombre_usuario, prod.nombre, detp.cantidad, prod.precio_venta, detp.descuento, mar.marca, veh.modelo, ped.comentarios, ped.aprobacionCliente, fact.idfactura, fact.fact_sinIVA, fact.fact_neto, ped.idusuarioVendedor, veh.anio, fact.num_factura AS 'numFact', fact.comentario AS 'factComen' FROM detalle_pedido detp LEFT OUTER JOIN pedido ped ON ped.idpedido = detp.idpedido LEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto LEFT OUTER JOIN usuario us ON us.idusuario = ped.idusuarioCliente LEFT OUTER JOIN vehiculo veh ON veh.idvehiculo = detp.idvehiculo LEFT OUTER JOIN marca mar ON mar.idmarca = veh.idmarca LEFT OUTER JOIN factura fact ON fact.idfactura = ped.idfactura WHERE detp.iddetalle_pedido = '{0}';", idDetallePedido), nuevacon);
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read())
                    {
                        detallesPedido[0] = Lector["idpedido"].ToString();//IDPEDIDO
                        detallesPedido[1] = Lector["fecha_hora"].ToString().Substring(0,10);//FECHA_HORA
                        detallesPedido[2] = Lector["nombre_real"].ToString();//NOMBRE CLIENTE
                        detallesPedido[3] = Lector["nombre_usuario"].ToString();//USUARIO 
                        detallesPedido[4] = Lector["nombre"].ToString();//NOMBRE PRODUCTO
                        detallesPedido[5] = Lector["cantidad"].ToString();//CANTIDAD PRODUCTO
                        detallesPedido[6] = Lector["precio_venta"].ToString();//PRECIO VENTA
                        detallesPedido[7] = Lector["descuento"].ToString();//DESCUENTO
                        detallesPedido[8] = Lector["marca"].ToString();//MARCA
                        detallesPedido[9] = Lector["modelo"].ToString();//MODELO
                        detallesPedido[10] = Lector["comentarios"].ToString();//COMENTARIOS
                        detallesPedido[17] = Lector["anio"].ToString();//ANIO VEHICULO

                        if (Lector["aprobacionCliente"].ToString() == "true")//ESTADO PEDIDO
                            detallesPedido[11] = "Autorizado";
                        else detallesPedido[11] = "En revisión";
                        

                        if (Lector["idfactura"].ToString() != string.Empty) {
                            detallesPedido[12] = Lector["numFact"].ToString();//IDFACTURA
                            detallesPedido[13] = Lector["fact_sinIVA"].ToString();//FACTURA SIN IVA
                            detallesPedido[14] = Lector["fact_neto"].ToString();//FACTURA CON IVA

                            impuesto = Convert.ToDouble(Lector["fact_neto"].ToString()) - Convert.ToDouble(Lector["fact_sinIVA"].ToString());
                            detallesPedido[15] = impuesto.ToString("0.##");//IMPUESTO
                            detallesPedido[18] = Lector["factComen"].ToString();//COMENTARIO

                        }
                        else
                        {
                            detallesPedido[12] = "";//IDFACTURA
                            detallesPedido[13] = "";//FACTURA SIN IVA
                            detallesPedido[14] = "";//FACTURA CON 
                            detallesPedido[15] = "";//IMPUESTO
                            detallesPedido[18] = "";//COMENTARIO
                        }

                       
                        detallesPedido[16] = nombreVendedor(Lector["idusuarioVendedor"].ToString());//NOMBRE VENDEDOR
                        

                    }
                    Lector.Close();
                    nuevacon.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

            return detallesPedido;
        }


        //----------------------------------ACTUALIZAR STOCK PRODUCTO----------------------------------------------
        public void aprobarPedidoCliente(string idPedido)
        {
            int i = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    nuevacon.Open();


                    Comando = new SqlCommand(string.Format("UPDATE ped SET ped.aprobacionCliente = 1 FROM pedido ped WHERE ped.idpedido = '{0}';", idPedido), nuevacon);
                    i = Comando.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Pedido autorizado");
                    }
                    else
                        MessageBox.Show("Error al autorizar el pedido");



                    nuevacon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }



        //---------------------------Llenar datos DGV Pedido Filtro # Pedido  CLIENTE--------------------
        public void filtroPedidoCliente(DataGridView dgv, string idPedido, string usuario)
        {

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    //MessageBox.Show(cvePedido);
                    da = new SqlDataAdapter(string.Format("SELECT detp.iddetalle_pedido, ped.idpedido AS '# Pedido', ped.aprobacionCliente AS 'Autorizado', us.nombre_usuario AS 'Usuario', us.nombre_real AS 'Nombre', ped.fecha_hora AS 'Fecha Creación', prod.nombre AS 'Producto', prod.precio_venta AS 'Precio venta', detp.cantidad AS 'Cantidad', detp.descuento AS 'Descuento', ped.comentarios, ped.impuesto, ped.total, mar.marca AS 'Marca', veh.modelo AS 'Modelo'  FROM detalle_pedido detp LEFT OUTER JOIN pedido ped ON ped.idpedido = detp.idpedido LEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto LEFT OUTER JOIN usuario us ON us.idusuario = ped.idusuarioCliente LEFT OUTER JOIN vehiculo veh ON veh.idvehiculo = detp.idvehiculo LEFT OUTER JOIN marca mar ON mar.idmarca = veh.idmarca WHERE ped.idpedido = '{0}' AND us.nombre_usuario = '{1}' AND detp.estado = 1 ORDER BY ped.fecha_hora desc;", idPedido, usuario), nuevacon);
                    nuevacon.Open();
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

        //---------------------------Llenar datos DGV Pedido Filtro Fechas  CLIENTE--------------------
        public void filtroFechaCliente(DataGridView dgv, string fechaInicio, string fechaFinal, string usuario)
        {

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    //MessageBox.Show(cvePedido);
                    da = new SqlDataAdapter(string.Format("SELECT detp.iddetalle_pedido, ped.idpedido AS '# Pedido', ped.aprobacionCliente AS 'Autorizado', us.nombre_usuario AS 'Usuario', us.nombre_real AS 'Nombre', ped.fecha_hora AS 'Fecha Creación', prod.nombre AS 'Producto', prod.precio_venta AS 'Precio venta', detp.cantidad AS 'Cantidad', detp.descuento AS 'Descuento', ped.comentarios, ped.impuesto, ped.total, mar.marca AS 'Marca', veh.modelo AS 'Modelo'  FROM detalle_pedido detp LEFT OUTER JOIN pedido ped ON ped.idpedido = detp.idpedido LEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto LEFT OUTER JOIN usuario us ON us.idusuario = ped.idusuarioCliente LEFT OUTER JOIN vehiculo veh ON veh.idvehiculo = detp.idvehiculo LEFT OUTER JOIN marca mar ON mar.idmarca = veh.idmarca WHERE us.idusuario = '{0}' AND ped.fecha_hora between '{1}' and '{2}' AND detp.estado = 1 ORDER BY ped.fecha_hora desc;", idUsuario(usuario), fechaInicio, fechaFinal ), nuevacon);
                    nuevacon.Open();
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


        //---------------------------Llenar datos DGV Pedido Filtro Nombre Cliente  CLIENTE--------------------
        public void filtroNombreCliente(DataGridView dgv, string nombreCliente, string usuario)
        {

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    //MessageBox.Show(cvePedido);
                    da = new SqlDataAdapter(string.Format("", nombreCliente, usuario), nuevacon);
                    nuevacon.Open();
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


        //---------------------------Llenar datos DGV Pedido Filtro # Pedido EMPLEADO--------------------
        public void filtroPedidoEmpleado(DataGridView dgv, string idPedido, string usuario)
        {

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    //MessageBox.Show(cvePedido);
                    da = new SqlDataAdapter(string.Format("SELECT detp.iddetalle_pedido, ped.idpedido AS '# Pedido', ped.aprobacionCliente AS 'Autorizado', us.nombre_usuario AS 'Usuario', us.nombre_real AS 'Nombre', ped.fecha_hora AS 'Fecha Creación', prod.nombre AS 'Producto', prod.precio_venta AS 'Precio venta', detp.cantidad AS 'Cantidad', detp.descuento AS 'Descuento', ped.comentarios, ped.impuesto, ped.total, mar.marca AS 'Marca', veh.modelo AS 'Modelo'  FROM detalle_pedido detp LEFT OUTER JOIN pedido ped ON ped.idpedido = detp.idpedido LEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto LEFT OUTER JOIN usuario us ON us.idusuario = ped.idusuarioVendedor LEFT OUTER JOIN vehiculo veh ON veh.idvehiculo = detp.idvehiculo LEFT OUTER JOIN marca mar ON mar.idmarca = veh.idmarca WHERE us.idusuario = '{0}' AND ped.idpedido = '{1}' AND detp.estado = 1 ORDER BY ped.fecha_hora desc;", idUsuario(usuario) ,idPedido), nuevacon);
                    nuevacon.Open();
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

        //---------------------------Llenar datos DGV Pedido Filtro Nombre Cliente EMPLEADO--------------------
        public void filtroNombreClienteEmpleado(DataGridView dgv, string nombreCliente, string usuario)
        {

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    //MessageBox.Show(cvePedido);
                    da = new SqlDataAdapter(string.Format("SELECT detp.iddetalle_pedido, ped.idpedido AS '# Pedido', ped.aprobacionCliente AS 'Autorizado', us.nombre_usuario AS 'Usuario', us.nombre_real AS 'Nombre', ped.fecha_hora AS 'Fecha Creación', prod.nombre AS 'Producto', prod.precio_venta AS 'Precio venta', detp.cantidad AS 'Cantidad', detp.descuento AS 'Descuento', ped.comentarios, ped.impuesto, ped.total, mar.marca AS 'Marca', veh.modelo AS 'Modelo'  FROM detalle_pedido detp LEFT OUTER JOIN pedido ped ON ped.idpedido = detp.idpedido LEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto LEFT OUTER JOIN usuario us ON us.idusuario = ped.idusuarioCliente LEFT OUTER JOIN vehiculo veh ON veh.idvehiculo = detp.idvehiculo LEFT OUTER JOIN marca mar ON mar.idmarca = veh.idmarca WHERE ped.idusuarioVendedor = '{0}' AND us.nombre_real LIKE '%{1}%' AND detp.estado = 1 ORDER BY ped.fecha_hora desc;", idUsuario(usuario), nombreCliente), nuevacon);
                    nuevacon.Open();
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

        //---------------------------Llenar datos DGV Pedido Filtro Nombre Usuario EMPLEADO--------------------
        public void filtroNombreUsuarioEmpleado(DataGridView dgv, string nombreUsuario, string usuario)
        {

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    //MessageBox.Show(cvePedido);
                    da = new SqlDataAdapter(string.Format("SELECT detp.iddetalle_pedido, ped.idpedido AS '# Pedido', ped.aprobacionCliente AS 'Autorizado', us.nombre_usuario AS 'Usuario', us.nombre_real AS 'Nombre', ped.fecha_hora AS 'Fecha Creación', prod.nombre AS 'Producto', prod.precio_venta AS 'Precio venta', detp.cantidad AS 'Cantidad', detp.descuento AS 'Descuento', ped.comentarios, ped.impuesto, ped.total, mar.marca AS 'Marca', veh.modelo AS 'Modelo'  FROM detalle_pedido detp LEFT OUTER JOIN pedido ped ON ped.idpedido = detp.idpedido LEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto LEFT OUTER JOIN usuario us ON us.idusuario = ped.idusuarioCliente LEFT OUTER JOIN vehiculo veh ON veh.idvehiculo = detp.idvehiculo LEFT OUTER JOIN marca mar ON mar.idmarca = veh.idmarca WHERE ped.idusuarioVendedor = '{0}' AND us.nombre_usuario LIKE '%{1}%' AND detp.estado = 1 ORDER BY ped.fecha_hora desc;", idUsuario(usuario), nombreUsuario), nuevacon);
                    nuevacon.Open();
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

        //---------------------------Llenar datos DGV Pedido Filtro Fecha EMPLEADO--------------------
        public void filtroFechaEmpleado(DataGridView dgv, string fechaInicio, string fechaFin, string usuario)
        {

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    //MessageBox.Show(cvePedido);
                    da = new SqlDataAdapter(string.Format("SELECT detp.iddetalle_pedido, ped.idpedido AS '# Pedido', ped.aprobacionCliente AS 'Autorizado', us.nombre_usuario AS 'Usuario', us.nombre_real AS 'Nombre', ped.fecha_hora AS 'Fecha Creación', prod.nombre AS 'Producto', prod.precio_venta AS 'Precio venta', detp.cantidad AS 'Cantidad', detp.descuento AS 'Descuento', ped.comentarios, ped.impuesto, ped.total, mar.marca AS 'Marca', veh.modelo AS 'Modelo'  FROM detalle_pedido detp LEFT OUTER JOIN pedido ped ON ped.idpedido = detp.idpedido LEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto LEFT OUTER JOIN usuario us ON us.idusuario = ped.idusuarioCliente LEFT OUTER JOIN vehiculo veh ON veh.idvehiculo = detp.idvehiculo LEFT OUTER JOIN marca mar ON mar.idmarca = veh.idmarca WHERE ped.idusuarioVendedor = '{0}' AND ped.fecha_hora between '{1}' and '{2}' AND detp.estado = 1 ORDER BY ped.fecha_hora desc;", idUsuario(usuario), fechaInicio, fechaFin), nuevacon);
                    nuevacon.Open();
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



        //---------------------------Llenar datos DGV Pedido al ACTUALIZAR--------------------
        public void datosPedidoActualizar(DataGridView dgv, DataTable dt, string idPedido)
        {

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    //MessageBox.Show(cvePedido);
                    da = new SqlDataAdapter(string.Format("SELECT prod.nombre AS 'Producto', CONCAT(mar.marca,'-',veh.modelo,'-', veh.anio) AS 'Vehiculo',  detp.cantidad AS 'Cantidad', prod.codigo AS 'Clave de producto', prod.descripcion AS 'Descripción', prod.precio_venta AS 'Precio de venta\n($)', detp.descuento AS 'Descuento\n(%)', prod.idproducto, veh.idvehiculo ,ped.comentarios AS 'Comentarios', ped.fecha_hora , ped.idusuarioVendedor, detp.iddetalle_pedido FROM detalle_pedido detp LEFT OUTER JOIN pedido ped ON ped.idpedido = detp.idpedido LEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto LEFT OUTER JOIN usuario us ON us.idusuario = ped.idusuarioCliente LEFT OUTER JOIN vehiculo veh ON veh.idvehiculo = detp.idvehiculo LEFT OUTER JOIN marca mar ON mar.idmarca = veh.idmarca WHERE ped.idpedido = '{0}' AND detp.estado = 1;", idPedido), nuevacon);
                    nuevacon.Open();
                    //dt = new DataTable();
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


        //----------------------------------ACTUALIZAR DATOS PEDIDO ----------------------------------------------
        public void actualizarDatosPedido(string idvehiculo, string cantidad, string descuento, string iddetalle_pedido, string comentarios, string idPedido, string impuesto, string total)
        {
            int i = 0;
            
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    nuevacon.Open();

                    Comando = new SqlCommand("UPDATE ped SET ped.comentarios = @comentarios, ped.impuesto = @impuesto, ped.total = @total FROM pedido ped WHERE ped.idpedido = @idpedido;", nuevacon);

                    Comando.Parameters.AddWithValue("@comentarios", comentarios);
                    Comando.Parameters.AddWithValue("@idpedido", Convert.ToInt32(idPedido));
                    Comando.Parameters.AddWithValue("@impuesto", Convert.ToDouble(impuesto));
                    Comando.Parameters.AddWithValue("@total", Convert.ToDouble(total));
                    Comando.ExecuteNonQuery();


                    Comando = new SqlCommand("UPDATE detp SET detp.idvehiculo = @idvehiculo, detp.cantidad = @cantidad, detp.descuento = @descuento FROM detalle_pedido detp WHERE detp.iddetalle_pedido = @iddetalle_pedido;", nuevacon);

                    Comando.Parameters.AddWithValue("@idvehiculo", Convert.ToInt32(idvehiculo));
                    Comando.Parameters.AddWithValue("@cantidad", Convert.ToInt32(cantidad));
                    Comando.Parameters.AddWithValue("@descuento", Convert.ToDouble(descuento));
                    Comando.Parameters.AddWithValue("@iddetalle_pedido", Convert.ToInt32(iddetalle_pedido));
                    



                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Datos del pedido actualizado correctamente");
                    }
                    else
                        MessageBox.Show("Datos del pedido no actualizados");



                    nuevacon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        //REGISTRAR PRODUCTO NUEVO AL MOMENTO DE ESTAR ACTUALIZANDO

        public int registrarDetallePedidoActualizar(string idProducto, string cantidad, string precio, string descuento, string idVehiculo, string idPedido, string comentarios, string impuesto, string total)
        {

            int i;
            
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {

                    nuevacon.Open();

                    Comando = new SqlCommand("UPDATE ped SET ped.comentarios = @comentarios, ped.impuesto = @impuesto, ped.total = @total FROM pedido ped WHERE ped.idpedido = @idpedido;", nuevacon);

                    Comando.Parameters.AddWithValue("@comentarios", comentarios);
                    Comando.Parameters.AddWithValue("@idpedido", Convert.ToInt32(idPedido));
                    Comando.Parameters.AddWithValue("@impuesto", Convert.ToDouble(impuesto));
                    Comando.Parameters.AddWithValue("@total", Convert.ToDouble(total));
                    Comando.ExecuteNonQuery();


                    Comando = new SqlCommand("INSERT INTO detalle_pedido (idpedido, idproducto, cantidad, precio, descuento, idvehiculo)\r\nVALUES (@idPedido,@idProducto, @cantidad, @precio, @descuento, @idVehiculo);", nuevacon);

                    Comando.Parameters.AddWithValue("@idPedido", Convert.ToInt32(idPedido));
                    Comando.Parameters.AddWithValue("@idProducto", Convert.ToInt32(idProducto));
                    Comando.Parameters.AddWithValue("@cantidad", Convert.ToInt32(cantidad));
                    Comando.Parameters.AddWithValue("@precio", Convert.ToDouble(precio));
                    Comando.Parameters.AddWithValue("@descuento", Convert.ToDouble(descuento));
                    Comando.Parameters.AddWithValue("@idVehiculo", Convert.ToInt32(idVehiculo));



                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevacon.Close();
                    if (i == 1)
                    {
                        actualizarStock(idProducto, cantidad);
                       
                        
                    }
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar pedido");
                }
                return -1;
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error registrar pedido: " + EX.Message);
            }
            return -1;

        }

        //QUITAR PIEZA DE PEDIDO PASAR ESTADO = 0 EN ACTUALIZAR PEDIDO

        public int eliminarProductoPedido(string iddetalle_pedido)
        {

            int i;

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {

                    nuevacon.Open();

                    Comando = new SqlCommand("UPDATE detp SET detp.estado = 0 FROM detalle_pedido detp WHERE detp.iddetalle_pedido = @iddetalle_pedido;", nuevacon);

                    Comando.Parameters.AddWithValue("@iddetalle_pedido", Convert.ToInt32(iddetalle_pedido));
                    Comando.ExecuteNonQuery();

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevacon.Close();
                    if (i == 1)
                    {
                        MessageBox.Show("Producto eliminado correctamente");
                    }
                    else
                        MessageBOX.SHowDialog(2, "Problemas al eliminar el producto");
                }
                return -1;
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error al eliminar el producto: " + EX.Message);
            }
            return -1;

        }

        //OBETER DATOS DEL PRODUCTO QUE SE ESTA ACTUALIZANDO
        public string[] datosProductoActualizar(string iddetalle_pedido)
        {
            string[] producto = new string[6];

            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();

                    Comando = new SqlCommand(string.Format("SELECT detp.idproducto, detp.cantidad, veh.modelo, veh.anio, mar.marca, detp.descuento FROM detalle_pedido detp LEFT OUTER JOIN pedido ped ON ped.idpedido = detp.idpedido LEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto LEFT OUTER JOIN usuario us ON us.idusuario = ped.idusuarioCliente LEFT OUTER JOIN vehiculo veh ON veh.idvehiculo = detp.idvehiculo LEFT OUTER JOIN marca mar ON mar.idmarca = veh.idmarca WHERE detp.iddetalle_pedido = '{0}' AND detp.estado = 1;", iddetalle_pedido), nuevaConexion);
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read())
                    {
                        producto[0] = Lector["idproducto"].ToString();//idproducto
                        producto[1] = Lector["cantidad"].ToString();//cantidad
                        producto[2] = Lector["modelo"].ToString();//modelo
                        producto[3] = Lector["anio"].ToString();//anio
                        producto[4] = Lector["marca"].ToString();//marca
                        producto[5] = Lector["descuento"].ToString();//descuento
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

        //OBETER NOMBRE DEL CLIENTE AL ENTRAR A ACTUALIZAR UN PEDIDO 
        public string nombreCliente(string idPedido)
        {
            string cliente = string.Empty;

            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();

                    Comando = new SqlCommand(string.Format("SELECT us.nombre_usuario FROM detalle_pedido detp LEFT OUTER JOIN pedido ped ON ped.idpedido = detp.idpedido LEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto LEFT OUTER JOIN usuario us ON us.idusuario = ped.idusuarioCliente LEFT OUTER JOIN vehiculo veh ON veh.idvehiculo = detp.idvehiculo LEFT OUTER JOIN marca mar ON mar.idmarca = veh.idmarca WHERE ped.idpedido = '{0}' AND us.estado = 1;", idPedido), nuevaConexion);
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read())
                    {
                        cliente = Lector["nombre_usuario"].ToString();//Nombre Cliente
                    }
                    Lector.Close();

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return cliente;
        }

        //OBETER DATOS PERSONALES DEL USUARIO
        public string[] datosPersonalesUsuario(string usuario)
        {
            string[] datos = new string[9];

            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();

                    
                    
                    Comando = new SqlCommand(string.Format("SELECT us.nombre_real, us.colonia, us.calle, us.noExt, us.noInt, us.cp, us.ciudad, us.telefono, us.correo FROM usuario us WHERE us.nombre_usuario = '{0}' AND us.estado =1;", usuario), nuevaConexion);
                    

                    Lector = Comando.ExecuteReader();
                    while (Lector.Read())
                    {
                        datos[0] = Lector["nombre_real"].ToString();
                        datos[1] = Lector["colonia"].ToString();
                        datos[2] = Lector["calle"].ToString();
                        datos[3] = Lector["noExt"].ToString();
                        datos[4] = Lector["noInt"].ToString();
                        datos[5] = Lector["cp"].ToString();
                        datos[6] = Lector["ciudad"].ToString();
                        datos[7] = Lector["telefono"].ToString();
                        datos[8] = Lector["correo"].ToString();
                    }
                    Lector.Close();

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return datos;
        }

        //OBETER DATOS FISCALES DEL USUARIO
        public string[] datosFiscalesUsuario(string usuario)
        {
            string[] datos = new string[10];

            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();



                    Comando = new SqlCommand(string.Format("SELECT dfc.nombre, dfc.colonia, dfc.calle, dfc.noExt, dfc.noInt, dfc.cp, dfc.ciudad, dfc.telefono, dfc.correo, dfc.cif FROM usuario us LEFT OUTER JOIN datos_fiscales_cliente dfc ON dfc.iddatos_fiscales_cli = us.iddatos_fiscales_cli WHERE us.nombre_usuario = '{0}' AND us.estado =1;", usuario), nuevaConexion);


                    Lector = Comando.ExecuteReader();
                    while (Lector.Read())
                    {
                        datos[0] = Lector["nombre"].ToString();
                        datos[1] = Lector["colonia"].ToString();
                        datos[2] = Lector["calle"].ToString();
                        datos[3] = Lector["noExt"].ToString();
                        datos[4] = Lector["noInt"].ToString();
                        datos[5] = Lector["cp"].ToString();
                        datos[6] = Lector["ciudad"].ToString();
                        datos[7] = Lector["telefono"].ToString();
                        datos[8] = Lector["correo"].ToString();
                        datos[9] = Lector["cif"].ToString();
                    }
                    Lector.Close();

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return datos;
        }



        //----------------------------------ACTUALIZAR CONTRASENIA----------------------------------------------
        public void actualizarContrasenia(string usuario, string contrasenia)
        {

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    nuevacon.Open();
                        string contraHash = BC.HashPassword(contrasenia);
                        
                        Comando = new SqlCommand(string.Format("UPDATE USUARIO SET contrasenia = '{0}' WHERE nombre_usuario = '{1}';", contraHash, usuario), nuevacon);
                        Comando.ExecuteNonQuery();

                        

                        
                    nuevacon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        //ACTUALIZAR DATOS PERSONALES DE UN USUARIO

        public int actualizarDatosPersonales(int actualizarContrasenia,string contrasenia, string nombre_usuario, string nombre_real, string colonia, string calle, string noExt, string noInt, string cp, string ciudad, string telefono, string correo)
        {

            int i;

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {

                    nuevacon.Open();

                    Comando = new SqlCommand("UPDATE us SET us.nombre_real = @nombre_real, us.colonia = @colonia, us.calle = @calle, us.noExt = @noExt, us.noInt = @noInt, us.cp = @cp, us.ciudad = @ciudad, us.telefono = @telefono, us.correo = @correo FROM usuario us WHERE us.nombre_usuario = @nombre_usuario AND estado =1;", nuevacon);

                    Comando.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                    Comando.Parameters.AddWithValue("@nombre_real", nombre_real);
                    Comando.Parameters.AddWithValue("@colonia", colonia);
                    Comando.Parameters.AddWithValue("@calle", calle);
                    Comando.Parameters.AddWithValue("@noExt", noExt);
                    Comando.Parameters.AddWithValue("@noInt", noInt);
                    Comando.Parameters.AddWithValue("@cp", cp);
                    Comando.Parameters.AddWithValue("@ciudad", ciudad);
                    Comando.Parameters.AddWithValue("@telefono", telefono);
                    Comando.Parameters.AddWithValue("@correo", correo);
                    Comando.ExecuteNonQuery();

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevacon.Close();
                    if (i == 1)
                    {
                        if (actualizarContrasenia == 1)
                        {
                            this.actualizarContrasenia(nombre_usuario, contrasenia);
                        }
                        else { }
                        MessageBox.Show("Datos personales actualizados");
                    }
                    else
                        MessageBOX.SHowDialog(2, "Problemas al actualizar datos personales");
                }
                return -1;
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error actualizar datos personales: " + EX.Message);
            }
            return -1;

        }

        //ACTUALIZAR DATOS FISCALES DE UN USUARIO

        public int actualizarDatosFiscales(string nombre_usuario, string nombre, string cif, string colonia, string calle, string noExt, string noInt, string cp, string ciudad, string telefono, string correo)
        {

            int i;

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {

                    nuevacon.Open();

                    Comando = new SqlCommand("UPDATE dfc SET dfc.nombre = @nombre, dfc.cif = @cif, dfc.colonia = @colonia, dfc.calle = @calle, dfc.noExt = @noExt, dfc.noInt = @noInt, dfc.cp = @cp, dfc.ciudad = @ciudad, dfc.telefono = @telefono, dfc.correo = @correo FROM usuario us LEFT OUTHER JOIN datos_fiscales_cliente dfc ON dfc.iddatos_fiscales_cli = us.iddatos_fiscales_cli WHERE us.nombre_usuario = @nombre_usuario AND us.estado =1;", nuevacon);

                    Comando.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                    Comando.Parameters.AddWithValue("@nombre", nombre);
                    Comando.Parameters.AddWithValue("@cif", cif);
                    Comando.Parameters.AddWithValue("@colonia", colonia);
                    Comando.Parameters.AddWithValue("@calle", calle);
                    Comando.Parameters.AddWithValue("@noExt", noExt);
                    Comando.Parameters.AddWithValue("@noInt", noInt);
                    Comando.Parameters.AddWithValue("@cp", cp);
                    Comando.Parameters.AddWithValue("@ciudad", ciudad);
                    Comando.Parameters.AddWithValue("@telefono", telefono);
                    Comando.Parameters.AddWithValue("@correo", correo);
                    Comando.ExecuteNonQuery();

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevacon.Close();
                    if (i == 1)
                    {

                        MessageBox.Show("Datos fiscales actualizados");
                    }
                    else
                        MessageBOX.SHowDialog(2, "Problemas al actualizar datos fiscales");
                }
                return -1;
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error actualizar datos fiscales: " + EX.Message);
            }
            return -1;

        }

        //OBTENER LA INFORMACI[ON DE LOS USUARIOS REGISTRADOS EN LA BASE DE DATOS PARA LLENAR EL CMB DE USUARIOS PARA MODIFICAR
        //---------------- DATOS DE USUARIOS REGISTRADOS
        public DataSet Usuarios()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT idusuario, nombre_usuario, idrol FROM usuario WHERE estado = 1;", nuevaConexion);
                    dataAdapter.Fill(dataSet, "USUARIO");

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //ACTUALIZAR DATOS PERSONALES DE UN USUARIO

        public int actualizarDatosPersonalesAdmin(int actualizarContrasenia, string contrasenia, string nombre_usuario, string nombre_real, string colonia, string calle, string noExt, string noInt, string cp, string ciudad, string telefono, string correo, string idrol)
        {

            int i;

            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {

                    nuevacon.Open();

                    Comando = new SqlCommand("UPDATE us SET us.nombre_real = @nombre_real, us.colonia = @colonia, us.calle = @calle, us.noExt = @noExt, us.noInt = @noInt, us.cp = @cp, us.ciudad = @ciudad, us.telefono = @telefono, us.correo = @correo, us.idrol = @idrol FROM usuario us WHERE us.nombre_usuario = @nombre_usuario AND estado =1;", nuevacon);

                    Comando.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                    Comando.Parameters.AddWithValue("@nombre_real", nombre_real);
                    Comando.Parameters.AddWithValue("@colonia", colonia);
                    Comando.Parameters.AddWithValue("@calle", calle);
                    Comando.Parameters.AddWithValue("@noExt", noExt);
                    Comando.Parameters.AddWithValue("@noInt", noInt);
                    Comando.Parameters.AddWithValue("@cp", cp);
                    Comando.Parameters.AddWithValue("@ciudad", ciudad);
                    Comando.Parameters.AddWithValue("@telefono", telefono);
                    Comando.Parameters.AddWithValue("@correo", correo);
                    Comando.Parameters.AddWithValue("@idrol", idrol);
                    Comando.ExecuteNonQuery();

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevacon.Close();
                    if (i == 1)
                    {
                        if (actualizarContrasenia == 1)
                        {
                            this.actualizarContrasenia(nombre_usuario, contrasenia);
                        }
                        else { }
                        MessageBox.Show("Datos personales actualizados");
                    }
                    else
                        MessageBOX.SHowDialog(2, "Problemas al actualizar datos personales");
                }
                return -1;
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error actualizar datos personales: " + EX.Message);
            }
            return -1;

        }


        public void generarReporteVentas(string ruta, string fecha1, string fecha2)
        {
            File.WriteAllBytes(ruta, Properties.Resources.Reporte);

            BDExcel bDExcel = new ();

            bDExcel.generarExcelTest(ruta, fecha1, fecha2);
        }

        //----------------------GENERAR PDF FACTURA
        public void generarFactura(string idPedido, DataGridView dgvDatosFactura)
        {
            try
            {
                SaveFileDialog fileRoute = new SaveFileDialog();
                fileRoute.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                fileRoute.Title = "FACTURA";
                fileRoute.CheckPathExists = true;
                fileRoute.DefaultExt = "pdf";
                fileRoute.Filter = "PDF files (*.pdf)|*.pdf";
                fileRoute.FilterIndex = 2;
                fileRoute.RestoreDirectory = true;
                fileRoute.FileName = "Factura_Pedido_" + idPedido;


                if (fileRoute.ShowDialog() == DialogResult.OK)
                {
                    if (!File.Exists(fileRoute.FileName))
                    {
                        iText.Kernel.Pdf.PdfWriter pdfWriter = new iText.Kernel.Pdf.PdfWriter(fileRoute.FileName);

                        string ruta = Application.StartupPath + "\\Factura.pdf";
                        File.WriteAllBytes(ruta, Properties.Resources.Factura);


                        iText.Kernel.Pdf.PdfReader pdfReader = new iText.Kernel.Pdf.PdfReader(Application.StartupPath + "\\Factura.pdf");

                        iText.Kernel.Pdf.PdfDocument pdfdoc = new iText.Kernel.Pdf.PdfDocument(pdfReader, pdfWriter);


                        datosFacturaPDF(dgvDatosFactura, idPedido);

                        int NumeroFila = NumeroFilas(idPedido);


                        PdfCanvas canvas = new PdfCanvas(pdfdoc.GetFirstPage());
                        PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                        int y = 0;//633
                        int x = 0;//109
                        byte[] pdf;
                        string correoCliente = dgvDatosFactura.Rows[0].Cells[14].Value.ToString();

                        string direccion = dgvDatosFactura.Rows[0].Cells[8].Value.ToString() +" "+ dgvDatosFactura.Rows[0].Cells[9].Value.ToString() +" "+
                           dgvDatosFactura.Rows[0].Cells[10].Value.ToString();

                        string direccion2 = dgvDatosFactura.Rows[0].Cells[11].Value.ToString() +" "+ 
                            dgvDatosFactura.Rows[0].Cells[12].Value.ToString() +" "+ dgvDatosFactura.Rows[0].Cells[13].Value.ToString();

                        string direccion3 = dgvDatosFactura.Rows[0].Cells[14].Value.ToString() +" "+ dgvDatosFactura.Rows[0].Cells[15].Value.ToString();

                        string cif = "CIF: " + dgvDatosFactura.Rows[0].Cells[16].Value.ToString();

                        string impuestos = Convert.ToString( (Convert.ToDouble(dgvDatosFactura.Rows[0].Cells[6].Value.ToString()) - Convert.ToDouble(dgvDatosFactura.Rows[0].Cells[5].Value.ToString())));
                        decimal impuestosX = Convert.ToDecimal(impuestos);
                        decimal subtotal = Convert.ToDecimal(dgvDatosFactura.Rows[0].Cells[5].Value.ToString());

                        //"\r\n

                        //ORIGEN
                        //canvas.BeginText().SetFontAndSize(font, 12)
                        //         .MoveText(x + 463, y + 214)//470,190,
                        //         .ShowText("Nombre")
                        //         .EndText();

                        //NUMERO FACTURA
                        canvas.BeginText().SetFontAndSize(font, 18)
                                 .MoveText(x + 242, y + 679)
                                 .ShowText(dgvDatosFactura.Rows[0].Cells[1].Value.ToString())
                                 .EndText();

                        //DATOS FISCALES CLIENTE-NOMBRE
                        canvas.BeginText().SetFontAndSize(font, 12)
                                .MoveText(x + 18, y + 607)
                                .ShowText(dgvDatosFactura.Rows[0].Cells[7].Value.ToString())
                                .EndText();
                        //DATOS FISCALES CLIENTE-DIRECCION 1
                        canvas.BeginText().SetFontAndSize(font, 12)
                                .MoveText(x + 18, y + 592)
                                .ShowText(direccion)
                                .EndText();

                        //DATOS FISCALES CLIENTE-DIRECCION 2
                        canvas.BeginText().SetFontAndSize(font, 12)
                                .MoveText(x + 18, y + 577)
                                .ShowText(direccion2)
                                .EndText();

                        //DATOS FISCALES CLIENTE-DIRECCION 3
                        canvas.BeginText().SetFontAndSize(font, 12)
                                .MoveText(x + 18, y + 562)
                                .ShowText(direccion3)
                                .EndText();

                        //DATOS FISCALES CIF
                        canvas.BeginText().SetFontAndSize(font, 12)
                                .MoveText(x + 18, y + 547)
                                .ShowText(cif)
                                .EndText();

                        //SUBTOTAL
                        canvas.BeginText().SetFontAndSize(font, 12)
                                .MoveText(x + 463, y + 214)
                                .ShowText(decimal.Round(subtotal,2).ToString())
                                .EndText();

                        //IMPUESTOS
                        canvas.BeginText().SetFontAndSize(font, 12)
                                .MoveText(x + 463, y + 194)
                                .ShowText(decimal.Round(impuestosX,2).ToString())
                                .EndText();

                        //TOTAL
                        canvas.BeginText().SetFontAndSize(font, 16)
                                .MoveText(x + 463, y + 160)
                                .ShowText("$" + dgvDatosFactura.Rows[0].Cells[6].Value.ToString())
                                .EndText();
                        
                        //CADENA DE SELLO
                        canvas.BeginText().SetFontAndSize(font, 9)
                                .MoveText(x + 300, y + 100)
                                .ShowText("Cadena de sello: ")
                                .EndText();

                        generarQr(dgvDatosFactura.Rows[0].Cells[1].Value.ToString());
                        iText.IO.Image.ImageData img = iText.IO.Image.ImageDataFactory.Create(Application.StartupPath + "\\tempQr.png");
                        canvas.AddImageAt(img, Convert.ToSingle(x + 490), Convert.ToSingle(y + 25), false);
                        File.Delete(Application.StartupPath + "\\tempQr.png");

                        string producto;
                        for (int count = 0; count < NumeroFila; count++)
                        {
                            producto = dgvDatosFactura.Rows[count].Cells[17].Value.ToString() + " " + dgvDatosFactura.Rows[count].Cells[18].Value.ToString() + " " +
                            dgvDatosFactura.Rows[count].Cells[19].Value.ToString() + " " + dgvDatosFactura.Rows[count].Cells[20].Value.ToString();

                            

                            //PRODUCTOS
                            canvas.BeginText().SetFontAndSize(font, 9)
                                    .MoveText(x + 10, y + 465)
                                    .SetFillColor(ColorConstants.BLACK)
                                    .ShowText(producto)
                                    .EndText();

                            //CANTIDAD
                            canvas.BeginText().SetFontAndSize(font, 10)
                                    .MoveText(x + 300, y + 465)
                                    .SetFillColor(ColorConstants.BLACK)
                                    .ShowText(dgvDatosFactura.Rows[count].Cells[21].Value.ToString())
                                    .EndText(); 

                            //PRECIO POR PRODUCTO
                            canvas.BeginText().SetFontAndSize(font, 10)
                                    .MoveText(x + 375, y + 465)
                                    .SetFillColor(ColorConstants.BLACK)
                                    .ShowText(dgvDatosFactura.Rows[count].Cells[22].Value.ToString())
                                    .EndText(); 

                            //DESCUENTO POR PRODUCTO
                            canvas.BeginText().SetFontAndSize(font, 10)
                                    .MoveText(x + 470, y + 465)
                                    .SetFillColor(ColorConstants.BLACK)
                                    .ShowText(dgvDatosFactura.Rows[count].Cells[23].Value.ToString() + "%")
                                    .EndText();

                            decimal totalXProd = Convert.ToDecimal(dgvDatosFactura.Rows[count].Cells[24].Value.ToString());
                            //TOTAL POR PRODUCTO CON DESCUENTO
                            canvas.BeginText().SetFontAndSize(font, 10)
                                    .MoveText(x + 540, y + 465)
                                    .SetFillColor(ColorConstants.BLACK)
                                    .ShowText(decimal.Round(totalXProd,2).ToString())
                                    .EndText();

                            
                            y -= 22;
                        }

                   
                        pdfdoc.Close();

                        pdf = File.ReadAllBytes(fileRoute.FileName);

                        

                        //MessageBOX.SHowDialog(3, "PDF creado exitosamente 1");

                    }

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrió un problema FACTURA \nMayor Detalle:\n" + err.Message + "\n\n*Si muestra en ingles, proceda a traducirlo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        //---------------------------GENERAR CODIGO QR PARA PDF--------------------
        public void generarQr(string cadena)
        {


            try
            {

            QRCodeGenerator qrGenerador = new QRCodeGenerator();
            QRCodeData qrDatos = qrGenerador.CreateQrCode(cadena, QRCodeGenerator.ECCLevel.H);
            QRCode qrCodigo = new QRCode(qrDatos);

            Bitmap qrImagen = qrCodigo.GetGraphic(3, System.Drawing.Color.Black, System.Drawing.Color.White, true);

            qrImagen.Save(Application.StartupPath + "\\tempQr.png", System.Drawing.Imaging.ImageFormat.Png);
            qrImagen.Dispose();

            qrImagen.Dispose();

            //MessageBox.Show("Etiqueta Generada!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrió un problema\nMayor Detalle:\n" + err.Message + "\n\n*Si muestra en ingles, proceda a traducirlo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

}

        public int registrarFactura(string idPedido,string iddatos_fiscales_emp, string iddatos_fiscales_cliente, string num_factura, string fecha_emision, string fact_sinIVA, string descuento, string fact_neto, string comentario, DataGridView dgvDatosFactura)
        {

            int i;
            int idfactura = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {

                    nuevacon.Open();

                    Comando = new SqlCommand("INSERT INTO factura (iddatos_fiscales_emp, iddatos_fiscales_cliente, num_factura, fecha_emision, fact_sinIVA, descuento, fact_neto, comentario) VALUES (@iddatos_fiscales_emp, @iddatos_fiscales_cliente, @num_factura, @fecha_emision, @fact_sinIVA, @descuento, @fact_neto, @comentario);", nuevacon);

                    Comando.Parameters.AddWithValue("@iddatos_fiscales_emp", Convert.ToInt32(iddatos_fiscales_emp));
                    Comando.Parameters.AddWithValue("@iddatos_fiscales_cliente", Convert.ToInt32(iddatos_fiscales_cliente));
                    Comando.Parameters.AddWithValue("@num_factura", num_factura);
                    Comando.Parameters.AddWithValue("@fecha_emision", fecha_emision);
                    Comando.Parameters.AddWithValue("@fact_sinIVA",Convert.ToDouble(fact_sinIVA));
                    Comando.Parameters.AddWithValue("@descuento", Convert.ToDouble(descuento));
                    Comando.Parameters.AddWithValue("@fact_neto", Convert.ToDouble(fact_neto));
                    Comando.Parameters.AddWithValue("@comentario", comentario);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();


                    Comando = new SqlCommand("SELECT TOP 1 idfactura FROM factura WHERE estado = 1 ORDER BY idfactura desc;", nuevacon);
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read()) { idfactura = Convert.ToInt32(Lector["idfactura"].ToString()); }
                    Lector.Close();

                    Comando = new SqlCommand("UPDATE pedido SET idfactura = @idfactura WHERE idpedido = @idpedido;", nuevacon);

                    Comando.Parameters.AddWithValue("@idfactura", idfactura);
                    Comando.Parameters.AddWithValue("@idpedido", Convert.ToInt32(idPedido));

                    Comando.ExecuteNonQuery();


                    nuevacon.Close();
                    if (i == 1)
                    {
                        MessageBox.Show("Factura registrada correctamente");
                        generarFactura(idPedido, dgvDatosFactura);
                    }
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registrar la factura");
                }
                return -1;
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error registrar factura: " + EX.Message);
            }
            return -1;

        }




    }
}

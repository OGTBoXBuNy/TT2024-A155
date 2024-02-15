using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//EXCEL
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using System.Data.SqlClient;

namespace TT2024_A155
{
    internal class BDExcel
    {
        private SqlCommand Comando;
        private SqlDataReader Lector;

        private Style GetStyleHeader(Workbook wb)
        {
            Style style = wb.Styles.Add("MiEstilo");
            style.Font.Bold = true;
            style.HorizontalAlignment = XlHAlign.xlHAlignLeft;
            //style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
            //style.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);

            return style;
        }


        public void generarExcelTest(string ruta, string fecha1, string fecha2)
        {

            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            

            Workbook workbook = excelApp.Workbooks.Open(ruta);

            Worksheet worksheet = (Worksheet)workbook.Sheets[1];

            

            int totalRegistrosExportar;
            DateTime hoy = DateTime.Today;

            worksheet.Cells[2, 13] = hoy.ToString("dd-MM-yyyy");//FECHA CREACION DEL REPORTE


            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int celdaContenido = 9;



                Comando = new SqlCommand("SELECT Count(detp.iddetalle_pedido) AS 'TOTAL DE REGISTROS A EXPORTAR' FROM detalle_pedido detp LEFT OUTER JOIN pedido ped ON ped.idpedido = detp.idpedido WHERE ped.fecha_hora BETWEEN @fecha1 AND @fecha2 AND ped.estado =1;", nuevaConexion);

                Comando.Parameters.AddWithValue("@fecha1", fecha1);
                Comando.Parameters.AddWithValue("@fecha2", fecha2);
                totalRegistrosExportar = Int32.Parse(Comando.ExecuteScalar().ToString());
                MessageBox.Show("El número de registros encontrados son: " + totalRegistrosExportar.ToString() + "\n" + "Antes de dar clic en Aceptar revisa que tu conexión a internet sea estable, para evitar error a la hora de generar", "Generar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                Comando = new SqlCommand("SELECT ped.idpedido, ped.fecha_hora, ped.aprobacionCliente, us.nombre_usuario, us.nombre_real, prod.nombre, detp.cantidad, mar.marca, veh.modelo, veh.anio, prod.precio_venta, detp.descuento, ((prod.precio_venta) *((100 - detp.descuento)/100)) AS 'Precio Final', fact.num_factura, fact.fact_sinIVA, fact.fact_neto  FROM detalle_pedido detp LEFT OUTER JOIN pedido ped ON ped.idpedido = detp.idpedido LEFT OUTER JOIN producto prod ON prod.idproducto = detp.idproducto LEFT OUTER JOIN usuario us ON us.idusuario = ped.idusuarioCliente LEFT OUTER JOIN vehiculo veh ON veh.idvehiculo = detp.idvehiculo LEFT OUTER JOIN marca mar ON mar.idmarca = veh.idmarca LEFT OUTER JOIN factura fact ON fact.idfactura = ped.idfactura WHERE ped.fecha_hora BETWEEN @fecha1 AND @fecha2 AND detp.estado = 1;", nuevaConexion);

                Comando.Parameters.AddWithValue("@fecha1", fecha1);
                Comando.Parameters.AddWithValue("@fecha2", fecha2);

                Lector = Comando.ExecuteReader();

                for (int r = 0; r < totalRegistrosExportar; r++)

                {
                    Lector.Read();
                    
                    worksheet.Cells[celdaContenido, 1] = Lector["idpedido"].ToString();

                    worksheet.Cells[celdaContenido, 2] = Lector["fecha_hora"].ToString().Substring(0,10);

                    if(bool.Parse(Lector["aprobacionCliente"].ToString()))
                        worksheet.Cells[celdaContenido, 3] = "Revisado";
                    else
                        worksheet.Cells[celdaContenido, 3] = "En Revisión";

                    worksheet.Cells[celdaContenido, 4] = Lector["nombre_usuario"].ToString();

                    worksheet.Cells[celdaContenido, 5] = Lector["nombre_real"].ToString();

                    worksheet.Cells[celdaContenido, 6] = Lector["nombre"].ToString();

                    worksheet.Cells[celdaContenido, 7] = Lector["cantidad"].ToString();

                    worksheet.Cells[celdaContenido, 8] = Lector["marca"].ToString();

                    worksheet.Cells[celdaContenido, 9] = Lector["modelo"].ToString();

                    worksheet.Cells[celdaContenido, 10] = Lector["anio"].ToString();

                    worksheet.Cells[celdaContenido, 11] = Lector["precio_venta"].ToString();

                    worksheet.Cells[celdaContenido, 12] = Lector["descuento"].ToString();

                    worksheet.Cells[celdaContenido, 13] = Lector["Precio Final"].ToString();

                    worksheet.Cells[celdaContenido, 14] = Lector["num_factura"].ToString();

                    worksheet.Cells[celdaContenido, 15] = Lector["fact_sinIVA"].ToString();

                    worksheet.Cells[celdaContenido, 16] = Lector["fact_neto"].ToString();


                    
                    celdaContenido++;
                }


                Lector.Close();
                nuevaConexion.Close();
            }

            //var style = GetStyleHeader(workbook);
            //excelApp.Range[excelApp.Cells[8, 1], excelApp.Cells[totalRegistrosExportar + 8, 16]].Style = style;

            worksheet.Range["A:P"].Columns.AutoFit();



            //workbook.Close();
            //SaveFileDialog guarda = new();
            //guarda.Filter = "Libro de Excel|*.xlsx";
            //guarda.Title = "Guardar Reporte";
            //guarda.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //if (guarda.ShowDialog() == DialogResult.OK)
            //{
            //    workbook.SaveAs(guarda.FileName);
            //    MessageBOX.SHowDialog(3, "Archivo Guardado");
            //}

            //string tempFile = System.IO.Path.GetTempFileName() + ".xls";
            //workbook.SaveAs(tempFile);

        }


    }

    
}

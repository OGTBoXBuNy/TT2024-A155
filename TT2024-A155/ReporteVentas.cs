using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Diseño
using MaterialSkin.Controls;

namespace TT2024_A155
{
    public partial class ReporteVentas : MaterialForm
    {
        public ReporteVentas()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
        }
        BD Consulta = new();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Fecha_inicio = dtpFechaInicio.Value.Year.ToString() + "-" + dtpFechaInicio.Value.Month.ToString() + "-" + dtpFechaInicio.Value.Day.ToString();
            string Fecha_Final = dtpFechaFinal.Value.Year.ToString() + "-" + dtpFechaFinal.Value.Month.ToString() + "-" + dtpFechaFinal.Value.Day.ToString();

            string ruta = Application.StartupPath + "Reporte.xlsx";
            if (ruta != "")
            {
                Consulta.generarReporteVentas(ruta, Fecha_inicio, Fecha_Final);
                //Consulta.generarReporte(ruta, Fecha_inicio, Fecha_Final);
                string usuario = lblUsuario.Text;
                string descripcionLog = "El usuario : " + usuario + " generó el reporte de ventas de la fecha: " + Fecha_inicio + "hasta: " + Fecha_Final + " el día: " + DateTime.Now.ToString();
                Consulta.Log(usuario, "", descripcionLog, "20");
                this.Close();
            }
        }
    }
}

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

namespace TT2024_A155
{
    public partial class ReporteVentas : Form
    {
        public ReporteVentas()
        {
            InitializeComponent();
        }
        BD Consulta = new();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Fecha_inicio = dtpFechaInicio.Value.Year.ToString() + "-" + dtpFechaInicio.Value.Month.ToString() + "-" + dtpFechaInicio.Value.Day.ToString();
            string Fecha_Final = dtpFechaFinal.Value.Year.ToString() + "-" + dtpFechaFinal.Value.Month.ToString() + "-" + dtpFechaFinal.Value.Day.ToString();

            string ruta = Application.StartupPath + "Reporte.xlsx";
            if (ruta != "")
            {
                Consulta.test(ruta, Fecha_inicio, Fecha_Final);
                //Consulta.generarReporte(ruta, Fecha_inicio, Fecha_Final);
                this.Close();
            }
        }
    }
}

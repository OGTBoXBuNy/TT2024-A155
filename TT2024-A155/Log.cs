using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT2024_A155
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }
        BD Consulta = new();
        private void Log_Load(object sender, EventArgs e)
        {
            //Carga los datos de los nombres de los tipos de cambios registrados
            cmbTipo.DataSource = Consulta.cLogTipo().Tables[0].DefaultView;
            cmbTipo.ValueMember = "tipo";
            Consulta.LogLoad(dgvLog);
        }

        private void txtFiltroPedido_KeyUp(object sender, KeyEventArgs e)
        {
            string idpedido = txtFiltroPedido.Text.Trim();
            string nomUsuario = txtFiltroNomUsuario.Text.Trim();
            string nomReal = txtFiltroNomReal.Text.Trim();
            string tipo = cmbTipo.Text.Trim();
            string fechaInicial = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string fechaFinal = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();

            Consulta.LogBuscar(dgvLog, idpedido, nomUsuario, nomReal, tipo, fechaInicial, fechaFinal);
        }

        private void txtFiltroNomUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            string idpedido = txtFiltroPedido.Text.Trim();
            string nomUsuario = txtFiltroNomUsuario.Text.Trim();
            string nomReal = txtFiltroNomReal.Text.Trim();
            string tipo = cmbTipo.Text.Trim();
            string fechaInicial = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string fechaFinal = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();

            Consulta.LogBuscar(dgvLog, idpedido, nomUsuario, nomReal, tipo, fechaInicial, fechaFinal);
        }

        private void txtFiltroNomReal_KeyUp(object sender, KeyEventArgs e)
        {
            string idpedido = txtFiltroPedido.Text.Trim();
            string nomUsuario = txtFiltroNomUsuario.Text.Trim();
            string nomReal = txtFiltroNomReal.Text.Trim();
            string tipo = cmbTipo.Text.Trim();
            string fechaInicial = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string fechaFinal = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();

            Consulta.LogBuscar(dgvLog, idpedido, nomUsuario, nomReal, tipo, fechaInicial, fechaFinal);
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idpedido = txtFiltroPedido.Text.Trim();
            string nomUsuario = txtFiltroNomUsuario.Text.Trim();
            string nomReal = txtFiltroNomReal.Text.Trim();
            string tipo = cmbTipo.Text.Trim();
            string fechaInicial = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string fechaFinal = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();

            Consulta.LogBuscar(dgvLog, idpedido, nomUsuario, nomReal, tipo, fechaInicial, fechaFinal);
        }

        private void Fecha_in_ValueChanged(object sender, EventArgs e)
        {
            string idpedido = txtFiltroPedido.Text.Trim();
            string nomUsuario = txtFiltroNomUsuario.Text.Trim();
            string nomReal = txtFiltroNomReal.Text.Trim();
            string tipo = cmbTipo.Text.Trim();
            string fechaInicial = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string fechaFinal = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();

            Consulta.LogBuscar(dgvLog, idpedido, nomUsuario, nomReal, tipo, fechaInicial, fechaFinal);
        }

        private void Fecha_Fin_ValueChanged(object sender, EventArgs e)
        {
            string idpedido = txtFiltroPedido.Text.Trim();
            string nomUsuario = txtFiltroNomUsuario.Text.Trim();
            string nomReal = txtFiltroNomReal.Text.Trim();
            string tipo = cmbTipo.Text.Trim();
            string fechaInicial = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string fechaFinal = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();

            Consulta.LogBuscar(dgvLog, idpedido, nomUsuario, nomReal, tipo, fechaInicial, fechaFinal);
        }
    }
}

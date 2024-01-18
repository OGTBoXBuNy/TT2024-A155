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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.ShowDialog();
            //this.Hide();

        }
    }
}

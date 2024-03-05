namespace TT2024_A155
{
    partial class SubMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubMenu));
            lblUsuario = new Label();
            lblRol = new Label();
            lblIdPedido = new Label();
            btnModificarDatosPedido = new Button();
            btnGenerarFactura = new Button();
            btnRegistrarDevolucion = new Button();
            btnRegistrarEntrega = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(150, 32);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 20);
            lblUsuario.TabIndex = 4;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(170, 32);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(0, 20);
            lblRol.TabIndex = 5;
            // 
            // lblIdPedido
            // 
            lblIdPedido.AutoSize = true;
            lblIdPedido.Location = new Point(12, 350);
            lblIdPedido.Name = "lblIdPedido";
            lblIdPedido.Size = new Size(0, 20);
            lblIdPedido.TabIndex = 6;
            // 
            // btnModificarDatosPedido
            // 
            btnModificarDatosPedido.BackColor = Color.FromArgb(66, 165, 245);
            btnModificarDatosPedido.Enabled = false;
            btnModificarDatosPedido.ForeColor = Color.White;
            btnModificarDatosPedido.Location = new Point(80, 80);
            btnModificarDatosPedido.Name = "btnModificarDatosPedido";
            btnModificarDatosPedido.Size = new Size(196, 64);
            btnModificarDatosPedido.TabIndex = 13;
            btnModificarDatosPedido.Text = "Modificar Datos del Pedido";
            btnModificarDatosPedido.UseVisualStyleBackColor = false;
            btnModificarDatosPedido.Click += btnModificarDatosPedido_Click;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.BackColor = Color.FromArgb(66, 165, 245);
            btnGenerarFactura.Enabled = false;
            btnGenerarFactura.ForeColor = Color.White;
            btnGenerarFactura.Location = new Point(80, 150);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(196, 64);
            btnGenerarFactura.TabIndex = 14;
            btnGenerarFactura.Text = "Generar Factura";
            btnGenerarFactura.UseVisualStyleBackColor = false;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.BackColor = Color.FromArgb(66, 165, 245);
            btnRegistrarDevolucion.Enabled = false;
            btnRegistrarDevolucion.ForeColor = Color.White;
            btnRegistrarDevolucion.Location = new Point(80, 290);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new Size(196, 64);
            btnRegistrarDevolucion.TabIndex = 16;
            btnRegistrarDevolucion.Text = "Registrar Devolución";
            btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            btnRegistrarDevolucion.Click += btnRegistrarDevolucion_Click;
            // 
            // btnRegistrarEntrega
            // 
            btnRegistrarEntrega.BackColor = Color.FromArgb(66, 165, 245);
            btnRegistrarEntrega.Enabled = false;
            btnRegistrarEntrega.ForeColor = Color.White;
            btnRegistrarEntrega.Location = new Point(80, 220);
            btnRegistrarEntrega.Name = "btnRegistrarEntrega";
            btnRegistrarEntrega.Size = new Size(196, 64);
            btnRegistrarEntrega.TabIndex = 15;
            btnRegistrarEntrega.Text = "Registrar Entrega";
            btnRegistrarEntrega.UseVisualStyleBackColor = false;
            btnRegistrarEntrega.Click += btnRegistrarEntrega_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(66, 165, 245);
            button5.Enabled = false;
            button5.ForeColor = Color.White;
            button5.Location = new Point(80, 361);
            button5.Name = "button5";
            button5.Size = new Size(196, 64);
            button5.TabIndex = 17;
            button5.Text = "Generar Refactura";
            button5.UseVisualStyleBackColor = false;
            // 
            // SubMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 448);
            Controls.Add(button5);
            Controls.Add(btnRegistrarDevolucion);
            Controls.Add(btnRegistrarEntrega);
            Controls.Add(btnGenerarFactura);
            Controls.Add(btnModificarDatosPedido);
            Controls.Add(lblIdPedido);
            Controls.Add(lblRol);
            Controls.Add(lblUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SubMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Submenú";
            Load += SubMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblUsuario;
        public Label lblRol;
        public Label lblIdPedido;
        private Button btnModificarDatosPedido;
        private Button btnGenerarFactura;
        private Button btnRegistrarDevolucion;
        private Button btnRegistrarEntrega;
        private Button button5;
    }
}
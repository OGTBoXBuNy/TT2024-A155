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
            btnModificarDatosPedido = new Button();
            btnGenerarFactura = new Button();
            btnGenerarRefactura = new Button();
            btnRegistrarEntregasDevoluciones = new Button();
            lblUsuario = new Label();
            lblRol = new Label();
            lblIdPedido = new Label();
            SuspendLayout();
            // 
            // btnModificarDatosPedido
            // 
            btnModificarDatosPedido.Location = new Point(12, 31);
            btnModificarDatosPedido.Name = "btnModificarDatosPedido";
            btnModificarDatosPedido.Size = new Size(233, 52);
            btnModificarDatosPedido.TabIndex = 0;
            btnModificarDatosPedido.Text = "Modificar Datos Pedido";
            btnModificarDatosPedido.UseVisualStyleBackColor = true;
            btnModificarDatosPedido.Click += btnModificarDatosPedido_Click;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.Location = new Point(12, 89);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(233, 52);
            btnGenerarFactura.TabIndex = 1;
            btnGenerarFactura.Text = "Generar Factura";
            btnGenerarFactura.UseVisualStyleBackColor = true;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            // 
            // btnGenerarRefactura
            // 
            btnGenerarRefactura.Location = new Point(12, 147);
            btnGenerarRefactura.Name = "btnGenerarRefactura";
            btnGenerarRefactura.Size = new Size(233, 52);
            btnGenerarRefactura.TabIndex = 2;
            btnGenerarRefactura.Text = "Generar Refactura";
            btnGenerarRefactura.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarEntregasDevoluciones
            // 
            btnRegistrarEntregasDevoluciones.Location = new Point(12, 205);
            btnRegistrarEntregasDevoluciones.Name = "btnRegistrarEntregasDevoluciones";
            btnRegistrarEntregasDevoluciones.Size = new Size(233, 52);
            btnRegistrarEntregasDevoluciones.TabIndex = 3;
            btnRegistrarEntregasDevoluciones.Text = "Registrar Entregas y Devoluciones";
            btnRegistrarEntregasDevoluciones.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 8);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 20);
            lblUsuario.TabIndex = 4;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(206, 8);
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
            // SubMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 379);
            Controls.Add(lblIdPedido);
            Controls.Add(lblRol);
            Controls.Add(lblUsuario);
            Controls.Add(btnRegistrarEntregasDevoluciones);
            Controls.Add(btnGenerarRefactura);
            Controls.Add(btnGenerarFactura);
            Controls.Add(btnModificarDatosPedido);
            Name = "SubMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SubMenu";
            Load += SubMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificarDatosPedido;
        private Button btnGenerarFactura;
        private Button btnGenerarRefactura;
        private Button btnRegistrarEntregasDevoluciones;
        public Label lblUsuario;
        public Label lblRol;
        public Label lblIdPedido;
    }
}
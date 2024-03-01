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
            btnModificarDatosPedido = new MaterialSkin.Controls.MaterialRaisedButton();
            btnGenerarFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            btnGenerarRefactura = new MaterialSkin.Controls.MaterialRaisedButton();
            btnRegistrarEntrega = new MaterialSkin.Controls.MaterialRaisedButton();
            btnRegistrarDevolucion = new MaterialSkin.Controls.MaterialRaisedButton();
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
            btnModificarDatosPedido.AutoSize = true;
            btnModificarDatosPedido.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificarDatosPedido.Depth = 0;
            btnModificarDatosPedido.Icon = null;
            btnModificarDatosPedido.Location = new Point(65, 90);
            btnModificarDatosPedido.MouseState = MaterialSkin.MouseState.HOVER;
            btnModificarDatosPedido.Name = "btnModificarDatosPedido";
            btnModificarDatosPedido.Primary = true;
            btnModificarDatosPedido.Size = new Size(236, 36);
            btnModificarDatosPedido.TabIndex = 8;
            btnModificarDatosPedido.Text = "Modificar Datos Pedido";
            btnModificarDatosPedido.UseVisualStyleBackColor = true;
            btnModificarDatosPedido.Click += btnModificarDatosPedido_Click;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.AutoSize = true;
            btnGenerarFactura.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGenerarFactura.Depth = 0;
            btnGenerarFactura.Icon = null;
            btnGenerarFactura.Location = new Point(65, 150);
            btnGenerarFactura.MouseState = MaterialSkin.MouseState.HOVER;
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Primary = true;
            btnGenerarFactura.Size = new Size(178, 36);
            btnGenerarFactura.TabIndex = 9;
            btnGenerarFactura.Text = "Generar Factura";
            btnGenerarFactura.UseVisualStyleBackColor = true;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            // 
            // btnGenerarRefactura
            // 
            btnGenerarRefactura.AutoSize = true;
            btnGenerarRefactura.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGenerarRefactura.Depth = 0;
            btnGenerarRefactura.Icon = null;
            btnGenerarRefactura.Location = new Point(65, 210);
            btnGenerarRefactura.MouseState = MaterialSkin.MouseState.HOVER;
            btnGenerarRefactura.Name = "btnGenerarRefactura";
            btnGenerarRefactura.Primary = true;
            btnGenerarRefactura.Size = new Size(199, 36);
            btnGenerarRefactura.TabIndex = 10;
            btnGenerarRefactura.Text = "Generar Refactura";
            btnGenerarRefactura.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarEntrega
            // 
            btnRegistrarEntrega.AutoSize = true;
            btnRegistrarEntrega.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistrarEntrega.Depth = 0;
            btnRegistrarEntrega.Icon = null;
            btnRegistrarEntrega.Location = new Point(65, 270);
            btnRegistrarEntrega.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegistrarEntrega.Name = "btnRegistrarEntrega";
            btnRegistrarEntrega.Primary = true;
            btnRegistrarEntrega.Size = new Size(193, 36);
            btnRegistrarEntrega.TabIndex = 11;
            btnRegistrarEntrega.Text = "Registrar Entrega";
            btnRegistrarEntrega.UseVisualStyleBackColor = true;
            btnRegistrarEntrega.Click += btnRegistrarEntrega_Click;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.AutoSize = true;
            btnRegistrarDevolucion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistrarDevolucion.Depth = 0;
            btnRegistrarDevolucion.Icon = null;
            btnRegistrarDevolucion.Location = new Point(65, 330);
            btnRegistrarDevolucion.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Primary = true;
            btnRegistrarDevolucion.Size = new Size(221, 36);
            btnRegistrarDevolucion.TabIndex = 12;
            btnRegistrarDevolucion.Text = "Registrar Devolución";
            btnRegistrarDevolucion.UseVisualStyleBackColor = true;
            btnRegistrarDevolucion.Click += btnRegistrarDevolucion_Click;
            // 
            // SubMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 398);
            Controls.Add(btnRegistrarDevolucion);
            Controls.Add(btnRegistrarEntrega);
            Controls.Add(btnGenerarRefactura);
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
        private MaterialSkin.Controls.MaterialRaisedButton btnModificarDatosPedido;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerarFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerarRefactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistrarEntrega;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistrarDevolucion;
    }
}
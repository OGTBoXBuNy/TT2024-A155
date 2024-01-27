namespace TT2024_A155
{
    partial class Inicio
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
            lblUsuario = new Label();
            btnCrearPedido = new Button();
            lblRol = new Label();
            menuStrip1 = new MenuStrip();
            otrasOpcionesToolStripMenuItem = new ToolStripMenuItem();
            cuentaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 20);
            lblUsuario.TabIndex = 0;
            // 
            // btnCrearPedido
            // 
            btnCrearPedido.Location = new Point(12, 60);
            btnCrearPedido.Name = "btnCrearPedido";
            btnCrearPedido.Size = new Size(112, 29);
            btnCrearPedido.TabIndex = 1;
            btnCrearPedido.Text = "Crear pedido";
            btnCrearPedido.UseVisualStyleBackColor = true;
            btnCrearPedido.Click += btnCrearPedido_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(12, 37);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(36, 20);
            lblRol.TabIndex = 2;
            lblRol.Text = "ROL";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { otrasOpcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // otrasOpcionesToolStripMenuItem
            // 
            otrasOpcionesToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            otrasOpcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cuentaToolStripMenuItem });
            otrasOpcionesToolStripMenuItem.Enabled = false;
            otrasOpcionesToolStripMenuItem.Name = "otrasOpcionesToolStripMenuItem";
            otrasOpcionesToolStripMenuItem.Size = new Size(124, 24);
            otrasOpcionesToolStripMenuItem.Text = "Otras Opciones";
            otrasOpcionesToolStripMenuItem.Visible = false;
            // 
            // cuentaToolStripMenuItem
            // 
            cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            cuentaToolStripMenuItem.Size = new Size(224, 26);
            cuentaToolStripMenuItem.Text = "Administrar Cuenta";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRol);
            Controls.Add(btnCrearPedido);
            Controls.Add(lblUsuario);
            Controls.Add(menuStrip1);
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblUsuario;
        private Button btnCrearPedido;
        public Label lblRol;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem otrasOpcionesToolStripMenuItem;
        private ToolStripMenuItem cuentaToolStripMenuItem;
    }
}
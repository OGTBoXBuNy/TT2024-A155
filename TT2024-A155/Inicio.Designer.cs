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
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrearPedido);
            Controls.Add(lblUsuario);
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblUsuario;
        private Button btnCrearPedido;
    }
}
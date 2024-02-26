namespace TT2024_A155
{
    partial class cambioContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cambioContraseña));
            lblTitulo = new Label();
            lblContra = new Label();
            lblrRepContra = new Label();
            txtContra = new TextBox();
            txtContraRep = new TextBox();
            btnAceptar = new Button();
            lblUsuario = new Label();
            lblRol = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(270, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(187, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CAMBIO DE CONTRASEÑA";
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.Location = new Point(51, 81);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(129, 20);
            lblContra.TabIndex = 1;
            lblContra.Text = "Contraseña nueva:";
            // 
            // lblrRepContra
            // 
            lblrRepContra.AutoSize = true;
            lblrRepContra.Location = new Point(51, 115);
            lblrRepContra.Name = "lblrRepContra";
            lblrRepContra.Size = new Size(179, 20);
            lblrRepContra.TabIndex = 2;
            lblrRepContra.Text = "Repetir contraseña nueva:";
            // 
            // txtContra
            // 
            txtContra.Location = new Point(245, 74);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(300, 27);
            txtContra.TabIndex = 3;
            // 
            // txtContraRep
            // 
            txtContraRep.Location = new Point(245, 108);
            txtContraRep.Name = "txtContraRep";
            txtContraRep.Size = new Size(300, 27);
            txtContraRep.TabIndex = 4;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(451, 151);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(12, 29);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(36, 20);
            lblRol.TabIndex = 7;
            lblRol.Text = "ROL";
            // 
            // cambioContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 206);
            Controls.Add(lblRol);
            Controls.Add(lblUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(txtContraRep);
            Controls.Add(txtContra);
            Controls.Add(lblrRepContra);
            Controls.Add(lblContra);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "cambioContraseña";
            Text = "CREAR NUEVA CONTRASEÑA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblContra;
        private Label lblrRepContra;
        private TextBox txtContra;
        private TextBox txtContraRep;
        private Button btnAceptar;
        public Label lblUsuario;
        public Label lblRol;
    }
}
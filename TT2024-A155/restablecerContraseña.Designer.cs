namespace TT2024_A155
{
    partial class restablecerContraseña
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
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            txtRecuperacion = new TextBox();
            btnAceptar = new Button();
            lblCrearCuenta = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(306, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "RESTABLECER CONTRASEÑA";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(208, 47);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(405, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Ingresa tu nombre de usuario o correo electronico asociado";
            // 
            // txtRecuperacion
            // 
            txtRecuperacion.Location = new Point(250, 79);
            txtRecuperacion.Name = "txtRecuperacion";
            txtRecuperacion.Size = new Size(306, 27);
            txtRecuperacion.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(355, 112);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Continuar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblCrearCuenta
            // 
            lblCrearCuenta.AutoSize = true;
            lblCrearCuenta.Location = new Point(250, 109);
            lblCrearCuenta.Name = "lblCrearCuenta";
            lblCrearCuenta.Size = new Size(92, 20);
            lblCrearCuenta.TabIndex = 4;
            lblCrearCuenta.TabStop = true;
            lblCrearCuenta.Text = "Crear cuenta";
            lblCrearCuenta.LinkClicked += lblCrearCuenta_LinkClicked;
            // 
            // restablecerContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 202);
            Controls.Add(lblCrearCuenta);
            Controls.Add(btnAceptar);
            Controls.Add(txtRecuperacion);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Name = "restablecerContraseña";
            Text = "RECUPERAR CONTRASEÑA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private TextBox txtRecuperacion;
        private Button btnAceptar;
        private LinkLabel lblCrearCuenta;
    }
}
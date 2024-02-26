namespace TT2024_A155
{
    partial class inicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicioSesion));
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            btnAceptar = new Button();
            lblUsuario = new Label();
            lblContrasenia = new Label();
            picInicioSesion = new PictureBox();
            lblRestablecerContrasenia = new LinkLabel();
            lblVersion = new Label();
            btnFirma = new Button();
            ((System.ComponentModel.ISupportInitialize)picInicioSesion).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(110, 124);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(110, 181);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(125, 27);
            txtContrasenia.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(119, 260);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "INGRESAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(110, 101);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(110, 158);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(83, 20);
            lblContrasenia.TabIndex = 4;
            lblContrasenia.Text = "Contraseña";
            // 
            // picInicioSesion
            // 
            picInicioSesion.ErrorImage = Properties.Resources.Error;
            picInicioSesion.Image = Properties.Resources.ESCOM;
            picInicioSesion.InitialImage = Properties.Resources.ESCOM;
            picInicioSesion.Location = new Point(110, 12);
            picInicioSesion.Name = "picInicioSesion";
            picInicioSesion.Size = new Size(125, 62);
            picInicioSesion.SizeMode = PictureBoxSizeMode.Zoom;
            picInicioSesion.TabIndex = 5;
            picInicioSesion.TabStop = false;
            // 
            // lblRestablecerContrasenia
            // 
            lblRestablecerContrasenia.AutoSize = true;
            lblRestablecerContrasenia.Location = new Point(96, 222);
            lblRestablecerContrasenia.Name = "lblRestablecerContrasenia";
            lblRestablecerContrasenia.Size = new Size(152, 20);
            lblRestablecerContrasenia.TabIndex = 6;
            lblRestablecerContrasenia.TabStop = true;
            lblRestablecerContrasenia.Text = "Recuperar contraseña";
            lblRestablecerContrasenia.LinkClicked += lblRestablecerContrasenia_LinkClicked;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(12, 286);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(94, 20);
            lblVersion.TabIndex = 7;
            lblVersion.Text = "Versión: 1.0.1";
            // 
            // btnFirma
            // 
            btnFirma.Location = new Point(10, 12);
            btnFirma.Name = "btnFirma";
            btnFirma.Size = new Size(42, 27);
            btnFirma.TabIndex = 8;
            btnFirma.Text = "..";
            btnFirma.UseVisualStyleBackColor = true;
            btnFirma.Click += btnFirma_Click;
            // 
            // inicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 315);
            Controls.Add(btnFirma);
            Controls.Add(lblVersion);
            Controls.Add(lblRestablecerContrasenia);
            Controls.Add(picInicioSesion);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "inicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio Sesión";
            FormClosed += inicioSesion_FormClosed;
            Load += inicioSesion_Load;
            ((System.ComponentModel.ISupportInitialize)picInicioSesion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private Button btnAceptar;
        private Label lblUsuario;
        private Label lblContrasenia;
        private PictureBox picInicioSesion;
        private LinkLabel lblRestablecerContrasenia;
        private Label lblVersion;
        private Button btnFirma;
    }
}
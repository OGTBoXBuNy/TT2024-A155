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
            picInicioSesion = new PictureBox();
            lblRestablecerContrasenia = new LinkLabel();
            btnFirma = new Button();
            txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtContrasenia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            btnIngresar = new MaterialSkin.Controls.MaterialRaisedButton();
            pbUsuario = new PictureBox();
            pbContrasenia = new PictureBox();
            lblVersion = new Label();
            ((System.ComponentModel.ISupportInitialize)picInicioSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbContrasenia).BeginInit();
            SuspendLayout();
            // 
            // picInicioSesion
            // 
            picInicioSesion.BackColor = Color.Transparent;
            picInicioSesion.ErrorImage = Properties.Resources.Error;
            picInicioSesion.Image = Properties.Resources.logoAppTransMovimiento;
            picInicioSesion.InitialImage = Properties.Resources.ESCOM;
            picInicioSesion.Location = new Point(123, 68);
            picInicioSesion.Name = "picInicioSesion";
            picInicioSesion.Size = new Size(131, 112);
            picInicioSesion.SizeMode = PictureBoxSizeMode.StretchImage;
            picInicioSesion.TabIndex = 5;
            picInicioSesion.TabStop = false;
            // 
            // lblRestablecerContrasenia
            // 
            lblRestablecerContrasenia.AutoSize = true;
            lblRestablecerContrasenia.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRestablecerContrasenia.LinkColor = Color.White;
            lblRestablecerContrasenia.Location = new Point(14, 336);
            lblRestablecerContrasenia.Name = "lblRestablecerContrasenia";
            lblRestablecerContrasenia.Size = new Size(136, 17);
            lblRestablecerContrasenia.TabIndex = 4;
            lblRestablecerContrasenia.TabStop = true;
            lblRestablecerContrasenia.Text = "Recuperar contraseña";
            lblRestablecerContrasenia.LinkClicked += lblRestablecerContrasenia_LinkClicked;
            // 
            // btnFirma
            // 
            btnFirma.Location = new Point(302, 30);
            btnFirma.Name = "btnFirma";
            btnFirma.Size = new Size(42, 27);
            btnFirma.TabIndex = 8;
            btnFirma.Text = "..";
            btnFirma.UseVisualStyleBackColor = true;
            btnFirma.Click += btnFirma_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Depth = 0;
            txtUsuario.Hint = "";
            txtUsuario.Location = new Point(90, 196);
            txtUsuario.MaxLength = 32767;
            txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '\0';
            txtUsuario.SelectedText = "";
            txtUsuario.SelectionLength = 0;
            txtUsuario.SelectionStart = 0;
            txtUsuario.Size = new Size(202, 28);
            txtUsuario.TabIndex = 1;
            txtUsuario.TabStop = false;
            txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Depth = 0;
            txtContrasenia.Hint = "";
            txtContrasenia.Location = new Point(90, 254);
            txtContrasenia.MaxLength = 32767;
            txtContrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '\0';
            txtContrasenia.SelectedText = "";
            txtContrasenia.SelectionLength = 0;
            txtContrasenia.SelectionStart = 0;
            txtContrasenia.Size = new Size(202, 28);
            txtContrasenia.TabIndex = 2;
            txtContrasenia.TabStop = false;
            txtContrasenia.UseSystemPasswordChar = false;
            // 
            // btnIngresar
            // 
            btnIngresar.AutoSize = true;
            btnIngresar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIngresar.Depth = 0;
            btnIngresar.Icon = null;
            btnIngresar.Location = new Point(139, 297);
            btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Primary = true;
            btnIngresar.Size = new Size(104, 36);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pbUsuario
            // 
            pbUsuario.Image = Properties.Resources.usuarioIcono;
            pbUsuario.Location = new Point(48, 199);
            pbUsuario.Name = "pbUsuario";
            pbUsuario.Size = new Size(25, 25);
            pbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUsuario.TabIndex = 15;
            pbUsuario.TabStop = false;
            // 
            // pbContrasenia
            // 
            pbContrasenia.Image = Properties.Resources.contraseniaIcono;
            pbContrasenia.Location = new Point(48, 257);
            pbContrasenia.Name = "pbContrasenia";
            pbContrasenia.Size = new Size(25, 25);
            pbContrasenia.SizeMode = PictureBoxSizeMode.StretchImage;
            pbContrasenia.TabIndex = 16;
            pbContrasenia.TabStop = false;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(250, 336);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(94, 20);
            lblVersion.TabIndex = 17;
            lblVersion.Text = "Versión: 1.0.0";
            // 
            // inicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 362);
            Controls.Add(lblVersion);
            Controls.Add(pbContrasenia);
            Controls.Add(pbUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(btnFirma);
            Controls.Add(lblRestablecerContrasenia);
            Controls.Add(picInicioSesion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "inicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            FormClosed += inicioSesion_FormClosed;
            Load += inicioSesion_Load;
            ((System.ComponentModel.ISupportInitialize)picInicioSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbContrasenia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picInicioSesion;
        private LinkLabel lblRestablecerContrasenia;
        private Label lblVersion;
        private Button btnFirma;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasenia;
        private MaterialSkin.Controls.MaterialRaisedButton btnIngresar;
        private PictureBox pbUsuario;
        private PictureBox pbContrasenia;
        
    }
}
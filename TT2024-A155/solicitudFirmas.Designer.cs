namespace TT2024_A155
{
    partial class solicitudFirmas
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
            components = new System.ComponentModel.Container();
            lblUsuario = new Label();
            txtInfo = new TextBox();
            pbAdvertencia = new PictureBox();
            btnGenerar = new MaterialSkin.Controls.MaterialRaisedButton();
            lblRol = new Label();
            lblContrasenia = new MaterialSkin.Controls.MaterialLabel();
            txtContrasenia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            errorContrasenia = new ErrorProvider(components);
            PicOJO = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbAdvertencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorContrasenia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicOJO).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(203, 24);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 20);
            lblUsuario.TabIndex = 0;
            // 
            // txtInfo
            // 
            txtInfo.BackColor = Color.White;
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtInfo.Location = new Point(118, 76);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(670, 105);
            txtInfo.TabIndex = 1;
            txtInfo.Text = "Los archivos se guardarán automaticamente en este dispositivo. Por tu seguridad te recomendamos borrarlos si estás en una computadora pública.";
            // 
            // pbAdvertencia
            // 
            pbAdvertencia.Image = Properties.Resources.advertencia;
            pbAdvertencia.Location = new Point(11, 89);
            pbAdvertencia.Name = "pbAdvertencia";
            pbAdvertencia.Size = new Size(98, 83);
            pbAdvertencia.SizeMode = PictureBoxSizeMode.Zoom;
            pbAdvertencia.TabIndex = 2;
            pbAdvertencia.TabStop = false;
            // 
            // btnGenerar
            // 
            btnGenerar.AutoSize = true;
            btnGenerar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGenerar.Depth = 0;
            btnGenerar.Icon = null;
            btnGenerar.Location = new Point(690, 322);
            btnGenerar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Primary = true;
            btnGenerar.Size = new Size(98, 36);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(203, 53);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(0, 20);
            lblRol.TabIndex = 4;
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Depth = 0;
            lblContrasenia.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblContrasenia.Location = new Point(11, 267);
            lblContrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(365, 24);
            lblContrasenia.TabIndex = 5;
            lblContrasenia.Text = "Contraseña para proteger tu clave privada:";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Depth = 0;
            txtContrasenia.Hint = "";
            txtContrasenia.Location = new Point(394, 267);
            txtContrasenia.MaxLength = 32767;
            txtContrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '\0';
            txtContrasenia.SelectedText = "";
            txtContrasenia.SelectionLength = 0;
            txtContrasenia.SelectionStart = 0;
            txtContrasenia.Size = new Size(250, 28);
            txtContrasenia.TabIndex = 6;
            txtContrasenia.TabStop = false;
            txtContrasenia.UseSystemPasswordChar = true;
            txtContrasenia.Enter += txtContrasenia_Enter;
            txtContrasenia.Leave += txtContrasenia_Leave;
            // 
            // errorContrasenia
            // 
            errorContrasenia.ContainerControl = this;
            // 
            // PicOJO
            // 
            PicOJO.Image = Properties.Resources.ojo;
            PicOJO.Location = new Point(651, 267);
            PicOJO.Margin = new Padding(4);
            PicOJO.Name = "PicOJO";
            PicOJO.Size = new Size(44, 28);
            PicOJO.SizeMode = PictureBoxSizeMode.Zoom;
            PicOJO.TabIndex = 21;
            PicOJO.TabStop = false;
            PicOJO.Visible = false;
            PicOJO.MouseClick += PicOJO_MouseClick;
            // 
            // solicitudFirmas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(806, 370);
            Controls.Add(PicOJO);
            Controls.Add(txtContrasenia);
            Controls.Add(lblContrasenia);
            Controls.Add(lblRol);
            Controls.Add(btnGenerar);
            Controls.Add(pbAdvertencia);
            Controls.Add(txtInfo);
            Controls.Add(lblUsuario);
            MaximizeBox = false;
            Name = "solicitudFirmas";
            Text = "Solicitud de Firma";
            ((System.ComponentModel.ISupportInitialize)pbAdvertencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorContrasenia).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicOJO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblUsuario;
        private TextBox txtInfo;
        private PictureBox pbAdvertencia;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerar;
        public Label lblRol;
        private MaterialSkin.Controls.MaterialLabel lblContrasenia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasenia;
        private ErrorProvider errorContrasenia;
        private PictureBox PicOJO;
    }
}
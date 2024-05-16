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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cambioContraseña));
            lblUsuario = new Label();
            lblRol = new Label();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            txtContra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtContraRep = new MaterialSkin.Controls.MaterialSingleLineTextField();
            btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            errorContrasenia = new ErrorProvider(components);
            errorContraseniaRepe = new ErrorProvider(components);
            PicOJO = new PictureBox();
            PicOjoRes = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorContrasenia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorContraseniaRepe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicOJO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicOjoRes).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(523, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            lblUsuario.Visible = false;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(523, 29);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(36, 20);
            lblRol.TabIndex = 7;
            lblRol.Text = "ROL";
            lblRol.Visible = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(35, 80);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(164, 24);
            materialLabel1.TabIndex = 8;
            materialLabel1.Text = "Contraseña nueva:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(35, 120);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(227, 24);
            materialLabel2.TabIndex = 9;
            materialLabel2.Text = "Repetir contraseña nueva:";
            // 
            // txtContra
            // 
            txtContra.Depth = 0;
            txtContra.Hint = "";
            txtContra.Location = new Point(282, 80);
            txtContra.MaxLength = 32767;
            txtContra.MouseState = MaterialSkin.MouseState.HOVER;
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '\0';
            txtContra.SelectedText = "";
            txtContra.SelectionLength = 0;
            txtContra.SelectionStart = 0;
            txtContra.Size = new Size(300, 28);
            txtContra.TabIndex = 10;
            txtContra.TabStop = false;
            txtContra.UseSystemPasswordChar = true;
            txtContra.Enter += txtContra_Enter;
            txtContra.Leave += txtContra_Leave;
            // 
            // txtContraRep
            // 
            txtContraRep.Depth = 0;
            txtContraRep.Hint = "";
            txtContraRep.Location = new Point(282, 120);
            txtContraRep.MaxLength = 32767;
            txtContraRep.MouseState = MaterialSkin.MouseState.HOVER;
            txtContraRep.Name = "txtContraRep";
            txtContraRep.PasswordChar = '\0';
            txtContraRep.SelectedText = "";
            txtContraRep.SelectionLength = 0;
            txtContraRep.SelectionStart = 0;
            txtContraRep.Size = new Size(300, 28);
            txtContraRep.TabIndex = 11;
            txtContraRep.TabStop = false;
            txtContraRep.UseSystemPasswordChar = true;
            txtContraRep.Enter += txtContraRep_Enter;
            txtContraRep.Leave += txtContraRep_Leave;
            // 
            // btnAceptar
            // 
            btnAceptar.AutoSize = true;
            btnAceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAceptar.Depth = 0;
            btnAceptar.Icon = null;
            btnAceptar.Location = new Point(484, 154);
            btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Primary = true;
            btnAceptar.Size = new Size(98, 36);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // errorContrasenia
            // 
            errorContrasenia.ContainerControl = this;
            // 
            // errorContraseniaRepe
            // 
            errorContraseniaRepe.ContainerControl = this;
            // 
            // PicOJO
            // 
            PicOJO.Image = Properties.Resources.ojo;
            PicOJO.Location = new Point(589, 80);
            PicOJO.Margin = new Padding(4);
            PicOJO.Name = "PicOJO";
            PicOJO.Size = new Size(44, 28);
            PicOJO.SizeMode = PictureBoxSizeMode.Zoom;
            PicOJO.TabIndex = 21;
            PicOJO.TabStop = false;
            PicOJO.Visible = false;
            PicOJO.MouseClick += PicOJO_MouseClick;
            // 
            // PicOjoRes
            // 
            PicOjoRes.Image = Properties.Resources.ojo;
            PicOjoRes.Location = new Point(589, 120);
            PicOjoRes.Margin = new Padding(4);
            PicOjoRes.Name = "PicOjoRes";
            PicOjoRes.Size = new Size(44, 28);
            PicOjoRes.SizeMode = PictureBoxSizeMode.Zoom;
            PicOjoRes.TabIndex = 22;
            PicOjoRes.TabStop = false;
            PicOjoRes.Visible = false;
            PicOjoRes.MouseClick += PicOjoRes_MouseClick;
            // 
            // cambioContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(636, 192);
            Controls.Add(PicOjoRes);
            Controls.Add(PicOJO);
            Controls.Add(btnAceptar);
            Controls.Add(txtContraRep);
            Controls.Add(txtContra);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(lblRol);
            Controls.Add(lblUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "cambioContraseña";
            Text = "CREAR NUEVA CONTRASEÑA";
            ((System.ComponentModel.ISupportInitialize)errorContrasenia).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorContraseniaRepe).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicOJO).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicOjoRes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblUsuario;
        public Label lblRol;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContraRep;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
        private ErrorProvider errorContrasenia;
        private ErrorProvider errorContraseniaRepe;
        private PictureBox PicOjoRes;
        private PictureBox PicOJO;
    }
}
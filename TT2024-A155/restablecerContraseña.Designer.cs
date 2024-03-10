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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(restablecerContraseña));
            lblCrearCuenta = new LinkLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtRecuperacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            SuspendLayout();
            // 
            // lblCrearCuenta
            // 
            lblCrearCuenta.ActiveLinkColor = SystemColors.HotTrack;
            lblCrearCuenta.AutoSize = true;
            lblCrearCuenta.LinkColor = Color.Black;
            lblCrearCuenta.Location = new Point(250, 134);
            lblCrearCuenta.Name = "lblCrearCuenta";
            lblCrearCuenta.Size = new Size(92, 20);
            lblCrearCuenta.TabIndex = 4;
            lblCrearCuenta.TabStop = true;
            lblCrearCuenta.Text = "Crear cuenta";
            lblCrearCuenta.Visible = false;
            lblCrearCuenta.LinkClicked += lblCrearCuenta_LinkClicked;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(138, 65);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(513, 24);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Ingresa tu nombre de usuario o correo electronico asociado";
            // 
            // txtRecuperacion
            // 
            txtRecuperacion.Depth = 0;
            txtRecuperacion.Hint = "";
            txtRecuperacion.Location = new Point(250, 92);
            txtRecuperacion.MaxLength = 32767;
            txtRecuperacion.MouseState = MaterialSkin.MouseState.HOVER;
            txtRecuperacion.Name = "txtRecuperacion";
            txtRecuperacion.PasswordChar = '\0';
            txtRecuperacion.SelectedText = "";
            txtRecuperacion.SelectionLength = 0;
            txtRecuperacion.SelectionStart = 0;
            txtRecuperacion.Size = new Size(306, 28);
            txtRecuperacion.TabIndex = 6;
            txtRecuperacion.TabStop = false;
            txtRecuperacion.UseSystemPasswordChar = false;
            // 
            // btnAceptar
            // 
            btnAceptar.AutoSize = true;
            btnAceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAceptar.Depth = 0;
            btnAceptar.Icon = null;
            btnAceptar.Location = new Point(361, 126);
            btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Primary = true;
            btnAceptar.Size = new Size(118, 36);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Continuar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // restablecerContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 202);
            Controls.Add(btnAceptar);
            Controls.Add(txtRecuperacion);
            Controls.Add(materialLabel1);
            Controls.Add(lblCrearCuenta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "restablecerContraseña";
            Text = "RESTABLECIMIENTO DE CONTRASEÑA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel lblCrearCuenta;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRecuperacion;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
    }
}
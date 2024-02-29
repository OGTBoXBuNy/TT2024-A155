namespace TT2024_A155
{
    partial class Administrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrar));
            cmbRol = new ComboBox();
            lblRolF = new Label();
            lblUsuarioF = new Label();
            lblNombre = new MaterialSkin.Controls.MaterialLabel();
            lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            lblNoInt = new MaterialSkin.Controls.MaterialLabel();
            lblContrasenia = new MaterialSkin.Controls.MaterialLabel();
            lblTel = new MaterialSkin.Controls.MaterialLabel();
            lblColonia = new MaterialSkin.Controls.MaterialLabel();
            lblCalle = new MaterialSkin.Controls.MaterialLabel();
            lblCorreo = new MaterialSkin.Controls.MaterialLabel();
            lblCp = new MaterialSkin.Controls.MaterialLabel();
            lblNoExt = new MaterialSkin.Controls.MaterialLabel();
            lblCiudad = new MaterialSkin.Controls.MaterialLabel();
            lblRol = new MaterialSkin.Controls.MaterialLabel();
            lblCif = new MaterialSkin.Controls.MaterialLabel();
            txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtContrasenia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtTel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCalle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCif = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtNoExt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCiudad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtNoInt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            rbtnDatosPersonales = new MaterialSkin.Controls.MaterialRadioButton();
            rbtnDatosFiscales = new MaterialSkin.Controls.MaterialRadioButton();
            SuspendLayout();
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Ventas", "Finanzas", "Cliente" });
            cmbRol.Location = new Point(147, 410);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(198, 28);
            cmbRol.TabIndex = 15;
            // 
            // lblRolF
            // 
            lblRolF.AutoSize = true;
            lblRolF.Location = new Point(886, 63);
            lblRolF.Name = "lblRolF";
            lblRolF.Size = new Size(36, 20);
            lblRolF.TabIndex = 49;
            lblRolF.Text = "ROL";
            // 
            // lblUsuarioF
            // 
            lblUsuarioF.AutoSize = true;
            lblUsuarioF.Location = new Point(886, 35);
            lblUsuarioF.Name = "lblUsuarioF";
            lblUsuarioF.Size = new Size(0, 20);
            lblUsuarioF.TabIndex = 48;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Depth = 0;
            lblNombre.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNombre.Location = new Point(15, 150);
            lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(84, 24);
            lblNombre.TabIndex = 51;
            lblNombre.Text = "Nombre:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Depth = 0;
            lblUsuario.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblUsuario.Location = new Point(15, 190);
            lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(79, 24);
            lblUsuario.TabIndex = 52;
            lblUsuario.Text = "Usuario:";
            // 
            // lblNoInt
            // 
            lblNoInt.AutoSize = true;
            lblNoInt.Depth = 0;
            lblNoInt.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoInt.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNoInt.Location = new Point(700, 290);
            lblNoInt.MouseState = MaterialSkin.MouseState.HOVER;
            lblNoInt.Name = "lblNoInt";
            lblNoInt.Size = new Size(76, 24);
            lblNoInt.TabIndex = 54;
            lblNoInt.Text = "No. Int.:";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Depth = 0;
            lblContrasenia.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblContrasenia.Location = new Point(15, 230);
            lblContrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(110, 24);
            lblContrasenia.TabIndex = 53;
            lblContrasenia.Text = "Contraseña:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Depth = 0;
            lblTel.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTel.Location = new Point(35, 370);
            lblTel.MouseState = MaterialSkin.MouseState.HOVER;
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(90, 24);
            lblTel.TabIndex = 57;
            lblTel.Text = "Telefono:";
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.Depth = 0;
            lblColonia.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblColonia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblColonia.Location = new Point(46, 330);
            lblColonia.MouseState = MaterialSkin.MouseState.HOVER;
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(79, 24);
            lblColonia.TabIndex = 56;
            lblColonia.Text = "Colonia:";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Depth = 0;
            lblCalle.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCalle.Location = new Point(68, 290);
            lblCalle.MouseState = MaterialSkin.MouseState.HOVER;
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(57, 24);
            lblCalle.TabIndex = 55;
            lblCalle.Text = "Calle:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Depth = 0;
            lblCorreo.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCorreo.Location = new Point(400, 370);
            lblCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(71, 24);
            lblCorreo.TabIndex = 60;
            lblCorreo.Text = "Correo:";
            // 
            // lblCp
            // 
            lblCp.AutoSize = true;
            lblCp.Depth = 0;
            lblCp.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCp.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCp.Location = new Point(422, 330);
            lblCp.MouseState = MaterialSkin.MouseState.HOVER;
            lblCp.Name = "lblCp";
            lblCp.Size = new Size(49, 24);
            lblCp.TabIndex = 59;
            lblCp.Text = "C.P.:";
            // 
            // lblNoExt
            // 
            lblNoExt.AutoSize = true;
            lblNoExt.Depth = 0;
            lblNoExt.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoExt.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNoExt.Location = new Point(390, 290);
            lblNoExt.MouseState = MaterialSkin.MouseState.HOVER;
            lblNoExt.Name = "lblNoExt";
            lblNoExt.Size = new Size(81, 24);
            lblNoExt.TabIndex = 58;
            lblNoExt.Text = "No. Ext.:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Depth = 0;
            lblCiudad.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCiudad.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCiudad.Location = new Point(700, 330);
            lblCiudad.MouseState = MaterialSkin.MouseState.HOVER;
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(74, 24);
            lblCiudad.TabIndex = 61;
            lblCiudad.Text = "Ciudad:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Depth = 0;
            lblRol.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblRol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblRol.Location = new Point(82, 410);
            lblRol.MouseState = MaterialSkin.MouseState.HOVER;
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(43, 24);
            lblRol.TabIndex = 62;
            lblRol.Text = "Rol:";
            // 
            // lblCif
            // 
            lblCif.AutoSize = true;
            lblCif.Depth = 0;
            lblCif.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCif.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCif.Location = new Point(423, 410);
            lblCif.MouseState = MaterialSkin.MouseState.HOVER;
            lblCif.Name = "lblCif";
            lblCif.Size = new Size(48, 24);
            lblCif.TabIndex = 63;
            lblCif.Text = "CIF: ";
            // 
            // txtNombre
            // 
            txtNombre.Depth = 0;
            txtNombre.Hint = "";
            txtNombre.Location = new Point(147, 150);
            txtNombre.MaxLength = 32767;
            txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.SelectedText = "";
            txtNombre.SelectionLength = 0;
            txtNombre.SelectionStart = 0;
            txtNombre.Size = new Size(288, 28);
            txtNombre.TabIndex = 64;
            txtNombre.TabStop = false;
            txtNombre.UseSystemPasswordChar = false;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtUsuario
            // 
            txtUsuario.Depth = 0;
            txtUsuario.Hint = "";
            txtUsuario.Location = new Point(147, 190);
            txtUsuario.MaxLength = 32767;
            txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '\0';
            txtUsuario.SelectedText = "";
            txtUsuario.SelectionLength = 0;
            txtUsuario.SelectionStart = 0;
            txtUsuario.Size = new Size(198, 28);
            txtUsuario.TabIndex = 65;
            txtUsuario.TabStop = false;
            txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Depth = 0;
            txtContrasenia.Hint = "";
            txtContrasenia.Location = new Point(147, 230);
            txtContrasenia.MaxLength = 32767;
            txtContrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '\0';
            txtContrasenia.SelectedText = "";
            txtContrasenia.SelectionLength = 0;
            txtContrasenia.SelectionStart = 0;
            txtContrasenia.Size = new Size(198, 28);
            txtContrasenia.TabIndex = 66;
            txtContrasenia.TabStop = false;
            txtContrasenia.UseSystemPasswordChar = false;
            // 
            // txtTel
            // 
            txtTel.Depth = 0;
            txtTel.Hint = "";
            txtTel.Location = new Point(147, 370);
            txtTel.MaxLength = 32767;
            txtTel.MouseState = MaterialSkin.MouseState.HOVER;
            txtTel.Name = "txtTel";
            txtTel.PasswordChar = '\0';
            txtTel.SelectedText = "";
            txtTel.SelectionLength = 0;
            txtTel.SelectionStart = 0;
            txtTel.Size = new Size(198, 28);
            txtTel.TabIndex = 70;
            txtTel.TabStop = false;
            txtTel.UseSystemPasswordChar = false;
            txtTel.KeyPress += txtTel_KeyPress;
            // 
            // txtCol
            // 
            txtCol.Depth = 0;
            txtCol.Hint = "";
            txtCol.Location = new Point(147, 330);
            txtCol.MaxLength = 32767;
            txtCol.MouseState = MaterialSkin.MouseState.HOVER;
            txtCol.Name = "txtCol";
            txtCol.PasswordChar = '\0';
            txtCol.SelectedText = "";
            txtCol.SelectionLength = 0;
            txtCol.SelectionStart = 0;
            txtCol.Size = new Size(198, 28);
            txtCol.TabIndex = 69;
            txtCol.TabStop = false;
            txtCol.UseSystemPasswordChar = false;
            // 
            // txtCalle
            // 
            txtCalle.Depth = 0;
            txtCalle.Hint = "";
            txtCalle.Location = new Point(147, 290);
            txtCalle.MaxLength = 32767;
            txtCalle.MouseState = MaterialSkin.MouseState.HOVER;
            txtCalle.Name = "txtCalle";
            txtCalle.PasswordChar = '\0';
            txtCalle.SelectedText = "";
            txtCalle.SelectionLength = 0;
            txtCalle.SelectionStart = 0;
            txtCalle.Size = new Size(198, 28);
            txtCalle.TabIndex = 68;
            txtCalle.TabStop = false;
            txtCalle.UseSystemPasswordChar = false;
            // 
            // txtCif
            // 
            txtCif.Depth = 0;
            txtCif.Hint = "";
            txtCif.Location = new Point(490, 410);
            txtCif.MaxLength = 32767;
            txtCif.MouseState = MaterialSkin.MouseState.HOVER;
            txtCif.Name = "txtCif";
            txtCif.PasswordChar = '\0';
            txtCif.SelectedText = "";
            txtCif.SelectionLength = 0;
            txtCif.SelectionStart = 0;
            txtCif.Size = new Size(198, 28);
            txtCif.TabIndex = 71;
            txtCif.TabStop = false;
            txtCif.UseSystemPasswordChar = false;
            // 
            // txtCorreo
            // 
            txtCorreo.Depth = 0;
            txtCorreo.Hint = "";
            txtCorreo.Location = new Point(490, 370);
            txtCorreo.MaxLength = 32767;
            txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PasswordChar = '\0';
            txtCorreo.SelectedText = "";
            txtCorreo.SelectionLength = 0;
            txtCorreo.SelectionStart = 0;
            txtCorreo.Size = new Size(198, 28);
            txtCorreo.TabIndex = 74;
            txtCorreo.TabStop = false;
            txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtCP
            // 
            txtCP.Depth = 0;
            txtCP.Hint = "";
            txtCP.Location = new Point(490, 330);
            txtCP.MaxLength = 32767;
            txtCP.MouseState = MaterialSkin.MouseState.HOVER;
            txtCP.Name = "txtCP";
            txtCP.PasswordChar = '\0';
            txtCP.SelectedText = "";
            txtCP.SelectionLength = 0;
            txtCP.SelectionStart = 0;
            txtCP.Size = new Size(120, 28);
            txtCP.TabIndex = 73;
            txtCP.TabStop = false;
            txtCP.UseSystemPasswordChar = false;
            txtCP.KeyPress += txtCP_KeyPress;
            // 
            // txtNoExt
            // 
            txtNoExt.Depth = 0;
            txtNoExt.Hint = "";
            txtNoExt.Location = new Point(490, 290);
            txtNoExt.MaxLength = 32767;
            txtNoExt.MouseState = MaterialSkin.MouseState.HOVER;
            txtNoExt.Name = "txtNoExt";
            txtNoExt.PasswordChar = '\0';
            txtNoExt.SelectedText = "";
            txtNoExt.SelectionLength = 0;
            txtNoExt.SelectionStart = 0;
            txtNoExt.Size = new Size(120, 28);
            txtNoExt.TabIndex = 72;
            txtNoExt.TabStop = false;
            txtNoExt.UseSystemPasswordChar = false;
            txtNoExt.KeyPress += txtNoExt_KeyPress;
            // 
            // txtCiudad
            // 
            txtCiudad.Depth = 0;
            txtCiudad.Hint = "";
            txtCiudad.Location = new Point(802, 330);
            txtCiudad.MaxLength = 32767;
            txtCiudad.MouseState = MaterialSkin.MouseState.HOVER;
            txtCiudad.Name = "txtCiudad";
            txtCiudad.PasswordChar = '\0';
            txtCiudad.SelectedText = "";
            txtCiudad.SelectionLength = 0;
            txtCiudad.SelectionStart = 0;
            txtCiudad.Size = new Size(120, 28);
            txtCiudad.TabIndex = 76;
            txtCiudad.TabStop = false;
            txtCiudad.UseSystemPasswordChar = false;
            // 
            // txtNoInt
            // 
            txtNoInt.Depth = 0;
            txtNoInt.Hint = "";
            txtNoInt.Location = new Point(802, 286);
            txtNoInt.MaxLength = 32767;
            txtNoInt.MouseState = MaterialSkin.MouseState.HOVER;
            txtNoInt.Name = "txtNoInt";
            txtNoInt.PasswordChar = '\0';
            txtNoInt.SelectedText = "";
            txtNoInt.SelectionLength = 0;
            txtNoInt.SelectionStart = 0;
            txtNoInt.Size = new Size(120, 28);
            txtNoInt.TabIndex = 75;
            txtNoInt.TabStop = false;
            txtNoInt.UseSystemPasswordChar = false;
            txtNoInt.KeyPress += txtNoInt_KeyPress;
            // 
            // btnAceptar
            // 
            btnAceptar.AutoSize = true;
            btnAceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAceptar.Depth = 0;
            btnAceptar.Icon = null;
            btnAceptar.Location = new Point(824, 410);
            btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Primary = true;
            btnAceptar.Size = new Size(98, 36);
            btnAceptar.TabIndex = 77;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // rbtnDatosPersonales
            // 
            rbtnDatosPersonales.AutoSize = true;
            rbtnDatosPersonales.Depth = 0;
            rbtnDatosPersonales.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnDatosPersonales.Location = new Point(15, 88);
            rbtnDatosPersonales.Margin = new Padding(0);
            rbtnDatosPersonales.MouseLocation = new Point(-1, -1);
            rbtnDatosPersonales.MouseState = MaterialSkin.MouseState.HOVER;
            rbtnDatosPersonales.Name = "rbtnDatosPersonales";
            rbtnDatosPersonales.Ripple = true;
            rbtnDatosPersonales.Size = new Size(165, 30);
            rbtnDatosPersonales.TabIndex = 78;
            rbtnDatosPersonales.TabStop = true;
            rbtnDatosPersonales.Text = "Datos Personales";
            rbtnDatosPersonales.UseVisualStyleBackColor = true;
            rbtnDatosPersonales.CheckedChanged += rbtnDatosPersonales_CheckedChanged;
            // 
            // rbtnDatosFiscales
            // 
            rbtnDatosFiscales.AutoSize = true;
            rbtnDatosFiscales.Depth = 0;
            rbtnDatosFiscales.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnDatosFiscales.Location = new Point(221, 88);
            rbtnDatosFiscales.Margin = new Padding(0);
            rbtnDatosFiscales.MouseLocation = new Point(-1, -1);
            rbtnDatosFiscales.MouseState = MaterialSkin.MouseState.HOVER;
            rbtnDatosFiscales.Name = "rbtnDatosFiscales";
            rbtnDatosFiscales.Ripple = true;
            rbtnDatosFiscales.Size = new Size(143, 30);
            rbtnDatosFiscales.TabIndex = 79;
            rbtnDatosFiscales.TabStop = true;
            rbtnDatosFiscales.Text = "Datos Fiscales";
            rbtnDatosFiscales.UseVisualStyleBackColor = true;
            rbtnDatosFiscales.CheckedChanged += rbtnDatosFiscales_CheckedChanged;
            // 
            // Administrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 463);
            Controls.Add(rbtnDatosFiscales);
            Controls.Add(rbtnDatosPersonales);
            Controls.Add(btnAceptar);
            Controls.Add(txtCiudad);
            Controls.Add(txtNoInt);
            Controls.Add(txtCorreo);
            Controls.Add(txtCP);
            Controls.Add(txtNoExt);
            Controls.Add(txtCif);
            Controls.Add(txtTel);
            Controls.Add(txtCol);
            Controls.Add(txtCalle);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombre);
            Controls.Add(lblCif);
            Controls.Add(lblRol);
            Controls.Add(lblCiudad);
            Controls.Add(lblCorreo);
            Controls.Add(lblCp);
            Controls.Add(lblNoExt);
            Controls.Add(lblTel);
            Controls.Add(lblColonia);
            Controls.Add(lblCalle);
            Controls.Add(lblNoInt);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(lblNombre);
            Controls.Add(lblRolF);
            Controls.Add(lblUsuarioF);
            Controls.Add(cmbRol);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Administrar";
            Text = "ADMINISTRAR CUENTA";
            Load += Administrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbRol;
        public Label lblRolF;
        public Label lblUsuarioF;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialLabel lblNoInt;
        private MaterialSkin.Controls.MaterialLabel lblContrasenia;
        private MaterialSkin.Controls.MaterialLabel lblTel;
        private MaterialSkin.Controls.MaterialLabel lblColonia;
        private MaterialSkin.Controls.MaterialLabel lblCalle;
        private MaterialSkin.Controls.MaterialLabel lblCorreo;
        private MaterialSkin.Controls.MaterialLabel lblCp;
        private MaterialSkin.Controls.MaterialLabel lblNoExt;
        private MaterialSkin.Controls.MaterialLabel lblCiudad;
        private MaterialSkin.Controls.MaterialLabel lblRol;
        private MaterialSkin.Controls.MaterialLabel lblCif;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasenia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCalle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCif;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNoExt;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCiudad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNoInt;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
        private MaterialSkin.Controls.MaterialRadioButton rbtnDatosPersonales;
        private MaterialSkin.Controls.MaterialRadioButton rbtnDatosFiscales;
    }
}
namespace TT2024_A155
{
    partial class CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuario));
            cmbRol = new ComboBox();
            lblUsuarioLog = new Label();
            lblNombre = new MaterialSkin.Controls.MaterialLabel();
            lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            lblCalle = new MaterialSkin.Controls.MaterialLabel();
            lblContrasenia = new MaterialSkin.Controls.MaterialLabel();
            lblColonia = new MaterialSkin.Controls.MaterialLabel();
            lblCp = new MaterialSkin.Controls.MaterialLabel();
            lblCorreo = new MaterialSkin.Controls.MaterialLabel();
            lblCiudad = new MaterialSkin.Controls.MaterialLabel();
            lblNoExt = new MaterialSkin.Controls.MaterialLabel();
            lblNoInt = new MaterialSkin.Controls.MaterialLabel();
            lblTel = new MaterialSkin.Controls.MaterialLabel();
            lblRol = new MaterialSkin.Controls.MaterialLabel();
            txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtContrasenia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCalle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCiudad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtNoExt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtNoInt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtTel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            errorNombre = new ErrorProvider(components);
            errorUsuario = new ErrorProvider(components);
            errorContrasenia = new ErrorProvider(components);
            errorCalle = new ErrorProvider(components);
            errorColonia = new ErrorProvider(components);
            errorCP = new ErrorProvider(components);
            errorTelefono = new ErrorProvider(components);
            errorNoExt = new ErrorProvider(components);
            errorNoInt = new ErrorProvider(components);
            errorCiudad = new ErrorProvider(components);
            errorCorreo = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorNombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorContrasenia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorCalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorColonia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorCP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorTelefono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoInt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorCiudad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorCorreo).BeginInit();
            SuspendLayout();
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Ventas", "Finanzas", "Cliente" });
            cmbRol.Location = new Point(143, 400);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(206, 28);
            cmbRol.TabIndex = 87;
            // 
            // lblUsuarioLog
            // 
            lblUsuarioLog.AutoSize = true;
            lblUsuarioLog.Location = new Point(810, 34);
            lblUsuarioLog.Name = "lblUsuarioLog";
            lblUsuarioLog.Size = new Size(0, 20);
            lblUsuarioLog.TabIndex = 89;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Depth = 0;
            lblNombre.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNombre.Location = new Point(15, 90);
            lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(84, 24);
            lblNombre.TabIndex = 90;
            lblNombre.Text = "Nombre:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Depth = 0;
            lblUsuario.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblUsuario.Location = new Point(15, 130);
            lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(79, 24);
            lblUsuario.TabIndex = 91;
            lblUsuario.Text = "Usuario:";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Depth = 0;
            lblCalle.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCalle.Location = new Point(65, 230);
            lblCalle.MouseState = MaterialSkin.MouseState.HOVER;
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(57, 24);
            lblCalle.TabIndex = 93;
            lblCalle.Text = "Calle:";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Depth = 0;
            lblContrasenia.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblContrasenia.Location = new Point(15, 170);
            lblContrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(110, 24);
            lblContrasenia.TabIndex = 92;
            lblContrasenia.Text = "Contraseña:";
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.Depth = 0;
            lblColonia.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblColonia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblColonia.Location = new Point(43, 270);
            lblColonia.MouseState = MaterialSkin.MouseState.HOVER;
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(79, 24);
            lblColonia.TabIndex = 94;
            lblColonia.Text = "Colonia:";
            // 
            // lblCp
            // 
            lblCp.AutoSize = true;
            lblCp.Depth = 0;
            lblCp.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCp.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCp.Location = new Point(73, 310);
            lblCp.MouseState = MaterialSkin.MouseState.HOVER;
            lblCp.Name = "lblCp";
            lblCp.Size = new Size(49, 24);
            lblCp.TabIndex = 95;
            lblCp.Text = "C.P.:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Depth = 0;
            lblCorreo.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCorreo.Location = new Point(417, 310);
            lblCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(71, 24);
            lblCorreo.TabIndex = 98;
            lblCorreo.Text = "Correo:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Depth = 0;
            lblCiudad.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCiudad.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCiudad.Location = new Point(414, 270);
            lblCiudad.MouseState = MaterialSkin.MouseState.HOVER;
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(74, 24);
            lblCiudad.TabIndex = 97;
            lblCiudad.Text = "Ciudad:";
            // 
            // lblNoExt
            // 
            lblNoExt.AutoSize = true;
            lblNoExt.Depth = 0;
            lblNoExt.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoExt.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNoExt.Location = new Point(407, 230);
            lblNoExt.MouseState = MaterialSkin.MouseState.HOVER;
            lblNoExt.Name = "lblNoExt";
            lblNoExt.Size = new Size(81, 24);
            lblNoExt.TabIndex = 96;
            lblNoExt.Text = "No. Ext.:";
            // 
            // lblNoInt
            // 
            lblNoInt.AutoSize = true;
            lblNoInt.Depth = 0;
            lblNoInt.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoInt.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNoInt.Location = new Point(676, 230);
            lblNoInt.MouseState = MaterialSkin.MouseState.HOVER;
            lblNoInt.Name = "lblNoInt";
            lblNoInt.Size = new Size(76, 24);
            lblNoInt.TabIndex = 99;
            lblNoInt.Text = "No. Int.:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Depth = 0;
            lblTel.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTel.Location = new Point(32, 360);
            lblTel.MouseState = MaterialSkin.MouseState.HOVER;
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(90, 24);
            lblTel.TabIndex = 100;
            lblTel.Text = "Telefono:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Depth = 0;
            lblRol.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblRol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblRol.Location = new Point(79, 400);
            lblRol.MouseState = MaterialSkin.MouseState.HOVER;
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(43, 24);
            lblRol.TabIndex = 101;
            lblRol.Text = "Rol:";
            // 
            // txtNombre
            // 
            txtNombre.Depth = 0;
            txtNombre.Hint = "";
            txtNombre.Location = new Point(143, 90);
            txtNombre.MaxLength = 32767;
            txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.SelectedText = "";
            txtNombre.SelectionLength = 0;
            txtNombre.SelectionStart = 0;
            txtNombre.Size = new Size(258, 28);
            txtNombre.TabIndex = 102;
            txtNombre.TabStop = false;
            txtNombre.UseSystemPasswordChar = false;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtUsuario
            // 
            txtUsuario.Depth = 0;
            txtUsuario.Hint = "";
            txtUsuario.Location = new Point(143, 130);
            txtUsuario.MaxLength = 32767;
            txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '\0';
            txtUsuario.SelectedText = "";
            txtUsuario.SelectionLength = 0;
            txtUsuario.SelectionStart = 0;
            txtUsuario.Size = new Size(206, 28);
            txtUsuario.TabIndex = 103;
            txtUsuario.TabStop = false;
            txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Depth = 0;
            txtContrasenia.Hint = "";
            txtContrasenia.Location = new Point(143, 170);
            txtContrasenia.MaxLength = 32767;
            txtContrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '\0';
            txtContrasenia.SelectedText = "";
            txtContrasenia.SelectionLength = 0;
            txtContrasenia.SelectionStart = 0;
            txtContrasenia.Size = new Size(206, 28);
            txtContrasenia.TabIndex = 104;
            txtContrasenia.TabStop = false;
            txtContrasenia.UseSystemPasswordChar = false;
            // 
            // txtCP
            // 
            txtCP.Depth = 0;
            txtCP.Hint = "";
            txtCP.Location = new Point(143, 310);
            txtCP.MaxLength = 32767;
            txtCP.MouseState = MaterialSkin.MouseState.HOVER;
            txtCP.Name = "txtCP";
            txtCP.PasswordChar = '\0';
            txtCP.SelectedText = "";
            txtCP.SelectionLength = 0;
            txtCP.SelectionStart = 0;
            txtCP.Size = new Size(127, 28);
            txtCP.TabIndex = 107;
            txtCP.TabStop = false;
            txtCP.UseSystemPasswordChar = false;
            txtCP.KeyPress += txtCP_KeyPress;
            // 
            // txtCol
            // 
            txtCol.Depth = 0;
            txtCol.Hint = "";
            txtCol.Location = new Point(143, 270);
            txtCol.MaxLength = 32767;
            txtCol.MouseState = MaterialSkin.MouseState.HOVER;
            txtCol.Name = "txtCol";
            txtCol.PasswordChar = '\0';
            txtCol.SelectedText = "";
            txtCol.SelectionLength = 0;
            txtCol.SelectionStart = 0;
            txtCol.Size = new Size(206, 28);
            txtCol.TabIndex = 106;
            txtCol.TabStop = false;
            txtCol.UseSystemPasswordChar = false;
            // 
            // txtCalle
            // 
            txtCalle.Depth = 0;
            txtCalle.Hint = "";
            txtCalle.Location = new Point(143, 230);
            txtCalle.MaxLength = 32767;
            txtCalle.MouseState = MaterialSkin.MouseState.HOVER;
            txtCalle.Name = "txtCalle";
            txtCalle.PasswordChar = '\0';
            txtCalle.SelectedText = "";
            txtCalle.SelectionLength = 0;
            txtCalle.SelectionStart = 0;
            txtCalle.Size = new Size(206, 28);
            txtCalle.TabIndex = 105;
            txtCalle.TabStop = false;
            txtCalle.UseSystemPasswordChar = false;
            // 
            // txtCorreo
            // 
            txtCorreo.Depth = 0;
            txtCorreo.Hint = "";
            txtCorreo.Location = new Point(519, 310);
            txtCorreo.MaxLength = 32767;
            txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PasswordChar = '\0';
            txtCorreo.SelectedText = "";
            txtCorreo.SelectionLength = 0;
            txtCorreo.SelectionStart = 0;
            txtCorreo.Size = new Size(233, 28);
            txtCorreo.TabIndex = 110;
            txtCorreo.TabStop = false;
            txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtCiudad
            // 
            txtCiudad.Depth = 0;
            txtCiudad.Hint = "";
            txtCiudad.Location = new Point(519, 270);
            txtCiudad.MaxLength = 32767;
            txtCiudad.MouseState = MaterialSkin.MouseState.HOVER;
            txtCiudad.Name = "txtCiudad";
            txtCiudad.PasswordChar = '\0';
            txtCiudad.SelectedText = "";
            txtCiudad.SelectionLength = 0;
            txtCiudad.SelectionStart = 0;
            txtCiudad.Size = new Size(233, 28);
            txtCiudad.TabIndex = 109;
            txtCiudad.TabStop = false;
            txtCiudad.UseSystemPasswordChar = false;
            // 
            // txtNoExt
            // 
            txtNoExt.Depth = 0;
            txtNoExt.Hint = "";
            txtNoExt.Location = new Point(519, 230);
            txtNoExt.MaxLength = 32767;
            txtNoExt.MouseState = MaterialSkin.MouseState.HOVER;
            txtNoExt.Name = "txtNoExt";
            txtNoExt.PasswordChar = '\0';
            txtNoExt.SelectedText = "";
            txtNoExt.SelectionLength = 0;
            txtNoExt.SelectionStart = 0;
            txtNoExt.Size = new Size(127, 28);
            txtNoExt.TabIndex = 108;
            txtNoExt.TabStop = false;
            txtNoExt.UseSystemPasswordChar = false;
            txtNoExt.KeyPress += txtNoExt_KeyPress;
            // 
            // txtNoInt
            // 
            txtNoInt.Depth = 0;
            txtNoInt.Hint = "";
            txtNoInt.Location = new Point(791, 230);
            txtNoInt.MaxLength = 32767;
            txtNoInt.MouseState = MaterialSkin.MouseState.HOVER;
            txtNoInt.Name = "txtNoInt";
            txtNoInt.PasswordChar = '\0';
            txtNoInt.SelectedText = "";
            txtNoInt.SelectionLength = 0;
            txtNoInt.SelectionStart = 0;
            txtNoInt.Size = new Size(86, 28);
            txtNoInt.TabIndex = 111;
            txtNoInt.TabStop = false;
            txtNoInt.UseSystemPasswordChar = false;
            txtNoInt.KeyPress += txtNoInt_KeyPress;
            // 
            // txtTel
            // 
            txtTel.Depth = 0;
            txtTel.Hint = "";
            txtTel.Location = new Point(143, 360);
            txtTel.MaxLength = 32767;
            txtTel.MouseState = MaterialSkin.MouseState.HOVER;
            txtTel.Name = "txtTel";
            txtTel.PasswordChar = '\0';
            txtTel.SelectedText = "";
            txtTel.SelectionLength = 0;
            txtTel.SelectionStart = 0;
            txtTel.Size = new Size(206, 28);
            txtTel.TabIndex = 112;
            txtTel.TabStop = false;
            txtTel.UseSystemPasswordChar = false;
            txtTel.KeyPress += txtTel_KeyPress;
            // 
            // btnAceptar
            // 
            btnAceptar.AutoSize = true;
            btnAceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAceptar.Depth = 0;
            btnAceptar.Icon = null;
            btnAceptar.Location = new Point(779, 395);
            btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Primary = true;
            btnAceptar.Size = new Size(98, 36);
            btnAceptar.TabIndex = 113;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // errorNombre
            // 
            errorNombre.ContainerControl = this;
            // 
            // errorUsuario
            // 
            errorUsuario.ContainerControl = this;
            // 
            // errorContrasenia
            // 
            errorContrasenia.ContainerControl = this;
            // 
            // errorCalle
            // 
            errorCalle.ContainerControl = this;
            // 
            // errorColonia
            // 
            errorColonia.ContainerControl = this;
            // 
            // errorCP
            // 
            errorCP.ContainerControl = this;
            // 
            // errorTelefono
            // 
            errorTelefono.ContainerControl = this;
            // 
            // errorNoExt
            // 
            errorNoExt.ContainerControl = this;
            // 
            // errorNoInt
            // 
            errorNoInt.ContainerControl = this;
            // 
            // errorCiudad
            // 
            errorCiudad.ContainerControl = this;
            // 
            // errorCorreo
            // 
            errorCorreo.ContainerControl = this;
            // 
            // CrearUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 464);
            Controls.Add(btnAceptar);
            Controls.Add(txtTel);
            Controls.Add(txtNoInt);
            Controls.Add(txtCorreo);
            Controls.Add(txtCiudad);
            Controls.Add(txtNoExt);
            Controls.Add(txtCP);
            Controls.Add(txtCol);
            Controls.Add(txtCalle);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombre);
            Controls.Add(lblRol);
            Controls.Add(lblTel);
            Controls.Add(lblNoInt);
            Controls.Add(lblCorreo);
            Controls.Add(lblCiudad);
            Controls.Add(lblNoExt);
            Controls.Add(lblCp);
            Controls.Add(lblColonia);
            Controls.Add(lblCalle);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(lblNombre);
            Controls.Add(lblUsuarioLog);
            Controls.Add(cmbRol);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CrearUsuario";
            Text = "CREAR NUEVO USUARIO";
            Load += CrearUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)errorNombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorContrasenia).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorCalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorColonia).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorCP).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorTelefono).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoInt).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorCiudad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorCorreo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbRol;
        public Label lblUsuarioLog;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialLabel lblCalle;
        private MaterialSkin.Controls.MaterialLabel lblContrasenia;
        private MaterialSkin.Controls.MaterialLabel lblColonia;
        private MaterialSkin.Controls.MaterialLabel lblCp;
        private MaterialSkin.Controls.MaterialLabel lblCorreo;
        private MaterialSkin.Controls.MaterialLabel lblCiudad;
        private MaterialSkin.Controls.MaterialLabel lblNoExt;
        private MaterialSkin.Controls.MaterialLabel lblNoInt;
        private MaterialSkin.Controls.MaterialLabel lblTel;
        private MaterialSkin.Controls.MaterialLabel lblRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasenia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCalle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCiudad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNoExt;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNoInt;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTel;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
        private ErrorProvider errorNombre;
        private ErrorProvider errorUsuario;
        private ErrorProvider errorContrasenia;
        private ErrorProvider errorCalle;
        private ErrorProvider errorColonia;
        private ErrorProvider errorCP;
        private ErrorProvider errorTelefono;
        private ErrorProvider errorNoExt;
        private ErrorProvider errorNoInt;
        private ErrorProvider errorCiudad;
        private ErrorProvider errorCorreo;
    }
}
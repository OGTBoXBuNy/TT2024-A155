namespace TT2024_A155
{
    partial class ModificarUsuario
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
            txtCif = new TextBox();
            lblCif = new Label();
            rbtnDatosFiscales = new RadioButton();
            rbtnDatosPersonales = new RadioButton();
            txtNoInt = new TextBox();
            txtCorreo = new TextBox();
            txtCiudad = new TextBox();
            txtNoExt = new TextBox();
            txtCol = new TextBox();
            txtTel = new TextBox();
            txtCP = new TextBox();
            txtCalle = new TextBox();
            lblCorreo = new Label();
            lblTel = new Label();
            lblCiudad = new Label();
            lblCp = new Label();
            lblNoInt = new Label();
            lblNoExt = new Label();
            lblColonia = new Label();
            lblCalle = new Label();
            btnAceptar = new Button();
            txtNombre = new TextBox();
            lblRol = new Label();
            lblNombre = new Label();
            lblContrasenia = new Label();
            lblUsuario = new Label();
            cmbRol = new ComboBox();
            txtContrasenia = new TextBox();
            txtUsuario = new TextBox();
            lblTitle = new Label();
            rbtnPermisos = new RadioButton();
            cmbNombreUsuario = new ComboBox();
            lblCliente = new Label();
            SuspendLayout();
            // 
            // txtCif
            // 
            txtCif.Location = new Point(342, 360);
            txtCif.Name = "txtCif";
            txtCif.Size = new Size(210, 27);
            txtCif.TabIndex = 66;
            // 
            // lblCif
            // 
            lblCif.AutoSize = true;
            lblCif.Location = new Point(292, 368);
            lblCif.Name = "lblCif";
            lblCif.Size = new Size(36, 20);
            lblCif.TabIndex = 79;
            lblCif.Text = "CIF: ";
            // 
            // rbtnDatosFiscales
            // 
            rbtnDatosFiscales.AutoSize = true;
            rbtnDatosFiscales.Location = new Point(498, 62);
            rbtnDatosFiscales.Name = "rbtnDatosFiscales";
            rbtnDatosFiscales.Size = new Size(123, 24);
            rbtnDatosFiscales.TabIndex = 52;
            rbtnDatosFiscales.Text = "Datos Fiscales";
            rbtnDatosFiscales.UseVisualStyleBackColor = true;
            rbtnDatosFiscales.CheckedChanged += rbtnDatosFiscales_CheckedChanged;
            // 
            // rbtnDatosPersonales
            // 
            rbtnDatosPersonales.AutoSize = true;
            rbtnDatosPersonales.Checked = true;
            rbtnDatosPersonales.Location = new Point(324, 62);
            rbtnDatosPersonales.Name = "rbtnDatosPersonales";
            rbtnDatosPersonales.Size = new Size(142, 24);
            rbtnDatosPersonales.TabIndex = 51;
            rbtnDatosPersonales.TabStop = true;
            rbtnDatosPersonales.Text = "Datos Personales";
            rbtnDatosPersonales.UseVisualStyleBackColor = true;
            rbtnDatosPersonales.CheckedChanged += rbtnDatosPersonales_CheckedChanged;
            // 
            // txtNoInt
            // 
            txtNoInt.Location = new Point(605, 231);
            txtNoInt.Name = "txtNoInt";
            txtNoInt.Size = new Size(73, 27);
            txtNoInt.TabIndex = 60;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(448, 317);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(347, 27);
            txtCorreo.TabIndex = 68;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(636, 277);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(159, 27);
            txtCiudad.TabIndex = 65;
            // 
            // txtNoExt
            // 
            txtNoExt.Location = new Point(448, 231);
            txtNoExt.Name = "txtNoExt";
            txtNoExt.Size = new Size(74, 27);
            txtNoExt.TabIndex = 59;
            // 
            // txtCol
            // 
            txtCol.Location = new Point(99, 273);
            txtCol.Name = "txtCol";
            txtCol.Size = new Size(268, 27);
            txtCol.TabIndex = 62;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(99, 317);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(268, 27);
            txtTel.TabIndex = 67;
            // 
            // txtCP
            // 
            txtCP.Location = new Point(448, 277);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(104, 27);
            txtCP.TabIndex = 63;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(99, 231);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(268, 27);
            txtCalle.TabIndex = 58;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(380, 324);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 78;
            lblCorreo.Text = "Correo:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(7, 324);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(70, 20);
            lblTel.TabIndex = 77;
            lblTel.Text = "Telefono:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(571, 284);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(59, 20);
            lblCiudad.TabIndex = 76;
            lblCiudad.Text = "Ciudad:";
            // 
            // lblCp
            // 
            lblCp.AutoSize = true;
            lblCp.Location = new Point(380, 280);
            lblCp.Name = "lblCp";
            lblCp.Size = new Size(35, 20);
            lblCp.TabIndex = 75;
            lblCp.Text = "C.P.:";
            // 
            // lblNoInt
            // 
            lblNoInt.AutoSize = true;
            lblNoInt.Location = new Point(540, 238);
            lblNoInt.Name = "lblNoInt";
            lblNoInt.Size = new Size(59, 20);
            lblNoInt.TabIndex = 74;
            lblNoInt.Text = "No. Int.:";
            // 
            // lblNoExt
            // 
            lblNoExt.AutoSize = true;
            lblNoExt.Location = new Point(380, 238);
            lblNoExt.Name = "lblNoExt";
            lblNoExt.Size = new Size(62, 20);
            lblNoExt.TabIndex = 73;
            lblNoExt.Text = "No. Ext.:";
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.Location = new Point(7, 280);
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(63, 20);
            lblColonia.TabIndex = 72;
            lblColonia.Text = "Colonia:";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(7, 238);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(45, 20);
            lblCalle.TabIndex = 71;
            lblCalle.Text = "Calle:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(690, 358);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 70;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(99, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(273, 27);
            txtNombre.TabIndex = 53;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(7, 367);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(34, 20);
            lblRol.TabIndex = 64;
            lblRol.Text = "Rol:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(7, 110);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 61;
            lblNombre.Text = "Nombre:";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(7, 179);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(86, 20);
            lblContrasenia.TabIndex = 56;
            lblContrasenia.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(7, 146);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 55;
            lblUsuario.Text = "Usuario:";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Ventas", "Finanzas", "Cliente" });
            cmbRol.Location = new Point(99, 360);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(151, 28);
            cmbRol.TabIndex = 69;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(99, 172);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(273, 27);
            txtContrasenia.TabIndex = 57;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(99, 139);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(273, 27);
            txtUsuario.TabIndex = 54;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(342, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(161, 20);
            lblTitle.TabIndex = 80;
            lblTitle.Text = "MODIFICAR USUARIOS";
            // 
            // rbtnPermisos
            // 
            rbtnPermisos.AutoSize = true;
            rbtnPermisos.Location = new Point(661, 62);
            rbtnPermisos.Name = "rbtnPermisos";
            rbtnPermisos.Size = new Size(88, 24);
            rbtnPermisos.TabIndex = 81;
            rbtnPermisos.Text = "Permisos";
            rbtnPermisos.UseVisualStyleBackColor = true;
            rbtnPermisos.CheckedChanged += rbtnPermisos_CheckedChanged;
            // 
            // cmbNombreUsuario
            // 
            cmbNombreUsuario.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbNombreUsuario.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbNombreUsuario.FormattingEnabled = true;
            cmbNombreUsuario.Location = new Point(99, 56);
            cmbNombreUsuario.Name = "cmbNombreUsuario";
            cmbNombreUsuario.Size = new Size(189, 28);
            cmbNombreUsuario.TabIndex = 83;
            cmbNombreUsuario.SelectedIndexChanged += cmbNombreUsuario_SelectedIndexChanged;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(7, 64);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(62, 20);
            lblCliente.TabIndex = 82;
            lblCliente.Text = "Usuario:";
            // 
            // ModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbNombreUsuario);
            Controls.Add(lblCliente);
            Controls.Add(rbtnPermisos);
            Controls.Add(lblTitle);
            Controls.Add(txtCif);
            Controls.Add(lblCif);
            Controls.Add(rbtnDatosFiscales);
            Controls.Add(rbtnDatosPersonales);
            Controls.Add(txtNoInt);
            Controls.Add(txtCorreo);
            Controls.Add(txtCiudad);
            Controls.Add(txtNoExt);
            Controls.Add(txtCol);
            Controls.Add(txtTel);
            Controls.Add(txtCP);
            Controls.Add(txtCalle);
            Controls.Add(lblCorreo);
            Controls.Add(lblTel);
            Controls.Add(lblCiudad);
            Controls.Add(lblCp);
            Controls.Add(lblNoInt);
            Controls.Add(lblNoExt);
            Controls.Add(lblColonia);
            Controls.Add(lblCalle);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombre);
            Controls.Add(lblRol);
            Controls.Add(lblNombre);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(cmbRol);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Name = "ModificarUsuario";
            Text = "ModificarUsuario";
            Load += ModificarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCif;
        private Label lblCif;
        private RadioButton rbtnDatosFiscales;
        private RadioButton rbtnDatosPersonales;
        private TextBox txtNoInt;
        private TextBox txtCorreo;
        private TextBox txtCiudad;
        private TextBox txtNoExt;
        private TextBox txtCol;
        private TextBox txtTel;
        private TextBox txtCP;
        private TextBox txtCalle;
        private Label lblCorreo;
        private Label lblTel;
        private Label lblCiudad;
        private Label lblCp;
        private Label lblNoInt;
        private Label lblNoExt;
        private Label lblColonia;
        private Label lblCalle;
        private Button btnAceptar;
        private TextBox txtNombre;
        private Label lblRol;
        private Label lblNombre;
        private Label lblContrasenia;
        private Label lblUsuario;
        private ComboBox cmbRol;
        private TextBox txtContrasenia;
        private TextBox txtUsuario;
        private Label lblTitle;
        private RadioButton rbtnPermisos;
        private ComboBox cmbNombreUsuario;
        private Label lblCliente;
    }
}
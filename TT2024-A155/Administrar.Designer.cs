﻿namespace TT2024_A155
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
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            cmbRol = new ComboBox();
            lblUsuario = new Label();
            lblContrasenia = new Label();
            lblNombre = new Label();
            lblRol = new Label();
            txtNombre = new TextBox();
            btnAceptar = new Button();
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
            lblTitle = new Label();
            rbtnDatosPersonales = new RadioButton();
            rbtnDatosFiscales = new RadioButton();
            lblRolF = new Label();
            lblUsuarioF = new Label();
            txtCif = new TextBox();
            lblCif = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(171, 139);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(171, 195);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(125, 27);
            txtContrasenia.TabIndex = 2;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Ventas", "Finanzas", "Cliente" });
            cmbRol.Location = new Point(171, 425);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(151, 28);
            cmbRol.TabIndex = 6;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(14, 146);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(14, 202);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(86, 20);
            lblContrasenia.TabIndex = 5;
            lblContrasenia.Text = "Contraseña:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(14, 86);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(14, 433);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(34, 20);
            lblRol.TabIndex = 10;
            lblRol.Text = "Rol:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(171, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(453, 400);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtNoInt
            // 
            txtNoInt.Location = new Point(588, 277);
            txtNoInt.Name = "txtNoInt";
            txtNoInt.Size = new Size(53, 27);
            txtNoInt.TabIndex = 44;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(349, 366);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(159, 27);
            txtCorreo.TabIndex = 43;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(349, 324);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(159, 27);
            txtCiudad.TabIndex = 42;
            // 
            // txtNoExt
            // 
            txtNoExt.Location = new Point(349, 281);
            txtNoExt.Name = "txtNoExt";
            txtNoExt.Size = new Size(159, 27);
            txtNoExt.TabIndex = 41;
            // 
            // txtCol
            // 
            txtCol.Location = new Point(89, 244);
            txtCol.Name = "txtCol";
            txtCol.Size = new Size(159, 27);
            txtCol.TabIndex = 40;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(89, 364);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(159, 27);
            txtTel.TabIndex = 39;
            // 
            // txtCP
            // 
            txtCP.Location = new Point(89, 320);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(159, 27);
            txtCP.TabIndex = 38;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(89, 277);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(159, 27);
            txtCalle.TabIndex = 37;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(280, 371);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 35;
            lblCorreo.Text = "Correo:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(13, 371);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(70, 20);
            lblTel.TabIndex = 34;
            lblTel.Text = "Telefono:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(280, 327);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(59, 20);
            lblCiudad.TabIndex = 33;
            lblCiudad.Text = "Ciudad:";
            // 
            // lblCp
            // 
            lblCp.AutoSize = true;
            lblCp.Location = new Point(13, 327);
            lblCp.Name = "lblCp";
            lblCp.Size = new Size(35, 20);
            lblCp.TabIndex = 32;
            lblCp.Text = "C.P.:";
            // 
            // lblNoInt
            // 
            lblNoInt.AutoSize = true;
            lblNoInt.Location = new Point(523, 284);
            lblNoInt.Name = "lblNoInt";
            lblNoInt.Size = new Size(59, 20);
            lblNoInt.TabIndex = 31;
            lblNoInt.Text = "No. Int.:";
            // 
            // lblNoExt
            // 
            lblNoExt.AutoSize = true;
            lblNoExt.Location = new Point(280, 284);
            lblNoExt.Name = "lblNoExt";
            lblNoExt.Size = new Size(62, 20);
            lblNoExt.TabIndex = 30;
            lblNoExt.Text = "No. Ext.:";
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.Location = new Point(20, 251);
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(63, 20);
            lblColonia.TabIndex = 29;
            lblColonia.Text = "Colonia:";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(13, 284);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(45, 20);
            lblCalle.TabIndex = 28;
            lblCalle.Text = "Calle:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(349, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(165, 20);
            lblTitle.TabIndex = 45;
            lblTitle.Text = "ADMINISTRAR CUENTA";
            // 
            // rbtnDatosPersonales
            // 
            rbtnDatosPersonales.AutoSize = true;
            rbtnDatosPersonales.Checked = true;
            rbtnDatosPersonales.Location = new Point(12, 38);
            rbtnDatosPersonales.Name = "rbtnDatosPersonales";
            rbtnDatosPersonales.Size = new Size(142, 24);
            rbtnDatosPersonales.TabIndex = 46;
            rbtnDatosPersonales.TabStop = true;
            rbtnDatosPersonales.Text = "Datos Personales";
            rbtnDatosPersonales.UseVisualStyleBackColor = true;
            rbtnDatosPersonales.CheckedChanged += rbtnDatosPersonales_CheckedChanged;
            // 
            // rbtnDatosFiscales
            // 
            rbtnDatosFiscales.AutoSize = true;
            rbtnDatosFiscales.Location = new Point(186, 38);
            rbtnDatosFiscales.Name = "rbtnDatosFiscales";
            rbtnDatosFiscales.Size = new Size(123, 24);
            rbtnDatosFiscales.TabIndex = 47;
            rbtnDatosFiscales.Text = "Datos Fiscales";
            rbtnDatosFiscales.UseVisualStyleBackColor = true;
            rbtnDatosFiscales.CheckedChanged += rbtnDatosFiscales_CheckedChanged;
            // 
            // lblRolF
            // 
            lblRolF.AutoSize = true;
            lblRolF.Location = new Point(791, 38);
            lblRolF.Name = "lblRolF";
            lblRolF.Size = new Size(36, 20);
            lblRolF.TabIndex = 49;
            lblRolF.Text = "ROL";
            // 
            // lblUsuarioF
            // 
            lblUsuarioF.AutoSize = true;
            lblUsuarioF.Location = new Point(791, 10);
            lblUsuarioF.Name = "lblUsuarioF";
            lblUsuarioF.Size = new Size(0, 20);
            lblUsuarioF.TabIndex = 48;
            // 
            // txtCif
            // 
            txtCif.Location = new Point(588, 324);
            txtCif.Name = "txtCif";
            txtCif.Size = new Size(139, 27);
            txtCif.TabIndex = 51;
            // 
            // lblCif
            // 
            lblCif.AutoSize = true;
            lblCif.Location = new Point(523, 331);
            lblCif.Name = "lblCif";
            lblCif.Size = new Size(36, 20);
            lblCif.TabIndex = 50;
            lblCif.Text = "CIF: ";
            // 
            // Administrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 507);
            Controls.Add(txtCif);
            Controls.Add(lblCif);
            Controls.Add(lblRolF);
            Controls.Add(lblUsuarioF);
            Controls.Add(rbtnDatosFiscales);
            Controls.Add(rbtnDatosPersonales);
            Controls.Add(lblTitle);
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
            Name = "Administrar";
            Text = "Administrar";
            Load += Administrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private ComboBox cmbRol;
        private Label lblUsuario;
        private Label lblContrasenia;
        private Label lblNombre;
        private Label lblRol;
        private TextBox txtNombre;
        private Button btnAceptar;
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
        private Label lblTitle;
        private RadioButton rbtnDatosPersonales;
        private RadioButton rbtnDatosFiscales;
        public Label lblRolF;
        public Label lblUsuarioF;
        private TextBox txtCif;
        private Label lblCif;
    }
}
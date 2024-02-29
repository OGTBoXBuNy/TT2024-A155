namespace TT2024_A155
{
    partial class registrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrarCliente));
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
            lblNombre = new Label();
            lblContrasenia = new Label();
            lblUsuario = new Label();
            txtContrasenia = new TextBox();
            txtUsuario = new TextBox();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // txtNoInt
            // 
            txtNoInt.Location = new Point(670, 198);
            txtNoInt.Name = "txtNoInt";
            txtNoInt.Size = new Size(68, 27);
            txtNoInt.TabIndex = 5;
            txtNoInt.KeyPress += txtNoInt_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(421, 283);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(159, 27);
            txtCorreo.TabIndex = 9;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(421, 240);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(159, 27);
            txtCiudad.TabIndex = 7;
            // 
            // txtNoExt
            // 
            txtNoExt.Location = new Point(420, 198);
            txtNoExt.Name = "txtNoExt";
            txtNoExt.Size = new Size(159, 27);
            txtNoExt.TabIndex = 4;
            txtNoExt.KeyPress += txtNoExt_KeyPress;
            // 
            // txtCol
            // 
            txtCol.Location = new Point(97, 236);
            txtCol.Name = "txtCol";
            txtCol.Size = new Size(226, 27);
            txtCol.TabIndex = 6;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(104, 330);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(159, 27);
            txtTel.TabIndex = 10;
            txtTel.KeyPress += txtTel_KeyPress;
            // 
            // txtCP
            // 
            txtCP.Location = new Point(97, 279);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(226, 27);
            txtCP.TabIndex = 8;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(97, 194);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(226, 27);
            txtCalle.TabIndex = 3;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(357, 286);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 61;
            lblCorreo.Text = "Correo:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(28, 337);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(70, 20);
            lblTel.TabIndex = 60;
            lblTel.Text = "Telefono:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(355, 243);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(59, 20);
            lblCiudad.TabIndex = 59;
            lblCiudad.Text = "Ciudad:";
            // 
            // lblCp
            // 
            lblCp.AutoSize = true;
            lblCp.Location = new Point(56, 286);
            lblCp.Name = "lblCp";
            lblCp.Size = new Size(35, 20);
            lblCp.TabIndex = 58;
            lblCp.Text = "C.P.:";
            // 
            // lblNoInt
            // 
            lblNoInt.AutoSize = true;
            lblNoInt.Location = new Point(596, 201);
            lblNoInt.Name = "lblNoInt";
            lblNoInt.Size = new Size(59, 20);
            lblNoInt.TabIndex = 57;
            lblNoInt.Text = "No. Int.:";
            // 
            // lblNoExt
            // 
            lblNoExt.AutoSize = true;
            lblNoExt.Location = new Point(352, 201);
            lblNoExt.Name = "lblNoExt";
            lblNoExt.Size = new Size(62, 20);
            lblNoExt.TabIndex = 56;
            lblNoExt.Text = "No. Ext.:";
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.Location = new Point(28, 243);
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(63, 20);
            lblColonia.TabIndex = 55;
            lblColonia.Text = "Colonia:";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(46, 201);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(45, 20);
            lblCalle.TabIndex = 54;
            lblCalle.Text = "Calle:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(463, 337);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(97, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 27);
            txtNombre.TabIndex = 0;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(5, 66);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 52;
            lblNombre.Text = "Nombre:";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(5, 145);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(86, 20);
            lblContrasenia.TabIndex = 49;
            lblContrasenia.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(5, 108);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 48;
            lblUsuario.Text = "Usuario:";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(97, 138);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(300, 27);
            txtContrasenia.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(97, 101);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 27);
            txtUsuario.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(310, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(188, 20);
            lblTitulo.TabIndex = 62;
            lblTitulo.Text = "REGISTRO NUEVO CLIENTE";
            // 
            // registrarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
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
            Controls.Add(lblNombre);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "registrarCliente";
            Text = "REGRISTRO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label lblNombre;
        private Label lblContrasenia;
        private Label lblUsuario;
        private TextBox txtContrasenia;
        private TextBox txtUsuario;
        private Label lblTitulo;
    }
}
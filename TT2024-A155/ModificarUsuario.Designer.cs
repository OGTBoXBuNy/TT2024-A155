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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarUsuario));
            cmbRol = new ComboBox();
            rbtnPermisos = new RadioButton();
            cmbNombreUsuario = new ComboBox();
            panelDatos = new Panel();
            PicOJO = new PictureBox();
            btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            txtCif = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCiudad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtNoInt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtNoExt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtTel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCalle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtContrasenia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblRol = new MaterialSkin.Controls.MaterialLabel();
            lblCif = new MaterialSkin.Controls.MaterialLabel();
            lblCiudad = new MaterialSkin.Controls.MaterialLabel();
            lblNoInt = new MaterialSkin.Controls.MaterialLabel();
            lblCorreo = new MaterialSkin.Controls.MaterialLabel();
            lblCp = new MaterialSkin.Controls.MaterialLabel();
            lblNoExt = new MaterialSkin.Controls.MaterialLabel();
            lblTel = new MaterialSkin.Controls.MaterialLabel();
            lblColonia = new MaterialSkin.Controls.MaterialLabel();
            lblCalle = new MaterialSkin.Controls.MaterialLabel();
            lblContrasenia = new MaterialSkin.Controls.MaterialLabel();
            lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            lblNombre = new MaterialSkin.Controls.MaterialLabel();
            panelPermisos = new Panel();
            label9 = new Label();
            rbtnGenerarReporteF = new RadioButton();
            rbtnGenerarReporteT = new RadioButton();
            label10 = new Label();
            rbtnGenerarFacturaF = new RadioButton();
            rbtnGenerarFacturaT = new RadioButton();
            label5 = new Label();
            rbtnGenerarFirmaF = new RadioButton();
            rbtnGenerarFirmaT = new RadioButton();
            label6 = new Label();
            rbtnRegistrarDevolucionF = new RadioButton();
            rbtnRegistrarDevolucionT = new RadioButton();
            label7 = new Label();
            rbtnRegistrarEntregasF = new RadioButton();
            rbtnRegistrarEntregasT = new RadioButton();
            label8 = new Label();
            rbtnConfirmarPedidoF = new RadioButton();
            rbtnConfirmarPedidoT = new RadioButton();
            label3 = new Label();
            rbtnModificarPedidoF = new RadioButton();
            rbtnModificarPedidoT = new RadioButton();
            label4 = new Label();
            rbtnCrearPedidoF = new RadioButton();
            rbtnCrearPedidoT = new RadioButton();
            label2 = new Label();
            rbtnModificarUsuarioF = new RadioButton();
            rbtnModificarUsuarioT = new RadioButton();
            label1 = new Label();
            rbtnCrearUsuarioF = new RadioButton();
            rbtnCrearUsuarioT = new RadioButton();
            lblUsuarioLog = new Label();
            lblCliente = new MaterialSkin.Controls.MaterialLabel();
            rbtnDatosPersonales = new MaterialSkin.Controls.MaterialRadioButton();
            rbtnDatosFiscales = new MaterialSkin.Controls.MaterialRadioButton();
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
            errorCif = new ErrorProvider(components);
            panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicOJO).BeginInit();
            panelPermisos.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)errorCif).BeginInit();
            SuspendLayout();
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Ventas", "Finanzas", "Cliente" });
            cmbRol.Location = new Point(132, 300);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(213, 28);
            cmbRol.TabIndex = 69;
            // 
            // rbtnPermisos
            // 
            rbtnPermisos.AutoSize = true;
            rbtnPermisos.Enabled = false;
            rbtnPermisos.Location = new Point(1159, 184);
            rbtnPermisos.Name = "rbtnPermisos";
            rbtnPermisos.Size = new Size(88, 24);
            rbtnPermisos.TabIndex = 81;
            rbtnPermisos.Text = "Permisos";
            rbtnPermisos.UseVisualStyleBackColor = true;
            rbtnPermisos.Visible = false;
            // 
            // cmbNombreUsuario
            // 
            cmbNombreUsuario.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbNombreUsuario.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbNombreUsuario.FormattingEnabled = true;
            cmbNombreUsuario.Location = new Point(113, 110);
            cmbNombreUsuario.Name = "cmbNombreUsuario";
            cmbNombreUsuario.Size = new Size(189, 28);
            cmbNombreUsuario.TabIndex = 83;
            cmbNombreUsuario.SelectedIndexChanged += cmbNombreUsuario_SelectedIndexChanged;
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(PicOJO);
            panelDatos.Controls.Add(btnAceptar);
            panelDatos.Controls.Add(txtCif);
            panelDatos.Controls.Add(txtCiudad);
            panelDatos.Controls.Add(txtNoInt);
            panelDatos.Controls.Add(txtCorreo);
            panelDatos.Controls.Add(txtCP);
            panelDatos.Controls.Add(txtNoExt);
            panelDatos.Controls.Add(txtTel);
            panelDatos.Controls.Add(txtCol);
            panelDatos.Controls.Add(txtCalle);
            panelDatos.Controls.Add(txtContrasenia);
            panelDatos.Controls.Add(txtUsuario);
            panelDatos.Controls.Add(txtNombre);
            panelDatos.Controls.Add(lblRol);
            panelDatos.Controls.Add(lblCif);
            panelDatos.Controls.Add(lblCiudad);
            panelDatos.Controls.Add(lblNoInt);
            panelDatos.Controls.Add(lblCorreo);
            panelDatos.Controls.Add(lblCp);
            panelDatos.Controls.Add(lblNoExt);
            panelDatos.Controls.Add(lblTel);
            panelDatos.Controls.Add(lblColonia);
            panelDatos.Controls.Add(lblCalle);
            panelDatos.Controls.Add(lblContrasenia);
            panelDatos.Controls.Add(lblUsuario);
            panelDatos.Controls.Add(lblNombre);
            panelDatos.Controls.Add(cmbRol);
            panelDatos.Location = new Point(12, 184);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(976, 365);
            panelDatos.TabIndex = 84;
            // 
            // PicOJO
            // 
            PicOJO.Image = Properties.Resources.ojo;
            PicOJO.Location = new Point(355, 105);
            PicOJO.Margin = new Padding(4);
            PicOJO.Name = "PicOJO";
            PicOJO.Size = new Size(44, 28);
            PicOJO.SizeMode = PictureBoxSizeMode.Zoom;
            PicOJO.TabIndex = 107;
            PicOJO.TabStop = false;
            PicOJO.Visible = false;
            PicOJO.MouseClick += PicOJO_MouseClick;
            // 
            // btnAceptar
            // 
            btnAceptar.AutoSize = true;
            btnAceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAceptar.Depth = 0;
            btnAceptar.Icon = null;
            btnAceptar.Location = new Point(853, 300);
            btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Primary = true;
            btnAceptar.Size = new Size(98, 36);
            btnAceptar.TabIndex = 106;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtCif
            // 
            txtCif.Depth = 0;
            txtCif.Hint = "";
            txtCif.Location = new Point(500, 300);
            txtCif.MaxLength = 32767;
            txtCif.MouseState = MaterialSkin.MouseState.HOVER;
            txtCif.Name = "txtCif";
            txtCif.PasswordChar = '\0';
            txtCif.SelectedText = "";
            txtCif.SelectionLength = 0;
            txtCif.SelectionStart = 0;
            txtCif.Size = new Size(251, 28);
            txtCif.TabIndex = 105;
            txtCif.TabStop = false;
            txtCif.UseSystemPasswordChar = false;
            // 
            // txtCiudad
            // 
            txtCiudad.Depth = 0;
            txtCiudad.Hint = "";
            txtCiudad.Location = new Point(766, 220);
            txtCiudad.MaxLength = 32767;
            txtCiudad.MouseState = MaterialSkin.MouseState.HOVER;
            txtCiudad.Name = "txtCiudad";
            txtCiudad.PasswordChar = '\0';
            txtCiudad.SelectedText = "";
            txtCiudad.SelectionLength = 0;
            txtCiudad.SelectionStart = 0;
            txtCiudad.Size = new Size(185, 28);
            txtCiudad.TabIndex = 104;
            txtCiudad.TabStop = false;
            txtCiudad.UseSystemPasswordChar = false;
            // 
            // txtNoInt
            // 
            txtNoInt.Depth = 0;
            txtNoInt.Hint = "";
            txtNoInt.Location = new Point(766, 180);
            txtNoInt.MaxLength = 32767;
            txtNoInt.MouseState = MaterialSkin.MouseState.HOVER;
            txtNoInt.Name = "txtNoInt";
            txtNoInt.PasswordChar = '\0';
            txtNoInt.SelectedText = "";
            txtNoInt.SelectionLength = 0;
            txtNoInt.SelectionStart = 0;
            txtNoInt.Size = new Size(124, 28);
            txtNoInt.TabIndex = 103;
            txtNoInt.TabStop = false;
            txtNoInt.UseSystemPasswordChar = false;
            txtNoInt.KeyPress += txtNoInt_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.Depth = 0;
            txtCorreo.Hint = "";
            txtCorreo.Location = new Point(500, 260);
            txtCorreo.MaxLength = 32767;
            txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PasswordChar = '\0';
            txtCorreo.SelectedText = "";
            txtCorreo.SelectionLength = 0;
            txtCorreo.SelectionStart = 0;
            txtCorreo.Size = new Size(251, 28);
            txtCorreo.TabIndex = 102;
            txtCorreo.TabStop = false;
            txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtCP
            // 
            txtCP.Depth = 0;
            txtCP.Hint = "";
            txtCP.Location = new Point(500, 220);
            txtCP.MaxLength = 32767;
            txtCP.MouseState = MaterialSkin.MouseState.HOVER;
            txtCP.Name = "txtCP";
            txtCP.PasswordChar = '\0';
            txtCP.SelectedText = "";
            txtCP.SelectionLength = 0;
            txtCP.SelectionStart = 0;
            txtCP.Size = new Size(124, 28);
            txtCP.TabIndex = 101;
            txtCP.TabStop = false;
            txtCP.UseSystemPasswordChar = false;
            txtCP.KeyPress += txtCP_KeyPress;
            // 
            // txtNoExt
            // 
            txtNoExt.Depth = 0;
            txtNoExt.Hint = "";
            txtNoExt.Location = new Point(500, 180);
            txtNoExt.MaxLength = 32767;
            txtNoExt.MouseState = MaterialSkin.MouseState.HOVER;
            txtNoExt.Name = "txtNoExt";
            txtNoExt.PasswordChar = '\0';
            txtNoExt.SelectedText = "";
            txtNoExt.SelectionLength = 0;
            txtNoExt.SelectionStart = 0;
            txtNoExt.Size = new Size(124, 28);
            txtNoExt.TabIndex = 100;
            txtNoExt.TabStop = false;
            txtNoExt.UseSystemPasswordChar = false;
            txtNoExt.KeyPress += txtNoExt_KeyPress;
            // 
            // txtTel
            // 
            txtTel.Depth = 0;
            txtTel.Hint = "";
            txtTel.Location = new Point(140, 260);
            txtTel.MaxLength = 32767;
            txtTel.MouseState = MaterialSkin.MouseState.HOVER;
            txtTel.Name = "txtTel";
            txtTel.PasswordChar = '\0';
            txtTel.SelectedText = "";
            txtTel.SelectionLength = 0;
            txtTel.SelectionStart = 0;
            txtTel.Size = new Size(205, 28);
            txtTel.TabIndex = 99;
            txtTel.TabStop = false;
            txtTel.UseSystemPasswordChar = false;
            txtTel.KeyPress += txtTel_KeyPress;
            // 
            // txtCol
            // 
            txtCol.Depth = 0;
            txtCol.Hint = "";
            txtCol.Location = new Point(140, 220);
            txtCol.MaxLength = 32767;
            txtCol.MouseState = MaterialSkin.MouseState.HOVER;
            txtCol.Name = "txtCol";
            txtCol.PasswordChar = '\0';
            txtCol.SelectedText = "";
            txtCol.SelectionLength = 0;
            txtCol.SelectionStart = 0;
            txtCol.Size = new Size(205, 28);
            txtCol.TabIndex = 98;
            txtCol.TabStop = false;
            txtCol.UseSystemPasswordChar = false;
            // 
            // txtCalle
            // 
            txtCalle.Depth = 0;
            txtCalle.Hint = "";
            txtCalle.Location = new Point(140, 180);
            txtCalle.MaxLength = 32767;
            txtCalle.MouseState = MaterialSkin.MouseState.HOVER;
            txtCalle.Name = "txtCalle";
            txtCalle.PasswordChar = '\0';
            txtCalle.SelectedText = "";
            txtCalle.SelectionLength = 0;
            txtCalle.SelectionStart = 0;
            txtCalle.Size = new Size(205, 28);
            txtCalle.TabIndex = 97;
            txtCalle.TabStop = false;
            txtCalle.UseSystemPasswordChar = false;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Depth = 0;
            txtContrasenia.Hint = "";
            txtContrasenia.Location = new Point(140, 105);
            txtContrasenia.MaxLength = 32767;
            txtContrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '\0';
            txtContrasenia.SelectedText = "";
            txtContrasenia.SelectionLength = 0;
            txtContrasenia.SelectionStart = 0;
            txtContrasenia.Size = new Size(205, 28);
            txtContrasenia.TabIndex = 96;
            txtContrasenia.TabStop = false;
            txtContrasenia.UseSystemPasswordChar = true;
            txtContrasenia.Enter += txtContrasenia_Enter;
            txtContrasenia.Leave += txtContrasenia_Leave;
            // 
            // txtUsuario
            // 
            txtUsuario.Depth = 0;
            txtUsuario.Hint = "";
            txtUsuario.Location = new Point(140, 65);
            txtUsuario.MaxLength = 32767;
            txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '\0';
            txtUsuario.SelectedText = "";
            txtUsuario.SelectionLength = 0;
            txtUsuario.SelectionStart = 0;
            txtUsuario.Size = new Size(205, 28);
            txtUsuario.TabIndex = 95;
            txtUsuario.TabStop = false;
            txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            txtNombre.Depth = 0;
            txtNombre.Hint = "";
            txtNombre.Location = new Point(140, 25);
            txtNombre.MaxLength = 32767;
            txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.SelectedText = "";
            txtNombre.SelectionLength = 0;
            txtNombre.SelectionStart = 0;
            txtNombre.Size = new Size(283, 28);
            txtNombre.TabIndex = 93;
            txtNombre.TabStop = false;
            txtNombre.UseSystemPasswordChar = false;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Depth = 0;
            lblRol.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblRol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblRol.Location = new Point(83, 300);
            lblRol.MouseState = MaterialSkin.MouseState.HOVER;
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(43, 24);
            lblRol.TabIndex = 92;
            lblRol.Text = "Rol:";
            // 
            // lblCif
            // 
            lblCif.AutoSize = true;
            lblCif.Depth = 0;
            lblCif.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCif.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCif.Location = new Point(432, 300);
            lblCif.MouseState = MaterialSkin.MouseState.HOVER;
            lblCif.Name = "lblCif";
            lblCif.Size = new Size(48, 24);
            lblCif.TabIndex = 91;
            lblCif.Text = "CIF: ";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Depth = 0;
            lblCiudad.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCiudad.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCiudad.Location = new Point(665, 220);
            lblCiudad.MouseState = MaterialSkin.MouseState.HOVER;
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(74, 24);
            lblCiudad.TabIndex = 90;
            lblCiudad.Text = "Ciudad:";
            // 
            // lblNoInt
            // 
            lblNoInt.AutoSize = true;
            lblNoInt.Depth = 0;
            lblNoInt.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoInt.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNoInt.Location = new Point(665, 180);
            lblNoInt.MouseState = MaterialSkin.MouseState.HOVER;
            lblNoInt.Name = "lblNoInt";
            lblNoInt.Size = new Size(76, 24);
            lblNoInt.TabIndex = 89;
            lblNoInt.Text = "No. Int.:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Depth = 0;
            lblCorreo.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCorreo.Location = new Point(410, 260);
            lblCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(71, 24);
            lblCorreo.TabIndex = 88;
            lblCorreo.Text = "Correo:";
            // 
            // lblCp
            // 
            lblCp.AutoSize = true;
            lblCp.Depth = 0;
            lblCp.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCp.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCp.Location = new Point(432, 220);
            lblCp.MouseState = MaterialSkin.MouseState.HOVER;
            lblCp.Name = "lblCp";
            lblCp.Size = new Size(49, 24);
            lblCp.TabIndex = 87;
            lblCp.Text = "C.P.:";
            // 
            // lblNoExt
            // 
            lblNoExt.AutoSize = true;
            lblNoExt.Depth = 0;
            lblNoExt.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoExt.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNoExt.Location = new Point(400, 180);
            lblNoExt.MouseState = MaterialSkin.MouseState.HOVER;
            lblNoExt.Name = "lblNoExt";
            lblNoExt.Size = new Size(81, 24);
            lblNoExt.TabIndex = 86;
            lblNoExt.Text = "No. Ext.:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Depth = 0;
            lblTel.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTel.Location = new Point(36, 260);
            lblTel.MouseState = MaterialSkin.MouseState.HOVER;
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(90, 24);
            lblTel.TabIndex = 85;
            lblTel.Text = "Telefono:";
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.Depth = 0;
            lblColonia.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblColonia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblColonia.Location = new Point(47, 220);
            lblColonia.MouseState = MaterialSkin.MouseState.HOVER;
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(79, 24);
            lblColonia.TabIndex = 84;
            lblColonia.Text = "Colonia:";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Depth = 0;
            lblCalle.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCalle.Location = new Point(69, 180);
            lblCalle.MouseState = MaterialSkin.MouseState.HOVER;
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(57, 24);
            lblCalle.TabIndex = 83;
            lblCalle.Text = "Calle:";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Depth = 0;
            lblContrasenia.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblContrasenia.Location = new Point(16, 105);
            lblContrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(110, 24);
            lblContrasenia.TabIndex = 82;
            lblContrasenia.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Depth = 0;
            lblUsuario.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblUsuario.Location = new Point(16, 65);
            lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(79, 24);
            lblUsuario.TabIndex = 81;
            lblUsuario.Text = "Usuario:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Depth = 0;
            lblNombre.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNombre.Location = new Point(16, 25);
            lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(84, 24);
            lblNombre.TabIndex = 80;
            lblNombre.Text = "Nombre:";
            // 
            // panelPermisos
            // 
            panelPermisos.Controls.Add(label9);
            panelPermisos.Controls.Add(rbtnGenerarReporteF);
            panelPermisos.Controls.Add(rbtnGenerarReporteT);
            panelPermisos.Controls.Add(label10);
            panelPermisos.Controls.Add(rbtnGenerarFacturaF);
            panelPermisos.Controls.Add(rbtnGenerarFacturaT);
            panelPermisos.Controls.Add(label5);
            panelPermisos.Controls.Add(rbtnGenerarFirmaF);
            panelPermisos.Controls.Add(rbtnGenerarFirmaT);
            panelPermisos.Controls.Add(label6);
            panelPermisos.Controls.Add(rbtnRegistrarDevolucionF);
            panelPermisos.Controls.Add(rbtnRegistrarDevolucionT);
            panelPermisos.Controls.Add(label7);
            panelPermisos.Controls.Add(rbtnRegistrarEntregasF);
            panelPermisos.Controls.Add(rbtnRegistrarEntregasT);
            panelPermisos.Controls.Add(label8);
            panelPermisos.Controls.Add(rbtnConfirmarPedidoF);
            panelPermisos.Controls.Add(rbtnConfirmarPedidoT);
            panelPermisos.Controls.Add(label3);
            panelPermisos.Controls.Add(rbtnModificarPedidoF);
            panelPermisos.Controls.Add(rbtnModificarPedidoT);
            panelPermisos.Controls.Add(label4);
            panelPermisos.Controls.Add(rbtnCrearPedidoF);
            panelPermisos.Controls.Add(rbtnCrearPedidoT);
            panelPermisos.Controls.Add(label2);
            panelPermisos.Controls.Add(rbtnModificarUsuarioF);
            panelPermisos.Controls.Add(rbtnModificarUsuarioT);
            panelPermisos.Controls.Add(label1);
            panelPermisos.Controls.Add(rbtnCrearUsuarioF);
            panelPermisos.Controls.Add(rbtnCrearUsuarioT);
            panelPermisos.Enabled = false;
            panelPermisos.Location = new Point(1159, 236);
            panelPermisos.Name = "panelPermisos";
            panelPermisos.Size = new Size(417, 334);
            panelPermisos.TabIndex = 80;
            panelPermisos.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(47, 293);
            label9.Name = "label9";
            label9.Size = new Size(121, 20);
            label9.TabIndex = 29;
            label9.Text = "Generar Reporte:";
            // 
            // rbtnGenerarReporteF
            // 
            rbtnGenerarReporteF.AutoSize = true;
            rbtnGenerarReporteF.Location = new Point(261, 291);
            rbtnGenerarReporteF.Name = "rbtnGenerarReporteF";
            rbtnGenerarReporteF.Size = new Size(50, 24);
            rbtnGenerarReporteF.TabIndex = 28;
            rbtnGenerarReporteF.TabStop = true;
            rbtnGenerarReporteF.Text = "No";
            rbtnGenerarReporteF.UseVisualStyleBackColor = true;
            // 
            // rbtnGenerarReporteT
            // 
            rbtnGenerarReporteT.AutoSize = true;
            rbtnGenerarReporteT.Location = new Point(208, 291);
            rbtnGenerarReporteT.Name = "rbtnGenerarReporteT";
            rbtnGenerarReporteT.Size = new Size(42, 24);
            rbtnGenerarReporteT.TabIndex = 27;
            rbtnGenerarReporteT.TabStop = true;
            rbtnGenerarReporteT.Text = "Si";
            rbtnGenerarReporteT.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(47, 263);
            label10.Name = "label10";
            label10.Size = new Size(115, 20);
            label10.TabIndex = 26;
            label10.Text = "Generar Factura:";
            // 
            // rbtnGenerarFacturaF
            // 
            rbtnGenerarFacturaF.AutoSize = true;
            rbtnGenerarFacturaF.Location = new Point(261, 261);
            rbtnGenerarFacturaF.Name = "rbtnGenerarFacturaF";
            rbtnGenerarFacturaF.Size = new Size(50, 24);
            rbtnGenerarFacturaF.TabIndex = 25;
            rbtnGenerarFacturaF.TabStop = true;
            rbtnGenerarFacturaF.Text = "No";
            rbtnGenerarFacturaF.UseVisualStyleBackColor = true;
            // 
            // rbtnGenerarFacturaT
            // 
            rbtnGenerarFacturaT.AutoSize = true;
            rbtnGenerarFacturaT.Location = new Point(208, 261);
            rbtnGenerarFacturaT.Name = "rbtnGenerarFacturaT";
            rbtnGenerarFacturaT.Size = new Size(42, 24);
            rbtnGenerarFacturaT.TabIndex = 24;
            rbtnGenerarFacturaT.TabStop = true;
            rbtnGenerarFacturaT.Text = "Si";
            rbtnGenerarFacturaT.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 237);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 23;
            label5.Text = "Generar Firma:";
            // 
            // rbtnGenerarFirmaF
            // 
            rbtnGenerarFirmaF.AutoSize = true;
            rbtnGenerarFirmaF.Location = new Point(261, 235);
            rbtnGenerarFirmaF.Name = "rbtnGenerarFirmaF";
            rbtnGenerarFirmaF.Size = new Size(50, 24);
            rbtnGenerarFirmaF.TabIndex = 22;
            rbtnGenerarFirmaF.TabStop = true;
            rbtnGenerarFirmaF.Text = "No";
            rbtnGenerarFirmaF.UseVisualStyleBackColor = true;
            // 
            // rbtnGenerarFirmaT
            // 
            rbtnGenerarFirmaT.AutoSize = true;
            rbtnGenerarFirmaT.Location = new Point(208, 235);
            rbtnGenerarFirmaT.Name = "rbtnGenerarFirmaT";
            rbtnGenerarFirmaT.Size = new Size(42, 24);
            rbtnGenerarFirmaT.TabIndex = 21;
            rbtnGenerarFirmaT.TabStop = true;
            rbtnGenerarFirmaT.Text = "Si";
            rbtnGenerarFirmaT.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 207);
            label6.Name = "label6";
            label6.Size = new Size(150, 20);
            label6.TabIndex = 20;
            label6.Text = "Registrar Devolucion:";
            // 
            // rbtnRegistrarDevolucionF
            // 
            rbtnRegistrarDevolucionF.AutoSize = true;
            rbtnRegistrarDevolucionF.Location = new Point(261, 205);
            rbtnRegistrarDevolucionF.Name = "rbtnRegistrarDevolucionF";
            rbtnRegistrarDevolucionF.Size = new Size(50, 24);
            rbtnRegistrarDevolucionF.TabIndex = 19;
            rbtnRegistrarDevolucionF.TabStop = true;
            rbtnRegistrarDevolucionF.Text = "No";
            rbtnRegistrarDevolucionF.UseVisualStyleBackColor = true;
            // 
            // rbtnRegistrarDevolucionT
            // 
            rbtnRegistrarDevolucionT.AutoSize = true;
            rbtnRegistrarDevolucionT.Location = new Point(208, 205);
            rbtnRegistrarDevolucionT.Name = "rbtnRegistrarDevolucionT";
            rbtnRegistrarDevolucionT.Size = new Size(42, 24);
            rbtnRegistrarDevolucionT.TabIndex = 18;
            rbtnRegistrarDevolucionT.TabStop = true;
            rbtnRegistrarDevolucionT.Text = "Si";
            rbtnRegistrarDevolucionT.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 177);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 17;
            label7.Text = "Registrar Entregas:";
            // 
            // rbtnRegistrarEntregasF
            // 
            rbtnRegistrarEntregasF.AutoSize = true;
            rbtnRegistrarEntregasF.Location = new Point(261, 175);
            rbtnRegistrarEntregasF.Name = "rbtnRegistrarEntregasF";
            rbtnRegistrarEntregasF.Size = new Size(50, 24);
            rbtnRegistrarEntregasF.TabIndex = 16;
            rbtnRegistrarEntregasF.TabStop = true;
            rbtnRegistrarEntregasF.Text = "No";
            rbtnRegistrarEntregasF.UseVisualStyleBackColor = true;
            // 
            // rbtnRegistrarEntregasT
            // 
            rbtnRegistrarEntregasT.AutoSize = true;
            rbtnRegistrarEntregasT.Location = new Point(208, 175);
            rbtnRegistrarEntregasT.Name = "rbtnRegistrarEntregasT";
            rbtnRegistrarEntregasT.Size = new Size(42, 24);
            rbtnRegistrarEntregasT.TabIndex = 15;
            rbtnRegistrarEntregasT.TabStop = true;
            rbtnRegistrarEntregasT.Text = "Si";
            rbtnRegistrarEntregasT.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 147);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 14;
            label8.Text = "Confirmar Pedidos:";
            // 
            // rbtnConfirmarPedidoF
            // 
            rbtnConfirmarPedidoF.AutoSize = true;
            rbtnConfirmarPedidoF.Location = new Point(261, 145);
            rbtnConfirmarPedidoF.Name = "rbtnConfirmarPedidoF";
            rbtnConfirmarPedidoF.Size = new Size(50, 24);
            rbtnConfirmarPedidoF.TabIndex = 13;
            rbtnConfirmarPedidoF.TabStop = true;
            rbtnConfirmarPedidoF.Text = "No";
            rbtnConfirmarPedidoF.UseVisualStyleBackColor = true;
            // 
            // rbtnConfirmarPedidoT
            // 
            rbtnConfirmarPedidoT.AutoSize = true;
            rbtnConfirmarPedidoT.Location = new Point(208, 145);
            rbtnConfirmarPedidoT.Name = "rbtnConfirmarPedidoT";
            rbtnConfirmarPedidoT.Size = new Size(42, 24);
            rbtnConfirmarPedidoT.TabIndex = 12;
            rbtnConfirmarPedidoT.TabStop = true;
            rbtnConfirmarPedidoT.Text = "Si";
            rbtnConfirmarPedidoT.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 117);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 11;
            label3.Text = "Modificar Pedidos:";
            // 
            // rbtnModificarPedidoF
            // 
            rbtnModificarPedidoF.AutoSize = true;
            rbtnModificarPedidoF.Location = new Point(261, 115);
            rbtnModificarPedidoF.Name = "rbtnModificarPedidoF";
            rbtnModificarPedidoF.Size = new Size(50, 24);
            rbtnModificarPedidoF.TabIndex = 10;
            rbtnModificarPedidoF.TabStop = true;
            rbtnModificarPedidoF.Text = "No";
            rbtnModificarPedidoF.UseVisualStyleBackColor = true;
            // 
            // rbtnModificarPedidoT
            // 
            rbtnModificarPedidoT.AutoSize = true;
            rbtnModificarPedidoT.Location = new Point(208, 115);
            rbtnModificarPedidoT.Name = "rbtnModificarPedidoT";
            rbtnModificarPedidoT.Size = new Size(42, 24);
            rbtnModificarPedidoT.TabIndex = 9;
            rbtnModificarPedidoT.TabStop = true;
            rbtnModificarPedidoT.Text = "Si";
            rbtnModificarPedidoT.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 87);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 8;
            label4.Text = "Crear Pedido:";
            // 
            // rbtnCrearPedidoF
            // 
            rbtnCrearPedidoF.AutoSize = true;
            rbtnCrearPedidoF.Location = new Point(261, 85);
            rbtnCrearPedidoF.Name = "rbtnCrearPedidoF";
            rbtnCrearPedidoF.Size = new Size(50, 24);
            rbtnCrearPedidoF.TabIndex = 7;
            rbtnCrearPedidoF.TabStop = true;
            rbtnCrearPedidoF.Text = "No";
            rbtnCrearPedidoF.UseVisualStyleBackColor = true;
            // 
            // rbtnCrearPedidoT
            // 
            rbtnCrearPedidoT.AutoSize = true;
            rbtnCrearPedidoT.Location = new Point(208, 85);
            rbtnCrearPedidoT.Name = "rbtnCrearPedidoT";
            rbtnCrearPedidoT.Size = new Size(42, 24);
            rbtnCrearPedidoT.TabIndex = 6;
            rbtnCrearPedidoT.TabStop = true;
            rbtnCrearPedidoT.Text = "Si";
            rbtnCrearPedidoT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 57);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 5;
            label2.Text = "Modificar Usuario:";
            // 
            // rbtnModificarUsuarioF
            // 
            rbtnModificarUsuarioF.AutoSize = true;
            rbtnModificarUsuarioF.Location = new Point(261, 55);
            rbtnModificarUsuarioF.Name = "rbtnModificarUsuarioF";
            rbtnModificarUsuarioF.Size = new Size(50, 24);
            rbtnModificarUsuarioF.TabIndex = 4;
            rbtnModificarUsuarioF.TabStop = true;
            rbtnModificarUsuarioF.Text = "No";
            rbtnModificarUsuarioF.UseVisualStyleBackColor = true;
            // 
            // rbtnModificarUsuarioT
            // 
            rbtnModificarUsuarioT.AutoSize = true;
            rbtnModificarUsuarioT.Location = new Point(208, 55);
            rbtnModificarUsuarioT.Name = "rbtnModificarUsuarioT";
            rbtnModificarUsuarioT.Size = new Size(42, 24);
            rbtnModificarUsuarioT.TabIndex = 3;
            rbtnModificarUsuarioT.TabStop = true;
            rbtnModificarUsuarioT.Text = "Si";
            rbtnModificarUsuarioT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 27);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 2;
            label1.Text = "Crear Usuario:";
            // 
            // rbtnCrearUsuarioF
            // 
            rbtnCrearUsuarioF.AutoSize = true;
            rbtnCrearUsuarioF.Location = new Point(261, 25);
            rbtnCrearUsuarioF.Name = "rbtnCrearUsuarioF";
            rbtnCrearUsuarioF.Size = new Size(50, 24);
            rbtnCrearUsuarioF.TabIndex = 1;
            rbtnCrearUsuarioF.TabStop = true;
            rbtnCrearUsuarioF.Text = "No";
            rbtnCrearUsuarioF.UseVisualStyleBackColor = true;
            // 
            // rbtnCrearUsuarioT
            // 
            rbtnCrearUsuarioT.AutoSize = true;
            rbtnCrearUsuarioT.Location = new Point(208, 25);
            rbtnCrearUsuarioT.Name = "rbtnCrearUsuarioT";
            rbtnCrearUsuarioT.Size = new Size(42, 24);
            rbtnCrearUsuarioT.TabIndex = 0;
            rbtnCrearUsuarioT.TabStop = true;
            rbtnCrearUsuarioT.Text = "Si";
            rbtnCrearUsuarioT.UseVisualStyleBackColor = true;
            // 
            // lblUsuarioLog
            // 
            lblUsuarioLog.AutoSize = true;
            lblUsuarioLog.Location = new Point(694, 7);
            lblUsuarioLog.Name = "lblUsuarioLog";
            lblUsuarioLog.Size = new Size(0, 20);
            lblUsuarioLog.TabIndex = 85;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Depth = 0;
            lblCliente.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCliente.Location = new Point(21, 110);
            lblCliente.MouseState = MaterialSkin.MouseState.HOVER;
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(79, 24);
            lblCliente.TabIndex = 86;
            lblCliente.Text = "Usuario:";
            // 
            // rbtnDatosPersonales
            // 
            rbtnDatosPersonales.AutoSize = true;
            rbtnDatosPersonales.Checked = true;
            rbtnDatosPersonales.Depth = 0;
            rbtnDatosPersonales.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnDatosPersonales.Location = new Point(367, 110);
            rbtnDatosPersonales.Margin = new Padding(0);
            rbtnDatosPersonales.MouseLocation = new Point(-1, -1);
            rbtnDatosPersonales.MouseState = MaterialSkin.MouseState.HOVER;
            rbtnDatosPersonales.Name = "rbtnDatosPersonales";
            rbtnDatosPersonales.Ripple = true;
            rbtnDatosPersonales.Size = new Size(165, 30);
            rbtnDatosPersonales.TabIndex = 87;
            rbtnDatosPersonales.TabStop = true;
            rbtnDatosPersonales.Text = "Datos Personales";
            rbtnDatosPersonales.UseVisualStyleBackColor = true;
            rbtnDatosPersonales.CheckedChanged += rbtnDatosPersonales_CheckedChanged_1;
            // 
            // rbtnDatosFiscales
            // 
            rbtnDatosFiscales.AutoSize = true;
            rbtnDatosFiscales.Depth = 0;
            rbtnDatosFiscales.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnDatosFiscales.Location = new Point(570, 110);
            rbtnDatosFiscales.Margin = new Padding(0);
            rbtnDatosFiscales.MouseLocation = new Point(-1, -1);
            rbtnDatosFiscales.MouseState = MaterialSkin.MouseState.HOVER;
            rbtnDatosFiscales.Name = "rbtnDatosFiscales";
            rbtnDatosFiscales.Ripple = true;
            rbtnDatosFiscales.Size = new Size(143, 30);
            rbtnDatosFiscales.TabIndex = 88;
            rbtnDatosFiscales.Text = "Datos Fiscales";
            rbtnDatosFiscales.UseVisualStyleBackColor = true;
            rbtnDatosFiscales.CheckedChanged += rbtnDatosFiscales_CheckedChanged;
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
            // errorCif
            // 
            errorCif.ContainerControl = this;
            // 
            // ModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 560);
            Controls.Add(rbtnDatosFiscales);
            Controls.Add(rbtnDatosPersonales);
            Controls.Add(lblCliente);
            Controls.Add(lblUsuarioLog);
            Controls.Add(panelPermisos);
            Controls.Add(cmbNombreUsuario);
            Controls.Add(rbtnPermisos);
            Controls.Add(panelDatos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModificarUsuario";
            Text = "MODIFICAR USUARIOS";
            Load += ModificarUsuario_Load;
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicOJO).EndInit();
            panelPermisos.ResumeLayout(false);
            panelPermisos.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)errorCif).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbRol;
        private RadioButton rbtnPermisos;
        private ComboBox cmbNombreUsuario;
        private Panel panelDatos;
        private Panel panelPermisos;
        private RadioButton rbtnCrearUsuarioF;
        private RadioButton rbtnCrearUsuarioT;
        private Label label1;
        private Label label9;
        private RadioButton rbtnGenerarReporteF;
        private RadioButton rbtnGenerarReporteT;
        private Label label10;
        private RadioButton rbtnGenerarFacturaF;
        private RadioButton rbtnGenerarFacturaT;
        private Label label5;
        private RadioButton rbtnGenerarFirmaF;
        private RadioButton rbtnGenerarFirmaT;
        private Label label6;
        private RadioButton rbtnRegistrarDevolucionF;
        private RadioButton rbtnRegistrarDevolucionT;
        private Label label7;
        private RadioButton rbtnRegistrarEntregasF;
        private RadioButton rbtnRegistrarEntregasT;
        private Label label8;
        private RadioButton rbtnConfirmarPedidoF;
        private RadioButton rbtnConfirmarPedidoT;
        private Label label3;
        private RadioButton rbtnModificarPedidoF;
        private RadioButton rbtnModificarPedidoT;
        private Label label4;
        private RadioButton rbtnCrearPedidoF;
        private RadioButton rbtnCrearPedidoT;
        private Label label2;
        private RadioButton rbtnModificarUsuarioF;
        private RadioButton rbtnModificarUsuarioT;
        public Label lblUsuarioLog;
        private MaterialSkin.Controls.MaterialLabel lblRol;
        private MaterialSkin.Controls.MaterialLabel lblCif;
        private MaterialSkin.Controls.MaterialLabel lblCiudad;
        private MaterialSkin.Controls.MaterialLabel lblNoInt;
        private MaterialSkin.Controls.MaterialLabel lblCorreo;
        private MaterialSkin.Controls.MaterialLabel lblCp;
        private MaterialSkin.Controls.MaterialLabel lblNoExt;
        private MaterialSkin.Controls.MaterialLabel lblTel;
        private MaterialSkin.Controls.MaterialLabel lblColonia;
        private MaterialSkin.Controls.MaterialLabel lblCalle;
        private MaterialSkin.Controls.MaterialLabel lblContrasenia;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCif;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCiudad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNoInt;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNoExt;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCalle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasenia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialRadioButton rbtnDatosPersonales;
        private MaterialSkin.Controls.MaterialRadioButton rbtnDatosFiscales;
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
        private ErrorProvider errorCif;
        private PictureBox PicOJO;
    }
}
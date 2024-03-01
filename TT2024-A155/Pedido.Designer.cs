namespace TT2024_A155
{
    partial class Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            lblUsuario = new Label();
            txtComentarios = new TextBox();
            dgvPedido = new DataGridView();
            cmbCliente = new ComboBox();
            dgvDatosPDF = new DataGridView();
            lblRol = new Label();
            lblIdPedido = new Label();
            lblCliente = new MaterialSkin.Controls.MaterialLabel();
            lblNombreCliente = new MaterialSkin.Controls.MaterialLabel();
            lblFechaCreacion = new MaterialSkin.Controls.MaterialLabel();
            lblComentarios = new MaterialSkin.Controls.MaterialLabel();
            lblTituloFact = new MaterialSkin.Controls.MaterialLabel();
            lblClienteFact = new MaterialSkin.Controls.MaterialLabel();
            lblCif = new MaterialSkin.Controls.MaterialLabel();
            lblCalle = new MaterialSkin.Controls.MaterialLabel();
            lblCp = new MaterialSkin.Controls.MaterialLabel();
            lblTel = new MaterialSkin.Controls.MaterialLabel();
            lblColonia = new MaterialSkin.Controls.MaterialLabel();
            lblNoExt = new MaterialSkin.Controls.MaterialLabel();
            lblCiudad = new MaterialSkin.Controls.MaterialLabel();
            lblCorreo = new MaterialSkin.Controls.MaterialLabel();
            lblNoInt = new MaterialSkin.Controls.MaterialLabel();
            lblSubtotal = new MaterialSkin.Controls.MaterialLabel();
            lblTotal = new MaterialSkin.Controls.MaterialLabel();
            txtNombreCliFact = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCif = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCalle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtTel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCiudad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtNoExt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtCol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtNoInt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            btnAgregarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            errorNombre = new ErrorProvider(components);
            errorCif = new ErrorProvider(components);
            errorContrasenia = new ErrorProvider(components);
            errorCalle = new ErrorProvider(components);
            errorColonia = new ErrorProvider(components);
            errorCP = new ErrorProvider(components);
            errorTelefono = new ErrorProvider(components);
            errorNoExt = new ErrorProvider(components);
            errorNoInt = new ErrorProvider(components);
            errorCiudad = new ErrorProvider(components);
            errorCorreo = new ErrorProvider(components);
            errorProductosDGV = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosPDF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorCif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorContrasenia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorCalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorColonia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorCP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorTelefono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoInt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorCiudad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorCorreo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProductosDGV).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(302, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(159, 215);
            txtComentarios.Multiline = true;
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(291, 106);
            txtComentarios.TabIndex = 4;
            // 
            // dgvPedido
            // 
            dgvPedido.AllowUserToAddRows = false;
            dgvPedido.AllowUserToDeleteRows = false;
            dgvPedido.AllowUserToResizeRows = false;
            dgvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPedido.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedido.Location = new Point(12, 390);
            dgvPedido.Name = "dgvPedido";
            dgvPedido.RowHeadersWidth = 51;
            dgvPedido.RowTemplate.Height = 29;
            dgvPedido.Size = new Size(1106, 188);
            dgvPedido.TabIndex = 27;
            dgvPedido.CellClick += dgvPedido_CellClick;
            // 
            // cmbCliente
            // 
            cmbCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(101, 90);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(349, 28);
            cmbCliente.TabIndex = 30;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // dgvDatosPDF
            // 
            dgvDatosPDF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosPDF.Location = new Point(384, 49);
            dgvDatosPDF.Name = "dgvDatosPDF";
            dgvDatosPDF.RowHeadersWidth = 51;
            dgvDatosPDF.RowTemplate.Height = 29;
            dgvDatosPDF.Size = new Size(44, 10);
            dgvDatosPDF.TabIndex = 38;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(302, 29);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(36, 20);
            lblRol.TabIndex = 39;
            lblRol.Text = "ROL";
            // 
            // lblIdPedido
            // 
            lblIdPedido.AutoSize = true;
            lblIdPedido.Location = new Point(302, 49);
            lblIdPedido.Name = "lblIdPedido";
            lblIdPedido.Size = new Size(70, 20);
            lblIdPedido.TabIndex = 40;
            lblIdPedido.Text = "IDPedido";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Depth = 0;
            lblCliente.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCliente.Location = new Point(12, 90);
            lblCliente.MouseState = MaterialSkin.MouseState.HOVER;
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(73, 24);
            lblCliente.TabIndex = 42;
            lblCliente.Text = "Cliente:";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Depth = 0;
            lblNombreCliente.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNombreCliente.Location = new Point(12, 130);
            lblNombreCliente.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(84, 24);
            lblNombreCliente.TabIndex = 43;
            lblNombreCliente.Text = "Nombre:";
            // 
            // lblFechaCreacion
            // 
            lblFechaCreacion.AutoSize = true;
            lblFechaCreacion.Depth = 0;
            lblFechaCreacion.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaCreacion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblFechaCreacion.Location = new Point(12, 170);
            lblFechaCreacion.MouseState = MaterialSkin.MouseState.HOVER;
            lblFechaCreacion.Name = "lblFechaCreacion";
            lblFechaCreacion.Size = new Size(150, 24);
            lblFechaCreacion.TabIndex = 44;
            lblFechaCreacion.Text = "Fecha Creación: ";
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.Depth = 0;
            lblComentarios.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblComentarios.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblComentarios.Location = new Point(12, 210);
            lblComentarios.MouseState = MaterialSkin.MouseState.HOVER;
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(123, 24);
            lblComentarios.TabIndex = 45;
            lblComentarios.Text = "Comentarios:";
            // 
            // lblTituloFact
            // 
            lblTituloFact.AutoSize = true;
            lblTituloFact.Depth = 0;
            lblTituloFact.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloFact.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTituloFact.Location = new Point(547, 90);
            lblTituloFact.MouseState = MaterialSkin.MouseState.HOVER;
            lblTituloFact.Name = "lblTituloFact";
            lblTituloFact.Size = new Size(205, 24);
            lblTituloFact.TabIndex = 46;
            lblTituloFact.Text = "DATOS FACTURACION:";
            // 
            // lblClienteFact
            // 
            lblClienteFact.AutoSize = true;
            lblClienteFact.Depth = 0;
            lblClienteFact.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteFact.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblClienteFact.Location = new Point(547, 130);
            lblClienteFact.MouseState = MaterialSkin.MouseState.HOVER;
            lblClienteFact.Name = "lblClienteFact";
            lblClienteFact.Size = new Size(84, 24);
            lblClienteFact.TabIndex = 47;
            lblClienteFact.Text = "Nombre:";
            // 
            // lblCif
            // 
            lblCif.AutoSize = true;
            lblCif.Depth = 0;
            lblCif.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCif.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCif.Location = new Point(547, 170);
            lblCif.MouseState = MaterialSkin.MouseState.HOVER;
            lblCif.Name = "lblCif";
            lblCif.Size = new Size(43, 24);
            lblCif.TabIndex = 48;
            lblCif.Text = "CIF:";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Depth = 0;
            lblCalle.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCalle.Location = new Point(547, 210);
            lblCalle.MouseState = MaterialSkin.MouseState.HOVER;
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(57, 24);
            lblCalle.TabIndex = 49;
            lblCalle.Text = "Calle:";
            // 
            // lblCp
            // 
            lblCp.AutoSize = true;
            lblCp.Depth = 0;
            lblCp.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCp.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCp.Location = new Point(547, 250);
            lblCp.MouseState = MaterialSkin.MouseState.HOVER;
            lblCp.Name = "lblCp";
            lblCp.Size = new Size(49, 24);
            lblCp.TabIndex = 50;
            lblCp.Text = "C.P.:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Depth = 0;
            lblTel.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTel.Location = new Point(547, 290);
            lblTel.MouseState = MaterialSkin.MouseState.HOVER;
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(90, 24);
            lblTel.TabIndex = 51;
            lblTel.Text = "Telefono:";
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.Depth = 0;
            lblColonia.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblColonia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblColonia.Location = new Point(894, 130);
            lblColonia.MouseState = MaterialSkin.MouseState.HOVER;
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(79, 24);
            lblColonia.TabIndex = 52;
            lblColonia.Text = "Colonia:";
            // 
            // lblNoExt
            // 
            lblNoExt.AutoSize = true;
            lblNoExt.Depth = 0;
            lblNoExt.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoExt.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNoExt.Location = new Point(894, 170);
            lblNoExt.MouseState = MaterialSkin.MouseState.HOVER;
            lblNoExt.Name = "lblNoExt";
            lblNoExt.Size = new Size(81, 24);
            lblNoExt.TabIndex = 53;
            lblNoExt.Text = "No. Ext.:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Depth = 0;
            lblCiudad.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCiudad.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCiudad.Location = new Point(894, 210);
            lblCiudad.MouseState = MaterialSkin.MouseState.HOVER;
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(74, 24);
            lblCiudad.TabIndex = 54;
            lblCiudad.Text = "Ciudad:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Depth = 0;
            lblCorreo.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCorreo.Location = new Point(894, 250);
            lblCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(71, 24);
            lblCorreo.TabIndex = 55;
            lblCorreo.Text = "Correo:";
            // 
            // lblNoInt
            // 
            lblNoInt.AutoSize = true;
            lblNoInt.Depth = 0;
            lblNoInt.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoInt.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNoInt.Location = new Point(1119, 170);
            lblNoInt.MouseState = MaterialSkin.MouseState.HOVER;
            lblNoInt.Name = "lblNoInt";
            lblNoInt.Size = new Size(76, 24);
            lblNoInt.TabIndex = 56;
            lblNoInt.Text = "No. Int.:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Depth = 0;
            lblSubtotal.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtotal.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblSubtotal.Location = new Point(853, 590);
            lblSubtotal.MouseState = MaterialSkin.MouseState.HOVER;
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(90, 24);
            lblSubtotal.TabIndex = 57;
            lblSubtotal.Text = "Subtotal: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Depth = 0;
            lblTotal.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTotal.Location = new Point(853, 630);
            lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(157, 24);
            lblTotal.TabIndex = 58;
            lblTotal.Text = "Total + IVA(16%):";
            // 
            // txtNombreCliFact
            // 
            txtNombreCliFact.Depth = 0;
            txtNombreCliFact.Hint = "";
            txtNombreCliFact.Location = new Point(652, 130);
            txtNombreCliFact.MaxLength = 32767;
            txtNombreCliFact.MouseState = MaterialSkin.MouseState.HOVER;
            txtNombreCliFact.Name = "txtNombreCliFact";
            txtNombreCliFact.PasswordChar = '\0';
            txtNombreCliFact.SelectedText = "";
            txtNombreCliFact.SelectionLength = 0;
            txtNombreCliFact.SelectionStart = 0;
            txtNombreCliFact.Size = new Size(221, 28);
            txtNombreCliFact.TabIndex = 59;
            txtNombreCliFact.TabStop = false;
            txtNombreCliFact.UseSystemPasswordChar = false;
            txtNombreCliFact.KeyPress += txtNombreCliFact_KeyPress;
            // 
            // txtCif
            // 
            txtCif.Depth = 0;
            txtCif.Hint = "";
            txtCif.Location = new Point(652, 170);
            txtCif.MaxLength = 32767;
            txtCif.MouseState = MaterialSkin.MouseState.HOVER;
            txtCif.Name = "txtCif";
            txtCif.PasswordChar = '\0';
            txtCif.SelectedText = "";
            txtCif.SelectionLength = 0;
            txtCif.SelectionStart = 0;
            txtCif.Size = new Size(221, 28);
            txtCif.TabIndex = 60;
            txtCif.TabStop = false;
            txtCif.UseSystemPasswordChar = false;
            // 
            // txtCalle
            // 
            txtCalle.Depth = 0;
            txtCalle.Hint = "";
            txtCalle.Location = new Point(652, 210);
            txtCalle.MaxLength = 32767;
            txtCalle.MouseState = MaterialSkin.MouseState.HOVER;
            txtCalle.Name = "txtCalle";
            txtCalle.PasswordChar = '\0';
            txtCalle.SelectedText = "";
            txtCalle.SelectionLength = 0;
            txtCalle.SelectionStart = 0;
            txtCalle.Size = new Size(221, 28);
            txtCalle.TabIndex = 61;
            txtCalle.TabStop = false;
            txtCalle.UseSystemPasswordChar = false;
            // 
            // txtTel
            // 
            txtTel.Depth = 0;
            txtTel.Hint = "";
            txtTel.Location = new Point(652, 290);
            txtTel.MaxLength = 32767;
            txtTel.MouseState = MaterialSkin.MouseState.HOVER;
            txtTel.Name = "txtTel";
            txtTel.PasswordChar = '\0';
            txtTel.SelectedText = "";
            txtTel.SelectionLength = 0;
            txtTel.SelectionStart = 0;
            txtTel.Size = new Size(221, 28);
            txtTel.TabIndex = 63;
            txtTel.TabStop = false;
            txtTel.UseSystemPasswordChar = false;
            txtTel.KeyPress += txtTel_KeyPress;
            // 
            // txtCP
            // 
            txtCP.Depth = 0;
            txtCP.Hint = "";
            txtCP.Location = new Point(652, 250);
            txtCP.MaxLength = 32767;
            txtCP.MouseState = MaterialSkin.MouseState.HOVER;
            txtCP.Name = "txtCP";
            txtCP.PasswordChar = '\0';
            txtCP.SelectedText = "";
            txtCP.SelectionLength = 0;
            txtCP.SelectionStart = 0;
            txtCP.Size = new Size(100, 28);
            txtCP.TabIndex = 62;
            txtCP.TabStop = false;
            txtCP.UseSystemPasswordChar = false;
            txtCP.KeyPress += txtCP_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.Depth = 0;
            txtCorreo.Hint = "";
            txtCorreo.Location = new Point(996, 250);
            txtCorreo.MaxLength = 32767;
            txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PasswordChar = '\0';
            txtCorreo.SelectedText = "";
            txtCorreo.SelectionLength = 0;
            txtCorreo.SelectionStart = 0;
            txtCorreo.Size = new Size(199, 28);
            txtCorreo.TabIndex = 67;
            txtCorreo.TabStop = false;
            txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtCiudad
            // 
            txtCiudad.Depth = 0;
            txtCiudad.Hint = "";
            txtCiudad.Location = new Point(996, 210);
            txtCiudad.MaxLength = 32767;
            txtCiudad.MouseState = MaterialSkin.MouseState.HOVER;
            txtCiudad.Name = "txtCiudad";
            txtCiudad.PasswordChar = '\0';
            txtCiudad.SelectedText = "";
            txtCiudad.SelectionLength = 0;
            txtCiudad.SelectionStart = 0;
            txtCiudad.Size = new Size(199, 28);
            txtCiudad.TabIndex = 66;
            txtCiudad.TabStop = false;
            txtCiudad.UseSystemPasswordChar = false;
            // 
            // txtNoExt
            // 
            txtNoExt.Depth = 0;
            txtNoExt.Hint = "";
            txtNoExt.Location = new Point(996, 170);
            txtNoExt.MaxLength = 32767;
            txtNoExt.MouseState = MaterialSkin.MouseState.HOVER;
            txtNoExt.Name = "txtNoExt";
            txtNoExt.PasswordChar = '\0';
            txtNoExt.SelectedText = "";
            txtNoExt.SelectionLength = 0;
            txtNoExt.SelectionStart = 0;
            txtNoExt.Size = new Size(100, 28);
            txtNoExt.TabIndex = 65;
            txtNoExt.TabStop = false;
            txtNoExt.UseSystemPasswordChar = false;
            txtNoExt.KeyPress += txtNoExt_KeyPress;
            // 
            // txtCol
            // 
            txtCol.Depth = 0;
            txtCol.Hint = "";
            txtCol.Location = new Point(996, 130);
            txtCol.MaxLength = 32767;
            txtCol.MouseState = MaterialSkin.MouseState.HOVER;
            txtCol.Name = "txtCol";
            txtCol.PasswordChar = '\0';
            txtCol.SelectedText = "";
            txtCol.SelectionLength = 0;
            txtCol.SelectionStart = 0;
            txtCol.Size = new Size(199, 28);
            txtCol.TabIndex = 64;
            txtCol.TabStop = false;
            txtCol.UseSystemPasswordChar = false;
            // 
            // txtNoInt
            // 
            txtNoInt.Depth = 0;
            txtNoInt.Hint = "";
            txtNoInt.Location = new Point(1214, 170);
            txtNoInt.MaxLength = 32767;
            txtNoInt.MouseState = MaterialSkin.MouseState.HOVER;
            txtNoInt.Name = "txtNoInt";
            txtNoInt.PasswordChar = '\0';
            txtNoInt.SelectedText = "";
            txtNoInt.SelectionLength = 0;
            txtNoInt.SelectionStart = 0;
            txtNoInt.Size = new Size(100, 28);
            txtNoInt.TabIndex = 68;
            txtNoInt.TabStop = false;
            txtNoInt.UseSystemPasswordChar = false;
            txtNoInt.KeyPress += txtNoInt_KeyPress;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.AutoSize = true;
            btnAgregarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarProducto.Depth = 0;
            btnAgregarProducto.Icon = null;
            btnAgregarProducto.Location = new Point(12, 345);
            btnAgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Primary = true;
            btnAgregarProducto.Size = new Size(193, 36);
            btnAgregarProducto.TabIndex = 69;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.AutoSize = true;
            btnAceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAceptar.Depth = 0;
            btnAceptar.Icon = null;
            btnAceptar.Location = new Point(1234, 642);
            btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Primary = true;
            btnAceptar.Size = new Size(98, 36);
            btnAceptar.TabIndex = 70;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // errorNombre
            // 
            errorNombre.ContainerControl = this;
            // 
            // errorCif
            // 
            errorCif.ContainerControl = this;
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
            // errorProductosDGV
            // 
            errorProductosDGV.ContainerControl = this;
            // 
            // Pedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 690);
            Controls.Add(btnAceptar);
            Controls.Add(btnAgregarProducto);
            Controls.Add(txtNoInt);
            Controls.Add(txtCorreo);
            Controls.Add(txtCiudad);
            Controls.Add(txtNoExt);
            Controls.Add(txtCol);
            Controls.Add(txtTel);
            Controls.Add(txtCP);
            Controls.Add(txtCalle);
            Controls.Add(txtCif);
            Controls.Add(txtNombreCliFact);
            Controls.Add(lblTotal);
            Controls.Add(lblSubtotal);
            Controls.Add(lblNoInt);
            Controls.Add(lblCorreo);
            Controls.Add(lblCiudad);
            Controls.Add(lblNoExt);
            Controls.Add(lblColonia);
            Controls.Add(lblTel);
            Controls.Add(lblCp);
            Controls.Add(lblCalle);
            Controls.Add(lblCif);
            Controls.Add(lblClienteFact);
            Controls.Add(lblTituloFact);
            Controls.Add(lblComentarios);
            Controls.Add(lblFechaCreacion);
            Controls.Add(lblNombreCliente);
            Controls.Add(lblCliente);
            Controls.Add(lblIdPedido);
            Controls.Add(lblRol);
            Controls.Add(dgvDatosPDF);
            Controls.Add(cmbCliente);
            Controls.Add(dgvPedido);
            Controls.Add(txtComentarios);
            Controls.Add(lblUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pedido";
            Text = "Solicitar Cotización (Pedido)";
            Load += Pedido_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosPDF).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorCif).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorContrasenia).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorCalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorColonia).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorCP).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorTelefono).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoInt).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorCiudad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorCorreo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProductosDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblUsuario;
        private TextBox txtComentarios;
        private DataGridView dgvPedido;
        private ComboBox cmbCliente;
        private DataGridView dgvDatosPDF;
        public Label lblRol;
        public Label lblIdPedido;
        private MaterialSkin.Controls.MaterialLabel lblCliente;
        private MaterialSkin.Controls.MaterialLabel lblNombreCliente;
        private MaterialSkin.Controls.MaterialLabel lblFechaCreacion;
        private MaterialSkin.Controls.MaterialLabel lblComentarios;
        private MaterialSkin.Controls.MaterialLabel lblTituloFact;
        private MaterialSkin.Controls.MaterialLabel lblClienteFact;
        private MaterialSkin.Controls.MaterialLabel lblCif;
        private MaterialSkin.Controls.MaterialLabel lblCalle;
        private MaterialSkin.Controls.MaterialLabel lblCp;
        private MaterialSkin.Controls.MaterialLabel lblTel;
        private MaterialSkin.Controls.MaterialLabel lblColonia;
        private MaterialSkin.Controls.MaterialLabel lblNoExt;
        private MaterialSkin.Controls.MaterialLabel lblCiudad;
        private MaterialSkin.Controls.MaterialLabel lblCorreo;
        private MaterialSkin.Controls.MaterialLabel lblNoInt;
        private MaterialSkin.Controls.MaterialLabel lblSubtotal;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreCliFact;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCif;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCalle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCiudad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNoExt;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNoInt;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
        private ErrorProvider errorNombre;
        private ErrorProvider errorCif;
        private ErrorProvider errorContrasenia;
        private ErrorProvider errorCalle;
        private ErrorProvider errorColonia;
        private ErrorProvider errorCP;
        private ErrorProvider errorTelefono;
        private ErrorProvider errorNoExt;
        private ErrorProvider errorNoInt;
        private ErrorProvider errorCiudad;
        private ErrorProvider errorCorreo;
        private ErrorProvider errorProductosDGV;
    }
}
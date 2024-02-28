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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            lblUsuario = new Label();
            lblCliente = new Label();
            lblComentarios = new Label();
            txtComentarios = new TextBox();
            lblClienteFact = new Label();
            lblTituloFact = new Label();
            lblCif = new Label();
            lblCalle = new Label();
            lblColonia = new Label();
            lblNoExt = new Label();
            lblNoInt = new Label();
            lblCp = new Label();
            lblCiudad = new Label();
            lblTel = new Label();
            lblCorreo = new Label();
            txtNombreCliFact = new TextBox();
            txtCif = new TextBox();
            txtCalle = new TextBox();
            txtCP = new TextBox();
            txtTel = new TextBox();
            txtCol = new TextBox();
            txtNoExt = new TextBox();
            txtCorreo = new TextBox();
            txtCiudad = new TextBox();
            txtNoInt = new TextBox();
            dgvPedido = new DataGridView();
            btnAceptar = new Button();
            btnAgregarProducto = new Button();
            cmbCliente = new ComboBox();
            lblNombreCliente = new Label();
            lblSubtotal = new Label();
            lblTotal = new Label();
            dgvDatosPDF = new DataGridView();
            lblRol = new Label();
            lblIdPedido = new Label();
            lblFechaCreacion = new Label();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosPDF).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(1037, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(12, 123);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente:";
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.Location = new Point(268, 271);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(96, 20);
            lblComentarios.TabIndex = 3;
            lblComentarios.Text = "Comentarios:";
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(178, 294);
            txtComentarios.Multiline = true;
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(272, 90);
            txtComentarios.TabIndex = 4;
            // 
            // lblClienteFact
            // 
            lblClienteFact.AutoSize = true;
            lblClienteFact.Location = new Point(471, 166);
            lblClienteFact.Name = "lblClienteFact";
            lblClienteFact.Size = new Size(67, 20);
            lblClienteFact.TabIndex = 6;
            lblClienteFact.Text = "Nombre:";
            // 
            // lblTituloFact
            // 
            lblTituloFact.AutoSize = true;
            lblTituloFact.Location = new Point(471, 123);
            lblTituloFact.Name = "lblTituloFact";
            lblTituloFact.Size = new Size(159, 20);
            lblTituloFact.TabIndex = 7;
            lblTituloFact.Text = "DATOS FACTURACION:";
            // 
            // lblCif
            // 
            lblCif.AutoSize = true;
            lblCif.Location = new Point(471, 203);
            lblCif.Name = "lblCif";
            lblCif.Size = new Size(32, 20);
            lblCif.TabIndex = 8;
            lblCif.Text = "CIF:";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(471, 241);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(45, 20);
            lblCalle.TabIndex = 9;
            lblCalle.Text = "Calle:";
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.Location = new Point(738, 203);
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(63, 20);
            lblColonia.TabIndex = 10;
            lblColonia.Text = "Colonia:";
            // 
            // lblNoExt
            // 
            lblNoExt.AutoSize = true;
            lblNoExt.Location = new Point(738, 241);
            lblNoExt.Name = "lblNoExt";
            lblNoExt.Size = new Size(62, 20);
            lblNoExt.TabIndex = 11;
            lblNoExt.Text = "No. Ext.:";
            // 
            // lblNoInt
            // 
            lblNoInt.AutoSize = true;
            lblNoInt.Location = new Point(981, 241);
            lblNoInt.Name = "lblNoInt";
            lblNoInt.Size = new Size(59, 20);
            lblNoInt.TabIndex = 12;
            lblNoInt.Text = "No. Int.:";
            // 
            // lblCp
            // 
            lblCp.AutoSize = true;
            lblCp.Location = new Point(471, 284);
            lblCp.Name = "lblCp";
            lblCp.Size = new Size(35, 20);
            lblCp.TabIndex = 13;
            lblCp.Text = "C.P.:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(738, 284);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(59, 20);
            lblCiudad.TabIndex = 14;
            lblCiudad.Text = "Ciudad:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(471, 328);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(70, 20);
            lblTel.TabIndex = 15;
            lblTel.Text = "Telefono:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(738, 328);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 16;
            lblCorreo.Text = "Correo:";
            // 
            // txtNombreCliFact
            // 
            txtNombreCliFact.Location = new Point(547, 159);
            txtNombreCliFact.Name = "txtNombreCliFact";
            txtNombreCliFact.Size = new Size(310, 27);
            txtNombreCliFact.TabIndex = 17;
            // 
            // txtCif
            // 
            txtCif.Location = new Point(547, 196);
            txtCif.Name = "txtCif";
            txtCif.Size = new Size(159, 27);
            txtCif.TabIndex = 18;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(547, 234);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(159, 27);
            txtCalle.TabIndex = 19;
            // 
            // txtCP
            // 
            txtCP.Location = new Point(547, 277);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(159, 27);
            txtCP.TabIndex = 20;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(547, 321);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(159, 27);
            txtTel.TabIndex = 21;
            // 
            // txtCol
            // 
            txtCol.Location = new Point(807, 196);
            txtCol.Name = "txtCol";
            txtCol.Size = new Size(159, 27);
            txtCol.TabIndex = 22;
            // 
            // txtNoExt
            // 
            txtNoExt.Location = new Point(807, 238);
            txtNoExt.Name = "txtNoExt";
            txtNoExt.Size = new Size(159, 27);
            txtNoExt.TabIndex = 23;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(807, 323);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(159, 27);
            txtCorreo.TabIndex = 25;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(807, 281);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(159, 27);
            txtCiudad.TabIndex = 24;
            // 
            // txtNoInt
            // 
            txtNoInt.Location = new Point(1046, 234);
            txtNoInt.Name = "txtNoInt";
            txtNoInt.Size = new Size(53, 27);
            txtNoInt.TabIndex = 26;
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
            dgvPedido.Size = new Size(954, 188);
            dgvPedido.TabIndex = 27;
            dgvPedido.CellClick += dgvPedido_CellClick;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(1069, 609);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 28;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(12, 355);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(140, 29);
            btnAgregarProducto.TabIndex = 29;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // cmbCliente
            // 
            cmbCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(86, 115);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(299, 28);
            cmbCliente.TabIndex = 30;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(12, 159);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(67, 20);
            lblNombreCliente.TabIndex = 35;
            lblNombreCliente.Text = "Nombre:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(807, 581);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(72, 20);
            lblSubtotal.TabIndex = 36;
            lblSubtotal.Text = "Subtotal: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(807, 609);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(123, 20);
            lblTotal.TabIndex = 37;
            lblTotal.Text = "Total + IVA(16%):";
            // 
            // dgvDatosPDF
            // 
            dgvDatosPDF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosPDF.Location = new Point(1119, 49);
            dgvDatosPDF.Name = "dgvDatosPDF";
            dgvDatosPDF.RowHeadersWidth = 51;
            dgvDatosPDF.RowTemplate.Height = 29;
            dgvDatosPDF.Size = new Size(44, 10);
            dgvDatosPDF.TabIndex = 38;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(1037, 29);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(36, 20);
            lblRol.TabIndex = 39;
            lblRol.Text = "ROL";
            // 
            // lblIdPedido
            // 
            lblIdPedido.AutoSize = true;
            lblIdPedido.Location = new Point(1037, 49);
            lblIdPedido.Name = "lblIdPedido";
            lblIdPedido.Size = new Size(70, 20);
            lblIdPedido.TabIndex = 40;
            lblIdPedido.Text = "IDPedido";
            // 
            // lblFechaCreacion
            // 
            lblFechaCreacion.AutoSize = true;
            lblFechaCreacion.Location = new Point(12, 203);
            lblFechaCreacion.Name = "lblFechaCreacion";
            lblFechaCreacion.Size = new Size(116, 20);
            lblFechaCreacion.TabIndex = 41;
            lblFechaCreacion.Text = "Fecha Creación: ";
            lblFechaCreacion.Visible = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(12, 88);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(73, 24);
            materialLabel1.TabIndex = 42;
            materialLabel1.Text = "Cliente:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(96, 155);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(84, 24);
            materialLabel2.TabIndex = 43;
            materialLabel2.Text = "Nombre:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel3.Location = new Point(150, 199);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(150, 24);
            materialLabel3.TabIndex = 44;
            materialLabel3.Text = "Fecha Creación: ";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel4.Location = new Point(126, 267);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(123, 24);
            materialLabel4.TabIndex = 45;
            materialLabel4.Text = "Comentarios:";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel5.Location = new Point(471, 99);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(205, 24);
            materialLabel5.TabIndex = 46;
            materialLabel5.Text = "DATOS FACTURACION:";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel6.Location = new Point(557, 157);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(84, 24);
            materialLabel6.TabIndex = 47;
            materialLabel6.Text = "Nombre:";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel7.Location = new Point(547, 197);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(43, 24);
            materialLabel7.TabIndex = 48;
            materialLabel7.Text = "CIF:";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel8.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel8.Location = new Point(547, 237);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(57, 24);
            materialLabel8.TabIndex = 49;
            materialLabel8.Text = "Calle:";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel9.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel9.Location = new Point(547, 278);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(49, 24);
            materialLabel9.TabIndex = 50;
            materialLabel9.Text = "C.P.:";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel10.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel10.Location = new Point(557, 323);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(90, 24);
            materialLabel10.TabIndex = 51;
            materialLabel10.Text = "Telefono:";
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel11.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel11.Location = new Point(819, 196);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(79, 24);
            materialLabel11.TabIndex = 52;
            materialLabel11.Text = "Colonia:";
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel12.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel12.Location = new Point(806, 238);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(81, 24);
            materialLabel12.TabIndex = 53;
            materialLabel12.Text = "No. Ext.:";
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel13.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel13.Location = new Point(807, 282);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(74, 24);
            materialLabel13.TabIndex = 54;
            materialLabel13.Text = "Ciudad:";
            // 
            // materialLabel14
            // 
            materialLabel14.AutoSize = true;
            materialLabel14.Depth = 0;
            materialLabel14.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel14.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel14.Location = new Point(807, 322);
            materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new Size(71, 24);
            materialLabel14.TabIndex = 55;
            materialLabel14.Text = "Correo:";
            // 
            // materialLabel15
            // 
            materialLabel15.AutoSize = true;
            materialLabel15.Depth = 0;
            materialLabel15.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel15.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel15.Location = new Point(981, 271);
            materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel15.Name = "materialLabel15";
            materialLabel15.Size = new Size(76, 24);
            materialLabel15.TabIndex = 56;
            materialLabel15.Text = "No. Int.:";
            // 
            // materialLabel16
            // 
            materialLabel16.AutoSize = true;
            materialLabel16.Depth = 0;
            materialLabel16.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel16.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel16.Location = new Point(629, 581);
            materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel16.Name = "materialLabel16";
            materialLabel16.Size = new Size(90, 24);
            materialLabel16.TabIndex = 57;
            materialLabel16.Text = "Subtotal: ";
            // 
            // materialLabel17
            // 
            materialLabel17.AutoSize = true;
            materialLabel17.Depth = 0;
            materialLabel17.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel17.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel17.Location = new Point(629, 611);
            materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel17.Name = "materialLabel17";
            materialLabel17.Size = new Size(157, 24);
            materialLabel17.TabIndex = 58;
            materialLabel17.Text = "Total + IVA(16%):";
            // 
            // Pedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 666);
            Controls.Add(materialLabel17);
            Controls.Add(materialLabel16);
            Controls.Add(materialLabel15);
            Controls.Add(materialLabel14);
            Controls.Add(materialLabel13);
            Controls.Add(materialLabel12);
            Controls.Add(materialLabel11);
            Controls.Add(materialLabel10);
            Controls.Add(materialLabel9);
            Controls.Add(materialLabel8);
            Controls.Add(materialLabel7);
            Controls.Add(materialLabel6);
            Controls.Add(materialLabel5);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(lblFechaCreacion);
            Controls.Add(lblIdPedido);
            Controls.Add(lblRol);
            Controls.Add(dgvDatosPDF);
            Controls.Add(lblTotal);
            Controls.Add(lblSubtotal);
            Controls.Add(lblNombreCliente);
            Controls.Add(cmbCliente);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnAceptar);
            Controls.Add(dgvPedido);
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
            Controls.Add(lblCorreo);
            Controls.Add(lblTel);
            Controls.Add(lblCiudad);
            Controls.Add(lblCp);
            Controls.Add(lblNoInt);
            Controls.Add(lblNoExt);
            Controls.Add(lblColonia);
            Controls.Add(lblCalle);
            Controls.Add(lblCif);
            Controls.Add(lblTituloFact);
            Controls.Add(lblClienteFact);
            Controls.Add(txtComentarios);
            Controls.Add(lblComentarios);
            Controls.Add(lblCliente);
            Controls.Add(lblUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pedido";
            Text = "Crear Pedido";
            Load += Pedido_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosPDF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblUsuario;
        private Label lblCliente;
        private Label lblComentarios;
        private TextBox txtComentarios;
        private Label lblClienteFact;
        private Label lblTituloFact;
        private Label lblCif;
        private Label lblCalle;
        private Label lblColonia;
        private Label lblNoExt;
        private Label lblNoInt;
        private Label lblCp;
        private Label lblCiudad;
        private Label lblTel;
        private Label lblCorreo;
        private TextBox txtNombreCliFact;
        private TextBox txtCif;
        private TextBox txtCalle;
        private TextBox txtCP;
        private TextBox txtTel;
        private TextBox txtCol;
        private TextBox txtNoExt;
        private TextBox txtCorreo;
        private TextBox txtCiudad;
        private TextBox txtNoInt;
        private DataGridView dgvPedido;
        private Button btnAceptar;
        private Button btnAgregarProducto;
        private ComboBox cmbCliente;
        private Label lblNombreCliente;
        private Label lblSubtotal;
        private Label lblTotal;
        private DataGridView dgvDatosPDF;
        public Label lblRol;
        public Label lblIdPedido;
        private Label lblFechaCreacion;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
    }
}
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
            ((System.ComponentModel.ISupportInitialize)dgvPedido).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 20);
            lblUsuario.TabIndex = 0;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(16, 28);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente:";
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.Location = new Point(272, 176);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(96, 20);
            lblComentarios.TabIndex = 3;
            lblComentarios.Text = "Comentarios:";
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(182, 199);
            txtComentarios.Multiline = true;
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(272, 90);
            txtComentarios.TabIndex = 4;
            // 
            // lblClienteFact
            // 
            lblClienteFact.AutoSize = true;
            lblClienteFact.Location = new Point(475, 71);
            lblClienteFact.Name = "lblClienteFact";
            lblClienteFact.Size = new Size(67, 20);
            lblClienteFact.TabIndex = 6;
            lblClienteFact.Text = "Nombre:";
            // 
            // lblTituloFact
            // 
            lblTituloFact.AutoSize = true;
            lblTituloFact.Location = new Point(475, 28);
            lblTituloFact.Name = "lblTituloFact";
            lblTituloFact.Size = new Size(159, 20);
            lblTituloFact.TabIndex = 7;
            lblTituloFact.Text = "DATOS FACTURACION:";
            // 
            // lblCif
            // 
            lblCif.AutoSize = true;
            lblCif.Location = new Point(475, 108);
            lblCif.Name = "lblCif";
            lblCif.Size = new Size(32, 20);
            lblCif.TabIndex = 8;
            lblCif.Text = "CIF:";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(475, 146);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(45, 20);
            lblCalle.TabIndex = 9;
            lblCalle.Text = "Calle:";
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.Location = new Point(742, 108);
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(63, 20);
            lblColonia.TabIndex = 10;
            lblColonia.Text = "Colonia:";
            // 
            // lblNoExt
            // 
            lblNoExt.AutoSize = true;
            lblNoExt.Location = new Point(742, 146);
            lblNoExt.Name = "lblNoExt";
            lblNoExt.Size = new Size(62, 20);
            lblNoExt.TabIndex = 11;
            lblNoExt.Text = "No. Ext.:";
            // 
            // lblNoInt
            // 
            lblNoInt.AutoSize = true;
            lblNoInt.Location = new Point(985, 146);
            lblNoInt.Name = "lblNoInt";
            lblNoInt.Size = new Size(59, 20);
            lblNoInt.TabIndex = 12;
            lblNoInt.Text = "No. Int.:";
            // 
            // lblCp
            // 
            lblCp.AutoSize = true;
            lblCp.Location = new Point(475, 189);
            lblCp.Name = "lblCp";
            lblCp.Size = new Size(35, 20);
            lblCp.TabIndex = 13;
            lblCp.Text = "C.P.:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(742, 189);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(59, 20);
            lblCiudad.TabIndex = 14;
            lblCiudad.Text = "Ciudad:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(475, 233);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(70, 20);
            lblTel.TabIndex = 15;
            lblTel.Text = "Telefono:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(742, 233);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 16;
            lblCorreo.Text = "Correo:";
            // 
            // txtNombreCliFact
            // 
            txtNombreCliFact.Location = new Point(551, 64);
            txtNombreCliFact.Name = "txtNombreCliFact";
            txtNombreCliFact.Size = new Size(310, 27);
            txtNombreCliFact.TabIndex = 17;
            // 
            // txtCif
            // 
            txtCif.Location = new Point(551, 101);
            txtCif.Name = "txtCif";
            txtCif.Size = new Size(159, 27);
            txtCif.TabIndex = 18;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(551, 139);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(159, 27);
            txtCalle.TabIndex = 19;
            // 
            // txtCP
            // 
            txtCP.Location = new Point(551, 182);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(159, 27);
            txtCP.TabIndex = 20;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(551, 226);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(159, 27);
            txtTel.TabIndex = 21;
            // 
            // txtCol
            // 
            txtCol.Location = new Point(811, 101);
            txtCol.Name = "txtCol";
            txtCol.Size = new Size(159, 27);
            txtCol.TabIndex = 22;
            // 
            // txtNoExt
            // 
            txtNoExt.Location = new Point(811, 143);
            txtNoExt.Name = "txtNoExt";
            txtNoExt.Size = new Size(159, 27);
            txtNoExt.TabIndex = 23;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(811, 228);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(159, 27);
            txtCorreo.TabIndex = 25;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(811, 186);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(159, 27);
            txtCiudad.TabIndex = 24;
            // 
            // txtNoInt
            // 
            txtNoInt.Location = new Point(1050, 139);
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
            dgvPedido.Location = new Point(16, 295);
            dgvPedido.Name = "dgvPedido";
            dgvPedido.RowHeadersWidth = 51;
            dgvPedido.RowTemplate.Height = 29;
            dgvPedido.Size = new Size(954, 188);
            dgvPedido.TabIndex = 27;
            dgvPedido.CellClick += dgvPedido_CellClick;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(1073, 514);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 28;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(16, 260);
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
            cmbCliente.Location = new Point(90, 20);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(299, 28);
            cmbCliente.TabIndex = 30;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(16, 64);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(67, 20);
            lblNombreCliente.TabIndex = 35;
            lblNombreCliente.Text = "Nombre:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(811, 486);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(72, 20);
            lblSubtotal.TabIndex = 36;
            lblSubtotal.Text = "Subtotal: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(811, 514);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(123, 20);
            lblTotal.TabIndex = 37;
            lblTotal.Text = "Total + IVA(16%):";
            // 
            // Pedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 555);
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
            Name = "Pedido";
            Text = "Crear Pedido";
            Load += Pedido_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
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
    }
}
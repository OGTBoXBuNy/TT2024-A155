namespace TT2024_A155
{
    partial class verificarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verificarFactura));
            rbtnArchivo = new MaterialSkin.Controls.MaterialRadioButton();
            rbtnQr = new MaterialSkin.Controls.MaterialRadioButton();
            lblUsuario = new Label();
            txtRutaArchivo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblArchivo = new MaterialSkin.Controls.MaterialLabel();
            btnBuscarArchivo = new MaterialSkin.Controls.MaterialFlatButton();
            btnBuscarLlavePub = new MaterialSkin.Controls.MaterialFlatButton();
            lblRutaLlavePub = new MaterialSkin.Controls.MaterialLabel();
            txtRutaLlavePublica = new MaterialSkin.Controls.MaterialSingleLineTextField();
            btnVerificar = new MaterialSkin.Controls.MaterialRaisedButton();
            errorRutaArchivo = new ErrorProvider(components);
            errorLlavePublica = new ErrorProvider(components);
            errorFactura = new ErrorProvider(components);
            lblNumeroFact = new MaterialSkin.Controls.MaterialLabel();
            lblCliente = new MaterialSkin.Controls.MaterialLabel();
            txtDatosCliente = new TextBox();
            dgvFactura = new DataGridView();
            txtDatosProveedor = new TextBox();
            lblProveedor = new MaterialSkin.Controls.MaterialLabel();
            lblCamara = new MaterialSkin.Controls.MaterialLabel();
            cmbDispositivos = new ComboBox();
            pbLectorQr = new PictureBox();
            btnLeer = new MaterialSkin.Controls.MaterialRaisedButton();
            txtLecturaQr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            btnComenzar = new MaterialSkin.Controls.MaterialRaisedButton();
            temporizador = new System.Windows.Forms.Timer(components);
            cmbFactura = new ComboBox();
            lblNumFact = new MaterialSkin.Controls.MaterialLabel();
            lblfechaEmision = new MaterialSkin.Controls.MaterialLabel();
            lblComentario = new MaterialSkin.Controls.MaterialLabel();
            txtComentario = new TextBox();
            lblSubTotal = new MaterialSkin.Controls.MaterialLabel();
            lblImpuestos = new MaterialSkin.Controls.MaterialLabel();
            lblTotal = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)errorRutaArchivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorLlavePublica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLectorQr).BeginInit();
            SuspendLayout();
            // 
            // rbtnArchivo
            // 
            rbtnArchivo.AutoSize = true;
            rbtnArchivo.Checked = true;
            rbtnArchivo.Depth = 0;
            rbtnArchivo.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnArchivo.Location = new Point(18, 87);
            rbtnArchivo.Margin = new Padding(0);
            rbtnArchivo.MouseLocation = new Point(-1, -1);
            rbtnArchivo.MouseState = MaterialSkin.MouseState.HOVER;
            rbtnArchivo.Name = "rbtnArchivo";
            rbtnArchivo.Ripple = true;
            rbtnArchivo.Size = new Size(141, 30);
            rbtnArchivo.TabIndex = 0;
            rbtnArchivo.TabStop = true;
            rbtnArchivo.Text = "Desde Archivo";
            rbtnArchivo.UseVisualStyleBackColor = true;
            rbtnArchivo.CheckedChanged += rbtnArchivo_CheckedChanged;
            // 
            // rbtnQr
            // 
            rbtnQr.AutoSize = true;
            rbtnQr.Depth = 0;
            rbtnQr.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnQr.Location = new Point(196, 87);
            rbtnQr.Margin = new Padding(0);
            rbtnQr.MouseLocation = new Point(-1, -1);
            rbtnQr.MouseState = MaterialSkin.MouseState.HOVER;
            rbtnQr.Name = "rbtnQr";
            rbtnQr.Ripple = true;
            rbtnQr.Size = new Size(164, 30);
            rbtnQr.TabIndex = 1;
            rbtnQr.Text = "Desde Código QR";
            rbtnQr.UseVisualStyleBackColor = true;
            rbtnQr.CheckedChanged += rbtnQr_CheckedChanged;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(210, 25);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 20);
            lblUsuario.TabIndex = 2;
            // 
            // txtRutaArchivo
            // 
            txtRutaArchivo.Depth = 0;
            txtRutaArchivo.Enabled = false;
            txtRutaArchivo.Hint = "";
            txtRutaArchivo.Location = new Point(196, 155);
            txtRutaArchivo.MaxLength = 32767;
            txtRutaArchivo.MouseState = MaterialSkin.MouseState.HOVER;
            txtRutaArchivo.Name = "txtRutaArchivo";
            txtRutaArchivo.PasswordChar = '\0';
            txtRutaArchivo.SelectedText = "";
            txtRutaArchivo.SelectionLength = 0;
            txtRutaArchivo.SelectionStart = 0;
            txtRutaArchivo.Size = new Size(313, 28);
            txtRutaArchivo.TabIndex = 3;
            txtRutaArchivo.TabStop = false;
            txtRutaArchivo.UseSystemPasswordChar = false;
            // 
            // lblArchivo
            // 
            lblArchivo.AutoSize = true;
            lblArchivo.Depth = 0;
            lblArchivo.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblArchivo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblArchivo.Location = new Point(12, 155);
            lblArchivo.MouseState = MaterialSkin.MouseState.HOVER;
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(121, 24);
            lblArchivo.TabIndex = 4;
            lblArchivo.Text = "Ruta Archivo:";
            // 
            // btnBuscarArchivo
            // 
            btnBuscarArchivo.AutoSize = true;
            btnBuscarArchivo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarArchivo.Depth = 0;
            btnBuscarArchivo.Icon = null;
            btnBuscarArchivo.Location = new Point(516, 148);
            btnBuscarArchivo.Margin = new Padding(4, 6, 4, 6);
            btnBuscarArchivo.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarArchivo.Name = "btnBuscarArchivo";
            btnBuscarArchivo.Primary = false;
            btnBuscarArchivo.Size = new Size(36, 36);
            btnBuscarArchivo.TabIndex = 5;
            btnBuscarArchivo.Text = "...";
            btnBuscarArchivo.UseVisualStyleBackColor = true;
            btnBuscarArchivo.Click += btnBuscarArchivo_Click;
            // 
            // btnBuscarLlavePub
            // 
            btnBuscarLlavePub.AutoSize = true;
            btnBuscarLlavePub.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarLlavePub.Depth = 0;
            btnBuscarLlavePub.Icon = null;
            btnBuscarLlavePub.Location = new Point(516, 196);
            btnBuscarLlavePub.Margin = new Padding(4, 6, 4, 6);
            btnBuscarLlavePub.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarLlavePub.Name = "btnBuscarLlavePub";
            btnBuscarLlavePub.Primary = false;
            btnBuscarLlavePub.Size = new Size(36, 36);
            btnBuscarLlavePub.TabIndex = 8;
            btnBuscarLlavePub.Text = "...";
            btnBuscarLlavePub.UseVisualStyleBackColor = true;
            btnBuscarLlavePub.Click += btnBuscarLlavePub_Click;
            // 
            // lblRutaLlavePub
            // 
            lblRutaLlavePub.AutoSize = true;
            lblRutaLlavePub.Depth = 0;
            lblRutaLlavePub.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblRutaLlavePub.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblRutaLlavePub.Location = new Point(12, 200);
            lblRutaLlavePub.MouseState = MaterialSkin.MouseState.HOVER;
            lblRutaLlavePub.Name = "lblRutaLlavePub";
            lblRutaLlavePub.Size = new Size(169, 24);
            lblRutaLlavePub.TabIndex = 7;
            lblRutaLlavePub.Text = "Ruta Llave publica:";
            // 
            // txtRutaLlavePublica
            // 
            txtRutaLlavePublica.Depth = 0;
            txtRutaLlavePublica.Enabled = false;
            txtRutaLlavePublica.Hint = "";
            txtRutaLlavePublica.Location = new Point(196, 200);
            txtRutaLlavePublica.MaxLength = 32767;
            txtRutaLlavePublica.MouseState = MaterialSkin.MouseState.HOVER;
            txtRutaLlavePublica.Name = "txtRutaLlavePublica";
            txtRutaLlavePublica.PasswordChar = '\0';
            txtRutaLlavePublica.SelectedText = "";
            txtRutaLlavePublica.SelectionLength = 0;
            txtRutaLlavePublica.SelectionStart = 0;
            txtRutaLlavePublica.Size = new Size(313, 28);
            txtRutaLlavePublica.TabIndex = 6;
            txtRutaLlavePublica.TabStop = false;
            txtRutaLlavePublica.UseSystemPasswordChar = false;
            // 
            // btnVerificar
            // 
            btnVerificar.AutoSize = true;
            btnVerificar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVerificar.Depth = 0;
            btnVerificar.Icon = null;
            btnVerificar.Location = new Point(446, 289);
            btnVerificar.MouseState = MaterialSkin.MouseState.HOVER;
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Primary = true;
            btnVerificar.Size = new Size(106, 36);
            btnVerificar.TabIndex = 9;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // errorRutaArchivo
            // 
            errorRutaArchivo.ContainerControl = this;
            // 
            // errorLlavePublica
            // 
            errorLlavePublica.ContainerControl = this;
            // 
            // errorFactura
            // 
            errorFactura.ContainerControl = this;
            // 
            // lblNumeroFact
            // 
            lblNumeroFact.AutoSize = true;
            lblNumeroFact.Depth = 0;
            lblNumeroFact.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumeroFact.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNumeroFact.Location = new Point(12, 340);
            lblNumeroFact.MouseState = MaterialSkin.MouseState.HOVER;
            lblNumeroFact.Name = "lblNumeroFact";
            lblNumeroFact.Size = new Size(177, 24);
            lblNumeroFact.TabIndex = 10;
            lblNumeroFact.Text = "Número de Factura:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Depth = 0;
            lblCliente.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCliente.Location = new Point(12, 390);
            lblCliente.MouseState = MaterialSkin.MouseState.HOVER;
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(73, 24);
            lblCliente.TabIndex = 11;
            lblCliente.Text = "Cliente:";
            // 
            // txtDatosCliente
            // 
            txtDatosCliente.BackColor = Color.White;
            txtDatosCliente.BorderStyle = BorderStyle.None;
            txtDatosCliente.Enabled = false;
            txtDatosCliente.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDatosCliente.Location = new Point(196, 380);
            txtDatosCliente.Multiline = true;
            txtDatosCliente.Name = "txtDatosCliente";
            txtDatosCliente.Size = new Size(308, 114);
            txtDatosCliente.TabIndex = 12;
            // 
            // dgvFactura
            // 
            dgvFactura.AllowUserToAddRows = false;
            dgvFactura.AllowUserToDeleteRows = false;
            dgvFactura.AllowUserToResizeRows = false;
            dgvFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFactura.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(2, 591);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.RowTemplate.Height = 29;
            dgvFactura.Size = new Size(845, 188);
            dgvFactura.TabIndex = 28;
            // 
            // txtDatosProveedor
            // 
            txtDatosProveedor.BackColor = Color.White;
            txtDatosProveedor.BorderStyle = BorderStyle.None;
            txtDatosProveedor.Enabled = false;
            txtDatosProveedor.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDatosProveedor.Location = new Point(973, 603);
            txtDatosProveedor.Multiline = true;
            txtDatosProveedor.Name = "txtDatosProveedor";
            txtDatosProveedor.Size = new Size(475, 128);
            txtDatosProveedor.TabIndex = 30;
            txtDatosProveedor.Text = resources.GetString("txtDatosProveedor.Text");
            txtDatosProveedor.Visible = false;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Depth = 0;
            lblProveedor.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblProveedor.Location = new Point(849, 603);
            lblProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(101, 24);
            lblProveedor.TabIndex = 29;
            lblProveedor.Text = "Proveedor:";
            // 
            // lblCamara
            // 
            lblCamara.AutoSize = true;
            lblCamara.Depth = 0;
            lblCamara.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCamara.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCamara.Location = new Point(579, 72);
            lblCamara.MouseState = MaterialSkin.MouseState.HOVER;
            lblCamara.Name = "lblCamara";
            lblCamara.Size = new Size(80, 24);
            lblCamara.TabIndex = 31;
            lblCamara.Text = "Camara:";
            lblCamara.Visible = false;
            // 
            // cmbDispositivos
            // 
            cmbDispositivos.FormattingEnabled = true;
            cmbDispositivos.Location = new Point(665, 71);
            cmbDispositivos.Name = "cmbDispositivos";
            cmbDispositivos.Size = new Size(237, 28);
            cmbDispositivos.TabIndex = 32;
            cmbDispositivos.Visible = false;
            // 
            // pbLectorQr
            // 
            pbLectorQr.BorderStyle = BorderStyle.Fixed3D;
            pbLectorQr.Location = new Point(665, 105);
            pbLectorQr.Name = "pbLectorQr";
            pbLectorQr.Size = new Size(431, 248);
            pbLectorQr.SizeMode = PictureBoxSizeMode.Zoom;
            pbLectorQr.TabIndex = 33;
            pbLectorQr.TabStop = false;
            pbLectorQr.Visible = false;
            // 
            // btnLeer
            // 
            btnLeer.AutoSize = true;
            btnLeer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLeer.Depth = 0;
            btnLeer.Icon = null;
            btnLeer.Location = new Point(1035, 66);
            btnLeer.MouseState = MaterialSkin.MouseState.HOVER;
            btnLeer.Name = "btnLeer";
            btnLeer.Primary = true;
            btnLeer.Size = new Size(61, 36);
            btnLeer.TabIndex = 34;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Visible = false;
            btnLeer.Click += btnLeer_Click;
            // 
            // txtLecturaQr
            // 
            txtLecturaQr.Depth = 0;
            txtLecturaQr.Hint = "";
            txtLecturaQr.Location = new Point(210, 25);
            txtLecturaQr.MaxLength = 32767;
            txtLecturaQr.MouseState = MaterialSkin.MouseState.HOVER;
            txtLecturaQr.Name = "txtLecturaQr";
            txtLecturaQr.PasswordChar = '\0';
            txtLecturaQr.SelectedText = "";
            txtLecturaQr.SelectionLength = 0;
            txtLecturaQr.SelectionStart = 0;
            txtLecturaQr.Size = new Size(517, 28);
            txtLecturaQr.TabIndex = 35;
            txtLecturaQr.TabStop = false;
            txtLecturaQr.UseSystemPasswordChar = false;
            txtLecturaQr.Visible = false;
            // 
            // btnComenzar
            // 
            btnComenzar.AutoSize = true;
            btnComenzar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnComenzar.Depth = 0;
            btnComenzar.Icon = null;
            btnComenzar.Location = new Point(908, 66);
            btnComenzar.MouseState = MaterialSkin.MouseState.HOVER;
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Primary = true;
            btnComenzar.Size = new Size(115, 36);
            btnComenzar.TabIndex = 36;
            btnComenzar.Text = "Comenzar";
            btnComenzar.UseVisualStyleBackColor = true;
            btnComenzar.Visible = false;
            btnComenzar.Click += btnComenzar_Click;
            // 
            // temporizador
            // 
            temporizador.Tick += temporizador_Tick;
            // 
            // cmbFactura
            // 
            cmbFactura.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbFactura.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbFactura.FormattingEnabled = true;
            cmbFactura.Location = new Point(196, 255);
            cmbFactura.Name = "cmbFactura";
            cmbFactura.Size = new Size(313, 28);
            cmbFactura.TabIndex = 37;
            // 
            // lblNumFact
            // 
            lblNumFact.AutoSize = true;
            lblNumFact.Depth = 0;
            lblNumFact.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumFact.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNumFact.Location = new Point(12, 255);
            lblNumFact.MouseState = MaterialSkin.MouseState.HOVER;
            lblNumFact.Name = "lblNumFact";
            lblNumFact.Size = new Size(78, 24);
            lblNumFact.TabIndex = 38;
            lblNumFact.Text = "Factura:";
            // 
            // lblfechaEmision
            // 
            lblfechaEmision.AutoSize = true;
            lblfechaEmision.Depth = 0;
            lblfechaEmision.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblfechaEmision.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblfechaEmision.Location = new Point(665, 370);
            lblfechaEmision.MouseState = MaterialSkin.MouseState.HOVER;
            lblfechaEmision.Name = "lblfechaEmision";
            lblfechaEmision.Size = new Size(140, 24);
            lblfechaEmision.TabIndex = 39;
            lblfechaEmision.Text = "Fecha Emisión:";
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Depth = 0;
            lblComentario.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblComentario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblComentario.Location = new Point(12, 527);
            lblComentario.MouseState = MaterialSkin.MouseState.HOVER;
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(113, 24);
            lblComentario.TabIndex = 40;
            lblComentario.Text = "Comentario:";
            // 
            // txtComentario
            // 
            txtComentario.BackColor = Color.White;
            txtComentario.BorderStyle = BorderStyle.None;
            txtComentario.Enabled = false;
            txtComentario.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtComentario.Location = new Point(196, 527);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(308, 58);
            txtComentario.TabIndex = 41;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Depth = 0;
            lblSubTotal.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubTotal.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblSubTotal.Location = new Point(665, 420);
            lblSubTotal.MouseState = MaterialSkin.MouseState.HOVER;
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(90, 24);
            lblSubTotal.TabIndex = 42;
            lblSubTotal.Text = "SubTotal:";
            // 
            // lblImpuestos
            // 
            lblImpuestos.AutoSize = true;
            lblImpuestos.Depth = 0;
            lblImpuestos.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblImpuestos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblImpuestos.Location = new Point(665, 470);
            lblImpuestos.MouseState = MaterialSkin.MouseState.HOVER;
            lblImpuestos.Name = "lblImpuestos";
            lblImpuestos.Size = new Size(105, 24);
            lblImpuestos.TabIndex = 43;
            lblImpuestos.Text = "Impuestos:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Depth = 0;
            lblTotal.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTotal.Location = new Point(665, 520);
            lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 24);
            lblTotal.TabIndex = 44;
            lblTotal.Text = "Total:";
            // 
            // verificarFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 790);
            Controls.Add(lblTotal);
            Controls.Add(lblImpuestos);
            Controls.Add(lblSubTotal);
            Controls.Add(txtComentario);
            Controls.Add(lblComentario);
            Controls.Add(lblfechaEmision);
            Controls.Add(lblNumFact);
            Controls.Add(cmbFactura);
            Controls.Add(btnComenzar);
            Controls.Add(txtLecturaQr);
            Controls.Add(btnLeer);
            Controls.Add(pbLectorQr);
            Controls.Add(cmbDispositivos);
            Controls.Add(lblCamara);
            Controls.Add(txtDatosProveedor);
            Controls.Add(lblProveedor);
            Controls.Add(dgvFactura);
            Controls.Add(txtDatosCliente);
            Controls.Add(lblCliente);
            Controls.Add(lblNumeroFact);
            Controls.Add(btnVerificar);
            Controls.Add(btnBuscarLlavePub);
            Controls.Add(lblRutaLlavePub);
            Controls.Add(txtRutaLlavePublica);
            Controls.Add(btnBuscarArchivo);
            Controls.Add(lblArchivo);
            Controls.Add(txtRutaArchivo);
            Controls.Add(lblUsuario);
            Controls.Add(rbtnQr);
            Controls.Add(rbtnArchivo);
            Name = "verificarFactura";
            Text = "Verificar Factura";
            FormClosing += verificarFactura_FormClosing;
            Load += verificarFactura_Load;
            ((System.ComponentModel.ISupportInitialize)errorRutaArchivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorLlavePublica).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLectorQr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton rbtnArchivo;
        private MaterialSkin.Controls.MaterialRadioButton rbtnQr;
        private Label lblUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRutaArchivo;
        private MaterialSkin.Controls.MaterialLabel lblArchivo;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarArchivo;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarLlavePub;
        private MaterialSkin.Controls.MaterialLabel lblRutaLlavePub;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRutaLlavePublica;
        private MaterialSkin.Controls.MaterialRaisedButton btnVerificar;
        private ErrorProvider errorRutaArchivo;
        private MaterialSkin.Controls.MaterialLabel lblNumeroFact;
        private ErrorProvider errorLlavePublica;
        private ErrorProvider errorFactura;
        private TextBox txtDatosCliente;
        private MaterialSkin.Controls.MaterialLabel lblCliente;
        private TextBox txtDatosProveedor;
        private MaterialSkin.Controls.MaterialLabel lblProveedor;
        private DataGridView dgvFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLecturaQr;
        private MaterialSkin.Controls.MaterialRaisedButton btnLeer;
        private PictureBox pbLectorQr;
        private ComboBox cmbDispositivos;
        private MaterialSkin.Controls.MaterialLabel lblCamara;
        private MaterialSkin.Controls.MaterialRaisedButton btnComenzar;
        private System.Windows.Forms.Timer temporizador;
        private MaterialSkin.Controls.MaterialLabel lblNumFact;
        private ComboBox cmbFactura;
        private TextBox txtComentario;
        private MaterialSkin.Controls.MaterialLabel lblComentario;
        private MaterialSkin.Controls.MaterialLabel lblfechaEmision;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialLabel lblImpuestos;
        private MaterialSkin.Controls.MaterialLabel lblSubTotal;
    }
}
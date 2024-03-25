namespace TT2024_A155
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            txtComentarios = new TextBox();
            dtpFechEmision = new DateTimePicker();
            lblIDPedido = new Label();
            dgvDatosFactura = new DataGridView();
            fileRoute = new SaveFileDialog();
            lblUsuario = new Label();
            errorNumeroFact = new ErrorProvider(components);
            errorFactSinIva = new ErrorProvider(components);
            errorDescuento = new ErrorProvider(components);
            errorFactConIva = new ErrorProvider(components);
            errorLlavePublica = new ErrorProvider(components);
            errorLlavePrivada = new ErrorProvider(components);
            lblNumFact = new MaterialSkin.Controls.MaterialLabel();
            lblFactSinIva = new MaterialSkin.Controls.MaterialLabel();
            lblFactConIva = new MaterialSkin.Controls.MaterialLabel();
            lblDescuento = new MaterialSkin.Controls.MaterialLabel();
            lblComentarios = new MaterialSkin.Controls.MaterialLabel();
            lblLlavePrivada = new MaterialSkin.Controls.MaterialLabel();
            lblLlavePublica = new MaterialSkin.Controls.MaterialLabel();
            lblFecha = new MaterialSkin.Controls.MaterialLabel();
            txtNumeroFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtFacturaSinIVA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtFactIVA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtpubKey = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtprivKey = new MaterialSkin.Controls.MaterialSingleLineTextField();
            btnpubKey = new MaterialSkin.Controls.MaterialFlatButton();
            btnprivKey = new MaterialSkin.Controls.MaterialFlatButton();
            btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            txtContraLlavePrivada = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblContrasenia = new MaterialSkin.Controls.MaterialLabel();
            errorContraLlavePriv = new ErrorProvider(components);
            PicOJO = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatosFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNumeroFact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorFactSinIva).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorDescuento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorFactConIva).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorLlavePublica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorLlavePrivada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorContraLlavePriv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicOJO).BeginInit();
            SuspendLayout();
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(318, 365);
            txtComentarios.Multiline = true;
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(285, 70);
            txtComentarios.TabIndex = 11;
            // 
            // dtpFechEmision
            // 
            dtpFechEmision.Location = new Point(318, 245);
            dtpFechEmision.Name = "dtpFechEmision";
            dtpFechEmision.Size = new Size(250, 27);
            dtpFechEmision.TabIndex = 13;
            // 
            // lblIDPedido
            // 
            lblIDPedido.AutoSize = true;
            lblIDPedido.Location = new Point(238, 9);
            lblIDPedido.Name = "lblIDPedido";
            lblIDPedido.Size = new Size(77, 20);
            lblIDPedido.TabIndex = 14;
            lblIDPedido.Text = "IDPEDIDO";
            // 
            // dgvDatosFactura
            // 
            dgvDatosFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosFactura.Enabled = false;
            dgvDatosFactura.Location = new Point(785, 177);
            dgvDatosFactura.Name = "dgvDatosFactura";
            dgvDatosFactura.RowHeadersWidth = 51;
            dgvDatosFactura.RowTemplate.Height = 29;
            dgvDatosFactura.Size = new Size(300, 188);
            dgvDatosFactura.TabIndex = 15;
            dgvDatosFactura.Visible = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(238, 39);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 20);
            lblUsuario.TabIndex = 22;
            // 
            // errorNumeroFact
            // 
            errorNumeroFact.ContainerControl = this;
            // 
            // errorFactSinIva
            // 
            errorFactSinIva.ContainerControl = this;
            // 
            // errorDescuento
            // 
            errorDescuento.ContainerControl = this;
            // 
            // errorFactConIva
            // 
            errorFactConIva.ContainerControl = this;
            // 
            // errorLlavePublica
            // 
            errorLlavePublica.ContainerControl = this;
            // 
            // errorLlavePrivada
            // 
            errorLlavePrivada.ContainerControl = this;
            // 
            // lblNumFact
            // 
            lblNumFact.AutoSize = true;
            lblNumFact.Depth = 0;
            lblNumFact.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumFact.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNumFact.Location = new Point(13, 85);
            lblNumFact.MouseState = MaterialSkin.MouseState.HOVER;
            lblNumFact.Name = "lblNumFact";
            lblNumFact.Size = new Size(182, 24);
            lblNumFact.TabIndex = 23;
            lblNumFact.Text = "Numero de Factura: ";
            // 
            // lblFactSinIva
            // 
            lblFactSinIva.AutoSize = true;
            lblFactSinIva.Depth = 0;
            lblFactSinIva.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblFactSinIva.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblFactSinIva.Location = new Point(13, 125);
            lblFactSinIva.MouseState = MaterialSkin.MouseState.HOVER;
            lblFactSinIva.Name = "lblFactSinIva";
            lblFactSinIva.Size = new Size(148, 24);
            lblFactSinIva.TabIndex = 24;
            lblFactSinIva.Text = "Factura Sin IVA: ";
            // 
            // lblFactConIva
            // 
            lblFactConIva.AutoSize = true;
            lblFactConIva.Depth = 0;
            lblFactConIva.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblFactConIva.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblFactConIva.Location = new Point(13, 205);
            lblFactConIva.MouseState = MaterialSkin.MouseState.HOVER;
            lblFactConIva.Name = "lblFactConIva";
            lblFactConIva.Size = new Size(155, 24);
            lblFactConIva.TabIndex = 26;
            lblFactConIva.Text = "Factura Con IVA: ";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Depth = 0;
            lblDescuento.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescuento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDescuento.Location = new Point(13, 165);
            lblDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(109, 24);
            lblDescuento.TabIndex = 25;
            lblDescuento.Text = "Descuento: ";
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.Depth = 0;
            lblComentarios.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblComentarios.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblComentarios.Location = new Point(16, 365);
            lblComentarios.MouseState = MaterialSkin.MouseState.HOVER;
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(128, 24);
            lblComentarios.TabIndex = 30;
            lblComentarios.Text = "Comentarios: ";
            // 
            // lblLlavePrivada
            // 
            lblLlavePrivada.AutoSize = true;
            lblLlavePrivada.Depth = 0;
            lblLlavePrivada.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblLlavePrivada.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblLlavePrivada.Location = new Point(13, 325);
            lblLlavePrivada.MouseState = MaterialSkin.MouseState.HOVER;
            lblLlavePrivada.Name = "lblLlavePrivada";
            lblLlavePrivada.Size = new Size(164, 24);
            lblLlavePrivada.TabIndex = 29;
            lblLlavePrivada.Text = "Ruta llave privada:";
            // 
            // lblLlavePublica
            // 
            lblLlavePublica.AutoSize = true;
            lblLlavePublica.Depth = 0;
            lblLlavePublica.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblLlavePublica.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblLlavePublica.Location = new Point(25, 521);
            lblLlavePublica.MouseState = MaterialSkin.MouseState.HOVER;
            lblLlavePublica.Name = "lblLlavePublica";
            lblLlavePublica.Size = new Size(164, 24);
            lblLlavePublica.TabIndex = 28;
            lblLlavePublica.Text = "Ruta llave publica:";
            lblLlavePublica.Visible = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Depth = 0;
            lblFecha.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblFecha.Location = new Point(13, 245);
            lblFecha.MouseState = MaterialSkin.MouseState.HOVER;
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(145, 24);
            lblFecha.TabIndex = 27;
            lblFecha.Text = "Fecha Emision: ";
            // 
            // txtNumeroFactura
            // 
            txtNumeroFactura.Depth = 0;
            txtNumeroFactura.Hint = "";
            txtNumeroFactura.Location = new Point(318, 85);
            txtNumeroFactura.MaxLength = 32767;
            txtNumeroFactura.MouseState = MaterialSkin.MouseState.HOVER;
            txtNumeroFactura.Name = "txtNumeroFactura";
            txtNumeroFactura.PasswordChar = '\0';
            txtNumeroFactura.SelectedText = "";
            txtNumeroFactura.SelectionLength = 0;
            txtNumeroFactura.SelectionStart = 0;
            txtNumeroFactura.Size = new Size(285, 28);
            txtNumeroFactura.TabIndex = 31;
            txtNumeroFactura.TabStop = false;
            txtNumeroFactura.UseSystemPasswordChar = false;
            // 
            // txtFacturaSinIVA
            // 
            txtFacturaSinIVA.Depth = 0;
            txtFacturaSinIVA.Enabled = false;
            txtFacturaSinIVA.Hint = "";
            txtFacturaSinIVA.Location = new Point(318, 125);
            txtFacturaSinIVA.MaxLength = 32767;
            txtFacturaSinIVA.MouseState = MaterialSkin.MouseState.HOVER;
            txtFacturaSinIVA.Name = "txtFacturaSinIVA";
            txtFacturaSinIVA.PasswordChar = '\0';
            txtFacturaSinIVA.SelectedText = "";
            txtFacturaSinIVA.SelectionLength = 0;
            txtFacturaSinIVA.SelectionStart = 0;
            txtFacturaSinIVA.Size = new Size(285, 28);
            txtFacturaSinIVA.TabIndex = 32;
            txtFacturaSinIVA.TabStop = false;
            txtFacturaSinIVA.UseSystemPasswordChar = false;
            // 
            // txtFactIVA
            // 
            txtFactIVA.Depth = 0;
            txtFactIVA.Enabled = false;
            txtFactIVA.Hint = "";
            txtFactIVA.Location = new Point(318, 205);
            txtFactIVA.MaxLength = 32767;
            txtFactIVA.MouseState = MaterialSkin.MouseState.HOVER;
            txtFactIVA.Name = "txtFactIVA";
            txtFactIVA.PasswordChar = '\0';
            txtFactIVA.SelectedText = "";
            txtFactIVA.SelectionLength = 0;
            txtFactIVA.SelectionStart = 0;
            txtFactIVA.Size = new Size(285, 28);
            txtFactIVA.TabIndex = 34;
            txtFactIVA.TabStop = false;
            txtFactIVA.UseSystemPasswordChar = false;
            // 
            // txtDescuento
            // 
            txtDescuento.Depth = 0;
            txtDescuento.Hint = "";
            txtDescuento.Location = new Point(318, 165);
            txtDescuento.MaxLength = 32767;
            txtDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.PasswordChar = '\0';
            txtDescuento.SelectedText = "";
            txtDescuento.SelectionLength = 0;
            txtDescuento.SelectionStart = 0;
            txtDescuento.Size = new Size(285, 28);
            txtDescuento.TabIndex = 33;
            txtDescuento.TabStop = false;
            txtDescuento.Text = "0";
            txtDescuento.UseSystemPasswordChar = false;
            txtDescuento.KeyPress += txtDescuento_KeyPress;
            // 
            // txtpubKey
            // 
            txtpubKey.Depth = 0;
            txtpubKey.Enabled = false;
            txtpubKey.Hint = "";
            txtpubKey.Location = new Point(330, 521);
            txtpubKey.MaxLength = 32767;
            txtpubKey.MouseState = MaterialSkin.MouseState.HOVER;
            txtpubKey.Name = "txtpubKey";
            txtpubKey.PasswordChar = '\0';
            txtpubKey.SelectedText = "";
            txtpubKey.SelectionLength = 0;
            txtpubKey.SelectionStart = 0;
            txtpubKey.Size = new Size(285, 28);
            txtpubKey.TabIndex = 35;
            txtpubKey.TabStop = false;
            txtpubKey.UseSystemPasswordChar = false;
            txtpubKey.Visible = false;
            // 
            // txtprivKey
            // 
            txtprivKey.Depth = 0;
            txtprivKey.Enabled = false;
            txtprivKey.Hint = "";
            txtprivKey.Location = new Point(318, 325);
            txtprivKey.MaxLength = 32767;
            txtprivKey.MouseState = MaterialSkin.MouseState.HOVER;
            txtprivKey.Name = "txtprivKey";
            txtprivKey.PasswordChar = '\0';
            txtprivKey.SelectedText = "";
            txtprivKey.SelectionLength = 0;
            txtprivKey.SelectionStart = 0;
            txtprivKey.Size = new Size(285, 28);
            txtprivKey.TabIndex = 36;
            txtprivKey.TabStop = false;
            txtprivKey.UseSystemPasswordChar = false;
            // 
            // btnpubKey
            // 
            btnpubKey.AutoSize = true;
            btnpubKey.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnpubKey.Depth = 0;
            btnpubKey.Icon = null;
            btnpubKey.Location = new Point(622, 513);
            btnpubKey.Margin = new Padding(4, 6, 4, 6);
            btnpubKey.MouseState = MaterialSkin.MouseState.HOVER;
            btnpubKey.Name = "btnpubKey";
            btnpubKey.Primary = false;
            btnpubKey.Size = new Size(36, 36);
            btnpubKey.TabIndex = 37;
            btnpubKey.Text = "...";
            btnpubKey.UseVisualStyleBackColor = true;
            btnpubKey.Visible = false;
            // 
            // btnprivKey
            // 
            btnprivKey.AutoSize = true;
            btnprivKey.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnprivKey.Depth = 0;
            btnprivKey.Icon = null;
            btnprivKey.Location = new Point(610, 325);
            btnprivKey.Margin = new Padding(4, 6, 4, 6);
            btnprivKey.MouseState = MaterialSkin.MouseState.HOVER;
            btnprivKey.Name = "btnprivKey";
            btnprivKey.Primary = false;
            btnprivKey.Size = new Size(36, 36);
            btnprivKey.TabIndex = 38;
            btnprivKey.Text = "...";
            btnprivKey.UseVisualStyleBackColor = true;
            btnprivKey.Click += btnprivKey_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.AutoSize = true;
            btnAceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAceptar.Depth = 0;
            btnAceptar.Icon = null;
            btnAceptar.Location = new Point(505, 451);
            btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Primary = true;
            btnAceptar.Size = new Size(98, 36);
            btnAceptar.TabIndex = 39;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtContraLlavePrivada
            // 
            txtContraLlavePrivada.Depth = 0;
            txtContraLlavePrivada.Hint = "";
            txtContraLlavePrivada.Location = new Point(318, 285);
            txtContraLlavePrivada.MaxLength = 32767;
            txtContraLlavePrivada.MouseState = MaterialSkin.MouseState.HOVER;
            txtContraLlavePrivada.Name = "txtContraLlavePrivada";
            txtContraLlavePrivada.PasswordChar = '\0';
            txtContraLlavePrivada.SelectedText = "";
            txtContraLlavePrivada.SelectionLength = 0;
            txtContraLlavePrivada.SelectionStart = 0;
            txtContraLlavePrivada.Size = new Size(285, 28);
            txtContraLlavePrivada.TabIndex = 41;
            txtContraLlavePrivada.TabStop = false;
            txtContraLlavePrivada.UseSystemPasswordChar = true;
            txtContraLlavePrivada.Enter += txtContraLlavePrivada_Enter;
            txtContraLlavePrivada.Leave += txtContraLlavePrivada_Leave;
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Depth = 0;
            lblContrasenia.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblContrasenia.Location = new Point(13, 285);
            lblContrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(221, 24);
            lblContrasenia.TabIndex = 40;
            lblContrasenia.Text = "Contraseña llave privada:";
            // 
            // errorContraLlavePriv
            // 
            errorContraLlavePriv.ContainerControl = this;
            // 
            // PicOJO
            // 
            PicOJO.Image = Properties.Resources.ojo;
            PicOJO.Location = new Point(610, 285);
            PicOJO.Margin = new Padding(4);
            PicOJO.Name = "PicOJO";
            PicOJO.Size = new Size(44, 28);
            PicOJO.SizeMode = PictureBoxSizeMode.Zoom;
            PicOJO.TabIndex = 42;
            PicOJO.TabStop = false;
            PicOJO.Visible = false;
            PicOJO.MouseClick += PicOJO_MouseClick;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(683, 501);
            Controls.Add(PicOJO);
            Controls.Add(txtContraLlavePrivada);
            Controls.Add(lblContrasenia);
            Controls.Add(btnAceptar);
            Controls.Add(btnprivKey);
            Controls.Add(btnpubKey);
            Controls.Add(txtprivKey);
            Controls.Add(txtpubKey);
            Controls.Add(txtFactIVA);
            Controls.Add(txtDescuento);
            Controls.Add(txtFacturaSinIVA);
            Controls.Add(txtNumeroFactura);
            Controls.Add(lblComentarios);
            Controls.Add(lblLlavePrivada);
            Controls.Add(lblLlavePublica);
            Controls.Add(lblFecha);
            Controls.Add(lblFactConIva);
            Controls.Add(lblDescuento);
            Controls.Add(lblFactSinIva);
            Controls.Add(lblNumFact);
            Controls.Add(lblUsuario);
            Controls.Add(dgvDatosFactura);
            Controls.Add(lblIDPedido);
            Controls.Add(dtpFechEmision);
            Controls.Add(txtComentarios);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Factura";
            Text = "Generación de Factura";
            Load += Factura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatosFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNumeroFact).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorFactSinIva).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorDescuento).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorFactConIva).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorLlavePublica).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorLlavePrivada).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorContraLlavePriv).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicOJO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtComentarios;
        private DateTimePicker dtpFechEmision;
        public Label lblIDPedido;
        private DataGridView dgvDatosFactura;
        private SaveFileDialog fileRoute;
        public Label lblUsuario;
        private ErrorProvider errorNumeroFact;
        private ErrorProvider errorFactSinIva;
        private ErrorProvider errorDescuento;
        private ErrorProvider errorFactConIva;
        private ErrorProvider errorLlavePublica;
        private ErrorProvider errorLlavePrivada;
        private MaterialSkin.Controls.MaterialLabel lblComentarios;
        private MaterialSkin.Controls.MaterialLabel lblLlavePrivada;
        private MaterialSkin.Controls.MaterialLabel lblLlavePublica;
        private MaterialSkin.Controls.MaterialLabel lblFecha;
        private MaterialSkin.Controls.MaterialLabel lblFactConIva;
        private MaterialSkin.Controls.MaterialLabel lblDescuento;
        private MaterialSkin.Controls.MaterialLabel lblFactSinIva;
        private MaterialSkin.Controls.MaterialLabel lblNumFact;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFacturaSinIVA;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumeroFactura;
        private MaterialSkin.Controls.MaterialFlatButton btnprivKey;
        private MaterialSkin.Controls.MaterialFlatButton btnpubKey;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtprivKey;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtpubKey;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFactIVA;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuento;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContraLlavePrivada;
        private MaterialSkin.Controls.MaterialLabel lblContrasenia;
        private ErrorProvider errorContraLlavePriv;
        private PictureBox PicOJO;
    }
}
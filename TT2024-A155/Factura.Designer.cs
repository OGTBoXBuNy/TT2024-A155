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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNumeroFactura = new TextBox();
            txtFacturaSinIVA = new TextBox();
            txtDescuento = new TextBox();
            txtFactIVA = new TextBox();
            txtComentarios = new TextBox();
            btnAceptar = new Button();
            dtpFechEmision = new DateTimePicker();
            lblIDPedido = new Label();
            dgvDatosFactura = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            btnprivKey = new Button();
            btnpubKey = new Button();
            txtprivKey = new TextBox();
            txtpubKey = new TextBox();
            fileRoute = new SaveFileDialog();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatosFactura).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "GENERAR FACTURA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 1;
            label2.Text = "Numero de Factura: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 2;
            label3.Text = "Factura Sin IVA: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 3;
            label4.Text = "Factura Con IVA: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 134);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 4;
            label5.Text = "Descuento: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 198);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 5;
            label6.Text = "Fecha Emision: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 317);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 6;
            label7.Text = "Comentarios: ";
            // 
            // txtNumeroFactura
            // 
            txtNumeroFactura.Location = new Point(151, 59);
            txtNumeroFactura.Name = "txtNumeroFactura";
            txtNumeroFactura.Size = new Size(285, 27);
            txtNumeroFactura.TabIndex = 7;
            // 
            // txtFacturaSinIVA
            // 
            txtFacturaSinIVA.Enabled = false;
            txtFacturaSinIVA.Location = new Point(151, 94);
            txtFacturaSinIVA.Name = "txtFacturaSinIVA";
            txtFacturaSinIVA.Size = new Size(285, 27);
            txtFacturaSinIVA.TabIndex = 8;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(151, 127);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(285, 27);
            txtDescuento.TabIndex = 9;
            txtDescuento.KeyPress += txtDescuento_KeyPress;
            // 
            // txtFactIVA
            // 
            txtFactIVA.Enabled = false;
            txtFactIVA.Location = new Point(151, 164);
            txtFactIVA.Name = "txtFactIVA";
            txtFactIVA.Size = new Size(285, 27);
            txtFactIVA.TabIndex = 10;
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(151, 314);
            txtComentarios.Multiline = true;
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(285, 70);
            txtComentarios.TabIndex = 11;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(342, 399);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dtpFechEmision
            // 
            dtpFechEmision.Location = new Point(151, 197);
            dtpFechEmision.Name = "dtpFechEmision";
            dtpFechEmision.Size = new Size(250, 27);
            dtpFechEmision.TabIndex = 13;
            // 
            // lblIDPedido
            // 
            lblIDPedido.AutoSize = true;
            lblIDPedido.Location = new Point(359, 9);
            lblIDPedido.Name = "lblIDPedido";
            lblIDPedido.Size = new Size(77, 20);
            lblIDPedido.TabIndex = 14;
            lblIDPedido.Text = "IDPEDIDO";
            // 
            // dgvDatosFactura
            // 
            dgvDatosFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosFactura.Enabled = false;
            dgvDatosFactura.Location = new Point(452, 188);
            dgvDatosFactura.Name = "dgvDatosFactura";
            dgvDatosFactura.RowHeadersWidth = 51;
            dgvDatosFactura.RowTemplate.Height = 29;
            dgvDatosFactura.Size = new Size(300, 188);
            dgvDatosFactura.TabIndex = 15;
            dgvDatosFactura.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 266);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 21;
            label8.Text = "Ruta llave privada";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 233);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 20;
            label9.Text = "Ruta llave publica";
            // 
            // btnprivKey
            // 
            btnprivKey.Location = new Point(342, 261);
            btnprivKey.Name = "btnprivKey";
            btnprivKey.Size = new Size(94, 29);
            btnprivKey.TabIndex = 19;
            btnprivKey.Text = "...";
            btnprivKey.UseVisualStyleBackColor = true;
            btnprivKey.Click += btnprivKey_Click;
            // 
            // btnpubKey
            // 
            btnpubKey.Location = new Point(342, 229);
            btnpubKey.Name = "btnpubKey";
            btnpubKey.Size = new Size(94, 29);
            btnpubKey.TabIndex = 18;
            btnpubKey.Text = "...";
            btnpubKey.UseVisualStyleBackColor = true;
            btnpubKey.Click += btnpubKey_Click;
            // 
            // txtprivKey
            // 
            txtprivKey.Enabled = false;
            txtprivKey.Location = new Point(151, 263);
            txtprivKey.Name = "txtprivKey";
            txtprivKey.Size = new Size(185, 27);
            txtprivKey.TabIndex = 17;
            // 
            // txtpubKey
            // 
            txtpubKey.Enabled = false;
            txtpubKey.Location = new Point(151, 230);
            txtpubKey.Name = "txtpubKey";
            txtpubKey.Size = new Size(185, 27);
            txtpubKey.TabIndex = 16;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(359, 36);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 20);
            lblUsuario.TabIndex = 22;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 439);
            Controls.Add(lblUsuario);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(btnprivKey);
            Controls.Add(btnpubKey);
            Controls.Add(txtprivKey);
            Controls.Add(txtpubKey);
            Controls.Add(dgvDatosFactura);
            Controls.Add(lblIDPedido);
            Controls.Add(dtpFechEmision);
            Controls.Add(btnAceptar);
            Controls.Add(txtComentarios);
            Controls.Add(txtFactIVA);
            Controls.Add(txtDescuento);
            Controls.Add(txtFacturaSinIVA);
            Controls.Add(txtNumeroFactura);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Factura";
            Text = "Factura";
            Load += Factura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatosFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNumeroFactura;
        private TextBox txtFacturaSinIVA;
        private TextBox txtDescuento;
        private TextBox txtFactIVA;
        private TextBox txtComentarios;
        private Button btnAceptar;
        private DateTimePicker dtpFechEmision;
        public Label lblIDPedido;
        private DataGridView dgvDatosFactura;
        private Label label8;
        private Label label9;
        private Button btnprivKey;
        private Button btnpubKey;
        private TextBox txtprivKey;
        private TextBox txtpubKey;
        private SaveFileDialog fileRoute;
        public Label lblUsuario;
    }
}
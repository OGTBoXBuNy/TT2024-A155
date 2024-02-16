namespace TT2024_A155
{
    partial class Inicio
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
            btnCrearPedido = new Button();
            lblRol = new Label();
            menuStrip1 = new MenuStrip();
            otrasOpcionesToolStripMenuItem = new ToolStripMenuItem();
            cuentaToolStripMenuItem = new ToolStripMenuItem();
            crearUsuariosToolStripMenuItem = new ToolStripMenuItem();
            modificarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            generarReporteDeVentasToolStripMenuItem = new ToolStripMenuItem();
            panelInfoPedido = new Panel();
            lblComentariosFact = new Label();
            txtComenatriosFact = new TextBox();
            lblAnio = new Label();
            pbFactura = new PictureBox();
            lblComprobantePDF = new Label();
            txtComentarios = new TextBox();
            dgvDatosPDF = new DataGridView();
            lblFactIVA = new Label();
            lblFactSinIva = new Label();
            label4 = new Label();
            label3 = new Label();
            pbComprobante = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            lblPrecio = new Label();
            lblModelo = new Label();
            lblMarca = new Label();
            lblDescuento = new Label();
            lblAprobacion = new Label();
            lblComentarios = new Label();
            lblTotal = new Label();
            lblImpuesto = new Label();
            lblFechaCreacion = new Label();
            lblFactura = new Label();
            lblCliente = new Label();
            lblVendedor = new Label();
            lblCantidad = new Label();
            lblProducto = new Label();
            lblNoPedido = new Label();
            lblTituloInfoPedido = new Label();
            dgvPedido = new DataGridView();
            lblPedido = new Label();
            lblNomCliente = new Label();
            lblNombreUsuario = new Label();
            lblFecha = new Label();
            txtFiltroPedido = new TextBox();
            txtFiltroCliente = new TextBox();
            txtFiltroUsuario = new TextBox();
            dtpInicio = new DateTimePicker();
            lblFecha2 = new Label();
            dtpFin = new DateTimePicker();
            menuStrip1.SuspendLayout();
            panelInfoPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosPDF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbComprobante).BeginInit();
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
            // btnCrearPedido
            // 
            btnCrearPedido.Enabled = false;
            btnCrearPedido.Location = new Point(12, 60);
            btnCrearPedido.Name = "btnCrearPedido";
            btnCrearPedido.Size = new Size(112, 29);
            btnCrearPedido.TabIndex = 1;
            btnCrearPedido.Text = "Crear pedido";
            btnCrearPedido.UseVisualStyleBackColor = true;
            btnCrearPedido.Visible = false;
            btnCrearPedido.Click += btnCrearPedido_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(12, 37);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(36, 20);
            lblRol.TabIndex = 2;
            lblRol.Text = "ROL";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { otrasOpcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1447, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // otrasOpcionesToolStripMenuItem
            // 
            otrasOpcionesToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            otrasOpcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cuentaToolStripMenuItem, crearUsuariosToolStripMenuItem, modificarUsuariosToolStripMenuItem, generarReporteDeVentasToolStripMenuItem });
            otrasOpcionesToolStripMenuItem.Name = "otrasOpcionesToolStripMenuItem";
            otrasOpcionesToolStripMenuItem.Size = new Size(124, 24);
            otrasOpcionesToolStripMenuItem.Text = "Otras Opciones";
            // 
            // cuentaToolStripMenuItem
            // 
            cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            cuentaToolStripMenuItem.Size = new Size(264, 26);
            cuentaToolStripMenuItem.Text = "Administrar Cuenta";
            cuentaToolStripMenuItem.Click += cuentaToolStripMenuItem_Click;
            // 
            // crearUsuariosToolStripMenuItem
            // 
            crearUsuariosToolStripMenuItem.Enabled = false;
            crearUsuariosToolStripMenuItem.Name = "crearUsuariosToolStripMenuItem";
            crearUsuariosToolStripMenuItem.Size = new Size(264, 26);
            crearUsuariosToolStripMenuItem.Text = "Crear Usuarios";
            crearUsuariosToolStripMenuItem.Visible = false;
            crearUsuariosToolStripMenuItem.Click += crearUsuariosToolStripMenuItem_Click;
            // 
            // modificarUsuariosToolStripMenuItem
            // 
            modificarUsuariosToolStripMenuItem.Enabled = false;
            modificarUsuariosToolStripMenuItem.Name = "modificarUsuariosToolStripMenuItem";
            modificarUsuariosToolStripMenuItem.Size = new Size(264, 26);
            modificarUsuariosToolStripMenuItem.Text = "Modificar Usuarios";
            modificarUsuariosToolStripMenuItem.Visible = false;
            modificarUsuariosToolStripMenuItem.Click += modificarUsuariosToolStripMenuItem_Click;
            // 
            // generarReporteDeVentasToolStripMenuItem
            // 
            generarReporteDeVentasToolStripMenuItem.Enabled = false;
            generarReporteDeVentasToolStripMenuItem.Name = "generarReporteDeVentasToolStripMenuItem";
            generarReporteDeVentasToolStripMenuItem.Size = new Size(264, 26);
            generarReporteDeVentasToolStripMenuItem.Text = "Generar reporte de ventas";
            generarReporteDeVentasToolStripMenuItem.Visible = false;
            generarReporteDeVentasToolStripMenuItem.Click += generarReporteDeVentasToolStripMenuItem_Click;
            // 
            // panelInfoPedido
            // 
            panelInfoPedido.BorderStyle = BorderStyle.Fixed3D;
            panelInfoPedido.Controls.Add(lblComentariosFact);
            panelInfoPedido.Controls.Add(txtComenatriosFact);
            panelInfoPedido.Controls.Add(lblAnio);
            panelInfoPedido.Controls.Add(pbFactura);
            panelInfoPedido.Controls.Add(lblComprobantePDF);
            panelInfoPedido.Controls.Add(txtComentarios);
            panelInfoPedido.Controls.Add(dgvDatosPDF);
            panelInfoPedido.Controls.Add(lblFactIVA);
            panelInfoPedido.Controls.Add(lblFactSinIva);
            panelInfoPedido.Controls.Add(label4);
            panelInfoPedido.Controls.Add(label3);
            panelInfoPedido.Controls.Add(pbComprobante);
            panelInfoPedido.Controls.Add(label2);
            panelInfoPedido.Controls.Add(label1);
            panelInfoPedido.Controls.Add(lblPrecio);
            panelInfoPedido.Controls.Add(lblModelo);
            panelInfoPedido.Controls.Add(lblMarca);
            panelInfoPedido.Controls.Add(lblDescuento);
            panelInfoPedido.Controls.Add(lblAprobacion);
            panelInfoPedido.Controls.Add(lblComentarios);
            panelInfoPedido.Controls.Add(lblTotal);
            panelInfoPedido.Controls.Add(lblImpuesto);
            panelInfoPedido.Controls.Add(lblFechaCreacion);
            panelInfoPedido.Controls.Add(lblFactura);
            panelInfoPedido.Controls.Add(lblCliente);
            panelInfoPedido.Controls.Add(lblVendedor);
            panelInfoPedido.Controls.Add(lblCantidad);
            panelInfoPedido.Controls.Add(lblProducto);
            panelInfoPedido.Controls.Add(lblNoPedido);
            panelInfoPedido.Controls.Add(lblTituloInfoPedido);
            panelInfoPedido.Location = new Point(0, 140);
            panelInfoPedido.Margin = new Padding(4);
            panelInfoPedido.Name = "panelInfoPedido";
            panelInfoPedido.Size = new Size(425, 589);
            panelInfoPedido.TabIndex = 4;
            // 
            // lblComentariosFact
            // 
            lblComentariosFact.AutoSize = true;
            lblComentariosFact.Location = new Point(201, 379);
            lblComentariosFact.Name = "lblComentariosFact";
            lblComentariosFact.Size = new Size(100, 20);
            lblComentariosFact.TabIndex = 102;
            lblComentariosFact.Text = "Comentarios: ";
            // 
            // txtComenatriosFact
            // 
            txtComenatriosFact.Enabled = false;
            txtComenatriosFact.Location = new Point(201, 402);
            txtComenatriosFact.Multiline = true;
            txtComenatriosFact.Name = "txtComenatriosFact";
            txtComenatriosFact.ReadOnly = true;
            txtComenatriosFact.Size = new Size(213, 95);
            txtComenatriosFact.TabIndex = 101;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(336, 233);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(39, 20);
            lblAnio.TabIndex = 100;
            lblAnio.Text = "Año:";
            // 
            // pbFactura
            // 
            pbFactura.Cursor = Cursors.Hand;
            pbFactura.Image = Properties.Resources.file;
            pbFactura.Location = new Point(247, 534);
            pbFactura.Margin = new Padding(4);
            pbFactura.Name = "pbFactura";
            pbFactura.Size = new Size(55, 43);
            pbFactura.SizeMode = PictureBoxSizeMode.Zoom;
            pbFactura.TabIndex = 42;
            pbFactura.TabStop = false;
            pbFactura.Click += pbFactura_Click;
            // 
            // lblComprobantePDF
            // 
            lblComprobantePDF.AutoSize = true;
            lblComprobantePDF.Location = new Point(3, 510);
            lblComprobantePDF.Name = "lblComprobantePDF";
            lblComprobantePDF.Size = new Size(108, 20);
            lblComprobantePDF.TabIndex = 41;
            lblComprobantePDF.Text = "Comprobante: ";
            // 
            // txtComentarios
            // 
            txtComentarios.Enabled = false;
            txtComentarios.Location = new Point(101, 264);
            txtComentarios.Multiline = true;
            txtComentarios.Name = "txtComentarios";
            txtComentarios.ReadOnly = true;
            txtComentarios.Size = new Size(313, 74);
            txtComentarios.TabIndex = 99;
            // 
            // dgvDatosPDF
            // 
            dgvDatosPDF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosPDF.Location = new Point(370, 436);
            dgvDatosPDF.Name = "dgvDatosPDF";
            dgvDatosPDF.RowHeadersWidth = 51;
            dgvDatosPDF.RowTemplate.Height = 29;
            dgvDatosPDF.Size = new Size(44, 10);
            dgvDatosPDF.TabIndex = 39;
            dgvDatosPDF.Visible = false;
            // 
            // lblFactIVA
            // 
            lblFactIVA.AutoSize = true;
            lblFactIVA.Location = new Point(10, 468);
            lblFactIVA.Name = "lblFactIVA";
            lblFactIVA.Size = new Size(113, 20);
            lblFactIVA.TabIndex = 27;
            lblFactIVA.Text = "Factura con IVA:";
            // 
            // lblFactSinIva
            // 
            lblFactSinIva.AutoSize = true;
            lblFactSinIva.Location = new Point(10, 402);
            lblFactSinIva.Name = "lblFactSinIva";
            lblFactSinIva.Size = new Size(107, 20);
            lblFactSinIva.TabIndex = 26;
            lblFactSinIva.Text = "Factura sin IVA:";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(106, 109, 119);
            label4.Location = new Point(0, 500);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(427, 2);
            label4.TabIndex = 25;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(106, 109, 119);
            label3.Location = new Point(0, 358);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(427, 2);
            label3.TabIndex = 24;
            // 
            // pbComprobante
            // 
            pbComprobante.Cursor = Cursors.Hand;
            pbComprobante.Image = Properties.Resources.file;
            pbComprobante.Location = new Point(101, 534);
            pbComprobante.Margin = new Padding(4);
            pbComprobante.Name = "pbComprobante";
            pbComprobante.Size = new Size(55, 43);
            pbComprobante.SizeMode = PictureBoxSizeMode.Zoom;
            pbComprobante.TabIndex = 23;
            pbComprobante.TabStop = false;
            pbComprobante.Click += pbComprobante_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(106, 109, 119);
            label2.Location = new Point(0, 253);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(427, 2);
            label2.TabIndex = 22;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(106, 109, 119);
            label1.Location = new Point(-2, 130);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(427, 2);
            label1.TabIndex = 21;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(9, 192);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(94, 20);
            lblPrecio.TabIndex = 20;
            lblPrecio.Text = "Precio Venta:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(186, 233);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(64, 20);
            lblModelo.TabIndex = 19;
            lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(9, 233);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(53, 20);
            lblMarca.TabIndex = 18;
            lblMarca.Text = "Marca:";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(186, 192);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(82, 20);
            lblDescuento.TabIndex = 17;
            lblDescuento.Text = "Descuento:";
            // 
            // lblAprobacion
            // 
            lblAprobacion.AutoSize = true;
            lblAprobacion.Location = new Point(10, 338);
            lblAprobacion.Name = "lblAprobacion";
            lblAprobacion.Size = new Size(57, 20);
            lblAprobacion.TabIndex = 16;
            lblAprobacion.Text = "Estado:";
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.Location = new Point(3, 264);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(96, 20);
            lblComentarios.TabIndex = 15;
            lblComentarios.Text = "Comentarios:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(191, 510);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 20);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "Factura:";
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Location = new Point(10, 436);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(74, 20);
            lblImpuesto.TabIndex = 13;
            lblImpuesto.Text = "Impuesto:";
            // 
            // lblFechaCreacion
            // 
            lblFechaCreacion.AutoSize = true;
            lblFechaCreacion.Location = new Point(186, 24);
            lblFechaCreacion.Name = "lblFechaCreacion";
            lblFechaCreacion.Size = new Size(116, 20);
            lblFechaCreacion.TabIndex = 12;
            lblFechaCreacion.Text = "Fecha Creación: ";
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.Location = new Point(10, 369);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(72, 20);
            lblFactura.TabIndex = 11;
            lblFactura.Text = "# Factura:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(10, 65);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 10;
            lblCliente.Text = "Cliente:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(9, 110);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(76, 20);
            lblVendedor.TabIndex = 9;
            lblVendedor.Text = "Vendedor:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(317, 151);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(76, 20);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cantidad: ";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(9, 151);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(72, 20);
            lblProducto.TabIndex = 7;
            lblProducto.Text = "Producto:";
            // 
            // lblNoPedido
            // 
            lblNoPedido.AutoSize = true;
            lblNoPedido.Location = new Point(10, 24);
            lblNoPedido.Name = "lblNoPedido";
            lblNoPedido.Size = new Size(71, 20);
            lblNoPedido.TabIndex = 6;
            lblNoPedido.Text = "# Pedido:";
            // 
            // lblTituloInfoPedido
            // 
            lblTituloInfoPedido.BackColor = Color.FromArgb(70, 72, 79);
            lblTituloInfoPedido.BorderStyle = BorderStyle.FixedSingle;
            lblTituloInfoPedido.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloInfoPedido.ForeColor = Color.White;
            lblTituloInfoPedido.Location = new Point(0, 0);
            lblTituloInfoPedido.Margin = new Padding(4, 0, 4, 0);
            lblTituloInfoPedido.Name = "lblTituloInfoPedido";
            lblTituloInfoPedido.Size = new Size(429, 24);
            lblTituloInfoPedido.TabIndex = 5;
            lblTituloInfoPedido.Text = "DATOS DEL PEDIDO";
            lblTituloInfoPedido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvPedido
            // 
            dgvPedido.AllowUserToAddRows = false;
            dgvPedido.AllowUserToDeleteRows = false;
            dgvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPedido.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPedido.BackgroundColor = Color.FromArgb(40, 40, 40);
            dgvPedido.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPedido.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPedido.ColumnHeadersHeight = 22;
            dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPedido.GridColor = Color.FromArgb(42, 51, 65);
            dgvPedido.Location = new Point(424, 140);
            dgvPedido.Margin = new Padding(4);
            dgvPedido.Name = "dgvPedido";
            dgvPedido.RowHeadersWidth = 51;
            dgvPedido.RowTemplate.Height = 29;
            dgvPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedido.Size = new Size(1041, 591);
            dgvPedido.TabIndex = 100;
            dgvPedido.CellClick += dgvPedido_CellClick;
            // 
            // lblPedido
            // 
            lblPedido.AutoSize = true;
            lblPedido.Location = new Point(181, 69);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(71, 20);
            lblPedido.TabIndex = 6;
            lblPedido.Text = "# Pedido:";
            // 
            // lblNomCliente
            // 
            lblNomCliente.AutoSize = true;
            lblNomCliente.Location = new Point(437, 69);
            lblNomCliente.Name = "lblNomCliente";
            lblNomCliente.Size = new Size(117, 20);
            lblNomCliente.TabIndex = 7;
            lblNomCliente.Text = "Nombre Cliente:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(753, 69);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(121, 20);
            lblNombreUsuario.TabIndex = 8;
            lblNombreUsuario.Text = "Nombre Usuario:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(1081, 37);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(87, 20);
            lblFecha.TabIndex = 9;
            lblFecha.Text = "De la fecha:";
            // 
            // txtFiltroPedido
            // 
            txtFiltroPedido.Location = new Point(258, 62);
            txtFiltroPedido.Name = "txtFiltroPedido";
            txtFiltroPedido.Size = new Size(158, 27);
            txtFiltroPedido.TabIndex = 2;
            txtFiltroPedido.KeyUp += txtFiltroPedido_KeyUp;
            // 
            // txtFiltroCliente
            // 
            txtFiltroCliente.Location = new Point(560, 62);
            txtFiltroCliente.Name = "txtFiltroCliente";
            txtFiltroCliente.Size = new Size(158, 27);
            txtFiltroCliente.TabIndex = 3;
            txtFiltroCliente.KeyUp += txtFiltroCliente_KeyUp;
            // 
            // txtFiltroUsuario
            // 
            txtFiltroUsuario.Location = new Point(880, 62);
            txtFiltroUsuario.Name = "txtFiltroUsuario";
            txtFiltroUsuario.Size = new Size(158, 27);
            txtFiltroUsuario.TabIndex = 4;
            txtFiltroUsuario.KeyUp += txtFiltroUsuario_KeyUp;
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(1081, 64);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(112, 27);
            dtpInicio.TabIndex = 5;
            dtpInicio.ValueChanged += dtpInicio_ValueChanged;
            // 
            // lblFecha2
            // 
            lblFecha2.AutoSize = true;
            lblFecha2.Location = new Point(1211, 71);
            lblFecha2.Name = "lblFecha2";
            lblFecha2.Size = new Size(24, 20);
            lblFecha2.TabIndex = 14;
            lblFecha2.Text = "a :";
            // 
            // dtpFin
            // 
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(1255, 64);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(112, 27);
            dtpFin.TabIndex = 6;
            dtpFin.ValueChanged += dtpFin_ValueChanged;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 732);
            Controls.Add(dtpFin);
            Controls.Add(lblFecha2);
            Controls.Add(dtpInicio);
            Controls.Add(txtFiltroUsuario);
            Controls.Add(txtFiltroCliente);
            Controls.Add(txtFiltroPedido);
            Controls.Add(lblFecha);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblNomCliente);
            Controls.Add(lblPedido);
            Controls.Add(dgvPedido);
            Controls.Add(panelInfoPedido);
            Controls.Add(lblRol);
            Controls.Add(btnCrearPedido);
            Controls.Add(lblUsuario);
            Controls.Add(menuStrip1);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            FormClosed += Inicio_FormClosed;
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelInfoPedido.ResumeLayout(false);
            panelInfoPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosPDF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbComprobante).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblUsuario;
        private Button btnCrearPedido;
        public Label lblRol;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem otrasOpcionesToolStripMenuItem;
        private ToolStripMenuItem cuentaToolStripMenuItem;
        private ToolStripMenuItem crearUsuariosToolStripMenuItem;
        private ToolStripMenuItem modificarUsuariosToolStripMenuItem;
        private ToolStripMenuItem generarReporteDeVentasToolStripMenuItem;
        private Panel panelInfoPedido;
        private Label lblTituloInfoPedido;
        private DataGridView dgvPedido;
        private Label lblNoPedido;
        private Label lblFechaCreacion;
        private Label lblFactura;
        private Label lblCliente;
        private Label lblVendedor;
        private Label lblCantidad;
        private Label lblProducto;
        private Label lblAprobacion;
        private Label lblTotal;
        private Label lblImpuesto;
        private Label lblModelo;
        private Label lblMarca;
        private Label lblDescuento;
        private Label lblPrecio;
        private Label label2;
        private Label label1;
        private PictureBox pbComprobante;
        private Label label4;
        private Label label3;
        private Label lblFactSinIva;
        private Label lblFactIVA;
        private DataGridView dgvDatosPDF;
        private TextBox txtComentarios;
        private Label lblComentarios;
        private Label lblPedido;
        private Label lblNomCliente;
        private Label lblNombreUsuario;
        private Label lblFecha;
        private TextBox txtFiltroPedido;
        private TextBox txtFiltroCliente;
        private TextBox txtFiltroUsuario;
        private DateTimePicker dtpInicio;
        private Label lblFecha2;
        private DateTimePicker dtpFin;
        private PictureBox pbFactura;
        private Label lblComprobantePDF;
        private Label lblAnio;
        private Label lblComentariosFact;
        private TextBox txtComenatriosFact;
    }
}
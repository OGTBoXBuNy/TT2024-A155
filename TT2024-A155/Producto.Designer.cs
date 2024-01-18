namespace TT2024_A155
{
    partial class Producto
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
            lblPieza = new Label();
            lblCantidad = new Label();
            lblPrecio = new Label();
            lblDescuento = new Label();
            txtPrecioVenta = new TextBox();
            txtDescuento = new TextBox();
            cmbProducto = new ComboBox();
            btnAceptar = new Button();
            lblDisponible = new Label();
            cmbCantidad = new ComboBox();
            cmbModelo = new ComboBox();
            label2 = new Label();
            cmbMarca = new ComboBox();
            label1 = new Label();
            lblAnio = new Label();
            txtAnio = new TextBox();
            SuspendLayout();
            // 
            // lblPieza
            // 
            lblPieza.AutoSize = true;
            lblPieza.Location = new Point(17, 176);
            lblPieza.Name = "lblPieza";
            lblPieza.Size = new Size(112, 20);
            lblPieza.TabIndex = 0;
            lblPieza.Text = "Elije una pieza: ";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(57, 212);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(35, 245);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(94, 20);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio Venta:";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(47, 287);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(82, 20);
            lblDescuento.TabIndex = 3;
            lblDescuento.Text = "Descuento:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Enabled = false;
            txtPrecioVenta.Location = new Point(145, 238);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(151, 27);
            txtPrecioVenta.TabIndex = 5;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(145, 280);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(151, 27);
            txtDescuento.TabIndex = 6;
            txtDescuento.Text = "0";
            // 
            // cmbProducto
            // 
            cmbProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(145, 171);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(273, 28);
            cmbProducto.TabIndex = 7;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            cmbProducto.KeyPress += cmbProducto_KeyPress;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(161, 328);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(126, 29);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Añadir Producto";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblDisponible
            // 
            lblDisponible.AutoSize = true;
            lblDisponible.Location = new Point(302, 212);
            lblDisponible.Name = "lblDisponible";
            lblDisponible.Size = new Size(96, 20);
            lblDisponible.TabIndex = 9;
            lblDisponible.Text = "Disponible: 0";
            // 
            // cmbCantidad
            // 
            cmbCantidad.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCantidad.FormattingEnabled = true;
            cmbCantidad.Location = new Point(145, 205);
            cmbCantidad.Name = "cmbCantidad";
            cmbCantidad.Size = new Size(151, 28);
            cmbCantidad.TabIndex = 10;
            // 
            // cmbModelo
            // 
            cmbModelo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbModelo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbModelo.FormattingEnabled = true;
            cmbModelo.Location = new Point(93, 100);
            cmbModelo.Name = "cmbModelo";
            cmbModelo.Size = new Size(299, 28);
            cmbModelo.TabIndex = 38;
            cmbModelo.SelectedIndexChanged += cmbModelo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 108);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 37;
            label2.Text = "Modelo:";
            // 
            // cmbMarca
            // 
            cmbMarca.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(93, 58);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(299, 28);
            cmbMarca.TabIndex = 36;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 66);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 35;
            label1.Text = "Marca:";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(19, 144);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(39, 20);
            lblAnio.TabIndex = 39;
            lblAnio.Text = "Año:";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(93, 138);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(85, 27);
            txtAnio.TabIndex = 40;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 440);
            Controls.Add(txtAnio);
            Controls.Add(lblAnio);
            Controls.Add(cmbModelo);
            Controls.Add(label2);
            Controls.Add(cmbMarca);
            Controls.Add(label1);
            Controls.Add(cmbCantidad);
            Controls.Add(lblDisponible);
            Controls.Add(btnAceptar);
            Controls.Add(cmbProducto);
            Controls.Add(txtDescuento);
            Controls.Add(txtPrecioVenta);
            Controls.Add(lblDescuento);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(lblPieza);
            Name = "Producto";
            Text = "Producto";
            Load += Producto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPieza;
        private Label lblCantidad;
        private Label lblPrecio;
        private Label lblDescuento;
        private TextBox txtPrecioVenta;
        private TextBox txtDescuento;
        private ComboBox cmbProducto;
        private Button btnAceptar;
        private Label lblDisponible;
        private ComboBox cmbCantidad;
        private ComboBox cmbModelo;
        private Label label2;
        private ComboBox cmbMarca;
        private Label label1;
        private Label lblAnio;
        private TextBox txtAnio;
    }
}
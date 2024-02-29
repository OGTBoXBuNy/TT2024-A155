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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            txtPrecioVenta = new TextBox();
            txtDescuento = new TextBox();
            cmbProducto = new ComboBox();
            cmbCantidad = new ComboBox();
            cmbModelo = new ComboBox();
            cmbMarca = new ComboBox();
            cmbAnio = new ComboBox();
            lblMarca = new MaterialSkin.Controls.MaterialLabel();
            lblModelo = new MaterialSkin.Controls.MaterialLabel();
            lblAnio = new MaterialSkin.Controls.MaterialLabel();
            lblPieza = new MaterialSkin.Controls.MaterialLabel();
            lblCantidad = new MaterialSkin.Controls.MaterialLabel();
            lblDisponible = new MaterialSkin.Controls.MaterialLabel();
            lblPrecio = new MaterialSkin.Controls.MaterialLabel();
            lblDescuento = new MaterialSkin.Controls.MaterialLabel();
            btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            SuspendLayout();
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Enabled = false;
            txtPrecioVenta.Location = new Point(172, 300);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(151, 27);
            txtPrecioVenta.TabIndex = 5;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(172, 340);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(151, 27);
            txtDescuento.TabIndex = 6;
            txtDescuento.Text = "0";
            txtDescuento.KeyPress += txtDescuento_KeyPress;
            // 
            // cmbProducto
            // 
            cmbProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(172, 220);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(273, 28);
            cmbProducto.TabIndex = 7;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            cmbProducto.KeyPress += cmbProducto_KeyPress;
            // 
            // cmbCantidad
            // 
            cmbCantidad.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCantidad.FormattingEnabled = true;
            cmbCantidad.Location = new Point(172, 260);
            cmbCantidad.Name = "cmbCantidad";
            cmbCantidad.Size = new Size(151, 28);
            cmbCantidad.TabIndex = 10;
            // 
            // cmbModelo
            // 
            cmbModelo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbModelo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbModelo.FormattingEnabled = true;
            cmbModelo.Location = new Point(107, 130);
            cmbModelo.Name = "cmbModelo";
            cmbModelo.Size = new Size(299, 28);
            cmbModelo.TabIndex = 38;
            cmbModelo.SelectedIndexChanged += cmbModelo_SelectedIndexChanged;
            // 
            // cmbMarca
            // 
            cmbMarca.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(107, 90);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(299, 28);
            cmbMarca.TabIndex = 36;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // cmbAnio
            // 
            cmbAnio.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbAnio.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbAnio.FormattingEnabled = true;
            cmbAnio.Location = new Point(107, 170);
            cmbAnio.Name = "cmbAnio";
            cmbAnio.Size = new Size(105, 28);
            cmbAnio.TabIndex = 41;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Depth = 0;
            lblMarca.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblMarca.Location = new Point(12, 90);
            lblMarca.MouseState = MaterialSkin.MouseState.HOVER;
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(68, 24);
            lblMarca.TabIndex = 42;
            lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Depth = 0;
            lblModelo.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblModelo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblModelo.Location = new Point(12, 130);
            lblModelo.MouseState = MaterialSkin.MouseState.HOVER;
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(80, 24);
            lblModelo.TabIndex = 43;
            lblModelo.Text = "Modelo:";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Depth = 0;
            lblAnio.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnio.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblAnio.Location = new Point(12, 170);
            lblAnio.MouseState = MaterialSkin.MouseState.HOVER;
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(48, 24);
            lblAnio.TabIndex = 44;
            lblAnio.Text = "Año:";
            // 
            // lblPieza
            // 
            lblPieza.AutoSize = true;
            lblPieza.Depth = 0;
            lblPieza.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPieza.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblPieza.Location = new Point(12, 220);
            lblPieza.MouseState = MaterialSkin.MouseState.HOVER;
            lblPieza.Name = "lblPieza";
            lblPieza.Size = new Size(141, 24);
            lblPieza.TabIndex = 45;
            lblPieza.Text = "Elije una pieza: ";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Depth = 0;
            lblCantidad.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCantidad.Location = new Point(63, 260);
            lblCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(90, 24);
            lblCantidad.TabIndex = 46;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblDisponible
            // 
            lblDisponible.AutoSize = true;
            lblDisponible.Depth = 0;
            lblDisponible.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisponible.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDisponible.Location = new Point(329, 260);
            lblDisponible.MouseState = MaterialSkin.MouseState.HOVER;
            lblDisponible.Name = "lblDisponible";
            lblDisponible.Size = new Size(121, 24);
            lblDisponible.TabIndex = 47;
            lblDisponible.Text = "Disponible: 0";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Depth = 0;
            lblPrecio.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblPrecio.Location = new Point(33, 300);
            lblPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(122, 24);
            lblPrecio.TabIndex = 48;
            lblPrecio.Text = "Precio Venta:";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Depth = 0;
            lblDescuento.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescuento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDescuento.Location = new Point(49, 340);
            lblDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(104, 24);
            lblDescuento.TabIndex = 49;
            lblDescuento.Text = "Descuento:";
            // 
            // btnAceptar
            // 
            btnAceptar.AutoSize = true;
            btnAceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAceptar.Depth = 0;
            btnAceptar.Icon = null;
            btnAceptar.Location = new Point(145, 392);
            btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Primary = true;
            btnAceptar.Size = new Size(178, 36);
            btnAceptar.TabIndex = 50;
            btnAceptar.Text = "Añadir Producto";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 440);
            Controls.Add(btnAceptar);
            Controls.Add(lblDescuento);
            Controls.Add(lblPrecio);
            Controls.Add(lblDisponible);
            Controls.Add(lblCantidad);
            Controls.Add(lblPieza);
            Controls.Add(lblAnio);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(cmbAnio);
            Controls.Add(cmbModelo);
            Controls.Add(cmbMarca);
            Controls.Add(cmbCantidad);
            Controls.Add(cmbProducto);
            Controls.Add(txtDescuento);
            Controls.Add(txtPrecioVenta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Producto";
            Text = "Seleccionar Producto";
            Load += Producto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPrecioVenta;
        private TextBox txtDescuento;
        private ComboBox cmbProducto;
        private ComboBox cmbCantidad;
        private ComboBox cmbModelo;
        private ComboBox cmbMarca;
        private ComboBox cmbAnio;
        private MaterialSkin.Controls.MaterialLabel lblMarca;
        private MaterialSkin.Controls.MaterialLabel lblModelo;
        private MaterialSkin.Controls.MaterialLabel lblAnio;
        private MaterialSkin.Controls.MaterialLabel lblPieza;
        private MaterialSkin.Controls.MaterialLabel lblCantidad;
        private MaterialSkin.Controls.MaterialLabel lblDisponible;
        private MaterialSkin.Controls.MaterialLabel lblPrecio;
        private MaterialSkin.Controls.MaterialLabel lblDescuento;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
    }
}
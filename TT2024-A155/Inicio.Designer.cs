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
            lblTituloInfoPedido = new Label();
            dgvPedido = new DataGridView();
            menuStrip1.SuspendLayout();
            panelInfoPedido.SuspendLayout();
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
            // 
            // crearUsuariosToolStripMenuItem
            // 
            crearUsuariosToolStripMenuItem.Enabled = false;
            crearUsuariosToolStripMenuItem.Name = "crearUsuariosToolStripMenuItem";
            crearUsuariosToolStripMenuItem.Size = new Size(264, 26);
            crearUsuariosToolStripMenuItem.Text = "Crear Usuarios";
            crearUsuariosToolStripMenuItem.Visible = false;
            // 
            // modificarUsuariosToolStripMenuItem
            // 
            modificarUsuariosToolStripMenuItem.Enabled = false;
            modificarUsuariosToolStripMenuItem.Name = "modificarUsuariosToolStripMenuItem";
            modificarUsuariosToolStripMenuItem.Size = new Size(264, 26);
            modificarUsuariosToolStripMenuItem.Text = "Modificar Usuarios";
            modificarUsuariosToolStripMenuItem.Visible = false;
            // 
            // generarReporteDeVentasToolStripMenuItem
            // 
            generarReporteDeVentasToolStripMenuItem.Enabled = false;
            generarReporteDeVentasToolStripMenuItem.Name = "generarReporteDeVentasToolStripMenuItem";
            generarReporteDeVentasToolStripMenuItem.Size = new Size(264, 26);
            generarReporteDeVentasToolStripMenuItem.Text = "Generar reporte de ventas";
            generarReporteDeVentasToolStripMenuItem.Visible = false;
            // 
            // panelInfoPedido
            // 
            panelInfoPedido.BorderStyle = BorderStyle.Fixed3D;
            panelInfoPedido.Controls.Add(lblTituloInfoPedido);
            panelInfoPedido.Location = new Point(0, 140);
            panelInfoPedido.Margin = new Padding(4);
            panelInfoPedido.Name = "panelInfoPedido";
            panelInfoPedido.Size = new Size(425, 589);
            panelInfoPedido.TabIndex = 4;
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
            dgvPedido.TabIndex = 5;
            dgvPedido.CellClick += dgvPedido_CellClick;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 732);
            Controls.Add(dgvPedido);
            Controls.Add(panelInfoPedido);
            Controls.Add(lblRol);
            Controls.Add(btnCrearPedido);
            Controls.Add(lblUsuario);
            Controls.Add(menuStrip1);
            Name = "Inicio";
            Text = "Inicio";
            FormClosed += Inicio_FormClosed;
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelInfoPedido.ResumeLayout(false);
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
    }
}
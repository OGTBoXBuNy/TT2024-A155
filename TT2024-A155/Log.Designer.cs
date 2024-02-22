namespace TT2024_A155
{
    partial class Log
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
            dgvLog = new DataGridView();
            Fecha_Fin = new DateTimePicker();
            lblFecha2 = new Label();
            Fecha_in = new DateTimePicker();
            txtFiltroNomReal = new TextBox();
            txtFiltroNomUsuario = new TextBox();
            txtFiltroPedido = new TextBox();
            lblFecha = new Label();
            lblNombreUsuario = new Label();
            lblNomUsuario = new Label();
            lblPedido = new Label();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvLog).BeginInit();
            SuspendLayout();
            // 
            // dgvLog
            // 
            dgvLog.AllowUserToAddRows = false;
            dgvLog.AllowUserToDeleteRows = false;
            dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLog.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLog.BackgroundColor = Color.FromArgb(40, 40, 40);
            dgvLog.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvLog.ColumnHeadersHeight = 22;
            dgvLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLog.GridColor = Color.FromArgb(42, 51, 65);
            dgvLog.Location = new Point(0, 95);
            dgvLog.Margin = new Padding(4);
            dgvLog.Name = "dgvLog";
            dgvLog.RowHeadersWidth = 51;
            dgvLog.RowTemplate.Height = 29;
            dgvLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLog.Size = new Size(1552, 537);
            dgvLog.TabIndex = 101;
            // 
            // Fecha_Fin
            // 
            Fecha_Fin.Format = DateTimePickerFormat.Short;
            Fecha_Fin.Location = new Point(1377, 38);
            Fecha_Fin.Name = "Fecha_Fin";
            Fecha_Fin.Size = new Size(112, 27);
            Fecha_Fin.TabIndex = 106;
            Fecha_Fin.ValueChanged += Fecha_Fin_ValueChanged;
            // 
            // lblFecha2
            // 
            lblFecha2.AutoSize = true;
            lblFecha2.Location = new Point(1333, 45);
            lblFecha2.Name = "lblFecha2";
            lblFecha2.Size = new Size(24, 20);
            lblFecha2.TabIndex = 111;
            lblFecha2.Text = "a :";
            // 
            // Fecha_in
            // 
            Fecha_in.Format = DateTimePickerFormat.Short;
            Fecha_in.Location = new Point(1203, 38);
            Fecha_in.Name = "Fecha_in";
            Fecha_in.Size = new Size(112, 27);
            Fecha_in.TabIndex = 105;
            Fecha_in.ValueChanged += Fecha_in_ValueChanged;
            // 
            // txtFiltroNomReal
            // 
            txtFiltroNomReal.Location = new Point(700, 36);
            txtFiltroNomReal.Name = "txtFiltroNomReal";
            txtFiltroNomReal.Size = new Size(158, 27);
            txtFiltroNomReal.TabIndex = 104;
            txtFiltroNomReal.KeyUp += txtFiltroNomReal_KeyUp;
            // 
            // txtFiltroNomUsuario
            // 
            txtFiltroNomUsuario.Location = new Point(407, 36);
            txtFiltroNomUsuario.Name = "txtFiltroNomUsuario";
            txtFiltroNomUsuario.Size = new Size(158, 27);
            txtFiltroNomUsuario.TabIndex = 103;
            txtFiltroNomUsuario.KeyUp += txtFiltroNomUsuario_KeyUp;
            // 
            // txtFiltroPedido
            // 
            txtFiltroPedido.Location = new Point(105, 36);
            txtFiltroPedido.Name = "txtFiltroPedido";
            txtFiltroPedido.Size = new Size(158, 27);
            txtFiltroPedido.TabIndex = 102;
            txtFiltroPedido.KeyUp += txtFiltroPedido_KeyUp;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(1203, 11);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(87, 20);
            lblFecha.TabIndex = 110;
            lblFecha.Text = "De la fecha:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(580, 43);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(100, 20);
            lblNombreUsuario.TabIndex = 109;
            lblNombreUsuario.Text = "Nombre Real:";
            // 
            // lblNomUsuario
            // 
            lblNomUsuario.AutoSize = true;
            lblNomUsuario.Location = new Point(277, 43);
            lblNomUsuario.Name = "lblNomUsuario";
            lblNomUsuario.Size = new Size(121, 20);
            lblNomUsuario.TabIndex = 108;
            lblNomUsuario.Text = "Nombre Usuario:";
            // 
            // lblPedido
            // 
            lblPedido.AutoSize = true;
            lblPedido.Location = new Point(28, 43);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(71, 20);
            lblPedido.TabIndex = 107;
            lblPedido.Text = "# Pedido:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(889, 43);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(42, 20);
            lblTipo.TabIndex = 112;
            lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(940, 35);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(243, 28);
            cmbTipo.TabIndex = 113;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // Log
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 630);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Controls.Add(Fecha_Fin);
            Controls.Add(lblFecha2);
            Controls.Add(Fecha_in);
            Controls.Add(txtFiltroNomReal);
            Controls.Add(txtFiltroNomUsuario);
            Controls.Add(txtFiltroPedido);
            Controls.Add(lblFecha);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblNomUsuario);
            Controls.Add(lblPedido);
            Controls.Add(dgvLog);
            Name = "Log";
            Text = "Log";
            Load += Log_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLog;
        private DateTimePicker Fecha_Fin;
        private Label lblFecha2;
        private DateTimePicker Fecha_in;
        private TextBox txtFiltroNomReal;
        private TextBox txtFiltroNomUsuario;
        private TextBox txtFiltroPedido;
        private Label lblFecha;
        private Label lblNombreUsuario;
        private Label lblNomUsuario;
        private Label lblPedido;
        private Label lblTipo;
        private ComboBox cmbTipo;
    }
}
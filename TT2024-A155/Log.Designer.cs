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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            dgvLog = new DataGridView();
            Fecha_Fin = new DateTimePicker();
            Fecha_in = new DateTimePicker();
            cmbTipo = new ComboBox();
            lblPedido = new MaterialSkin.Controls.MaterialLabel();
            lblNomUsuario = new MaterialSkin.Controls.MaterialLabel();
            lblTipo = new MaterialSkin.Controls.MaterialLabel();
            lblNombreUsuario = new MaterialSkin.Controls.MaterialLabel();
            lblFecha2 = new MaterialSkin.Controls.MaterialLabel();
            lblFecha = new MaterialSkin.Controls.MaterialLabel();
            txtFiltroPedido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtFiltroNomUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtFiltroNomReal = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            dgvLog.Location = new Point(1, 216);
            dgvLog.Margin = new Padding(4);
            dgvLog.Name = "dgvLog";
            dgvLog.RowHeadersWidth = 51;
            dgvLog.RowTemplate.Height = 29;
            dgvLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLog.Size = new Size(1259, 537);
            dgvLog.TabIndex = 101;
            // 
            // Fecha_Fin
            // 
            Fecha_Fin.Format = DateTimePickerFormat.Short;
            Fecha_Fin.Location = new Point(699, 140);
            Fecha_Fin.Name = "Fecha_Fin";
            Fecha_Fin.Size = new Size(112, 27);
            Fecha_Fin.TabIndex = 106;
            Fecha_Fin.ValueChanged += Fecha_Fin_ValueChanged;
            // 
            // Fecha_in
            // 
            Fecha_in.Format = DateTimePickerFormat.Short;
            Fecha_in.Location = new Point(514, 140);
            Fecha_in.Name = "Fecha_in";
            Fecha_in.Size = new Size(112, 27);
            Fecha_in.TabIndex = 105;
            Fecha_in.ValueChanged += Fecha_in_ValueChanged;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(110, 140);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(243, 28);
            cmbTipo.TabIndex = 113;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblPedido
            // 
            lblPedido.AutoSize = true;
            lblPedido.Depth = 0;
            lblPedido.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPedido.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblPedido.Location = new Point(12, 100);
            lblPedido.MouseState = MaterialSkin.MouseState.HOVER;
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(92, 24);
            lblPedido.TabIndex = 114;
            lblPedido.Text = "# Pedido:";
            // 
            // lblNomUsuario
            // 
            lblNomUsuario.AutoSize = true;
            lblNomUsuario.Depth = 0;
            lblNomUsuario.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNomUsuario.Location = new Point(387, 100);
            lblNomUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            lblNomUsuario.Name = "lblNomUsuario";
            lblNomUsuario.Size = new Size(153, 24);
            lblNomUsuario.TabIndex = 115;
            lblNomUsuario.Text = "Nombre Usuario:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Depth = 0;
            lblTipo.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTipo.Location = new Point(51, 140);
            lblTipo.MouseState = MaterialSkin.MouseState.HOVER;
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(53, 24);
            lblTipo.TabIndex = 117;
            lblTipo.Text = "Tipo:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Depth = 0;
            lblNombreUsuario.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNombreUsuario.Location = new Point(851, 100);
            lblNombreUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(126, 24);
            lblNombreUsuario.TabIndex = 116;
            lblNombreUsuario.Text = "Nombre Real:";
            // 
            // lblFecha2
            // 
            lblFecha2.AutoSize = true;
            lblFecha2.Depth = 0;
            lblFecha2.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblFecha2.Location = new Point(646, 140);
            lblFecha2.MouseState = MaterialSkin.MouseState.HOVER;
            lblFecha2.Name = "lblFecha2";
            lblFecha2.Size = new Size(30, 24);
            lblFecha2.TabIndex = 119;
            lblFecha2.Text = "a :";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Depth = 0;
            lblFecha.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblFecha.Location = new Point(387, 140);
            lblFecha.MouseState = MaterialSkin.MouseState.HOVER;
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(109, 24);
            lblFecha.TabIndex = 118;
            lblFecha.Text = "De la fecha:";
            // 
            // txtFiltroPedido
            // 
            txtFiltroPedido.Depth = 0;
            txtFiltroPedido.Hint = "";
            txtFiltroPedido.Location = new Point(110, 100);
            txtFiltroPedido.MaxLength = 32767;
            txtFiltroPedido.MouseState = MaterialSkin.MouseState.HOVER;
            txtFiltroPedido.Name = "txtFiltroPedido";
            txtFiltroPedido.PasswordChar = '\0';
            txtFiltroPedido.SelectedText = "";
            txtFiltroPedido.SelectionLength = 0;
            txtFiltroPedido.SelectionStart = 0;
            txtFiltroPedido.Size = new Size(243, 28);
            txtFiltroPedido.TabIndex = 120;
            txtFiltroPedido.TabStop = false;
            txtFiltroPedido.UseSystemPasswordChar = false;
            txtFiltroPedido.KeyUp += txtFiltroPedido_KeyUp;
            // 
            // txtFiltroNomUsuario
            // 
            txtFiltroNomUsuario.Depth = 0;
            txtFiltroNomUsuario.Hint = "";
            txtFiltroNomUsuario.Location = new Point(546, 100);
            txtFiltroNomUsuario.MaxLength = 32767;
            txtFiltroNomUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            txtFiltroNomUsuario.Name = "txtFiltroNomUsuario";
            txtFiltroNomUsuario.PasswordChar = '\0';
            txtFiltroNomUsuario.SelectedText = "";
            txtFiltroNomUsuario.SelectionLength = 0;
            txtFiltroNomUsuario.SelectionStart = 0;
            txtFiltroNomUsuario.Size = new Size(243, 28);
            txtFiltroNomUsuario.TabIndex = 121;
            txtFiltroNomUsuario.TabStop = false;
            txtFiltroNomUsuario.UseSystemPasswordChar = false;
            txtFiltroNomUsuario.KeyUp += txtFiltroNomUsuario_KeyUp;
            // 
            // txtFiltroNomReal
            // 
            txtFiltroNomReal.Depth = 0;
            txtFiltroNomReal.Hint = "";
            txtFiltroNomReal.Location = new Point(983, 100);
            txtFiltroNomReal.MaxLength = 32767;
            txtFiltroNomReal.MouseState = MaterialSkin.MouseState.HOVER;
            txtFiltroNomReal.Name = "txtFiltroNomReal";
            txtFiltroNomReal.PasswordChar = '\0';
            txtFiltroNomReal.SelectedText = "";
            txtFiltroNomReal.SelectionLength = 0;
            txtFiltroNomReal.SelectionStart = 0;
            txtFiltroNomReal.Size = new Size(243, 28);
            txtFiltroNomReal.TabIndex = 122;
            txtFiltroNomReal.TabStop = false;
            txtFiltroNomReal.UseSystemPasswordChar = false;
            txtFiltroNomReal.KeyUp += txtFiltroNomReal_KeyUp;
            // 
            // Log
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 756);
            Controls.Add(txtFiltroNomReal);
            Controls.Add(txtFiltroNomUsuario);
            Controls.Add(txtFiltroPedido);
            Controls.Add(lblFecha2);
            Controls.Add(lblFecha);
            Controls.Add(lblTipo);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblNomUsuario);
            Controls.Add(lblPedido);
            Controls.Add(cmbTipo);
            Controls.Add(Fecha_Fin);
            Controls.Add(Fecha_in);
            Controls.Add(dgvLog);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Log";
            Text = "Control de Cambios (LOG)";
            Load += Log_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLog;
        private DateTimePicker Fecha_Fin;
        private DateTimePicker Fecha_in;
        private ComboBox cmbTipo;
        private MaterialSkin.Controls.MaterialLabel lblPedido;
        private MaterialSkin.Controls.MaterialLabel lblNomUsuario;
        private MaterialSkin.Controls.MaterialLabel lblTipo;
        private MaterialSkin.Controls.MaterialLabel lblNombreUsuario;
        private MaterialSkin.Controls.MaterialLabel lblFecha2;
        private MaterialSkin.Controls.MaterialLabel lblFecha;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFiltroPedido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFiltroNomUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFiltroNomReal;
    }
}
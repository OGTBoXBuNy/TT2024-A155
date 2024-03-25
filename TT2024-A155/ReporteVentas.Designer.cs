namespace TT2024_A155
{
    partial class ReporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentas));
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFinal = new DateTimePicker();
            lblUsuario = new Label();
            lblDesde = new MaterialSkin.Controls.MaterialLabel();
            lblHasta = new MaterialSkin.Controls.MaterialLabel();
            btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(104, 90);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(250, 27);
            dtpFechaInicio.TabIndex = 4;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Location = new Point(104, 130);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(250, 27);
            dtpFechaFinal.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(340, 38);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 20);
            lblUsuario.TabIndex = 6;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Depth = 0;
            lblDesde.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesde.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDesde.Location = new Point(12, 90);
            lblDesde.MouseState = MaterialSkin.MouseState.HOVER;
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(72, 24);
            lblDesde.TabIndex = 7;
            lblDesde.Text = "DESDE:";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Depth = 0;
            lblHasta.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblHasta.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblHasta.Location = new Point(12, 130);
            lblHasta.MouseState = MaterialSkin.MouseState.HOVER;
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(75, 24);
            lblHasta.TabIndex = 8;
            lblHasta.Text = "HASTA:";
            // 
            // btnAceptar
            // 
            btnAceptar.AutoSize = true;
            btnAceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAceptar.Depth = 0;
            btnAceptar.Icon = null;
            btnAceptar.Location = new Point(164, 170);
            btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Primary = true;
            btnAceptar.Size = new Size(98, 36);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Generar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // ReporteVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(429, 219);
            Controls.Add(btnAceptar);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Controls.Add(lblUsuario);
            Controls.Add(dtpFechaFinal);
            Controls.Add(dtpFechaInicio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ReporteVentas";
            Text = "REPORTE DE VENTAS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFinal;
        public Label lblUsuario;
        private MaterialSkin.Controls.MaterialLabel lblDesde;
        private MaterialSkin.Controls.MaterialLabel lblHasta;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
    }
}
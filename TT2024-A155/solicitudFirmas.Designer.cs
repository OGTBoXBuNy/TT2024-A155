namespace TT2024_A155
{
    partial class solicitudFirmas
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
            txtInfo = new TextBox();
            pbAdvertencia = new PictureBox();
            btnGenerar = new MaterialSkin.Controls.MaterialRaisedButton();
            lblRol = new Label();
            ((System.ComponentModel.ISupportInitialize)pbAdvertencia).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(203, 24);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 20);
            lblUsuario.TabIndex = 0;
            // 
            // txtInfo
            // 
            txtInfo.BackColor = Color.White;
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtInfo.Location = new Point(118, 76);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(670, 105);
            txtInfo.TabIndex = 1;
            txtInfo.Text = "Los archivos se guardarán automaticamente en este dispositivo. Por tu seguridad te recomendamos borrarlos si estás en una computadora pública.";
            // 
            // pbAdvertencia
            // 
            pbAdvertencia.Image = Properties.Resources.advertencia;
            pbAdvertencia.Location = new Point(11, 89);
            pbAdvertencia.Name = "pbAdvertencia";
            pbAdvertencia.Size = new Size(98, 83);
            pbAdvertencia.SizeMode = PictureBoxSizeMode.Zoom;
            pbAdvertencia.TabIndex = 2;
            pbAdvertencia.TabStop = false;
            // 
            // btnGenerar
            // 
            btnGenerar.AutoSize = true;
            btnGenerar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGenerar.Depth = 0;
            btnGenerar.Icon = null;
            btnGenerar.Location = new Point(368, 216);
            btnGenerar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Primary = true;
            btnGenerar.Size = new Size(98, 36);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(203, 53);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(0, 20);
            lblRol.TabIndex = 4;
            // 
            // solicitudFirmas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 282);
            Controls.Add(lblRol);
            Controls.Add(btnGenerar);
            Controls.Add(pbAdvertencia);
            Controls.Add(txtInfo);
            Controls.Add(lblUsuario);
            Name = "solicitudFirmas";
            Text = "Solicitud de Firma";
            ((System.ComponentModel.ISupportInitialize)pbAdvertencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblUsuario;
        private TextBox txtInfo;
        private PictureBox pbAdvertencia;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerar;
        public Label lblRol;
    }
}
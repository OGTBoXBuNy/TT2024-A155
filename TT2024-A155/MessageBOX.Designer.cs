namespace TT2024_A155
{
    partial class MessageBOX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBOX));
            GifHecho = new PictureBox();
            lblTexto = new Label();
            btnOK = new Button();
            btnNO = new Button();
            Retraso_icono = new System.Windows.Forms.Timer(components);
            Timer_Close = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)GifHecho).BeginInit();
            SuspendLayout();
            // 
            // GifHecho
            // 
            GifHecho.Location = new Point(60, 15);
            GifHecho.Name = "GifHecho";
            GifHecho.Size = new Size(187, 117);
            GifHecho.SizeMode = PictureBoxSizeMode.Zoom;
            GifHecho.TabIndex = 0;
            GifHecho.TabStop = false;
            // 
            // lblTexto
            // 
            lblTexto.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTexto.ForeColor = Color.Gray;
            lblTexto.Location = new Point(0, 135);
            lblTexto.Margin = new Padding(4, 0, 4, 0);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(308, 46);
            lblTexto.TabIndex = 1;
            lblTexto.Text = "Bienvenido";
            lblTexto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.Transparent;
            btnOK.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOK.ForeColor = Color.FromArgb(119, 180, 63);
            btnOK.Location = new Point(76, 185);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(155, 41);
            btnOK.TabIndex = 2;
            btnOK.Text = "Aceptar";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Visible = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnNO
            // 
            btnNO.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNO.ForeColor = Color.FromArgb(226, 76, 75);
            btnNO.Location = new Point(253, 76);
            btnNO.Name = "btnNO";
            btnNO.Size = new Size(116, 35);
            btnNO.TabIndex = 3;
            btnNO.Text = "NO";
            btnNO.UseVisualStyleBackColor = true;
            btnNO.Visible = false;
            btnNO.Click += btnNO_Click;
            // 
            // Retraso_icono
            // 
            Retraso_icono.Enabled = true;
            Retraso_icono.Interval = 4000;
            Retraso_icono.Tick += Retraso_icono_Tick;
            // 
            // Timer_Close
            // 
            Timer_Close.Interval = 4500;
            Timer_Close.Tick += Timer_Close_Tick;
            // 
            // MessageBOX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(308, 238);
            Controls.Add(btnNO);
            Controls.Add(btnOK);
            Controls.Add(lblTexto);
            Controls.Add(GifHecho);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MessageBOX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dialog";
            ((System.ComponentModel.ISupportInitialize)GifHecho).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox GifHecho;
        private Label lblTexto;
        private Button btnOK;
        private Button btnNO;
        private System.Windows.Forms.Timer Retraso_icono;
        private System.Windows.Forms.Timer Timer_Close;
    }
}
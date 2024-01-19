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
            GifHecho.Location = new Point(105, 12);
            GifHecho.Name = "GifHecho";
            GifHecho.Size = new Size(206, 97);
            GifHecho.TabIndex = 0;
            GifHecho.TabStop = false;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(162, 134);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(83, 20);
            lblTexto.TabIndex = 1;
            lblTexto.Text = "Bienvenido";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(93, 179);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 2;
            btnOK.Text = "Aceptar";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnNO
            // 
            btnNO.Location = new Point(217, 179);
            btnNO.Name = "btnNO";
            btnNO.Size = new Size(94, 29);
            btnNO.TabIndex = 3;
            btnNO.Text = "NO";
            btnNO.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(446, 293);
            Controls.Add(btnNO);
            Controls.Add(btnOK);
            Controls.Add(lblTexto);
            Controls.Add(GifHecho);
            Name = "MessageBOX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dialog";
            ((System.ComponentModel.ISupportInitialize)GifHecho).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
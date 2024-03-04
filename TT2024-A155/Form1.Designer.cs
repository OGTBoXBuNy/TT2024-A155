namespace TT2024_A155
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSign = new Button();
            btnGenLlaves = new Button();
            btnPDF = new Button();
            btnVerificar = new Button();
            fileRoute = new SaveFileDialog();
            txtpubKey = new TextBox();
            txtprivKey = new TextBox();
            btnpubKey = new Button();
            btnprivKey = new Button();
            btnBuscar = new Button();
            txtRuta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            openFile = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnSign
            // 
            btnSign.Location = new Point(157, 306);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(94, 29);
            btnSign.TabIndex = 0;
            btnSign.Text = "Sign";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            btnSign.MouseCaptureChanged += btnSign_MouseCaptureChanged;
            // 
            // btnGenLlaves
            // 
            btnGenLlaves.Location = new Point(157, 113);
            btnGenLlaves.Name = "btnGenLlaves";
            btnGenLlaves.Size = new Size(142, 29);
            btnGenLlaves.TabIndex = 1;
            btnGenLlaves.Text = "Generar Llaves";
            btnGenLlaves.UseVisualStyleBackColor = true;
            btnGenLlaves.Click += btnGenLlaves_Click;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(519, 210);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(94, 29);
            btnPDF.TabIndex = 2;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Visible = false;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(519, 320);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(94, 29);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtpubKey
            // 
            txtpubKey.Location = new Point(157, 34);
            txtpubKey.Name = "txtpubKey";
            txtpubKey.Size = new Size(438, 27);
            txtpubKey.TabIndex = 4;
            // 
            // txtprivKey
            // 
            txtprivKey.Enabled = false;
            txtprivKey.Location = new Point(157, 67);
            txtprivKey.Name = "txtprivKey";
            txtprivKey.Size = new Size(438, 27);
            txtprivKey.TabIndex = 5;
            // 
            // btnpubKey
            // 
            btnpubKey.Location = new Point(619, 34);
            btnpubKey.Name = "btnpubKey";
            btnpubKey.Size = new Size(94, 29);
            btnpubKey.TabIndex = 6;
            btnpubKey.Text = "...";
            btnpubKey.UseVisualStyleBackColor = true;
            btnpubKey.Click += btnpubKey_Click;
            // 
            // btnprivKey
            // 
            btnprivKey.Location = new Point(619, 67);
            btnprivKey.Name = "btnprivKey";
            btnprivKey.Size = new Size(94, 29);
            btnprivKey.TabIndex = 7;
            btnprivKey.Text = "...";
            btnprivKey.UseVisualStyleBackColor = true;
            btnprivKey.Click += btnprivKey_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(619, 273);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "...";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(157, 273);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(438, 27);
            txtRuta.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 41);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 10;
            label1.Text = "Ruta llave publica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 74);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 11;
            label2.Text = "Ruta llave privada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 280);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 12;
            label3.Text = "Ruta Archivo";
            // 
            // openFile
            // 
            openFile.FileName = "openFile";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRuta);
            Controls.Add(btnBuscar);
            Controls.Add(btnprivKey);
            Controls.Add(btnpubKey);
            Controls.Add(txtprivKey);
            Controls.Add(txtpubKey);
            Controls.Add(btnVerificar);
            Controls.Add(btnPDF);
            Controls.Add(btnGenLlaves);
            Controls.Add(btnSign);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSign;
        private Button btnGenLlaves;
        private Button btnPDF;
        private Button btnVerificar;
        private SaveFileDialog fileRoute;
        private TextBox txtpubKey;
        private TextBox txtprivKey;
        private Button btnpubKey;
        private Button btnprivKey;
        private Button btnBuscar;
        private TextBox txtRuta;
        private Label label1;
        private Label label2;
        private Label label3;
        private OpenFileDialog openFile;
    }
}
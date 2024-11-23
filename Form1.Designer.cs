namespace WinFormPictureBox
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
            btnPrimavera = new Button();
            btnVerano = new Button();
            btnInvierno = new Button();
            pictureBox1 = new PictureBox();
            btnOtonio = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPrimavera
            // 
            btnPrimavera.Location = new Point(71, 362);
            btnPrimavera.Name = "btnPrimavera";
            btnPrimavera.Size = new Size(88, 29);
            btnPrimavera.TabIndex = 0;
            btnPrimavera.Text = "Primavera";
            btnPrimavera.UseVisualStyleBackColor = true;
            btnPrimavera.Click += btnPrimavera_Click;
            // 
            // btnVerano
            // 
            btnVerano.Location = new Point(190, 362);
            btnVerano.Name = "btnVerano";
            btnVerano.Size = new Size(83, 29);
            btnVerano.TabIndex = 1;
            btnVerano.Text = "Verano";
            btnVerano.UseVisualStyleBackColor = true;
            btnVerano.Click += btnVerano_Click;
            // 
            // btnInvierno
            // 
            btnInvierno.Location = new Point(303, 362);
            btnInvierno.Name = "btnInvierno";
            btnInvierno.Size = new Size(86, 29);
            btnInvierno.TabIndex = 2;
            btnInvierno.Text = "Invierno";
            btnInvierno.UseVisualStyleBackColor = true;
            btnInvierno.Click += btnInvierno_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Verano;
            pictureBox1.Location = new Point(75, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnOtonio
            // 
            btnOtonio.Location = new Point(420, 362);
            btnOtonio.Name = "btnOtonio";
            btnOtonio.Size = new Size(81, 29);
            btnOtonio.TabIndex = 4;
            btnOtonio.Text = "Otoño";
            btnOtonio.UseVisualStyleBackColor = true;
            btnOtonio.Click += btnOtonio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 19);
            label1.Name = "label1";
            label1.Size = new Size(454, 37);
            label1.TabIndex = 5;
            label1.Text = "Change Image - Picture Box";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Sitka Small", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(298, 414);
            label2.Name = "label2";
            label2.Size = new Size(268, 27);
            label2.TabIndex = 6;
            label2.Text = "Andres Joseph Pacheco Carlos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(578, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOtonio);
            Controls.Add(pictureBox1);
            Controls.Add(btnInvierno);
            Controls.Add(btnVerano);
            Controls.Add(btnPrimavera);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambiar Imagenes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrimavera;
        private Button btnVerano;
        private Button btnInvierno;
        private PictureBox pictureBox1;
        private Button btnOtonio;
        private Label label1;
        private Label label2;
    }
}

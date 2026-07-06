namespace integra_1
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
            btnInicio = new Button();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(455, 255);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(228, 112);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(524, 89);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(524, 145);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(150, 31);
            txtContrasena.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(400, 89);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 151);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMG_20260609_WA0003;
            pictureBox1.Location = new Point(12, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(364, 351);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(btnInicio);
            Name = "Form1";
            Text = "Sesion";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInicio;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}

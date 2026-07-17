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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(401, 637);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(150, 58);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(337, 334);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(296, 31);
            txtUsuario.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(337, 493);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(296, 31);
            txtContrasena.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(432, 281);
            label1.Name = "label1";
            label1.Size = new Size(125, 35);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            label2.Location = new Point(401, 432);
            label2.Name = "label2";
            label2.Size = new Size(171, 35);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMG_20260609_WA0003;
            pictureBox1.Location = new Point(199, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(592, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1035, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(863, 1024);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bernard MT Condensed", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(294, 148);
            label4.Name = "label4";
            label4.Size = new Size(381, 67);
            label4.TabIndex = 5;
            label4.Text = "Inicio de Sesion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(52, 696);
            label3.Name = "label3";
            label3.Size = new Size(979, 106);
            label3.TabIndex = 7;
            label3.Text = "Sistema De Inventario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 6, 158);
            ClientSize = new Size(1898, 1024);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label3;
        private Label label4;
    }
}

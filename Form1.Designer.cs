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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            cuiPanel1 = new HartUI.Controls.cuiPanel();
            pictureBox2 = new PictureBox();
            texContrasena = new HartUI.Controls.cuiTextBox();
            texUsuario = new HartUI.Controls.cuiTextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Lavender;
            btnInicio.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.FromArgb(13, 71, 161);
            btnInicio.Location = new Point(167, 596);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(205, 56);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 71, 161);
            label1.Location = new Point(85, 270);
            label1.Name = "label1";
            label1.Size = new Size(118, 38);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(13, 71, 161);
            label2.Location = new Point(85, 418);
            label2.Name = "label2";
            label2.Size = new Size(166, 38);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 6, 158);
            panel1.Controls.Add(cuiPanel1);
            panel1.Location = new Point(982, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 1024);
            panel1.TabIndex = 6;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(pictureBox2);
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(texContrasena);
            cuiPanel1.Controls.Add(texUsuario);
            cuiPanel1.Controls.Add(label4);
            cuiPanel1.Controls.Add(btnInicio);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Location = new Point(213, 160);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(30);
            cuiPanel1.Size = new Size(519, 712);
            cuiPanel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.pngwing_com__5_;
            pictureBox2.Location = new Point(179, 129);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(193, 143);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // texContrasena
            // 
            texContrasena.BackColor = Color.White;
            texContrasena.BackgroundColor = Color.LightSteelBlue;
            texContrasena.Content = "";
            texContrasena.FocusBackgroundColor = Color.LightSteelBlue;
            texContrasena.FocusImageTint = Color.White;
            texContrasena.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            texContrasena.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texContrasena.ForeColor = Color.Gray;
            texContrasena.Image = null;
            texContrasena.ImageExpand = new Point(0, 0);
            texContrasena.ImageOffset = new Point(0, 0);
            texContrasena.Location = new Point(85, 479);
            texContrasena.Margin = new Padding(4);
            texContrasena.Multiline = false;
            texContrasena.Name = "texContrasena";
            texContrasena.NormalImageTint = Color.White;
            texContrasena.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            texContrasena.Padding = new Padding(23, 23, 23, 0);
            texContrasena.PasswordChar = false;
            texContrasena.PlaceholderColor = Color.MidnightBlue;
            texContrasena.PlaceholderText = "";
            texContrasena.Rounding = new Padding(8);
            texContrasena.Size = new Size(347, 68);
            texContrasena.TabIndex = 7;
            texContrasena.TextOffset = new Size(0, 0);
            texContrasena.UnderlinedStyle = true;
            // 
            // texUsuario
            // 
            texUsuario.BackColor = Color.White;
            texUsuario.BackgroundColor = Color.LightSteelBlue;
            texUsuario.Content = "";
            texUsuario.FocusBackgroundColor = Color.LightSteelBlue;
            texUsuario.FocusImageTint = Color.White;
            texUsuario.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            texUsuario.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texUsuario.ForeColor = Color.DimGray;
            texUsuario.Image = null;
            texUsuario.ImageExpand = new Point(0, 0);
            texUsuario.ImageOffset = new Point(0, 0);
            texUsuario.Location = new Point(85, 326);
            texUsuario.Margin = new Padding(4);
            texUsuario.Multiline = false;
            texUsuario.Name = "texUsuario";
            texUsuario.NormalImageTint = Color.White;
            texUsuario.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            texUsuario.Padding = new Padding(23, 23, 23, 0);
            texUsuario.PasswordChar = false;
            texUsuario.PlaceholderColor = Color.MidnightBlue;
            texUsuario.PlaceholderText = "";
            texUsuario.Rounding = new Padding(8);
            texUsuario.Size = new Size(347, 68);
            texUsuario.TabIndex = 6;
            texUsuario.TextOffset = new Size(0, 0);
            texUsuario.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Symbol", 26F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(13, 71, 161);
            label4.Location = new Point(69, 56);
            label4.Name = "label4";
            label4.Size = new Size(404, 70);
            label4.TabIndex = 5;
            label4.Text = "Inicio de Sesión";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMG_20260609_WA0003;
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 1024);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInicio;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private HartUI.Controls.cuiPanel cuiPanel1;
        private HartUI.Controls.cuiTextBox texContrasena;
        private HartUI.Controls.cuiTextBox texUsuario;
        private PictureBox pictureBox2;
    }
}

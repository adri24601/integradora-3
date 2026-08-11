namespace integra_1
{
    partial class FrmCambiarContra
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            texClave = new HartUI.Controls.cuiTextBox();
            btnValidarClave = new HartUI.Controls.cuiButton();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Salir22;
            pictureBox1.Location = new Point(680, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(159, 64);
            label1.Name = "label1";
            label1.Size = new Size(392, 54);
            label1.TabIndex = 1;
            label1.Text = "Cambiar contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 399);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(75, 192);
            label5.Name = "label5";
            label5.Size = new Size(588, 64);
            label5.TabIndex = 5;
            label5.Text = "Si el usuario olvido su contraseña, ingrese la clave de \r\nproducto proporcionada en la instalación.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.CornflowerBlue;
            label7.Location = new Point(100, 313);
            label7.Name = "label7";
            label7.Size = new Size(104, 38);
            label7.TabIndex = 7;
            label7.Text = "Clave: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnValidarClave);
            panel1.Controls.Add(texClave);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 530);
            panel1.TabIndex = 0;
            // 
            // texClave
            // 
            texClave.BackgroundColor = Color.CornflowerBlue;
            texClave.Content = "";
            texClave.FocusBackgroundColor = Color.CornflowerBlue;
            texClave.FocusImageTint = Color.White;
            texClave.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            texClave.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texClave.ForeColor = Color.DimGray;
            texClave.Image = null;
            texClave.ImageExpand = new Point(0, 0);
            texClave.ImageOffset = new Point(0, 0);
            texClave.Location = new Point(226, 297);
            texClave.Margin = new Padding(4);
            texClave.Multiline = false;
            texClave.Name = "texClave";
            texClave.NormalImageTint = Color.White;
            texClave.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            texClave.Padding = new Padding(27, 20, 27, 0);
            texClave.PasswordChar = false;
            texClave.PlaceholderColor = Color.DimGray;
            texClave.PlaceholderText = "";
            texClave.Rounding = new Padding(8);
            texClave.Size = new Size(399, 67);
            texClave.TabIndex = 8;
            texClave.TextOffset = new Size(0, 0);
            texClave.UnderlinedStyle = true;
            // 
            // btnValidarClave
            // 
            btnValidarClave.CheckButton = false;
            btnValidarClave.Checked = false;
            btnValidarClave.CheckedBackground = Color.LightSkyBlue;
            btnValidarClave.CheckedForeColor = Color.White;
            btnValidarClave.CheckedImageTint = Color.White;
            btnValidarClave.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnValidarClave.Content = "Validar ";
            btnValidarClave.DialogResult = DialogResult.None;
            btnValidarClave.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidarClave.ForeColor = Color.White;
            btnValidarClave.HoverBackground = Color.LightSkyBlue;
            btnValidarClave.HoverForeColor = Color.DimGray;
            btnValidarClave.HoverImageTint = Color.DimGray;
            btnValidarClave.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnValidarClave.Image = null;
            btnValidarClave.ImageExpand = new Point(0, 0);
            btnValidarClave.Location = new Point(292, 415);
            btnValidarClave.Name = "btnValidarClave";
            btnValidarClave.NormalBackground = Color.LightSkyBlue;
            btnValidarClave.NormalForeColor = Color.White;
            btnValidarClave.NormalImageTint = Color.Black;
            btnValidarClave.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnValidarClave.OutlineThickness = 1F;
            btnValidarClave.Padding = new Padding(12);
            btnValidarClave.PressedBackground = Color.LightSkyBlue;
            btnValidarClave.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnValidarClave.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnValidarClave.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnValidarClave.Rounding = new Padding(8);
            btnValidarClave.Size = new Size(177, 55);
            btnValidarClave.TabIndex = 9;
            btnValidarClave.TextAlignment = StringAlignment.Center;
            btnValidarClave.TextPadding = 12;
            btnValidarClave.TextSpacing = 2;
            btnValidarClave.Click += btnValidarClave_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngwing_com__8_;
            pictureBox2.Location = new Point(57, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(764, 558);
            panel2.TabIndex = 1;
            // 
            // FrmCambiarContra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 558);
            Controls.Add(panel2);
            Name = "FrmCambiarContra";
            Text = "Form2";
            Load += FrmCambiarContra_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label7;
        private Panel panel1;
        private HartUI.Controls.cuiTextBox texClave;
        private HartUI.Controls.cuiButton btnValidarClave;
        private PictureBox pictureBox2;
        private Panel panel2;
    }
}
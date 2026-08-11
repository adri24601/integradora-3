namespace integra_1
{
    partial class FrmUsuario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cuiPanel1 = new HartUI.Controls.cuiPanel();
            cuiPanel2 = new HartUI.Controls.cuiPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            txtID_Tienda = new TextBox();
            txtNomTienda = new TextBox();
            txtClaveTienda = new TextBox();
            txtUsuarioTienda = new TextBox();
            txtContrasenaTienda = new TextBox();
            txtNombrePropietario = new TextBox();
            txtAP_Propietario = new TextBox();
            txtAM_Propietario = new TextBox();
            btnConfiguracionTienda = new HartUI.Controls.cuiButton();
            cuiPanel1.SuspendLayout();
            cuiPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(50, 42);
            label1.Name = "label1";
            label1.Size = new Size(583, 65);
            label1.TabIndex = 2;
            label1.Text = "Configuración de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(197, 212, 235);
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(49, 87);
            label2.Name = "label2";
            label2.Size = new Size(149, 32);
            label2.TabIndex = 3;
            label2.Text = "Nombre(s): ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(197, 212, 235);
            label3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(49, 133);
            label3.Name = "label3";
            label3.Size = new Size(229, 32);
            label3.TabIndex = 4;
            label3.Text = "Apellido materno: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(197, 212, 235);
            label4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(49, 145);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 5;
            label4.Text = "Nombre: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(197, 212, 235);
            label5.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(48, 195);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 6;
            label5.Text = "Clave:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(197, 212, 235);
            label6.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(49, 101);
            label6.Name = "label6";
            label6.Size = new Size(142, 32);
            label6.TabIndex = 7;
            label6.Text = "ID_Tienda: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(197, 212, 235);
            label7.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(48, 182);
            label7.Name = "label7";
            label7.Size = new Size(222, 32);
            label7.TabIndex = 8;
            label7.Text = "Apellido paterno: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(197, 212, 235);
            label8.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(49, 292);
            label8.Name = "label8";
            label8.Size = new Size(150, 32);
            label8.TabIndex = 9;
            label8.Text = "Contraseña:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(197, 212, 235);
            label9.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(49, 243);
            label9.Name = "label9";
            label9.Size = new Size(115, 32);
            label9.TabIndex = 10;
            label9.Text = "Usuario: ";
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(txtContrasenaTienda);
            cuiPanel1.Controls.Add(txtUsuarioTienda);
            cuiPanel1.Controls.Add(txtClaveTienda);
            cuiPanel1.Controls.Add(txtNomTienda);
            cuiPanel1.Controls.Add(txtID_Tienda);
            cuiPanel1.Controls.Add(label10);
            cuiPanel1.Controls.Add(label6);
            cuiPanel1.Controls.Add(label8);
            cuiPanel1.Controls.Add(label9);
            cuiPanel1.Controls.Add(label5);
            cuiPanel1.Controls.Add(label4);
            cuiPanel1.Location = new Point(57, 157);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(197, 212, 235);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(20);
            cuiPanel1.Size = new Size(680, 357);
            cuiPanel1.TabIndex = 11;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(txtAM_Propietario);
            cuiPanel2.Controls.Add(txtAP_Propietario);
            cuiPanel2.Controls.Add(txtNombrePropietario);
            cuiPanel2.Controls.Add(label11);
            cuiPanel2.Controls.Add(label2);
            cuiPanel2.Controls.Add(label3);
            cuiPanel2.Controls.Add(label7);
            cuiPanel2.Location = new Point(57, 543);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(197, 212, 235);
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(20);
            cuiPanel2.Size = new Size(680, 266);
            cuiPanel2.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnConfiguracionTienda);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cuiPanel1);
            panel1.Controls.Add(cuiPanel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 931);
            panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngwing_com__7_;
            pictureBox1.Location = new Point(639, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(197, 212, 235);
            label10.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold);
            label10.Location = new Point(48, 28);
            label10.Name = "label10";
            label10.Size = new Size(308, 38);
            label10.TabIndex = 14;
            label10.Text = "Configuración: Tienda";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(197, 212, 235);
            label11.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold);
            label11.Location = new Point(48, 31);
            label11.Name = "label11";
            label11.Size = new Size(256, 38);
            label11.TabIndex = 15;
            label11.Text = "Datos: Propietario";
            // 
            // txtID_Tienda
            // 
            txtID_Tienda.Location = new Point(248, 101);
            txtID_Tienda.Name = "txtID_Tienda";
            txtID_Tienda.Size = new Size(371, 31);
            txtID_Tienda.TabIndex = 15;
            // 
            // txtNomTienda
            // 
            txtNomTienda.Location = new Point(248, 145);
            txtNomTienda.Name = "txtNomTienda";
            txtNomTienda.Size = new Size(371, 31);
            txtNomTienda.TabIndex = 16;
            // 
            // txtClaveTienda
            // 
            txtClaveTienda.Location = new Point(248, 195);
            txtClaveTienda.Name = "txtClaveTienda";
            txtClaveTienda.Size = new Size(371, 31);
            txtClaveTienda.TabIndex = 17;
            // 
            // txtUsuarioTienda
            // 
            txtUsuarioTienda.Location = new Point(248, 243);
            txtUsuarioTienda.Name = "txtUsuarioTienda";
            txtUsuarioTienda.Size = new Size(371, 31);
            txtUsuarioTienda.TabIndex = 18;
            // 
            // txtContrasenaTienda
            // 
            txtContrasenaTienda.Location = new Point(248, 292);
            txtContrasenaTienda.Name = "txtContrasenaTienda";
            txtContrasenaTienda.Size = new Size(371, 31);
            txtContrasenaTienda.TabIndex = 19;
            // 
            // txtNombrePropietario
            // 
            txtNombrePropietario.Location = new Point(248, 87);
            txtNombrePropietario.Name = "txtNombrePropietario";
            txtNombrePropietario.Size = new Size(371, 31);
            txtNombrePropietario.TabIndex = 16;
            // 
            // txtAP_Propietario
            // 
            txtAP_Propietario.Location = new Point(284, 133);
            txtAP_Propietario.Name = "txtAP_Propietario";
            txtAP_Propietario.Size = new Size(335, 31);
            txtAP_Propietario.TabIndex = 17;
            // 
            // txtAM_Propietario
            // 
            txtAM_Propietario.Location = new Point(284, 183);
            txtAM_Propietario.Name = "txtAM_Propietario";
            txtAM_Propietario.Size = new Size(335, 31);
            txtAM_Propietario.TabIndex = 18;
            // 
            // btnConfiguracionTienda
            // 
            btnConfiguracionTienda.CheckButton = false;
            btnConfiguracionTienda.Checked = false;
            btnConfiguracionTienda.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnConfiguracionTienda.CheckedForeColor = Color.White;
            btnConfiguracionTienda.CheckedImageTint = Color.White;
            btnConfiguracionTienda.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnConfiguracionTienda.Content = "Guardar";
            btnConfiguracionTienda.DialogResult = DialogResult.None;
            btnConfiguracionTienda.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfiguracionTienda.ForeColor = Color.White;
            btnConfiguracionTienda.HoverBackground = Color.White;
            btnConfiguracionTienda.HoverForeColor = Color.DimGray;
            btnConfiguracionTienda.HoverImageTint = Color.DimGray;
            btnConfiguracionTienda.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnConfiguracionTienda.Image = null;
            btnConfiguracionTienda.ImageExpand = new Point(0, 0);
            btnConfiguracionTienda.Location = new Point(57, 843);
            btnConfiguracionTienda.Name = "btnConfiguracionTienda";
            btnConfiguracionTienda.NormalBackground = Color.SkyBlue;
            btnConfiguracionTienda.NormalForeColor = Color.White;
            btnConfiguracionTienda.NormalImageTint = Color.Black;
            btnConfiguracionTienda.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnConfiguracionTienda.OutlineThickness = 1F;
            btnConfiguracionTienda.Padding = new Padding(12);
            btnConfiguracionTienda.PressedBackground = Color.WhiteSmoke;
            btnConfiguracionTienda.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnConfiguracionTienda.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnConfiguracionTienda.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnConfiguracionTienda.Rounding = new Padding(8);
            btnConfiguracionTienda.Size = new Size(171, 58);
            btnConfiguracionTienda.TabIndex = 14;
            btnConfiguracionTienda.TextAlignment = StringAlignment.Center;
            btnConfiguracionTienda.TextPadding = 12;
            btnConfiguracionTienda.TextSpacing = 2;
            btnConfiguracionTienda.Click += btnConfiguracionTienda_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 933);
            Controls.Add(panel1);
            Name = "FrmUsuario";
            Text = "Form2";
            Load += FrmUsuario_Load;
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            cuiPanel2.ResumeLayout(false);
            cuiPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private HartUI.Controls.cuiPanel cuiPanel1;
        private HartUI.Controls.cuiPanel cuiPanel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label11;
        private Label label10;
        private TextBox txtContrasenaTienda;
        private TextBox txtUsuarioTienda;
        private TextBox txtClaveTienda;
        private TextBox txtNomTienda;
        private TextBox txtID_Tienda;
        private TextBox txtAM_Propietario;
        private TextBox txtAP_Propietario;
        private TextBox txtNombrePropietario;
        private HartUI.Controls.cuiButton btnConfiguracionTienda;
    }
}
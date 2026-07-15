namespace integra_1
{
    partial class FrmDashboard
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
            btnProductos = new Button();
            btnProveedores = new Button();
            btnVentas = new Button();
            btnCerrar_Sesion = new Button();
            btnMenu_Inicio = new Button();
            btnReportes = new Button();
            panel1 = new Panel();
            btnAyuda = new Button();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btnGuardarInventario = new Button();
            numStockAlerta = new NumericUpDown();
            lbStockAlertas = new Label();
            label3 = new Label();
            panel4 = new Panel();
            btnCambiarLogo = new Button();
            pictureBox2 = new PictureBox();
            btnGuardarTienda = new Button();
            txtCorreo = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            txtDirTienda = new TextBox();
            txtNomTienda = new TextBox();
            label9 = new Label();
            lbTelTienda = new Label();
            lbDirecTienda = new Label();
            lbNomTienda = new Label();
            lbApartadoTitulo = new Label();
            lbAlerta = new Label();
            panelAlerta = new Panel();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            label10 = new Label();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStockAlerta).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelAlerta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(74, 443);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(239, 53);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(74, 517);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(239, 53);
            btnProveedores.TabIndex = 1;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(74, 590);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(239, 53);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnCerrar_Sesion
            // 
            btnCerrar_Sesion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar_Sesion.Location = new Point(74, 819);
            btnCerrar_Sesion.Name = "btnCerrar_Sesion";
            btnCerrar_Sesion.Size = new Size(239, 53);
            btnCerrar_Sesion.TabIndex = 4;
            btnCerrar_Sesion.Text = "Cerrar Sesión";
            btnCerrar_Sesion.UseVisualStyleBackColor = true;
            btnCerrar_Sesion.Click += btnCerrar_Sesion_Click;
            // 
            // btnMenu_Inicio
            // 
            btnMenu_Inicio.Location = new Point(74, 365);
            btnMenu_Inicio.Name = "btnMenu_Inicio";
            btnMenu_Inicio.Size = new Size(239, 53);
            btnMenu_Inicio.TabIndex = 0;
            btnMenu_Inicio.Text = "Inicio";
            btnMenu_Inicio.UseVisualStyleBackColor = true;
            btnMenu_Inicio.Click += button1_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(74, 668);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(239, 53);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 71, 161);
            panel1.Controls.Add(btnAyuda);
            panel1.Controls.Add(btnMenu_Inicio);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnCerrar_Sesion);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnVentas);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 1024);
            panel1.TabIndex = 8;
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(74, 744);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(239, 53);
            btnAyuda.TabIndex = 10;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 6, 158);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(383, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1518, 186);
            panel2.TabIndex = 15;
            panel2.Paint += panel2_Paint_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(84, 98);
            label7.Name = "label7";
            label7.Size = new Size(386, 38);
            label7.TabIndex = 19;
            label7.Text = "Resumen general de la tienda";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(61, 38);
            label6.Name = "label6";
            label6.Size = new Size(501, 70);
            label6.TabIndex = 0;
            label6.Text = "¡Bienvenido, Admin!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(131, 65);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 11;
            label2.Text = "Resumen del Sistema";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Historic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(112, 11);
            label1.Name = "label1";
            label1.Size = new Size(398, 54);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido, Admin!";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.APARTADOS;
            pictureBox1.Location = new Point(43, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(btnGuardarInventario);
            panel3.Controls.Add(numStockAlerta);
            panel3.Controls.Add(lbStockAlertas);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(1271, 395);
            panel3.Name = "panel3";
            panel3.Size = new Size(529, 167);
            panel3.TabIndex = 10;
            // 
            // btnGuardarInventario
            // 
            btnGuardarInventario.Location = new Point(173, 114);
            btnGuardarInventario.Name = "btnGuardarInventario";
            btnGuardarInventario.Size = new Size(155, 35);
            btnGuardarInventario.TabIndex = 22;
            btnGuardarInventario.Text = "Guardar";
            btnGuardarInventario.UseVisualStyleBackColor = true;
            btnGuardarInventario.Click += button3_Click;
            // 
            // numStockAlerta
            // 
            numStockAlerta.Location = new Point(298, 69);
            numStockAlerta.Name = "numStockAlerta";
            numStockAlerta.Size = new Size(180, 31);
            numStockAlerta.TabIndex = 19;
            // 
            // lbStockAlertas
            // 
            lbStockAlertas.AutoSize = true;
            lbStockAlertas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbStockAlertas.Location = new Point(33, 69);
            lbStockAlertas.Name = "lbStockAlertas";
            lbStockAlertas.Size = new Size(247, 28);
            lbStockAlertas.TabIndex = 12;
            lbStockAlertas.Text = "Stock mínimo para alertas: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 15);
            label3.Name = "label3";
            label3.Size = new Size(387, 38);
            label3.TabIndex = 11;
            label3.Text = "Configuración de inventario";
            // 
            // panel4
            // 
            panel4.BackColor = Color.PowderBlue;
            panel4.Controls.Add(btnCambiarLogo);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(btnGuardarTienda);
            panel4.Controls.Add(txtCorreo);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtTelefono);
            panel4.Controls.Add(txtDirTienda);
            panel4.Controls.Add(txtNomTienda);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(lbTelTienda);
            panel4.Controls.Add(lbDirecTienda);
            panel4.Controls.Add(lbNomTienda);
            panel4.Controls.Add(lbApartadoTitulo);
            panel4.Location = new Point(485, 395);
            panel4.Name = "panel4";
            panel4.Size = new Size(751, 525);
            panel4.TabIndex = 11;
            // 
            // btnCambiarLogo
            // 
            btnCambiarLogo.Location = new Point(298, 401);
            btnCambiarLogo.Name = "btnCambiarLogo";
            btnCambiarLogo.Size = new Size(177, 46);
            btnCambiarLogo.TabIndex = 1;
            btnCambiarLogo.Text = "Cambiar logo";
            btnCambiarLogo.UseVisualStyleBackColor = true;
            btnCambiarLogo.Click += btnCambiarLogo_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.CAF_1;
            pictureBox2.Location = new Point(80, 341);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(203, 161);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnGuardarTienda
            // 
            btnGuardarTienda.Location = new Point(298, 238);
            btnGuardarTienda.Name = "btnGuardarTienda";
            btnGuardarTienda.Size = new Size(177, 35);
            btnGuardarTienda.TabIndex = 19;
            btnGuardarTienda.Text = "Guardar ";
            btnGuardarTienda.UseVisualStyleBackColor = true;
            btnGuardarTienda.Click += btnGuardarTienda_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(228, 186);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(488, 31);
            txtCorreo.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 290);
            label5.Name = "label5";
            label5.Size = new Size(57, 28);
            label5.TabIndex = 0;
            label5.Text = "Logo";
            label5.Click += label5_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(228, 149);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(488, 31);
            txtTelefono.TabIndex = 17;
            // 
            // txtDirTienda
            // 
            txtDirTienda.Location = new Point(228, 112);
            txtDirTienda.Name = "txtDirTienda";
            txtDirTienda.Size = new Size(488, 31);
            txtDirTienda.TabIndex = 16;
            // 
            // txtNomTienda
            // 
            txtNomTienda.Location = new Point(228, 75);
            txtNomTienda.Name = "txtNomTienda";
            txtNomTienda.Size = new Size(488, 31);
            txtNomTienda.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(24, 189);
            label9.Name = "label9";
            label9.Size = new Size(183, 28);
            label9.TabIndex = 12;
            label9.Text = "Correo electrónico: ";
            // 
            // lbTelTienda
            // 
            lbTelTienda.AutoSize = true;
            lbTelTienda.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTelTienda.Location = new Point(24, 152);
            lbTelTienda.Name = "lbTelTienda";
            lbTelTienda.Size = new Size(95, 28);
            lbTelTienda.TabIndex = 3;
            lbTelTienda.Text = "Teléfono: ";
            // 
            // lbDirecTienda
            // 
            lbDirecTienda.AutoSize = true;
            lbDirecTienda.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDirecTienda.Location = new Point(24, 114);
            lbDirecTienda.Name = "lbDirecTienda";
            lbDirecTienda.Size = new Size(103, 28);
            lbDirecTienda.TabIndex = 2;
            lbDirecTienda.Text = "Dirección: ";
            // 
            // lbNomTienda
            // 
            lbNomTienda.AutoSize = true;
            lbNomTienda.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNomTienda.Location = new Point(24, 73);
            lbNomTienda.Name = "lbNomTienda";
            lbNomTienda.Size = new Size(201, 28);
            lbNomTienda.TabIndex = 1;
            lbNomTienda.Text = "Nombre de la tienda: ";
            // 
            // lbApartadoTitulo
            // 
            lbApartadoTitulo.AutoSize = true;
            lbApartadoTitulo.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbApartadoTitulo.Location = new Point(24, 15);
            lbApartadoTitulo.Name = "lbApartadoTitulo";
            lbApartadoTitulo.Size = new Size(259, 38);
            lbApartadoTitulo.TabIndex = 0;
            lbApartadoTitulo.Text = "Datos de la tienda";
            // 
            // lbAlerta
            // 
            lbAlerta.AutoSize = true;
            lbAlerta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAlerta.Location = new Point(42, 50);
            lbAlerta.Name = "lbAlerta";
            lbAlerta.Size = new Size(36, 28);
            lbAlerta.TabIndex = 17;
            lbAlerta.Text = "......";
            lbAlerta.TextAlign = ContentAlignment.MiddleLeft;
            lbAlerta.Click += lbAlerta_Click;
            // 
            // panelAlerta
            // 
            panelAlerta.BackColor = Color.PeachPuff;
            panelAlerta.Controls.Add(pictureBox3);
            panelAlerta.Controls.Add(label11);
            panelAlerta.Controls.Add(lbAlerta);
            panelAlerta.Location = new Point(1087, 242);
            panelAlerta.Name = "panelAlerta";
            panelAlerta.Size = new Size(713, 107);
            panelAlerta.TabIndex = 18;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.TStockcritico;
            pictureBox3.Location = new Point(578, -4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(132, 134);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(15, 12);
            label11.Name = "label11";
            label11.Size = new Size(293, 38);
            label11.TabIndex = 20;
            label11.Text = "Alerta: Stock mínimo";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(33, 54);
            label10.Name = "label10";
            label10.Size = new Size(36, 28);
            label10.TabIndex = 16;
            label10.Text = "......";
            // 
            // panel6
            // 
            panel6.BackColor = Color.LemonChiffon;
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label10);
            panel6.Location = new Point(485, 242);
            panel6.Name = "panel6";
            panel6.Size = new Size(570, 107);
            panel6.TabIndex = 13;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.TObjeto;
            pictureBox4.Location = new Point(402, -4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(168, 118);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 15);
            label4.Name = "label4";
            label4.Size = new Size(225, 38);
            label4.TabIndex = 17;
            label4.Text = "Total Productos";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1898, 968);
            Controls.Add(panel3);
            Controls.Add(panelAlerta);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmDashboard";
            Text = "Inicio";
            Load += FrmDashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStockAlerta).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelAlerta.ResumeLayout(false);
            panelAlerta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnProveedores;
        private Button btnVentas;
        private Button btnCerrar_Sesion;
        private Button btnMenu_Inicio;
        private Button btnReportes;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnAyuda;
        private Panel panel3;
        private Label label3;
        private Label lbStockAlertas;
        private Panel panel4;
        private Label lbTelTienda;
        private Label lbDirecTienda;
        private Label lbNomTienda;
        private Label lbApartadoTitulo;
        private Label label9;
        private TextBox txtNomTienda;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDirTienda;
        private NumericUpDown numStockAlerta;
        private Button btnGuardarTienda;
        private Button btnGuardarInventario;
        private PictureBox pictureBox2;
        private Button btnCambiarLogo;
        private Label label5;
        private Label lbAlerta;
        private Panel panelAlerta;
        private Label label7;
        private Label label6;
        private Label label11;
        private Label label10;
        private Panel panel6;
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
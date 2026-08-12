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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            panel1 = new Panel();
            btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            btnProveedores = new Guna.UI2.WinForms.Guna2Button();
            btnAyuda = new Guna.UI2.WinForms.Guna2Button();
            btnVentas = new Guna.UI2.WinForms.Guna2Button();
            btnProductos = new Guna.UI2.WinForms.Guna2Button();
            label13 = new Label();
            btnInicio = new Guna.UI2.WinForms.Guna2Button();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            panel2 = new Panel();
            picBoxApartados = new PictureBox();
            picBoxUsuario = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            picProveedores = new PictureBox();
            lbCantidadProveedores = new Label();
            lbAlertaStock = new Label();
            pictureBoxAlertas = new PictureBox();
            label12 = new Label();
            lbCantidadProductos = new Label();
            lbTituloTotalProductos = new Label();
            picProductos = new PictureBox();
            panel3 = new Panel();
            cuiPanel5 = new HartUI.Controls.cuiPanel();
            texStockMinimo = new HartUI.Controls.cuiTextBox();
            btnGuardarStockMinimo = new HartUI.Controls.cuiButton();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            cuiPanel4 = new HartUI.Controls.cuiPanel();
            label8 = new Label();
            cuiPanel2 = new HartUI.Controls.cuiPanel();
            label5 = new Label();
            label4 = new Label();
            cuiPanel1 = new HartUI.Controls.cuiPanel();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxApartados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlertas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProductos).BeginInit();
            panel3.SuspendLayout();
            cuiPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            cuiPanel4.SuspendLayout();
            cuiPanel2.SuspendLayout();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 71, 161);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnAyuda);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 968);
            panel1.TabIndex = 8;
            // 
            // btnCerrar
            // 
            btnCerrar.BorderRadius = 10;
            btnCerrar.DisabledState.BorderColor = Color.DarkGray;
            btnCerrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCerrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCerrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCerrar.FillColor = Color.FromArgb(0, 21, 137);
            btnCerrar.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(68, 778);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(234, 53);
            btnCerrar.TabIndex = 23;
            btnCerrar.Text = "Cerrar Sesión";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.BorderRadius = 10;
            btnProveedores.DisabledState.BorderColor = Color.DarkGray;
            btnProveedores.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProveedores.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProveedores.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProveedores.FillColor = Color.FromArgb(0, 21, 137);
            btnProveedores.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Location = new Point(68, 531);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(234, 53);
            btnProveedores.TabIndex = 22;
            btnProveedores.Text = "Proveedores";
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.BorderRadius = 10;
            btnAyuda.DisabledState.BorderColor = Color.DarkGray;
            btnAyuda.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAyuda.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAyuda.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAyuda.FillColor = Color.FromArgb(0, 21, 137);
            btnAyuda.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            btnAyuda.ForeColor = Color.White;
            btnAyuda.Location = new Point(68, 699);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(234, 53);
            btnAyuda.TabIndex = 21;
            btnAyuda.Text = "Ayuda";
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnVentas
            // 
            btnVentas.BorderRadius = 10;
            btnVentas.DisabledState.BorderColor = Color.DarkGray;
            btnVentas.DisabledState.CustomBorderColor = Color.DarkGray;
            btnVentas.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnVentas.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnVentas.FillColor = Color.FromArgb(0, 21, 137);
            btnVentas.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(68, 615);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(234, 53);
            btnVentas.TabIndex = 22;
            btnVentas.Text = "Ventas";
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductos
            // 
            btnProductos.BorderRadius = 10;
            btnProductos.DisabledState.BorderColor = Color.DarkGray;
            btnProductos.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProductos.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProductos.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProductos.FillColor = Color.FromArgb(0, 21, 137);
            btnProductos.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(68, 445);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(234, 53);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "Productos";
            btnProductos.Click += btnProductos_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(70, 260);
            label13.Name = "label13";
            label13.Size = new Size(232, 45);
            label13.TabIndex = 21;
            label13.Text = "CAF Inventory";
            // 
            // btnInicio
            // 
            btnInicio.BorderRadius = 10;
            btnInicio.DisabledState.BorderColor = Color.DarkGray;
            btnInicio.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInicio.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInicio.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInicio.FillColor = Color.FromArgb(0, 21, 137);
            btnInicio.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(68, 360);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(234, 53);
            btnInicio.TabIndex = 21;
            btnInicio.Text = "Inicio";
            btnInicio.Click += btnInicio_Click;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.ErrorImage = (Image)resources.GetObject("guna2CirclePictureBox1.ErrorImage");
            guna2CirclePictureBox1.Image = Properties.Resources.re4;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(85, 68);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(202, 174);
            guna2CirclePictureBox1.TabIndex = 17;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 6, 158);
            panel2.Controls.Add(picBoxApartados);
            panel2.Controls.Add(picBoxUsuario);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1518, 186);
            panel2.TabIndex = 15;
            panel2.Paint += panel2_Paint_1;
            // 
            // picBoxApartados
            // 
            picBoxApartados.Image = Properties.Resources.APARTADOS;
            picBoxApartados.Location = new Point(79, 38);
            picBoxApartados.Name = "picBoxApartados";
            picBoxApartados.Size = new Size(139, 75);
            picBoxApartados.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxApartados.TabIndex = 21;
            picBoxApartados.TabStop = false;
            picBoxApartados.Click += picBoxApartados_Click;
            // 
            // picBoxUsuario
            // 
            picBoxUsuario.Image = Properties.Resources.user3;
            picBoxUsuario.Location = new Point(1273, 38);
            picBoxUsuario.Name = "picBoxUsuario";
            picBoxUsuario.Size = new Size(140, 117);
            picBoxUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxUsuario.TabIndex = 21;
            picBoxUsuario.TabStop = false;
            picBoxUsuario.Click += picBoxUsuario_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(231, 108);
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
            label6.Location = new Point(224, 38);
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
            // picProveedores
            // 
            picProveedores.BackColor = Color.FromArgb(197, 212, 235);
            picProveedores.Image = (Image)resources.GetObject("picProveedores.Image");
            picProveedores.Location = new Point(304, 25);
            picProveedores.Name = "picProveedores";
            picProveedores.Size = new Size(235, 183);
            picProveedores.SizeMode = PictureBoxSizeMode.Zoom;
            picProveedores.TabIndex = 3;
            picProveedores.TabStop = false;
            picProveedores.Click += picProveedores_Click;
            // 
            // lbCantidadProveedores
            // 
            lbCantidadProveedores.AutoSize = true;
            lbCantidadProveedores.BackColor = Color.FromArgb(197, 212, 235);
            lbCantidadProveedores.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCantidadProveedores.ForeColor = Color.MidnightBlue;
            lbCantidadProveedores.Location = new Point(59, 211);
            lbCantidadProveedores.Name = "lbCantidadProveedores";
            lbCantidadProveedores.Size = new Size(335, 30);
            lbCantidadProveedores.TabIndex = 2;
            lbCantidadProveedores.Text = "Hay \"n\" proveedores registrados";
            // 
            // lbAlertaStock
            // 
            lbAlertaStock.AutoSize = true;
            lbAlertaStock.BackColor = Color.FromArgb(197, 212, 235);
            lbAlertaStock.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAlertaStock.ForeColor = Color.MidnightBlue;
            lbAlertaStock.Location = new Point(45, 184);
            lbAlertaStock.Name = "lbAlertaStock";
            lbAlertaStock.Size = new Size(473, 30);
            lbAlertaStock.TabIndex = 1;
            lbAlertaStock.Text = "\"N\" productos se encuentran en stock mínimo";
            // 
            // pictureBoxAlertas
            // 
            pictureBoxAlertas.BackColor = Color.FromArgb(197, 212, 235);
            pictureBoxAlertas.Image = Properties.Resources.TStockcritico;
            pictureBoxAlertas.Location = new Point(321, 10);
            pictureBoxAlertas.Name = "pictureBoxAlertas";
            pictureBoxAlertas.Size = new Size(266, 171);
            pictureBoxAlertas.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAlertas.TabIndex = 2;
            pictureBoxAlertas.TabStop = false;
            pictureBoxAlertas.Click += pictureBoxAlertas_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(197, 212, 235);
            label12.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold);
            label12.ForeColor = Color.MidnightBlue;
            label12.Location = new Point(59, 53);
            label12.Name = "label12";
            label12.Size = new Size(110, 45);
            label12.TabIndex = 0;
            label12.Text = "Alerta";
            // 
            // lbCantidadProductos
            // 
            lbCantidadProductos.AutoSize = true;
            lbCantidadProductos.BackColor = Color.FromArgb(197, 212, 235);
            lbCantidadProductos.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCantidadProductos.ForeColor = Color.MidnightBlue;
            lbCantidadProductos.Location = new Point(68, 176);
            lbCantidadProductos.Name = "lbCantidadProductos";
            lbCantidadProductos.Size = new Size(443, 30);
            lbCantidadProductos.TabIndex = 1;
            lbCantidadProductos.Text = "Hay \"n\" tipos de productos en el inventario";
            // 
            // lbTituloTotalProductos
            // 
            lbTituloTotalProductos.AutoSize = true;
            lbTituloTotalProductos.BackColor = Color.FromArgb(197, 212, 235);
            lbTituloTotalProductos.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold);
            lbTituloTotalProductos.ForeColor = Color.MidnightBlue;
            lbTituloTotalProductos.Location = new Point(68, 53);
            lbTituloTotalProductos.Name = "lbTituloTotalProductos";
            lbTituloTotalProductos.Size = new Size(106, 45);
            lbTituloTotalProductos.TabIndex = 0;
            lbTituloTotalProductos.Text = "Total ";
            // 
            // picProductos
            // 
            picProductos.BackColor = Color.FromArgb(197, 212, 235);
            picProductos.Image = Properties.Resources.TObjeto1;
            picProductos.Location = new Point(330, 0);
            picProductos.Name = "picProductos";
            picProductos.Size = new Size(200, 173);
            picProductos.SizeMode = PictureBoxSizeMode.Zoom;
            picProductos.TabIndex = 21;
            picProductos.TabStop = false;
            picProductos.Click += picProductos_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(cuiPanel5);
            panel3.Controls.Add(cuiPanel4);
            panel3.Controls.Add(cuiPanel2);
            panel3.Controls.Add(cuiPanel1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(385, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1518, 968);
            panel3.TabIndex = 22;
            // 
            // cuiPanel5
            // 
            cuiPanel5.Controls.Add(texStockMinimo);
            cuiPanel5.Controls.Add(btnGuardarStockMinimo);
            cuiPanel5.Controls.Add(pictureBox2);
            cuiPanel5.Controls.Add(label9);
            cuiPanel5.Controls.Add(label10);
            cuiPanel5.Location = new Point(794, 590);
            cuiPanel5.Name = "cuiPanel5";
            cuiPanel5.OutlineThickness = 1F;
            cuiPanel5.PanelColor = Color.FromArgb(197, 212, 235);
            cuiPanel5.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel5.Rounding = new Padding(20);
            cuiPanel5.Size = new Size(603, 283);
            cuiPanel5.TabIndex = 24;
            // 
            // texStockMinimo
            // 
            texStockMinimo.BackColor = Color.FromArgb(197, 212, 235);
            texStockMinimo.BackgroundColor = Color.White;
            texStockMinimo.Content = "";
            texStockMinimo.FocusBackgroundColor = Color.White;
            texStockMinimo.FocusImageTint = Color.White;
            texStockMinimo.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            texStockMinimo.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texStockMinimo.ForeColor = Color.Gray;
            texStockMinimo.Image = null;
            texStockMinimo.ImageExpand = new Point(0, 0);
            texStockMinimo.ImageOffset = new Point(0, 0);
            texStockMinimo.Location = new Point(83, 188);
            texStockMinimo.Margin = new Padding(4);
            texStockMinimo.Multiline = false;
            texStockMinimo.Name = "texStockMinimo";
            texStockMinimo.NormalImageTint = Color.White;
            texStockMinimo.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            texStockMinimo.Padding = new Padding(23, 17, 23, 0);
            texStockMinimo.PasswordChar = false;
            texStockMinimo.PlaceholderColor = Color.DimGray;
            texStockMinimo.PlaceholderText = "";
            texStockMinimo.Rounding = new Padding(8);
            texStockMinimo.Size = new Size(258, 57);
            texStockMinimo.TabIndex = 12;
            texStockMinimo.TextOffset = new Size(0, 0);
            texStockMinimo.UnderlinedStyle = true;
            // 
            // btnGuardarStockMinimo
            // 
            btnGuardarStockMinimo.BackColor = Color.FromArgb(197, 212, 235);
            btnGuardarStockMinimo.CheckButton = false;
            btnGuardarStockMinimo.Checked = false;
            btnGuardarStockMinimo.CheckedBackground = Color.SkyBlue;
            btnGuardarStockMinimo.CheckedForeColor = Color.White;
            btnGuardarStockMinimo.CheckedImageTint = Color.White;
            btnGuardarStockMinimo.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnGuardarStockMinimo.Content = "Guardar";
            btnGuardarStockMinimo.DialogResult = DialogResult.None;
            btnGuardarStockMinimo.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarStockMinimo.ForeColor = Color.White;
            btnGuardarStockMinimo.HoverBackground = Color.LightSteelBlue;
            btnGuardarStockMinimo.HoverForeColor = Color.DimGray;
            btnGuardarStockMinimo.HoverImageTint = Color.DimGray;
            btnGuardarStockMinimo.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnGuardarStockMinimo.Image = null;
            btnGuardarStockMinimo.ImageExpand = new Point(0, 0);
            btnGuardarStockMinimo.Location = new Point(397, 188);
            btnGuardarStockMinimo.Name = "btnGuardarStockMinimo";
            btnGuardarStockMinimo.NormalBackground = Color.LightSkyBlue;
            btnGuardarStockMinimo.NormalForeColor = Color.White;
            btnGuardarStockMinimo.NormalImageTint = Color.Black;
            btnGuardarStockMinimo.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnGuardarStockMinimo.OutlineThickness = 1F;
            btnGuardarStockMinimo.Padding = new Padding(12);
            btnGuardarStockMinimo.PressedBackground = Color.LightSteelBlue;
            btnGuardarStockMinimo.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnGuardarStockMinimo.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnGuardarStockMinimo.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnGuardarStockMinimo.Rounding = new Padding(8);
            btnGuardarStockMinimo.Size = new Size(113, 53);
            btnGuardarStockMinimo.TabIndex = 11;
            btnGuardarStockMinimo.TextAlignment = StringAlignment.Center;
            btnGuardarStockMinimo.TextPadding = 12;
            btnGuardarStockMinimo.TextSpacing = 2;
            btnGuardarStockMinimo.Click += btnGuardarStockMinimo_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(197, 212, 235);
            pictureBox2.Image = Properties.Resources.pngwing_com__6_;
            pictureBox2.Location = new Point(346, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 110);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(197, 212, 235);
            label9.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(72, 64);
            label9.Name = "label9";
            label9.Size = new Size(232, 45);
            label9.TabIndex = 7;
            label9.Text = "Configuración";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(197, 212, 235);
            label10.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(72, 109);
            label10.Name = "label10";
            label10.Size = new Size(228, 45);
            label10.TabIndex = 6;
            label10.Text = "Stock mínimo";
            // 
            // cuiPanel4
            // 
            cuiPanel4.Controls.Add(label8);
            cuiPanel4.Controls.Add(picProductos);
            cuiPanel4.Controls.Add(lbCantidadProductos);
            cuiPanel4.Controls.Add(lbTituloTotalProductos);
            cuiPanel4.Location = new Point(774, 284);
            cuiPanel4.Name = "cuiPanel4";
            cuiPanel4.OutlineThickness = 1F;
            cuiPanel4.PanelColor = Color.FromArgb(197, 212, 235);
            cuiPanel4.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel4.Rounding = new Padding(20);
            cuiPanel4.Size = new Size(605, 253);
            cuiPanel4.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(197, 212, 235);
            label8.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(68, 98);
            label8.Name = "label8";
            label8.Size = new Size(173, 45);
            label8.TabIndex = 22;
            label8.Text = "Productos";
            // 
            // cuiPanel2
            // 
            cuiPanel2.BackColor = Color.White;
            cuiPanel2.Controls.Add(label5);
            cuiPanel2.Controls.Add(picProveedores);
            cuiPanel2.Controls.Add(label4);
            cuiPanel2.Controls.Add(lbCantidadProveedores);
            cuiPanel2.Location = new Point(123, 590);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(197, 212, 235);
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(20);
            cuiPanel2.Size = new Size(587, 283);
            cuiPanel2.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(197, 212, 235);
            label5.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(59, 109);
            label5.Name = "label5";
            label5.Size = new Size(218, 45);
            label5.TabIndex = 4;
            label5.Text = "Proveedores ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(197, 212, 235);
            label4.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(59, 64);
            label4.Name = "label4";
            label4.Size = new Size(106, 45);
            label4.TabIndex = 1;
            label4.Text = "Total ";
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(label3);
            cuiPanel1.Controls.Add(pictureBoxAlertas);
            cuiPanel1.Controls.Add(lbAlertaStock);
            cuiPanel1.Controls.Add(label12);
            cuiPanel1.Location = new Point(123, 284);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(197, 212, 235);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(20);
            cuiPanel1.Size = new Size(602, 253);
            cuiPanel1.TabIndex = 3;
            cuiPanel1.Paint += cuiPanel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(197, 212, 235);
            label3.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(59, 98);
            label3.Name = "label3";
            label3.Size = new Size(228, 45);
            label3.TabIndex = 3;
            label3.Text = "Stock mínimo";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1898, 968);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FrmDashboard";
            Text = "Inicio";
            Activated += FrmDashboard_Activated_1;
            Load += FrmDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxApartados).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlertas).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProductos).EndInit();
            panel3.ResumeLayout(false);
            cuiPanel5.ResumeLayout(false);
            cuiPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            cuiPanel4.ResumeLayout(false);
            cuiPanel4.PerformLayout();
            cuiPanel2.ResumeLayout(false);
            cuiPanel2.PerformLayout();
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label lbCantidadProductos;
        private Label lbTituloTotalProductos;
        private Label lbCantidadProveedores;
        private ComboBox com;
        private Label lbAlertaStock;
        private Label label12;
        private PictureBox pictureBoxAlertas;
        private PictureBox picProveedores;
        private PictureBox picProductos;
        private Label label13;
        private Guna.UI2.WinForms.Guna2Button btnInicio;
        private Guna.UI2.WinForms.Guna2Button btnProductos;
        private Guna.UI2.WinForms.Guna2Button btnProveedores;
        private Guna.UI2.WinForms.Guna2Button btnAyuda;
        private Guna.UI2.WinForms.Guna2Button btnVentas;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private PictureBox picBoxApartados;
        private PictureBox picBoxUsuario;
        private Panel panel3;
        private HartUI.Controls.cuiPanel cuiPanel1;
        private HartUI.Controls.cuiPanel cuiPanel2;
        private Label label4;
        private Label label10;
        private HartUI.Controls.cuiPanel cuiPanel5;
        private HartUI.Controls.cuiPanel cuiPanel4;
        private Label label9;
        private Label label8;
        private Label label5;
        private Label label3;
        private HartUI.Controls.cuiButton btnGuardarStockMinimo;
        private PictureBox pictureBox2;
        private HartUI.Controls.cuiTextBox texStockMinimo;
    }
}
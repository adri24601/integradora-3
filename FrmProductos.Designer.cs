namespace integra_1
{
    partial class FrmProductos
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            button1Agregar = new Button();
            dgvProductos = new DataGridView();
            btnModificarProducto = new Button();
            panel1 = new Panel();
            btnProveedores = new Guna.UI2.WinForms.Guna2Button();
            btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            btnAyuda = new Guna.UI2.WinForms.Guna2Button();
            btnInicio = new Guna.UI2.WinForms.Guna2Button();
            btnVentas = new Guna.UI2.WinForms.Guna2Button();
            btnProductos = new Guna.UI2.WinForms.Guna2Button();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            panel2 = new Panel();
            picBoxUsuario = new PictureBox();
            picBoxApartados = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnEliminarProducto = new Button();
            panel3 = new Panel();
            texBuscar = new HartUI.Controls.cuiTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxApartados).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1Agregar
            // 
            button1Agregar.BackColor = Color.FromArgb(68, 192, 95);
            button1Agregar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1Agregar.ForeColor = Color.White;
            button1Agregar.Location = new Point(951, 300);
            button1Agregar.Name = "button1Agregar";
            button1Agregar.Size = new Size(349, 66);
            button1Agregar.TabIndex = 0;
            button1Agregar.Text = "+ Agregar producto";
            button1Agregar.UseVisualStyleBackColor = false;
            button1Agregar.Click += button1_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(206, 411);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(1106, 388);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            dgvProductos.DataError += dgvProductos_DataError;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.BackColor = Color.FromArgb(94, 167, 239);
            btnModificarProducto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnModificarProducto.ForeColor = Color.White;
            btnModificarProducto.Location = new Point(463, 848);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(193, 60);
            btnModificarProducto.TabIndex = 4;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = false;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 71, 161);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnAyuda);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 968);
            panel1.TabIndex = 5;
            // 
            // btnProveedores
            // 
            btnProveedores.BorderRadius = 10;
            btnProveedores.DisabledState.BorderColor = Color.DarkGray;
            btnProveedores.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProveedores.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProveedores.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProveedores.FillColor = Color.FromArgb(0, 21, 137);
            btnProveedores.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Location = new Point(68, 531);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(234, 53);
            btnProveedores.TabIndex = 10;
            btnProveedores.Text = "Proveedores";
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnCerrar
            // 
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
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar Sesión";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(68, 260);
            label3.Name = "label3";
            label3.Size = new Size(232, 45);
            label3.TabIndex = 8;
            label3.Text = "CAF Inventory";
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
            btnAyuda.TabIndex = 9;
            btnAyuda.Text = "Ayuda";
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnInicio
            // 
            btnInicio.BorderRadius = 10;
            btnInicio.DisabledState.BorderColor = Color.DarkGray;
            btnInicio.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInicio.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInicio.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInicio.FillColor = Color.FromArgb(0, 21, 137);
            btnInicio.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(68, 360);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(234, 53);
            btnInicio.TabIndex = 8;
            btnInicio.Text = "Inicio";
            btnInicio.Click += btnInicio_Click;
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
            btnVentas.TabIndex = 8;
            btnVentas.Text = "Ventas";
            btnVentas.Click += btnReportes_Click;
            // 
            // btnProductos
            // 
            btnProductos.BorderRadius = 10;
            btnProductos.DisabledState.BorderColor = Color.DarkGray;
            btnProductos.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProductos.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProductos.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProductos.FillColor = Color.FromArgb(0, 21, 137);
            btnProductos.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(68, 445);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(234, 53);
            btnProductos.TabIndex = 9;
            btnProductos.Text = "Productos";
            btnProductos.Click += btnProductos_Click;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = Properties.Resources.re4;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(85, 61);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(202, 174);
            guna2CirclePictureBox1.TabIndex = 8;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 6, 158);
            panel2.Controls.Add(picBoxUsuario);
            panel2.Controls.Add(picBoxApartados);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1517, 186);
            panel2.TabIndex = 6;
            // 
            // picBoxUsuario
            // 
            picBoxUsuario.Image = Properties.Resources.user3;
            picBoxUsuario.Location = new Point(1273, 38);
            picBoxUsuario.Name = "picBoxUsuario";
            picBoxUsuario.Size = new Size(140, 117);
            picBoxUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxUsuario.TabIndex = 8;
            picBoxUsuario.TabStop = false;
            picBoxUsuario.Click += picBoxUsuario_Click;
            // 
            // picBoxApartados
            // 
            picBoxApartados.Image = Properties.Resources.APARTADOS;
            picBoxApartados.Location = new Point(79, 38);
            picBoxApartados.Name = "picBoxApartados";
            picBoxApartados.Size = new Size(139, 75);
            picBoxApartados.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxApartados.TabIndex = 9;
            picBoxApartados.TabStop = false;
            picBoxApartados.Click += picBoxApartados_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(231, 108);
            label2.Name = "label2";
            label2.Size = new Size(257, 32);
            label2.TabIndex = 8;
            label2.Text = "Productos Registrados ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(224, 38);
            label1.Name = "label1";
            label1.Size = new Size(536, 70);
            label1.TabIndex = 7;
            label1.Text = "Gestión de Productos";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.FromArgb(253, 77, 77);
            btnEliminarProducto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEliminarProducto.ForeColor = Color.White;
            btnEliminarProducto.Location = new Point(206, 848);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(204, 60);
            btnEliminarProducto.TabIndex = 7;
            btnEliminarProducto.Text = "Eliminar ";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(texBuscar);
            panel3.Controls.Add(dgvProductos);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(btnEliminarProducto);
            panel3.Controls.Add(button1Agregar);
            panel3.Controls.Add(btnModificarProducto);
            panel3.Location = new Point(381, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1520, 968);
            panel3.TabIndex = 8;
            // 
            // texBuscar
            // 
            texBuscar.BackgroundColor = Color.RoyalBlue;
            texBuscar.Content = "";
            texBuscar.FocusBackgroundColor = Color.RoyalBlue;
            texBuscar.FocusImageTint = Color.White;
            texBuscar.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            texBuscar.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texBuscar.ForeColor = Color.White;
            texBuscar.Image = Properties.Resources.lupa11;
            texBuscar.ImageExpand = new Point(15, 15);
            texBuscar.ImageOffset = new Point(8, 0);
            texBuscar.Location = new Point(206, 300);
            texBuscar.Margin = new Padding(4);
            texBuscar.Multiline = false;
            texBuscar.Name = "texBuscar";
            texBuscar.NormalImageTint = Color.White;
            texBuscar.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            texBuscar.Padding = new Padding(97, 17, 97, 0);
            texBuscar.PasswordChar = false;
            texBuscar.PlaceholderColor = Color.White;
            texBuscar.PlaceholderText = "Buscar Id_Producto o nombre";
            texBuscar.Rounding = new Padding(8);
            texBuscar.Size = new Size(704, 66);
            texBuscar.TabIndex = 8;
            texBuscar.TextOffset = new Size(65, 0);
            texBuscar.UnderlinedStyle = true;
            texBuscar.ContentChanged += texBuscar_ContentChanged;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 968);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FrmProductos";
            Text = "Form2";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxApartados).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1Agregar;
        private DataGridView dgvProductos;
        private Button btnModificarProducto;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button btnEliminarProducto;
        private PictureBox picBoxApartados;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label3;
        private PictureBox picBoxUsuario;
        private Guna.UI2.WinForms.Guna2Button btnInicio;
        private Guna.UI2.WinForms.Guna2Button btnProductos;
        private Guna.UI2.WinForms.Guna2Button btnProveedores;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private Guna.UI2.WinForms.Guna2Button btnAyuda;
        private Guna.UI2.WinForms.Guna2Button btnVentas;
        private Panel panel3;
        private HartUI.Controls.cuiTextBox texBuscar;
    }
}
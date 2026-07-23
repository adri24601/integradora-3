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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            pictureBox1 = new PictureBox();
            picBox_Apartados = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnEliminarProducto = new Button();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_Apartados).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1Agregar
            // 
            button1Agregar.BackColor = Color.FromArgb(68, 192, 95);
            button1Agregar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1Agregar.ForeColor = Color.White;
            button1Agregar.Location = new Point(194, 260);
            button1Agregar.Name = "button1Agregar";
            button1Agregar.Size = new Size(349, 86);
            button1Agregar.TabIndex = 0;
            button1Agregar.Text = "Agregar Producto";
            button1Agregar.UseVisualStyleBackColor = false;
            button1Agregar.Click += button1_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(194, 413);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(1106, 466);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            dgvProductos.DataError += dgvProductos_DataError;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.BackColor = Color.FromArgb(94, 167, 239);
            btnModificarProducto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnModificarProducto.ForeColor = Color.White;
            btnModificarProducto.Location = new Point(572, 262);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(349, 86);
            btnModificarProducto.TabIndex = 4;
            btnModificarProducto.Text = "Modificar Producto";
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 1024);
            panel1.TabIndex = 5;
            // 
            // btnProveedores
            // 
            btnProveedores.BorderRadius = 10;
            btnProveedores.CustomizableEdges = customizableEdges1;
            btnProveedores.DisabledState.BorderColor = Color.DarkGray;
            btnProveedores.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProveedores.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProveedores.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProveedores.FillColor = Color.FromArgb(0, 21, 137);
            btnProveedores.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Location = new Point(68, 531);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnProveedores.Size = new Size(234, 53);
            btnProveedores.TabIndex = 10;
            btnProveedores.Text = "Proveedores";
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.CustomizableEdges = customizableEdges3;
            btnCerrar.DisabledState.BorderColor = Color.DarkGray;
            btnCerrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCerrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCerrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCerrar.FillColor = Color.FromArgb(0, 21, 137);
            btnCerrar.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(68, 778);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            btnAyuda.CustomizableEdges = customizableEdges5;
            btnAyuda.DisabledState.BorderColor = Color.DarkGray;
            btnAyuda.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAyuda.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAyuda.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAyuda.FillColor = Color.FromArgb(0, 21, 137);
            btnAyuda.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            btnAyuda.ForeColor = Color.White;
            btnAyuda.Location = new Point(68, 699);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAyuda.Size = new Size(234, 53);
            btnAyuda.TabIndex = 9;
            btnAyuda.Text = "Ayuda";
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnInicio
            // 
            btnInicio.BorderRadius = 10;
            btnInicio.CustomizableEdges = customizableEdges7;
            btnInicio.DisabledState.BorderColor = Color.DarkGray;
            btnInicio.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInicio.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInicio.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInicio.FillColor = Color.FromArgb(0, 21, 137);
            btnInicio.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(68, 360);
            btnInicio.Name = "btnInicio";
            btnInicio.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnInicio.Size = new Size(234, 53);
            btnInicio.TabIndex = 8;
            btnInicio.Text = "Inicio";
            btnInicio.Click += btnInicio_Click;
            // 
            // btnVentas
            // 
            btnVentas.BorderRadius = 10;
            btnVentas.CustomizableEdges = customizableEdges9;
            btnVentas.DisabledState.BorderColor = Color.DarkGray;
            btnVentas.DisabledState.CustomBorderColor = Color.DarkGray;
            btnVentas.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnVentas.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnVentas.FillColor = Color.FromArgb(0, 21, 137);
            btnVentas.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(68, 615);
            btnVentas.Name = "btnVentas";
            btnVentas.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnVentas.Size = new Size(234, 53);
            btnVentas.TabIndex = 8;
            btnVentas.Text = "Ventas";
            btnVentas.Click += btnReportes_Click;
            // 
            // btnProductos
            // 
            btnProductos.BorderRadius = 10;
            btnProductos.CustomizableEdges = customizableEdges11;
            btnProductos.DisabledState.BorderColor = Color.DarkGray;
            btnProductos.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProductos.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProductos.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProductos.FillColor = Color.FromArgb(0, 21, 137);
            btnProductos.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(68, 445);
            btnProductos.Name = "btnProductos";
            btnProductos.ShadowDecoration.CustomizableEdges = customizableEdges12;
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
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges13;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(202, 174);
            guna2CirclePictureBox1.TabIndex = 8;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 6, 158);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(picBox_Apartados);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1517, 186);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user3;
            pictureBox1.Location = new Point(1273, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // picBox_Apartados
            // 
            picBox_Apartados.Image = Properties.Resources.APARTADOS;
            picBox_Apartados.Location = new Point(79, 38);
            picBox_Apartados.Name = "picBox_Apartados";
            picBox_Apartados.Size = new Size(139, 75);
            picBox_Apartados.SizeMode = PictureBoxSizeMode.Zoom;
            picBox_Apartados.TabIndex = 9;
            picBox_Apartados.TabStop = false;
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
            btnEliminarProducto.Location = new Point(951, 264);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(349, 82);
            btnEliminarProducto.TabIndex = 7;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Linen;
            panel3.Controls.Add(dgvProductos);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(btnEliminarProducto);
            panel3.Controls.Add(button1Agregar);
            panel3.Controls.Add(btnModificarProducto);
            panel3.Location = new Point(384, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1517, 968);
            panel3.TabIndex = 8;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_Apartados).EndInit();
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
        private PictureBox picBox_Apartados;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label3;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnInicio;
        private Guna.UI2.WinForms.Guna2Button btnProductos;
        private Guna.UI2.WinForms.Guna2Button btnProveedores;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private Guna.UI2.WinForms.Guna2Button btnAyuda;
        private Guna.UI2.WinForms.Guna2Button btnVentas;
        private Panel panel3;
    }
}
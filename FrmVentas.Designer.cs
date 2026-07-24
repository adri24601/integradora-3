namespace integra_1
{
    partial class FrmVentas
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
            btnAgregar_Venta = new Button();
            btnImprimir_Ticket = new Button();
            txtAgregar_Id_Producto = new TextBox();
            dgvCarrito = new DataGridView();
            Id_Producto = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            lblTotal_a_Pagar = new Label();
            panel1 = new Panel();
            btnAyuda = new Guna.UI2.WinForms.Guna2Button();
            btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            btnProveedores = new Guna.UI2.WinForms.Guna2Button();
            btnVentas = new Guna.UI2.WinForms.Guna2Button();
            btnProductos = new Guna.UI2.WinForms.Guna2Button();
            btnInicio = new Guna.UI2.WinForms.Guna2Button();
            label5 = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            panel2 = new Panel();
            picBoxUsuario = new PictureBox();
            picBoxApartados = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxApartados).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar_Venta
            // 
            btnAgregar_Venta.BackColor = Color.FromArgb(68, 192, 95);
            btnAgregar_Venta.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar_Venta.ForeColor = Color.White;
            btnAgregar_Venta.Location = new Point(535, 444);
            btnAgregar_Venta.Name = "btnAgregar_Venta";
            btnAgregar_Venta.Size = new Size(220, 51);
            btnAgregar_Venta.TabIndex = 0;
            btnAgregar_Venta.Text = "Agregar";
            btnAgregar_Venta.UseVisualStyleBackColor = false;
            btnAgregar_Venta.Click += btnAgregar_Producto_Venta_Click;
            // 
            // btnImprimir_Ticket
            // 
            btnImprimir_Ticket.BackColor = Color.RoyalBlue;
            btnImprimir_Ticket.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir_Ticket.ForeColor = Color.White;
            btnImprimir_Ticket.Location = new Point(116, 816);
            btnImprimir_Ticket.Name = "btnImprimir_Ticket";
            btnImprimir_Ticket.Size = new Size(328, 69);
            btnImprimir_Ticket.TabIndex = 1;
            btnImprimir_Ticket.Text = "Cobrar e imprimir Ticket";
            btnImprimir_Ticket.UseVisualStyleBackColor = false;
            btnImprimir_Ticket.Click += btnImprimir_Ticket_Click;
            // 
            // txtAgregar_Id_Producto
            // 
            txtAgregar_Id_Producto.Location = new Point(116, 455);
            txtAgregar_Id_Producto.Name = "txtAgregar_Id_Producto";
            txtAgregar_Id_Producto.Size = new Size(314, 31);
            txtAgregar_Id_Producto.TabIndex = 2;
            txtAgregar_Id_Producto.TextChanged += txtAgregar_Id_Producto_TextChanged;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { Id_Producto, Nombre, Precio, Cantidad, Subtotal });
            dgvCarrito.Location = new Point(28, 40);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.Size = new Size(666, 66);
            dgvCarrito.TabIndex = 3;
            dgvCarrito.CellContentClick += dgvCarrito_CellContentClick;
            // 
            // Id_Producto
            // 
            Id_Producto.HeaderText = "Id";
            Id_Producto.MinimumWidth = 8;
            Id_Producto.Name = "Id_Producto";
            Id_Producto.ReadOnly = true;
            Id_Producto.Visible = false;
            Id_Producto.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Producto";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 8;
            Precio.Name = "Precio";
            Precio.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cant.";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 150;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 8;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 150;
            // 
            // lblTotal_a_Pagar
            // 
            lblTotal_a_Pagar.AutoSize = true;
            lblTotal_a_Pagar.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold);
            lblTotal_a_Pagar.ForeColor = Color.FromArgb(49, 62, 200);
            lblTotal_a_Pagar.Location = new Point(116, 719);
            lblTotal_a_Pagar.Name = "lblTotal_a_Pagar";
            lblTotal_a_Pagar.Size = new Size(207, 38);
            lblTotal_a_Pagar.TabIndex = 4;
            lblTotal_a_Pagar.Text = "Total a pagar: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 71, 161);
            panel1.Controls.Add(btnAyuda);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 968);
            panel1.TabIndex = 5;
            // 
            // btnAyuda
            // 
            btnAyuda.BorderRadius = 10;
            btnAyuda.CustomizableEdges = customizableEdges1;
            btnAyuda.DisabledState.BorderColor = Color.DarkGray;
            btnAyuda.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAyuda.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAyuda.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAyuda.FillColor = Color.FromArgb(0, 21, 137);
            btnAyuda.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAyuda.ForeColor = Color.White;
            btnAyuda.Location = new Point(68, 699);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAyuda.Size = new Size(234, 53);
            btnAyuda.TabIndex = 11;
            btnAyuda.Text = "Ayuda";
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BorderRadius = 10;
            btnCerrar.CustomizableEdges = customizableEdges3;
            btnCerrar.DisabledState.BorderColor = Color.DarkGray;
            btnCerrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCerrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCerrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCerrar.FillColor = Color.FromArgb(0, 21, 137);
            btnCerrar.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(68, 778);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCerrar.Size = new Size(234, 53);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar Sesión";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.BorderRadius = 10;
            btnProveedores.CustomizableEdges = customizableEdges5;
            btnProveedores.DisabledState.BorderColor = Color.DarkGray;
            btnProveedores.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProveedores.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProveedores.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProveedores.FillColor = Color.FromArgb(0, 21, 137);
            btnProveedores.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Location = new Point(68, 531);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnProveedores.Size = new Size(234, 53);
            btnProveedores.TabIndex = 4;
            btnProveedores.Text = "Proveedores";
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnVentas
            // 
            btnVentas.BorderRadius = 10;
            btnVentas.CustomizableEdges = customizableEdges7;
            btnVentas.DisabledState.BorderColor = Color.DarkGray;
            btnVentas.DisabledState.CustomBorderColor = Color.DarkGray;
            btnVentas.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnVentas.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnVentas.FillColor = Color.FromArgb(0, 21, 137);
            btnVentas.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(68, 615);
            btnVentas.Name = "btnVentas";
            btnVentas.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnVentas.Size = new Size(234, 53);
            btnVentas.TabIndex = 11;
            btnVentas.Text = "Ventas";
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductos
            // 
            btnProductos.BorderRadius = 10;
            btnProductos.CustomizableEdges = customizableEdges9;
            btnProductos.DisabledState.BorderColor = Color.DarkGray;
            btnProductos.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProductos.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProductos.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProductos.FillColor = Color.FromArgb(0, 21, 137);
            btnProductos.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(68, 445);
            btnProductos.Name = "btnProductos";
            btnProductos.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnProductos.Size = new Size(234, 53);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "Productos";
            btnProductos.Click += btnProductos_Click;
            // 
            // btnInicio
            // 
            btnInicio.BorderRadius = 10;
            btnInicio.CustomizableEdges = customizableEdges11;
            btnInicio.DisabledState.BorderColor = Color.DarkGray;
            btnInicio.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInicio.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInicio.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInicio.FillColor = Color.FromArgb(0, 21, 137);
            btnInicio.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(68, 360);
            btnInicio.Name = "btnInicio";
            btnInicio.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnInicio.Size = new Size(234, 53);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Inicio";
            btnInicio.Click += btnInicio_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(70, 260);
            label5.Name = "label5";
            label5.Size = new Size(232, 45);
            label5.TabIndex = 1;
            label5.Text = "CAF Inventory";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = Properties.Resources.re4;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(85, 68);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges13;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(202, 174);
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 6, 158);
            panel2.Controls.Add(picBoxUsuario);
            panel2.Controls.Add(picBoxApartados);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
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
            picBoxUsuario.TabIndex = 12;
            picBoxUsuario.TabStop = false;
            // 
            // picBoxApartados
            // 
            picBoxApartados.Image = Properties.Resources.APARTADOS;
            picBoxApartados.Location = new Point(79, 38);
            picBoxApartados.Name = "picBoxApartados";
            picBoxApartados.Size = new Size(139, 75);
            picBoxApartados.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxApartados.TabIndex = 11;
            picBoxApartados.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(231, 108);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 7;
            label1.Text = "Generar Ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(224, 38);
            label2.Name = "label2";
            label2.Size = new Size(189, 70);
            label2.TabIndex = 8;
            label2.Text = "Ventas";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Linen;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(guna2ShadowPanel1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(txtAgregar_Id_Producto);
            panel3.Controls.Add(btnImprimir_Ticket);
            panel3.Controls.Add(lblTotal_a_Pagar);
            panel3.Controls.Add(btnAgregar_Venta);
            panel3.Location = new Point(381, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1517, 968);
            panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.grocery_cart2;
            pictureBox1.Location = new Point(887, 439);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(524, 446);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(dgvCarrito);
            guna2ShadowPanel1.FillColor = Color.AntiqueWhite;
            guna2ShadowPanel1.Location = new Point(116, 532);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(723, 150);
            guna2ShadowPanel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(49, 62, 200);
            label4.Location = new Point(110, 382);
            label4.Name = "label4";
            label4.Size = new Size(317, 38);
            label4.TabIndex = 8;
            label4.Text = "Ingresa la ID_Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 22F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(49, 62, 200);
            label3.Location = new Point(99, 255);
            label3.Name = "label3";
            label3.Size = new Size(331, 60);
            label3.TabIndex = 7;
            label3.Text = "Generar Ticket ";
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 968);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FrmVentas";
            Text = "Form2";
            Load += FrmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxApartados).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2ShadowPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar_Venta;
        private Button btnImprimir_Ticket;
        private TextBox txtAgregar_Id_Producto;
        private DataGridView dgvCarrito;
        private Label lblTotal_a_Pagar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Id_Producto;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private PictureBox pictureBox1;
        private PictureBox picBoxUsuario;
        private PictureBox picBoxApartados;
        private Guna.UI2.WinForms.Guna2Button btnProveedores;
        private Guna.UI2.WinForms.Guna2Button btnVentas;
        private Guna.UI2.WinForms.Guna2Button btnProductos;
        private Guna.UI2.WinForms.Guna2Button btnInicio;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button btnAyuda;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
    }
}
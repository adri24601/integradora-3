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
            btnAyuda = new Button();
            btnCerrar_Sesion = new Button();
            btnReportes = new Button();
            btnMenu_Inicio = new Button();
            btnVentas = new Button();
            btnProductos = new Button();
            btnProveedores = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar_Venta
            // 
            btnAgregar_Venta.Location = new Point(432, 268);
            btnAgregar_Venta.Name = "btnAgregar_Venta";
            btnAgregar_Venta.Size = new Size(112, 34);
            btnAgregar_Venta.TabIndex = 0;
            btnAgregar_Venta.Text = "Agregar";
            btnAgregar_Venta.UseVisualStyleBackColor = true;
            btnAgregar_Venta.Click += btnAgregar_Producto_Venta_Click;
            // 
            // btnImprimir_Ticket
            // 
            btnImprimir_Ticket.Location = new Point(543, 487);
            btnImprimir_Ticket.Name = "btnImprimir_Ticket";
            btnImprimir_Ticket.Size = new Size(150, 69);
            btnImprimir_Ticket.TabIndex = 1;
            btnImprimir_Ticket.Text = "Cobrar e imprimir Ticket";
            btnImprimir_Ticket.UseVisualStyleBackColor = true;
            btnImprimir_Ticket.Click += btnImprimir_Ticket_Click;
            // 
            // txtAgregar_Id_Producto
            // 
            txtAgregar_Id_Producto.Location = new Point(422, 200);
            txtAgregar_Id_Producto.Name = "txtAgregar_Id_Producto";
            txtAgregar_Id_Producto.Size = new Size(314, 31);
            txtAgregar_Id_Producto.TabIndex = 2;
            txtAgregar_Id_Producto.TextChanged += txtAgregar_Id_Producto_TextChanged;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { Id_Producto, Nombre, Precio, Cantidad, Subtotal });
            dgvCarrito.Location = new Point(318, 354);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.Size = new Size(664, 66);
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
            lblTotal_a_Pagar.Location = new Point(774, 277);
            lblTotal_a_Pagar.Name = "lblTotal_a_Pagar";
            lblTotal_a_Pagar.Size = new Size(114, 25);
            lblTotal_a_Pagar.TabIndex = 4;
            lblTotal_a_Pagar.Text = "Total a pagar";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 71, 161);
            panel1.Controls.Add(btnAyuda);
            panel1.Controls.Add(btnCerrar_Sesion);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnMenu_Inicio);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnProveedores);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 632);
            panel1.TabIndex = 5;
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(48, 411);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(125, 42);
            btnAyuda.TabIndex = 7;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnCerrar_Sesion
            // 
            btnCerrar_Sesion.Location = new Point(61, 459);
            btnCerrar_Sesion.Name = "btnCerrar_Sesion";
            btnCerrar_Sesion.Size = new Size(119, 81);
            btnCerrar_Sesion.TabIndex = 7;
            btnCerrar_Sesion.Text = "Cerrar Sesión";
            btnCerrar_Sesion.UseVisualStyleBackColor = true;
            btnCerrar_Sesion.Click += btnCerrar_Sesion_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(61, 371);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(112, 34);
            btnReportes.TabIndex = 11;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnMenu_Inicio
            // 
            btnMenu_Inicio.Location = new Point(61, 116);
            btnMenu_Inicio.Name = "btnMenu_Inicio";
            btnMenu_Inicio.Size = new Size(112, 34);
            btnMenu_Inicio.TabIndex = 7;
            btnMenu_Inicio.Text = "Inicio";
            btnMenu_Inicio.UseVisualStyleBackColor = true;
            btnMenu_Inicio.Click += btnMenu_Inicio_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(61, 320);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(112, 34);
            btnVentas.TabIndex = 10;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(61, 167);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(112, 34);
            btnProductos.TabIndex = 7;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(61, 268);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(134, 34);
            btnProveedores.TabIndex = 9;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 6, 158);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(251, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(906, 132);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.APARTADOS;
            pictureBox1.Location = new Point(37, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(115, 70);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 7;
            label1.Text = "Generar Ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(106, 26);
            label2.Name = "label2";
            label2.Size = new Size(149, 54);
            label2.TabIndex = 8;
            label2.Text = "Ventas";
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 631);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblTotal_a_Pagar);
            Controls.Add(dgvCarrito);
            Controls.Add(txtAgregar_Id_Producto);
            Controls.Add(btnImprimir_Ticket);
            Controls.Add(btnAgregar_Venta);
            Name = "FrmVentas";
            Text = "Form2";
            Load += FrmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnMenu_Inicio;
        private Button btnProductos;
        private Button btnProveedores;
        private Button btnVentas;
        private Button btnReportes;
        private Button btnCerrar_Sesion;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnAyuda;
    }
}
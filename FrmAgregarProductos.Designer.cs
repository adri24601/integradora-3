namespace integra_1
{
    partial class FrmAgregarProductos
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
            txtNombre_Producto = new TextBox();
            txtId_Producto = new TextBox();
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMarca_Producto = new TextBox();
            txtPrecio_Producto = new TextBox();
            label6 = new Label();
            btnEliminar = new Button();
            btnModificar_Producto = new Button();
            label7 = new Label();
            txtCantidad_Producto = new TextBox();
            txtImagen = new TextBox();
            panel1 = new Panel();
            btnAyuda = new Button();
            btnCerrar_Sesion = new Button();
            btnMenu_Inicio = new Button();
            btnReportes = new Button();
            btnProductos = new Button();
            btnVentas = new Button();
            btnProveedores = new Button();
            panel2 = new Panel();
            label10 = new Label();
            label9 = new Label();
            lbInformacionProd = new Label();
            label8 = new Label();
            txtId_Proveedor = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre_Producto
            // 
            txtNombre_Producto.Location = new Point(815, 434);
            txtNombre_Producto.Margin = new Padding(4, 5, 4, 5);
            txtNombre_Producto.Name = "txtNombre_Producto";
            txtNombre_Producto.Size = new Size(431, 31);
            txtNombre_Producto.TabIndex = 0;
            // 
            // txtId_Producto
            // 
            txtId_Producto.Location = new Point(469, 434);
            txtId_Producto.Margin = new Padding(4, 5, 4, 5);
            txtId_Producto.Name = "txtId_Producto";
            txtId_Producto.Size = new Size(288, 31);
            txtId_Producto.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(68, 192, 95);
            btnGuardar.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(609, 825);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(220, 92);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(49, 62, 200);
            label1.Location = new Point(1343, 389);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 3;
            label1.Text = "Imagen ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(49, 62, 200);
            label2.Location = new Point(802, 389);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(304, 38);
            label2.TabIndex = 4;
            label2.Text = "Nombre del Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 120);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(49, 62, 200);
            label4.Location = new Point(460, 381);
            label4.Name = "label4";
            label4.Size = new Size(175, 38);
            label4.TabIndex = 6;
            label4.Text = "ID Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(49, 62, 200);
            label5.Location = new Point(460, 645);
            label5.Name = "label5";
            label5.Size = new Size(98, 38);
            label5.TabIndex = 7;
            label5.Text = "Marca";
            // 
            // txtMarca_Producto
            // 
            txtMarca_Producto.Location = new Point(469, 699);
            txtMarca_Producto.Name = "txtMarca_Producto";
            txtMarca_Producto.Size = new Size(458, 31);
            txtMarca_Producto.TabIndex = 8;
            // 
            // txtPrecio_Producto
            // 
            txtPrecio_Producto.Location = new Point(815, 566);
            txtPrecio_Producto.Name = "txtPrecio_Producto";
            txtPrecio_Producto.Size = new Size(350, 31);
            txtPrecio_Producto.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(49, 62, 200);
            label6.Location = new Point(802, 513);
            label6.Name = "label6";
            label6.Size = new Size(223, 38);
            label6.TabIndex = 11;
            label6.Text = "Precio de venta";
            label6.Click += label6_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(253, 77, 77);
            btnEliminar.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1140, 825);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(220, 92);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += button2_Click;
            // 
            // btnModificar_Producto
            // 
            btnModificar_Producto.BackColor = Color.FromArgb(94, 167, 239);
            btnModificar_Producto.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar_Producto.ForeColor = Color.White;
            btnModificar_Producto.Location = new Point(869, 825);
            btnModificar_Producto.Name = "btnModificar_Producto";
            btnModificar_Producto.Size = new Size(220, 92);
            btnModificar_Producto.TabIndex = 13;
            btnModificar_Producto.Text = "Modificar";
            btnModificar_Producto.UseVisualStyleBackColor = false;
            btnModificar_Producto.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(49, 62, 200);
            label7.Location = new Point(469, 513);
            label7.Name = "label7";
            label7.Size = new Size(98, 38);
            label7.TabIndex = 15;
            label7.Text = "Stock ";
            // 
            // txtCantidad_Producto
            // 
            txtCantidad_Producto.Location = new Point(469, 566);
            txtCantidad_Producto.Name = "txtCantidad_Producto";
            txtCantidad_Producto.Size = new Size(288, 31);
            txtCantidad_Producto.TabIndex = 16;
            txtCantidad_Producto.TextChanged += textBox1_TextChanged;
            // 
            // txtImagen
            // 
            txtImagen.Location = new Point(1372, 490);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(150, 31);
            txtImagen.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 71, 161);
            panel1.Controls.Add(btnAyuda);
            panel1.Controls.Add(btnCerrar_Sesion);
            panel1.Controls.Add(btnMenu_Inicio);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnProveedores);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 1024);
            panel1.TabIndex = 18;
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(74, 726);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(239, 53);
            btnAyuda.TabIndex = 21;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnCerrar_Sesion
            // 
            btnCerrar_Sesion.Location = new Point(74, 802);
            btnCerrar_Sesion.Name = "btnCerrar_Sesion";
            btnCerrar_Sesion.Size = new Size(239, 53);
            btnCerrar_Sesion.TabIndex = 25;
            btnCerrar_Sesion.Text = "Cerrar Sesión";
            btnCerrar_Sesion.UseVisualStyleBackColor = true;
            btnCerrar_Sesion.Click += btnCerrar_Sesion_Click;
            // 
            // btnMenu_Inicio
            // 
            btnMenu_Inicio.Location = new Point(74, 332);
            btnMenu_Inicio.Name = "btnMenu_Inicio";
            btnMenu_Inicio.Size = new Size(239, 53);
            btnMenu_Inicio.TabIndex = 20;
            btnMenu_Inicio.Text = "Inicio";
            btnMenu_Inicio.UseVisualStyleBackColor = true;
            btnMenu_Inicio.Click += btnMenu_Inicio_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(74, 645);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(239, 53);
            btnReportes.TabIndex = 24;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(74, 412);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(239, 53);
            btnProductos.TabIndex = 20;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(74, 566);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(239, 53);
            btnVentas.TabIndex = 23;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(74, 488);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(239, 53);
            btnProveedores.TabIndex = 22;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 6, 158);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(384, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1515, 186);
            panel2.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Historic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(111, 113);
            label10.Name = "label10";
            label10.Size = new Size(238, 32);
            label10.TabIndex = 21;
            label10.Text = "Registro de Producto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Historic", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(99, 44);
            label9.Name = "label9";
            label9.Size = new Size(513, 70);
            label9.TabIndex = 0;
            label9.Text = "Gestión de Producto";
            // 
            // lbInformacionProd
            // 
            lbInformacionProd.AutoSize = true;
            lbInformacionProd.Font = new Font("Segoe UI Symbol", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbInformacionProd.ForeColor = Color.FromArgb(49, 62, 200);
            lbInformacionProd.Location = new Point(447, 244);
            lbInformacionProd.Name = "lbInformacionProd";
            lbInformacionProd.Size = new Size(457, 60);
            lbInformacionProd.TabIndex = 20;
            lbInformacionProd.Text = "Registro de Producto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(49, 62, 200);
            label8.Location = new Point(1041, 627);
            label8.Name = "label8";
            label8.Size = new Size(191, 38);
            label8.TabIndex = 21;
            label8.Text = "Id_Proveedor";
            // 
            // txtId_Proveedor
            // 
            txtId_Proveedor.Location = new Point(1017, 699);
            txtId_Proveedor.Name = "txtId_Proveedor";
            txtId_Proveedor.Size = new Size(329, 31);
            txtId_Proveedor.TabIndex = 22;
            // 
            // FrmAgregarProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 968);
            Controls.Add(txtId_Proveedor);
            Controls.Add(label8);
            Controls.Add(lbInformacionProd);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtImagen);
            Controls.Add(txtCantidad_Producto);
            Controls.Add(label7);
            Controls.Add(btnModificar_Producto);
            Controls.Add(btnEliminar);
            Controls.Add(label6);
            Controls.Add(txtPrecio_Producto);
            Controls.Add(txtMarca_Producto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(txtId_Producto);
            Controls.Add(txtNombre_Producto);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmAgregarProductos";
            Text = "Form2";
            Load += FrmAgregarProductos_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEliminar;
        private Button btnModificar_Producto;
        private Label label7;
        public TextBox txtNombre_Producto;
        public TextBox txtId_Producto;
        public TextBox txtMarca_Producto;
        public TextBox txtPrecio_Producto;
        public TextBox txtImagen;
        private Panel panel1;
        private Panel panel2;
        private Button btnMenu_Inicio;
        private Button btnProductos;
        private Button btnProveedores;
        private Button btnVentas;
        private Button btnReportes;
        private Button btnCerrar_Sesion;
        private Label lbInformacionProd;
        private Label label10;
        private Label label9;
        private Button btnAyuda;
        public TextBox txtCantidad_Producto;
        private Label label8;
        public TextBox txtId_Proveedor;
    }
}
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMarca_Producto = new TextBox();
            txtPrecio_Producto = new TextBox();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            textBox1 = new TextBox();
            txtImagen = new TextBox();
            panel1 = new Panel();
            btnCerrar_Sesion = new Button();
            btnMenu_Inicio = new Button();
            btnReportes = new Button();
            btnProductos = new Button();
            btnVentas = new Button();
            btnInventario = new Button();
            btnProveedores = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre_Producto
            // 
            txtNombre_Producto.Location = new Point(582, 271);
            txtNombre_Producto.Margin = new Padding(4, 5, 4, 5);
            txtNombre_Producto.Name = "txtNombre_Producto";
            txtNombre_Producto.Size = new Size(291, 31);
            txtNombre_Producto.TabIndex = 0;
            // 
            // txtId_Producto
            // 
            txtId_Producto.Location = new Point(314, 271);
            txtId_Producto.Margin = new Padding(4, 5, 4, 5);
            txtId_Producto.Name = "txtId_Producto";
            txtId_Producto.Size = new Size(240, 31);
            txtId_Producto.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(68, 192, 95);
            button1.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(342, 536);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(183, 50);
            button1.TabIndex = 2;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(49, 62, 200);
            label1.Location = new Point(952, 241);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 3;
            label1.Text = "Imagen ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(49, 62, 200);
            label2.Location = new Point(582, 241);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(222, 28);
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
            label4.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(49, 62, 200);
            label4.Location = new Point(314, 241);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 6;
            label4.Text = "ID Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(49, 62, 200);
            label5.Location = new Point(314, 409);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 7;
            label5.Text = "Marca";
            // 
            // txtMarca_Producto
            // 
            txtMarca_Producto.Location = new Point(314, 437);
            txtMarca_Producto.Name = "txtMarca_Producto";
            txtMarca_Producto.Size = new Size(272, 31);
            txtMarca_Producto.TabIndex = 8;
            // 
            // txtPrecio_Producto
            // 
            txtPrecio_Producto.Location = new Point(582, 350);
            txtPrecio_Producto.Name = "txtPrecio_Producto";
            txtPrecio_Producto.Size = new Size(219, 31);
            txtPrecio_Producto.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(49, 62, 200);
            label6.Location = new Point(582, 322);
            label6.Name = "label6";
            label6.Size = new Size(163, 28);
            label6.TabIndex = 11;
            label6.Text = "Precio de Venta";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(253, 77, 77);
            button2.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(816, 536);
            button2.Name = "button2";
            button2.Size = new Size(183, 50);
            button2.TabIndex = 12;
            button2.Text = "Eliminar ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(94, 167, 239);
            button3.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(582, 536);
            button3.Name = "button3";
            button3.Size = new Size(183, 50);
            button3.TabIndex = 13;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(49, 62, 200);
            label7.Location = new Point(314, 322);
            label7.Name = "label7";
            label7.Size = new Size(72, 28);
            label7.TabIndex = 15;
            label7.Text = "Stock ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(314, 350);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 31);
            textBox1.TabIndex = 16;
            // 
            // txtImagen
            // 
            txtImagen.Location = new Point(925, 272);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(150, 31);
            txtImagen.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 71, 161);
            panel1.Controls.Add(btnCerrar_Sesion);
            panel1.Controls.Add(btnMenu_Inicio);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(btnProveedores);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 632);
            panel1.TabIndex = 18;
            // 
            // btnCerrar_Sesion
            // 
            btnCerrar_Sesion.Location = new Point(57, 495);
            btnCerrar_Sesion.Name = "btnCerrar_Sesion";
            btnCerrar_Sesion.Size = new Size(141, 57);
            btnCerrar_Sesion.TabIndex = 25;
            btnCerrar_Sesion.Text = "Cerrar Sesión";
            btnCerrar_Sesion.UseVisualStyleBackColor = true;
            btnCerrar_Sesion.Click += btnCerrar_Sesion_Click;
            // 
            // btnMenu_Inicio
            // 
            btnMenu_Inicio.Location = new Point(57, 118);
            btnMenu_Inicio.Name = "btnMenu_Inicio";
            btnMenu_Inicio.Size = new Size(141, 47);
            btnMenu_Inicio.TabIndex = 20;
            btnMenu_Inicio.Text = "Inicio";
            btnMenu_Inicio.UseVisualStyleBackColor = true;
            btnMenu_Inicio.Click += btnMenu_Inicio_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(57, 437);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(141, 47);
            btnReportes.TabIndex = 24;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(57, 171);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(141, 47);
            btnProductos.TabIndex = 20;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(57, 369);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(141, 47);
            btnVentas.TabIndex = 23;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(57, 241);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(141, 47);
            btnInventario.TabIndex = 21;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(57, 303);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(141, 47);
            btnProveedores.TabIndex = 22;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 6, 158);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(251, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 119);
            panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.APARTADOS;
            pictureBox1.Location = new Point(50, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Historic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(114, 62);
            label10.Name = "label10";
            label10.Size = new Size(238, 32);
            label10.TabIndex = 21;
            label10.Text = "Registro de Producto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Historic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(109, 18);
            label9.Name = "label9";
            label9.Size = new Size(405, 54);
            label9.TabIndex = 0;
            label9.Text = "Gestión de Producto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(49, 62, 200);
            label8.Location = new Point(301, 166);
            label8.Name = "label8";
            label8.Size = new Size(342, 45);
            label8.TabIndex = 20;
            label8.Text = "Registro de Producto";
            // 
            // FrmAgregarProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 631);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtImagen);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(txtPrecio_Producto);
            Controls.Add(txtMarca_Producto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtId_Producto);
            Controls.Add(txtNombre_Producto);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmAgregarProductos";
            Text = "Form2";
            Load += FrmAgregarProductos_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Button button3;
        private Label label7;
        private TextBox textBox1;
        public TextBox txtNombre_Producto;
        public TextBox txtId_Producto;
        public TextBox txtMarca_Producto;
        public TextBox txtPrecio_Producto;
        public TextBox txtImagen;
        private Panel panel1;
        private Panel panel2;
        private Button btnMenu_Inicio;
        private Button btnProductos;
        private Button btnInventario;
        private Button btnProveedores;
        private Button btnVentas;
        private Button btnReportes;
        private Button btnCerrar_Sesion;
        private Label label8;
        private Label label10;
        private Label label9;
        private PictureBox pictureBox1;
    }
}
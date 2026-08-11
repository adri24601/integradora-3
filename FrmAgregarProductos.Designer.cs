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
            label2 = new Label();
            label3 = new Label();
            lb_IDProducto = new Label();
            label5 = new Label();
            txtMarca_Producto = new TextBox();
            txtPrecio_Producto = new TextBox();
            label6 = new Label();
            btnModificar_Producto = new Button();
            label7 = new Label();
            txtCantidad_Producto = new TextBox();
            lbInformacionProd = new Label();
            panelContenido = new Panel();
            picBoxCerrarPanel = new PictureBox();
            panel1 = new Panel();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxCerrarPanel).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre_Producto
            // 
            txtNombre_Producto.BackColor = SystemColors.GradientInactiveCaption;
            txtNombre_Producto.Location = new Point(85, 266);
            txtNombre_Producto.Margin = new Padding(4, 5, 4, 5);
            txtNombre_Producto.Name = "txtNombre_Producto";
            txtNombre_Producto.Size = new Size(539, 31);
            txtNombre_Producto.TabIndex = 0;
            // 
            // txtId_Producto
            // 
            txtId_Producto.BackColor = SystemColors.GradientInactiveCaption;
            txtId_Producto.Location = new Point(717, 149);
            txtId_Producto.Margin = new Padding(4, 5, 4, 5);
            txtId_Producto.Name = "txtId_Producto";
            txtId_Producto.Size = new Size(203, 31);
            txtId_Producto.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(68, 192, 95);
            btnGuardar.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(85, 461);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(176, 61);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(49, 62, 200);
            label2.Location = new Point(85, 209);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(304, 38);
            label2.TabIndex = 4;
            label2.Text = "Nombre del Producto";
            label2.Click += label2_Click;
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
            // lb_IDProducto
            // 
            lb_IDProducto.AutoSize = true;
            lb_IDProducto.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_IDProducto.ForeColor = Color.FromArgb(49, 62, 200);
            lb_IDProducto.Location = new Point(717, 95);
            lb_IDProducto.Name = "lb_IDProducto";
            lb_IDProducto.Size = new Size(175, 38);
            lb_IDProducto.TabIndex = 6;
            lb_IDProducto.Text = "ID Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(49, 62, 200);
            label5.Location = new Point(368, 326);
            label5.Name = "label5";
            label5.Size = new Size(98, 38);
            label5.TabIndex = 7;
            label5.Text = "Marca";
            label5.Click += label5_Click;
            // 
            // txtMarca_Producto
            // 
            txtMarca_Producto.BackColor = SystemColors.GradientInactiveCaption;
            txtMarca_Producto.Location = new Point(368, 379);
            txtMarca_Producto.Name = "txtMarca_Producto";
            txtMarca_Producto.Size = new Size(552, 31);
            txtMarca_Producto.TabIndex = 8;
            // 
            // txtPrecio_Producto
            // 
            txtPrecio_Producto.BackColor = SystemColors.GradientInactiveCaption;
            txtPrecio_Producto.Location = new Point(85, 379);
            txtPrecio_Producto.Name = "txtPrecio_Producto";
            txtPrecio_Producto.Size = new Size(223, 31);
            txtPrecio_Producto.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(49, 62, 200);
            label6.Location = new Point(85, 326);
            label6.Name = "label6";
            label6.Size = new Size(223, 38);
            label6.TabIndex = 11;
            label6.Text = "Precio de venta";
            label6.Click += label6_Click;
            // 
            // btnModificar_Producto
            // 
            btnModificar_Producto.BackColor = Color.FromArgb(94, 167, 239);
            btnModificar_Producto.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar_Producto.ForeColor = Color.White;
            btnModificar_Producto.Location = new Point(744, 461);
            btnModificar_Producto.Name = "btnModificar_Producto";
            btnModificar_Producto.Size = new Size(176, 61);
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
            label7.Location = new Point(688, 209);
            label7.Name = "label7";
            label7.Size = new Size(98, 38);
            label7.TabIndex = 15;
            label7.Text = "Stock ";
            // 
            // txtCantidad_Producto
            // 
            txtCantidad_Producto.BackColor = SystemColors.GradientInactiveCaption;
            txtCantidad_Producto.Location = new Point(688, 266);
            txtCantidad_Producto.Name = "txtCantidad_Producto";
            txtCantidad_Producto.Size = new Size(232, 31);
            txtCantidad_Producto.TabIndex = 16;
            txtCantidad_Producto.TextChanged += textBox1_TextChanged;
            // 
            // lbInformacionProd
            // 
            lbInformacionProd.AutoSize = true;
            lbInformacionProd.Font = new Font("Segoe UI Symbol", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbInformacionProd.ForeColor = Color.FromArgb(49, 62, 200);
            lbInformacionProd.Location = new Point(85, 73);
            lbInformacionProd.Name = "lbInformacionProd";
            lbInformacionProd.Size = new Size(457, 60);
            lbInformacionProd.TabIndex = 20;
            lbInformacionProd.Text = "Registro de Producto";
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.White;
            panelContenido.Controls.Add(picBoxCerrarPanel);
            panelContenido.Controls.Add(lbInformacionProd);
            panelContenido.Controls.Add(btnGuardar);
            panelContenido.Controls.Add(lb_IDProducto);
            panelContenido.Controls.Add(btnModificar_Producto);
            panelContenido.Controls.Add(txtId_Producto);
            panelContenido.Controls.Add(label2);
            panelContenido.Controls.Add(label6);
            panelContenido.Controls.Add(txtNombre_Producto);
            panelContenido.Controls.Add(label7);
            panelContenido.Controls.Add(txtCantidad_Producto);
            panelContenido.Controls.Add(txtMarca_Producto);
            panelContenido.Controls.Add(txtPrecio_Producto);
            panelContenido.Controls.Add(label5);
            panelContenido.Location = new Point(14, 15);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1014, 576);
            panelContenido.TabIndex = 23;
            // 
            // picBoxCerrarPanel
            // 
            picBoxCerrarPanel.Image = Properties.Resources.Salir21;
            picBoxCerrarPanel.Location = new Point(931, 27);
            picBoxCerrarPanel.Name = "picBoxCerrarPanel";
            picBoxCerrarPanel.Size = new Size(58, 44);
            picBoxCerrarPanel.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxCerrarPanel.TabIndex = 21;
            picBoxCerrarPanel.TabStop = false;
            picBoxCerrarPanel.Click += picBoxCerrarPanel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panelContenido);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 604);
            panel1.TabIndex = 22;
            // 
            // FrmAgregarProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 602);
            Controls.Add(panel1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmAgregarProductos";
            Text = "Form2";
            Load += FrmAgregarProductos_Load;
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxCerrarPanel).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        public TextBox txtNombre_Producto;
        public TextBox txtId_Producto;
        public TextBox txtMarca_Producto;
        public TextBox txtPrecio_Producto;
        private Label lbInformacionProd;
        public TextBox txtCantidad_Producto;
        private Panel panelContenido;
        public Button btnGuardar;
        public Button btnModificar_Producto;
        public Label lb_IDProducto;
        private PictureBox picBoxCerrarPanel;
        private Panel panel1;
    }
}
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
            SuspendLayout();
            // 
            // txtNombre_Producto
            // 
            txtNombre_Producto.Location = new Point(308, 54);
            txtNombre_Producto.Margin = new Padding(4, 5, 4, 5);
            txtNombre_Producto.Name = "txtNombre_Producto";
            txtNombre_Producto.Size = new Size(141, 31);
            txtNombre_Producto.TabIndex = 0;
            // 
            // txtId_Producto
            // 
            txtId_Producto.Location = new Point(308, 120);
            txtId_Producto.Margin = new Padding(4, 5, 4, 5);
            txtId_Producto.Name = "txtId_Producto";
            txtId_Producto.Size = new Size(141, 31);
            txtId_Producto.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(592, 50);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 2;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 378);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 3;
            label1.Text = "Imagen del Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 50);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(185, 25);
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
            label4.Location = new Point(92, 120);
            label4.Name = "label4";
            label4.Size = new Size(135, 25);
            label4.TabIndex = 6;
            label4.Text = "Id del Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 183);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 7;
            label5.Text = "Marca";
            // 
            // txtMarca_Producto
            // 
            txtMarca_Producto.Location = new Point(299, 183);
            txtMarca_Producto.Name = "txtMarca_Producto";
            txtMarca_Producto.Size = new Size(150, 31);
            txtMarca_Producto.TabIndex = 8;
            // 
            // txtPrecio_Producto
            // 
            txtPrecio_Producto.Location = new Point(299, 247);
            txtPrecio_Producto.Name = "txtPrecio_Producto";
            txtPrecio_Producto.Size = new Size(150, 31);
            txtPrecio_Producto.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 247);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 11;
            label6.Text = "Precio";
            // 
            // button2
            // 
            button2.Location = new Point(592, 180);
            button2.Name = "button2";
            button2.Size = new Size(183, 31);
            button2.TabIndex = 12;
            button2.Text = "Eliminar Producto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(592, 112);
            button3.Name = "button3";
            button3.Size = new Size(212, 33);
            button3.TabIndex = 13;
            button3.Text = "Modificar Producto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(93, 308);
            label7.Name = "label7";
            label7.Size = new Size(162, 25);
            label7.TabIndex = 15;
            label7.Text = "Stock del Producto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(299, 308);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 16;
            // 
            // txtImagen
            // 
            txtImagen.Location = new Point(299, 378);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(150, 31);
            txtImagen.TabIndex = 17;
            // 
            // FrmAgregarProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
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
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox textBox1;
        public TextBox txtNombre_Producto;
        public TextBox txtId_Producto;
        public TextBox txtMarca_Producto;
        public TextBox txtPrecio_Producto;
        public TextBox txtImagen;
    }
}
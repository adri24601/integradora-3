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
            button1 = new Button();
            dgvProductos = new DataGridView();
            btnModificarProducto = new Button();
            panel1 = new Panel();
            label3 = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            panel2 = new Panel();
            picBox_Apartados = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnEliminarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox_Apartados).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(921, 240);
            button1.Name = "button1";
            button1.Size = new Size(230, 58);
            button1.TabIndex = 0;
            button1.Text = "Agregar Producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(509, 353);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(1259, 393);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            dgvProductos.DataError += dgvProductos_DataError;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(509, 240);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(301, 58);
            btnModificarProducto.TabIndex = 4;
            btnModificarProducto.Text = "Modificar Producto";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 71, 161);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 1024);
            panel1.TabIndex = 5;
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
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = Properties.Resources.re4;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(85, 61);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(202, 174);
            guna2CirclePictureBox1.TabIndex = 8;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 6, 158);
            panel2.Controls.Add(picBox_Apartados);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(384, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1517, 186);
            panel2.TabIndex = 6;
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
            btnEliminarProducto.Location = new Point(1387, 245);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(207, 53);
            btnEliminarProducto.TabIndex = 7;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 968);
            Controls.Add(btnEliminarProducto);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnModificarProducto);
            Controls.Add(dgvProductos);
            Controls.Add(button1);
            Name = "FrmProductos";
            Text = "Form2";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBox_Apartados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
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
    }
}
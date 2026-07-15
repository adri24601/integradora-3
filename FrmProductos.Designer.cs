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
            button1 = new Button();
            dgvProductos = new DataGridView();
            btnModificarProducto = new Button();
            panel1 = new Panel();
            btnAyuda = new Button();
            btnCerrar_Sesion = new Button();
            btnReportes = new Button();
            btnVentas = new Button();
            btnProveedores = new Button();
            btnProductos = new Button();
            btnMenu_Inicio = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(925, 240);
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
            dgvProductos.Size = new Size(944, 530);
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
            panel1.Controls.Add(btnAyuda);
            panel1.Controls.Add(btnCerrar_Sesion);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnMenu_Inicio);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 1024);
            panel1.TabIndex = 5;
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(67, 755);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(239, 53);
            btnAyuda.TabIndex = 7;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnCerrar_Sesion
            // 
            btnCerrar_Sesion.Location = new Point(67, 830);
            btnCerrar_Sesion.Name = "btnCerrar_Sesion";
            btnCerrar_Sesion.Size = new Size(239, 53);
            btnCerrar_Sesion.TabIndex = 7;
            btnCerrar_Sesion.Text = "Cerrar Sesión";
            btnCerrar_Sesion.UseVisualStyleBackColor = true;
            btnCerrar_Sesion.Click += btnCerrar_Sesion_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(67, 672);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(239, 53);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(67, 590);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(239, 53);
            btnVentas.TabIndex = 7;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(67, 509);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(239, 53);
            btnProveedores.TabIndex = 7;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(67, 427);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(239, 53);
            btnProductos.TabIndex = 7;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnMenu_Inicio
            // 
            btnMenu_Inicio.Location = new Point(67, 347);
            btnMenu_Inicio.Name = "btnMenu_Inicio";
            btnMenu_Inicio.Size = new Size(239, 53);
            btnMenu_Inicio.TabIndex = 7;
            btnMenu_Inicio.Text = "Inicio";
            btnMenu_Inicio.UseVisualStyleBackColor = true;
            btnMenu_Inicio.Click += btnMenu_Inicio_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 6, 158);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(384, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1517, 186);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(138, 105);
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
            label1.Location = new Point(125, 35);
            label1.Name = "label1";
            label1.Size = new Size(536, 70);
            label1.TabIndex = 7;
            label1.Text = "Gestión de Productos";
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 968);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Button btnVentas;
        private Button btnProveedores;
        private Button btnProductos;
        private Button btnMenu_Inicio;
        private Button btnReportes;
        private Button btnCerrar_Sesion;
        private Button btnAyuda;
    }
}
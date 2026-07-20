namespace integra_1
{
    partial class FrmProveedores
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
            btnModificarProveedores = new Button();
            btnAgregarProveedor = new Button();
            dgvProveedores = new DataGridView();
            panel1 = new Panel();
            btnCerrar_Sesion = new Button();
            btnMenu_Inicio = new Button();
            btnAyuda = new Button();
            btnProductos = new Button();
            btnReportes = new Button();
            btnVentas = new Button();
            btnProveedores = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnEliminar_Proveedor = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnModificarProveedores
            // 
            btnModificarProveedores.Location = new Point(557, 243);
            btnModificarProveedores.Name = "btnModificarProveedores";
            btnModificarProveedores.Size = new Size(218, 73);
            btnModificarProveedores.TabIndex = 1;
            btnModificarProveedores.Text = "Modificar";
            btnModificarProveedores.UseVisualStyleBackColor = true;
            btnModificarProveedores.Click += button1_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Location = new Point(825, 243);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(281, 73);
            btnAgregarProveedor.TabIndex = 2;
            btnAgregarProveedor.Text = "Agregar";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(506, 394);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 62;
            dgvProveedores.Size = new Size(1176, 514);
            dgvProveedores.TabIndex = 0;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 71, 161);
            panel1.Controls.Add(btnCerrar_Sesion);
            panel1.Controls.Add(btnMenu_Inicio);
            panel1.Controls.Add(btnAyuda);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnProveedores);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 1024);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // btnCerrar_Sesion
            // 
            btnCerrar_Sesion.Location = new Point(67, 825);
            btnCerrar_Sesion.Name = "btnCerrar_Sesion";
            btnCerrar_Sesion.Size = new Size(239, 53);
            btnCerrar_Sesion.TabIndex = 12;
            btnCerrar_Sesion.Text = "Cerrar Sesión";
            btnCerrar_Sesion.UseVisualStyleBackColor = true;
            btnCerrar_Sesion.Click += btnCerrar_Sesion_Click;
            // 
            // btnMenu_Inicio
            // 
            btnMenu_Inicio.Location = new Point(67, 350);
            btnMenu_Inicio.Name = "btnMenu_Inicio";
            btnMenu_Inicio.Size = new Size(239, 53);
            btnMenu_Inicio.TabIndex = 5;
            btnMenu_Inicio.Text = "Inicio";
            btnMenu_Inicio.UseVisualStyleBackColor = true;
            btnMenu_Inicio.Click += button1_Click_1;
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(67, 752);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(239, 53);
            btnAyuda.TabIndex = 11;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(67, 433);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(239, 53);
            btnProductos.TabIndex = 6;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(67, 674);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(239, 53);
            btnReportes.TabIndex = 10;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(67, 597);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(239, 53);
            btnVentas.TabIndex = 9;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(67, 516);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(239, 53);
            btnProveedores.TabIndex = 8;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 6, 158);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(387, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1518, 186);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(133, 102);
            label2.Name = "label2";
            label2.Size = new Size(149, 32);
            label2.TabIndex = 6;
            label2.Text = "Información ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(95, 45);
            label1.Name = "label1";
            label1.Size = new Size(591, 70);
            label1.TabIndex = 5;
            label1.Text = "Gestión de Proveedores";
            // 
            // btnEliminar_Proveedor
            // 
            btnEliminar_Proveedor.Location = new Point(1275, 256);
            btnEliminar_Proveedor.Name = "btnEliminar_Proveedor";
            btnEliminar_Proveedor.Size = new Size(261, 68);
            btnEliminar_Proveedor.TabIndex = 5;
            btnEliminar_Proveedor.Text = "Eliminar";
            btnEliminar_Proveedor.UseVisualStyleBackColor = true;
            btnEliminar_Proveedor.Click += btnEliminar_Proveedor_Click;
            // 
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 968);
            Controls.Add(btnEliminar_Proveedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvProveedores);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(btnModificarProveedores);
            Name = "FrmProveedores";
            Text = "Form2";
            Load += FrmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnModificarProveedores;
        private Button btnAgregarProveedor;
        private DataGridView dgvProveedores;
        private Panel panel1;
        private Panel panel2;
        private Button btnCerrar_Sesion;
        private Button btnMenu_Inicio;
        private Button btnAyuda;
        private Button btnProductos;
        private Button btnReportes;
        private Button btnVentas;
        private Button btnProveedores;
        private Label label1;
        private Label label2;
        private Button btnEliminar_Proveedor;
    }
}
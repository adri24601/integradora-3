namespace integra_1
{
    partial class FrmDashboard
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
            btnProductos = new Button();
            btnProveedores = new Button();
            btnVentas = new Button();
            btnCerrar_Sesion = new Button();
            btnMenu_Inicio = new Button();
            btnInventario = new Button();
            btnReportes = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelContenido = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(65, 221);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(141, 47);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(65, 348);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(141, 47);
            btnProveedores.TabIndex = 1;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(65, 401);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(141, 47);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnCerrar_Sesion
            // 
            btnCerrar_Sesion.Location = new Point(65, 542);
            btnCerrar_Sesion.Name = "btnCerrar_Sesion";
            btnCerrar_Sesion.Size = new Size(141, 47);
            btnCerrar_Sesion.TabIndex = 4;
            btnCerrar_Sesion.Text = "Cerrar Sesión";
            btnCerrar_Sesion.UseVisualStyleBackColor = true;
            btnCerrar_Sesion.Click += btnCerrar_Sesion_Click;
            // 
            // btnMenu_Inicio
            // 
            btnMenu_Inicio.Location = new Point(65, 170);
            btnMenu_Inicio.Name = "btnMenu_Inicio";
            btnMenu_Inicio.Size = new Size(141, 47);
            btnMenu_Inicio.TabIndex = 0;
            btnMenu_Inicio.Text = "Inicio";
            btnMenu_Inicio.UseVisualStyleBackColor = true;
            btnMenu_Inicio.Click += button1_Click;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(65, 274);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(141, 47);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(65, 465);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(141, 47);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 71, 161);
            panel1.Controls.Add(btnMenu_Inicio);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnCerrar_Sesion);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnVentas);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 616);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 6, 158);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(251, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(906, 132);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(131, 65);
            label2.Name = "label2";
            label2.Size = new Size(243, 32);
            label2.TabIndex = 11;
            label2.Text = "Resumen del Sistema";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Historic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(112, 11);
            label1.Name = "label1";
            label1.Size = new Size(398, 54);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido, Admin!";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.APARTADOS;
            pictureBox1.Location = new Point(43, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelContenido
            // 
            panelContenido.Location = new Point(510, 333);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(300, 150);
            panelContenido.TabIndex = 10;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 617);
            Controls.Add(panelContenido);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmDashboard";
            Text = "Inicio";
            Load += FrmDashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnProveedores;
        private Button btnVentas;
        private Button btnCerrar_Sesion;
        private Button btnMenu_Inicio;
        private Button btnInventario;
        private Button btnReportes;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panelContenido;
    }
}
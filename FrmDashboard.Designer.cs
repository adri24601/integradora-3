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
            label1 = new Label();
            panelContenido = new Panel();
            btnMenu_Inicio = new Button();
            btnInventario = new Button();
            btnReportes = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(22, 178);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(114, 32);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(10, 272);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(131, 35);
            btnProveedores.TabIndex = 1;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(10, 335);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(131, 34);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnCerrar_Sesion
            // 
            btnCerrar_Sesion.Location = new Point(10, 491);
            btnCerrar_Sesion.Name = "btnCerrar_Sesion";
            btnCerrar_Sesion.Size = new Size(131, 60);
            btnCerrar_Sesion.TabIndex = 4;
            btnCerrar_Sesion.Text = "Cerrar sesion";
            btnCerrar_Sesion.UseVisualStyleBackColor = true;
            btnCerrar_Sesion.Click += btnCerrar_Sesion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 5;
            label1.Text = "Menu principal";
            // 
            // panelContenido
            // 
            panelContenido.Location = new Point(159, 37);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(997, 547);
            panelContenido.TabIndex = 6;
            // 
            // btnMenu_Inicio
            // 
            btnMenu_Inicio.Location = new Point(22, 138);
            btnMenu_Inicio.Name = "btnMenu_Inicio";
            btnMenu_Inicio.Size = new Size(112, 34);
            btnMenu_Inicio.TabIndex = 0;
            btnMenu_Inicio.Text = "Inicio";
            btnMenu_Inicio.UseVisualStyleBackColor = true;
            btnMenu_Inicio.Click += button1_Click;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(22, 216);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(112, 34);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(12, 396);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(112, 34);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMG_20260609_WA0004__1_;
            pictureBox1.Location = new Point(12, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 584);
            Controls.Add(pictureBox1);
            Controls.Add(btnReportes);
            Controls.Add(panelContenido);
            Controls.Add(btnInventario);
            Controls.Add(label1);
            Controls.Add(btnMenu_Inicio);
            Controls.Add(btnCerrar_Sesion);
            Controls.Add(btnVentas);
            Controls.Add(btnProveedores);
            Controls.Add(btnProductos);
            Name = "FrmDashboard";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProductos;
        private Button btnProveedores;
        private Button btnVentas;
        private Button btnCerrar_Sesion;
        private Label label1;
        private Panel panelContenido;
        private Button btnMenu_Inicio;
        private Button btnInventario;
        private Button btnReportes;
        private PictureBox pictureBox1;
    }
}
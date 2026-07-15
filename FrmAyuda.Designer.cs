namespace integra_1
{
    partial class FrmAyuda
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
            panel1 = new Panel();
            btnCerrar_Sesion = new Button();
            btnReportes = new Button();
            btnAyuda = new Button();
            btnVentas = new Button();
            btnMenu_Inicio = new Button();
            btnProveedores = new Button();
            btnProductos = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 71, 161);
            panel1.Controls.Add(btnCerrar_Sesion);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnAyuda);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnMenu_Inicio);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnProductos);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 1024);
            panel1.TabIndex = 0;
            // 
            // btnCerrar_Sesion
            // 
            btnCerrar_Sesion.Location = new Point(70, 821);
            btnCerrar_Sesion.Name = "btnCerrar_Sesion";
            btnCerrar_Sesion.Size = new Size(239, 53);
            btnCerrar_Sesion.TabIndex = 2;
            btnCerrar_Sesion.Text = "Cerrar Sesión";
            btnCerrar_Sesion.UseVisualStyleBackColor = true;
            btnCerrar_Sesion.Click += btnCerrar_Sesion_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(70, 665);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(239, 53);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(70, 746);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(239, 53);
            btnAyuda.TabIndex = 8;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(70, 582);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(239, 53);
            btnVentas.TabIndex = 6;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnMenu_Inicio
            // 
            btnMenu_Inicio.Location = new Point(70, 330);
            btnMenu_Inicio.Name = "btnMenu_Inicio";
            btnMenu_Inicio.Size = new Size(239, 53);
            btnMenu_Inicio.TabIndex = 2;
            btnMenu_Inicio.Text = "Inicio";
            btnMenu_Inicio.UseVisualStyleBackColor = true;
            btnMenu_Inicio.Click += button1_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(70, 498);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(239, 53);
            btnProveedores.TabIndex = 5;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(70, 414);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(239, 53);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 6, 158);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(387, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1518, 186);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 87);
            label2.Name = "label2";
            label2.Size = new Size(439, 32);
            label2.TabIndex = 3;
            label2.Text = "Guía de uso del sistema CAF Inventory  ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(76, 28);
            label1.Name = "label1";
            label1.Size = new Size(441, 70);
            label1.TabIndex = 2;
            label1.Text = "Centro de Ayuda ";
            // 
            // FrmAyuda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 968);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmAyuda";
            Load += FrmAyuda_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button btnReportes;
        private Button btnAyuda;
        private Button btnVentas;
        private Button btnMenu_Inicio;
        private Button btnProveedores;
        private Button btnProductos;
        private Button btnCerrar_Sesion;
    }
}
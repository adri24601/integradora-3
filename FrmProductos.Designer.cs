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
            label1 = new Label();
            dgvProductos = new DataGridView();
            btnModificarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(567, 9);
            button1.Name = "button1";
            button1.Size = new Size(221, 38);
            button1.TabIndex = 0;
            button1.Text = "Agregar Producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 25);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(159, 53);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(640, 393);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            dgvProductos.DataError += dgvProductos_DataError;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(314, 11);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(203, 34);
            btnModificarProducto.TabIndex = 4;
            btnModificarProducto.Text = "Modificar Producto";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificarProducto);
            Controls.Add(dgvProductos);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FrmProductos";
            Text = "Form2";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dgvProductos;
        private Button btnModificarProducto;
    }
}
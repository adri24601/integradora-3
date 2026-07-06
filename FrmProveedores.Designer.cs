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
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // btnModificarProveedores
            // 
            btnModificarProveedores.Location = new Point(382, 47);
            btnModificarProveedores.Name = "btnModificarProveedores";
            btnModificarProveedores.Size = new Size(112, 34);
            btnModificarProveedores.TabIndex = 1;
            btnModificarProveedores.Text = "Modificar";
            btnModificarProveedores.UseVisualStyleBackColor = true;
            btnModificarProveedores.Click += button1_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Location = new Point(546, 47);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(112, 34);
            btnAgregarProveedor.TabIndex = 2;
            btnAgregarProveedor.Text = "Agregar";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(264, 105);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 62;
            dgvProveedores.Size = new Size(488, 310);
            dgvProveedores.TabIndex = 0;
            // 
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProveedores);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(btnModificarProveedores);
            Name = "FrmProveedores";
            Text = "Form2";
            Load += FrmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnModificarProveedores;
        private Button btnAgregarProveedor;
        private DataGridView dgvProveedores;
    }
}
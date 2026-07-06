namespace integra_1
{
    partial class FrmAgregarProveedores
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
            btnModificarProveedor = new Button();
            btnProveedor = new Button();
            btnGuardarProveedor = new Button();
            txtId_Proveedor = new TextBox();
            txtProveedor_Nombre = new TextBox();
            txtProveedor_Empresa = new TextBox();
            txtProveedor_Telefono = new TextBox();
            txtProveedor_Correo = new TextBox();
            txtProveedor_Direccion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId_Producto2 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnModificarProveedor
            // 
            btnModificarProveedor.Location = new Point(514, 34);
            btnModificarProveedor.Name = "btnModificarProveedor";
            btnModificarProveedor.Size = new Size(112, 34);
            btnModificarProveedor.TabIndex = 0;
            btnModificarProveedor.Text = "Modificar";
            btnModificarProveedor.UseVisualStyleBackColor = true;
            btnModificarProveedor.Click += btnModificarProveedor_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.Location = new Point(645, 34);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(112, 34);
            btnProveedor.TabIndex = 1;
            btnProveedor.Text = "Eliminar";
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btnGuardarProveedor
            // 
            btnGuardarProveedor.Location = new Point(396, 34);
            btnGuardarProveedor.Name = "btnGuardarProveedor";
            btnGuardarProveedor.Size = new Size(112, 34);
            btnGuardarProveedor.TabIndex = 2;
            btnGuardarProveedor.Text = "Guardar";
            btnGuardarProveedor.UseVisualStyleBackColor = true;
            btnGuardarProveedor.Click += btnGuardarProveedor_Click;
            // 
            // txtId_Proveedor
            // 
            txtId_Proveedor.Location = new Point(205, 31);
            txtId_Proveedor.Name = "txtId_Proveedor";
            txtId_Proveedor.Size = new Size(150, 31);
            txtId_Proveedor.TabIndex = 3;
            // 
            // txtProveedor_Nombre
            // 
            txtProveedor_Nombre.Location = new Point(205, 81);
            txtProveedor_Nombre.Name = "txtProveedor_Nombre";
            txtProveedor_Nombre.Size = new Size(150, 31);
            txtProveedor_Nombre.TabIndex = 4;
            // 
            // txtProveedor_Empresa
            // 
            txtProveedor_Empresa.Location = new Point(205, 132);
            txtProveedor_Empresa.Name = "txtProveedor_Empresa";
            txtProveedor_Empresa.Size = new Size(150, 31);
            txtProveedor_Empresa.TabIndex = 5;
            // 
            // txtProveedor_Telefono
            // 
            txtProveedor_Telefono.Location = new Point(205, 187);
            txtProveedor_Telefono.Name = "txtProveedor_Telefono";
            txtProveedor_Telefono.Size = new Size(150, 31);
            txtProveedor_Telefono.TabIndex = 6;
            // 
            // txtProveedor_Correo
            // 
            txtProveedor_Correo.Location = new Point(205, 240);
            txtProveedor_Correo.Name = "txtProveedor_Correo";
            txtProveedor_Correo.Size = new Size(150, 31);
            txtProveedor_Correo.TabIndex = 7;
            // 
            // txtProveedor_Direccion
            // 
            txtProveedor_Direccion.Location = new Point(205, 297);
            txtProveedor_Direccion.Name = "txtProveedor_Direccion";
            txtProveedor_Direccion.Size = new Size(150, 31);
            txtProveedor_Direccion.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 37);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 9;
            label1.Text = "Id Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 87);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 10;
            label2.Text = "Proveedor Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 135);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 11;
            label3.Text = "Proveedor Empresa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 187);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 12;
            label4.Text = "Proveedor  Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 243);
            label5.Name = "label5";
            label5.Size = new Size(153, 25);
            label5.TabIndex = 13;
            label5.Text = "Proveedor Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 300);
            label6.Name = "label6";
            label6.Size = new Size(172, 25);
            label6.TabIndex = 14;
            label6.Text = "Proveedor Direccion";
            // 
            // txtId_Producto2
            // 
            txtId_Producto2.Location = new Point(205, 365);
            txtId_Producto2.Name = "txtId_Producto2";
            txtId_Producto2.Size = new Size(150, 31);
            txtId_Producto2.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 365);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 16;
            label7.Text = "Id Producto";
            // 
            // FrmAgregarProveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(txtId_Producto2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProveedor_Direccion);
            Controls.Add(txtProveedor_Correo);
            Controls.Add(txtProveedor_Telefono);
            Controls.Add(txtProveedor_Empresa);
            Controls.Add(txtProveedor_Nombre);
            Controls.Add(txtId_Proveedor);
            Controls.Add(btnGuardarProveedor);
            Controls.Add(btnProveedor);
            Controls.Add(btnModificarProveedor);
            Name = "FrmAgregarProveedores";
            Text = "Form2";
            Load += FrmAgregarProveedores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificarProveedor;
        private Button btnProveedor;
        private Button btnGuardarProveedor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public TextBox txtId_Proveedor;
        public TextBox txtProveedor_Nombre;
        public TextBox txtProveedor_Empresa;
        public TextBox txtProveedor_Telefono;
        public TextBox txtProveedor_Correo;
        public TextBox txtProveedor_Direccion;
        public TextBox txtId_Producto2;
    }
}
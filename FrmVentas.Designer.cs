namespace integra_1
{
    partial class FrmVentas
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
            btnAgregar_Venta = new Button();
            btnImprimir_Ticket = new Button();
            txtAgregar_Id_Producto = new TextBox();
            dgvCarrito = new DataGridView();
            Id_Producto = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            lblTotal_a_Pagar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar_Venta
            // 
            btnAgregar_Venta.Location = new Point(432, 268);
            btnAgregar_Venta.Name = "btnAgregar_Venta";
            btnAgregar_Venta.Size = new Size(112, 34);
            btnAgregar_Venta.TabIndex = 0;
            btnAgregar_Venta.Text = "Agregar";
            btnAgregar_Venta.UseVisualStyleBackColor = true;
            btnAgregar_Venta.Click += btnAgregar_Producto_Venta_Click;
            // 
            // btnImprimir_Ticket
            // 
            btnImprimir_Ticket.Location = new Point(543, 487);
            btnImprimir_Ticket.Name = "btnImprimir_Ticket";
            btnImprimir_Ticket.Size = new Size(150, 69);
            btnImprimir_Ticket.TabIndex = 1;
            btnImprimir_Ticket.Text = "Cobrar e imprimir Ticket";
            btnImprimir_Ticket.UseVisualStyleBackColor = true;
            btnImprimir_Ticket.Click += btnImprimir_Ticket_Click;
            // 
            // txtAgregar_Id_Producto
            // 
            txtAgregar_Id_Producto.Location = new Point(179, 180);
            txtAgregar_Id_Producto.Name = "txtAgregar_Id_Producto";
            txtAgregar_Id_Producto.Size = new Size(150, 31);
            txtAgregar_Id_Producto.TabIndex = 2;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { Id_Producto, Nombre, Precio, Cantidad, Subtotal });
            dgvCarrito.Location = new Point(316, 348);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.Size = new Size(664, 66);
            dgvCarrito.TabIndex = 3;
            dgvCarrito.CellContentClick += dgvCarrito_CellContentClick;
            // 
            // Id_Producto
            // 
            Id_Producto.HeaderText = "Id";
            Id_Producto.MinimumWidth = 8;
            Id_Producto.Name = "Id_Producto";
            Id_Producto.ReadOnly = true;
            Id_Producto.Visible = false;
            Id_Producto.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Producto";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 8;
            Precio.Name = "Precio";
            Precio.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cant.";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 150;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 8;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 150;
            // 
            // lblTotal_a_Pagar
            // 
            lblTotal_a_Pagar.AutoSize = true;
            lblTotal_a_Pagar.Location = new Point(774, 277);
            lblTotal_a_Pagar.Name = "lblTotal_a_Pagar";
            lblTotal_a_Pagar.Size = new Size(114, 25);
            lblTotal_a_Pagar.TabIndex = 4;
            lblTotal_a_Pagar.Text = "Total a pagar";
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 631);
            Controls.Add(lblTotal_a_Pagar);
            Controls.Add(dgvCarrito);
            Controls.Add(txtAgregar_Id_Producto);
            Controls.Add(btnImprimir_Ticket);
            Controls.Add(btnAgregar_Venta);
            Name = "FrmVentas";
            Text = "Form2";
            Load += FrmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar_Venta;
        private Button btnImprimir_Ticket;
        private TextBox txtAgregar_Id_Producto;
        private DataGridView dgvCarrito;
        private Label lblTotal_a_Pagar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Id_Producto;
    }
}
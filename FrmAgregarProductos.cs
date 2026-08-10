using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace integra_1
{
    public partial class FrmAgregarProductos : Form
    {
        public bool EsEdicion = false;

        public FrmAgregarProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // Boton Guardar
        {
            string nombre = txtNombre_Producto.Text;
            string IDProducto = txtId_Producto.Text;
            string marca = txtMarca_Producto.Text;
            string cantidad = txtCantidad_Producto.Text;
            string precio = txtPrecio_Producto.Text;

            if(nombre == "")
            {
                MessageBox.Show("Ingresa el nombre producto");
                return;
            }

            if(IDProducto == "")
            {
                MessageBox.Show("Ingresa ID_Producto");
                return;
            }

            if(marca == "")
            {
                MessageBox.Show("Ingresa la marca del producto");
                return;
            }

            if(cantidad == "")
            {
                MessageBox.Show("Ingresa la cantidad disponible");
                return;
            }

            if(precio == "")
            {
                MessageBox.Show("Ingresa precio del producto");
                return;
            }

            string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

            string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            using (OleDbConnection conexionBase = new OleDbConnection(seguirRuta))
            {
                conexionBase.Open();

                string instruccion = @"INSERT INTO Productos (Nombre_Producto, Marca_Producto, Precio_Producto, Cantidad_Producto, Id_Producto) 
                                                      VALUES (@Nombre, @Marca, @Precio, @Cantidad, @ID)";

                OleDbCommand ejecutar = new OleDbCommand(instruccion, conexionBase);

                ejecutar.Parameters.AddWithValue("@Nombre", nombre);
                ejecutar.Parameters.AddWithValue("@Marca", marca);
                ejecutar.Parameters.AddWithValue("@Precio", precio);
                ejecutar.Parameters.AddWithValue("@Cantidad", cantidad);
                ejecutar.Parameters.AddWithValue("@ID", IDProducto);

                ejecutar.ExecuteNonQuery();

                MessageBox.Show("Se ha agregado producto");
            }

        }

        private void button3_Click(object sender, EventArgs e) // Button Modificar/Editar
        {
            string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

            string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            using (OleDbConnection conexionBase = new OleDbConnection(seguirRuta))
            {
                conexionBase.Open();

                string instruccion = @"UPDATE Productos SET 
                               Nombre_Producto = @Nombre,
                               Marca_Producto = @Marca,
                               Precio_Producto = @Precio,
                               Cantidad_Producto = @Cantidad
                               WHERE Id_Producto = @ID";

                OleDbCommand ejecutar = new OleDbCommand(instruccion, conexionBase);

                ejecutar.Parameters.AddWithValue("@Nombre", txtNombre_Producto.Text);
                ejecutar.Parameters.AddWithValue("@Marca", txtMarca_Producto.Text);
                ejecutar.Parameters.AddWithValue("@Precio", txtPrecio_Producto.Text);
                ejecutar.Parameters.AddWithValue("@Cantidad", txtCantidad_Producto.Text);
                ejecutar.Parameters.AddWithValue("@ID", txtId_Producto.Text);

                int filasModificadas = ejecutar.ExecuteNonQuery();

                if (filasModificadas > 0)
                {
                    MessageBox.Show("Se ha modificado la información del producto");
                }
                else
                {
                    MessageBox.Show("No se encontró el producto.");
                }
            }
        }



        private void FrmAgregarProductos_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Inicio_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.Show();
            this.Hide();
        }


        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores();
            frm.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();
            frm.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes();
            frm.Show();
            this.Hide();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda frm = new FrmAyuda();
            frm.Show();

            this.Hide();
        }

        private void btnCerrar_Sesion_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();

            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbId_Proveedor_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.Show();
            this.Hide();
        }

        private void btnProveedores_Click_1(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores();
            frm.Show();
            this.Hide();
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();
            frm.Show();
            this.Hide();
        }

        private void btnAyuda_Click_1(object sender, EventArgs e)
        {
            FrmAyuda frm = new FrmAyuda();
            frm.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

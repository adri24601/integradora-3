using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace integra_1
{
    public partial class FrmDashboard : Form
    {


        public FrmDashboard()
        {
            InitializeComponent();
        }


        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            MostrarProveedores();
        }

        private void FrmDashboard_Activated_1(object sender, EventArgs e)
        {
            ActualizarAlertaStock();
        }

        private void pictureBoxAlertas_Click(object sender, EventArgs e)
        {
            MostrarProductosStockMinimo();
        }
        private void picProductos_Click(object sender, EventArgs e)
        {

        }

        private void picProveedores_Click(object sender, EventArgs e)
        {

        }

        private void MostrarProductos()
        {
            string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

            string seguirRuta =
                $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            using (OleDbConnection conexionBase =
                   new OleDbConnection(seguirRuta))
            {
                conexionBase.Open();

                string consultaTabla = "SELECT COUNT(*) FROM Productos";

                OleDbCommand ejecutar = new OleDbCommand(consultaTabla, conexionBase);

                int totalProductos = Convert.ToInt32(ejecutar.ExecuteScalar());

                lbCantidadProductos.Text = "Hay " + totalProductos + " tipos de productos en el inventario";
            }
        }

        private void MostrarProveedores()
        {
            string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

            string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            using (OleDbConnection conexionBase = new OleDbConnection(seguirRuta))
            {
                conexionBase.Open();

                string consultarTabla = "SELECT COUNT(*) FROM Proveedores";

                OleDbCommand ejecutar = new OleDbCommand(consultarTabla, conexionBase);

                int totalProveedores = Convert.ToInt32(ejecutar.ExecuteScalar());

                lbCantidadProveedores.Text = "Hay " + totalProveedores + " proveedores registrados";
            }
        }


        private void btnGuardarStockMinimo_Click(object sender, EventArgs e)
        {
            string stockMinimo = texStockMinimo.Text;

            if (stockMinimo == "")
            {
                MessageBox.Show("Ingrese el stock mínimo");
                return;
            }

            string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

            string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            using (OleDbConnection conexionBase = new OleDbConnection(seguirRuta))
            {
                conexionBase.Open();

                string insertarValor = "UPDATE Tienda SET Stock_minimo = ?";

                OleDbCommand ejecutar = new OleDbCommand(insertarValor, conexionBase);

                ejecutar.Parameters.AddWithValue("?", stockMinimo);

                ejecutar.ExecuteNonQuery();

                MessageBox.Show("Stock mínimo guardado");
            }
        }

        private void MostrarProductosStockMinimo()
        {
            string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

            string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            string consulta = @"SELECT Nombre_Producto, Cantidad_Producto
                                FROM Productos, Tienda
                                WHERE Cantidad_Producto <= Stock_minimo";

            using (OleDbConnection conexionBase = new OleDbConnection(seguirRuta))
            {
                conexionBase.Open();

                OleDbCommand ejecutar = new OleDbCommand(consulta, conexionBase);

                OleDbDataReader lector = ejecutar.ExecuteReader();

                string productos = "";

                int cantidadProductos = 0;

                while (lector.Read())
                {
                    string nombreProducto = lector["Nombre_Producto"].ToString();

                    string cantidad = lector["Cantidad_Producto"].ToString();

                    productos += nombreProducto + " - Cantidad: " + cantidad + "\n";

                    cantidadProductos++;
                }

                // Mostrar cantidad en el Label
                lbAlertaStock.Text = cantidadProductos + " productos se encuentran en stock mínimo";

                // Mostrar los productos al hacer clic
                if (productos != "")
                {
                    MessageBox.Show("Productos con stock mínimo:\n\n" + productos);
                }
                else
                {
                    MessageBox.Show("No hay productos con stock mínimo");
                }
            }

            ActualizarAlertaStock();

        }


        private void ActualizarAlertaStock()
        {
            string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

            string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            string consulta = @"SELECT COUNT(*)
                                FROM Productos, Tienda
                                WHERE Cantidad_Producto <= Stock_minimo";

            using (OleDbConnection conexionBase = new OleDbConnection(seguirRuta))
            {
                conexionBase.Open();

                OleDbCommand ejecutar = new OleDbCommand(consulta, conexionBase);

                int cantidadProductos = Convert.ToInt32(ejecutar.ExecuteScalar());

                lbAlertaStock.Text = cantidadProductos + " productos se encuentran en stock mínimo";
            }
        }


        private void picBoxUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario abrir = new FrmUsuario();
            abrir.Show();

            abrir.lb_idTienda.Visible = false;
            abrir.lb_idTienda.Enabled = false;

            abrir.txtID_Tienda.Visible = false;
            abrir.txtID_Tienda.Enabled = false;

        }











































        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores();
            frm.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();
            frm.Show();
            this.Hide();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
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


        private void cuiPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void picBoxApartados_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al sistema de control de inventario");
        }
    }
}


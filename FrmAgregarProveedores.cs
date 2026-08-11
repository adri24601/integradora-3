using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace integra_1
{
    public partial class FrmAgregarProveedores : Form
    {
        public bool EsEdicion = false;
        public FrmAgregarProveedores()
        {
            InitializeComponent();
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            string nombre = txtProveedor_Nombre.Text;
            string IDProveedor = txtId_Proveedor.Text;
            string empresa = txtProveedor_Empresa.Text;
            string telefono = txtProveedor_Telefono.Text;
            string correo = txtProveedor_Correo.Text;
            string direccion = txtProveedor_Direccion.Text;
            string IDProducto = txtId_Productos.Text;

            if (nombre == "")
            {
                MessageBox.Show("Ingresa el nombre del proveedor");
                return;
            }

            if (empresa == "")
            {
                MessageBox.Show("Ingresa la empresa del proveedor");
                return;
            }

            if (telefono == "")
            {
                MessageBox.Show("Ingresa el teléfono del proveedor");
                return;
            }

            if (correo == "")
            {
                MessageBox.Show("Ingresa el correo del proveedor");
                return;
            }

            if (direccion == "")
            {
                MessageBox.Show("Ingresa la dirección del proveedor");
                return;
            }

            if (IDProducto == "")
            {
                MessageBox.Show("Ingresa ID_Producto");
                return;
            }

            string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

            string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            using (OleDbConnection conexionBase = new OleDbConnection(seguirRuta))
            {
                conexionBase.Open();

                string instruccion = @"INSERT INTO Proveedores (Proveedor_Nombre, Proveedor_Empresa, Proveedor_Telefono, Proveedor_Correo, Proveedor_Direccion, Id_Producto)
                                                   VALUES (@Nombre, @Empresa, @Telefono, @Correo, @Direccion, @IDProducto)";

                OleDbCommand ejecutar = new OleDbCommand(instruccion, conexionBase);

                ejecutar.Parameters.AddWithValue("@Nombre", nombre);
                ejecutar.Parameters.AddWithValue("@Empresa", empresa);
                ejecutar.Parameters.AddWithValue("@Telefono", telefono);
                ejecutar.Parameters.AddWithValue("@Correo", correo);
                ejecutar.Parameters.AddWithValue("@Direccion", direccion);
                ejecutar.Parameters.AddWithValue("@IDProducto", IDProducto);

                ejecutar.ExecuteNonQuery();

                MessageBox.Show("Se ha agregado proveedor");
            }
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId_Proveedor.Text))
            {
                MessageBox.Show("Seleccione la ID del proveedor que desea modificar");
                return;
            }

            string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

            string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            using (OleDbConnection conexionBase = new OleDbConnection(seguirRuta))
            {
                conexionBase.Open();

                string instruccion = @"UPDATE Proveedores SET 
                       Proveedor_Nombre = @Nombre,
                       Proveedor_Empresa = @Empresa,
                       Proveedor_Telefono = @Telefono,
                       Proveedor_Correo = @Correo,
                       Proveedor_Direccion = @Direccion, 
                       Id_Producto = @IDProducto
                       WHERE Id_Proveedor = @ID";

                OleDbCommand ejecutar = new OleDbCommand(instruccion, conexionBase);

                ejecutar.Parameters.AddWithValue("@Nombre", txtProveedor_Nombre.Text);
                ejecutar.Parameters.AddWithValue("@Empresa", txtProveedor_Empresa.Text);
                ejecutar.Parameters.AddWithValue("@Telefono", txtProveedor_Telefono.Text);
                ejecutar.Parameters.AddWithValue("@Correo", txtProveedor_Correo.Text);
                ejecutar.Parameters.AddWithValue("@Direccion", txtProveedor_Direccion.Text);
                ejecutar.Parameters.AddWithValue("@IDProducto", txtId_Productos.Text);
                ejecutar.Parameters.AddWithValue("@ID", txtId_Proveedor.Text);

                int filasModificadas = ejecutar.ExecuteNonQuery();

                if (filasModificadas > 0)
                {
                    MessageBox.Show("Se ha modificado la información del proveedor");
                }
                else
                {
                    MessageBox.Show("No se encontró el proveedor.");
                }
            }
        }



        private void FrmAgregarProveedores_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
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

        private void picBoxCerrarPanell_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

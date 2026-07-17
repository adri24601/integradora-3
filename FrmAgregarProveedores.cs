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
        public FrmAgregarProveedores()
        {
            InitializeComponent();
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            // 1. Validar que no dejen ningún campo vacío
            if (string.IsNullOrEmpty(txtId_Proveedor.Text) || string.IsNullOrEmpty(txtProveedor_Nombre.Text) ||
                string.IsNullOrEmpty(txtProveedor_Empresa.Text) || string.IsNullOrEmpty(txtProveedor_Telefono.Text) ||
                string.IsNullOrEmpty(txtProveedor_Correo.Text) || string.IsNullOrEmpty(txtProveedor_Direccion.Text) ||
                string.IsNullOrEmpty(txtId_Producto2.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos necesarios.");
                return;
            }

            // RUTA DE BASE DE DATOS

            string ruta = Path.Combine(Application.StartupPath, "integradora boceto.accdb");

            string cadenaConexion = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";


            // 3. Consulta SQL completa con los 4 campos (los signos '?' se sustituyen en orden exacto abajo)
            string consulta = "INSERT INTO Proveedores ([Id_Proveedor], [Proveedor_Nombre], [Proveedor_Empresa], [Proveedor_Telefono], [Proveedor_Correo], [Proveedor_Direccion], [Id_Producto]) VALUES (?, ?, ?, ?, ?, ?, ?);";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        // Pasamos los parámetros en el mismo orden que aparecen en el INSERT
                        comando.Parameters.AddWithValue("@id_proveedor", Convert.ToInt32(txtId_Proveedor.Text));
                        comando.Parameters.AddWithValue("@nombre_proveedor", txtProveedor_Nombre.Text);
                        comando.Parameters.AddWithValue("@empresa_proveedor", txtProveedor_Empresa.Text);
                        comando.Parameters.AddWithValue("@telefono_proveedor", txtProveedor_Telefono.Text);
                        comando.Parameters.AddWithValue("@correo_proveedor", txtProveedor_Correo.Text);
                        comando.Parameters.AddWithValue("@direccion_proveedor", txtProveedor_Direccion.Text);
                        comando.Parameters.AddWithValue("@id_producto", Convert.ToInt32(txtId_Producto2.Text));

                        conexion.Open();
                        comando.ExecuteNonQuery(); // Guarda la fila completa en Access

                        MessageBox.Show("¡Producto agregado con éxito con toda su información!");

                        this.Close(); // Cierra la ventana de captura al terminar
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar toda la información: " + ex.Message);
            }
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminar este producto de la base de datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.No) return;

            // RUTA DE BASE DE DATOS

            string ruta = Path.Combine(Application.StartupPath, "integradora boceto.accdb");

            string cadenaConexion = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            string consulta = "DELETE FROM Proveedores WHERE Id_Proveedor = ?";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        // Solo dejamos el parámetro que pide el '?' de la consulta anterior
                        comando.Parameters.AddWithValue("@id_proveedor", Convert.ToInt32(txtId_Proveedor.Text));

                        conexion.Open();
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Producto eliminado con éxito."); // Nota: Si es la sección de proveedores, quizás quieras cambiar el texto a "Proveedor eliminado con éxito."
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void FrmAgregarProveedores_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores();
            frm.Show();
            this.Hide();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

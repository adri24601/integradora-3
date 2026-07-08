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
    public partial class FrmAgregarProductos : Form
    {
        public FrmAgregarProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Validar que no dejen ningún campo vacío
            if (string.IsNullOrEmpty(txtNombre_Producto.Text) || string.IsNullOrEmpty(txtMarca_Producto.Text) ||
                string.IsNullOrEmpty(txtPrecio_Producto.Text) || string.IsNullOrEmpty(txtImagen.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos necesarios.");
                return;
            }

            // 2. Tu ruta absoluta que ya está probada
            string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\adria\Desktop\integradora00\integradora avanzada media\integradora boceto.accdb;";

            // 3. Consulta SQL completa con los 4 campos (los signos '?' se sustituyen en orden exacto abajo)
            string consulta = "INSERT INTO Productos (Id_Producto, Nombre_Producto, Marca_Producto, Precio_Producto, Imagen_Producto) VALUES (?, ?, ?, ?, ?)";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        // Pasamos los parámetros en el mismo orden que aparecen en el INSERT
                        comando.Parameters.AddWithValue("@id_producto", Convert.ToInt32(txtId_Producto.Text));
                        comando.Parameters.AddWithValue("@nombre_producto", txtNombre_Producto.Text);
                        comando.Parameters.AddWithValue("@marca_producto", txtMarca_Producto.Text);

                        // Convertimos el texto del precio a número decimal/entero para que Access lo guarde bien
                        comando.Parameters.AddWithValue("@precio_producto", Convert.ToDecimal(txtPrecio_Producto.Text));

                        // Por ahora pasamos el texto de la imagen (como "arroz.png" o el link)
                        comando.Parameters.AddWithValue("@imagen_producto", txtImagen.Text);

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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminar este producto de la base de datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.No) return;

            string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\adria\Desktop\integradora00\integradora avanzada media\integradora boceto.accdb;";
            string consulta = "DELETE FROM Productos WHERE Id_Producto = ?";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_producto", Convert.ToInt32(txtId_Producto.Text));

                        conexion.Open();
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Producto eliminado con éxito.");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void FrmAgregarProductos_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Sesion_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                    }
    }
}

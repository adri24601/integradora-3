using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Web;

namespace integra_1
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            //ruta 
            string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\adria\Desktop\integradora00\integradora avanzada media\integradora boceto.accdb;";
            //consulta a SQL para traer los "productos"
            // En lugar de usar el asterisco (*), escribe las columnas de texto y números separadas por comas
            string consulta = "SELECT * FROM Productos";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    //adaptador sirve como puente , hace la consulta y se enarga de abrir/cerrar la conexion solo
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);

                    //creamos tabla en memoria para guardar lo que traiga Access
                    System.Data.DataTable tablaProductos = new System.Data.DataTable();

                    // Llenamos la tabla en memoria con los datos
                    adaptador.Fill(tablaProductos);

                    //decir a DataGridView que su fuente de datos es la tabla de acces
                    dgvProductos.DataSource = tablaProductos;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos:  " + ex.Message);
            }

        }

        private void dgvProductos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Esto le dice al DataGridView: "Si encuentras una imagen extraña, no lances nigun cartel de error"
            e.ThrowException = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Asegúrate de que el nombre coincida letra por letra con tu nuevo Form
            FrmAgregarProductos ventanaAgregar = new FrmAgregarProductos();
            ventanaAgregar.ShowDialog();

            // Si ya tienes el método para actualizar la tabla, llámalo aquí abajo:

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            // 1. Validamos que haya una fila seleccionada en tu tabla
            if (dgvProductos.CurrentRow != null)
            {
                // 2. Creamos la instancia usando el nombre real de tu ventana
                FrmAgregarProductos ventanaEdicion = new FrmAgregarProductos();

                // 3. Rellenamos los campos de la ventana emergente con lo seleccionado en la tabla
                // (Revisa que los nombres de las celdas ["Id_Producto"], etc., sean exactamente los de tu Access)
                ventanaEdicion.txtId_Producto.Text = dgvProductos.CurrentRow.Cells["Id_Producto"].Value.ToString();
                ventanaEdicion.txtNombre_Producto.Text = dgvProductos.CurrentRow.Cells["Nombre_Producto"].Value.ToString();
                ventanaEdicion.txtMarca_Producto.Text = dgvProductos.CurrentRow.Cells["Marca_Producto"].Value.ToString();
                ventanaEdicion.txtPrecio_Producto.Text = dgvProductos.CurrentRow.Cells["Precio_Producto"].Value.ToString();
                ventanaEdicion.txtImagen.Text = dgvProductos.CurrentRow.Cells["Imagen_Producto"].Value.ToString();

                // 4. Mostramos la ventana llena con los datos
                ventanaEdicion.ShowDialog();

                // 5. Al cerrarse, refresca la tabla automáticamente para ver los cambios

            }
            else
            {
                MessageBox.Show("Por favor, selecciona primero un producto de la tabla gris.");
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

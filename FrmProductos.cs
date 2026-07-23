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

        // CREACIÓN DE "METODO" PARA CARGAR PRODUCTO
        private void CargarProducto()
        {
            // ESTRABLECER RUTA BASE DE DATOS (NO FIJA)
            string ruta = Path.Combine(Application.StartupPath, "integradora boceto.accdb");

            string cadenaConexion = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

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


        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProducto(); // METODO
        }

        private void dgvProductos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Esto le dice al DataGridView: "Si encuentras una imagen extraña, no lances nigun cartel de error"
            e.ThrowException = false;
        }

        private void button1_Click(object sender, EventArgs e)  // FrmAgregarProducto
        {
            // Asegúrate de que el nombre coincida letra por letra con tu nuevo Form
            FrmAgregarProductos ventanaAgregar = new FrmAgregarProductos();
            ventanaAgregar.ShowDialog();

            // Si ya tienes el método para actualizar la tabla, llámalo aquí abajo:

            CargarProducto();

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            FrmAgregarProductos ventana = new FrmAgregarProductos();

            // Indicar que es una modificación
            ventana.EsEdicion = true;

            // Pasar los datos al formulario
            ventana.txtId_Producto.Text = dgvProductos.CurrentRow.Cells["Id_Producto"].Value.ToString();
            ventana.txtNombre_Producto.Text = dgvProductos.CurrentRow.Cells["Nombre_Producto"].Value.ToString();
            ventana.txtMarca_Producto.Text = dgvProductos.CurrentRow.Cells["Marca_Producto"].Value.ToString();
            ventana.txtPrecio_Producto.Text = dgvProductos.CurrentRow.Cells["Precio_Producto"].Value.ToString();
            ventana.txtCantidad_Producto.Text = dgvProductos.CurrentRow.Cells["Cantidad_Producto"].Value.ToString();
            ventana.txtImagen.Text = dgvProductos.CurrentRow.Cells["Imagen_Producto"].Value.ToString();
            ventana.txtId_Proveedor.Text = dgvProductos.CurrentRow.Cells["Id_Proveedor"].Value.ToString();
            ventana.ShowDialog();

            // Recargar la tabla
            CargarProducto();

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

            // Se asegura de que el produto haya sido seleccionado al precionar el boton
            // Se ejucuta si el producto no se ha seleccionado
            if(dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }


            // Pregunta si desea eliminar el producto
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar este producto?", "Eliminar", MessageBoxButtons.YesNo);
           


            // Al seleccionar "SI"
            if(respuesta == DialogResult.Yes)
            {
                // 1. Establecer ruta de la base de datos 
                string ruta = Path.Combine(Application.StartupPath, "integradora boceto.accdb");

                // 2. Realizar conexión con ACESS con la ruta
                string cadenaConexion = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

                MessageBox.Show(ruta);

                // 3. Establece donde se encuentra la base de datos
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    // 4. Abre la conexión
                    conexion.Open();

                    // 4. Se establece la variable consulta para eliminar producto de la base de datos (consultando la tabla usando la Id_Producto)
                    string consulta = " DELETE FROM Productos WHERE Id_Producto = ? ";

                    // 5. Ejecuta la consulta
                    OleDbCommand comando = new OleDbCommand(consulta, conexion);

                    // 6. Toma la Id del producto a eliminar
                    comando.Parameters.AddWithValue("Id_Producto",dgvProductos.CurrentRow.Cells["Id_Producto"].Value);

                    // 7. Ejecuta la eliminación
                    comando.ExecuteNonQuery();
                }

                // Confirmación de eliminación
                MessageBox.Show("Producto eliminado del sistema");

                CargarProducto();
            }


        }


        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





    }
}

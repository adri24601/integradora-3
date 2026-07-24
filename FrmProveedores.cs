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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        // 1. Creamos la función que limpia y vuelve a rellenar la tabla
        private void CargarProveedores() // LISTO
        {
            // RUTA DE BASE DE DATOS

            string ruta = Path.Combine(Application.StartupPath, "integradora boceto.accdb");

            string cadenaConexion = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            string consulta = "SELECT * FROM Proveedores";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    // adaptador sirve como puente, hace la consulta, y se encarga de abir y cerrar la conexión
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);

                    // creamos tabla en memorio para guardar lo que traiga Access
                    System.Data.DataTable tablaProveedores = new System.Data.DataTable();

                    // Llenamos la tabla de memoria con los datos
                    adaptador.Fill(tablaProveedores);

                    // Le decimos a dgvProveedores que su fuente de datos es la tabla de Access
                    dgvProveedores.DataSource = tablaProveedores;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }

        }
        private void FrmProveedores_Load(object sender, EventArgs e) // LISTO
        {
            CargarProveedores();

        }

        private void button1_Click(object sender, EventArgs e) // Boton Modificar
        {
            // 1. Validamos que haya una fila seleccionada en tu tabla
            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un proveedor");
                return;
            }

            FrmAgregarProveedores ventana = new FrmAgregarProveedores();

            // Indicar que es una modificación 
            ventana.EsEdicion = true;

            ventana.txtId_Proveedor.Text = dgvProveedores.CurrentRow.Cells["Id_Proveedor"].Value.ToString();
            ventana.txtProveedor_Nombre.Text = dgvProveedores.CurrentRow.Cells["Proveedor_Nombre"].Value.ToString();
            ventana.txtProveedor_Empresa.Text = dgvProveedores.CurrentRow.Cells["Proveedor_Empresa"].Value.ToString();
            ventana.txtProveedor_Telefono.Text = dgvProveedores.CurrentRow.Cells["Proveedor_Telefono"].Value.ToString();
            ventana.txtProveedor_Correo.Text = dgvProveedores.CurrentRow.Cells["Proveedor_Correo"].Value.ToString();
            ventana.txtProveedor_Direccion.Text = dgvProveedores.CurrentRow.Cells["Proveedor_Direccion"].Value.ToString();


            ventana.ShowDialog();

            // Recargar la tabla
            CargarProveedores();


        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)  // Boton AgregarProveedor
        {
            FrmAgregarProveedores ventanaAgregar = new FrmAgregarProveedores();
            ventanaAgregar.ShowDialog();

            // Metodo para ACTUALIZAR LA TABLA
            CargarProveedores();

        }

        private void btnEliminar_Proveedor_Click(object sender, EventArgs e) // Boton Eliminar
        {
            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Selecciona el proveedor");
                return;

            }

            // Pregunta si desea eliminar el proveedor seleccionado
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar este proveedor?", "Eliminar", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                // RUTA DE BASE DE DATOS

                // 1. Establecer la ruta de la base de datos
                string ruta = Path.Combine(Application.StartupPath, "integradora boceto.accdb");

                // 2. Realizar la conexión con ACESS usando la ruta
                string cadenaConexion = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

                MessageBox.Show(ruta);

                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    // 4. Abre la conexión
                    conexion.Open();

                    // 5. 
                    string consulta = "DELETE FROM Proveedores WHERE Id_Proveedor = ? ";

                    // 6. Ejecuta la consulta
                    OleDbCommand comando = new OleDbCommand(consulta, conexion);

                    // 7. Toma la ID del producto a eliminar
                    comando.Parameters.AddWithValue("Id_Proveedor", dgvProveedores.CurrentRow.Cells["Id_Proveedor"].Value);

                    // 8. Ejecuta la eliminación
                    comando.ExecuteNonQuery();
                }

                // Confirmar eliminación
                MessageBox.Show("Proveedor eliminado del sistema");

                CargarProveedores();
            }

        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e) // Boton Productos
        {
            FrmProductos frm = new FrmProductos();
            frm.Show();
            this.Hide();
        }

        private void btnMenu_Inicio_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
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

        private void btnInicio_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

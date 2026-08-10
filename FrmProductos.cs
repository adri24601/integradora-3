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

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProducto(); // METODO
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CargarProducto()
        {
            string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

            string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            string consulta = "SELECT * FROM Productos";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(seguirRuta))
                {
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);

                    System.Data.DataTable tablaProductos = new System.Data.DataTable();

                    adaptador.Fill(tablaProductos);
                    
                    dgvProductos.DataSource = tablaProductos;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar dgv:  " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)  // FrmAgregarProducto
        {
            FrmAgregarProductos abrir = new FrmAgregarProductos();

            abrir.btnModificar_Producto.Visible = false;
            abrir.btnModificar_Producto.Enabled = false;
            abrir.ShowDialog();

            CargarProducto();

        }

        private void dgvProductos_DataError(object sender, EventArgs e)
        {

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            FrmAgregarProductos abrir = new FrmAgregarProductos();

            abrir.btnGuardar.Visible = false;
            abrir.btnGuardar.Enabled = false;

            abrir.EsEdicion = true;

            abrir.txtId_Producto.Text = dgvProductos.CurrentRow.Cells["Id_Producto"].Value.ToString();
            abrir.txtNombre_Producto.Text = dgvProductos.CurrentRow.Cells["Nombre_Producto"].Value.ToString();
            abrir.txtMarca_Producto.Text = dgvProductos.CurrentRow.Cells["Marca_Producto"].Value.ToString();
            abrir.txtPrecio_Producto.Text = dgvProductos.CurrentRow.Cells["Precio_Producto"].Value.ToString();
            abrir.txtCantidad_Producto.Text = dgvProductos.CurrentRow.Cells["Cantidad_Producto"].Value.ToString();

            abrir.ShowDialog();

            // Recargar la tabla
            CargarProducto();

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea eliminar este producto?", "Eliminar", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

                string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

                using (OleDbConnection conexionBase = new OleDbConnection(seguirRuta))
                {
                    conexionBase.Open();

                    string consulta = " DELETE FROM Productos WHERE Id_Producto = ? ";

                    OleDbCommand comando = new OleDbCommand(consulta, conexionBase);

                    comando.Parameters.AddWithValue("Id_Producto", dgvProductos.CurrentRow.Cells["Id_Producto"].Value);

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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores();
            frm.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e) // Ventas
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
    }
}

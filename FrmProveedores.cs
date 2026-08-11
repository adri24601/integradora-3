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


        private void CargarProveedores()
        {
            string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

            string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            string consulta = "SELECT * FROM Proveedores";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(seguirRuta))
                {
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);

                    System.Data.DataTable tablaProveedores = new System.Data.DataTable();

                    adaptador.Fill(tablaProveedores);

                    tablaProveedores.Columns["Id_Proveedor"].ColumnName = "Id_Proveedor";
                    tablaProveedores.Columns["Proveedor_Nombre"].ColumnName = "Nombre";
                    tablaProveedores.Columns["Proveedor_Empresa"].ColumnName = "Empresa";
                    tablaProveedores.Columns["Proveedor_Telefono"].ColumnName = "Telefono";
                    tablaProveedores.Columns["Proveedor_Correo"].ColumnName = "Correo";
                    tablaProveedores.Columns["Proveedor_Direccion"].ColumnName = "Direccion";
                    tablaProveedores.Columns["Id_Producto"].ColumnName = "Id_Producto";

                    dgvProveedores.DataSource = tablaProveedores;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar dgv:  " + ex.Message);
            }
        }

        private void FrmProveedores_Load(object sender, EventArgs e) // LISTO
        {
            CargarProveedores();

        }

        private void button1_Click(object sender, EventArgs e) // Boton Modificar
        {
            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un proveedor");
                return;
            }

            FrmAgregarProveedores abrir = new FrmAgregarProveedores();

            abrir.EsEdicion = true;

            abrir.btnGuardarProveedor.Visible = false;
            abrir.btnGuardarProveedor.Enabled = false;

            abrir.lb_IDProveedor.Visible = false;
            abrir.lb_IDProveedor.Enabled = false;

            abrir.txtId_Proveedor.Visible = false;
            abrir.txtId_Proveedor.Enabled = false;

            abrir.txtId_Proveedor.Text = dgvProveedores.CurrentRow.Cells["Id_Proveedor"].Value.ToString();
            abrir.txtProveedor_Nombre.Text = dgvProveedores.CurrentRow.Cells["Nombre"].Value.ToString();
            abrir.txtProveedor_Empresa.Text = dgvProveedores.CurrentRow.Cells["Empresa"].Value.ToString();
            abrir.txtProveedor_Telefono.Text = dgvProveedores.CurrentRow.Cells["Telefono"].Value.ToString();
            abrir.txtProveedor_Correo.Text = dgvProveedores.CurrentRow.Cells["Correo"].Value.ToString();
            abrir.txtProveedor_Direccion.Text = dgvProveedores.CurrentRow.Cells["Direccion"].Value.ToString();
            abrir.txtId_Productos.Text = dgvProveedores.CurrentRow.Cells["Id_Producto"].Value.ToString();


            abrir.ShowDialog();

            // Recargar la tabla
            CargarProveedores();

        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)  // Boton AgregarProveedor
        {
            FrmAgregarProveedores abrir = new FrmAgregarProveedores();

            abrir.btnModificarProveedor.Visible = false;
            abrir.btnModificarProveedor.Enabled = false;

            abrir.lb_IDProveedor.Visible = false;
            abrir.lb_IDProveedor.Enabled = false;

            abrir.txtId_Proveedor.Visible = false;
            abrir.txtId_Proveedor.Enabled = false;

            abrir.ShowDialog();

            CargarProveedores();

        }

        private void btnEliminar_Proveedor_Click(object sender, EventArgs e) // Boton Eliminar
        {
            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un proveedor");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea eliminar este proveedor?", "Eliminar", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

                string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

                using (OleDbConnection conexionBase = new OleDbConnection(seguirRuta))
                {
                    conexionBase.Open();

                    string consulta = "DELETE FROM Proveedores WHERE Id_Proveedor = ?";

                    OleDbCommand comando = new OleDbCommand(consulta, conexionBase);

                    comando.Parameters.AddWithValue("Id_Proveedor", dgvProveedores.CurrentRow.Cells["Id_Proveedor"].Value);

                    comando.ExecuteNonQuery();
                }

                // Confirmación de eliminación
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

        private void button1_Click(object sender, PaintEventArgs e)
        {

        }

        private void picBoxUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuario abrir = new FrmUsuario();
            abrir.Show();

            abrir.lb_idTienda.Visible = false;
            abrir.lb_idTienda.Enabled = false;

            abrir.txtID_Tienda.Visible = false;
            abrir.txtID_Tienda.Enabled = false;
        }

        private void picBoxApartados_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al sistema de control de inventario");
        }
    }
}

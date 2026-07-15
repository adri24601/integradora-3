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
        private void CargarProveedores()
        {
            // RUTA DE BASE DE DATOS

            string ruta = Path.Combine(Application.StartupPath, "integradora boceto.accdb");

            string cadenaConexion = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            string consulta = "SELECT * FROM Proveedores";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                    System.Data.DataTable tablaProveedores = new System.Data.DataTable();

                    adaptador.Fill(tablaProveedores);
                    dgvProveedores.DataSource = tablaProveedores;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }
        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Validamos que haya una fila seleccionada en tu tabla
            if (dgvProveedores.CurrentRow != null)
            {
                // 2. Creamos la instancia usando el nombre real de tu ventana
                FrmAgregarProveedores ventanaEdicion = new FrmAgregarProveedores();

                // 3. Rellenamos los campos de la ventana emergente con lo seleccionado en la tabla
                // (Revisa que los nombres de las celdas ["Id_Producto"], etc., sean exactamente los de tu Access)
                ventanaEdicion.txtId_Proveedor.Text = dgvProveedores.CurrentRow.Cells["Id_Proveedor"].Value.ToString();
                ventanaEdicion.txtProveedor_Nombre.Text = dgvProveedores.CurrentRow.Cells["Proveedor_Nombre"].Value.ToString();
                ventanaEdicion.txtProveedor_Empresa.Text = dgvProveedores.CurrentRow.Cells["Proveedor_Empresa"].Value.ToString();
                ventanaEdicion.txtProveedor_Telefono.Text = dgvProveedores.CurrentRow.Cells["Proveedor_Telefono"].Value.ToString();
                ventanaEdicion.txtProveedor_Correo.Text = dgvProveedores.CurrentRow.Cells["Proveedor_Correo"].Value.ToString();
                ventanaEdicion.txtProveedor_Direccion.Text = dgvProveedores.CurrentRow.Cells["Proveedor_Direccion"].Value.ToString();
                ventanaEdicion.txtId_Producto2.Text = dgvProveedores.CurrentRow.Cells["Id_Producto"].Value.ToString();


                // 4. Mostramos la ventana llena con los datos
                ventanaEdicion.ShowDialog();

                // ... Todo tu código anterior donde rellenas los campos ...
                ventanaEdicion.txtId_Producto2.Text = dgvProveedores.CurrentRow.Cells["Id_Producto"].Value.ToString();

                // 4. Mostramos la ventana llena con los datos
                ventanaEdicion.ShowDialog();

                // 5. Al cerrarse, refresca la tabla automáticamente para ver los cambios
                CargarProveedores();

                // 5. Al cerrarse, refresca la tabla automáticamente para ver los cambios

            }
            else
            {
                MessageBox.Show("Por favor, selecciona primero un producto de la tabla gris.");
            }

        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FrmAgregarProveedores ventanaAgregar = new FrmAgregarProveedores();
            ventanaAgregar.ShowDialog();

            // Si ya tienes el método para actualizar la tabla, llámalo aquí abajo:
            CargarProveedores();

        }

        private void button1_Click_1(object sender, EventArgs e)
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
    }
}

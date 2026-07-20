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
        string ruta = Path.Combine(Application.StartupPath, "integradora boceto.accdb");

        string cadenaConexion;


        public FrmDashboard()
        {
            InitializeComponent();

            cadenaConexion = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";
        }


        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            CargarResumen();
            CargarConfiguracion();
        }


        private void CargarResumen()
        {
            OleDbConnection con = new OleDbConnection(cadenaConexion);

            con.Open();

            // Contar productos
            OleDbCommand cmdProductos = new OleDbCommand("SELECT COUNT(*) FROM Productos", con);

            int totalProductos = Convert.ToInt32(cmdProductos.ExecuteScalar());

            lbCantidadProductos.Text = "Hay " + totalProductos + " productos registrados";


            // Contar proveedores
            OleDbCommand cmdProveedores = new OleDbCommand("SELECT COUNT(*) FROM Proveedores", con);

            int totalProveedores = Convert.ToInt32(cmdProveedores.ExecuteScalar());

            lbCantidadProveedores.Text = "Hay " + totalProveedores + " proveedores registrados";


            // Obtener stock mínimo
            OleDbCommand cmdStockMin = new OleDbCommand("SELECT TOP 1 Stock_minimo FROM Tienda", con);

            int stockMinimo = 5;

            object resultadoStock = cmdStockMin.ExecuteScalar();

            if (resultadoStock != null)
            {
                stockMinimo = Convert.ToInt32(resultadoStock);
            }


            // Contar productos con stock bajo
            OleDbCommand cmdAlerta = new OleDbCommand("SELECT COUNT(*) FROM Productos WHERE Cantidad_Producto <= " + stockMinimo, con);

            int productosBajos = Convert.ToInt32(cmdAlerta.ExecuteScalar());

            lbAlertaStock.Text = productosBajos + " productos con stock mínimo";

            con.Close();
        }

        private void CargarConfiguracion()
        {
            OleDbConnection con = new OleDbConnection(cadenaConexion);
            con.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT TOP 1 * FROM Tienda", con);

            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtNomTienda.Text = dr["Nombre"].ToString();
                txtDirTienda.Text = dr["Direccion"].ToString();
                txtTelTienda.Text = dr["Telefono"].ToString();
                txtCorreoTienda.Text = dr["Correo"].ToString();

                numStockMinimo.Value = Convert.ToDecimal(dr["Stock_minimo"]);
            }

            con.Close();
        }

        private void btnGuardarTienda_Click(object sender, EventArgs e)
        {
            // Verificar que el nombre no esté vacío
            if (txtNomTienda.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la tienda");
                txtNomTienda.Focus();
                return;
            }

            // Abrir conexión
            OleDbConnection con = new OleDbConnection(cadenaConexion);
            con.Open();

            // Verificar si ya existe una tienda
            OleDbCommand verificar = new OleDbCommand("SELECT COUNT(*) FROM Tienda", con);

            int existe = Convert.ToInt32(verificar.ExecuteScalar());

            if (existe > 0)
            {
                MessageBox.Show("La tienda ya está registrada. Use el botón Modificar.");
                con.Close();
                return;
            }

            // Guardar datos
            string insertar = "INSERT INTO Tienda (Nombre, Direccion, Telefono, Correo, Stock_minimo) " + "VALUES ('" + txtNomTienda.Text + "', '" + txtDirTienda.Text + "', '" + txtTelTienda.Text + "', '" + txtCorreoTienda.Text + "', " + numStockMinimo.Value + ")";

            OleDbCommand cmd = new OleDbCommand(insertar, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Tienda guardada correctamente");

            con.Close();

            // Actualizar resumen
            CargarResumen();
        }

        private void btnModificarTienda_Click_1(object sender, EventArgs e)
        {
            // Abrir conexión
            OleDbConnection con = new OleDbConnection(cadenaConexion);
            con.Open();

            string actualizar = "UPDATE Tienda SET " + "Nombre='" + txtNomTienda.Text + "', " + "Direccion='" + txtDirTienda.Text + "', " + "Telefono='" + txtTelTienda.Text + "', " + "Correo='" + txtCorreoTienda.Text + "', " + "Stock_minimo=" + numStockMinimo.Value;

            OleDbCommand cmd = new OleDbCommand(actualizar, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Tienda modificada correctamente");

            con.Close();

            // Actualizar resumen
            CargarResumen();
        }

        private void btnCambiarLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();

            abrir.Filter = "Archivos de imagen|*.jpg;*.png;*.jpeg";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                picLogoTienda.Image = Image.FromFile(abrir.FileName);

                picLogoTienda.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }










































        // ABRIR FORMULARIOS

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



        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void btnGuardarLogo_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void lbMoneda_Click(object sender, EventArgs e)
        {

        }

        private void lbAlerta_Click(object sender, EventArgs e)
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

        private void txtNomTienda_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


    }
}


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


        // Ruta de la base de datos
        string ruta = Path.Combine(Application.StartupPath, "integradora boceto.accdb");

        // Cadena de conexión
        string cadenaConexion = "";

        // Guarda la ruta del logo seleccionado
        string rutaLogo = "";


        public FrmDashboard()
        {
            InitializeComponent();

            cadenaConexion = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";
        }


        private void FrmDashboard_Load(object sender, EventArgs e)
        {

            CargarConfiguracion();

            MostrarAlertaStock();

        }


        private void CargarConfiguracion()
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT * FROM Tienda";

                    OleDbCommand comando = new OleDbCommand(consulta, conexion);

                    OleDbDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        txtNomTienda.Text = lector["Nombre"].ToString();
                        txtDirTienda.Text = lector["Direccion"].ToString();
                        txtTelefono.Text = lector["Telefono"].ToString();
                        txtCorreo.Text = lector["Correo"].ToString();

                        numStockAlerta.Value =
                            Convert.ToDecimal(lector["Stock_Minimo"]);

                        if (lector["Logo"].ToString() != "")
                        {
                            pictureBox2.Image = Image.FromFile(lector["Logo"].ToString());
                            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCambiarLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();


            if (abrir.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(abrir.FileName);

                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

                rutaLogo = abrir.FileName;
            }
        }


        private void btnGuardarTienda_Click(object sender, EventArgs e)
        {
            // Verificar que el nombre no esté vacío
            if (txtNomTienda.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la tienda.");
                txtNomTienda.Focus();
                return;
            }

            // Verificar la dirección
            if (txtDirTienda.Text == "")
            {
                MessageBox.Show("Ingrese la dirección.");
                txtDirTienda.Focus();
                return;
            }

            // Verificar el teléfono
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Ingrese el teléfono.");
                txtTelefono.Focus();
                return;
            }

            // Verificar el correo
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("Ingrese el correo electrónico.");
                txtCorreo.Focus();
                return;
            }


            try
            {
                // Crear conexión con la base de datos
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();


                    // Verificar si ya existe información de la tienda
                    string verificar = "SELECT COUNT(*) FROM Tienda";

                    OleDbCommand comandoVerificar = new OleDbCommand(verificar, conexion);

                    int registros = Convert.ToInt32(comandoVerificar.ExecuteScalar());


                    if (registros == 0)
                    {
                        // Si no existe información, se inserta el primer registro

                        string insertar = @"INSERT INTO Tienda  (Nombre, Direccion, Telefono, Correo, Stock_Minimo, Logo) VALUES (?, ?, ?, ?, ?, ?)";


                        OleDbCommand comando = new OleDbCommand(insertar, conexion);


                        comando.Parameters.AddWithValue("@Nombre", txtNomTienda.Text);

                        comando.Parameters.AddWithValue("@Direccion", txtDirTienda.Text);

                        comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text);

                        comando.Parameters.AddWithValue("@Correo", txtCorreo.Text);

                        comando.Parameters.AddWithValue("@Stock_Minimo", (int)numStockAlerta.Value);

                        comando.Parameters.AddWithValue("@Logo", rutaLogo);


                        comando.ExecuteNonQuery();
                    }
                    else
                    {
                        // Si ya existe información, se actualizan los datos

                        string actualizar = @"UPDATE Tienda
                                      SET Nombre = ?,
                                           Direccion = ?,
                                           Telefono = ?,
                                           Correo = ?,
                                           Stock_Minimo = ?,
                                           Logo = ?";


                        OleDbCommand comando = new OleDbCommand(actualizar, conexion);


                        comando.Parameters.AddWithValue("@Nombre", txtNomTienda.Text);

                        comando.Parameters.AddWithValue("@Direccion", txtDirTienda.Text);

                        comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text);

                        comando.Parameters.AddWithValue("@Correo", txtCorreo.Text);

                        comando.Parameters.AddWithValue("@Stock_Minimo", (int)numStockAlerta.Value);

                        comando.Parameters.AddWithValue("@Logo", rutaLogo);


                        comando.ExecuteNonQuery();
                    }



                }


                // Actualizar la alerta de productos
                MostrarAlertaStock();


                MessageBox.Show(
                    "Los datos de la tienda fueron guardados correctamente.",
                    "CAF Inventory",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la información: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void MostrarAlertaStock()
        {

            // LA ruta ya se encuentra ingresada
            // Consulta
            string consulta = "SELECT Cantidad_Producto FROM Productos";

            int productosStockBajo = 0;

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    OleDbCommand comando = new OleDbCommand(consulta, conexion);

                    OleDbDataReader lector = comando.ExecuteReader();

                    // Recorrer todos los productos
                    while (lector.Read())
                    {
                        int cantidad = Convert.ToInt32(lector["Cantidad_Producto"]);

                        // Comparar con el stock mínimo configurado
                        if (cantidad <= (int)numStockAlerta.Value)
                        {
                            productosStockBajo++;
                        }
                    }
                }

                // Mostrar la alerta
                if (productosStockBajo > 0)
                {
                    lbAlerta.Text = "Hay " + productosStockBajo + " productos con stock bajo.";
                    lbAlerta.ForeColor = Color.Red;
                }
                else
                {
                    lbAlerta.Text = "Todos los productos tienen suficiente stock.";
                    lbAlerta.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el stock: " + ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarAlertaStock();
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
    }
}


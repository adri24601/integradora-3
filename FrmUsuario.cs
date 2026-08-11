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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CargarConfiguracionTienda();
        }

        private void btnConfiguracionTienda_Click(object sender, EventArgs e)
        {
            string idTienda = txtID_Tienda.Text;
            string nomTienda = txtNomTienda.Text;
            string clave = txtClaveTienda.Text;
            string usuario = txtUsuarioTienda.Text;
            string contrasena = txtContrasenaTienda.Text;

            string nomPropietario = txtNombrePropietario.Text;
            string apellidoP = txtAP_Propietario.Text;
            string apellidoM = txtAM_Propietario.Text;

            string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

            string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            using (OleDbConnection conexionBase = new OleDbConnection(seguirRuta))
            {
                conexionBase.Open();

                string llenarTabla = @"UPDATE Tienda SET 
                                                          Nombre_Tienda = ?,
                                                          Nombres_Propietario = ?,
                                                          AP_Propietario = ?,
                                                          AM_Propietario = ?,
                                                          Clave_Recuperacion = ?,
                                                          Usuario = ?,
                                                          Contrasena = ?
                                                    WHERE Id_Tienda = ?";

                OleDbCommand ejecutar = new OleDbCommand(llenarTabla, conexionBase);

                ejecutar.Parameters.AddWithValue("@Nombre_Tienda", nomTienda);
                ejecutar.Parameters.AddWithValue("@Nombres_Propietario", nomPropietario);
                ejecutar.Parameters.AddWithValue("@AP_Propietario", apellidoP);
                ejecutar.Parameters.AddWithValue("@AM_Propietario", apellidoM);
                ejecutar.Parameters.AddWithValue("@Clave_Recuperacion", clave);
                ejecutar.Parameters.AddWithValue("@Usuario", usuario);
                ejecutar.Parameters.AddWithValue("@Contrasena", contrasena);
                ejecutar.Parameters.AddWithValue("@Id_Tienda", idTienda);

                ejecutar.ExecuteNonQuery();

                MessageBox.Show("Se ha registrado la información");
            }
        }

        private void CargarConfiguracionTienda()
        {
            string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

            string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            using (OleDbConnection conexionBase = new OleDbConnection(seguirRuta))
            {
                conexionBase.Open();

                string consulta = "SELECT * FROM Tienda";

                OleDbCommand ejecutar = new OleDbCommand(consulta, conexionBase);
                OleDbDataReader lector = ejecutar.ExecuteReader();

                if (lector.Read())
                {
                    txtID_Tienda.Text = lector["Id_Tienda"].ToString();
                    txtNomTienda.Text = lector["Nombre_Tienda"].ToString();
                    txtNombrePropietario.Text = lector["Nombres_Propietario"].ToString();
                    txtAP_Propietario.Text = lector["AP_Propietario"].ToString();
                    txtAM_Propietario.Text = lector["AM_Propietario"].ToString();
                    txtClaveTienda.Text = lector["Clave_Recuperacion"].ToString();
                    txtUsuarioTienda.Text = lector["Usuario"].ToString();
                    txtContrasenaTienda.Text = lector["Contrasena"].ToString();
                }

                lector.Close();
            }
        }

        private void picBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_RegresarLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 abrir = new Form1();
            abrir.Show();
            this.Hide();
        }
    }
} 

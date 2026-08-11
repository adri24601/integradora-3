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
    public partial class FrmCambiarContra : Form
    {
        public FrmCambiarContra()
        {
            InitializeComponent();
        }

        private void FrmCambiarContra_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidarClave_Click(object sender, EventArgs e)
        {
            string clave = texClave.Text;

            if(clave == "")
            {
                MessageBox.Show("Ingresa la clave del producto");
                return;
            }

            string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

            string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            using (OleDbConnection conexionBase = new OleDbConnection(seguirRuta))
            {
                conexionBase.Open();

                string consultarAcceso = "SELECT * FROM Tienda WHERE Clave_Recuperacion = @clave";

                OleDbCommand ejecutar = new OleDbCommand(consultarAcceso, conexionBase);

                ejecutar.Parameters.AddWithValue("@clave", clave);

                OleDbDataReader leer = ejecutar.ExecuteReader();

                if (leer.Read())
                {
                    FrmUsuario abrir = new FrmUsuario();
                    abrir.Show();

                    abrir.picBoxCerrar.Visible = false;
                    abrir.picBoxCerrar.Enabled = false;

                    abrir.lb_idTienda.Visible = false;
                    abrir.txtID_Tienda.Visible = false;

                    abrir.lb_idTienda.Enabled = false;
                    abrir.txtID_Tienda.Enabled = false;

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Clave incorrecta");
                }
            }
        }
    }
}

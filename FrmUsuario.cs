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
                
                string llenarTabla = @"UPDATE Tienda SET Nombre_Tienda = ?,
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
            }
        }

    }
}

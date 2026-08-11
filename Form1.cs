using System.Data.OleDb;

namespace integra_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            string usuario = texUsuario.Text;
            string contrasena = texContrasena.Text;

            if (usuario == "")
            {
                MessageBox.Show("Ingresa usuario");
                return;
            }

            if (contrasena == "")
            {
                MessageBox.Show("Ingresa contraseña");
                return;
            }

            string ruta = @"C:\Users\LPC\Desktop\REPOSITORIO 3\integradora boceto.accdb";

            string seguirRuta = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            using (OleDbConnection conexionBase = new OleDbConnection(seguirRuta))
            {
                conexionBase.Open();

                string consultarAcceso = "SELECT * FROM Tienda WHERE Usuario = @usuario AND Contrasena = @contrasena";

                OleDbCommand ejecutar = new OleDbCommand(consultarAcceso, conexionBase);

                ejecutar.Parameters.AddWithValue("@usuario", usuario);
                ejecutar.Parameters.AddWithValue("@contrasena", contrasena);

                OleDbDataReader leer = ejecutar.ExecuteReader();

                if (leer.Read())
                {
                    FrmDashboard abrir = new FrmDashboard();
                    abrir.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCambiarContra abrir = new FrmCambiarContra();
            abrir.Show();
            this.Hide();
        }
    }
}

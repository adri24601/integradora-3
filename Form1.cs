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
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (usuario == "admin" && contrasena == "1234")
            {
                MessageBox.Show("Bienvenido");

                FrmDashboard menu = new FrmDashboard();
                menu.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace integra_1
{
    public partial class FrmAyuda : Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void FrmAyuda_Load(object sender, EventArgs e)
        {

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

        }

        private void btnCerrar_Sesion_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

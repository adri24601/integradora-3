using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace integra_1
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            FrmProductos frm = new FrmProductos();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(frm);

            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDashboard menu = new FrmDashboard();
            menu.Show();

            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            FrmInventario frm = new FrmInventario();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(frm);

            frm.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            FrmProveedores frm = new FrmProveedores();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(frm);

            frm.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            FrmVentas frm = new FrmVentas();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(frm);

            frm.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            FrmReportes frm = new FrmReportes();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(frm);

            frm.Show();
        }

        private void btnCerrar_Sesion_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();

            this.Hide();
        }
    }
}

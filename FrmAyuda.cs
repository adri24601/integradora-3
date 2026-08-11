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

        private void FrmAyuda_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string mensaje = "Para agregar un producto:\n\n" +
                             "1. Dirígete al menú 'Inventario' o 'Productos'.\n" +
                             "2. Haz clic en el botón 'Nuevo' / 'Agregar'.\n" +
                             "3. Completa los campos obligatorios (Nombre, Código, Precio, Stock).\n" +
                             "4. Presiona 'Guardar'.";

            MessageBox.Show(mensaje, "¿Cómo agregar un producto?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            string mensaje = "Para editar un producto:\n\n" +
                             "1. Selecciona el producto que deseas modificar de la lista.\n" +
                             "2. Haz clic en 'Editar'.\n" +
                             "3. Cambia la información necesaria.\n" +
                             "4. Presiona 'Guardar cambios'.";

            MessageBox.Show(mensaje, "¿Cómo editar un producto?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string mensaje = "Para eliminar un producto:\n\n" +
                             "1. Selecciona el producto en la tabla.\n" +
                             "2. Haz clic en el botón 'Eliminar'.\n" +
                             "3. Confirma la acción cuando el sistema te lo pregunte.\n\n" +
                             "Nota: Si el producto tiene movimientos registrados, se recomienda deshabilitarlo en lugar de borrarlo.";

            MessageBox.Show(mensaje, "¿Cómo eliminar un producto?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void btnNoPuedoIniciarSesion_Click(object sender, EventArgs e)
        {
            string mensaje = "Solución si no puedes iniciar sesión:\n\n" +
                             "• Verifica que tu usuario y contraseña estén escritos correctamente.\n" +
                             "• Asegúrate de que las mayúsculas/minúsculas coincidan.\n" +
                             "• Si olvidaste tu contraseña, contacta al administrador del sistema.";

            MessageBox.Show(mensaje, "Problema: Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnProductoNoAparece_Click(object sender, EventArgs e)
        {
            string mensaje = "Solución si un producto no aparece:\n\n" +
                             "• Limpia los filtros de búsqueda y presiona 'Buscar' o 'Actualizar'.\n" +
                             "• Comprueba si el producto fue marcado como 'Inactivo' o eliminado.\n" +
                             "• Verifica que la base de datos esté conectada correctamente.";

            MessageBox.Show(mensaje, "Problema: Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnErrorGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = "Solución a error al guardar información:\n\n" +
                             "• Revisa que no haya campos requeridos vacíos.\n" +
                             "• Asegúrate de introducir valores numéricos válidos en precio y cantidad.\n" +
                             "• Verifica que el código de producto no esté duplicado.\n" +
                             "• Si el problema persiste, reinicia la aplicación o contacta a soporte.";

            MessageBox.Show(mensaje, "Problema: Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnNoProducto_Click(object sender, EventArgs e)
        {

        }

        private void picBoxUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario abrir = new FrmUsuario();
            abrir.Show();

            abrir.lb_idTienda.Visible = false;
            abrir.lb_idTienda.Enabled = false;

            abrir.txtID_Tienda.Visible = false;
            abrir.txtID_Tienda.Enabled = false;

            abrir.link_RegresarLogin.Visible = false;
            abrir.link_RegresarLogin.Enabled = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.Show();
            this.Hide();
        }

        private void cuiButton3_Click(object sender, EventArgs e) // btnProveedores
        {
            FrmProveedores frm = new FrmProveedores();
            frm.Show();
            this.Hide();
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();
            frm.Show();
            this.Hide();
        }

        private void btnAyuda_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al sistema de control de inventario");
        }
    }
}


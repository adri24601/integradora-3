using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace integra_1
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void btnImprimir_Ticket_Click(object sender, EventArgs e)
        {
            // Validar que la tabla tenga productos cargados
            if (dgvCarrito.Rows.Count == 0 || (dgvCarrito.Rows.Count == 1 && dgvCarrito.Rows[0].IsNewRow))
            {
                MessageBox.Show("El carrito está vacío. Agrega un producto primero.");
                return;
            }

            string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\adria\Desktop\integradora00\integradora avanzada media\integradora boceto.accdb;";
            // Configurar la impresión nativa de Windows
            System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
            pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CrearTicket);

            PrintDialog pdDialog = new PrintDialog();
            pdDialog.Document = pd;

            if (pdDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print(); // Lanza el proceso de dibujado


                // Recorrer el carrito para restar las existencias de cada producto vendido
                foreach (DataGridViewRow fila in dgvCarrito.Rows)
                {
                    if (fila.Cells["Nombre"].Value == null) continue;

                    // Nota: Como en tu buscador usaste el ID del producto, necesitamos guardar el ID en alguna columna oculta 
                    // o buscar por nombre. Lo ideal es que tu dgvCarrito tenga el ID a la mano.
                    string nombreProducto = fila.Cells["Nombre"].Value.ToString();
                    int cantidadVendida = Convert.ToInt32(fila.Cells["Cantidad"].Value);

                    string consultaRestar = "UPDATE Productos SET Cantidad_Producto = Cantidad_Producto - ? WHERE Nombre_Producto = ?";

                    using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                    {
                        using (OleDbCommand comando = new OleDbCommand(consultaRestar, conexion))
                        {
                            comando.Parameters.AddWithValue("@cantidad", cantidadVendida);
                            comando.Parameters.AddWithValue("@nombre", nombreProducto);

                            conexion.Open();
                            comando.ExecuteNonQuery();
                        }
                    }
                }
                // Limpiar todo para dejar listo para la siguiente venta
                dgvCarrito.Rows.Clear();
                lblTotal_a_Pagar.Text = "Total a pagar: $0.00";
                MessageBox.Show("¡Venta completada e impresa con éxito!");
            }
        }


        private void CrearTicket(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fuenteTitulo = new Font("Arial", 11, FontStyle.Bold);
            Font fuenteNormal = new Font("Arial", 9, FontStyle.Regular);
            Font fuenteTotales = new Font("Arial", 10, FontStyle.Bold);

            float x = 10;
            float y = 10;
            float anchoTicket = 260;

            // Encabezado
            g.DrawString("MI TIENDITA INTEGRADORA", fuenteTitulo, Brushes.Black, new RectangleF(x, y, anchoTicket, 20));
            y += 20;
            g.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fuenteNormal, Brushes.Black, x, y);
            y += 15;
            g.DrawString("--------------------------------------------------", fuenteNormal, Brushes.Black, x, y);
            y += 15;

            g.DrawString("Cant  Producto          Precio   Subtl", fuenteNormal, Brushes.Black, x, y);
            y += 15;
            g.DrawString("--------------------------------------------------", fuenteNormal, Brushes.Black, x, y);
            y += 15;

            double totalPagar = 0;

            // Recorremos la tabla gris fila por fila para dibujarla en el papel/PDF
            foreach (DataGridViewRow fila in dgvCarrito.Rows)
            {
                if (fila.Cells["Nombre"].Value == null) continue;

                string nombre = fila.Cells["Nombre"].Value.ToString();
                string precio = fila.Cells["Precio"].Value.ToString();
                string cantidad = fila.Cells["Cantidad"].Value.ToString();
                string subtotal = fila.Cells["Subtotal"].Value.ToString();

                totalPagar += Convert.ToDouble(subtotal);

                g.DrawString(cantidad, fuenteNormal, Brushes.Black, x, y);
                // Corta el nombre si es muy largo para que no se encime con el precio
                g.DrawString(nombre.Length > 12 ? nombre.Substring(0, 12) : nombre, fuenteNormal, Brushes.Black, x + 30, y);
                g.DrawString("$" + precio, fuenteNormal, Brushes.Black, x + 135, y);
                g.DrawString("$" + subtotal, fuenteNormal, Brushes.Black, x + 195, y);

                y += 15;
            }

            // Totales finales
            y += 10;
            g.DrawString("--------------------------------------------------", fuenteNormal, Brushes.Black, x, y);
            y += 15;
            g.DrawString("TOTAL A PAGAR:", fuenteTotales, Brushes.Black, x + 40, y);
            g.DrawString("$" + totalPagar.ToString("N2"), fuenteTotales, Brushes.Black, x + 195, y);
            y += 30;

            g.DrawString("¡Muchas gracias por su compra!", fuenteNormal, Brushes.Black, x + 30, y);
        }


        // Aquí es donde se "dibuja" el diseño del ticket


        private void btnAgregar_Producto_Venta_Click(object sender, EventArgs e)
        {
            // 1. Validar que el usuario haya escrito algo en el cuadro de texto
            if (string.IsNullOrEmpty(txtAgregar_Id_Producto.Text))
            {
                MessageBox.Show("Por favor escribe el ID de un producto.");
                return;
            }

            // 2. Tu ruta de la base de datos fija
            string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\adria\Desktop\integradora00\integradora avanzada media\integradora boceto.accdb;";
            string consulta = "SELECT Nombre_Producto, Precio_Producto, Cantidad_Producto FROM Productos WHERE Id = @id";

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", txtAgregar_Id_Producto.Text);

                    try
                    {
                        conexion.Open();
                        OleDbDataReader lector = comando.ExecuteReader();

                        if (lector.Read())
                        {
                            string nombre = lector["Nombre_Producto"].ToString();
                            double precio = Convert.ToDouble(lector["Precio_Producto"]);
                            int stockActual = Convert.ToInt32(lector["Cantidad_Producto"]);

                            if (stockActual <= 0)
                            {
                                MessageBox.Show("¡Ya no queda stock de este producto!");
                                return;
                            }

                            // 3. Insertar los datos directamente en las columnas de la tabla gris
                            int cantidad = 1;
                            double subtotal = precio * cantidad;
                            dgvCarrito.Rows.Add(nombre, precio, cantidad, subtotal);

                            // 4. Actualizar la etiqueta del total acumulado
                            ActualizarTotal();
                            txtAgregar_Id_Producto.Clear();
                            txtAgregar_Id_Producto.Focus();
                        }
                        else
                        {
                            MessageBox.Show("El producto con ese ID no existe.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar producto: " + ex.Message);
                    }
                }
            }
        }

        private void ActualizarTotal()
        {
            double total = 0;
            foreach (DataGridViewRow fila in dgvCarrito.Rows)
            {
                if (fila.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDouble(fila.Cells["Subtotal"].Value);
                }
            }
            // Modifica 'lblTotal' por el nombre que le diste a tu etiqueta de "Total a pagar"
            lblTotal_a_Pagar.Text = "Total a pagar: $" + total.ToString("N2");
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {

        }
    }
}

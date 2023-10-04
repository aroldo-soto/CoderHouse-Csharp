using App.Productos;
using App.Productos.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.ProductosVendidos.Formularios
{
    public partial class ProductoVendidoForm : Form
    {
        private ProductoVendido productoVendidoSeleccionado;
        public ProductoVendidoForm()
        {
            InitializeComponent();
        }
        private void CargarProductosVendidos()
        {
            List<ProductoVendido> productosVendidosList = ProductoVendidoData.ListarProductosVendidos();
            dataGridViewProductoVendido.AutoGenerateColumns = false;
            dataGridViewProductoVendido.DataSource = productosVendidosList;
        }
        private void ProductoVendidoForm_Load(object sender, EventArgs e)
        {
            CargarProductosVendidos();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (long.TryParse(textBoxBuscar.Text, out long productoVendidoId))
            {
                ProductoVendido productoVendidoEncontrado = ProductoVendidoData.ObtenerProductoVendido(productoVendidoId);

                if (productoVendidoEncontrado != null)
                {
                    string message = $"ID: {productoVendidoEncontrado.Id}\n" +
                         $"ID de producto: {productoVendidoEncontrado.IdProducto}\n" +
                         $"Stock: {productoVendidoEncontrado.Stock}\n" +
                         $"ID de venta: {productoVendidoEncontrado.IdVenta}";

                    MessageBox.Show(message, "Detalles del Producto vendido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto vendido no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID de producto vendido válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewProductoVendido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewProductoVendido.Columns["Modificar"].Index)
            {
                productoVendidoSeleccionado = (ProductoVendido)dataGridViewProductoVendido.Rows[e.RowIndex].DataBoundItem;

                ProductoVendidoModificar productoVendidoModificar = new ProductoVendidoModificar(productoVendidoSeleccionado);
                productoVendidoModificar.ShowDialog();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewProductoVendido.Columns["Eliminar"].Index)
            {
                productoVendidoSeleccionado = (ProductoVendido)dataGridViewProductoVendido.Rows[e.RowIndex].DataBoundItem;

                ProductoVendidoData.EliminarProductoVendido(productoVendidoSeleccionado);
                MessageBox.Show("Se ha eliminado el producto vendido satisfactoriamente.");
            }
        }
    }
}

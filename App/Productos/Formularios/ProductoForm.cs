using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Productos;
using App.Productos.Formularios;

namespace App
{
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
        }
        private Producto productoSeleccionado;
        private void CargarProductos()
        {
            List<Producto> productList = ProductoData.ListarProductos();
            dataGridViewProducto.AutoGenerateColumns = false;
            dataGridViewProducto.DataSource = productList;
        }
        private void ProductoForm_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
        private void buttonCrear_Click(object sender, EventArgs e)
        {
            ProductoCrear productoCrear = new ProductoCrear();
            productoCrear.Show();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (long.TryParse(textBoxBuscar.Text, out long productoId))
            {
                Producto productoEncontrado = ProductoData.ObtenerProducto(productoId);

                if (productoEncontrado != null)
                {
                    string message = $"ID: {productoEncontrado.Id}\n" +
                         $"Descripciones: {productoEncontrado.Descripciones}\n" +
                         $"Costo: {productoEncontrado.Costo}\n" +
                         $"Precio de Venta: {productoEncontrado.PrecioVenta}\n" +
                         $"Stock: {productoEncontrado.Stock}\n" +
                         $"ID de Usuario: {productoEncontrado.IdUsuario}";

                    MessageBox.Show(message, "Detalles del Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID de producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewProducto.Columns["Modificar"].Index)
            {
                productoSeleccionado = (Producto)dataGridViewProducto.Rows[e.RowIndex].DataBoundItem;

                ProductoModificar productoModificar = new ProductoModificar(productoSeleccionado);
                productoModificar.ShowDialog();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewProducto.Columns["Eliminar"].Index)
            {
                productoSeleccionado = (Producto)dataGridViewProducto.Rows[e.RowIndex].DataBoundItem;

                ProductoData.EliminarProducto(productoSeleccionado);
                MessageBox.Show("Se ha eliminado el producto satisfactoriamente.");
            }
        }
    }
}

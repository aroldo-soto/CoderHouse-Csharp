using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Productos.Formularios
{
    public partial class ProductoCrear : Form
    {
        public ProductoCrear()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Descripciones = textBoxDescripcion.Text;
            producto.Costo = numericUpDownCosto.Value;
            producto.PrecioVenta = numericUpDownPrecioVenta.Value;
            producto.Stock = numericUpDownStock.Value;
            producto.IdUsuario = 1;

            ProductoData.CrearProducto(producto);
            MessageBox.Show("Se ha creado el producto satisfactoriamente.");

        }

        private void ProductoCrear_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescripcion_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDownCosto_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDownPrecioVenta_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDownStock_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}

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
    public partial class ProductoModificar : Form
    {
        private Producto _producto;
        public ProductoModificar(Producto producto)
        {
            InitializeComponent();
            _producto = producto;
        }
        private void ProductoModificar_Load(object sender, EventArgs e)
        {
            this.textBoxDescripcion.Text = _producto.Descripciones;
            this.numericUpDownCosto.Value = _producto.Costo;
            this.numericUpDownPrecioVenta.Value = _producto.PrecioVenta;
            this.numericUpDownStock.Value = _producto.Stock;
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            _producto.Descripciones = textBoxDescripcion.Text;
            _producto.Costo = numericUpDownCosto.Value;
            _producto.PrecioVenta = numericUpDownPrecioVenta.Value;
            _producto.Stock = numericUpDownStock.Value;

            ProductoData.ModificarProducto(_producto);
            MessageBox.Show("Se ha actualizado el producto satisfactoriamente.");
        }

    }
}

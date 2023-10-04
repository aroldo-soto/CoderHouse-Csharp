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
    public partial class ProductoVendidoModificar : Form
    {
        private ProductoVendido _productoVendido;
        public ProductoVendidoModificar(ProductoVendido productoVendido)
        {
            InitializeComponent();
            _productoVendido = productoVendido;
        }
        private void ProductoVendidoModificar_Load(object sender, EventArgs e)
        {
            this.numericUpDownStock.Value = _productoVendido.Stock;
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            _productoVendido.Stock = numericUpDownStock.Value;
            ProductoVendidoData.ModificarProductoVendido(_productoVendido);
            MessageBox.Show("Se ha actualizado el producto vendido satisfactoriamente.");
        }
    }
}

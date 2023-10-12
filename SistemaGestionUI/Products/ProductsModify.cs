using SistemaGestionBussiness;
using SistemaGestionEntities;
using SistemaGestionUI.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI.Products
{
    public partial class ProductsModify : Form
    {
        private Producto _product;
        public ProductsModify(Producto product)
        {
            InitializeComponent();
            _product = product;
        }
        private void ProductModify_Load(object sender, EventArgs e)
        {
            this.textBoxDescripciones.Text = _product.Descripciones;
            this.numericUpDownCosto.Value = _product.Costo;
            this.numericUpDownPrecioVenta.Value = _product.PrecioVenta;
            this.numericUpDownStock.Value = _product.Stock;
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            var product = new Producto()
            {
                Id = _product.Id,
                Descripciones = textBoxDescripciones.Text,
                Costo = numericUpDownCosto.Value,
                PrecioVenta = numericUpDownPrecioVenta.Value,
                Stock = numericUpDownStock.Value,
                IdUsuario = _product.IdUsuario
            };

            ProductBusiness.UpdateProduct(product);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha actualizado el producto satisfactoriamente.");
            this.Close();
        }
    }
}

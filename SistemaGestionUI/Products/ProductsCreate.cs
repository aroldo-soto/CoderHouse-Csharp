using SistemaGestionBussiness;
using SistemaGestionEntities;
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
    public partial class ProductsCreate : Form
    {
        public ProductsCreate()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            var product = new Producto()
            {
                Descripciones = textBoxDescripciones.Text,
                Costo = numericUpDownCosto.Value,
                PrecioVenta = numericUpDownPrecioVenta.Value,
                Stock = numericUpDownStock.Value,
            };

            ProductBusiness.CreateProduct(product);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha creado el producto satisfactoriamente.");
            this.Close();
        }
    }
}

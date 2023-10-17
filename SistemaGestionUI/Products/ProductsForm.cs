using SistemaGestionBussiness;
using SistemaGestionData;
using SistemaGestionEntities;
using SistemaGestionUI.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI.Productos
{
    public partial class ProductsForm : Form
    {
        private Producto productSelected;
        public ProductsForm()
        {
            InitializeComponent();
        }
        private void LoadContent()
        {
            using (var context = new ApplicationDbContext())
            {
                var products = ProductBusiness.GetProducts();
                dataGridViewProducts.DataSource = products;
            }
        }
        private void ProductoForm_Load(object sender, EventArgs e)
        {
            LoadContent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            ProductsCreate form = new ProductsCreate();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadContent();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewProducts.Columns["Modificar"].Index)
            {
                productSelected = (Producto)dataGridViewProducts.Rows[e.RowIndex].DataBoundItem;

                ProductsModify form = new ProductsModify(productSelected);
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadContent();
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewProducts.Columns["Eliminar"].Index)
            {
                productSelected = (Producto)dataGridViewProducts.Rows[e.RowIndex].DataBoundItem;

                ProductBusiness.DeleteProduct(productSelected.Id);
                this.LoadContent();
                MessageBox.Show("Se ha eliminado el producto satisfactoriamente.");
            }
        }
    }
}

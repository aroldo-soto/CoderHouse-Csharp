using SistemaGestionBusiness;
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

namespace SistemaGestionUI.SoldProducts
{
    public partial class SoldProductsForm : Form
    {
        private ProductoVendido soldProductSelected;
        public SoldProductsForm()
        {
            InitializeComponent();
        }
        private void LoadContent()
        {
            using (var context = new ApplicationDbContext())
            {
                var soldProducts = SoldProductBusiness.GetSoldProducts();
                dataGridViewSoldProducts.DataSource = soldProducts;
            }
        }
        private void SoldProductsForm_Load(object sender, EventArgs e)
        {
            LoadContent();
        }

        private void dataGridViewSoldProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSoldProducts.Columns["Eliminar"].Index)
            {
                soldProductSelected = (ProductoVendido)dataGridViewSoldProducts.Rows[e.RowIndex].DataBoundItem;

                SoldProductBusiness.DeleteSoldProduct(soldProductSelected.Id);
                this.LoadContent();
                MessageBox.Show("Se ha eliminado el producto vendido satisfactoriamente.");
            }
        }
    }
}

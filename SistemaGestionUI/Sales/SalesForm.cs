using SistemaGestionBusiness;
using SistemaGestionData;
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

namespace SistemaGestionUI.Sales
{
    public partial class SalesForm : Form
    {
        private Venta saleSelected;
        public SalesForm()
        {
            InitializeComponent();
        }
        private void LoadContent()
        {
            using (var context = new ApplicationDbContext())
            {
                var sales = SaleBusiness.GetSales();
                dataGridViewSales.DataSource = sales;
            }
        }
        private void SalesForm_Load(object sender, EventArgs e)
        {
            LoadContent();
        }
        private void dataGridViewSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSales.Columns["Eliminar"].Index)
            {
                saleSelected = (Venta)dataGridViewSales.Rows[e.RowIndex].DataBoundItem;

                SaleBusiness.DeleteSale(saleSelected.Id);
                this.LoadContent();
                MessageBox.Show("Se ha eliminado la venta satisfactoriamente.");
            }
        }

    }
}

using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBusiness
{
    public class SaleBusiness
    {
        public static List<Venta> GetSales()
        {
            return SaleData.GetSales();
        }
        public static Venta GetSaleById(int saleId)
        {
            return SaleData.GetSaleById(saleId);
        }
        public static void CreateSale(Venta sale)
        {
            SaleData.CreateSale(sale);
        }
        public static void UpdateSale(int saleId, Venta sale)
        {
            SaleData.UpdateSale(saleId, sale);
        }
        public static void DeleteSale(int saleId)
        {
            SaleData.DeleteSale(saleId);
        }
    }
}

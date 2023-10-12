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
        public static void CreateSale(Venta sale)
        {
            SaleData.CreateSale(sale);
        }
        public static void UpdateSale(Venta sale)
        {
            SaleData.UpdateSale(sale);
        }
        public static void DeleteSale(Venta sale)
        {
            SaleData.DeleteSale(sale);
        }
    }
}

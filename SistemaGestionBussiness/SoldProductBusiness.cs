using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBusiness
{
    public class SoldProductBusiness
    {
        public static List<ProductoVendido> GetSoldProducts()
        {
            return SoldProductData.GetSoldProducts();
        }
        public static void CreateSoldProduct(ProductoVendido soldProduct)
        {
            SoldProductData.CreateSoldProduct(soldProduct);
        }
        public static void UpdateSoldProduct(ProductoVendido soldProduct)
        {
            SoldProductData.UpdateSoldProduct(soldProduct);
        }
        public static void DeleteSoldProduct(ProductoVendido soldProduct)
        {
            SoldProductData.DeleteSoldProduct(soldProduct);
        }
    }
}

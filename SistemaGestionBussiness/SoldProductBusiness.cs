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
        public static ProductoVendido GetSoldProductById(int soldProductId)
        {
            return SoldProductData.GetSoldProductById(soldProductId);
        }
        public static void CreateSoldProduct(ProductoVendido soldProduct)
        {
            SoldProductData.CreateSoldProduct(soldProduct);
        }
        public static void CreateSoldProducts(Venta sale)
        {
            SoldProductData.CreateSoldProducts(sale);
        }
        public static void UpdateSoldProduct(int soldProductId, ProductoVendido soldProduct)
        {
            SoldProductBusiness.UpdateSoldProduct(soldProductId, soldProduct);
        }
        public static void DeleteSoldProduct(int soldProductId)
        {
            SoldProductData.DeleteSoldProduct(soldProductId);
        }
        public static void DeleteSoldProducts(int productId)
        {
            SoldProductData.DeleteSoldProducts(productId);
        }
    }
}

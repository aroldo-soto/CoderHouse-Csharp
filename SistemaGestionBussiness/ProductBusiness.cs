using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class ProductBusiness
    {
        public static List<Producto> GetProducts()
        {
            return ProductData.GetProducts();
        }
        public static Producto GetProductById(int productId)
        {
            return ProductData.GetProductById(productId);
        }
        public static void CreateProduct(Producto product)
        {
            ProductData.CreateProduct(product);
        }
        public static void UpdateProduct(int productId, Producto product)
        {
            ProductData.UpdateProduct(productId, product);
        }
        public static void DeductStock(Venta sale)
        {
            ProductData.DeductStock(sale);
        }
        public static void DeleteProduct(int productId)
        {
            ProductData.DeleteProduct(productId);
        }
    }
}

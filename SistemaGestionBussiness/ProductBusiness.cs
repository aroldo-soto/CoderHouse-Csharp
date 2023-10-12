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
        public static void CreateProduct(Producto product)
        {
            ProductData.CreateProduct(product);
        }
        public static void UpdateProduct(Producto product)
        {
            ProductData.UpdateProduct(product);
        }
        public static void DeleteProduct(Producto product)
        {
            ProductData.DeleteProduct(product);
        }
    }
}

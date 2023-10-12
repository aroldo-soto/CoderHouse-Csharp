using Microsoft.Data.SqlClient;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public static class ProductData
    {
        public static List<Producto> GetProducts()
        {
            try
            {
                var db = new ApplicationDbContext();
                var productos = db.Productos.OrderBy(x => x.Id).ToList();

                return productos;
            } catch (Exception ex)
            {
                return null;
            }
        }
        public static Producto GetProductById(int productId, ApplicationDbContext context)
        {
            try
            {
                var product = context.Productos.Find(productId);

                return product;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void CreateProduct(Producto product)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Productos.Add(product);
                    context.SaveChanges();
                }
            } catch (Exception ex)
            {
                throw;
            }
        }
        public static void UpdateProduct(Producto product)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var productFound = GetProductById(product.Id, context);
                    context.Entry(productFound).CurrentValues.SetValues(product);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void DeleteProduct(Producto product)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Productos.Remove(product);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

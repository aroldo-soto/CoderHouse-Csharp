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
    public class SoldProductData
    {
        public static List<ProductoVendido> GetSoldProducts()
        {
            try
            {
                var db = new ApplicationDbContext();
                var soldProductos = db.ProductosVendidos.OrderBy(x => x.Id).ToList();

                return soldProductos;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static ProductoVendido GetSoldProductById(int soldProductId, ApplicationDbContext context)
        {
            try
            {
                var soldProduct = context.ProductosVendidos.Find(soldProductId);

                return soldProduct;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void CreateSoldProduct(ProductoVendido soldProduct)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.ProductosVendidos.Add(soldProduct);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void CreateSoldProducts(Venta sale)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    if (sale.Productos != null && sale.Productos.Any())
                    {
                        foreach (var producto in sale.Productos)
                        {
                            var existingProduct = context.Productos.FirstOrDefault(p => p.Descripciones == producto.Descripciones);
                            var productoVendido = new ProductoVendido
                            {
                                IdProducto = existingProduct.Id,
                                Stock = existingProduct.Stock,
                                IdVenta = sale.Id
                            };

                            context.ProductosVendidos.Add(productoVendido);
                        }

                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void UpdateSoldProduct(ProductoVendido soldProduct)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var soldProductFound = GetSoldProductById(soldProduct.Id, context);
                    context.Entry(soldProductFound).CurrentValues.SetValues(soldProduct);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void DeleteSoldProduct(int soldProductId)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var soldProduct = GetSoldProductById(soldProductId, context);

                    if (soldProduct != null)
                    {
                        context.ProductosVendidos.Remove(soldProduct);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void DeleteSoldProducts(int productId)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var soldProducts = context.ProductosVendidos.Where(x => x.IdProducto == productId).ToList();

                    if (soldProducts != null && soldProducts.Any())
                    {
                        context.ProductosVendidos.RemoveRange(soldProducts);
                        context.SaveChanges();
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

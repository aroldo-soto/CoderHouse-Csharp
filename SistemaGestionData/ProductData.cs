using Microsoft.Data.SqlClient;
using SistemaGestionData;
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
            } 
            catch (Exception ex)
            {
                return null;
            }
        }
        public static Producto GetProductById(int productId)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var product = context.Productos.Find(productId);

                    return product;
                }
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
        public static void UpdateProduct(int productId, Producto product)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var productFound = context.Productos.Find(productId);

                    if (productFound != null)
                    {
                        productFound.Id = productFound.Id;
                        productFound.Descripciones = product.Descripciones;
                        productFound.Costo = product.Costo;
                        productFound.PrecioVenta = product.PrecioVenta;
                        productFound.Stock = product.Stock;
                        productFound.IdUsuario = product.IdUsuario;

                        context.SaveChanges();
                    }
                    else
                    {
                        throw new InvalidOperationException($"Product with ID {product.Id} not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void DeductStock(Venta sale)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    foreach (var product in sale.Productos)
                    {
                        var existingProduct = context.Productos.FirstOrDefault(p => p.Descripciones == product.Descripciones);

                        if (existingProduct != null)
                        {
                            if (product.Stock <= existingProduct.Stock)
                            {
                                existingProduct.Stock -= product.Stock;
                            }
                            else
                            {
                                throw new Exception($"Insufficient stock for product ID {product.Id}.");
                            }
                        }
                        else
                        {
                            throw new Exception($"Product not found for ID {product.Id}.");
                        }
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void DeleteProduct(int productId)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var product = GetProductById(productId);

                    if (product != null)
                    {
                        context.Productos.Remove(product);
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
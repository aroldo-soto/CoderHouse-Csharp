using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class SaleData
    {
        public static List<Venta> GetSales()
        {
            try
            {
                var db = new ApplicationDbContext();
                var sales = db.Ventas.OrderBy(x => x.Id).ToList();

                return sales;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static Venta GetSaleById(int saleId)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var sale = context.Ventas.Find(saleId);

                    return sale;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void CreateSale(Venta sale)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Ventas.Add(sale);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void UpdateSale(int saleId, Venta sale)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var saleFound = context.Ventas.Find(saleId);

                    if (saleFound != null)
                    {
                        saleFound.Id = saleFound.Id;
                        saleFound.Comentarios = sale.Comentarios;
                        saleFound.IdUsuario = sale.IdUsuario;
                        saleFound.Productos = saleFound.Productos;

                        context.SaveChanges();
                    }
                    else
                    {
                        throw new InvalidOperationException($"Sale with ID {sale.Id} not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void DeleteSale(int saleId)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var sale = GetSaleById(saleId);

                    if (sale != null)
                    {
                        context.Ventas.Remove(sale);
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

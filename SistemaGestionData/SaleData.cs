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
        public static Venta GetSaleById(int saleId, ApplicationDbContext context)
        {
            try
            {
                var sale = context.Ventas.Find(saleId);

                return sale;

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
        public static void UpdateSale(Venta sale)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var saleFound = GetSaleById(sale.Id, context);
                    context.Entry(saleFound).CurrentValues.SetValues(sale);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void DeleteSale(Venta sale)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Ventas.Remove(sale);
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

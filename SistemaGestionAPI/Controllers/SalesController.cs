using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        [HttpGet(Name = "GetSales")]
        public IEnumerable<Venta> Get()
        {
            return SaleBusiness.GetSales();
        }
        [HttpPost(Name = "CreateSale")]
        public void Post([FromBody] Venta sale)
        {
            SaleBusiness.CreateSale(sale);
            SoldProductBusiness.CreateSoldProducts(sale);
            ProductBusiness.DeductStock(sale);
        }
        [HttpPut(Name = "UpdateSale")]
        public void Put([FromBody] Venta sale)
        {
            SaleBusiness.UpdateSale(sale);
        }
        [HttpDelete(Name = "DeleteSale")]
        public void Delete([FromBody] int saleId)
        {
            SaleBusiness.DeleteSale(saleId);
        }
    }
}

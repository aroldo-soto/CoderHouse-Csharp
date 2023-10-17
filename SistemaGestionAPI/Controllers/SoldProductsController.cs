using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoldProductsController : ControllerBase
    {
        [HttpGet(Name = "GetSoldProducts")]
        public IEnumerable<ProductoVendido> Get()
        {
            return SoldProductBusiness.GetSoldProducts();
        }
        [HttpPost(Name = "CreateSoldProduct")]
        public void Post([FromBody] ProductoVendido soldProduct)
        {
            SoldProductBusiness.CreateSoldProduct(soldProduct);
        }
        [HttpPut(Name = "UpdateSoldProduct")]
        public void Put([FromBody] ProductoVendido soldProduct)
        {
            SoldProductBusiness.UpdateSoldProduct(soldProduct);
        }
        [HttpDelete(Name = "DeleteSoldProduct")]
        public void Delete([FromBody] int soldProductId)
        {
            SoldProductBusiness.DeleteSoldProduct(soldProductId);
        }
    }
}

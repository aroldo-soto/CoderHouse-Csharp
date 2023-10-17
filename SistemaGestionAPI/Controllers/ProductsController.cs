using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Producto> Get()
        {
            return ProductBusiness.GetProducts();
        }
        [HttpPost(Name = "CreateProduct")]
        public void Post([FromBody] Producto product)
        {
            ProductBusiness.CreateProduct(product);
        }
        [HttpPut(Name = "UpdateProduct")]
        public void Put([FromBody] Producto product)
        {
            ProductBusiness.UpdateProduct(product);
        }
        [HttpDelete(Name = "DeleteProduct")]
        public void Delete([FromBody] int productId)
        {
            SoldProductBusiness.DeleteSoldProducts(productId);
            ProductBusiness.DeleteProduct(productId);
        }
    }
}

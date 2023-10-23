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
        [HttpGet]
        public IActionResult GetProducts()
        {
            try
            {
                var products = ProductBusiness.GetProducts();

                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpGet("{productId}")]
        public IActionResult GetProductById(int productId)
        {
            try
            {
                var product = ProductBusiness.GetProductById(productId);

                if (product != null)
                {
                    return Ok(product);
                }
                else
                {
                    return NotFound("Product not found.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpPost]
        public IActionResult CreateProduct([FromBody] Producto product)
        {
            if (product == null)
            {
                return BadRequest("Invalid product data.");
            }

            try
            {
                ProductBusiness.CreateProduct(product);

                return Ok("Producto creado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpPut("{productId}")]
        public IActionResult UpdateProduct(int productId, [FromBody] Producto product)
        {
            if (product == null)
            {
                return BadRequest("Invalid product data.");
            }

            try
            {
                ProductBusiness.UpdateProduct(productId, product);

                return Ok("Producto actualizado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpDelete("{productId}")]
        public IActionResult DeleteProductById(int productId)
        {
            try
            {
                var product = ProductBusiness.GetProductById(productId);

                if (product == null)
                {
                    return NotFound();
                }

                ProductBusiness.DeleteProduct(productId);

                return Ok("Producto eliminado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}

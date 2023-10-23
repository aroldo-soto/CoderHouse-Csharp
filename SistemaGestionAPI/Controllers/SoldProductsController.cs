using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoldProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSoldProducts()
        {
            try
            {
                var soldProducts = SoldProductBusiness.GetSoldProducts();

                return Ok(soldProducts);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpGet("{soldProductId}")]
        public IActionResult GetSoldProductById(int soldProductId)
        {
            try
            {
                var soldProduct = SoldProductBusiness.GetSoldProductById(soldProductId);

                if (soldProduct != null)
                {
                    return Ok(soldProduct);
                }
                else
                {
                    return NotFound("SoldProduct not found.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpPost]
        public IActionResult CreateSoldProduct([FromBody] ProductoVendido soldProduct)
        {
            if (soldProduct == null)
            {
                return BadRequest("Invalid sold product data.");
            }

            try
            {
                SoldProductBusiness.CreateSoldProduct(soldProduct);

                return Ok("Producto vendido creado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpPut("{soldProductId}")]
        public IActionResult UpdateSoldProduct(int soldProductId, [FromBody] ProductoVendido soldProduct)
        {
            if (soldProduct == null)
            {
                return BadRequest("Invalid sold product data.");
            }

            try
            {
                SoldProductBusiness.UpdateSoldProduct(soldProductId, soldProduct);

                return Ok("Producto vendido actualizado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpDelete("{soldProductId}")]
        public IActionResult DeleteSoldProductById(int soldProductId)
        {
            try
            {
                var soldProduct = SoldProductBusiness.GetSoldProductById(soldProductId);

                if (soldProduct == null)
                {
                    return NotFound();
                }

                SoldProductBusiness.DeleteSoldProduct(soldProductId);

                return Ok("Product vendido eliminado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}

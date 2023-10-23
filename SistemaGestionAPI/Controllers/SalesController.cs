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
        [HttpGet]
        public IActionResult GetSales()
        {
            try
            {
                var sales = SaleBusiness.GetSales();

                return Ok(sales);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpGet("{saleId}")]
        public IActionResult GetSaleById(int saleId)
        {
            try
            {
                var sale = SaleBusiness.GetSaleById(saleId);

                if (sale != null)
                {
                    return Ok(sale);
                }
                else
                {
                    return NotFound("Sale not found.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpPost]
        public IActionResult CreateSale([FromBody] Venta sale)
        {
            if (sale == null)
            {
                return BadRequest("Invalid sale data.");
            }

            try
            {
                SaleBusiness.CreateSale(sale);
                SoldProductBusiness.CreateSoldProducts(sale);
                ProductBusiness.DeductStock(sale);

                return Ok("Venta creada satisfactoriamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpPut("{saleId}")]
        public IActionResult UpdateSale(int saleId, [FromBody] Venta sale)
        {
            if (sale == null)
            {
                return BadRequest("Invalid sale data.");
            }

            try
            {
                SaleBusiness.UpdateSale(saleId, sale);

                return Ok("Venta actualizada satisfactoriamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpDelete("{saleId}")]
        public IActionResult DeleteSaleById(int saleId)
        {
            try
            {
                var sale = SaleBusiness.GetSaleById(saleId);

                if (sale == null)
                {
                    return NotFound();
                }

                SaleBusiness.DeleteSale(saleId);

                return Ok("Venta eliminada satisfactoriamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}

using FullProductAssesment.DTO;
using FullProductAssesment.Services;
using Microsoft.AspNetCore.Mvc;

namespace FullProductAssesment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _saleService;

        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }
        [HttpGet("Sale/{DateofSale},{StoreId}")]
        public async Task<ActionResult<GetSaleDTO>> GetSingle(DateTime DateofSale, int StoreId)
        {
            return Ok(await _saleService.GetSales(DateofSale, StoreId));
        }
        [HttpGet("AllSales")]
        public async Task<ActionResult<GetSaleDTO>> GetAll ()
        {
            return Ok(await _saleService.GetAllSales());
        }
        [HttpGet("Sale/{DateofSale}")]
        public async Task<ActionResult<GetSaleDTO>> GetAllDate(DateTime DateofSale)
        {
            return Ok(await _saleService.GetAllSalesDate(DateofSale));
        }
        [HttpGet("Sale/{StoreId}")]
        public async Task<ActionResult<GetSaleDTO>> GetAllStoreId(int StoreId)
        {
            return Ok(await _saleService.GetAllSalesForAStore(StoreId));
        }

        [HttpPost]       
        public async Task<ActionResult<int>> AddSale(AddSalesDTO saleDTO)
        {
            return Ok(await _saleService.AddSale(saleDTO));
        }
        [HttpDelete("SaleRem/{id}")]
        public async Task<ActionResult<int>> RemSale(int id)
        {
            var response = await _saleService.RemoveSale(id);
            if (response == -1)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

    }
}

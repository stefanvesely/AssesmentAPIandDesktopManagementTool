using FullProductAssesment.DTO;
using FullProductAssesment.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Exchange.WebServices.Data;

namespace FullProductAssesment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
       

        [HttpGet("Product/{id}")]
        public async Task<ActionResult<GetProductDTO>> GetSingle(int id)
        {
            return Ok(await _productService.GetSingleProduct(id));
        }

        [HttpPut("EditProduct")]
        public async Task<ActionResult<GetProductDTO>> UpdateProduct(int prodId, GetProductDTO updateProduct)
        {
            var srResponse = await _productService.UpdateProduct(prodId, updateProduct);
            if (srResponse == null)
            {
                return NotFound(srResponse);
            }
            return Ok(srResponse);
        }

        [HttpPut("ProductRem/{id}")]
        public async Task<ActionResult<int>> RemoveProduct(int id)
        {
            var srResponse = await _productService.RemoveProduct(id);
            if (srResponse == -1)
            {
                return NotFound(srResponse);
            }
            return Ok(srResponse);
        }
        [HttpPut("ProductRes/{id}")]
        public async Task<ActionResult<int>> RestoreProduct(int id)
        {
            var srResponse = await _productService.RestoreProduct(id);
            if (srResponse == -1)
            {
                return NotFound(srResponse);
            }
            return Ok(srResponse);
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddProduct(CreateProductDTO product)
        {
            return Ok(await _productService.CreateProduct(product));
        }
        
        [HttpGet("GetAllProducts")]
        public async Task<ActionResult<List<GetProductDTO>>> Get()
        {
            return Ok(await _productService.GetAllProducts());
        }
        [HttpGet("GetActiveProducts")]
        public async Task<ActionResult<List<GetProductDTO>>> GetActive()
        {
            return Ok(await _productService.GetActiveProducts());
        }
        [HttpGet("GetInactiveProducts")]
        public async Task<ActionResult<List<GetProductDTO>>> GetInactive()
        {
            return Ok(await _productService.GetInactiveProducts());
        }
    }

    
}

using FullProductAssesment.DTO;
using FullProductAssesment.Services;
using Microsoft.AspNetCore.Mvc;

namespace FullProductAssesment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : Controller
    {
        private readonly IStoreService _storeService;
        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpGet("Store/{id}")]
        public async Task<ActionResult<GetStoreDTO>> GetSingle(int id)
        {
            return Ok(await _storeService.GetSingleStore(id));
        }
        [HttpPut("EditStore")]
        public async Task<ActionResult<GetStoreDTO>> UpdateStore(int storeId, GetStoreDTO updateStore)
        {
            var srResponse = await _storeService.UpdateStore(storeId, updateStore);
            if (srResponse == null)
            {
                return NotFound(srResponse);
            }
            return Ok(srResponse);
        }
        [HttpPut("StoreRem/{id}")]
        public async Task<ActionResult<int>> RemoveStore(int id)
        {
            var srResponse = await _storeService.RemoveStore(id);
            if (srResponse == -1)
            {
                return NotFound(srResponse);
            }
            return Ok(srResponse);
        }
        [HttpPut("StoreRes/{id}")]
        public async Task<ActionResult<int>> RestoreStore(int id)
        {
            var srResponse = await _storeService.RestoreStore(id);
            if (srResponse == -1)
            {
                return NotFound(srResponse);
            }
            return Ok(srResponse);
        }
        [HttpPost]
        public async Task<ActionResult<int>> AddStore(AddStoreDTO storeDTO)
        {
            return Ok(await _storeService.CreateStore(storeDTO));
        }

        [HttpGet("GetAllStores")]
        public async Task<ActionResult<List<GetStoreDTO>>> GetAllStores()
        {
            return Ok(await _storeService.GetAllStores());
        }
        [HttpGet("GetActiveStores")]
        public async Task<ActionResult<List<GetProductDTO>>> GetActive()
        {
            return Ok(await _storeService.GetActiveStores());
        }
        [HttpGet("GetInactiveStores")]
        public async Task<ActionResult<List<GetProductDTO>>> GetInactive()
        {
            return Ok(await _storeService.GetInactiveStores());
        }
    }
}

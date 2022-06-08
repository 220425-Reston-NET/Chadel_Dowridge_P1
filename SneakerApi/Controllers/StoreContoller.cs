using Microsoft.AspNetCore.Mvc;
using StoreBL;



namespace SneakerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private IStoreBL2 _storeBL;
        public StoreController(IStoreBL2 p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        
        [HttpGet("ViewStoreInventory")]
        public IActionResult ViewStoreInventory([FromQuery] int p_sId)
        {
            return Ok(_storeBL.ViewStoreInventory(p_sId));
        }
    }
}

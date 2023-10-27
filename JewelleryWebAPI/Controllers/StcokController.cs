using JewelleryWebAPI.Interfaces.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JewelleryWebAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class StcokController : ControllerBase
    {
        private readonly IStockManager _stockManager;

        public StcokController(IStockManager stockManager)
        {
            _stockManager = stockManager;
        }
        [HttpGet]
        public async Task<IActionResult> getStockByProductId(int productId)
        {
            decimal? _stockCount = 0;
            try
            {
                _stockCount = _stockManager.stockCountbyId(productId);
               
               
                return Ok(_stockCount);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

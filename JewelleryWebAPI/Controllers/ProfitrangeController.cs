using JewelleryWebAPI.Interfaces.Manager;
using Microsoft.AspNetCore.Mvc;

namespace JewelleryWebAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class ProfitrangeController : ControllerBase
    {
        private readonly IProfitrangeManager _profitrangeManager;

        public ProfitrangeController(IProfitrangeManager profitrangeManager)
        {
            _profitrangeManager = profitrangeManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetProfitByproduct(int productId)
        {
            try
            {
                if (productId==0)
                {
                    return NotFound();
                }
                var profitRange= _profitrangeManager.Get(x=>x.ProductId==productId).FirstOrDefault();
                if (profitRange!=null)
                {
                    return Ok(profitRange);
                }
                else
                {
                    return BadRequest("No data found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}

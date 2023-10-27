using JewelleryWebAPI.Interfaces.Manager;
using Microsoft.AspNetCore.Mvc;

namespace JewelleryWebAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class BlockController : ControllerBase
    {
        private readonly IBlockManager _blockManager;

        public BlockController(IBlockManager blockManager)
        {
            _blockManager = blockManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetBlock(int blockNo)
        {
            try
            {
                var block = _blockManager.Get(x => x.block == blockNo).FirstOrDefault();
                return  Ok(block);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            

        }
    }
}

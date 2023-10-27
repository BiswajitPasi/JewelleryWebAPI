using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JewelleryWebAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class SODController : ControllerBase
    {
        private readonly ISODManager _sodManager;
        private readonly IProductManager _productManager;
        public SODController(ISODManager sodManager,IProductManager productManager)
        {
            _sodManager = sodManager;
            _productManager = productManager;
        }
        [HttpPost]

        public async Task<IActionResult> AddSOD(TblSalesOrderDetails salesDetail)
        {
            try
            {
                if (salesDetail == null)
                {
                    return BadRequest("No data");
                }
                bool _isSaved = await _sodManager.AddAsync(salesDetail);
                if (_isSaved)
                {
                    return Ok(salesDetail.SalesOrderDetailsId);
                }
                else
                {
                    return BadRequest("Failed to save order details");
                }

            }
            catch (Exception ex) { 
            
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        public async Task<IActionResult> GetSOD(int orderId)
        {
            try
            {
                if (orderId == 0)
                {
                    return BadRequest("not order id found");
                }

                var som =  _sodManager.Get(x => x.SalesOrderMasterId == orderId).ToList();
				if (som == null)
				{
					return NotFound("no data found");
				}
				som.ForEach(x =>
                {
                    x.productName = _productManager.getProductName((int)x.ProductId);
                });
                
                return Ok(som.ToList());



            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

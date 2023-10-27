using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JewelleryWebAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class SOMController : ControllerBase
    {
        private readonly ISOMManager _sOMManager;

        public SOMController(ISOMManager sOMManager)
        {
            _sOMManager = sOMManager;
        }
        [HttpPost]
        public async Task<IActionResult> AddSOM(TblSalesOrderMaster orderMaster)
        {
            try
            {
                if (orderMaster == null)
                {
                    return BadRequest("No data");
                }

                bool _isSaved = await _sOMManager.AddAsync(orderMaster);
                if (_isSaved)
                {
                 
                    return Ok(orderMaster.SalesOrderMasterId);
                }
                else
                {
                    return BadRequest("Failes to save order ");
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
        [HttpGet]
        public async Task<string> GetInvoiceNo()
        {

            string invoiceNo = string.Empty;
            try
            {
                int? intIdt = _sOMManager.GetAll().Max(u => (int?) u.SalesOrderMasterId) + 1;
                if (!intIdt.HasValue)
                {
                    intIdt = 1;
                }
                
              invoiceNo="ORD/"+DateTime.Now.ToString("ddMMyyyyhhMM")+"/"+intIdt.ToString();

            }
            catch(Exception ex)
            {
                //return BadRequest(ex.Message);
            }

            return invoiceNo;

        }
        [HttpGet]
        public async Task<IActionResult> GetSOM(int orderId)
        {
            try 
            { 
                if (orderId == 0)
                {
                    return BadRequest("not order id found");
                }
                var som= _sOMManager.Get(x=>x.SalesOrderMasterId==orderId).FirstOrDefault();
                if (som==null)
                {
                    return NotFound("no data found");
                }
                return Ok(som);

               
            
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetSOMbyUser(int userId)
        {
            try
            {
                if (userId == 0)
                {
                    return BadRequest("not order  found");
                }
                var som = _sOMManager.Get(x => x.UserId == userId).ToList();
                if (som == null)
                {
                    return NotFound("no data found");
                }
                return Ok(som);



            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

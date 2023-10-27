using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using JewelleryWebAPI.Tools;
using Microsoft.AspNetCore.Mvc;

namespace JewelleryWebAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class CustomerController : ControllerBase
    {
       private readonly ICustomerManager _customerManager;
        private readonly IUserManager _userManager;

        public CustomerController(ICustomerManager customerManager, IUserManager userManager)
        {
            _customerManager = customerManager;
            _userManager = userManager;
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomer(TblOnlineCustomer customer)
        {
            try
            {
                if (customer == null)
                {
                    return BadRequest("No data");
                }
                var users=_userManager.Get(x=>x.UserName==customer.emailId).FirstOrDefault();
                if (users != null)
                {
                    var customers = _customerManager.Get(x => x.userId == users.UserId).FirstOrDefault();
                    if (customers != null)
                    {
                        return Ok(customers);
                    }
                }
               
                customer.password= HPasssword.hashPassword(customer.password);

                bool _isSaved=await _customerManager.AddAsync(customer);
                if (_isSaved)
                {
                    return Ok(customer);
                }
                else
                {
                    return BadRequest("Failed to save data");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> EditCustomer(TblOnlineCustomer customer)
        {
            try
            {
                if (customer.customerId == 0)
                {
                    return BadRequest("No data");
                }
           

                customer.password = HPasssword.hashPassword(customer.password);

                bool _isSaved = await _customerManager.UpdateAsync(customer);
                if (_isSaved)
                {
                    return Ok(customer);
                }
                else
                {
                    return BadRequest("Failed to save data");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomer(int userId)
        {
            try
            {
                var customer=_customerManager.Get(x=>x.userId == userId).FirstOrDefault();
                if (customer == null)
                {
                    return BadRequest("No data");
                }
                return Ok(customer);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
      
    }
}

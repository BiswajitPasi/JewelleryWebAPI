using CoreApiResponse;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using JewelleryWebAPI.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JewelleryWebAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class UserController : BaseController
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login(TblUser user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest("Not found");
                }
                string pwd = HPasssword.hashPassword(user.Password);
                var users = _userManager.Get(x => x.UserName == user.UserName && x.Password == pwd).Select(x=>new
                {
                   x.UserId,
                   x.UserName,
                   x.Active
                }).FirstOrDefault();
                if (users == null)
                {
                    return BadRequest("Invaild User Name or Password !");
                }
                return  Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to login {ex.Message}");
            }
          

        }
        [HttpGet]
        public async Task<IActionResult> CheckuserName(string userName)
        {
            try
            {
                if (userName==null)
                {
                    return BadRequest("No data");
                }
                var users = _userManager.Get(x => x.UserName == userName).FirstOrDefault();
                if (users == null)
                {
                    return Ok(false);
                }
                return Ok(true);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]

        public async Task<IActionResult> Register(TblUser user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest("No data");
                }
                var users = _userManager.Get(x => x.UserName == user.UserName).FirstOrDefault();
                if (users != null)
                {
                    return BadRequest("User Name Already Exists !");
                }
                user.Password = HPasssword.hashPassword(user.Password);
                user.Active = true;
                user.RoleId = 5;
                bool _isSaved = await _userManager.AddAsync(user);
                if (_isSaved)
                {

                    return Ok(user);
                }
                else
                {
                    return BadRequest("Registration failed");
                }
                

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }


        [HttpPost]

        public async Task<IActionResult> update(TblUser user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest("No data");
                }
                var users = _userManager.Get(x => x.UserId == user.UserId).FirstOrDefault();
                if (users != null)
                {
                    user.Password = HPasssword.hashPassword(user.Password);
                    user.Active = true;
                    user.RoleId = 5;
                    bool _isSaved = await _userManager.UpdateAsync(user);
                    if (_isSaved)
                    {

                        return Ok(user);
                    }
                    else
                    {
                        return BadRequest("Registration failed");
                    }
                }
                else
                {
                    return BadRequest("Not a vaild user");
                }



            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}

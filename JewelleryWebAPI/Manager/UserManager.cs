using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using JewelleryWebAPI.Repository;

namespace JewelleryWebAPI.Manager
{
    public class UserManager : CommonManager<TblUser>, IUserManager
    {
        public UserManager(ApplicationDbContext _dbcontext) : base(new UserRepository(_dbcontext))
        {
        }
    }
}

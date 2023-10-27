using EF.Core.Repository.Repository;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Repository;
using JewelleryWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Repository
{
    public class UserRepository : CommonRepository<TblUser>,IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

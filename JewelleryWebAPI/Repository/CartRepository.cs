using EF.Core.Repository.Repository;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Repository;
using JewelleryWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Repository
{
    public class CartRepository : CommonRepository<TblCart>, ICartRepository
    {
        public CartRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}

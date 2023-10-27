using EF.Core.Repository.Repository;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Repository;
using JewelleryWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Repository
{
    public class ProductRepository : CommonRepository<TblProduct>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

using EF.Core.Repository.Repository;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Repository;
using JewelleryWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Repository
{
    public class CategoryRepository : CommonRepository<TblBrand>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}

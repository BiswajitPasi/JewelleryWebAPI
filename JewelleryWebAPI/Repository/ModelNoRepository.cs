using EF.Core.Repository.Repository;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Repository;
using JewelleryWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Repository
{
    public class ModelNoRepository : CommonRepository<TblModelNo>, IModelNoRepository
    {
        public ModelNoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

using EF.Core.Repository.Repository;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Repository;
using JewelleryWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Repository
{
    public class ProfitrangeRepository : CommonRepository<TblProfitRange>, IProfitrangeRepository
    {
        public ProfitrangeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

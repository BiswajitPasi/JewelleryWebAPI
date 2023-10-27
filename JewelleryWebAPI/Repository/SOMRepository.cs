using EF.Core.Repository.Repository;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Repository;
using JewelleryWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Repository
{
    public class SOMRepository : CommonRepository<TblSalesOrderMaster>, ISOMRepository
    {
        public SOMRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

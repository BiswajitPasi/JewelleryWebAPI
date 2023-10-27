using EF.Core.Repository.Repository;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Repository;
using JewelleryWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;

namespace JewelleryWebAPI.Repository
{
    public class StockRepository : CommonRepository<TblStockPosting>, IStockRepository
    {
        public StockRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

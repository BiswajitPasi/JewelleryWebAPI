using EF.Core.Repository.Repository;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Repository;
using JewelleryWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Repository
{
    public class SODRepository : CommonRepository<TblSalesOrderDetails>, ISODRepository
    {
        public SODRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

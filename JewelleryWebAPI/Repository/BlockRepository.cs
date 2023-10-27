using EF.Core.Repository.Repository;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Repository;
using JewelleryWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Repository
{
    public class BlockRepository : CommonRepository<TblBlock>, IBlockRepository
    {
        public BlockRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

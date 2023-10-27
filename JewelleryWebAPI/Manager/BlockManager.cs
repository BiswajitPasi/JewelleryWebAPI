using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using JewelleryWebAPI.Repository;

namespace JewelleryWebAPI.Manager
{
    public class BlockManager : CommonManager<TblBlock>, IBlockManager
    {
        public BlockManager(ApplicationDbContext _dbcontext) : base(new BlockRepository(_dbcontext))
        {

        }
    }
}

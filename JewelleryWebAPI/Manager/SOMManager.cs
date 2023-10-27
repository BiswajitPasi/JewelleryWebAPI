using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using JewelleryWebAPI.Repository;

namespace JewelleryWebAPI.Manager
{
    public class SOMManager : CommonManager<TblSalesOrderMaster>, ISOMManager
    {
        public SOMManager(ApplicationDbContext _dbContext) : base(new SOMRepository(_dbContext))
        {

        }
    }
}

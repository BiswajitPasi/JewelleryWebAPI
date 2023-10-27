using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using JewelleryWebAPI.Repository;

namespace JewelleryWebAPI.Manager
{
    public class ProfitrangeManager : CommonManager<TblProfitRange>, IProfitrangeManager
    {
        public ProfitrangeManager(ApplicationDbContext _dbcontext) : base(new ProfitrangeRepository(_dbcontext))
        {
        }
    }
}

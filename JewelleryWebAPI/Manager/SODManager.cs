using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using JewelleryWebAPI.Repository;

namespace JewelleryWebAPI.Manager
{
    public class SODManager : CommonManager<TblSalesOrderDetails>, ISODManager
    {
        public SODManager(ApplicationDbContext _context) : base(new SODRepository(_context))
        {
        }
    }
}

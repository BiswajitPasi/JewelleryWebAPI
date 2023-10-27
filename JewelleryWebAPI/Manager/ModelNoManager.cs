using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using JewelleryWebAPI.Repository;

namespace JewelleryWebAPI.Manager
{
    public class ModelNoManager : CommonManager<TblModelNo>, IModelNoManager
    {
        public ModelNoManager(ApplicationDbContext _context) : base(new ModelNoRepository(_context))
        {

        }

        public string getModelNamebyId(decimal id)
        {
            return GetFirstOrDefault(x=>x.ModelNoId==id).ModelNo;
        }
    }
}

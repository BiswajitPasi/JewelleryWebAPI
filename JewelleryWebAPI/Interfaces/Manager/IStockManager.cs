using EF.Core.Repository.Interface.Manager;
using JewelleryWebAPI.Models;

namespace JewelleryWebAPI.Interfaces.Manager
{
    public interface IStockManager:ICommonManager<TblStockPosting>
    {
        decimal? stockCountbyId(int productId);
    }
}

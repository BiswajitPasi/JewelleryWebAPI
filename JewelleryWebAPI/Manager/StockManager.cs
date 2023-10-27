using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using JewelleryWebAPI.Repository;

namespace JewelleryWebAPI.Manager
{
    public class StockManager : CommonManager<TblStockPosting>, IStockManager
    {
        public StockManager(ApplicationDbContext _dbcontext) : base(new StockRepository(_dbcontext))
        {
        }

        public decimal? stockCountbyId(int productId)
        {
            decimal? _stockCount = 0;
          
                var Balances = Get(p => p.ProductId == productId).GroupBy(
                y => y.ProductId,
                y => (y.InwardQty, y.OutwardQty),
                (key, elements) => new {
                    //  productId = key,
                    Total = elements.Sum(el => el.InwardQty > 0 ? el.InwardQty : -el.OutwardQty)
                });
                if (Balances.Count() > 0)
                {
                    _stockCount = Balances.FirstOrDefault().Total;
                }

                return _stockCount;
          
        }
    }
}

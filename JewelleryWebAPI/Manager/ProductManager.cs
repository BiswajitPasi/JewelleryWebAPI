using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using JewelleryWebAPI.Repository;

namespace JewelleryWebAPI.Manager
{
    public class ProductManager : CommonManager<TblProduct>, IProductManager
    {
        public ProductManager(ApplicationDbContext _dbcontext) : base(new ProductRepository(_dbcontext))
        {
        }

        public TblProduct GetProductsbyId(int productId)
        {
            return GetFirstOrDefault(x=>x.ProductId==productId);
        }

        public ICollection<TblProduct> GetProductsByPage(int page, int pageSize)
        {
            if (page <= 1)
            {
                page = 0;
            }
            int totalNumber = page * pageSize;
            return GetAll().Skip(totalNumber).Take(pageSize).ToList();
        }

        public ICollection<TblProduct> SearchProducts(string srchText)
        {
            
            return Get(x => x.ProductName.ToLower().Contains(srchText.ToLower())).ToList();

        }

        public ICollection<TblProduct> SearchProductsByCategory(int categoryId)
        {
           return Get(x=>x.BrandId==categoryId).ToList();
        }
        public string getProductName(int id)
        {
            return GetFirstOrDefault(x => x.ProductId == id).ProductName;
        }
    }
}

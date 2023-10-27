using EF.Core.Repository.Interface.Manager;
using JewelleryWebAPI.Models;

namespace JewelleryWebAPI.Interfaces.Manager
{
    public interface IProductManager: ICommonManager<TblProduct>
    {
        ICollection<TblProduct> GetProductsByPage(int page,int pageSize);
        ICollection<TblProduct> SearchProducts(string srchText);
        ICollection<TblProduct> SearchProductsByCategory(int categoryId);
        TblProduct GetProductsbyId(int productId);
        string getProductName(int id);
    }
}

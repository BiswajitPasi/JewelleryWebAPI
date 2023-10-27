using EF.Core.Repository.Interface.Manager;
using JewelleryWebAPI.Models;

namespace JewelleryWebAPI.Interfaces.Manager
{
    public interface ICategoryManager:ICommonManager<TblBrand>
    {
        TblBrand getbyid(int id);
        ICollection<TblBrand> getallbyname(string name);
        ICollection<TblBrand> searchCategory(string text);
        ICollection<TblBrand> getCategory(int page,int pageSize);
        string getCategoryName(int id);
    }
}

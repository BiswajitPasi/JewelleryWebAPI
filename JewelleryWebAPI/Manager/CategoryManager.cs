using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using JewelleryWebAPI.Repository;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Manager
{
    public class CategoryManager : CommonManager<TblBrand>, ICategoryManager
    {
        public CategoryManager(ApplicationDbContext _dbContext) : base(new CategoryRepository(_dbContext))
        {
        }

        public ICollection<TblBrand> getallbyname(string name)
        {
            return Get(x => x.BrandName.ToLower() == name.ToLower());
        }

        public TblBrand getbyid(int id)
        {
           
            return GetFirstOrDefault(x=>x.BrandId== id);
        }

        public ICollection<TblBrand> getCategory(int page, int pageSize)
        {
            if (page <= 1)
            {
                page= 0;
            }
            int totalNumber=page*pageSize;
            return GetAll().Skip(totalNumber).Take(pageSize).ToList();
        }

        public string getCategoryName(int id)
        {
            return GetFirstOrDefault(x => x.BrandId == id).BrandName;
        }

        public ICollection<TblBrand> searchCategory(string text)
        {
            return Get(x=>x.BrandName.ToLower().Contains(text.ToLower()));
        }
        // use stroed procedure
        //public ICollection<TblBrand> getBrand(ApplicationDbContext dbContext)
        //{
        //    return dbContext.tbl_Brand.FromSql($"procedureName {parameters}");
        //}
    }
}

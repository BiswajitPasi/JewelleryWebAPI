using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using JewelleryWebAPI.Repository;

namespace JewelleryWebAPI.Manager
{
    public class FileUploadManager : CommonManager<TblDocumentManage>, IFileUploadManager
    {
        public FileUploadManager(ApplicationDbContext _dbcontext) : base(new FileUploadRepository(_dbcontext))
        {

        }

        public ICollection<TblDocumentManage> GetImagesByProductId(int productId)
        {
           return Get(x=>x.ProductId==productId);
        }
    }
}

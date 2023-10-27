using EF.Core.Repository.Interface.Manager;
using JewelleryWebAPI.Models;

namespace JewelleryWebAPI.Interfaces.Manager
{
    public interface IFileUploadManager:ICommonManager<TblDocumentManage>
    {
        ICollection<TblDocumentManage> GetImagesByProductId(int productId);
    }
}

using EF.Core.Repository.Repository;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Repository;
using JewelleryWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Repository
{
    public class FileUploadRepository : CommonRepository<TblDocumentManage>, IFileUploadRepository
    {
        public FileUploadRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}

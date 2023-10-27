using CoreApiResponse;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using Microsoft.AspNetCore.Mvc;


namespace JewelleryWebAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class FileUploadController : BaseController
    {
        private readonly  IWebHostEnvironment _environment;
        private readonly IFileUploadManager _uploadManager;

        public FileUploadController(IWebHostEnvironment environment, IFileUploadManager uploadManager)
        {
            _environment = environment;
            this._uploadManager = uploadManager;
        }
        [NonAction]
        public string RenameFile(string filePath)
        {
            string strExt = Path.GetExtension(filePath);
            string fileName = Guid.NewGuid().ToString("N") + strExt;
            return fileName;
        }
        [HttpPost]
        public async Task<IActionResult> UploadFile([FromForm] TblDocumentManage documentManage)
        {

           

            try
            {
                if (documentManage == null)
                {
                    return BadRequest("No data entered");
                }
                string strExt = Path.GetExtension(documentManage.files.FileName);
               // string fileName = Path.GetFileName(documentManage.files.FileName);
                string fileName = RenameFile(documentManage.files.FileName);
                documentManage.DocName = fileName;
                documentManage.UploadDt = DateTime.Now;
                string strPAth = _environment.WebRootPath + "\\Upload\\" + documentManage.ProductId + "\\";
                documentManage.FileName = "\\Upload\\"+documentManage.ProductId+"\\" + fileName;
                if (documentManage.files.Length > 0)
                {
                    if (!Directory.Exists(strPAth))
                    {
                        Directory.CreateDirectory(strPAth);
                    }

                    using (FileStream filestream = System.IO.File.Create(strPAth + fileName))
                    {
                      await  documentManage.files.CopyToAsync(filestream).ConfigureAwait(false);
                       await filestream.FlushAsync().ConfigureAwait(false);
                        await  _uploadManager.AddAsync(documentManage).ConfigureAwait(false);


                        //  return "\\Upload\\" + objFile.files.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
               return BadRequest(ex.Message);
            }

            return Ok(documentManage);
        }


    }
}

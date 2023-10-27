using CoreApiResponse;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace JewelleryWebAPI.Controllers
{

    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class CategoryController : BaseController
    {

        private readonly ICategoryManager _categoryManager;
        private readonly IProductManager _productManager;
        private readonly IFileUploadManager _fileUploadManager;
       
        public CategoryController(ICategoryManager categoryManager,IProductManager productManager,IFileUploadManager fileUploadManager)
        {
            _categoryManager = categoryManager;
            _productManager = productManager;
            _fileUploadManager = fileUploadManager;
        }

        [HttpGet]
        public IActionResult GetAllCategory()
        {
            try
            {
                var categroies = _categoryManager.GetAll().OrderBy(c=>c.BrandName).ThenBy(c=>c.BrandId).ToList();
                categroies.ForEach(c => {


                    c.Products = _productManager.SearchProductsByCategory((int)c.BrandId).ToList();
                    c.Products.ToList().ForEach(x => {

                        
                            x.documentManages = _fileUploadManager.GetImagesByProductId((int)x.ProductId).ToList();
                      
                       

                    });

                });
                categroies=categroies.Where(c=>c.BrandId>0).ToList();

                
                return Ok(categroies);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
        [HttpGet]
        public IActionResult GetOnlyCategory()
        {
            try
            {
                var categroies = _categoryManager.GetAll().OrderBy(c => c.BrandName).ThenBy(c => c.BrandId).ToList();
             
                categroies = categroies.Where(c => c.BrandId > 0).ToList();

                
                return Ok(categroies);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("name")]
        public IActionResult GetCategoryByName(string name)
        {
            try
            {
                var categories = _categoryManager.getallbyname(name);
                return CustomResult("Data loaded", categories);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
        [HttpGet("name")]
        public IActionResult SearchCategory(string text)
        {
            try
            {
                var categories = _categoryManager.searchCategory(text);
                return CustomResult("Data found", categories);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        public IActionResult GetCategory(int page=1)
        {
            try
            {
                var categories = _categoryManager.getCategory(page,10);
                return CustomResult("Paging Data for page no"+page, categories.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("id")]
        public IActionResult GetCategoryById(int id)
        {
            try
            {
                var category = _categoryManager.getbyid(id);
                if (category == null)
                {
                    return CustomResult("Data not found",HttpStatusCode.NotFound);
                }
                return CustomResult("Data found",category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
        [HttpPost]
        public IActionResult AddCategory(TblBrand category)
        {
            try
            {
                if (category == null)
                {
                    return CustomResult("No data",HttpStatusCode.NoContent);
                }
                bool _isSaved = _categoryManager.Add(category);
                if (_isSaved)
                {
                    return CustomResult("Data Saved", category);
                }
                return CustomResult("Failed to save",HttpStatusCode.BadRequest);
            }
            catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
            
        }
        [HttpPut]
        public IActionResult EditCategory(TblBrand category)
        {
            try
            {
                if (category.BrandId == 0)
                {
                    return CustomResult("Id is missing",HttpStatusCode.NotFound);
                }
                bool _isUpdate = _categoryManager.Update(category);
                if (_isUpdate)
                {
                    return CustomResult("Data updated",category,HttpStatusCode.OK);

                }
                return CustomResult("Faild to update", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            try
            {
                var category = _categoryManager.getbyid(id);
                if (category == null)
                {
                    return CustomResult("Not found",HttpStatusCode.NotFound);
                }
                bool _isDelete = _categoryManager.Delete(category);
                if (_isDelete)
                {
                    return CustomResult("Category deleted");
                }
                return CustomResult("delete failed", HttpStatusCode.BadRequest);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
         
        }
    }
}

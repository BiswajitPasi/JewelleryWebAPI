using CoreApiResponse;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using JewelleryWebAPI.Tools;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace JewelleryWebAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class ProductController : BaseController
    {
        private const string ApiBaseUrl = "https://www.goldapi.io/api/XAU/USD";
        private const string ApiAccessToken = "goldapi-20t2ghuki4p6pu9-io";
        private readonly IProductManager _productManager;
        private readonly IFileUploadManager _fileUploadManager;
        private readonly ICategoryManager _categoryManager;
        private readonly IStockManager _stockManager;
        private readonly IModelNoManager _modelNoManager;

        public ProductController(IProductManager productManager, IFileUploadManager fileUploadManager, ICategoryManager categoryManager, IStockManager stockManager, IModelNoManager modelNoManager)
        {
            _productManager = productManager;
            _fileUploadManager = fileUploadManager;
            _categoryManager = categoryManager;
            _stockManager = stockManager;
            _modelNoManager = modelNoManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            try
            {
                decimal salesRate = 0;
                decimal vat = 0;
                decimal goldRateusd = await GetGoldRateUSD();
                var products=_productManager.GetAll().ToList().OrderBy(x=>x.ProductId).Where(x=>x.BrandId!=1 && x.BrandId!=7).ToList();
                products.ForEach(async c => {
                                     
                    c.GoldRateUsd = goldRateusd;
                    if (c.GoldRateUsd>0)
                    {
                        c.GoldPrice = convertGoldRatetoBHD((decimal)c.GoldRateUsd, (decimal)c.ModelNoId);
                    }
                    salesRate = (decimal)((c.GoldPrice + c.Mc) * c.Weight + c.Mpc);
                    if (c.TaxId>0)
                    {
                        vat = (decimal)( salesRate * 10) / 100;
                    }
                   
                    c.SalesRate = salesRate + vat;
                    c.vat= vat;
                    c.stockCount = _stockManager.stockCountbyId((int) c.ProductId);

                    c.documentManages = _fileUploadManager.GetImagesByProductId((int)c.ProductId).ToList();
                    c.modelName=_modelNoManager.getModelNamebyId((decimal)c.ModelNoId);

                });
                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

      
        [NonAction]
        public  async Task<decimal> GetGoldRateUSD()
        {
            decimal goldRate = 0;
            try
            {
                var data = new AccessToken();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ApiBaseUrl);


                    client.DefaultRequestHeaders.Add("x-access-token", ApiAccessToken);
                    // client.DefaultRequestHeaders.Add("Content-Type", "application/json");
                    using (var response = client.GetAsync(client.BaseAddress).Result)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            data = JsonConvert.DeserializeObject<AccessToken>(apiResponse);

                            if (data != null)
                            {
                                goldRate = Convert.ToDecimal(data.price);
                            }
                        }
                    }
                }
              

            }
            catch (Exception ex)
            {
                
            }
            return goldRate;
        }
        [NonAction]
        public decimal convertGoldRatetoBHD(decimal goldRate,decimal caratId)
        {
            decimal priceperGram = 0;
            decimal value =(decimal) 1.417;
            if (caratId==2)
            {
                priceperGram= (goldRate * value) / (decimal) 116.64;
            }
           else if (caratId==3)
            {
                priceperGram = (goldRate * value) / (decimal) 126.2;
            }
            else if (caratId == 4)
            {
                priceperGram = (goldRate * value) /(decimal) 132.4;
            }
            else if (caratId == 1002)
            {
                priceperGram = (goldRate * value) / (decimal) 155.5;
            }

            return priceperGram;
        }


        [HttpGet]
        public IActionResult GetProductByPage(int page=1)
        {
            var products= _productManager.GetProductsByPage(page,50).ToList();
            return CustomResult("Paged Data for page "+page, products, HttpStatusCode.OK);
        }
        [HttpGet("srchText")]
        public async Task<IActionResult> SearchProducts(string srchText)
        {
           
            decimal salesRate = 0;
            decimal vat = 0;
            decimal goldRateusd = await GetGoldRateUSD();
            var products = _productManager.SearchProducts(srchText).ToList().Where(x => x.BrandId != 1 && x.BrandId != 7).OrderBy(x=>x.ProductName).ToList();
            products.ForEach(c => {
                c.GoldRateUsd = goldRateusd;
                if (c.GoldRateUsd > 0)
                {
                    c.GoldPrice = convertGoldRatetoBHD((decimal)c.GoldRateUsd, (decimal)c.ModelNoId);
                }
                
                salesRate = (decimal)((c.GoldPrice + c.Mc) * c.Weight + c.Mpc);
                if (c.TaxId > 0)
                {
                    vat = (decimal)(salesRate * 10) / 100;
                }
                c.SalesRate = salesRate + vat;
                c.vat = vat;
              
                c.SalesRate = salesRate;
                c.stockCount = _stockManager.stockCountbyId((int)c.ProductId);
                c.documentManages = _fileUploadManager.GetImagesByProductId((int)c.ProductId).ToList();
                c.modelName = _modelNoManager.getModelNamebyId((decimal)c.ModelNoId);

            });
            return Ok( products);
        }
        [HttpGet("categoryId")]
        public async Task<IActionResult> SearchProductByCategory(int categoryId)
        {
           
            decimal salesRate = 0;
            decimal vat = 0;
            decimal goldRateusd = await GetGoldRateUSD();
            var products=_productManager.SearchProductsByCategory(categoryId).Where(x => x.BrandId != 1 && x.BrandId != 7).OrderBy(x=>x.ProductId).ToList();
            products.ForEach(c => {

                c.GoldRateUsd = goldRateusd;
                if (c.GoldRateUsd > 0)
                {
                    c.GoldPrice = convertGoldRatetoBHD((decimal)c.GoldRateUsd, (decimal)c.ModelNoId);
                }
               
                salesRate = (decimal)((c.GoldPrice + c.Mc) * c.Weight + c.Mpc);
                if (c.TaxId > 0)
                {
                    vat = (decimal)(salesRate * 10) / 100;
                }
                c.SalesRate = salesRate + vat;
                c.vat = vat;
                c.SalesRate= salesRate;
                c.stockCount = _stockManager.stockCountbyId((int)c.ProductId);
                c.documentManages = new List<TblDocumentManage>();
                    c.documentManages = _fileUploadManager.GetImagesByProductId((int) c.ProductId).ToList();
                c.modelName = _modelNoManager.getModelNamebyId((decimal)c.ModelNoId);

            });
            return Ok( products);
        }
        [HttpGet("productId")]
        public async Task<IActionResult> GetProductbyId(int productId)
        {
            try
            {
                if (productId == 0)
                {
                    return NoContent();
                }
                decimal salesRate = 0;
                decimal vat = 0;
                decimal goldRateusd = await GetGoldRateUSD();

                var products = _productManager.GetProductsbyId(productId);
                products.stockCount =  _stockManager.stockCountbyId((int)productId);
                products.brandName = _categoryManager.getCategoryName((int)products.BrandId);
				products.documentManages = new List<TblDocumentManage>();
				products.documentManages = _fileUploadManager.GetImagesByProductId(productId).ToList();
                products.GoldRateUsd = goldRateusd;
                if (products.GoldRateUsd > 0)
                {
                    products.GoldPrice = convertGoldRatetoBHD((decimal)products.GoldRateUsd, (decimal)products.ModelNoId);
                }
                salesRate = (decimal)((products.GoldPrice + products.Mc) * products.Weight + products.Mpc);
                if (products.TaxId > 0)
                {
                    vat = (decimal)(salesRate * 10) / 100;
                }
               
                products.SalesRate = salesRate + vat;
                products.vat = vat;
                products.modelName = _modelNoManager.getModelNamebyId((decimal)products.ModelNoId);


                return Ok(products);
			}
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
    }
}

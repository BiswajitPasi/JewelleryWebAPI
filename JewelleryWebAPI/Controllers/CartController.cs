using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using Microsoft.AspNetCore.Mvc;


namespace JewelleryWebAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class CartController : ControllerBase
    {
        private readonly ICartManager _cartManager;
        private readonly IProductManager _productManager;
        private readonly IFileUploadManager _uploadManager;

        public CartController(ICartManager cartManager, IProductManager productManager, IFileUploadManager uploadManager)
        {
            _cartManager = cartManager;
            _productManager = productManager;
            _uploadManager = uploadManager;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var cart = _cartManager.GetAll();

            return Ok(cart);
        }
        [HttpGet("CartKey")]
        public IActionResult GetCart(string CartKey)
        {
            var cart=_cartManager.GetCarts(CartKey).ToList();
            cart.ForEach(c =>
            {
                c.productName = _productManager.getProductName(c.productId);
                //x.GetDocumentManage = new List<TblDocumentManage>();
                //x.GetProduct = _productManager.GetProductsbyId(x.productId);
                c.documentManages = _uploadManager.GetImagesByProductId(c.productId).FirstOrDefault();
            });


                

            return Ok(cart);
        }
        [HttpPost]
        public IActionResult AddCart(TblCart cart)
        {
            try
            {
                if (cart == null)
                {
                    return BadRequest("No data");
                }
                var carts = _cartManager.GetCarts(cart.cartKey).ToList();


                int index = IsExist(cart.productId.ToString(), carts);
                if (index != -1)
                {
                    
                    
                     cart.productId = cart.productId;
                    cart.qunatity = index + 1;
                    cart.totPrice = cart.price * cart.qunatity;
                    _cartManager.Update(cart);
                    return Ok(cart);
                }
                else
                {
                    var cartsAll = _cartManager.GetAll().ToList();

                    int index1 = IsExist(cart.productId.ToString(), cartsAll);
                    if (index1 != -1)
                    {
                        _cartManager.Delete(cart);

                    }
                   
                     _cartManager.Add(cart);
                   
                        return Ok(cart);
                    
                }


               // return BadRequest("Failed to save");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [NonAction]
        private int IsExist(string id, IList<TblCart> carts)
        {
            List<TblCart> cart = carts.ToList();
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].productId.ToString().Equals(id))
                {
                    return cart[i].qunatity;
                }
            }
            return -1;
        }
        [HttpDelete]
        public IActionResult DeleteCart(string  CartKey,int productId)
        {
            try
            {
                var cart = _cartManager.GetCart(CartKey,productId);
                if (cart == null)
                {
                    return BadRequest("Not found");
                }
                bool _isDelete = _cartManager.Delete(cart);
                if (_isDelete)
                {
                    return Ok("Cart deleted");
                }
                return BadRequest("delete failed");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}

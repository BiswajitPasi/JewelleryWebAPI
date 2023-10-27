using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using JewelleryWebAPI.Repository;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Manager
{
    public class CartManager : CommonManager<TblCart>, ICartManager
    {
     
        public CartManager(ApplicationDbContext _dbcontext) : base(new CartRepository(_dbcontext))
        {
           
        }

        public void AddCart(TblCart cart)
        {
           
           Add(cart);
        }

        public TblCart GetCart(string CartKey,int productId)
        {
            return GetFirstOrDefault(x => x.cartKey == CartKey && x.productId==productId );

        }

        public ICollection<TblCart> GetCarts(string CartKey)
        {
            return Get(x=>x.cartKey==CartKey).ToList();
        }

        //public void UpdateCart( TblCart cart)
        //{
        //    //_context.tbl_Cart.Attach(cart);
        //    //_context.Entry(cart).State = EntityState.Modified;
        //    //_context.SaveChanges();
        //}
    }
}

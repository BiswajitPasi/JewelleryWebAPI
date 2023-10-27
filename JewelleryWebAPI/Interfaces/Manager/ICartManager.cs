using EF.Core.Repository.Interface.Manager;
using JewelleryWebAPI.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace JewelleryWebAPI.Interfaces.Manager
{
    public interface ICartManager:ICommonManager<TblCart> 
    {
        void AddCart(TblCart cart);
        ICollection<TblCart> GetCarts(string CartKey);
        TblCart GetCart(string CartKey,int productId);
        //void UpdateCart( TblCart cart);
    }
}

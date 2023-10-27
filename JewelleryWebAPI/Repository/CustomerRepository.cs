using EF.Core.Repository.Repository;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Repository;
using JewelleryWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Repository
{
    public class CustomerRepository : CommonRepository<TblOnlineCustomer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}

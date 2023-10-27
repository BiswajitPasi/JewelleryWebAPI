using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Models;
using JewelleryWebAPI.Repository;

namespace JewelleryWebAPI.Manager
{
    public class CustomerManager : CommonManager<TblOnlineCustomer>, ICustomerManager
    {
        public CustomerManager(ApplicationDbContext _dbcontext) : base(new CustomerRepository(_dbcontext))
        {

        }
    }
}

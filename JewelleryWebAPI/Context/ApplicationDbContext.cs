//using JewelleryWebAPI.Models;
using JewelleryWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){

            //  ChangeTracker.QueryTrackingBehavior=QueryTrackingBehavior.
            this.ChangeTracker.LazyLoadingEnabled = false;

        }
        public DbSet<TblBrand> tbl_Brand { get; set; }
        public DbSet<TblProduct> tbl_product { get; set; }
        public DbSet<TblDocumentManage> tbl_DocumentManage { get; set; }
        public DbSet<TblCart> tbl_Cart { get; set; }
        public DbSet<TblUser> tbl_User { get; set; }
        public DbSet<TblBlock> tbl_Block { get; set; }
        public DbSet<TblOnlineCustomer> tbl_OnlineCustomer { get; set; }
        public DbSet<TblSalesOrderMaster> tbl_SalesOrderMaster { get; set; }
        public DbSet<TblSalesOrderDetails> tbl_SalesOrderDetails { get; set; }
        public DbSet<TblStockPosting> tbl_StockPosting { get; set; }
        public DbSet<TblProfitRange> tbl_ProfitRange { get; set; }
        public DbSet<TblModelNo> tbl_ModelNo { get; set; }
    }
}

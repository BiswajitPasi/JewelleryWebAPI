using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewelleryWebAPI.Models
{
    //[Keyless]
    public partial class TblCart
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       // public int cartId { get; set; }
        public string? cartKey { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int productId { get; set; }
        public int qunatity { get; set; }

        public decimal price { get; set; }
        public decimal totPrice { get; set; }
        public DateTime createDate { get; set; }

        //[NotMapped]
        //public TblProduct GetProduct { get; set; }
        //[NotMapped]
        //public TblDocumentManage GetDocumentManage { get; set; }
        [NotMapped]
        public virtual TblDocumentManage? documentManages { get; set; }
        [NotMapped]
        public string? productName { get; set; }
    }
}

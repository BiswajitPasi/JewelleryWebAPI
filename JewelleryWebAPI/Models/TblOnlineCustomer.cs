using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JewelleryWebAPI.Models
{
    public partial class TblOnlineCustomer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int customerId { get; set; }
        public int userId { get; set; }
        public string? firstName { get; set; }   
        public string? lastName { get; set; }
        public string? emailId { get; set; }
        public string? mobileNo { get; set; }
        public string? flatNo { get; set; }
        public string? buildingNo { get; set; }
        public string? roadNo { get; set; }
        public int blockNo { get; set; }
        public string? area { get; set; }
        public string? landmark { get; set; }
        public string? extra1 { get; set; }
        public string? extra2 { get; set; }
        public DateTime extraDate { get; set; }
        public string? password { get; set; }

    }
}

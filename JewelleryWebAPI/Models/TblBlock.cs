using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI.Models
{
    [Keyless]
    public partial class TblBlock
    {
        public int block { get; set; }
        public string area { get; set; }
        public string governorate { get; set; }
    }
}
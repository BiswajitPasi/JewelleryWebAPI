using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblStockTemp
{
    public decimal? ProductId { get; set; }

    public decimal? GodownId { get; set; }

    public decimal? Qty { get; set; }
}

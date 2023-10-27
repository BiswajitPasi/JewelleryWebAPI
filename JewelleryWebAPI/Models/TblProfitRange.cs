using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

[Keyless]
public partial class TblProfitRange
{
    public int Srno { get; set; }

    public decimal? FromWeight { get; set; }

    public decimal? ToWeight { get; set; }

    public decimal? DProfit { get; set; }

    public decimal? MaxProfit { get; set; }

    public decimal? ProductId { get; set; }
}

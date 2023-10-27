using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblProjectCostH
{
    public int Srno { get; set; }

    public int? ProjectId { get; set; }

    public int? LedgerId { get; set; }

    public decimal? TotalCost { get; set; }

    public DateTime? Date { get; set; }

    public int? UserId { get; set; }
}

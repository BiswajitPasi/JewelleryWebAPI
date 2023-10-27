using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblProjectCostD
{
    public int Srno { get; set; }

    public int? ProjectCostId { get; set; }

    public int? AccledgerId { get; set; }

    public decimal? Amount { get; set; }
}

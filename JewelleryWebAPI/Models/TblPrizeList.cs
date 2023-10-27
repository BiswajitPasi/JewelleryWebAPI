using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblPrizeList
{
    public int Srno { get; set; }

    public string PriceCode { get; set; } = null!;

    public string? PriceAmount { get; set; }

    public string? Status { get; set; }

    public int? UtilizeWithEmp { get; set; }

    public int? RecCode { get; set; }
}

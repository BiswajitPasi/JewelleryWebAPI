using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblPackageHead
{
    public int Srno { get; set; }

    public string? PackageName { get; set; }

    public decimal? TotalQty { get; set; }

    public decimal? TotalAmount { get; set; }

    public bool? Active { get; set; }
}

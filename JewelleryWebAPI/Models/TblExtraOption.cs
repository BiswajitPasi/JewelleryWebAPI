using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblExtraOption
{
    public int Srno { get; set; }

    public string? ExtraOption { get; set; }

    public decimal? Price { get; set; }

    public string? Status { get; set; }
}

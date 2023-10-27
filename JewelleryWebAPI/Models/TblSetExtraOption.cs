using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblSetExtraOption
{
    public int Srno { get; set; }

    public int? ProductId { get; set; }

    public int? ExtraOptionId { get; set; }

    public string? Status { get; set; }
}

using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblTable
{
    public int TableId { get; set; }

    public int? TableTypeId { get; set; }

    public string? TableNo { get; set; }

    public int? MaximumCap { get; set; }

    public string? Naration { get; set; }

    public string? Status { get; set; }

    public bool? Reserved { get; set; }
}

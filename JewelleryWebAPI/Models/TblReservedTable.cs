using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblReservedTable
{
    public int Srno { get; set; }

    public string? OrderId { get; set; }

    public int? TableId { get; set; }

    public bool? Status { get; set; }
}

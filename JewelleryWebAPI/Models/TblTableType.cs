using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblTableType
{
    public int TableTypeId { get; set; }

    public string? TypeName { get; set; }

    public string? Naration { get; set; }

    public string? Status { get; set; }
}

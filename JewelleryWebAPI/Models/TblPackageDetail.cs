using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblPackageDetail
{
    public int SrNo { get; set; }

    public int? PackageId { get; set; }

    public int? ProductId { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Amount { get; set; }
}

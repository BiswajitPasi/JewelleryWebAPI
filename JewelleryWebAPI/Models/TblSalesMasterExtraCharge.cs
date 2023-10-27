using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblSalesMasterExtraCharge
{
    public int Srno { get; set; }

    public decimal? SalesMasterId { get; set; }

    public string? ExtraChargeNm { get; set; }

    public decimal? ExtraAmount { get; set; }
}

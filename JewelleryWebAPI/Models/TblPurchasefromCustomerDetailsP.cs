using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblPurchasefromCustomerDetailsP
{
    public int Srno { get; set; }

    public int? PurchaseMasterId { get; set; }

    public int? ProductId { get; set; }

    public int? GoldTypeId { get; set; }

    public string? Productode { get; set; }

    public string? ItemDescription { get; set; }

    public int? UnitId { get; set; }

    public decimal? RawWeight { get; set; }

    public decimal? Less { get; set; }

    public decimal? ActualWeight { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Price { get; set; }

    public decimal? LessPrice { get; set; }

    public decimal? Amount { get; set; }
}

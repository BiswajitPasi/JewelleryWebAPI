using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblPurchasefromCustomerDetailsP1
{
    public int Srno { get; set; }

    public int? PurchaseMasterId { get; set; }

    public int? ProductId { get; set; }

    public string? ProductCode { get; set; }

    public string? ItemDesc { get; set; }

    public int? UnitId { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Price { get; set; }

    public decimal? MakingCharge { get; set; }

    public decimal? MpCharge { get; set; }

    public decimal? Vat { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? ProfitGrm { get; set; }

    public decimal? Profit { get; set; }

    public decimal? SalePrice { get; set; }

    public decimal? Discount { get; set; }

    public decimal? TaxId { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Amount { get; set; }

    public string? Formula { get; set; }
}

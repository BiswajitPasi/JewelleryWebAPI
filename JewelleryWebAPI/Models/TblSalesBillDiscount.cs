using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblSalesBillDiscount
{
    public decimal SalesBillTaxId { get; set; }

    public decimal? SalesMasterId { get; set; }

    public decimal? DiscountId { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public decimal? DiscountAmount { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}

using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblDiscount
{
    public int Srno { get; set; }

    public string? FixedOrNot { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Automatically { get; set; }

    public string? DiscountOn { get; set; }

    public string? OfferOnpayMode { get; set; }

    public decimal? SalesQty { get; set; }

    public decimal? MinAmount { get; set; }

    public decimal? MaxAmount { get; set; }

    public string? DiscountName { get; set; }

    public string? PromoCode { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public string? Status { get; set; }

    public string? Naration { get; set; }

    public string? DiscountType { get; set; }
}

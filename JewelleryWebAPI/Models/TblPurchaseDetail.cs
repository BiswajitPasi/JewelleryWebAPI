using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblPurchaseDetail
{
    public decimal PurchaseDetailsId { get; set; }

    public decimal? PurchaseMasterId { get; set; }

    public decimal? ReceiptDetailsId { get; set; }

    public decimal? OrderDetailsId { get; set; }

    public decimal? ProductId { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Rate { get; set; }

    public decimal? UnitId { get; set; }

    public decimal? UnitConversionId { get; set; }

    public decimal? Discount { get; set; }

    public decimal? TaxId { get; set; }

    public decimal? BatchId { get; set; }

    public decimal? GodownId { get; set; }

    public decimal? RackId { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? GrossAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? Amount { get; set; }

    public int? SlNo { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? GoldPrice { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Mc { get; set; }

    public decimal? Mpc { get; set; }
}

using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblTempSalesDetail
{
    public decimal SalesDetailsId { get; set; }

    public decimal? SalesMasterId { get; set; }

    public decimal? DeliveryNoteDetailsId { get; set; }

    public decimal? OrderDetailsId { get; set; }

    public decimal? QuotationDetailsId { get; set; }

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

    public decimal? ExtraPrice { get; set; }

    public int? DiscountId { get; set; }

    public string? DiscountDesc { get; set; }

    public string? Extra3 { get; set; }

    public string? Extra4 { get; set; }
}

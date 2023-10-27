using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblProductTemp
{
    public decimal ProductId { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public decimal? GroupId { get; set; }

    public decimal? BrandId { get; set; }

    public decimal? UnitId { get; set; }

    public decimal? SizeId { get; set; }

    public decimal? ModelNoId { get; set; }

    public decimal? TaxId { get; set; }

    public string? TaxapplicableOn { get; set; }

    public decimal? PurchaseRate { get; set; }

    public decimal? SalesRate { get; set; }

    public decimal? Mrp { get; set; }

    public decimal? MinimumStock { get; set; }

    public decimal? MaximumStock { get; set; }

    public decimal? ReorderLevel { get; set; }

    public decimal? GodownId { get; set; }

    public decimal? RackId { get; set; }

    public bool? IsallowBatch { get; set; }

    public bool? Ismultipleunit { get; set; }

    public bool? IsBom { get; set; }

    public bool? Isopeningstock { get; set; }

    public string? Narration { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsshowRemember { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? PartNo { get; set; }

    public decimal? SalesRatePer { get; set; }
}

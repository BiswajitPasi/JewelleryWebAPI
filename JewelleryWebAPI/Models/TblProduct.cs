using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewelleryWebAPI.Models;
[Keyless]
public partial class TblProduct
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

    public int? PackageId { get; set; }

    public string? Width { get; set; }

    public string? Height { get; set; }

    public string? Depth { get; set; }

    public string? Length { get; set; }

    public int? SupplierId { get; set; }

    public decimal? Weight { get; set; }

    public decimal? GoldPrice { get; set; }

    public decimal? Mc { get; set; }

    public decimal? Mpc { get; set; }

    public decimal? TaxonP { get; set; }

    public decimal? GoldRateUsd { get; set; }

    public decimal? WeightLessPer { get; set; }

    public decimal? LessPrice { get; set; }
    [NotMapped]
    public string? brandName { get;set; }
    public IList<TblDocumentManage> documentManages { get; set; }
    [NotMapped]
    public virtual decimal? stockCount { get; set; }
    [NotMapped]
    public virtual decimal? vat { get; set; }
    [NotMapped]
    public virtual string modelName { get; set; }

}

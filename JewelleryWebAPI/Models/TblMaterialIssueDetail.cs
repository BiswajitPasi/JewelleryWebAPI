using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblMaterialIssueDetail
{
    public int Srno { get; set; }

    public int? IssueVoucherNo { get; set; }

    public int? ProductId { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Rate { get; set; }

    public int? UnitId { get; set; }

    public int? UnitConversionId { get; set; }

    public int? BatchId { get; set; }

    public int? GodownId { get; set; }

    public int? RackId { get; set; }

    public decimal? Amount { get; set; }

    public int? Slno { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}

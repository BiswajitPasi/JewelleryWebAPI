using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblProject
{
    public int Srno { get; set; }

    public string? VoucherNo { get; set; }

    public string? ProjectId { get; set; }

    public decimal? LedgerId { get; set; }

    public decimal? QuotationId { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? ProjectStart { get; set; }

    public DateTime? ProjectEnd { get; set; }

    public DateTime? ProjectComplete { get; set; }

    public DateTime? ProjectCancel { get; set; }

    public string? CancelReason { get; set; }

    public string? ProjectStatus { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public decimal? SuffixPrefixId { get; set; }

    public string? ProjectName { get; set; }
}

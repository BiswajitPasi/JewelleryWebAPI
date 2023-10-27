using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblMaterialIsuue
{
    public int Srno { get; set; }

    public int IssueVoucherNo { get; set; }

    public DateTime? IssueDate { get; set; }

    public int? EmployeeId { get; set; }

    public int? GodownId { get; set; }

    public decimal? TotalStockValue { get; set; }

    public string? Naration { get; set; }

    public int? UserId { get; set; }

    public int? FinancialYearId { get; set; }

    public string? Status { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}

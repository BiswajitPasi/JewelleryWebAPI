using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblMobileReport
{
    public int? SalesMasterId { get; set; }

    public string? VoucherNo { get; set; }

    public string? InvoiceNo { get; set; }

    public string? ProductName { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Qty { get; set; }

    public decimal? GrossAmount { get; set; }

    public decimal? Discount { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? Date { get; set; }

    public int? EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? Extra1 { get; set; }

    public string? PaymentMode { get; set; }

    public int? ShiftId { get; set; }

    public int? LedgerId { get; set; }

    public int? GroupId { get; set; }
}

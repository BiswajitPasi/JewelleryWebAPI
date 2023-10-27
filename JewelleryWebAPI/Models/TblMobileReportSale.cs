using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblMobileReportSale
{
    public int SalesMasterId { get; set; }

    public string? VoucherNo { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? OrderNo { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? BillDiscount { get; set; }

    public decimal? TaxAmtOnBill { get; set; }

    public decimal? GrandTotal { get; set; }

    public decimal? BalanceDue { get; set; }

    public string? Extra1 { get; set; }

    public string? PaymentMode { get; set; }

    public int? ShiftId { get; set; }

    public int? LedgerId { get; set; }

    public int? EmployeeId { get; set; }
}

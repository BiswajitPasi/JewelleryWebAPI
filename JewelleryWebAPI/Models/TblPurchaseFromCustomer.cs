using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblPurchaseFromCustomer
{
    public int Srno { get; set; }

    public string? VoucherNo { get; set; }

    public string? InvoiceNo { get; set; }

    public int? SuffixPrefixId { get; set; }

    public int? VoucherTypeId { get; set; }

    public int? LedgerId { get; set; }

    public decimal? PurchaseAccount { get; set; }

    public DateTime Date { get; set; }

    public bool? Ptype { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? GoldPrice { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Vat { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? OldGoldValue { get; set; }

    public decimal? FinalAmount { get; set; }

    public decimal? PaidAmount { get; set; }

    public decimal? BalanceAmount { get; set; }

    public string? CreditPurchase { get; set; }

    public string? CreditSale { get; set; }

    public decimal? TotalOldWeight { get; set; }

    public decimal? TotalNewWeight { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public DateTime? ExtraDate { get; set; }

    public decimal? FinancialYearId { get; set; }

    public string? Narration { get; set; }

    public decimal? UserId { get; set; }
}

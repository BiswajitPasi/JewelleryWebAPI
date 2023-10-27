using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblPurchaseMaster
{
    public decimal PurchaseMasterId { get; set; }

    public string? VoucherNo { get; set; }

    public string? InvoiceNo { get; set; }

    public decimal? SuffixPrefixId { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public DateTime? Date { get; set; }

    public decimal? LedgerId { get; set; }

    public string? VendorInvoiceNo { get; set; }

    public DateTime? VendorInvoiceDate { get; set; }

    public string? CreditPeriod { get; set; }

    public decimal? ExchangeRateId { get; set; }

    public string? Narration { get; set; }

    public decimal? PurchaseAccount { get; set; }

    public decimal? PurchaseOrderMasterId { get; set; }

    public decimal? MaterialReceiptMasterId { get; set; }

    public decimal? AdditionalCost { get; set; }

    public decimal? TotalTax { get; set; }

    public decimal? BillDiscount { get; set; }

    public decimal? GrandTotal { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? UserId { get; set; }

    public string? LrNo { get; set; }

    public string? TransportationCompany { get; set; }

    public decimal? FinancialYearId { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? TotalWeightReceived { get; set; }

    public decimal? TotalWeightIssued { get; set; }

    public decimal? DiffrenceWeight { get; set; }

    public decimal? ExtraGoldPriceBd { get; set; }

    public decimal? ExtraGoldValue { get; set; }

    public decimal? ExtraVatId { get; set; }

    public decimal? ExtraVat { get; set; }

    public decimal? ExtraAmount { get; set; }
}

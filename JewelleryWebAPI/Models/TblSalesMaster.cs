using System;
using System.Collections.Generic;

namespace JewelleryWebAPI.Models;

public partial class TblSalesMaster
{
    public decimal SalesMasterId { get; set; }

    public string? VoucherNo { get; set; }

    public string? InvoiceNo { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public decimal? SuffixPrefixId { get; set; }

    public DateTime? Date { get; set; }

    public int CreditPeriod { get; set; }

    public decimal? LedgerId { get; set; }

    public decimal? PricinglevelId { get; set; }

    public decimal? EmployeeId { get; set; }

    public decimal? SalesAccount { get; set; }

    public decimal? DeliveryNoteMasterId { get; set; }

    public decimal? OrderMasterId { get; set; }

    public string? Narration { get; set; }

    public string? CustomerName { get; set; }

    public decimal? ExchangeRateId { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? AdditionalCost { get; set; }

    public decimal? BillDiscount { get; set; }

    public decimal? GrandTotal { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? UserId { get; set; }

    public string? LrNo { get; set; }

    public string? TransportationCompany { get; set; }

    public decimal? QuotationMasterId { get; set; }

    public bool? Pos { get; set; }

    public decimal? CounterId { get; set; }

    public decimal? FinancialYearId { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public int? ShiftId { get; set; }

    public bool? DeliveryStatus { get; set; }

    public decimal? TenderedAmount { get; set; }

    public decimal? ChnageAmount { get; set; }

    public string? CardNo { get; set; }

    public string? SalesType { get; set; }

    public string? PaymentMode { get; set; }

    public decimal? CashAmount { get; set; }

    public decimal? CardAmount { get; set; }

    public decimal? BalanceDue { get; set; }

    public DateTime? Chequedate { get; set; }

    public string? Banknm { get; set; }

    public decimal? TotalWeight { get; set; }

    public decimal? GoldPrice { get; set; }

    public decimal? ExtraCharge { get; set; }

    public string? Canceled { get; set; }

    public string? Reason { get; set; }

    public DateTime? CanceledDate { get; set; }

    public string? CanceledBy { get; set; }
}
